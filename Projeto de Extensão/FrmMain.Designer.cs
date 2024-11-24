namespace Projeto_de_Extensão
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnAdmnistrador = new Button();
            tlpAlinhamento = new TableLayoutPanel();
            pbLogo = new PictureBox();
            btnAvaliar = new Button();
            btnCreditos = new Button();
            tlpAlinhamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnAdmnistrador
            // 
            btnAdmnistrador.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdmnistrador.BackgroundImage = (Image)resources.GetObject("btnAdmnistrador.BackgroundImage");
            btnAdmnistrador.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdmnistrador.Cursor = Cursors.Hand;
            btnAdmnistrador.FlatAppearance.BorderSize = 0;
            btnAdmnistrador.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdmnistrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnAdmnistrador.FlatStyle = FlatStyle.Flat;
            btnAdmnistrador.Location = new Point(1104, 472);
            btnAdmnistrador.Margin = new Padding(15);
            btnAdmnistrador.Name = "btnAdmnistrador";
            btnAdmnistrador.Size = new Size(61, 54);
            btnAdmnistrador.TabIndex = 2;
            btnAdmnistrador.UseVisualStyleBackColor = true;
            btnAdmnistrador.Click += btnAdmnistrador_Click;
            // 
            // tlpAlinhamento
            // 
            tlpAlinhamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpAlinhamento.BackColor = SystemColors.Control;
            tlpAlinhamento.BackgroundImageLayout = ImageLayout.Center;
            tlpAlinhamento.ColumnCount = 3;
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.63943F));
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.72346F));
            tlpAlinhamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6371117F));
            tlpAlinhamento.Controls.Add(pbLogo, 1, 0);
            tlpAlinhamento.Controls.Add(btnAvaliar, 1, 1);
            tlpAlinhamento.Controls.Add(btnAdmnistrador, 2, 2);
            tlpAlinhamento.Controls.Add(btnCreditos, 0, 2);
            tlpAlinhamento.Dock = DockStyle.Fill;
            tlpAlinhamento.Location = new Point(0, 0);
            tlpAlinhamento.Margin = new Padding(3, 2, 3, 2);
            tlpAlinhamento.Name = "tlpAlinhamento";
            tlpAlinhamento.RowCount = 3;
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.Size = new Size(1180, 541);
            tlpAlinhamento.TabIndex = 3;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(293, 2);
            pbLogo.Margin = new Padding(3, 2, 3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(592, 212);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnAvaliar
            // 
            btnAvaliar.Anchor = AnchorStyles.None;
            btnAvaliar.BackColor = SystemColors.InactiveBorder;
            btnAvaliar.BackgroundImage = (Image)resources.GetObject("btnAvaliar.BackgroundImage");
            btnAvaliar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvaliar.Cursor = Cursors.Hand;
            btnAvaliar.FlatAppearance.BorderSize = 0;
            btnAvaliar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAvaliar.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnAvaliar.FlatStyle = FlatStyle.Flat;
            btnAvaliar.Location = new Point(367, 256);
            btnAvaliar.Margin = new Padding(3, 2, 3, 2);
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.Size = new Size(444, 82);
            btnAvaliar.TabIndex = 1;
            btnAvaliar.UseVisualStyleBackColor = false;
            btnAvaliar.Click += btnAvaliar_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreditos.BackgroundImage = (Image)resources.GetObject("btnCreditos.BackgroundImage");
            btnCreditos.BackgroundImageLayout = ImageLayout.Stretch;
            btnCreditos.Cursor = Cursors.Hand;
            btnCreditos.FlatAppearance.BorderSize = 0;
            btnCreditos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCreditos.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Location = new Point(15, 472);
            btnCreditos.Margin = new Padding(15);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(61, 54);
            btnCreditos.TabIndex = 3;
            btnCreditos.UseVisualStyleBackColor = true;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 212, 214);
            ClientSize = new Size(1180, 541);
            Controls.Add(tlpAlinhamento);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "Sistema de Avaliação - UNISAGRADO";
            WindowState = FormWindowState.Maximized;
            tlpAlinhamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdmnistrador;
        private TableLayoutPanel tlpAlinhamento;
        private PictureBox pbLogo;
        private Button btnAvaliar;
        private Button btnCreditos;
    }
}