using Microsoft.VisualBasic;
using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
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
        private async void btnPerguntas_Click(object sender, EventArgs e)
        {
            await ListaTodosOsSetoresAsync(cbxListaSetorPergunta);
            tbcPaginas.SelectedTab = tbPerguntas;
        }


        private async void btnAtendente_Click(object sender, EventArgs e)
        {
            await ListaTodosOsSetoresAsync(cmbListaDeSetores);
            tbcPaginas.SelectedTab = tbAtendente;
        }



        //Efetua o Cadastro
        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (await validaCadastro())
            {
                cadastrarAdminNoBanco();
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtConfirmaSenha.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
                
        }

        private async void btnCadastraAtendente_Click(object sender, EventArgs e)
        {
            int atendenteId = await cadastraAtendenteNoBanco();

            if (atendenteId > 0 && ptbImagemAtendente != null && ptbImagemAtendente.Image != null)
            {
                string nome = txtNome2.Text;
                try
                {
                    await SaveImageToDatabase(ptbImagemAtendente, atendenteId, nome);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "Erro ao realizar cadastro.");
                    return;
                }
                    ptbImagemAtendente.Image = null;

            }
            txtNome2.Text = string.Empty;
            txtEmail2.Text = string.Empty;
            cmbListaDeSetores.SelectedIndex = 0;

            await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "Cadastro realizado com sucesso");
        }



        private int UltimoAtendenteCadastrado()
        {
            int ultAtendente = 1;
            string sql = @"SELECT MAX(atendente_id) FROM atendente;";

            using (MySqlConnection conn = new MySqlConnection(ClsConexao.connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int ultimoAtendenteId = Convert.ToInt32(result);
                        ultAtendente = ultimoAtendenteId + 1;
                    }
                }
            }

            return ultAtendente;
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
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblErroSetor, "Já existe um setor com esse nome.");
                }
            }
            else
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblErroSetor, "Digite o nome do Setor.");
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


        private async Task<int> cadastraAtendenteNoBanco()
        {
            string nome = txtNome2.Text;
            string email2 = txtEmail2.Text;
            string setor = cmbListaDeSetores.SelectedValue?.ToString() ?? "0";

            lblMsgErroAtendente.Text = string.Empty;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email2) || setor.Equals("0"))
            {
                if (string.IsNullOrEmpty(nome))
                {
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "O campo Nome deve ser preenchido.\n");
                }

                if (string.IsNullOrEmpty(email2))
                {
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "O campo Email deve ser preenchido.\n");
                }

                if (setor.Equals("0"))
                {
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "Escolha um setor.\n");
                }

                return 0; // Retorna 0 em caso de erro
            }

            if (!ValidaEmail(email2))
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "E-mail inválido.");
                return 0; // Retorna 0 em caso de erro
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
                    // Executa a inserção
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    if (rowsAffected > 0)
                    {
                        // Recupera o ID do último atendente inserido
                        string sqlLastInsertId = "SELECT LAST_INSERT_ID();";
                        using (var cmdLastId = new MySqlCommand(sqlLastInsertId, ClsConexao.Conexao))
                        {
                            int atendenteId = Convert.ToInt32(await cmdLastId.ExecuteScalarAsync());
                            Console.WriteLine("Atendente cadastrado com sucesso. ID: " + atendenteId);
                            lblMsgErroAtendente.Text = string.Empty;
                            

                            // Retorna o ID do atendente
                            return atendenteId;
                        }
                    }
                    else
                    {
                        await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAtendente, "Nenhum dado foi inserido.");
                        Console.WriteLine("Nenhum dado foi inserido.");
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao cadastrar atendente: " + ex.Message);
                    return 0; // Em caso de erro, retorna 0
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
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAdmin, "E-mail inválido.");
                return false;
            }
            if (!await validarPreenchimentoCampos(campos))
                return false;
            if (txtSenha.Text != txtConfirmaSenha.Text)
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAdmin, "As senhas não coincidem.");
                return false;
            }
            bool jaCadastrado = await JaExisteCadastroEmailAdmin(txtEmail.Text);
            if (jaCadastrado)
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAdmin, "E-mail já cadastrado.");
                return false;
            }
            MessageBox.Show("Cadastro efetuado com sucesso!");
            return true;
        }
        private async Task<bool> validarPreenchimentoCampos(Dictionary<string, string> campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Value))
                {
                    await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblMsgErroAdmin, $"O campo {campo.Key} é obrigatório.");
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
                            new DictionaryEntry(0,"--SELECIONE--")
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
            string setorId = cbxListaSetorPergunta.SelectedValue?.ToString() ?? "0";
            string pergunta = txtPergunta.Text;
            List<string> alternativas = await GetAlternativasRespondidas();

            if (alternativas.Count == 0) return;

            if (setorId == "0")
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblErroPerguntas, "Nenhum setor foi selecionado.");
                return;
            }

            int idPergunta = await InserirPerguntaAsync(pergunta, setorId);

            if (idPergunta > 0)
            {
                await InserirOpcoesAsync(idPergunta, alternativas);
                MessageBox.Show("Pergunta inserida com sucesso!");

                for (int i = 1; i <= 10; i++)
                {
                    var txtOpcao = this.Controls["txtAlternativa" + i] as TextBox;
                    if (txtOpcao != null)
                    {
                        txtOpcao.Text = string.Empty;
                    }
                }

            }
            else
            {
                await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblErroPerguntas, "Erro ao cadastrar a pergunta.");
            }
        }

        private async Task<List<string>> GetAlternativasRespondidas()
        {
            List<string> alternativas = new List<string>();

            for (int i = 0; i <= 10; i++)
            {
                var textBoxAlternativa = this.Controls.Find($"txtAlternativa{i}", true).FirstOrDefault();

                if (textBoxAlternativa != null && textBoxAlternativa.Visible)
                {
                    if (string.IsNullOrWhiteSpace(textBoxAlternativa.Text))
                    {
                        await FrmEditarCadastroscs.ExibirMensagemTemporaria(lblErroPerguntas, "Preencha todos os campos antes de realizar o cadastro.");
                        return new List<string>();
                    }
                    alternativas.Add(textBoxAlternativa.Text);
                }
            }

            return alternativas;
        }

        private async Task<int> InserirPerguntaAsync(string pergunta, string setorId)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT COALESCE(MAX(ordem), 0) + 1 FROM perguntas WHERE setor_id = @setor");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@setor", setorId);

                try
                {
                    int novaOrdem = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    
                    cmd.CommandText = "INSERT INTO perguntas (texto, setor_id, ordem) VALUES (@pergunta, @setor, @ordem)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pergunta", pergunta);
                    cmd.Parameters.AddWithValue("@setor", setorId);
                    cmd.Parameters.AddWithValue("@ordem", novaOrdem);

                    await cmd.ExecuteNonQueryAsync();

                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    return Convert.ToInt32(await cmd.ExecuteScalarAsync());
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao inserir a pergunta: " + ex.Message);
                    return 0;
                }
            }
        }


        private async Task InserirOpcoesAsync(int perguntaId, List<string> alternativas)
        {
            string setorId = cbxListaSetorPergunta.SelectedValue?.ToString() ?? "0";
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO opcoes (pergunta_id, texto, setor_id) VALUES (@pergunta_id, @texto, @setor_id)");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                foreach (string alternativa in alternativas)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pergunta_id", perguntaId);
                    cmd.Parameters.AddWithValue("@texto", alternativa);
                    cmd.Parameters.AddWithValue("@setor_id", setorId);

                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao inserir as opções: " + ex.Message);
                        break;
                    }
                }
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            SelecionaImagem(ptbImagemAtendente);
        }

        public static void SelecionaImagem(PictureBox picture)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = Image.FromFile(ofd.FileName);
                }
            }
        }


        //DELETAR COLUNA NOME  -- SEM NECESSIDADE DEVIVO A TER A COLUNA ATENDETE_ID e TBM NN CONSEGUI PASSAR O NOME

        /*********
         * 
         * 
         * REVER O PQ DA COLUNA VALOR NA TABELA OPCOES
         * 
         * NN TEM NENHUMA EXPLICAÇÃO POSSÍVEL PRA ELA EXISTIR
         * 
         * ALTER TABLE opcoes
           RENAME COLUMN valor to setor_id;
           Como vai ser necessário criar perguntas para cada setor acho melhor alterar esse valor para setor_id
         */

        private async Task SaveImageToDatabase(PictureBox picture, int atendenteId, string nome)
        {
            if (picture.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picture.Image.Save(ms, picture.Image.RawFormat);
                        byte[] imageBytes = ms.ToArray();

                        string sql = @"
                        INSERT INTO fotos (atendente_id, nome, tamanho, dataUpload, imagem)
                            VALUES (@atendente_id, @nome, @tamanho, @dataUpload, @imagem)
                            ON DUPLICATE KEY UPDATE
                            nome = @nome,
                            tamanho = @tamanho,
                            dataUpload = @dataUpload,
                            imagem = @imagem;";

                        using (var connection = new MySqlConnection(ClsConexao.connectionString))
                        {
                            await connection.OpenAsync();

                            using (var cmd = new MySqlCommand(sql, connection))
                            {
                                cmd.Parameters.AddWithValue("@atendente_id", atendenteId);
                                cmd.Parameters.AddWithValue("@nome", $"{nome}_{atendenteId}");
                                cmd.Parameters.AddWithValue("@tamanho", imageBytes.Length);
                                cmd.Parameters.AddWithValue("@dataUpload", DateTime.Now);
                                cmd.Parameters.AddWithValue("@imagem", imageBytes);

                                int rowsAffected = await cmd.ExecuteNonQueryAsync();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar a imagem: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Imagem não selecionada.");
            }

        }
    }
}
