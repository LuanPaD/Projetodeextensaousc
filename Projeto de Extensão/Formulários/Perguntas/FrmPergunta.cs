using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Projeto_de_Extensão.Formulários.Perguntas
{
    public partial class FrmPergunta : Form
    {
        public FrmPergunta()
        {
            InitializeComponent();
            CriarAlternativas();
        }

        public void CriarAlternativas()
        {
            var alternativas = new List<string> { "Não", "Sim", "Não", "Sim" };
            CriarBotoesAlternativas(alternativas);
        }

        public void CriarBotoesAlternativas(List<string> alternativas)
        {
            int espacamentoVertical = calculaEspacamentoPorQtdAlternativas(alternativas.Count);
            int larguraGroupBox = grbAlternativas.Width;
            grbAlternativas.Controls.Clear();

            // Calcula a posição inicial Y para centralizar os botões

            int posicaoY = calculaPosicaoYPorQtdAlternativas();

            foreach (var alternativa in alternativas)
            {
                CustomButton btnAlternativa = CriarBotaoAlternativa(alternativa);
                btnAlternativa.Click += BtnAlternativa_Click;

                // Centraliza o botão horizontalmente no GroupBox
                int posicaoX = (larguraGroupBox - btnAlternativa.Width) / 2;
                btnAlternativa.Location = new Point(posicaoX, posicaoY);

                grbAlternativas.Controls.Add(btnAlternativa);
                posicaoY += btnAlternativa.Height + espacamentoVertical;
            }
        }

        private CustomButton CriarBotaoAlternativa(string texto)
        {
            return new CustomButton
            {
                Text = texto,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Size = new Size(400, 90), // Aumentando o tamanho do botão
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(231, 76, 60),
                ForeColor = Color.White,
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter,
                Name = $"btnAlternativa_{texto}",
                Margin = new Padding(5)
            };
        }

        private void BtnAlternativa_Click(object sender, EventArgs e)
        {
            CustomButton clickedButton = (CustomButton)sender;

            foreach (CustomButton btn in grbAlternativas.Controls)
            {
                btn.BackColor = Color.FromArgb(231, 76, 60);
            }

            clickedButton.BackColor = Color.FromArgb(192, 57, 43);
        }

        private int calculaEspacamentoPorQtdAlternativas(int quantidade)
        {
            if (quantidade <= 2) return 40;

            if (quantidade <= 4) return 30;

            return 10;
        }
        private int calculaPosicaoYPorQtdAlternativas(int quantidade)
        {
            //grbAlternativas.Height - (alternativas.Count * 60 + (alternativas.Count - 1) * espacamentoVertical)) / 2
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
}
