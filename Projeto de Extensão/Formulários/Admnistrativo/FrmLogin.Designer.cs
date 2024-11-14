
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
            panel2 = new Panel();
            lblDireitos = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            lblErro = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            tableLogin.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(1336, 671);
            panel1.TabIndex = 10;
            // 
            // tableLogin
            // 
            tableLogin.BackColor = Color.Transparent;
            tableLogin.ColumnCount = 2;
            tableLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLogin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLogin.Controls.Add(panel2, 1, 0);
            tableLogin.Controls.Add(panel3, 0, 0);
            tableLogin.Dock = DockStyle.Fill;
            tableLogin.Location = new Point(0, 0);
            tableLogin.Name = "tableLogin";
            tableLogin.RowCount = 1;
            tableLogin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLogin.Size = new Size(1336, 671);
            tableLogin.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblDireitos);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnEntrar);
            panel2.Controls.Add(lblErro);
            panel2.Controls.Add(lblSenha);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(lblUsuario);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(671, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(662, 665);
            panel2.TabIndex = 9;
            // 
            // lblDireitos
            // 
            lblDireitos.Anchor = AnchorStyles.Bottom;
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireitos.ForeColor = SystemColors.AppWorkspace;
            lblDireitos.Location = new Point(251, 631);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(200, 17);
            lblDireitos.TabIndex = 8;
            lblDireitos.Text = "Reserved directs to Unisagrado";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 6);
            label1.Name = "label1";
            label1.Size = new Size(178, 75);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Anchor = AnchorStyles.Bottom;
            btnEntrar.BackColor = Color.Transparent;
            btnEntrar.BackgroundImage = (Image)resources.GetObject("btnEntrar.BackgroundImage");
            btnEntrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEntrar.FlatAppearance.BorderColor = Color.FromArgb(255, 65, 65);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = SystemColors.ButtonFace;
            btnEntrar.Location = new Point(197, 554);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(287, 60);
            btnEntrar.TabIndex = 4;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblErro
            // 
            lblErro.Anchor = AnchorStyles.Bottom;
            lblErro.BackColor = Color.Transparent;
            lblErro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(176, 478);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(328, 56);
            lblErro.TabIndex = 7;
            lblErro.TextAlign = ContentAlignment.MiddleCenter;
            lblErro.Click += lblErro_Click;
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.None;
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblSenha.Location = new Point(305, 301);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(70, 30);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            lblSenha.Click += lblSenha_Click;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Font = new Font("Segoe UI", 15.75F);
            txtSenha.Location = new Point(176, 333);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(328, 35);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(176, 236);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(328, 35);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(297, 204);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 30);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(662, 665);
            panel3.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.167984F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8320236F));
            tableLayoutPanel1.Size = new Size(662, 665);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 542);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(656, 533);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1336, 671);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            tableLogin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel2;
        private Label lblErro;
        private Label lblSenha;
        private TextBox txtSenha;
        private Button btnEntrar;
        private TextBox txtUsuario;
        private Label label1;
        private Label lblUsuario;
        private Label lblDireitos;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}