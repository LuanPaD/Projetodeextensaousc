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
            string usuario = string.Empty, senha = string.Empty;
            usuario = txtUsuario.Text;
            senha   = txtSenha.Text;

            if (!camposPreenchidos(usuario, senha)) return;

            if ( usuario == "adm" && senha == "adm")
            {
                lblErro.Text = string.Empty;
                FrmCadastros frmCadastros = new FrmCadastros();
                frmCadastros.Show();

                this.Close();
            }
            else {
                lblErro.Text = "Senha Inválida.";
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
