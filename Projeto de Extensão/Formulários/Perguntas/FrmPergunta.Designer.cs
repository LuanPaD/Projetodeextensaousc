﻿namespace Projeto_de_Extensão.Formulários.Perguntas
{
    partial class FrmPergunta
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPergunta));
            pictureBox1 = new PictureBox();
            tableImagens = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pnlDirects = new Panel();
            btnFinalizarAvaliacao = new Button();
            lblDireitos = new Label();
            panel2 = new Panel();
            grbAlternativas = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel5 = new Panel();
            btnPerguntaAnterior = new Button();
            panel4 = new Panel();
            btnProximaPergunta = new Button();
            lblPergunta = new Label();
            label1 = new Label();
            lblQtdPerguntas = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            pnlDirects.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1335, 616);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tableImagens
            // 
            tableImagens.BackColor = Color.Transparent;
            tableImagens.ColumnCount = 1;
            tableImagens.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableImagens.Controls.Add(pictureBox3, 0, 1);
            tableImagens.Controls.Add(pictureBox2, 0, 0);
            tableImagens.Dock = DockStyle.Fill;
            tableImagens.Location = new Point(3, 3);
            tableImagens.Name = "tableImagens";
            tableImagens.RowCount = 2;
            tableImagens.RowStyles.Add(new RowStyle(SizeType.Percent, 81.9F));
            tableImagens.RowStyles.Add(new RowStyle(SizeType.Percent, 18.1F));
            tableImagens.Size = new Size(661, 610);
            tableImagens.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 502);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Padding = new Padding(0, 0, 0, 8);
            pictureBox3.Size = new Size(655, 105);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(655, 493);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableImagens, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1335, 616);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pnlDirects);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft Sans Serif", 15.75F);
            panel1.Location = new Point(670, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 610);
            panel1.TabIndex = 13;
            // 
            // pnlDirects
            // 
            pnlDirects.Controls.Add(btnFinalizarAvaliacao);
            pnlDirects.Controls.Add(lblDireitos);
            pnlDirects.Dock = DockStyle.Bottom;
            pnlDirects.Location = new Point(0, 548);
            pnlDirects.Name = "pnlDirects";
            pnlDirects.Size = new Size(662, 62);
            pnlDirects.TabIndex = 15;
            // 
            // btnFinalizarAvaliacao
            // 
            btnFinalizarAvaliacao.Anchor = AnchorStyles.None;
            btnFinalizarAvaliacao.BackColor = Color.Brown;
            btnFinalizarAvaliacao.BackgroundImage = (Image)resources.GetObject("btnFinalizarAvaliacao.BackgroundImage");
            btnFinalizarAvaliacao.BackgroundImageLayout = ImageLayout.Stretch;
            btnFinalizarAvaliacao.Location = new Point(162, 0);
            btnFinalizarAvaliacao.Name = "btnFinalizarAvaliacao";
            btnFinalizarAvaliacao.Size = new Size(338, 62);
            btnFinalizarAvaliacao.TabIndex = 16;
            btnFinalizarAvaliacao.UseVisualStyleBackColor = false;
            btnFinalizarAvaliacao.Click += btnFinalizarAvaliacao_Click;
            // 
            // lblDireitos
            // 
            lblDireitos.Anchor = AnchorStyles.None;
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireitos.ForeColor = SystemColors.AppWorkspace;
            lblDireitos.Location = new Point(233, 42);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(200, 17);
            lblDireitos.TabIndex = 9;
            lblDireitos.Text = "Reserved directs to Unisagrado";
            // 
            // panel2
            // 
            panel2.Controls.Add(grbAlternativas);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 610);
            panel2.TabIndex = 16;
            // 
            // grbAlternativas
            // 
            grbAlternativas.Dock = DockStyle.Fill;
            grbAlternativas.FlatStyle = FlatStyle.Flat;
            grbAlternativas.Location = new Point(0, 174);
            grbAlternativas.Name = "grbAlternativas";
            grbAlternativas.Size = new Size(662, 436);
            grbAlternativas.TabIndex = 20;
            grbAlternativas.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(lblQtdPerguntas, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.41791F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.58209F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(662, 174);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblPergunta);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 68);
            panel3.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnPerguntaAnterior);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(83, 68);
            panel5.TabIndex = 15;
            // 
            // btnPerguntaAnterior
            // 
            btnPerguntaAnterior.Anchor = AnchorStyles.None;
            btnPerguntaAnterior.BackColor = Color.FromArgb(181, 0, 0);
            btnPerguntaAnterior.BackgroundImage = Projeto_de_Extensao.Properties.Resources.Group_855;
            btnPerguntaAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerguntaAnterior.ForeColor = Color.FromArgb(181, 0, 0);
            btnPerguntaAnterior.Location = new Point(4, 3);
            btnPerguntaAnterior.Name = "btnPerguntaAnterior";
            btnPerguntaAnterior.Size = new Size(76, 62);
            btnPerguntaAnterior.TabIndex = 1;
            btnPerguntaAnterior.UseVisualStyleBackColor = false;
            btnPerguntaAnterior.Click += btnPerguntaAnterior_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnProximaPergunta);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(552, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(104, 68);
            panel4.TabIndex = 15;
            // 
            // btnProximaPergunta
            // 
            btnProximaPergunta.Anchor = AnchorStyles.Left;
            btnProximaPergunta.BackColor = Color.FromArgb(181, 0, 0);
            btnProximaPergunta.BackgroundImage = Projeto_de_Extensao.Properties.Resources.Group_856;
            btnProximaPergunta.BackgroundImageLayout = ImageLayout.Stretch;
            btnProximaPergunta.Font = new Font("Microsoft Sans Serif", 26.25F);
            btnProximaPergunta.ForeColor = Color.FromArgb(181, 0, 0);
            btnProximaPergunta.Location = new Point(3, 3);
            btnProximaPergunta.Name = "btnProximaPergunta";
            btnProximaPergunta.Size = new Size(72, 62);
            btnProximaPergunta.TabIndex = 2;
            btnProximaPergunta.UseVisualStyleBackColor = false;
            btnProximaPergunta.Click += btnProximaPergunta_Click;
            // 
            // lblPergunta
            // 
            lblPergunta.Anchor = AnchorStyles.None;
            lblPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPergunta.Location = new Point(86, 0);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(470, 65);
            lblPergunta.TabIndex = 3;
            lblPergunta.Text = "Texto";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 1);
            label1.Name = "label1";
            label1.Size = new Size(307, 65);
            label1.TabIndex = 0;
            label1.Text = "PERGUNTAS";
            // 
            // lblQtdPerguntas
            // 
            lblQtdPerguntas.Dock = DockStyle.Fill;
            lblQtdPerguntas.Location = new Point(3, 67);
            lblQtdPerguntas.Name = "lblQtdPerguntas";
            lblQtdPerguntas.Size = new Size(656, 33);
            lblQtdPerguntas.TabIndex = 16;
            lblQtdPerguntas.Text = "N/N";
            lblQtdPerguntas.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FrmPergunta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 616);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmPergunta";
            Text = "FrmPergunta";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlDirects.ResumeLayout(false);
            pnlDirects.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TableLayoutPanel tableImagens;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label lblPergunta;
        private Button btnProximaPergunta;
        private Button btnPerguntaAnterior;
        private Label lblDireitos;
        private Panel pnlDirects;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private GroupBox grbAlternativas;
        private Label lblQtdPerguntas;
        private Button btnFinalizarAvaliacao;
    }
}