using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Admnistrativo;
using Projeto_de_Extensão.Formulários.Perguntas;

namespace Projeto_de_Extensão
{
    public partial class FrmMain : Form
    {
        ClsConexao conexao = new ClsConexao();

        public FrmMain()
        {
            InitializeComponent();
            abreConexao();
        }

        private async void abreConexao()
        {
            await conexao.GetConexao();

            if (!ClsConexao.ConexaoAtiva())
            {
                MessageBox.Show("Não há conexão com o banco de dados.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conectado com o banco de dados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
