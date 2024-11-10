using MySqlConnector;
using Projeto_de_Extensao.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projeto_de_Extensao.Formulários.Relatórios
{
    public partial class FrmGraficos : Form
    {
        public FrmGraficos()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void LoadCharts()
        {
            var conexao = ClsConexao.Conexao;

            try
            {
                // Gráfico 1: Total de Atendentes e Administradores
                int totalAtendentes = GetTotal("SELECT COUNT(*) FROM atendente;", conexao);
                int totalAdmins = GetTotal("SELECT COUNT(*) FROM admin;", conexao);

                chtGrafico.Series.Clear();
                chtGrafico.Series.Add("Total");
                chtGrafico.Series["Total"].ChartType = SeriesChartType.Column;
                chtGrafico.Series["Total"].IsXValueIndexed = true;
                chtGrafico.Series["Total"].Points.AddXY("Atendentes", totalAtendentes);
                chtGrafico.Series["Total"].Points.AddXY("Administradores", totalAdmins);
                chtGrafico.Titles.Clear();
                chtGrafico.Titles.Add("Total de Atendentes e Administradores");
                chtGrafico.Series["Total"].Color = Color.Blue;

                // Gráfico 2: Distribuição de Atendentes por Setor
                chtGrafico1.Series.Clear();
                chtGrafico1.Series.Add("Atendentes por Setor");
                chtGrafico1.Series["Atendentes por Setor"].ChartType = SeriesChartType.Bar;
                chtGrafico1.Series["Atendentes por Setor"].IsXValueIndexed = true;

                string querySetores = @"
                    SELECT setores.nome AS setor_nome, COUNT(atendente.atendente_id) AS total
                    FROM setores
                    LEFT JOIN atendente ON atendente.setor_id = setores.setor_id
                    GROUP BY setores.nome;";

                var commandSetores = new MySqlCommand(querySetores, conexao);
                var readerSetores = commandSetores.ExecuteReader();

                while (readerSetores.Read())
                {
                    string setorNome = readerSetores["setor_nome"].ToString();
                    int total = Convert.ToInt32(readerSetores["total"]);
                    chtGrafico1.Series["Atendentes por Setor"].Points.AddXY(setorNome, total);
                }
                readerSetores.Close();

                if (chtGrafico1.Series["Atendentes por Setor"].Points.Count == 0)
                {
                    chtGrafico1.Series["Atendentes por Setor"].Points.AddXY("Nenhum Atendente", 0);
                }

                chtGrafico1.Titles.Clear();
                chtGrafico1.Titles.Add("Atendentes por Setor");
                chtGrafico1.Series["Atendentes por Setor"].Color = Color.Green;

                // Gráfico 3: Distribuição de Administradores por Domínio de Email
                chtGrafico2.Series.Clear();
                chtGrafico2.Series.Add("Administradores por Domínio");
                chtGrafico2.Series["Administradores por Domínio"].ChartType = SeriesChartType.Pie;
                chtGrafico2.Series["Administradores por Domínio"].IsValueShownAsLabel = true;

                string queryAdminsDistribuicao = @"
                    SELECT SUBSTRING_INDEX(email, '@', -1) AS dominio, COUNT(*) AS total
                    FROM admin
                    GROUP BY dominio;";

                var commandAdminsDistribuicao = new MySqlCommand(queryAdminsDistribuicao, conexao);
                var readerAdmins = commandAdminsDistribuicao.ExecuteReader();

                while (readerAdmins.Read())
                {
                    string dominio = readerAdmins["dominio"].ToString();
                    int total = Convert.ToInt32(readerAdmins["total"]);
                    chtGrafico2.Series["Administradores por Domínio"].Points.AddXY(dominio, total);
                }
                readerAdmins.Close();

                if (chtGrafico2.Series["Administradores por Domínio"].Points.Count == 0)
                {
                    chtGrafico2.Series["Administradores por Domínio"].Points.AddXY("Nenhum Administrador", 0);
                }

                chtGrafico2.Titles.Clear();
                chtGrafico2.Titles.Add("Distribuição de Administradores por Domínio de Email");
                chtGrafico2.Series["Administradores por Domínio"].Color = Color.Red;

                // Gráfico 4: Distribuição de Atendentes por Setor (Gráfico de Setores)
                chtGrafico3.Series.Clear();
                chtGrafico3.Series.Add("Distribuição de Atendentes");
                chtGrafico3.Series["Distribuição de Atendentes"].ChartType = SeriesChartType.Pie;
                chtGrafico3.Series["Distribuição de Atendentes"].IsValueShownAsLabel = true;

                // Reutilizando a consulta de setores para o gráfico de setores
                commandSetores = new MySqlCommand(querySetores, conexao);
                readerSetores = commandSetores.ExecuteReader();

                while (readerSetores.Read())
                {
                    string setorNome = readerSetores["setor_nome"].ToString();
                    int total = Convert.ToInt32(readerSetores["total"]);
                    chtGrafico3.Series["Distribuição de Atendentes"].Points.AddXY(setorNome, total);
                }
                readerSetores.Close();

                if (chtGrafico3.Series["Distribuição de Atendentes"].Points.Count == 0)
                {
                    chtGrafico3.Series["Distribuição de Atendentes"].Points.AddXY("Nenhum Atendente", 0);
                }

                chtGrafico3.Titles.Clear();
                chtGrafico3.Titles.Add("Distribuição de Atendentes por Setor (Gráfico de Setores)");
                // cores para o gráfico de setores
                chtGrafico3.Series["Distribuição de Atendentes"].Points[0].Color = Color.Orange;
                if (chtGrafico3.Series["Distribuição de Atendentes"].Points.Count > 1)
                {
                    chtGrafico3.Series["Distribuição de Atendentes"].Points[1].Color = Color.Purple;
                }
                if (chtGrafico3.Series["Distribuição de Atendentes"].Points.Count > 2)
                {
                    chtGrafico3.Series["Distribuição de Atendentes"].Points[2].Color = Color.Yellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private int GetTotal(string query, MySqlConnection conexao)
        {
            var command = new MySqlCommand(query, conexao);
            return Convert.ToInt32(command.ExecuteScalar());
        }
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            var excelExporter = new EXCELgerador();
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string filePath = Path.Combine(downloadsPath, "Dados.xlsx");
            DataTable data = GetData(); 
            excelExporter.Export(data, filePath);
            MessageBox.Show("Arquivo Excel gerado com sucesso em:\n" + filePath);
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            var pdfExporter = new PDFgerador();
            string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            string filePath = Path.Combine(downloadsPath, "Dados.pdf");
            DataTable data = GetData();
            pdfExporter.Export(data, filePath);
            MessageBox.Show("Arquivo PDF gerado com sucesso em:\n" + filePath);
        }

        private DataTable GetData()
        {
            var conexao = ClsConexao.Conexao;
            DataTable admins = new DataTable();
            try
            {
                string queryAdminsDistribuicao = @"SELECT NOME, EMAIL FROM ADMIN;";
                var commandAdmin = new MySqlCommand(queryAdminsDistribuicao, conexao);
                var readerAdmins = commandAdmin.ExecuteReader();

                admins.Load(readerAdmins);
                readerAdmins.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }

            return admins;
        }


    }
}
