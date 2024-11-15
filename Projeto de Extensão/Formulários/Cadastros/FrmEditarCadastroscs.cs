using MySqlConnector;
using PdfSharp.Drawing.BarCodes;
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
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmEditarCadastroscs : Form
    {

        public FrmEditarCadastroscs()
        {

            InitializeComponent();

        }

        private async void ConsultaSqlPerguntas()
        {
            string sql = @"
                SELECT a.pergunta_id,a.ordem,a.texto, s.nome AS setor
                FROM perguntas a
                JOIN setores s ON a.setor_id = s.setor_id;";
            await CarregarDadosAsync(sql, GridViewPerguntas, "pergunta_id");
        }

        private async void ConsultaSqlAtendentes()
        {
            string sqlA = @"
                        SELECT a.atendente_id,a.nome, s.nome AS setor, a.email
                        FROM atendente a
                        JOIN setores s ON a.setor_id = s.setor_id;";

            await CarregarDadosAsync(sqlA, GridAtendentes, "atendente_id");
        }

        private void btnSair_Click(object sender, EventArgs e) => this.Hide();

        private async void btnSetor_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM setores;", GridSetores, "setor_id");
            tbcPaginas.SelectedTab = tbSetor;
        }

        private async void btnPerguntas_Click(object sender, EventArgs e)
        {
            //await ListaTodasAsOrdensAsync(cbxOrdemPerguntas, setorIdOriginal);
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbListaDeSetoresPerguntas);
            ConsultaSqlPerguntas();
            tbcPaginas.SelectedTab = tbPerguntas;
        }
        private async void btnCadrastoAdmin_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM admin", GridAdmin, "admin_id", "senha");
            tbcPaginas.SelectedTab = tbAdmin;
        }
        private async void btnAtendentes_Click(object sender, EventArgs e)
        {
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbListaDeSetores);
            ConsultaSqlAtendentes();
            tbcPaginas.SelectedTab = tbAtendentes;
        }

        private void btnHomeSetor_Click(object sender, EventArgs e)
        {
            FrmEscolhaInicial frmEscolhaInicial = new FrmEscolhaInicial();
            frmEscolhaInicial.Show();

            this.Hide();
        }

        public async Task CarregarDadosAsync(string sql, DataGridView grid, params string[] colunasOcultar)
        {
            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        grid.DataSource = dt;

                        grid.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        grid.DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
                        grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
                        grid.GridColor = System.Drawing.Color.LightSlateGray;

                        grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Brown;
                        grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                        grid.ColumnHeadersDefaultCellStyle.Font = new Font(grid.Font.FontFamily, 12, FontStyle.Bold);
                        grid.EnableHeadersVisualStyles = false;


                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Oculta as colunas especificadas
                        foreach (var coluna in colunasOcultar)
                        {
                            if (grid.Columns.Contains(coluna))
                            {
                                grid.Columns[coluna].Visible = false;
                            }
                        }

                        grid.RowHeadersVisible = false;

                        // Remover a última linha vazia
                        grid.AllowUserToAddRows = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
        }


        //OCULTA O GRUPO DOS BOTÕES DE UM DETERMINADO GRUPO
        private void MostraBotoes(GroupBox gb, bool valor)
        {
            gb.Visible = valor;
        }

        //MOSTRA OS BOTÕES 
        private void btnEditarSetor_Click(object sender, EventArgs e)
        {
            MostraBotoes(gbBotoesSetor, true);
        }

        private void btnEditarAtendentes_Click(object sender, EventArgs e)
        {
            MostraBotoes(gbBotoesAtendente, true);
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            MostraBotoes(gbBotoesAdmin, true);
        }

        private byte[] CarregarFoto(int atendenteID)
        {
            string sql = @"SELECT Imagem FROM fotos WHERE atendente_id = @atendente_id";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@atendente_id", atendenteID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Imagem"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["Imagem"];
                                return imageBytes; 
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a foto: " + ex.Message);
                return null;
            }
        }

        private void GridSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = GridSetores.Rows[e.RowIndex];

                txtNomeSetor.Text = row.Cells["nome"].Value?.ToString();
                txtIdSetor.Text = row.Cells["setor_id"].Value?.ToString();
            }
        }

        private string pergunta_id;


        private int ordemAtualGrid;
        private async void GridViewPerguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = GridViewPerguntas.Rows[e.RowIndex];

                txtPergunta.Text = row.Cells["texto"].Value?.ToString();

                pergunta_id = row.Cells["pergunta_id"].Value?.ToString();
                string setorId = row.Cells["setor"].Value?.ToString();

                if (!string.IsNullOrEmpty(setorId))
                {
                    var setorSelecionado = cmbListaDeSetoresPerguntas.Items
                        .Cast<DictionaryEntry>()
                        .FirstOrDefault(item => item.Value.ToString() == setorId);

                    if (setorSelecionado.Key != null)
                    {
                        int setor_int = Convert.ToInt32(setorSelecionado.Key);
                        await ListaTodasAsOrdensAsync(cbxOrdemPerguntas, setor_int);

                        int ordem = Convert.ToInt32(row.Cells["ordem"].Value ?? 0);
                        ordemAtualGrid = ordem;

                        if (cbxOrdemPerguntas.Items.Count > 0)
                        {
                            if (cbxOrdemPerguntas.Items.Contains(ordem))
                            {
                                cbxOrdemPerguntas.SelectedItem = ordem;
                            }
                        }
                        else
                        {
                            MessageBox.Show("O ComboBox cbxOrdemPerguntas está vazio.");
                        }

                        cmbListaDeSetoresPerguntas.SelectedValue = setorSelecionado.Key;
                    }
                    else
                    {
                        cmbListaDeSetoresPerguntas.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmbListaDeSetoresPerguntas.SelectedIndex = 0;
                }

                if (int.TryParse(pergunta_id, out int perguntaId))
                {
                    CarregarOpcoes(perguntaId);
                }
                else
                {
                    MessageBox.Show("O ID da pergunta não é um número válido.");
                }
            }
        }


        private void GridAdimin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = GridAdmin.Rows[e.RowIndex];

                txtIdAdmin.Text = row.Cells["admin_id"].Value?.ToString();
                txtNomeAdimin.Text = row.Cells["nome"].Value?.ToString();
                txtEmailAdmin.Text = row.Cells["email"].Value?.ToString();
                txtSenhaAdmin.Text = row.Cells["senha"].Value?.ToString();

                txtNomeadminInical = txtNomeAdimin.Text;
                txtSenhaInical = txtSenhaAdmin.Text;
                txtEmailadminInical = txtEmailAdmin.Text;

            }
        }

        private void GridAtendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = GridAtendentes.Rows[e.RowIndex];

                txtIdAtendente.Text = row.Cells["atendente_id"].Value?.ToString();
                txtNomeAtendente.Text = row.Cells["nome"].Value?.ToString();
                txtEmailAtendente.Text = row.Cells["email"].Value?.ToString();

                string setorId = row.Cells["setor"].Value?.ToString();

                if (!string.IsNullOrEmpty(setorId))
                {
                    var setorSelecionado = cmbListaDeSetores.Items
                        .Cast<DictionaryEntry>()
                        .FirstOrDefault(item => item.Value.ToString() == setorId);

                    if (setorSelecionado.Key != null)
                    {
                        cmbListaDeSetores.SelectedValue = setorSelecionado.Key;
                    }
                    else
                    {
                        cmbListaDeSetores.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmbListaDeSetores.SelectedIndex = 0;
                }

                bool valido = int.TryParse(txtIdAtendente.Text, out int intSetorId);

                if (valido)
                {
                    byte[] imageBytes = CarregarFoto(intSetorId);
                    if (imageBytes != null)
                    {
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            ptbImagemAtendente.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        ptbImagemAtendente.Image = Properties.Resources.Foto_de_perfil_para_redes_sociais_gradiente_simples__1__removebg_preview;
                    }

                }

                // Salvar os valores originais para comparação posterior
                nomeOriginal = txtNomeAtendente.Text;
                emailOriginal = txtEmailAtendente.Text;
                setorIdOriginal = int.TryParse(setorId, out int parsedSetorId) ? parsedSetorId : 0;
            }
        }


        //Salva Mudanças no Banco de dados
        private async void btnSalvarSetor_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdSetor.Text, out int setorId);

            bool operacaoRealizada = await AtualizarSetorAsync(setorId, txtNomeSetor.Text);

            if (operacaoRealizada)
            {
                MostraBotoes(gbBotoesSetor, false);
            }
        }

        private string txtNomeadminInical;
        private string txtEmailadminInical;
        private string txtSenhaInical;

        private async void btnSalvarAdmin_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdAdmin.Text, out int AdminId);

            if (txtEmailadminInical == txtEmailAdmin.Text && txtNomeadminInical == txtNomeAdimin.Text && txtSenhaAdmin.Text == txtSenhaInical)
            {
                await ExibirMensagemTemporaria(lblMsgErroAdmin, "Nenhum campo foi alterado.");
                return;
            }
            bool operacaoRealizada = await AtualizarAdminAsync(AdminId, txtNomeAdimin.Text, txtEmailAdmin.Text, txtSenhaAdmin.Text);

            if (operacaoRealizada)
                MostraBotoes(gbBotoesAdmin, false);
        }

        private string nomeOriginal;
        private string emailOriginal;
        private int setorIdOriginal;
        private int contadorClickUpload = 0;
        private int alteraSetor = 0;

        private async void btnSalvarAtendentes_Click(object sender, EventArgs e)
        {

            int.TryParse(txtIdAtendente.Text, out int atendenteId);



            int.TryParse(cmbListaDeSetores.SelectedValue?.ToString(), out int setorId);
            setorIdOriginal = setorId + alteraSetor;


            // Verificar se os campos de texto sofreram alteração
            bool camposTextoAlterados =
            !string.Equals(txtNomeAtendente.Text.Trim().Replace(" ", ""), nomeOriginal?.Trim().Replace(" ", ""), StringComparison.OrdinalIgnoreCase) ||
            !string.Equals(txtEmailAtendente.Text.Trim().Replace(" ", ""), emailOriginal?.Trim().Replace(" ", ""), StringComparison.OrdinalIgnoreCase) ||
            setorId != setorIdOriginal;



            if (!camposTextoAlterados && contadorClickUpload == 0)
            {
                await ExibirMensagemTemporaria(lblMsgErroAtendente, "Nenhum campo foi alterado.");
                return;
            }

            bool operacaoRealizada = await AtualizarAtendenteAsync(atendenteId, txtNomeAtendente.Text, txtEmailAtendente.Text, setorId);

            if (operacaoRealizada)
            {
                MostraBotoes(gbBotoesAtendente, false);
                alteraSetor = 0;
            }

            // Se a imagem foi alterada, salvar a nova imagem no banco
            if (contadorClickUpload != 0)
            {
                string nomeSemEspacos = txtNomeAtendente.Text.Replace(" ", "");
                await SaveImageToDatabase(ptbImagemAtendente, atendenteId, nomeSemEspacos);
            }
        }


        public static async Task SaveImageToDatabase(PictureBox picture, int atendenteId, string nome)
        {
            if (picture.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    using (var clonedImage = new Bitmap(picture.Image))
                    {
                        clonedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] newImageBytes = ms.ToArray();

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
                                cmd.Parameters.AddWithValue("@tamanho", newImageBytes.Length);
                                cmd.Parameters.AddWithValue("@dataUpload", DateTime.Now);
                                cmd.Parameters.AddWithValue("@imagem", newImageBytes);

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


        public static async Task ExibirMensagemTemporaria(Label label, string mensagem, int tempoEmMilissegundos = 5000)
        {
            label.Text = mensagem;
            label.Visible = true;
            await Task.Delay(tempoEmMilissegundos);
            label.Visible = false;
        }

        private async Task<bool> DeletaSetorAsync(int SetorId)
        {
            var resultado = MessageBox.Show("Tem certeza que deseja excluir este setor e todos os atendentes associados?",
                                            "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (var transacao = await ClsConexao.Conexao.BeginTransactionAsync())
                {
                    try
                    {
                        // Excluir fotos dos atendentes antes de excluir os atendentes
                        string sqlDeletaFotos = @"
                        DELETE FROM fotos
                        WHERE atendente_id IN (SELECT atendente_id FROM atendente WHERE setor_id = @SetorId);";

                        using (var cmdDeletaFotos = new MySqlCommand(sqlDeletaFotos, ClsConexao.Conexao, transacao))
                        {
                            cmdDeletaFotos.Parameters.AddWithValue("@SetorId", SetorId);
                            await cmdDeletaFotos.ExecuteNonQueryAsync();
                        }

                        // Excluir atendentes associados ao setor
                        string sqlAtendentes = @"
                        DELETE FROM atendente
                        WHERE setor_id = @SetorId";

                        using (var cmdAtendentes = new MySqlCommand(sqlAtendentes, ClsConexao.Conexao, transacao))
                        {
                            cmdAtendentes.Parameters.AddWithValue("@SetorId", SetorId);
                            await cmdAtendentes.ExecuteNonQueryAsync();
                        }

                        // Excluir o setor
                        string sqlSetor = @"
                        DELETE FROM setores
                        WHERE setor_id = @SetorId";

                        using (var cmdSetor = new MySqlCommand(sqlSetor, ClsConexao.Conexao, transacao))
                        {
                            cmdSetor.Parameters.AddWithValue("@SetorId", SetorId);
                            int rowsAffected = await cmdSetor.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                await transacao.CommitAsync();
                                MessageBox.Show("Setor e atendentes excluídos com sucesso.");
                                return true;
                            }
                            else
                            {
                                await transacao.RollbackAsync();
                                MessageBox.Show("Erro ao excluir setor.");
                                return false;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        await transacao.RollbackAsync();
                        MessageBox.Show("Erro ao excluir setor: " + ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }


        //Atualiza os dados dos setores e verifica se os campos estão preenchidos corretamente.
        private async Task<bool> AtualizarSetorAsync(int setorId, string nome)
        {
            if (await FrmCadastros.JaExisteCadastroNomeSetor(nome))
            {
                await ExibirMensagemTemporaria(lblMsgErroSetor, "Esse SETOR já está cadastrado");
                return false;
            }

            string sql = @"
                UPDATE setores 
                SET nome = @nome 
                WHERE setor_id = @setorId;";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@setorId", setorId);

                    int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                    if (linhasAfetadas > 0)
                    {
                        await ExibirMensagemTemporaria(lblMsgErroSetor, "Setor atualizado com sucesso!");
                        await CarregarDadosAsync("SELECT setor_id, nome FROM setores;", GridSetores, "setor_id");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar setor: " + ex.Message);
                return false;
            }
        }

        private async Task<bool> AtualizarAdminAsync(int adminId, string nome, string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                await ExibirMensagemTemporaria(lblMsgErroAdmin, "Todos os campos devem ser preenchidos.");
                return false;
            }

            if (!FrmCadastros.ValidaEmail(email))
            {
                await ExibirMensagemTemporaria(lblMsgErroAdmin, "Digite um e-mail válido.");
                return false;
            }

            int.TryParse(txtIdAdmin.Text, out int AdminId);

            if (await verificaEmailJaCadastrado("admin", "admin_id", AdminId, email))
            {
                await ExibirMensagemTemporaria(lblMsgErroAdmin, "Este e-mail já está cadastrado com outro administrador.");
                return false;
            }

            string sql = @"
                UPDATE admin 
                SET nome = @nome, email = @email, senha = @senha
                WHERE admin_id = @admin_id;";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@admin_id", adminId);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                    if (linhasAfetadas > 0)
                    {
                        await ExibirMensagemTemporaria(lblMsgErroAdmin, "Administrador atualizado com sucesso!");
                        await CarregarDadosAsync("SELECT * FROM admin;", GridAdmin, "admin_id", "senha");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar administrador: " + ex.Message);
                return false;
            }
        }


        private async Task<bool> AtualizarAtendenteAsync(int atendenteId, string nome, string email, int setorId)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || setorId == 0)
            {
                await ExibirMensagemTemporaria(lblMsgErroAtendente, "Todos os campos devem ser preenchidos.");
                return false;
            }

            if (!FrmCadastros.ValidaEmail(email))
            {
                await ExibirMensagemTemporaria(lblMsgErroAtendente, "Digite um e-mail válido.");
                return false;
            }

            if (await verificaEmailJaCadastrado("atendente", "atendente_id", atendenteId, email))
            {
                await ExibirMensagemTemporaria(lblMsgErroAtendente, "Este e-mail já está cadastrado com outro atendente.");
                return false;
            }

            string sql = @"
                UPDATE atendente 
                SET nome = @nome, email = @email, setor_id = @setor_id
                WHERE atendente_id = @atendente_id;";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@atendente_id", atendenteId);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@setor_id", setorId);

                    int linhasAfetadas = await cmd.ExecuteNonQueryAsync();

                    if (linhasAfetadas > 0)
                    {
                        await ExibirMensagemTemporaria(lblMsgErroAtendente, "Atendente atualizado com sucesso!");
                        ConsultaSqlAtendentes();
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi feita.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar atendente: " + ex.Message);
                return false;
            }
        }

        private async Task<bool> verificaEmailJaCadastrado(string tabela, string campoProucurado, int atendenteId, string email)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"SELECT COUNT(*) FROM {tabela} WHERE email = @email AND {campoProucurado} <> @id ");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", atendenteId);

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

        private async void btnCarregarSetores_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM setores;", GridSetores, "setor_id");
        }

        private async void btnCarregaAdmin_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM admin", GridAdmin, "admin_id", "senha");
        }

        private async void btnCarregaAtendentes_Click(object sender, EventArgs e)
        {
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbListaDeSetores);
            ConsultaSqlAtendentes();
        }



        private async void btnDeletarSetor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdSetor.Text, out int setorId))
            {
                bool sucesso = await DeletaSetorAsync(setorId);

                if (sucesso)
                {
                    gbBotoesSetor.Visible = false;
                    await ExibirMensagemTemporaria(lblMsgErroSetor, "Setor excluído com sucesso!");

                }
                else
                {
                    await ExibirMensagemTemporaria(lblMsgErroSetor, "Erro ao excluir o setor.");
                }
            }
            else
            {
                await ExibirMensagemTemporaria(lblMsgErroSetor, "ID do setor inválido.");
            }
        }

        private async void btnCarregarDadosPerguntas_Click(object sender, EventArgs e)
        {
            ConsultaSqlPerguntas();
        }

        public async void AdicionarOpcao()
        {
            for (int i = 1; i <= 10; i++)
            {
                var txtOpcao = this.Controls.Find($"txtOpcao{i}", true);
                var lblOpcao = this.Controls.Find($"lblOp{i}",true);
                if (txtOpcao.Length > 0 && txtOpcao[0] is TextBox txtBox && !txtBox.Visible && lblOpcao[0] is Label lblBox)
                {
                    txtBox.Text = string.Empty;
                    txtBox.Visible = true;
                    lblBox.Visible = true;
                    break;
                }
                if (i == 10)
                    await ExibirMensagemTemporaria(lblMsgErroPerguntas, "O limite máximo de opções é 10.");
            }
        }

        public async void RemoverOpcao()
        {
            for (int i = 10; i >= 3; i--)
            {
                var txtOpcao = this.Controls.Find($"txtOpcao{i}", true);
                var lblOpcao = this.Controls.Find($"lblOp{i}", true);
                if (txtOpcao.Length > 0 && txtOpcao[0] is TextBox txtBox && txtBox.Visible && lblOpcao[0] is Label lblBox )
                {
                    txtBox.Text = string.Empty;
                    txtBox.Visible = false;
                    lblBox.Visible = false;
                    break;
                }
                if (i == 3)
                    await ExibirMensagemTemporaria(lblMsgErroPerguntas, "O limite minimo e de opções é 2.");

            }
        }

        private void btnAdiconarAlternativa_Click(object sender, EventArgs e)
        {
            AdicionarOpcao();
        }

        private void btnRemoverAlternativa_Click(object sender, EventArgs e)
        {
            RemoverOpcao();
        }


        public void CarregarOpcoes(int idPergunta)
        {
            var sql = new System.Text.StringBuilder();
            sql.Append("SELECT texto FROM opcoes WHERE pergunta_id = @idPergunta");

            using (var cmd = new MySqlCommand(sql.ToString(), ClsConexao.Conexao))
            {
                cmd.Parameters.AddWithValue("@idPergunta", idPergunta);

                try
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        int index = 1;



                        while (reader.Read() && index <= 10)
                        {
                            var txtOpcao = this.Controls.Find($"txtOpcao{index}", true);
                            var lblopcao = this.Controls.Find($"lblOp{index}",true);
                            if (txtOpcao.Length > 0 && txtOpcao[0] is TextBox txtBox && lblopcao[0] is Label lblBox)
                            {
                                txtBox.Text = reader["texto"].ToString();
                                lblBox.Visible =true;
                                txtBox.Visible = true;

                            }
                            index++;
                        }
                        for (int i = index; i <= 10; i++)
                        {
                            var txtOpcao = this.Controls.Find($"txtOpcao{i}", true);
                            if (txtOpcao.Length > 0 && txtOpcao[0] is TextBox txtBox)
                            {

                                txtBox.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar opções: " + ex.Message);
                }
            }
        }

        private async void btnDeletarAdmin_Click(object sender, EventArgs e)
        {
            bool v = int.TryParse(txtIdAdmin.Text, out int adminId);
            if (v)
                await DeletarAdminAsync(adminId);
        }

        private async Task DeletarAdminAsync(int adminId)
        {
            string sql = @"
        DELETE FROM admin
        WHERE admin_id = @adminId";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    int rowsAffected = await cmd.ExecuteNonQueryAsync();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Administrador deletado com sucesso.");
                        await CarregarDadosAsync("SELECT * FROM admin", GridAdmin, "admin_id", "senha");
                        txtIdAdmin.Text = string.Empty;
                        txtEmailAdmin.Text = string.Empty;
                        txtSenhaAdmin.Text = string.Empty;
                        txtNomeAdimin.Text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("Nenhum administrador encontrado com esse ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar administrador: " + ex.Message);
            }
        }
        private async Task DeletaAtendenteAsync(int atendenteId)
        {
            string sql = @"DELETE FROM fotos WHERE atendente_id = @atendenteId;
                   DELETE FROM atendente WHERE atendente_id = @atendenteId;";

            try
            {
                using (var connection = new MySqlConnection(ClsConexao.connectionString))
                {
                    await connection.OpenAsync();

                    using (var transaction = await connection.BeginTransactionAsync())
                    using (var cmd = new MySqlCommand(sql, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@atendenteId", atendenteId);

                        int rowsAffected = await cmd.ExecuteNonQueryAsync();
                        await transaction.CommitAsync();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Atendente deletado com sucesso.");
                            txtEmailAtendente.Text = string.Empty;
                            txtNomeAtendente.Text = string.Empty;
                            txtIdAtendente.Text = string.Empty;
                            cmbListaDeSetores.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum Atendente encontrado com esse ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar Atendente: " + ex.Message);
            }
        }

        //private async void btnDeletarAtendentes_Click(object sender, EventArgs e)
        //{
        //    if (int.TryParse(pergunta_id, out int atendeteId))
        //        await DeletaAtendenteAsync(atendeteId);
        //}

        //private async void btnSalvarPerguntas_Click(object sender, EventArgs e)
        //{
        //    int novaOrdem = Convert.ToInt32(cbxOrdemPerguntas.SelectedItem);

        //    int ordemAtual = Convert.ToInt32(ordemAtualGrid); 

        //    if(novaOrdem != ordemAtual) //Verifica se teve alteração nos valores dos campos.
        //    {
        //        await AlterarOrdemNoBanco(ordemAtual, novaOrdem);
        //    }

        //    if (!int.TryParse(pergunta_id, out int perguntaId))
        //    {
        //        MessageBox.Show("Deu erro setor " + perguntaId);
        //        return;
        //    }

        //    if(!int.TryParse(cbxOrdemPerguntas.SelectedValue?.ToString(), out int setorId))
        //    {
        //        return;
        //    }


        //    await SalvarPerguntaBancoDeDadosAsync(perguntaId, txtPergunta.Text,setorId);

        //    var listaOpcoes = ObterOpcoesPreenchidas();
        //    await SubstituirOpcoesNoBancoDeDadosAsync(perguntaId, listaOpcoes);

        //    MessageBox.Show("Pergunta e opções salvas com sucesso!");
        //}

        private async void btnSalvarPerguntas_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se a ordem foi alterada
                if (cbxOrdemPerguntas.SelectedValue is int novaOrdem &&
                    novaOrdem != ordemAtualGrid)
                {
                    await AlterarOrdemNoBanco(ordemAtualGrid, novaOrdem);
                }

                // Validação e conversão do ID da pergunta
                if (!int.TryParse(pergunta_id, out int perguntaId))
                {
                    MessageBox.Show("Erro ao identificar o ID da pergunta.");
                    return;
                }

                // Validação e conversão do ID do setor (usando SelectedValue do ComboBox)
                if (cmbListaDeSetoresPerguntas.SelectedValue is not int setorIdPergunta)
                {
                    MessageBox.Show("Erro ao identificar o ID do setor.");
                    return;
                }
                MessageBox.Show("Setor ID :" + setorIdPergunta);
                // Salva a pergunta no banco de dados
                await SalvarPerguntaBancoDeDadosAsync(perguntaId, txtPergunta.Text, setorIdPergunta);

                // Obtém as opções preenchidas e atualiza no banco de dados
                var listaOpcoes = ObterOpcoesPreenchidas();
                if (listaOpcoes != null && listaOpcoes.Any())
                {
                    await SubstituirOpcoesNoBancoDeDadosAsync(perguntaId, listaOpcoes, setorIdPergunta);
                }
                else
                {
                    MessageBox.Show("Nenhuma opção foi preenchida.");
                }

                // Mensagem de sucesso
                MessageBox.Show("Pergunta e opções salvas com sucesso!");
            }
            catch (Exception ex)
            {
                // Tratamento genérico de erros
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }


        private List<string> ObterOpcoesPreenchidas()
        {
            var listaOpcoes = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                var txtOpcao = this.Controls.Find($"txtOpcao{i}", true);
                if (txtOpcao.Length > 0 && txtOpcao[0] is TextBox txtBox && !string.IsNullOrEmpty(txtBox.Text))
                {
                    listaOpcoes.Add(txtBox.Text);
                }
            }
            return listaOpcoes;
        }

        private async Task SubstituirOpcoesNoBancoDeDadosAsync(int perguntaId, List<string> listaOpcoes,int setor)
        {
            string deleteSql = "DELETE FROM opcoes WHERE pergunta_id = @perguntaId";
            string insertSql = "INSERT INTO opcoes (pergunta_id, texto,setor_id) VALUES (@perguntaId, @texto,@setor_id)";

            using (var connection = new MySqlConnection(ClsConexao.connectionString))
            {
                await connection.OpenAsync();

                // Apaga todas as opções atuais da pergunta para evitar duplicações
                using (var deleteCommand = new MySqlCommand(deleteSql, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@perguntaId", perguntaId);
                    await deleteCommand.ExecuteNonQueryAsync();
                }

                // Insere cada nova opção
                foreach (var opcao in listaOpcoes)
                {
                    using (var insertCommand = new MySqlCommand(insertSql, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@perguntaId", perguntaId);
                        insertCommand.Parameters.AddWithValue("@texto", opcao);
                        insertCommand.Parameters.AddWithValue("@setor_id", setor);
                        await insertCommand.ExecuteNonQueryAsync();
                    }
                }
            }
        }


        private async Task SalvarPerguntaBancoDeDadosAsync(int idPergunta, string text,int setor_id)
        {
            string sql = @"UPDATE perguntas
                           SET texto = @texto,setor_id = @setor_id
                           WHERE pergunta_id = @idPergunta";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@idPergunta", idPergunta);
                    cmd.Parameters.AddWithValue("@texto", text);
                    cmd.Parameters.AddWithValue("@setor_id", setor_id);
                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Pergunta atualizada com sucesso!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        public static async Task ListaTodasAsOrdensAsync(ComboBox comboBox, int setor)
        {
            string sql = @"SELECT COUNT(ordem) 
                 FROM perguntas
                 WHERE setor_id = @setor";

            try
            {
                using (var cmd = new MySqlCommand(sql, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@setor", setor);
                    var ordemList = new List<int>();

                    int totalPerguntas = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                    for (int i = 1; i <= totalPerguntas; i++)
                    {
                        ordemList.Add(i);
                    }

                    comboBox.DataSource = ordemList;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao listar ordens: " + ex.Message);
            }
        }




        private async Task AlterarOrdemNoBanco(int ordem1, int ordem2)
        {
            try
            {
                // Verifica se as ordens são diferentes
                if (ordem1 != ordem2)
                {
                    // Utiliza transações para garantir que a troca seja atômica
                    using (var transaction = ClsConexao.Conexao.BeginTransaction())
                    {
                        try
                        {
                            // Troca as ordens diretamente
                            string updateSql = @"
                                UPDATE perguntas
                                SET ordem = CASE
                                    WHEN ordem = @ordem1 THEN @ordem2
                                    WHEN ordem = @ordem2 THEN @ordem1
                                    ELSE ordem
                                END
                                WHERE ordem IN (@ordem1, @ordem2)";

                            using (var cmd = new MySqlCommand(updateSql, ClsConexao.Conexao, transaction))
                            {
                                cmd.Parameters.AddWithValue("@ordem1", ordem1);
                                cmd.Parameters.AddWithValue("@ordem2", ordem2);

                                await cmd.ExecuteNonQueryAsync();
                            }

                            transaction.Commit();

                            MessageBox.Show("Ordem trocada com sucesso no banco de dados!");
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Erro ao trocar a ordem no banco de dados: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("As ordens são iguais, nenhuma troca foi realizada.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar realizar a transação: " + ex.Message);
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            FrmCadastros.SelecionaImagem(ptbImagemAtendente);
            contadorClickUpload++;
        }

        private void TentouAleterarOSetor_Click(object sender, EventArgs e)
        {
            alteraSetor++;
        }

        private void btnEditarPerguntas_Click(object sender, EventArgs e)
        {
            gbPerguntas.Visible = true;
        }
    }
}


//LINHA 314 ALTERA - IMAGEM DE USUÁRIO

