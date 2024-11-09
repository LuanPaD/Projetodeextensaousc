using iText.Kernel.Colors;
using iText.StyledXmlParser.Jsoup.Nodes;
using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Cadastros;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    public partial class FrmEditarCadastroscs : Form
    {

        public FrmEditarCadastroscs()
        {

            InitializeComponent();

        }

        private async void btnSetor_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM setores;", GridSetores, "setor_id");
            tbcPaginas.SelectedTab = tbSetor;
        }

        private void btnPerguntas_Click(object sender, EventArgs e)
        {

            tbcPaginas.SelectedTab = tbPerguntas;
        }
        private async void btnCadrastoAdmin_Click(object sender, EventArgs e)
        {
            await CarregarDadosAsync("SELECT * FROM admin", GridAdmin, "admin_id", "senha");
            tbcPaginas.SelectedTab = tbAdmin;
        }
        private async void btnAtendentes_Click(object sender, EventArgs e)
        {
            string sql = @"
                SELECT a.atendente_id,a.nome, s.nome AS setor, a.email
                FROM atendente a
                JOIN setores s ON a.setor_id = s.setor_id;";

            await CarregarDadosAsync(sql, GridAtendentes, "atendente_id");
            await FrmCadastros.ListaTodosOsSetoresAsync(cmbListaDeSetores);
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
                        grid.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                        grid.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        grid.BackgroundColor = System.Drawing.Color.White;
                        grid.GridColor = System.Drawing.Color.Gray;
                        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        foreach (var coluna in colunasOcultar)
                        {
                            if (grid.Columns.Contains(coluna))
                            {
                                grid.Columns[coluna].Visible = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar cadastro: " + ex.Message);
            }
        }


        //OCULTA O GRUPO DOS BOTÕES DE UM DETERMINADO GRUPO
        private void MostraBotoesAtendentes(bool valor)
        {
            gbBotoesAtendente.Visible = valor;
        }

        private void MostrarBotoesAdmin(bool valor)
        {
            gbBotoesAdmin.Visible = valor;
        }

        private void MostraBotoesSetor(bool valor)
        {
            gbBotoesSetor.Visible = valor;
        }


        //MOSTRA OS BOTÕES 
        private void btnEditarSetor_Click(object sender, EventArgs e)
        {
            MostraBotoesSetor(true);
        }

        private void btnEditarAtendentes_Click(object sender, EventArgs e)
        {
            MostraBotoesAtendentes(true);
        }

        private void btnEditarAdmin_Click(object sender, EventArgs e)
        {
            MostrarBotoesAdmin(true);
        }



        //Extrai os valores da Linha do Grid Selecionado
        private void GridSetores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = GridSetores.Rows[e.RowIndex];

                txtNomeSetor.Text = row.Cells["nome"].Value?.ToString();
                txtIdSetor.Text = row.Cells["setor_id"].Value?.ToString();
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
            }
        }


        //Salva Mudanças no Banco de dados
        private async void btnSalvarSetor_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdSetor.Text, out int setorId);

            bool operacaoRealizada = await AtualizarSetorAsync(setorId, txtNomeSetor.Text);

            if (operacaoRealizada)
            {
                MostraBotoesSetor(false);
            }
        }

        private async void btnSalvarAdmin_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdAdmin.Text, out int AdminId);

            bool operacaoRealizada = await AtualizarAdminAsync(AdminId, txtNomeAdimin.Text, txtEmailAdmin.Text, txtSenhaAdmin.Text);

            if (operacaoRealizada)
                MostrarBotoesAdmin(false);
        }

        private async void btnSalvarAtendentes_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdAtendente.Text, out int AtentendenteId);
            int.TryParse(cmbListaDeSetores.SelectedValue?.ToString(), out int setorId);

            bool operacaoRealizada = await AtualizarAtendenteAsync(AtentendenteId, txtNomeAtendente.Text, txtEmailAtendente.Text, setorId);

            if (operacaoRealizada)
                MostraBotoesAtendentes(false);
        }

        private async Task ExibirMensagemTemporariaSetor(string mensagem, int tempoEmMilissegundos = 2000)
        {
            lblMsgDaOperacao.Text = mensagem;
            lblMsgDaOperacao.Visible = true;
            await Task.Delay(tempoEmMilissegundos);
            lblMsgDaOperacao.Visible = false;
        }

        private async Task ExibirMensagemTemporariaAdmin(string mensagem, int tempoEmMilissegundos = 2000)
        {
            lblMsgErroAdmin.Text = mensagem;
            lblMsgErroAdmin.Visible = true;
            await Task.Delay(tempoEmMilissegundos);
            lblMsgErroAdmin.Visible = false;
        }

        private async Task ExibirMensagemTemporariaAtendente(string mensagem, int tempoEmMilissegundos = 2000)
        {
            lblMsgErroAtendente.Text = mensagem;
            lblMsgErroAtendente.Visible = true;
            await Task.Delay(tempoEmMilissegundos);
            lblMsgErroAtendente.Visible = false;
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
                        string sqlAtendentes = @"
                        DELETE FROM atendente
                        WHERE setor_id = @SetorId";

                        using (var cmdAtendentes = new MySqlCommand(sqlAtendentes, ClsConexao.Conexao, transacao))
                        {
                            cmdAtendentes.Parameters.AddWithValue("@SetorId", SetorId);
                            await cmdAtendentes.ExecuteNonQueryAsync();
                        }

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
                                return true;
                            }
                            else
                            {
                                await transacao.RollbackAsync();
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
                await ExibirMensagemTemporariaSetor("Esse SETOR já está cadastrado");
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
                        await ExibirMensagemTemporariaSetor("Setor atualizado com sucesso!");
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

        //Atualiza os dados dos Admin e verifica se os campos estão preenchidos corretamente.
        private async Task<bool> AtualizarAdminAsync(int adminId, string nome, string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                await ExibirMensagemTemporariaAdmin("Todos os campos devem ser preenchidos.");
                return false;
            }

            if (!FrmCadastros.ValidaEmail(email))
            {
                await ExibirMensagemTemporariaAdmin("Digite um e-mail válido.");
                return false;
            }

            if (await FrmCadastros.JaExisteCadastroEmailAdmin(email))
            {
                await ExibirMensagemTemporariaAdmin("Este e-mail já está cadastrado com outro administrador.");
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
                        await ExibirMensagemTemporariaAdmin("Administrador atualizado com sucesso!");
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
                await ExibirMensagemTemporariaAtendente("Todos os campos devem ser preenchidos.");
                return false;
            }

            if (!FrmCadastros.ValidaEmail(email))
            {
                await ExibirMensagemTemporariaAtendente("Digite um e-mail válido.");
                return false;
            }

            /*
             * NN É APENAS VERIFICAR SE ESSE EMAIL ESTA CADASATRADO PRECISA VERIFICAR SE E O MESMO ATENDETEID QUE ESTÁ TENDANDO ALTERAR PQ SE NN VAI DEIXAR 
             * ATUALIZAR, PORQUE TEM UM EMAIL DESSE JÁ CADASTRADO
             * 
             * Não deixar o usuario EDITAR UM CAMPO QUE AINDA NN EXISTE
             * 
            if (await FrmCadastros.ExisteCadastroAsync("atendente", "email", email) )
            {
                await ExibirMensagemTemporariaAtendente("Este e-mail já está cadastrado com outro atendente.");
                return false;
            }
            */

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
                        await ExibirMensagemTemporariaAtendente("Atendente atualizado com sucesso!");
                        await CarregarDadosAsync("SELECT a.atendente_id, a.nome, s.nome AS setor, a.email FROM atendente a JOIN setores s ON a.setor_id = s.setor_id;", GridAtendentes, "atendente_id");
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
            string sql = @"
                SELECT a.atendente_id,a.nome, s.nome AS setor, a.email
                FROM atendente a
                JOIN setores s ON a.setor_id = s.setor_id;";

            await CarregarDadosAsync(sql, GridAtendentes, "atendente_id");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnDeletarSetor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdSetor.Text, out int setorId))
            {
                bool sucesso = await DeletaSetorAsync(setorId);

                if (sucesso)
                {
                    await ExibirMensagemTemporariaSetor("Setor excluído com sucesso!");
                }
                else
                {
                    await ExibirMensagemTemporariaSetor("Erro ao excluir o setor.");
                }
            }
            else
            {
                await ExibirMensagemTemporariaSetor("ID do setor inválido.");
            }
        }

    }
}

