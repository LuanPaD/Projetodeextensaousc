
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
            panel1 = new Panel();
            tableLogin = new TableLayoutPanel();
            tableImagens = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            lblErro = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            txtUsuario = new TextBox();
            label1 = new Label();
            lblUsuario = new Label();
            lblDireitos = new Label();
            panel1.SuspendLayout();
            tableLogin.SuspendLayout();
            tableImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableLogin);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1244, 498);
            panel1.TabIndex = 10;
            // 
            // tableLogin
            // 
            tableLogin.BackColor = Color.Transparent;
            tableLogin.ColumnCount = 2;
            tableLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLogin.Controls.Add(tableImagens, 0, 0);
            tableLogin.Controls.Add(panel2, 1, 0);
            tableLogin.Dock = DockStyle.Fill;
            tableLogin.Location = new Point(0, 0);
            tableLogin.Name = "tableLogin";
            tableLogin.RowCount = 1;
            tableLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLogin.Size = new Size(1244, 498);
            tableLogin.TabIndex = 10;
            // 
            // tableImagens
            // 
            tableImagens.ColumnCount = 1;
            tableImagens.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableImagens.Controls.Add(pictureBox1, 0, 0);
            tableImagens.Controls.Add(pictureBox2, 0, 1);
            tableImagens.Dock = DockStyle.Fill;
            tableImagens.Location = new Point(3, 3);
            tableImagens.Name = "tableImagens";
            tableImagens.RowCount = 2;
            tableImagens.RowStyles.Add(new RowStyle(SizeType.Percent, 81.91057F));
            tableImagens.RowStyles.Add(new RowStyle(SizeType.Percent, 18.0894318F));
            tableImagens.Size = new Size(616, 492);
            tableImagens.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(610, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(610, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblErro);
            panel2.Controls.Add(lblSenha);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblUsuario);
            panel2.Controls.Add(lblDireitos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(625, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 492);
            panel2.TabIndex = 9;
            // 
            // lblErro
            // 
            lblErro.Anchor = AnchorStyles.None;
            lblErro.BackColor = Color.Transparent;
            lblErro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(174, 318);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(288, 68);
            lblErro.TabIndex = 7;
            lblErro.Click += lblErro_Click;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.None;
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Location = new Point(299, 243);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(174, 260);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(288, 23);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
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
            btnEntrar.Location = new Point(243, 406);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(150, 41);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Location = new Point(174, 196);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(288, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 16);
            label1.Name = "label1";
            label1.Size = new Size(182, 75);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Location = new Point(295, 178);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblDireitos
            // 
            lblDireitos.Anchor = AnchorStyles.None;
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireitos.ForeColor = SystemColors.AppWorkspace;
            lblDireitos.Location = new Point(218, 460);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(200, 17);
            lblDireitos.TabIndex = 8;
            lblDireitos.Text = "Reserved directs to Unisagrado";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1244, 498);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            tableLogin.ResumeLayout(false);
            tableImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
           
        }

        private void lblErro_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

#endregion
        private Panel panel1;
        private TableLayoutPanel tableLogin;
        private TableLayoutPanel tableImagens;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label lblErro;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private TextBox txtUsuario;
        private Label label1;
        private Label lblUsuario;
        private Label lblDireitos;
    }
}