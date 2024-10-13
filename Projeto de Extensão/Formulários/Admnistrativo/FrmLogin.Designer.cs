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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblErro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 721);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(978, 66);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(821, 279);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(387, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(821, 360);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(387, 27);
            txtSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(927, 525);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(172, 55);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(821, 256);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(821, 337);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // lblErro
            // 
            lblErro.BackColor = Color.White;
            lblErro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(821, 421);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(387, 90);
            lblErro.TabIndex = 7;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(lblErro);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnEntrar;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblErro;
    }
}