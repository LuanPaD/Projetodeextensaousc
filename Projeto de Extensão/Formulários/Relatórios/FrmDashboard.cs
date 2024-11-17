using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Admnistrativo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        #region Funções 
        private async void preencheStaticValues()
        {
            int totalAtendentesAvaliados = GetTotal("SELECT COUNT(DISTINCT ATENDENTE_ID) FROM AVALIACAO;");
            int totalSetores = GetTotal("SELECT COUNT(SETOR_ID) FROM SETORES;");
            int totalAvaliacoes = GetTotal("SELECT COUNT(avaliacao_id) FROM AVALIACAO; ");

            lblTotalAtendentesAvaliados.Text = totalAtendentesAvaliados.ToString();
            lblTotalSetoresCadastrados.Text = totalSetores.ToString();
            lblTotalDeAvaliacoes.Text = totalAvaliacoes.ToString();

            await FrmCadastros.ListaTodosOsSetoresAsync(cmbSetores);
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
    }
}
