using Projeto_de_Extensao.Formulários.Admnistrativo;
using Projeto_de_Extensão.Formulários.Perguntas;

namespace Projeto_de_Extensão
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            FrmPergunta frmPergunta = new FrmPergunta();
            frmPergunta.ShowDialog();

            //this.Dispose();
        }

        private void btnAdmnistrador_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin= new FrmLogin();
            frmLogin.Show();
            //this.Dispose();
        }
    }
}
