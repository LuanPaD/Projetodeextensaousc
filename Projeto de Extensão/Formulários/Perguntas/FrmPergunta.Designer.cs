namespace Projeto_de_Extensão.Formulários.Perguntas
{
    partial class FrmPergunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< Updated upstream
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(401, 199);
            button1.Name = "button1";
            button1.Size = new Size(250, 41);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPergunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "FrmPergunta";
            Text = "FrmPergunta";
            Load += FrmPergunta_Load;
            ResumeLayout(false);
=======
            ptbFundoPerguntas = new PictureBox();
            btnProximaPagina = new Button();
            btnPaginaAnterior = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbFundoPerguntas).BeginInit();
            SuspendLayout();
            // 
            // ptbFundoPerguntas
            // 
            ptbFundoPerguntas.BackColor = SystemColors.ControlDark;
            ptbFundoPerguntas.Image = Properties.Resources.Perguntas;
            ptbFundoPerguntas.Location = new Point(0, -3);
            ptbFundoPerguntas.Name = "ptbFundoPerguntas";
            ptbFundoPerguntas.Size = new Size(1366, 760);
            ptbFundoPerguntas.TabIndex = 0;
            ptbFundoPerguntas.TabStop = false;
            // 
            // btnProximaPagina
            // 
            btnProximaPagina.BackgroundImage = Properties.Resources.Group_856;
            btnProximaPagina.BackgroundImageLayout = ImageLayout.Stretch;
            btnProximaPagina.Location = new Point(1400, 600);
            btnProximaPagina.Name = "btnProximaPagina";
            btnProximaPagina.Size = new Size(46, 46);
            btnProximaPagina.TabIndex = 6;
            btnProximaPagina.TextAlign = ContentAlignment.TopLeft;
            btnProximaPagina.UseVisualStyleBackColor = true;
            btnProximaPagina.Click += button1_Click;
            // 
            // btnPaginaAnterior
            // 
            btnPaginaAnterior.Anchor = AnchorStyles.None;
            btnPaginaAnterior.AutoSize = true;
            btnPaginaAnterior.BackColor = SystemColors.Control;
            btnPaginaAnterior.BackgroundImage = Properties.Resources.Group_855;
            btnPaginaAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaginaAnterior.CausesValidation = false;
            btnPaginaAnterior.FlatStyle = FlatStyle.Flat;
            btnPaginaAnterior.ForeColor = SystemColors.Control;
            btnPaginaAnterior.Location = new Point(1222, 671);
            btnPaginaAnterior.Name = "btnPaginaAnterior";
            btnPaginaAnterior.Size = new Size(49, 46);
            btnPaginaAnterior.TabIndex = 7;
            btnPaginaAnterior.UseVisualStyleBackColor = false;
            btnPaginaAnterior.Click += btnPaginaAnterior_Click;
            // 
            // FrmPergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 729);
            Controls.Add(btnPaginaAnterior);
            Controls.Add(btnProximaPagina);
            Controls.Add(ptbFundoPerguntas);
            Name = "FrmPergunta";
            Text = "FrmPergunta";
            ((System.ComponentModel.ISupportInitialize)ptbFundoPerguntas).EndInit();
            ResumeLayout(false);
            PerformLayout();
>>>>>>> Stashed changes
        }

        #endregion

<<<<<<< Updated upstream
        private Button button1;
=======
        private PictureBox ptbFundoPerguntas;
        private Button btnProximaPagina;
        private Button btnPaginaAnterior;
>>>>>>> Stashed changes
    }
}