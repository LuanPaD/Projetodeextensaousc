using Microsoft.VisualBasic;
using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void button1_Click(object sender, EventArgs e)
        {

            cadastraAtendenteNoBanco();

        }


        #endregion

        #region Funções

        //armazena o valor do botão selecionado

        private Button botaoSelecionado;


        private void ResetButtons()
        {
            // Restaura os botões à cor padrão
            btnSecretaria.BackColor = SystemColors.Control;
            btnSecretaria.ForeColor = SystemColors.ControlText;

            btnFinanceiro.BackColor = SystemColors.Control;
            btnFinanceiro.ForeColor = SystemColors.ControlText;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnFinanceiro.BackColor = Color.Red;
            btnFinanceiro.ForeColor = Color.White;

            botaoSelecionado = btnFinanceiro;
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            ResetButtons();
            btnSecretaria.BackColor = Color.Red;
            btnSecretaria.ForeColor = Color.White;

            botaoSelecionado = btnSecretaria;
        }
        private int ObterSetorId()
        {
            if (botaoSelecionado == null)
            {
                lblErro2.Text = "Nenhum botão foi selecionado.";
                return 0;
            }

            if (botaoSelecionado.Text == "Secretaria")
            {
                return 1;
            }
            else if (botaoSelecionado.Text == "Financeiro")
            {
                return 2;
            }
            return 0;
        }

        private async void cadastraAtendenteNoBanco()
        {
            string nome = txtNome2.Text;
            string email2 = txtEmail2.Text;
            string setor = ObterSetorId().ToString(); // Obtém o texto do botão selecionado

            // Limpa mensagens de erro anteriores
            lblErro2.Text = string.Empty;

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email2) || setor.Equals("0"))
            {
                if (string.IsNullOrEmpty(nome))
                {
                    lblErro2.Text += "O campo Nome deve ser preenchido.\n";
                }

                if (string.IsNullOrEmpty(email2))
                {
                    lblErro2.Text += "O campo Email deve ser preenchido.\n";
                }

                if (setor.Equals("0"))
                {
                    lblErro2.Text += "Escolha um setor.\n";
                }

                return;
            }

            if (!ValidaEmail(email2))
            {
                lblErro2.Text = "Email inválido. Por favor, verifique e tente novamente.";
                return;
            }

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO atendente (nome, setor_id, email) VALUES (@nome, @setor, @email)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@setor", setor);
                cmd.Parameters.AddWithValue("@email", email2);

                try
                {
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso.");
                        Console.WriteLine("Cadastro realizado com sucesso.");
                        lblErro2.Text = string.Empty;
                        txtNome2.Text = string.Empty;
                        txtEmail2.Text = string.Empty;
                        lblErro2.Text = string.Empty;
                        ResetButtons();
                    }
                    else
                    {
                        lblErro2.Text = "Nenhum dado foi inserido.";
                        Console.WriteLine("Nenhum dado foi inserido.");
                    }
                }
                catch (Exception ex)
                {
                    lblErro2.Text = "Erro ao cadastrar atendente: " + ex.Message;
                    Console.WriteLine("Erro ao cadastrar atendente: " + ex.Message);
                }
            }
        }

        private async void cadastrarAdminNoBanco()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO admin (nome, email , senha) VALUES (@nome,@email,@senha)");

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

            MessageBox.Show("Cadastro efetuado com sucesso!");


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

        private void btnPaginaAtendente_Click(object sender, EventArgs e)
        {
            tbcTipoCadastro.SelectedTab = tabCadastroAtendentes;
        }

        private void btnPaginaAdmin_Click(object sender, EventArgs e)
        {
            tbcTipoCadastro.SelectedTab = tabCadastroAdmin;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT nome, email FROM admin;");

            try
            {
                using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
                {
                    // Assegure-se de que a conexão está aberta
                    if (ClsConexao.Conexao.State == ConnectionState.Closed)
                    {
                        await ClsConexao.Conexao.OpenAsync();
                    }

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        dgvUsuariosCadastrados.DataSource = dt;

                        // Ajuste para preencher todo o espaço do DataGridView
                        dgvUsuariosCadastrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
            finally
            {
                // Opcionalmente, feche a conexão se você não precisar mais dela
                if (ClsConexao.Conexao.State == ConnectionState.Open)
                {
                    ClsConexao.Conexao.Close();
                }
            }
        }

        private void btnVoltarParaMenu_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.Show();

            this.Hide();
        }
    }
}
