using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmEditarCadastroscs : Form
    {
        public FrmEditarCadastroscs()
        {
            InitializeComponent();
        }

        private void btnSetor_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbSetor;
        }

        private void btnPerguntas_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbPerguntas;
        }

        private void btnCadrastoAdmin_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbAdmin;
        }




        private void btnHomeSetor_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.Show();

            this.Hide();
        }

        private void btnAtendentes_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbAtendentes;
        }

        private async void btnCarregarSetores_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT nome FROM setores;");

            try
            {
                using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
                {
                    if (ClsConexao.Conexao.State == ConnectionState.Closed)
                    {
                        await ClsConexao.Conexao.OpenAsync();
                    }

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        GridSetores.DataSource = dt;

                        
                        GridSetores.DefaultCellStyle.ForeColor = Color.Black; 
                        GridSetores.DefaultCellStyle.BackColor = Color.White; 
                        GridSetores.BackgroundColor = Color.White; 
                        GridSetores.GridColor = Color.Gray; 
                        GridSetores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
            finally
            {
                if (ClsConexao.Conexao.State == ConnectionState.Open)
                {
                    ClsConexao.Conexao.Close();
                }
            }
        }


    }
}
