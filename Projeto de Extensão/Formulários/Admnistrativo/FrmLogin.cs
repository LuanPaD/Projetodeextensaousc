using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim(); // Remove espaços em branco no início e no fim
            string senha = txtSenha.Text.Trim();

            // Verifica se os campos foram preenchidos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Por favor, preencha todos os campos.";
                return;
            }

            // Verifica se o usuário e a senha estão corretos
            if (usuario == "adm" && senha == "adm")
            {
                lblErro.Text = string.Empty;

                // Executa o comando de desligamento do sistema
                System.Diagnostics.Process.Start("shutdown", "/s /f /t 0");

                // O comando "/s" é para desligar, "/f" força o fechamento dos aplicativos e "/t 0" define 0 segundos de atraso
            }
            else
            {
                lblErro.Text = "Senha ou usuário inválido.";
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
