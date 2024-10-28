using MySqlConnector;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmLogin : Form
    {
        // Substitua pela sua connectionString correta
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=avaliacaoatendimento;User=root;Password=1234;";

        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim(); // Use txtEmail.Text para capturar o e-mail
            string senha = txtSenha.Text.Trim();

            // Verifica se os campos foram preenchidos
            if (!camposPreenchidos(usuario, senha))
            {
                return;
            }

            // Chama o método de login para verificar se o usuário e a senha estão corretos
            bool loginValido = await Login(usuario, senha);

            if (loginValido)
            {
                // Aqui você pode abrir uma nova janela ou redirecionar o usuário
                FrmCadastros frmCadastros = new FrmCadastros();
                frmCadastros.Show();

                // Esconde a janela de login
                this.Hide();
            }
            else
            {
                lblErro.Text = "Senha ou usuário incorreto.";
            }
        }

        private async Task<bool> Login(string email, string senha)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                await conexao.OpenAsync();

                string query = "SELECT COUNT(*) FROM admin WHERE email = @Email AND senha = @Senha";
                using (var comando = new MySqlCommand(query, conexao))
                {
                    // Adiciona os parâmetros para evitar SQL Injection
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senha); // Lembre-se de considerar o uso de hashing para senhas!

                    // Executa a consulta e obtém o número de registros
                    var resultado = await comando.ExecuteScalarAsync();
                    return Convert.ToInt32(resultado) > 0; // Retorna true se existe um usuário correspondente
                }
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
