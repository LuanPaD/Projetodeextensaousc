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

namespace Projeto_de_Extensao.Formulários.Cadastros
{
    public partial class FrmEscolhaInicial : Form
    {
        public FrmEscolhaInicial()
        {
            InitializeComponent();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastros frmCadastros = new FrmCadastros();
            frmCadastros.Show();

            this.Hide();
        }

        private void btnEditarCadastro_Click(object sender, EventArgs e)
        {
            FrmEditarCadastroscs frmEditarCadastroscs = new FrmEditarCadastroscs();
            frmEditarCadastroscs.Show();

            this.Hide();
        }
    }
}
