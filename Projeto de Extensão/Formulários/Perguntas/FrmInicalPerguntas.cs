using Projeto_de_Extensão.Formulários.Perguntas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Perguntas
{
    public partial class FrmInicalPerguntas : Form
    {
        public FrmInicalPerguntas()
        {
            InitializeComponent();
        }

        private void bntInicar_Click(object sender, EventArgs e)
        {
            FrmEscolhaSetorAvaliacao FrmEscolhaSetorAvaliacao = new FrmEscolhaSetorAvaliacao();
            FrmEscolhaSetorAvaliacao.ShowDialog();

            this.Dispose();
        }
    }
}
