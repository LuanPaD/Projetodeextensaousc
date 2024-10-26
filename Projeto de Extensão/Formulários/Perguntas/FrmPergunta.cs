using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensão.Formulários.Perguntas
{
    public partial class FrmPergunta : Form
    {
        public FrmPergunta()
        {
            InitializeComponent();
        }

        private void FrmPergunta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeiraOpcao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {

        }

        private void lblPergunta_Click(object sender, EventArgs e)
        {

        }


        private void ResetButtons()
        {
            // Restaura os botões à cor padrão
            btnOpcao1.BackColor = SystemColors.Control;
            btnOpcao1.ForeColor = SystemColors.ControlText;

            btnOpcao2.BackColor = SystemColors.Control;
            btnOpcao2.ForeColor = SystemColors.ControlText;

            btnOpcao3.BackColor = SystemColors.Control;
            btnOpcao3.ForeColor = SystemColors.ControlText;

            btnOpcao4.BackColor = SystemColors.Control;
            btnOpcao4.ForeColor = SystemColors.ControlText;
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnOpcao1.BackColor = Color.Red;
            btnOpcao1.ForeColor = Color.White;
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnOpcao2.BackColor = Color.Red;
            btnOpcao2.ForeColor = Color.White;
        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnOpcao3.BackColor = Color.Red;
            btnOpcao3.ForeColor = Color.White;
        }

        private void btnOpcao4_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnOpcao4.BackColor = Color.Red;
            btnOpcao4.ForeColor = Color.White;
        }

        
    }
}
