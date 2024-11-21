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
    public partial class FrmAgradecimento : Form
    {
        public FrmAgradecimento()
        {
            InitializeComponent();
        }

        private void bntInicar_Click(object sender, EventArgs e)
        {
            FrmInicalPerguntas frmInicalPerguntas = new FrmInicalPerguntas();
            frmInicalPerguntas.ShowDialog();
            this.Hide();
        }
    }
}
