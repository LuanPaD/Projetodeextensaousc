namespace Projeto_de_Extensão.Formulários.Perguntas
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
            btnAvancar = new Button();
            btnProximaPagina = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnPaginaAnterior = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAvancar
            // 
            btnAvancar.Location = new Point(895, 595);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(250, 41);
            btnAvancar.TabIndex = 0;
            btnAvancar.Text = "Avançar";
            btnAvancar.UseVisualStyleBackColor = true;
            // 
            // btnProximaPagina
            // 
            btnProximaPagina.BackgroundImage = (Image)resources.GetObject("btnProximaPagina.BackgroundImage");
            btnProximaPagina.BackgroundImageLayout = ImageLayout.Stretch;
            btnProximaPagina.Location = new Point(1263, 71);
            btnProximaPagina.Name = "btnProximaPagina";
            btnProximaPagina.Size = new Size(46, 46);
            btnProximaPagina.TabIndex = 6;
            btnProximaPagina.TextAlign = ContentAlignment.TopLeft;
            btnProximaPagina.UseVisualStyleBackColor = true;
            btnProximaPagina.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 721);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(963, 97);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 8;
            label1.Text = "N / N";
            // 
            // btnPaginaAnterior
            // 
            btnPaginaAnterior.BackgroundImage = (Image)resources.GetObject("btnPaginaAnterior.BackgroundImage");
            btnPaginaAnterior.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaginaAnterior.Location = new Point(682, 71);
            btnPaginaAnterior.Name = "btnPaginaAnterior";
            btnPaginaAnterior.Size = new Size(46, 46);
            btnPaginaAnterior.TabIndex = 9;
            btnPaginaAnterior.TextAlign = ContentAlignment.TopLeft;
            btnPaginaAnterior.UseVisualStyleBackColor = true;
            // 
            // FrmPergunta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1348, 721);
            Controls.Add(btnPaginaAnterior);
            Controls.Add(btnProximaPagina);
            Controls.Add(label1);
            Controls.Add(btnAvancar);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "FrmPergunta";
            Text = "FrmPergunta";
            Load += FrmPergunta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAvancar;
        private Button btnProximaPagina;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnPaginaAnterior;
    }
}