﻿using MySqlConnector;
using Projeto_de_Extensao.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projeto_de_Extensão.Formulários.Perguntas
{
    public partial class FrmPergunta : Form
    {
        public FrmPergunta(int AtendenteId)
        {
            InitializeComponent();
            CriarAlternativas();
        }

        public async void CriarAlternativas()
        {
            //var alternativas = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            //var alternativas = new List<string> { "1", "2", "3", "4", "5"};
            //lblPergunta.Text ="Pergunta Genérica"; 

            List<string> alternativas = await getPertguntaEalternativas();
            CriarBotoesAlternativas(alternativas);
        }

        private async Task<List<string>> getPertguntaEalternativas()
        {
            MessageBox.Show("Por enquanto só ta pegando a 1a pergunta pq n ta feito os botoes de avançar ainda! se n cadastrou pergunta ainda descomenta a linha de alternativas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            int IDpergunta = 0;
            List<string> alternativas = new List<string>();

            string sqlPergunta = "SELECT pergunta_id, texto FROM perguntas LIMIT 1";

            try
            {
                using (var cmd = new MySqlCommand(sqlPergunta, ClsConexao.Conexao))
                {
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao buscar pergunta: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return alternativas; 
            }

            string sqlAlternativas = "SELECT texto FROM opcoes WHERE pergunta_id = @pergunta_id";

            try
            {
                using (var cmd = new MySqlCommand(sqlAlternativas, ClsConexao.Conexao))
                {
                    cmd.Parameters.AddWithValue("@pergunta_id", IDpergunta);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            alternativas.Add(reader.GetString("texto"));
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


        #region Botões

        public void CriarBotoesAlternativas(List<string> alternativas)
        {
            int espacamentoVertical = calculaEspacamentoPorQtdAlternativas(alternativas.Count);
            int larguraGroupBox = grbAlternativas.Width;
            int alturaGroupBox = grbAlternativas.Height;
            grbAlternativas.Controls.Clear();

            // Calcula a posição inicial para os botões
            // Se a quantidade de botões for maior, distribui em múltiplas colunas
            if (alternativas.Count <= 5)
            {
                // Distribui os botões verticalmente
                DistribuirBotoesVerticalmente(alternativas, larguraGroupBox, alturaGroupBox, espacamentoVertical);
            }
            else
            {
                // Distribui os botões em múltiplas colunas
                DistribuirBotoesEmColunas(alternativas, larguraGroupBox, alturaGroupBox, espacamentoVertical);
            }
        }

        private void DistribuirBotoesVerticalmente(List<string> alternativas, int larguraGroupBox, int alturaGroupBox, int espacamentoVertical)
        {
            int posicaoY = 30;  // Começar no topo do GroupBox

            foreach (var alternativa in alternativas)
            {
                CustomButton btnAlternativa = CriarBotaoAlternativa(alternativa, alternativas);
                btnAlternativa.Click += BtnAlternativa_Click;

                // Centraliza o botão horizontalmente
                int posicaoX = (larguraGroupBox - btnAlternativa.Width) / 2;
                btnAlternativa.Location = new Point(posicaoX, posicaoY);

                grbAlternativas.Controls.Add(btnAlternativa);
                posicaoY += btnAlternativa.Height + espacamentoVertical;
            }
        }

        private void DistribuirBotoesEmColunas(List<string> alternativas, int larguraGroupBox, int alturaGroupBox, int espacamentoVertical)
        {
            int numColunas = 2;  // Definindo um número fixo de colunas
            int numLinhas = (int)Math.Ceiling(alternativas.Count / (double)numColunas);
            int larguraColuna = larguraGroupBox / numColunas;  // Largura disponível para cada coluna
            int alturaBotao = 90;  // Altura do botão

            int posicaoX, posicaoY;

            // Para cada coluna
            for (int coluna = 0; coluna < numColunas; coluna++)
            {
                // Ajusta o posicionamento horizontal para evitar que os botões da primeira coluna fiquem cortados
                if (coluna == 0)
                {
                    posicaoX = (coluna * larguraColuna + (larguraColuna - 400) / 4) + 90; // Aumenta o recuo para a primeira coluna
                }
                else
                {
                    posicaoX = coluna * larguraColuna + (larguraColuna - 400) / 2; // Para a segunda coluna, centraliza normalmente
                }

                posicaoY = 10;  // Começa no topo do GroupBox

                // Para cada linha dentro da coluna
                for (int linha = 0; linha < numLinhas; linha++)
                {
                    int indiceBotao = linha * numColunas + coluna;

                    if (indiceBotao >= alternativas.Count)
                        break;

                    var alternativa = alternativas[indiceBotao];
                    CustomButton btnAlternativa = CriarBotaoAlternativa(alternativa, alternativas);
                    btnAlternativa.Click += BtnAlternativa_Click;

                    // Define a posição do botão
                    btnAlternativa.Location = new Point(posicaoX, posicaoY);
                    grbAlternativas.Controls.Add(btnAlternativa);

                    posicaoY += alturaBotao + espacamentoVertical;
                }
            }
        }




        private CustomButton CriarBotaoAlternativa(string texto, List<string> alternativas)
        {
            return new CustomButton
            {
                Text = texto,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),

                Size = alternativas.Count <= 5 ? new Size(400, 90) : new Size(270, 70), // Tamanho do botão
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                TextAlign = alternativas.Count <= 5 ? ContentAlignment.MiddleCenter : ContentAlignment.MiddleRight,
                Name = $"btnAlternativa_{texto}",
                Margin = new Padding(5)
            };
        }

        private void BtnAlternativa_Click(object sender, EventArgs e)
        {
            CustomButton clickedButton = (CustomButton)sender;

            foreach (CustomButton btn in grbAlternativas.Controls)
            {
                btn.BackColor = Color.FromArgb(231, 76, 60); // Cor original
            }

            // Escurecer o botão clicado
            clickedButton.BackColor = Color.FromArgb(153, 39, 30); // Cor mais escura
        }

        private int calculaEspacamentoPorQtdAlternativas(int quantidade)
        {
            if (quantidade <= 2) return 40;
            if (quantidade <= 4) return 30;
            return 10;
        }
    }

    public class CustomButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Definindo bordas arredondadas
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 30, 30, 180, 90); // Canto superior esquerdo
            path.AddArc(this.Width - 30, 0, 30, 30, 270, 90); // Canto superior direito
            path.AddArc(this.Width - 30, this.Height - 30, 30, 30, 0, 90); // Canto inferior direito
            path.AddArc(0, this.Height - 30, 30, 30, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            this.Region = new Region(path);

            // Preenchendo o fundo e a borda do botão
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillPath(brush, path);
            }

            // Desenhando o texto
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, new Point(Width / 2 - TextRenderer.MeasureText(this.Text, this.Font).Width / 2, Height / 2 - TextRenderer.MeasureText(this.Text, this.Font).Height / 2), this.ForeColor);
        }
    }
    #endregion
}
