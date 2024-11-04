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
            await CarregarDadosAsync("SELECT nome FROM setores;", GridSetores);
        }

        private async void btnCarregaAdmin_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT nome,email FROM admin;", GridAdmin);
        }

        private async void btnCarregarAtendentes_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT a.nome, s.nome AS setor, a.email
                FROM atendente a
                JOIN setores s ON a.setor_id = s.setor_id;";

            await CarregarDadosAsync(sql, GridAtendentes);
        }

        public async Task CarregarDadosAsync(string sql, DataGridView grid)
        {
            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    if (ClsConexao.Conexao.State == ConnectionState.Closed)
                    {
                        await ClsConexao.Conexao.OpenAsync();
                    }

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Configurar o DataGridView passado como parâmetro
                        grid.DataSource = dt;
                        grid.DefaultCellStyle.ForeColor = Color.Black;
                        grid.DefaultCellStyle.BackColor = Color.White;
                        grid.BackgroundColor = Color.White;
                        grid.GridColor = Color.Gray;
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
        }
    }
}
