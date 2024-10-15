namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblErro = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1065, 26);
            label1.Name = "label1";
            label1.Size = new Size(246, 100);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(1018, 266);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(329, 44);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Location = new Point(1018, 352);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(329, 44);
            txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.None;
            btnEntrar.BackColor = Color.FromArgb(255, 65, 65);
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 65, 65);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 65, 65);
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 65, 65);
            btnEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(1100, 546);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(172, 55);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(1018, 243);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.None;
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(1018, 329);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // lblErro
            // 
            lblErro.Anchor = AnchorStyles.None;
            lblErro.BackColor = Color.White;
            lblErro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(1008, 430);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(387, 90);
            lblErro.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(lblErro);
            panel1.Controls.Add(lblSenha);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1470, 666);
            panel1.TabIndex = 10;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1470, 666);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "FrmLogin";
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblErro;
        private Panel panel1;
    }
}