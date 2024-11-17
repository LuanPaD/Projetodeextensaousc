using MySqlConnector;
using Projeto_de_Extensao.Classes;
using Projeto_de_Extensao.Formulários.Perguntas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static Projeto_de_Extensão.Formulários.Perguntas.FrmPergunta;

namespace Projeto_de_Extensão.Formulários.Perguntas
{
    public partial class FrmPergunta : Form
    {
        private int num_perguntaAtual = 1;
        private int qtdDePerguntas = 0;
        private int AtendenteId = 0;
        private bool alternativaEscolhida = false;
        private string setorSelecionado = String.Empty;
        //Posicao(Ordem da pergunta), alternativa 
        private Dictionary<int, string> respostas = new Dictionary<int, string>();

        //id da pergunta, id da alternativa
        private Dictionary<int, int> idsPeguntaResposta = new Dictionary<int, int>();


        public FrmPergunta(int AtendenteId, string setorSelecionado)
        {
            InitializeComponent();
            this.setorSelecionado = setorSelecionado;
            this.AtendenteId = AtendenteId;

            CriarAlternativas();
            controlaVisibilidadeBotoesVoltarAvancar();
        }

        #region Eventos
        private void btnPerguntaAnterior_Click(object sender, EventArgs e)
        {
            if (num_perguntaAtual == 1) return;

            num_perguntaAtual--;
            CriarAlternativas();
            controlaVisibilidadeBotoesVoltarAvancar();
        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            if (alternativaEscolhida == false)
            {
                MessageBox.Show("Você deve escolher uma alternativa antes de avançar !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            num_perguntaAtual++;
            CriarAlternativas();

            controlaVisibilidadeBotoesVoltarAvancar();
        }

        private async void btnFinalizarAvaliacao_Click(object sender, EventArgs e)
        {
            if (respostas.Count < qtdDePerguntas)
            {
                MessageBox.Show("Você precisa responder todas as perguntas antes de finalizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idAvaliacao = 0;
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("yyyy-MM-dd HH:mm:ss"); // Formato MySQL

            // Inserir a avaliação
            string sqlInsertAvaliacao = @"
                INSERT INTO avaliacao (atendente_id, setor_id, data)
                VALUES (@atendente_id, (SELECT setor_id FROM setores WHERE nome = @setor), @data);
                SELECT LAST_INSERT_ID();";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();

                    using (var cmd = new MySqlCommand(sqlInsertAvaliacao, conexao))
                    {
                        cmd.Parameters.AddWithValue("@atendente_id", AtendenteId);
                        cmd.Parameters.AddWithValue("@setor", setorSelecionado);
                        cmd.Parameters.AddWithValue("@data", dataFormatada);

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                        {
                            idAvaliacao = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("[Informe o Administrador] - Erro ao salvar avaliação: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inserir as respostas
            string sqlInsertRespostas = @"
                INSERT INTO respostas (avaliacao_id, pergunta_id, opcao_id)
                VALUES (@avaliacao_id, @pergunta_id, @opcao_id);";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();

                    foreach (var resposta in idsPeguntaResposta)
                    {
                        using (var cmd = new MySqlCommand(sqlInsertRespostas, conexao))
                        {
                            cmd.Parameters.AddWithValue("@avaliacao_id", idAvaliacao);
                            cmd.Parameters.AddWithValue("@pergunta_id", await getPerguntaId(resposta.Value)); // A chave é o ID da pergunta
                            cmd.Parameters.AddWithValue("@opcao_id", resposta.Value); // O valor é o ID da alternativa

                            await cmd.ExecuteNonQueryAsync();
                        }
                    }
                }

                //MessageBox.Show("Questionário finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAgradecimento frmAgradecimento = new FrmAgradecimento();
                frmAgradecimento.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("[Informe o Administrador] - Erro ao salvar respostas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Funções

        private async Task<int> getPerguntaId(int opcaoId)
        {
            string sqlPerguntaid = @"
                        SELECT 
                            pergunta_id 
                        FROM 
                            opcoes 
                        WHERE 
                            opcao_id = @opcaoId";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();
                    using (var cmd = new MySqlCommand(sqlPerguntaid, conexao))
                    {
                        cmd.Parameters.AddWithValue("@opcaoId", opcaoId);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                MessageBox.Show("Pergunta id = " + reader.GetInt32(reader.GetOrdinal("pergunta_id")));
                                return reader.GetInt32(reader.GetOrdinal("pergunta_id"));
                            }
                            throw new Exception("Erro ao buscar id da pergunta");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar pergunta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public async void CriarAlternativas()
        {
            alternativaEscolhida = false;
            qtdDePerguntas = await getQuantidadeDePerguntas();

            // Obter alternativas, agora retornando uma lista de objetos Alternativa
            List<Alternativa> alternativas = await getPertguntaEalternativas();

            CriarBotoesAlternativas(alternativas);

            // Verificar se a pergunta atual já foi respondida
            if (idsPeguntaResposta.ContainsKey(num_perguntaAtual))
            {
                int opcaoId = idsPeguntaResposta[num_perguntaAtual];

                // Encontrar a alternativa que corresponde ao ID
                Alternativa AlternativaEscolhida = alternativas.FirstOrDefault(a => a.Id == opcaoId);
                if (AlternativaEscolhida != null)
                {
                    foreach (CustomButton btn in grbAlternativas.Controls)
                    {
                        if (btn.Text == AlternativaEscolhida.Texto)
                        {
                            btn.BackColor = Color.FromArgb(153, 39, 30); // Cor da resposta escolhida
                            alternativaEscolhida = true;
                            break;
                        }
                    }
                }
            }

            lblQtdPerguntas.Text = $"{num_perguntaAtual}/{qtdDePerguntas}";
        }

        private async Task<List<Alternativa>> getPertguntaEalternativas()
        {
            if (string.IsNullOrWhiteSpace(setorSelecionado))
            {
                MessageBox.Show("Setor não foi selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Alternativa>();
            }

            int IDpergunta = 0;
            List<Alternativa> alternativas = new List<Alternativa>();

            string sqlPergunta = @"
                            SELECT 
                                pergunta_id, texto 
                            FROM 
                                perguntas 
                            WHERE 
                                SETOR_ID = (SELECT setor_id FROM setores WHERE nome = @setorNome) 
                            ORDER BY ordem 
                            LIMIT 1 OFFSET @offset";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();
                    using (var cmd = new MySqlCommand(sqlPergunta, conexao))
                    {
                        cmd.Parameters.AddWithValue("@setorNome", setorSelecionado);
                        cmd.Parameters.AddWithValue("@offset", num_perguntaAtual - 1);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                IDpergunta = reader.GetInt32(reader.GetOrdinal("pergunta_id"));
                                lblPergunta.Text = reader.GetString("texto");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar pergunta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return alternativas;
            }

            // Consultar alternativas
            string sqlAlternativas = "SELECT texto, opcao_id FROM opcoes WHERE pergunta_id = @pergunta_id";

            try
            {
                using (var conexao = new MySqlConnection(ClsConexao.connectionString))
                {
                    await conexao.OpenAsync();
                    using (var cmd = new MySqlCommand(sqlAlternativas, conexao))
                    {
                        cmd.Parameters.AddWithValue("@pergunta_id", IDpergunta);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                alternativas.Add(new Alternativa
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("opcao_id")),
                                    Texto = reader.GetString("texto")
                                });
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar alternativas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return alternativas;
        }

        private int calculaEspacamentoPorQtdAlternativas(int quantidade)
        {
            if (quantidade <= 2) return 40;
            if (quantidade <= 4) return 30;
            return 10;
        }


        private async Task<int> getQuantidadeDePerguntas()
        {
            int qtdPerguntas = 0;
            string sqlQtd = @$" SELECT 
                                      count(pergunta_id) as 'quantidade'
                                     FROM 
                                      perguntas 
                                     WHERE
                                        SETOR_ID = (SELECT setor_id from setores where nome = @setor);  
                                    ";
            try
            {
                using (var cmd = new MySqlCommand(sqlQtd, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@setor", setorSelecionado);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            qtdPerguntas = reader.GetInt32(reader.GetOrdinal("quantidade"));
                        }
                    }
                }
                return qtdPerguntas;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar quantidade de perguntas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return qtdPerguntas;
            }
        }

        private void controlaVisibilidadeBotoesVoltarAvancar()
        {
            if (num_perguntaAtual == 1)
            {
                btnPerguntaAnterior.Visible = false;
                btnProximaPergunta.Visible = true;
                btnFinalizarAvaliacao.Visible = false;
                return;
            }

            if (num_perguntaAtual == qtdDePerguntas)
            {
                btnFinalizarAvaliacao.Visible = true;
                btnProximaPergunta.Visible = false;
                btnPerguntaAnterior.Visible = true;
                return;
            }

            if (qtdDePerguntas == 1)
            {
                btnProximaPergunta.Visible = false;
                btnPerguntaAnterior.Visible = false;
                btnFinalizarAvaliacao.Visible = true;
                return;
            }

            btnProximaPergunta.Visible = true;
            btnPerguntaAnterior.Visible = true;
        }

        #endregion

        #region Classe Alternativas 
        public class Alternativa
        {
            public int Id { get; set; }
            public string Texto { get; set; }
        }

        #endregion

        #region Botões

        public void CriarBotoesAlternativas(List<Alternativa> alternativas)
        {
            int espacamentoVertical = calculaEspacamentoPorQtdAlternativas(alternativas.Count);
            int larguraGroupBox = grbAlternativas.Width;
            int alturaGroupBox = grbAlternativas.Height;
            grbAlternativas.Controls.Clear();

            // Calcula a posição inicial para os botões
            if (alternativas.Count <= 5)
            {
                DistribuirBotoesVerticalmente(alternativas, larguraGroupBox, alturaGroupBox, espacamentoVertical);
            }
            else
            {
                DistribuirBotoesEmColunas(alternativas, larguraGroupBox, alturaGroupBox, espacamentoVertical);
            }
        }

        private void DistribuirBotoesVerticalmente(List<Alternativa> alternativas, int larguraGroupBox, int alturaGroupBox, int espacamentoVertical)
        {
            int posicaoY = 30;  // Começar no topo do GroupBox

            foreach (var alternativa in alternativas)
            {
                CustomButton btnAlternativa = CriarBotaoAlternativa(alternativa.Texto, alternativa.Id);
                btnAlternativa.Click += BtnAlternativa_Click;

                // Centraliza o botão horizontalmente
                int posicaoX = (larguraGroupBox - btnAlternativa.Width) / 2;
                btnAlternativa.Location = new Point(posicaoX, posicaoY);

                grbAlternativas.Controls.Add(btnAlternativa);
                posicaoY += btnAlternativa.Height + espacamentoVertical;
            }
        }

        private void DistribuirBotoesEmColunas(List<Alternativa> alternativas, int larguraGroupBox, int alturaGroupBox, int espacamentoVertical)
        {
            int numColunas = 2;
            int numLinhas = (int)Math.Ceiling(alternativas.Count / (double)numColunas);
            int larguraColuna = larguraGroupBox / numColunas;
            int alturaBotao = 90;

            int posicaoX, posicaoY;

            for (int coluna = 0; coluna < numColunas; coluna++)
            {
                if (coluna == 0)
                {
                    posicaoX = (coluna * larguraColuna + (larguraColuna - 400) / 4) + 90;
                }
                else
                {
                    posicaoX = coluna * larguraColuna + (larguraColuna - 400) / 2;
                }

                posicaoY = 10;

                for (int linha = 0; linha < numLinhas; linha++)
                {
                    int indiceBotao = linha * numColunas + coluna;

                    if (indiceBotao >= alternativas.Count)
                        break;

                    var alternativa = alternativas[indiceBotao];
                    CustomButton btnAlternativa = CriarBotaoAlternativa(alternativa.Texto, alternativa.Id);
                    btnAlternativa.Click += BtnAlternativa_Click;

                    btnAlternativa.Location = new Point(posicaoX, posicaoY);
                    grbAlternativas.Controls.Add(btnAlternativa);

                    posicaoY += alturaBotao + espacamentoVertical;
                }
            }
        }

        private CustomButton CriarBotaoAlternativa(string texto, int id)
        {
            var btn = new CustomButton
            {
                Text = texto,
                Tag = id,  // Armazenando o id da alternativa no Tag do botão
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Size = new Size(400, 90), // Tamanho do botão
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                Name = $"btnAlternativa_{texto}",
                Margin = new Padding(5)
            };

            return btn;
        }
        private void BtnAlternativa_Click(object sender, EventArgs e)
        {
            alternativaEscolhida = true;
            CustomButton clickedButton = (CustomButton)sender;

            foreach (CustomButton btn in grbAlternativas.Controls)
            {
                btn.BackColor = Color.FromArgb(231, 76, 60);
            }

            clickedButton.BackColor = Color.FromArgb(153, 39, 30);

            // Salvar a resposta no dicionário
            respostas[num_perguntaAtual] = clickedButton.Text;
            idsPeguntaResposta[num_perguntaAtual] = (int) clickedButton.Tag; // Salvar o id da alternativa
        }

        public class CustomButton : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                base.OnPaint(pevent);

                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, 30, 30, 180, 90);
                path.AddArc(this.Width - 30, 0, 30, 30, 270, 90);
                path.AddArc(this.Width - 30, this.Height - 30, 30, 30, 0, 90);
                path.AddArc(0, this.Height - 30, 30, 30, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillPath(brush, path);
                }

                TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, new Point(Width / 2 - TextRenderer.MeasureText(this.Text, this.Font).Width / 2, Height / 2 - TextRenderer.MeasureText(this.Text, this.Font).Height / 2), this.ForeColor);
            }
        }
        #endregion  
    }
}
