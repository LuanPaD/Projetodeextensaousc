using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Admnistrativo;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using Projeto_de_Extensao.Formulários.Cadastros;
using System.Web;
using System.Data.SqlTypes;
using Microsoft.VisualBasic.Logging;

namespace Projeto_de_Extensao.Formulários.Relatórios
{
    public partial class FrmDashboard : Form
    {
        MySqlConnection conexao = ClsConexao.Conexao;


        public FrmDashboard()
        {
            InitializeComponent();
            preencheStaticValues();


        }

        private void btnDashboard_Click(object sender, EventArgs e) => tbcDashboard.SelectedTab = tabPageDashboard;

        private void btnPerguntas_Click(object sender, EventArgs e) => tbcDashboard.SelectedTab = tabPagePerguntas;



        #region Funções 
        private async Task carregaSugestoes()
        {

            gridSugestoesDash.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            string sql = @"
                SELECT a.data, s.nome AS setor,a.sugestao
                FROM sugestoes a
                JOIN setores s ON a.setor_id = s.setor_id;";
            await FrmEditarCadastroscs.CarregarDadosAsync(sql, gridSugestoesDash);
        }
        private void carregaGraficos()
        {
            try
            {
                //Gráfico : Distribuição de Atendentes por Setor
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
                chtGrafico1.Series["Atendentes por Setor"].Color = Color.Red;

            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao obter dados: " + err.Message);
            }
        }


        private async void preencheStaticValues()
        {
            int totalAdministradores = GetTotal("SELECT COUNT(ADMIN_ID) FROM ADMIN");
            int totalAtendentesAvaliados = GetTotal("SELECT COUNT(DISTINCT ATENDENTE_ID) FROM AVALIACAO;");
            int totalSetores = GetTotal("SELECT COUNT(SETOR_ID) FROM SETORES;");
            int totalAvaliacoes = GetTotal("SELECT COUNT(avaliacao_id) FROM AVALIACAO; ");

            lblTotalAtendentesAvaliados.Text = totalAtendentesAvaliados.ToString();
            lblTotalSetoresCadastrados.Text = totalSetores.ToString();
            lblTotalDeAvaliacoes.Text = totalAvaliacoes.ToString();
            lblTotalAdmin.Text = totalAdministradores.ToString();

            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetores);
            carregaGraficos();

        }

        private int GetTotal(string query)
        {
            var command = new MySqlCommand(query, conexao);
            return Convert.ToInt32(command.ExecuteScalar());
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
        private async void FiltraSugestao(DateTime dataInicial, DateTime dataFinal, int? setorId)
        {
            dataInicial = dataInicial.Date;
            dataFinal = dataFinal.Date.AddDays(1).AddSeconds(-1);

            string sql = @"SELECT a.data, s.nome AS setor, a.sugestao
                   FROM sugestoes a
                   JOIN setores s ON a.setor_id = s.setor_id
                   WHERE a.data BETWEEN @dataInicial AND @dataFinal";

            if (setorId.HasValue)
            {
                sql += " AND s.setor_id = @setorId";
            }

            using (var conexao = new MySqlConnection(ClsConexao.connectionString))
            {
                using (var comando = new MySqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@dataInicial", dataInicial);
                    comando.Parameters.AddWithValue("@dataFinal", dataFinal);

                    if (setorId.HasValue)
                    {
                        comando.Parameters.AddWithValue("@setorId", setorId.Value);
                    }

                    await conexao.OpenAsync();
                    using (var reader = await comando.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader); 

                        gridSugestoesDash.DataSource = dt;
                    }
                }
            }
        }

        #endregion

        #region Eventos

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


        #endregion

        private void btnVoltarParaMenu_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.ShowDialog();
            this.Hide();
        }

        private async void btnSugestoes_Click(object sender, EventArgs e)
        {
            tbcDashboard.SelectedTab = tabPageSugestoes;
            await carregaSugestoes();
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetoresSugestoes);
        }

        private void btnCarregarSetoresSugestao_Click(object sender, EventArgs e)
        {
            if (dataInicialSugestoes.Value == DateTime.MinValue || dataFinalSugestoes.Value == DateTime.MinValue)
            {
                MessageBox.Show("Por favor, selecione ambas as datas (inicial e final).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataFinalSugestoes.Value < dataInicialSugestoes.Value)
            {
                MessageBox.Show("A data final não pode ser anterior à data inicial.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataInicial = dataInicialSugestoes.Value;
            DateTime dataFinal = dataFinalSugestoes.Value;

            int setorId = (int)cmbSetoresSugestoes.SelectedValue;

            FiltraSugestao(dataInicial, dataFinal, setorId == 0 ? null : setorId);
        }


    }
}
