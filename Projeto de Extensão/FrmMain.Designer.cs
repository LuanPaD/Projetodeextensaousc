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
            tlpAlinhamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnAdmnistrador
            // 
            btnAdmnistrador.Anchor = AnchorStyles.None;
            btnAdmnistrador.BackgroundImage = (Image)resources.GetObject("btnAdmnistrador.BackgroundImage");
            btnAdmnistrador.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdmnistrador.Cursor = Cursors.Hand;
            btnAdmnistrador.FlatAppearance.BorderSize = 0;
            btnAdmnistrador.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnAdmnistrador.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnAdmnistrador.FlatStyle = FlatStyle.Flat;
            btnAdmnistrador.Location = new Point(420, 558);
            btnAdmnistrador.Name = "btnAdmnistrador";
            btnAdmnistrador.Size = new Size(507, 109);
            btnAdmnistrador.TabIndex = 2;
            btnAdmnistrador.UseVisualStyleBackColor = true;
            btnAdmnistrador.Click += btnAdmnistrador_Click;
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
            tlpAlinhamento.Controls.Add(pbLogo, 1, 0);
            tlpAlinhamento.Controls.Add(btnAdmnistrador, 1, 2);
            tlpAlinhamento.Controls.Add(btnAvaliar, 1, 1);
            tlpAlinhamento.Location = new Point(0, 0);
            tlpAlinhamento.Name = "tlpAlinhamento";
            tlpAlinhamento.RowCount = 3;
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tlpAlinhamento.Size = new Size(1349, 721);
            tlpAlinhamento.TabIndex = 3;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(335, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(677, 282);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnAvaliar
            // 
            btnAvaliar.Anchor = AnchorStyles.None;
            btnAvaliar.BackColor = Color.FromArgb(208, 212, 214);
            btnAvaliar.BackgroundImage = (Image)resources.GetObject("btnAvaliar.BackgroundImage");
            btnAvaliar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvaliar.Cursor = Cursors.Hand;
            btnAvaliar.FlatAppearance.BorderSize = 0;
            btnAvaliar.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnAvaliar.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnAvaliar.FlatStyle = FlatStyle.Flat;
            btnAvaliar.Location = new Point(420, 341);
            btnAvaliar.Name = "btnAvaliar";
            btnAvaliar.Size = new Size(507, 109);
            btnAvaliar.TabIndex = 1;
            btnAvaliar.UseVisualStyleBackColor = false;
            btnAvaliar.Click += btnAvaliar_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(208, 212, 214);
            ClientSize = new Size(1349, 721);
            Controls.Add(tlpAlinhamento);
            Name = "FrmMain";
            Text = "Form1";
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
    }
}