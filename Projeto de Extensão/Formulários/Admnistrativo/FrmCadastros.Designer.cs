﻿namespace Projeto_de_Extensao.Formulários.Admnistrativo
{
    partial class FrmCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastros));
            pnlMenu = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUsuario = new Button();
            btnSetor = new Button();
            btnPerguntas = new Button();
            btnAjuda = new Button();
            panelTopo = new Panel();
            pictureBoxLogo = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSair = new Button();
            tbcPaginas = new TabControl();
            tbSetor = new TabPage();
            label2 = new Label();
            tbPerguntas = new TabPage();
            label1 = new Label();
            tbUsuario = new TabPage();
            btnCadastrar = new Button();
            txtConfirmaSenha = new TextBox();
            lblConfirmaSenha = new Label();
            lblTitulo = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            tbAjuda = new TabPage();
            lblTituloAjuda = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pnlMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tbcPaginas.SuspendLayout();
            tbSetor.SuspendLayout();
            tbPerguntas.SuspendLayout();
            tbUsuario.SuspendLayout();
            tbAjuda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Brown;
            pnlMenu.Controls.Add(tableLayoutPanel1);
            pnlMenu.Controls.Add(panelTopo);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(297, 727);
            pnlMenu.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnUsuario, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSetor, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPerguntas, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAjuda, 0, 3);
            tableLayoutPanel1.Location = new Point(7, 159);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(297, 343);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Brown;
            btnUsuario.BackgroundImage = (Image)resources.GetObject("btnUsuario.BackgroundImage");
            btnUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            btnUsuario.Dock = DockStyle.Fill;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.White;
            btnUsuario.Location = new Point(3, 174);
            btnUsuario.Margin = new Padding(3, 4, 3, 4);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(291, 77);
            btnUsuario.TabIndex = 13;
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnSetor
            // 
            btnSetor.BackColor = Color.Brown;
            btnSetor.BackgroundImage = (Image)resources.GetObject("btnSetor.BackgroundImage");
            btnSetor.BackgroundImageLayout = ImageLayout.Stretch;
            btnSetor.Dock = DockStyle.Fill;
            btnSetor.FlatAppearance.BorderSize = 0;
            btnSetor.FlatStyle = FlatStyle.Flat;
            btnSetor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetor.ForeColor = Color.White;
            btnSetor.Location = new Point(3, 4);
            btnSetor.Margin = new Padding(3, 4, 3, 4);
            btnSetor.Name = "btnSetor";
            btnSetor.Size = new Size(291, 77);
            btnSetor.TabIndex = 8;
            btnSetor.UseVisualStyleBackColor = false;
            btnSetor.Click += btnSetor_Click;
            // 
            // btnPerguntas
            // 
            btnPerguntas.BackColor = Color.Brown;
            btnPerguntas.BackgroundImage = (Image)resources.GetObject("btnPerguntas.BackgroundImage");
            btnPerguntas.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerguntas.Dock = DockStyle.Fill;
            btnPerguntas.FlatAppearance.BorderSize = 0;
            btnPerguntas.FlatStyle = FlatStyle.Flat;
            btnPerguntas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPerguntas.ForeColor = Color.White;
            btnPerguntas.Location = new Point(3, 89);
            btnPerguntas.Margin = new Padding(3, 4, 3, 4);
            btnPerguntas.Name = "btnPerguntas";
            btnPerguntas.Size = new Size(291, 77);
            btnPerguntas.TabIndex = 12;
            btnPerguntas.UseVisualStyleBackColor = false;
            btnPerguntas.Click += btnPerguntas_Click;
            // 
            // btnAjuda
            // 
            btnAjuda.BackColor = Color.Brown;
            btnAjuda.BackgroundImage = (Image)resources.GetObject("btnAjuda.BackgroundImage");
            btnAjuda.BackgroundImageLayout = ImageLayout.Stretch;
            btnAjuda.Dock = DockStyle.Fill;
            btnAjuda.FlatAppearance.BorderSize = 0;
            btnAjuda.FlatStyle = FlatStyle.Flat;
            btnAjuda.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjuda.ForeColor = Color.White;
            btnAjuda.Location = new Point(3, 259);
            btnAjuda.Margin = new Padding(3, 4, 3, 4);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(291, 80);
            btnAjuda.TabIndex = 14;
            btnAjuda.UseVisualStyleBackColor = false;
            btnAjuda.Click += btnAjuda_Click;
            // 
            // panelTopo
            // 
            panelTopo.Controls.Add(pictureBoxLogo);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Margin = new Padding(7, 8, 7, 8);
            panelTopo.Name = "panelTopo";
            panelTopo.Padding = new Padding(7, 8, 7, 8);
            panelTopo.Size = new Size(297, 149);
            panelTopo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(7, 8);
            pictureBoxLogo.Margin = new Padding(11, 13, 11, 13);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Padding = new Padding(11, 13, 11, 13);
            pictureBoxLogo.Size = new Size(283, 133);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 506);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 221);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnSair, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            tableLayoutPanel2.Size = new Size(297, 221);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Brown;
            btnSair.BackgroundImage = (Image)resources.GetObject("btnSair.BackgroundImage");
            btnSair.BackgroundImageLayout = ImageLayout.Stretch;
            btnSair.Dock = DockStyle.Fill;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(3, 132);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(291, 85);
            btnSair.TabIndex = 19;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // tbcPaginas
            // 
            tbcPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcPaginas.Controls.Add(tbSetor);
            tbcPaginas.Controls.Add(tbPerguntas);
            tbcPaginas.Controls.Add(tbUsuario);
            tbcPaginas.Controls.Add(tbAjuda);
            tbcPaginas.Location = new Point(297, 8);
            tbcPaginas.Margin = new Padding(3, 4, 3, 4);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(774, 718);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 9;
            // 
            // tbSetor
            // 
            tbSetor.Controls.Add(label2);
            tbSetor.ForeColor = Color.Transparent;
            tbSetor.Location = new Point(4, 29);
            tbSetor.Margin = new Padding(3, 4, 3, 4);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3, 4, 3, 4);
            tbSetor.Size = new Size(766, 685);
            tbSetor.TabIndex = 0;
            tbSetor.Text = "Setor";
            tbSetor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(361, 461);
            label2.Name = "label2";
            label2.Size = new Size(185, 54);
            label2.TabIndex = 1;
            label2.Text = "SETOR";
            // 
            // tbPerguntas
            // 
            tbPerguntas.Controls.Add(label1);
            tbPerguntas.Location = new Point(4, 29);
            tbPerguntas.Margin = new Padding(3, 4, 3, 4);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3, 4, 3, 4);
            tbPerguntas.Size = new Size(766, 685);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 479);
            label1.Name = "label1";
            label1.Size = new Size(315, 54);
            label1.TabIndex = 0;
            label1.Text = "PERGUNTAS";
            // 
            // tbUsuario
            // 
            tbUsuario.Controls.Add(btnCadastrar);
            tbUsuario.Controls.Add(txtConfirmaSenha);
            tbUsuario.Controls.Add(lblConfirmaSenha);
            tbUsuario.Controls.Add(lblTitulo);
            tbUsuario.Controls.Add(txtSenha);
            tbUsuario.Controls.Add(lblSenha);
            tbUsuario.Controls.Add(txtNome);
            tbUsuario.Controls.Add(lblNome);
            tbUsuario.Controls.Add(txtEmail);
            tbUsuario.Controls.Add(lblEmail);
            tbUsuario.Location = new Point(4, 29);
            tbUsuario.Margin = new Padding(3, 4, 3, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Padding = new Padding(3, 4, 3, 4);
            tbUsuario.Size = new Size(766, 685);
            tbUsuario.TabIndex = 2;
            tbUsuario.Text = "Usuário";
            tbUsuario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(338, 518);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(160, 76);
            btnCadastrar.TabIndex = 18;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(331, 359);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(175, 27);
            txtConfirmaSenha.TabIndex = 15;
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(359, 336);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(119, 20);
            lblConfirmaSenha.TabIndex = 14;
            lblConfirmaSenha.Text = "Confirmar Senha";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(262, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(312, 31);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Cadastro de Administradores";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(331, 294);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(175, 27);
            txtSenha.TabIndex = 12;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(395, 271);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(47, 20);
            lblSenha.TabIndex = 11;
            lblSenha.Text = "senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(331, 188);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(175, 27);
            txtNome.TabIndex = 9;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(393, 165);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 20);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(331, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(395, 218);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // tbAjuda
            // 
            tbAjuda.Controls.Add(lblTituloAjuda);
            tbAjuda.Location = new Point(4, 29);
            tbAjuda.Margin = new Padding(3, 4, 3, 4);
            tbAjuda.Name = "tbAjuda";
            tbAjuda.Padding = new Padding(3, 4, 3, 4);
            tbAjuda.Size = new Size(766, 685);
            tbAjuda.TabIndex = 3;
            tbAjuda.Text = "Ajuda";
            tbAjuda.UseVisualStyleBackColor = true;
            // 
            // lblTituloAjuda
            // 
            lblTituloAjuda.AutoSize = true;
            lblTituloAjuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloAjuda.Location = new Point(322, 172);
            lblTituloAjuda.Name = "lblTituloAjuda";
            lblTituloAjuda.Size = new Size(84, 31);
            lblTituloAjuda.TabIndex = 14;
            lblTituloAjuda.Text = "AJUDA";
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 727);
            Controls.Add(tbcPaginas);
            Controls.Add(pnlMenu);
            Name = "FrmCadastros";
            Text = "FrmCadastros";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tbcPaginas.ResumeLayout(false);
            tbSetor.ResumeLayout(false);
            tbSetor.PerformLayout();
            tbPerguntas.ResumeLayout(false);
            tbPerguntas.PerformLayout();
            tbUsuario.ResumeLayout(false);
            tbUsuario.PerformLayout();
            tbAjuda.ResumeLayout(false);
            tbAjuda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Panel panelTopo;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSetor;
        private Panel panel1;
        private Button btnAjuda;
        private Button btnUsuario;
        private Button btnPerguntas;
        private TabControl tbcPaginas;
        private TabPage tbSetor;
        private TabPage tbPerguntas;
        private TabPage tbUsuario;
        private TabPage tbAjuda;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSair;
        private Button btnCadastrar;
        private TextBox txtConfirmaSenha;
        private Label lblConfirmaSenha;
        private Label lblTitulo;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblTituloAjuda;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}