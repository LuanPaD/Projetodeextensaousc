using Microsoft.VisualBasic;
using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            escondeAlternativasAdicionais();
        }

        #region Eventos
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Troca de páginas
        private void btnAdmin_Click(object sender, EventArgs e) => tbcPaginas.SelectedTab = tbAdmin;
        private void btnSetor_Click(object sender, EventArgs e) => tbcPaginas.SelectedTab = tbSetor;
        private void btnPerguntas_Click(object sender, EventArgs e) => tbcPaginas.SelectedTab = tbPerguntas;

        private async void btnAtendente_Click(object sender, EventArgs e)
        {
            await ListaTodosOsSetoresAsync(cmbListaDeSetores);
            tbcPaginas.SelectedTab = tbAtendente;
        }



        //Efetua o Cadastro
        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (await validaCadastro())
                cadastrarAdminNoBanco();
        }
        private void btnCadastraAtendente_Click(object sender, EventArgs e)
        {
            cadastraAtendenteNoBanco();
        }
        private async void btnCadastrarSetor_Click(object sender, EventArgs e)
        {
            string nome = txtNomeSetor.Text;

            if (!string.IsNullOrEmpty(nome))
            {
                bool existe = await JaExisteCadastroNomeSetor(nome);
                if (!existe)
                {
                    cadastraSetorNoBanco();
                    txtNomeSetor.Text = string.Empty;
                    MessageBox.Show("Cadastro realizado.");
                }
                else
                {
                    lblErroSetor.Text = "Já existe um setor com esse nome.";
                }
            }
            else
            {
                lblErroSetor.Text = "Digite o nome do Setor.";
            }
        }

        private void btnAdicionarAlternativa_Click(object sender, EventArgs e)
        {
            mostrarPerguntaAdicional();
        }
        #endregion

        #region Funções

        /**
         * Esconde os txt 3 até o 10
         */
        private void escondeAlternativasAdicionais()
        {
            for (int i = 3; i <= 10; i++)
            {
                var textBoxAlternativa = this.Controls.Find($"txtAlternativa{i}", true).FirstOrDefault();

                if (textBoxAlternativa != null)
                {
                    textBoxAlternativa.Visible = false;
                }
            }
        }

        /**
         * Econtra o ultimo txt Visivel e mostra o proximo
         */
        private void mostrarPerguntaAdicional()
        {
            int numAlternativaVisivel = 0;

            for (int i = 0; i <= 10; i++)
            {
                var textBoxAlternativa = this.Controls.Find($"txtAlternativa{i}", true).FirstOrDefault();

                if (textBoxAlternativa != null)
                {
                    if (textBoxAlternativa.Visible)
                    {
                        numAlternativaVisivel = i;
                    }
                }
            }

            if (numAlternativaVisivel != 10)
            {
                var proximoTxt = this.Controls.Find($"txtAlternativa{numAlternativaVisivel + 1}", true).FirstOrDefault();
                proximoTxt.Visible = true;
            }
            else
            {
                MessageBox.Show("O número máximo de alternativas é 10!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Precisa SER ALTERADO - FAZER UMA LISTA COM TODOS OS SETORES DISPONIVEIS NO BANCO 
        private async void cadastraAtendenteNoBanco()
        {
            string nome = txtNome2.Text;
            string email2 = txtEmail2.Text;
            string setor = cmbListaDeSetores.SelectedValue?.ToString() ?? "0";

            lblErro2.Text = string.Empty;

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
                lblErro2.Text = "E-mail inválido.";
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
                        cmbListaDeSetores.SelectedIndex = 0;
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


        private async void cadastraSetorNoBanco()
        {
            string nome = txtNomeSetor.Text.ToUpper();

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO setores (nome) VALUES (@nome)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("nome", nome);

                try
                {
                    var result = await cmd.ExecuteScalarAsync();
                    int count = Convert.ToInt32(result);
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao verificar cadastro:" + ex.Message);
                    return;
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

        private async Task<bool> validaCadastro()
        {
            Dictionary<string, string> campos = new Dictionary<string, string>();
            campos.Add("Nome", txtNome.Text);
            campos.Add("Email", txtEmail.Text);
            campos.Add("Senha", txtSenha.Text);
            campos.Add("Confirmação de Senha", txtConfirmaSenha.Text);

            if (!ValidaEmail(txtEmail.Text))
            {
                lblErro.Text = ("E-mail inválido.");
                return false;
            }
            if (!validarPreenchimentoCampos(campos))
                return false;
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                lblErro.Text = ("As senhas não coincidem.");
                return false;
            }
            bool jaCadastrado = await JaExisteCadastroEmailAdmin(txtEmail.Text);
            if (jaCadastrado)
            {
                lblErro.Text = ("E-mail já cadastrado.");
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
                    lblErro.Text = ($"O campo {campo.Key} é obrigatório.");
                    return false;
                }
            }
            return true;
        }
        public static bool ValidaEmail(string email)
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

        // Função para verificar se já existe um registro
        public static async Task<bool> ExisteCadastroAsync(string tableName, string columnName, string value)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @value");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@value", value);

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
        }
        public static async Task<bool> JaExisteCadastroNomeSetor(string nome)
        {
            return await ExisteCadastroAsync("setores", "NOME", nome);
        }
        public static async Task<bool> JaExisteCadastroEmailAdmin(string email)
        {
            return await ExisteCadastroAsync("admin", "EMAIL", email);
        }

        #endregion

        private void btnVoltarParaMenu_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.Show();

            this.Hide();
        }

        // LISTA TODOS OS SETORES NO COMBOX
        public static async Task ListaTodosOsSetoresAsync(ComboBox comboBox)
        {
            string sql = "SELECT * FROM setores";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        var setores = new List<DictionaryEntry>
                        {
                            new DictionaryEntry(0, "--SELECIONE--")
                        };

                        while (await reader.ReadAsync())
                        {
                            int setorId = reader.GetInt32("setor_id");
                            string nomeSetor = reader.GetString("nome");

                            setores.Add(new DictionaryEntry(setorId, nomeSetor));
                        }

                        comboBox.DataSource = setores;
                        comboBox.DisplayMember = "Value";
                        comboBox.ValueMember = "Key";

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao listar setores: " + ex.Message);
            }
        }

        private async void btnCadastrarPergunta_Click(object sender, EventArgs e)
        {
            string pergunta = txtPergunta.Text;
            List<string> alternativas = getAlternativasRespondidas();

            if (alternativas.Count < 1) return;

            int idPergunta = await inserePergunta(pergunta);

            if (idPergunta == 0) return;

            insereOpcoes(1, alternativas);

        }

        private List<string> getAlternativasRespondidas()
        {
            int numUltimaAlternativaVisivel = 0;
            bool todasAlternativasPreenchidas = true;
            List<string> alternativas = new List<string>();

            for (int i = 0; i <= 10; i++)
            {
                var textBoxAlternativa = this.Controls.Find($"txtAlternativa{i}", true).FirstOrDefault();

                if (textBoxAlternativa != null)
                {
                    if (textBoxAlternativa.Visible)
                    {
                        numUltimaAlternativaVisivel = i;
                        if (string.IsNullOrWhiteSpace(textBoxAlternativa.Text))
                        {
                            todasAlternativasPreenchidas = false;
                        }
                    }
                }
            }

            if (todasAlternativasPreenchidas == false)
            {
                MessageBox.Show("Preencha todos os campos antes de realizar o cadastro.", "Cadastro Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return alternativas;
            }

            for (int numAlterntativa = 0; numAlterntativa <= numUltimaAlternativaVisivel; numAlterntativa++)
            {
                var textBoxAlternativa = this.Controls.Find($"txtAlternativa{numAlterntativa}", true).FirstOrDefault();
                if (textBoxAlternativa != null)
                    alternativas.Add(textBoxAlternativa.Text);
            }

            return alternativas;
        }

        private async Task<int> inserePergunta(string pergunta)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO perguntas (texto) VALUES (@pergunta)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@pergunta", pergunta);

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                    // Recupera o ID do último registro inserido
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    int perguntaId = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    //MessageBox.Show("Pergunta inserida com sucesso! ");
                    return perguntaId;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao inserir a pergunta: " + ex.Message);
                    return 0;
                }
            }
        }
        /*********
         * 
         * 
         * REVER O PQ DA COLUNA VALOR NA TABELA OPCOES
         * 
         * 
         * 
         **********/
        private async void insereOpcoes(int id, List<string> alternativas)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO opcoes (pergunta_id, texto, valor) VALUES (@pergunta_id, @texto, @valor)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                for (int i = 0; i < alternativas.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@texto", alternativas[i]);
                    cmd.Parameters.AddWithValue("@pergunta_id", id);
                    cmd.Parameters.AddWithValue("@valor", 1);

                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir as opções: " + ex.Message);
                        return;
                    }
                }
            }

            MessageBox.Show("Pergunta inserida com sucesso! ");

        }
    }
}
