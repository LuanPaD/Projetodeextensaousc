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
            FrmPergunta form = new FrmPergunta();
            form.ShowDialog();

            this.Dispose();
        }
    }
}
