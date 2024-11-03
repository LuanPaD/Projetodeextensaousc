namespace Projeto_de_Extensao.Formulários.Cadastros
{
    partial class FrmEscolhaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscolhaInicial));
            tlpAlinhamento = new TableLayoutPanel();
            btnNovoCadastro = new Button();
            btnEditarCadastro = new Button();
            pbLogo = new PictureBox();
            btnRelatorio = new Button();
            tlpAlinhamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // tlpAlinhamento
            // 
            tlpAlinhamento.Anchor = AnchorStyles.None;
            tlpAlinhamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpAlinhamento.BackgroundImageLayout = ImageLayout.Center;
            tlpAlinhamento.ColumnCount = 3;
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.63943F));
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.72346F));
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6371117F));
            tlpAlinhamento.Controls.Add(btnNovoCadastro, 1, 2);
            tlpAlinhamento.Controls.Add(btnEditarCadastro, 1, 1);
            tlpAlinhamento.Controls.Add(pbLogo, 1, 0);
            tlpAlinhamento.Controls.Add(btnRelatorio, 1, 3);
            tlpAlinhamento.Location = new Point(0, 0);
            tlpAlinhamento.Name = "tlpAlinhamento";
            tlpAlinhamento.RowCount = 4;
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            tlpAlinhamento.Size = new Size(1349, 721);
            tlpAlinhamento.TabIndex = 4;
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Anchor = AnchorStyles.None;
            btnNovoCadastro.BackgroundImage = (Image)resources.GetObject("btnNovoCadastro.BackgroundImage");
            btnNovoCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovoCadastro.Cursor = Cursors.Hand;
            btnNovoCadastro.FlatAppearance.BorderSize = 0;
            btnNovoCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnNovoCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnNovoCadastro.FlatStyle = FlatStyle.Flat;
            btnNovoCadastro.Location = new Point(420, 435);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(507, 109);
            btnNovoCadastro.TabIndex = 2;
            btnNovoCadastro.UseVisualStyleBackColor = true;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // btnEditarCadastro
            // 
            btnEditarCadastro.Anchor = AnchorStyles.None;
            btnEditarCadastro.BackColor = Color.FromArgb(208, 212, 214);
            btnEditarCadastro.BackgroundImage = (Image)resources.GetObject("btnEditarCadastro.BackgroundImage");
            btnEditarCadastro.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditarCadastro.Cursor = Cursors.Hand;
            btnEditarCadastro.FlatAppearance.BorderSize = 0;
            btnEditarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnEditarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnEditarCadastro.FlatStyle = FlatStyle.Flat;
            btnEditarCadastro.Location = new Point(420, 262);
            btnEditarCadastro.Name = "btnEditarCadastro";
            btnEditarCadastro.Size = new Size(507, 109);
            btnEditarCadastro.TabIndex = 1;
            btnEditarCadastro.UseVisualStyleBackColor = false;
            btnEditarCadastro.Click += btnEditarCadastro_Click;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(335, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(677, 224);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Anchor = AnchorStyles.None;
            btnRelatorio.BackgroundImage = (Image)resources.GetObject("btnRelatorio.BackgroundImage");
            btnRelatorio.BackgroundImageLayout = ImageLayout.Stretch;
            btnRelatorio.Cursor = Cursors.Hand;
            btnRelatorio.FlatAppearance.BorderSize = 0;
            btnRelatorio.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnRelatorio.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnRelatorio.FlatStyle = FlatStyle.Flat;
            btnRelatorio.Location = new Point(420, 594);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(507, 109);
            btnRelatorio.TabIndex = 3;
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // FrmEscolhaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 721);
            Controls.Add(tlpAlinhamento);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEscolhaInicial";
            Text = "FrmEscolhaInicial";
            WindowState = FormWindowState.Maximized;
            tlpAlinhamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAlinhamento;
        private PictureBox pbLogo;
        private Button btnNovoCadastro;
        private Button btnEditarCadastro;
        private Button btnRelatorio;
    }
}