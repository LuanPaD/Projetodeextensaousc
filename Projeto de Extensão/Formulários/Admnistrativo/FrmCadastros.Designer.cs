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
            tlpBotoesEscolha = new TableLayoutPanel();
            btnAdmin = new Button();
            btnSetor = new Button();
            btnPerguntas = new Button();
            btnAtendentes = new Button();
            panelTopo = new Panel();
            pictureBoxLogo = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSair = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tbAtendente = new TabPage();
            cmbListaDeSetores = new ComboBox();
            lblErro2 = new Label();
            lblSetor = new Label();
            btnHomeAtendentes = new Button();
            btnCadastraAtendente = new Button();
            txtEmail2 = new TextBox();
            txtNome2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            tbAdmin = new TabPage();
            lblErro = new Label();
            btnHomeAdmin = new Button();
            button9 = new Button();
            txtEmail = new TextBox();
            txtConfirmaSenha = new TextBox();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            lblEmail = new Label();
            lblNome = new Label();
            lblConfirmarSenha = new Label();
            lblAdministradores = new Label();
            lblSenha = new Label();
            tbPerguntas = new TabPage();
            button2 = new Button();
            btnCadastrarPergunta = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            lblTituloPergunta = new Label();
            label7 = new Label();
            btnAdicionarAlternativa = new Button();
            tbSetor = new TabPage();
            lblErroSetor = new Label();
            btnVoltarParaMenu = new Button();
            btnCadastrarSetor = new Button();
            button4 = new Button();
            txtNomeSetor = new TextBox();
            label2 = new Label();
            lblTituloSetor = new Label();
            tbcPaginas = new TabControl();
            pnlMenu.SuspendLayout();
            tlpBotoesEscolha.SuspendLayout();
            panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tbAtendente.SuspendLayout();
            tbAdmin.SuspendLayout();
            tbPerguntas.SuspendLayout();
            tbSetor.SuspendLayout();
            tbcPaginas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Brown;
            pnlMenu.Controls.Add(tlpBotoesEscolha);
            pnlMenu.Controls.Add(panelTopo);
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(260, 723);
            pnlMenu.TabIndex = 8;
            // 
            // tlpBotoesEscolha
            // 
            tlpBotoesEscolha.ColumnCount = 1;
            tlpBotoesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBotoesEscolha.Controls.Add(btnAdmin, 0, 2);
            tlpBotoesEscolha.Controls.Add(btnSetor, 0, 0);
            tlpBotoesEscolha.Controls.Add(btnPerguntas, 0, 1);
            tlpBotoesEscolha.Controls.Add(btnAtendentes, 0, 3);
            tlpBotoesEscolha.Location = new Point(0, 132);
            tlpBotoesEscolha.Name = "tlpBotoesEscolha";
            tlpBotoesEscolha.RowCount = 5;
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.Size = new Size(260, 333);
            tlpBotoesEscolha.TabIndex = 0;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Brown;
            btnAdmin.BackgroundImage = (Image)resources.GetObject("btnAdmin.BackgroundImage");
            btnAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Location = new Point(3, 135);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(254, 60);
            btnAdmin.TabIndex = 13;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
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
            btnSetor.Location = new Point(3, 3);
            btnSetor.Name = "btnSetor";
            btnSetor.Size = new Size(254, 60);
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
            btnPerguntas.Location = new Point(3, 69);
            btnPerguntas.Name = "btnPerguntas";
            btnPerguntas.Size = new Size(254, 60);
            btnPerguntas.TabIndex = 12;
            btnPerguntas.UseVisualStyleBackColor = false;
            btnPerguntas.Click += btnPerguntas_Click;
            // 
            // btnAtendentes
            // 
            btnAtendentes.BackColor = Color.Brown;
            btnAtendentes.BackgroundImage = (Image)resources.GetObject("btnAtendentes.BackgroundImage");
            btnAtendentes.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtendentes.Dock = DockStyle.Fill;
            btnAtendentes.FlatAppearance.BorderSize = 0;
            btnAtendentes.FlatStyle = FlatStyle.Flat;
            btnAtendentes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtendentes.ForeColor = Color.White;
            btnAtendentes.Location = new Point(3, 201);
            btnAtendentes.Name = "btnAtendentes";
            btnAtendentes.Size = new Size(254, 60);
            btnAtendentes.TabIndex = 14;
            btnAtendentes.UseVisualStyleBackColor = false;
            btnAtendentes.Click += btnAtendente_Click;
            // 
            // panelTopo
            // 
            panelTopo.Controls.Add(pictureBoxLogo);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Margin = new Padding(6);
            panelTopo.Name = "panelTopo";
            panelTopo.Padding = new Padding(6);
            panelTopo.Size = new Size(260, 112);
            panelTopo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(6, 6);
            pictureBoxLogo.Margin = new Padding(10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Padding = new Padding(10);
            pictureBoxLogo.Size = new Size(248, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 557);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 166);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnSair, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel2.Size = new Size(260, 166);
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
            btnSair.Location = new Point(3, 99);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(254, 64);
            btnSair.TabIndex = 19;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // tbAtendente
            // 
            tbAtendente.Controls.Add(cmbListaDeSetores);
            tbAtendente.Controls.Add(lblErro2);
            tbAtendente.Controls.Add(lblSetor);
            tbAtendente.Controls.Add(btnHomeAtendentes);
            tbAtendente.Controls.Add(btnCadastraAtendente);
            tbAtendente.Controls.Add(txtEmail2);
            tbAtendente.Controls.Add(txtNome2);
            tbAtendente.Controls.Add(label5);
            tbAtendente.Controls.Add(label6);
            tbAtendente.Controls.Add(label8);
            tbAtendente.Location = new Point(4, 24);
            tbAtendente.Name = "tbAtendente";
            tbAtendente.Padding = new Padding(3);
            tbAtendente.Size = new Size(1005, 694);
            tbAtendente.TabIndex = 3;
            tbAtendente.Text = "Atendente";
            tbAtendente.UseVisualStyleBackColor = true;
            // 
            // cmbListaDeSetores
            // 
            cmbListaDeSetores.FormattingEnabled = true;
            cmbListaDeSetores.Location = new Point(76, 290);
            cmbListaDeSetores.Name = "cmbListaDeSetores";
            cmbListaDeSetores.Size = new Size(253, 23);
            cmbListaDeSetores.TabIndex = 53;
            // 
            // lblErro2
            // 
            lblErro2.Anchor = AnchorStyles.None;
            lblErro2.AutoSize = true;
            lblErro2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErro2.ForeColor = Color.Red;
            lblErro2.Location = new Point(334, 422);
            lblErro2.Name = "lblErro2";
            lblErro2.Size = new Size(232, 25);
            lblErro2.TabIndex = 52;
            lblErro2.Text = "                                            ";
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 13.8F);
            lblSetor.Location = new Point(76, 262);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(56, 25);
            lblSetor.TabIndex = 49;
            lblSetor.Text = "Setor";
            // 
            // btnHomeAtendentes
            // 
            btnHomeAtendentes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeAtendentes.BackColor = Color.Gainsboro;
            btnHomeAtendentes.BackgroundImage = (Image)resources.GetObject("btnHomeAtendentes.BackgroundImage");
            btnHomeAtendentes.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeAtendentes.FlatAppearance.BorderSize = 0;
            btnHomeAtendentes.Location = new Point(926, 14);
            btnHomeAtendentes.Name = "btnHomeAtendentes";
            btnHomeAtendentes.Size = new Size(70, 68);
            btnHomeAtendentes.TabIndex = 48;
            btnHomeAtendentes.UseVisualStyleBackColor = false;
            btnHomeAtendentes.Click += btnVoltarParaMenu_Click;
            // 
            // btnCadastraAtendente
            // 
            btnCadastraAtendente.Anchor = AnchorStyles.None;
            btnCadastraAtendente.BackColor = Color.Transparent;
            btnCadastraAtendente.BackgroundImage = (Image)resources.GetObject("btnCadastraAtendente.BackgroundImage");
            btnCadastraAtendente.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastraAtendente.Cursor = Cursors.Hand;
            btnCadastraAtendente.FlatAppearance.BorderSize = 0;
            btnCadastraAtendente.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnCadastraAtendente.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnCadastraAtendente.FlatStyle = FlatStyle.Flat;
            btnCadastraAtendente.Location = new Point(282, 461);
            btnCadastraAtendente.Margin = new Padding(3, 2, 3, 2);
            btnCadastraAtendente.Name = "btnCadastraAtendente";
            btnCadastraAtendente.Size = new Size(342, 77);
            btnCadastraAtendente.TabIndex = 47;
            btnCadastraAtendente.UseVisualStyleBackColor = false;
            btnCadastraAtendente.Click += btnCadastraAtendente_Click;
            // 
            // txtEmail2
            // 
            txtEmail2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail2.Location = new Point(74, 227);
            txtEmail2.Margin = new Padding(3, 2, 3, 2);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(785, 23);
            txtEmail2.TabIndex = 43;
            // 
            // txtNome2
            // 
            txtNome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome2.Location = new Point(76, 163);
            txtNome2.Margin = new Padding(3, 2, 3, 2);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(785, 23);
            txtNome2.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(74, 200);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 41;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(76, 136);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 40;
            label6.Text = "Nome";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label8.Location = new Point(61, 49);
            label8.Name = "label8";
            label8.Size = new Size(568, 65);
            label8.TabIndex = 46;
            label8.Text = "Cadastro de Atendentes";
            // 
            // tbAdmin
            // 
            tbAdmin.Controls.Add(lblErro);
            tbAdmin.Controls.Add(btnHomeAdmin);
            tbAdmin.Controls.Add(button9);
            tbAdmin.Controls.Add(txtEmail);
            tbAdmin.Controls.Add(txtConfirmaSenha);
            tbAdmin.Controls.Add(txtNome);
            tbAdmin.Controls.Add(txtSenha);
            tbAdmin.Controls.Add(lblEmail);
            tbAdmin.Controls.Add(lblNome);
            tbAdmin.Controls.Add(lblConfirmarSenha);
            tbAdmin.Controls.Add(lblAdministradores);
            tbAdmin.Controls.Add(lblSenha);
            tbAdmin.Location = new Point(4, 24);
            tbAdmin.Name = "tbAdmin";
            tbAdmin.Padding = new Padding(3);
            tbAdmin.Size = new Size(1005, 694);
            tbAdmin.TabIndex = 2;
            tbAdmin.Text = "Usuário";
            tbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblErro
            // 
            lblErro.Anchor = AnchorStyles.None;
            lblErro.AutoSize = true;
            lblErro.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErro.ForeColor = Color.Red;
            lblErro.Location = new Point(339, 422);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(232, 25);
            lblErro.TabIndex = 53;
            lblErro.Text = "                                            ";
            // 
            // btnHomeAdmin
            // 
            btnHomeAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeAdmin.BackColor = Color.Gainsboro;
            btnHomeAdmin.BackgroundImage = (Image)resources.GetObject("btnHomeAdmin.BackgroundImage");
            btnHomeAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeAdmin.FlatAppearance.BorderSize = 0;
            btnHomeAdmin.Location = new Point(926, 6);
            btnHomeAdmin.Name = "btnHomeAdmin";
            btnHomeAdmin.Size = new Size(70, 68);
            btnHomeAdmin.TabIndex = 49;
            btnHomeAdmin.UseVisualStyleBackColor = false;
            btnHomeAdmin.Click += btnVoltarParaMenu_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.Transparent;
            button9.BackgroundImage = (Image)resources.GetObject("button9.BackgroundImage");
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(282, 461);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(342, 77);
            button9.TabIndex = 30;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnCadastrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(77, 225);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(785, 23);
            txtEmail.TabIndex = 24;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmaSenha.Location = new Point(77, 353);
            txtConfirmaSenha.Margin = new Padding(3, 2, 3, 2);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(785, 23);
            txtConfirmaSenha.TabIndex = 29;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(79, 161);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(785, 23);
            txtNome.TabIndex = 23;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(77, 289);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(785, 23);
            txtSenha.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F);
            lblEmail.Location = new Point(77, 198);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 13.8F);
            lblNome.Location = new Point(79, 134);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 25);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI", 13.8F);
            lblConfirmarSenha.Location = new Point(77, 326);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(154, 25);
            lblConfirmarSenha.TabIndex = 28;
            lblConfirmarSenha.Text = "Confirmar Senha";
            lblConfirmarSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdministradores
            // 
            lblAdministradores.AutoSize = true;
            lblAdministradores.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblAdministradores.Location = new Point(61, 49);
            lblAdministradores.Name = "lblAdministradores";
            lblAdministradores.Size = new Size(685, 65);
            lblAdministradores.TabIndex = 27;
            lblAdministradores.Text = "Cadastro de Administradores";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 13.8F);
            lblSenha.Location = new Point(77, 262);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 25);
            lblSenha.TabIndex = 25;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPerguntas
            // 
            tbPerguntas.Controls.Add(button2);
            tbPerguntas.Controls.Add(btnCadastrarPergunta);
            tbPerguntas.Controls.Add(textBox4);
            tbPerguntas.Controls.Add(textBox2);
            tbPerguntas.Controls.Add(textBox3);
            tbPerguntas.Controls.Add(label1);
            tbPerguntas.Controls.Add(lblTituloPergunta);
            tbPerguntas.Controls.Add(label7);
            tbPerguntas.Controls.Add(btnAdicionarAlternativa);
            tbPerguntas.Location = new Point(4, 24);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3);
            tbPerguntas.Size = new Size(1005, 694);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Gainsboro;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(914, 20);
            button2.Name = "button2";
            button2.Size = new Size(70, 68);
            button2.TabIndex = 28;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnVoltarParaMenu_Click;
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.Anchor = AnchorStyles.Left;
            btnCadastrarPergunta.BackgroundImage = (Image)resources.GetObject("btnCadastrarPergunta.BackgroundImage");
            btnCadastrarPergunta.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrarPergunta.Location = new Point(499, 494);
            btnCadastrarPergunta.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(243, 62);
            btnCadastrarPergunta.TabIndex = 21;
            btnCadastrarPergunta.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(72, 198);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(671, 32);
            textBox4.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(72, 318);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(671, 32);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(72, 275);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(671, 32);
            textBox3.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 250);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 18;
            label1.Text = "Alternativas";
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPergunta.Location = new Point(66, 172);
            lblTituloPergunta.Name = "lblTituloPergunta";
            lblTituloPergunta.Size = new Size(88, 25);
            lblTituloPergunta.TabIndex = 16;
            lblTituloPergunta.Text = "Pergunta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label7.Location = new Point(61, 49);
            label7.Name = "label7";
            label7.Size = new Size(255, 65);
            label7.TabIndex = 14;
            label7.Text = "Perguntas";
            // 
            // btnAdicionarAlternativa
            // 
            btnAdicionarAlternativa.Anchor = AnchorStyles.Left;
            btnAdicionarAlternativa.BackgroundImage = (Image)resources.GetObject("btnAdicionarAlternativa.BackgroundImage");
            btnAdicionarAlternativa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionarAlternativa.Location = new Point(72, 497);
            btnAdicionarAlternativa.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            btnAdicionarAlternativa.Size = new Size(251, 56);
            btnAdicionarAlternativa.TabIndex = 9;
            btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            // 
            // tbSetor
            // 
            tbSetor.Controls.Add(lblErroSetor);
            tbSetor.Controls.Add(btnVoltarParaMenu);
            tbSetor.Controls.Add(btnCadastrarSetor);
            tbSetor.Controls.Add(button4);
            tbSetor.Controls.Add(txtNomeSetor);
            tbSetor.Controls.Add(label2);
            tbSetor.Controls.Add(lblTituloSetor);
            tbSetor.ForeColor = Color.Transparent;
            tbSetor.Location = new Point(4, 24);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3);
            tbSetor.Size = new Size(1005, 694);
            tbSetor.TabIndex = 0;
            tbSetor.Text = "Setor";
            tbSetor.UseVisualStyleBackColor = true;
            // 
            // lblErroSetor
            // 
            lblErroSetor.Anchor = AnchorStyles.None;
            lblErroSetor.AutoSize = true;
            lblErroSetor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErroSetor.ForeColor = Color.Red;
            lblErroSetor.Location = new Point(304, 520);
            lblErroSetor.Name = "lblErroSetor";
            lblErroSetor.Size = new Size(232, 25);
            lblErroSetor.TabIndex = 54;
            lblErroSetor.Text = "                                            ";
            // 
            // btnVoltarParaMenu
            // 
            btnVoltarParaMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVoltarParaMenu.BackColor = Color.Gainsboro;
            btnVoltarParaMenu.BackgroundImage = (Image)resources.GetObject("btnVoltarParaMenu.BackgroundImage");
            btnVoltarParaMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltarParaMenu.FlatAppearance.BorderSize = 0;
            btnVoltarParaMenu.Location = new Point(914, 20);
            btnVoltarParaMenu.Name = "btnVoltarParaMenu";
            btnVoltarParaMenu.Size = new Size(70, 68);
            btnVoltarParaMenu.TabIndex = 27;
            btnVoltarParaMenu.UseVisualStyleBackColor = false;
            btnVoltarParaMenu.Click += btnVoltarParaMenu_Click;
            // 
            // btnCadastrarSetor
            // 
            btnCadastrarSetor.Anchor = AnchorStyles.Left;
            btnCadastrarSetor.BackgroundImage = (Image)resources.GetObject("btnCadastrarSetor.BackgroundImage");
            btnCadastrarSetor.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrarSetor.Location = new Point(485, 594);
            btnCadastrarSetor.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarSetor.Name = "btnCadastrarSetor";
            btnCadastrarSetor.Size = new Size(243, 62);
            btnCadastrarSetor.TabIndex = 26;
            btnCadastrarSetor.UseVisualStyleBackColor = true;
            btnCadastrarSetor.Click += btnCadastrarSetor_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(58, 597);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(251, 56);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = true;
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Location = new Point(58, 281);
            txtNomeSetor.Margin = new Padding(3, 2, 3, 2);
            txtNomeSetor.Multiline = true;
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(671, 32);
            txtNomeSetor.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 256);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 23;
            label2.Text = "Nome";
            // 
            // lblTituloSetor
            // 
            lblTituloSetor.AutoSize = true;
            lblTituloSetor.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTituloSetor.ForeColor = Color.Black;
            lblTituloSetor.Location = new Point(61, 49);
            lblTituloSetor.Name = "lblTituloSetor";
            lblTituloSetor.Size = new Size(148, 65);
            lblTituloSetor.TabIndex = 14;
            lblTituloSetor.Text = "Setor";
            // 
            // tbcPaginas
            // 
            tbcPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcPaginas.Controls.Add(tbSetor);
            tbcPaginas.Controls.Add(tbPerguntas);
            tbcPaginas.Controls.Add(tbAdmin);
            tbcPaginas.Controls.Add(tbAtendente);
            tbcPaginas.Location = new Point(260, 0);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(1013, 722);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 8;
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 723);
            Controls.Add(tbcPaginas);
            Controls.Add(pnlMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastros";
            Text = "FrmCadastros";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            tlpBotoesEscolha.ResumeLayout(false);
            panelTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tbAtendente.ResumeLayout(false);
            tbAtendente.PerformLayout();
            tbAdmin.ResumeLayout(false);
            tbAdmin.PerformLayout();
            tbPerguntas.ResumeLayout(false);
            tbPerguntas.PerformLayout();
            tbSetor.ResumeLayout(false);
            tbSetor.PerformLayout();
            tbcPaginas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Panel panelTopo;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tlpBotoesEscolha;
        private Button btnSetor;
        private Panel panel1;
        private Button btnAtendentes;
        private Button btnAdmin;
        private Button btnPerguntas;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSair;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabPage tbAtendente;
        private Label lblSetor;
        private Button btnHomeAtendentes;
        private Button btnCadastraAtendente;
        private TextBox txtEmail2;
        private TextBox txtNome2;
        private Label label5;
        private Label label6;
        private Label label8;
        private TabPage tbAdmin;
        private Button btnHomeAdmin;
        private Button button9;
        private TextBox txtEmail;
        private TextBox txtConfirmaSenha;
        private TextBox txtNome;
        private TextBox txtSenha;
        private Label lblEmail;
        private Label lblNome;
        private Label lblConfirmarSenha;
        private Label lblAdministradores;
        private Label lblSenha;
        private TabPage tbPerguntas;
        private Button button2;
        private Button btnCadastrarPergunta;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label lblTituloPergunta;
        private Label label7;
        private Button btnAdicionarAlternativa;
        private TabPage tbSetor;
        private Button btnVoltarParaMenu;
        private Button btnCadastrarSetor;
        private Button button4;
        private TextBox txtNomeSetor;
        private Label label2;
        private Label lblTituloSetor;
        private TabControl tbcPaginas;
        private Label lblErro2;
        private Label lblErro;
        private Label lblErroSetor;
        private ComboBox cmbListaDeSetores;
    }
}