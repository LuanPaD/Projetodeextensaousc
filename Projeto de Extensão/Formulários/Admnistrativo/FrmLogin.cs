﻿using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim(); 
            string senha = txtSenha.Text.Trim();

            if (!camposPreenchidos(usuario, senha))
            {
                return;
            }

            bool loginValido = await Login(usuario, senha);

            if (loginValido)
            {
                /*FrmCadastros frmCadastros = new FrmCadastros();
                frmCadastros.Show();
                */

                FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
                frmEscolhaInicial.Show();

                this.Hide();
            }
            else
            {
                lblErro.Text = "Usuário ou Senha incorreto.";
            }
        }

        private async Task<bool> Login(string email, string senha)
        {
            var conexao = ClsConexao.Conexao;

            string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND senha = @Senha";
            using (var comando = new MySqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@Email", email);
                comando.Parameters.AddWithValue("@Senha", senha); 

                var resultado = await comando.ExecuteScalarAsync();
                return Convert.ToInt32(resultado) > 0; 
            }
        }

        private bool camposPreenchidos(string usuario, string senha)
        {
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Preencha usuário e senha antes de avançar.";
                return false;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                lblErro.Text = "Preencha o usuário antes de avançar.";
                return false;
            }

            if (string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Preencha a senha antes de avançar.";
                return false;
            }

            lblErro.Text = string.Empty;
            return true;
        }
    }
}
