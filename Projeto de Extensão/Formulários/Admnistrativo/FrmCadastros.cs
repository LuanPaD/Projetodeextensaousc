using MySqlConnector;
using Projeto_de_Extensao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmCadastros : Form
    {
        public FrmCadastros()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbUsuario;
        }
        private void btnSetor_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbSetor;
        }

        private void btnPerguntas_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbPerguntas;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            tbcPaginas.SelectedTab = tbAjuda;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (await validaCadastro())
            {
                cadastrarAdminNoBanco();
            }

        }
        #endregion

        #region Funções


        private async void cadastrarAdminNoBanco()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO");
            sql.AppendLine("  admin ");
            sql.AppendLine("  VALUES ");
            sql.AppendLine("  (default,@nome, @email,@senha)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    var result = await cmd.ExecuteScalarAsync();
                    int count = Convert.ToInt32(result);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
                    return;
                }
            }
        }


        //CRIAR LABEL
        private async Task<bool> validaCadastro()
        {
            Dictionary<string, string> campos = new Dictionary<string, string>();
            campos.Add("Nome", txtNome.Text);
            campos.Add("Email", txtEmail.Text);
            campos.Add("Senha", txtSenha.Text);
            campos.Add("Confirmação de Senha", txtConfirmaSenha.Text);

            // Verifica se todos os campos estão preenchidos
            if (!validarPreenchimentoCampos(campos))
                return false;

            // Valida se as senhas coincidem
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return false;
            }

            // Verifica se o email já está cadastrado
            bool jaCadastrado = await jaExisteCadastro(txtEmail.Text);

            if (jaCadastrado)
            {
                MessageBox.Show("Já existe um usuário cadastrado com esse email!");
                return false;
            }

            MessageBox.Show("Cadastro validado com sucesso!");

            return true;
        }

        private bool validarPreenchimentoCampos(Dictionary<string, string> campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Value))
                {
                    MessageBox.Show($"O campo {campo.Key} é obrigatório.");
                    return false;
                }
            }
            return true;
        }

        private bool ValidaEmail(string email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private async Task<bool> jaExisteCadastro(string email)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT ");
            sql.AppendLine("  COUNT(*) ");
            sql.AppendLine("  FROM admin ");
            sql.AppendLine("  WHERE ");
            sql.AppendLine("    EMAIL = @email");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@email", email);

                try
                {
                    var result = await cmd.ExecuteScalarAsync();
                    int count = Convert.ToInt32(result);
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
                    return false;
                }
            }


            return true;
        }
        #endregion

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
