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
            btnUploadImage = new Button();
            lblFotoAtendente = new Label();
            ptbImagemAtendente = new PictureBox();
            cmbListaDeSetores = new ComboBox();
            lblMsgErroAtendente = new Label();
            lblSetor = new Label();
            btnHomeAtendentes = new Button();
            btnCadastraAtendente = new Button();
            txtEmail2 = new TextBox();
            txtNome2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            tbAdmin = new TabPage();
            lblMsgErroAdmin = new Label();
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
            lblErroPerguntas = new Label();
            label3 = new Label();
            cbxListaSetorPergunta = new ComboBox();
            txtAlternativa10 = new TextBox();
            txtAlternativa9 = new TextBox();
            txtAlternativa8 = new TextBox();
            txtAlternativa7 = new TextBox();
            txtAlternativa6 = new TextBox();
            txtAlternativa5 = new TextBox();
            txtAlternativa4 = new TextBox();
            txtAlternativa3 = new TextBox();
            button2 = new Button();
            btnCadastrarPergunta = new Button();
            txtPergunta = new TextBox();
            txtAlternativa2 = new TextBox();
            txtAlternativa1 = new TextBox();
            label1 = new Label();
            lblTituloPergunta = new Label();
            label7 = new Label();
            btnAdicionarAlternativa = new Button();
            tbSetor = new TabPage();
            lblErroSetor = new Label();
            btnVoltarParaMenu = new Button();
            btnCadastrarSetor = new Button();
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
            ((System.ComponentModel.ISupportInitialize)ptbImagemAtendente).BeginInit();
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
            pnlMenu.Size = new Size(260, 749);
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
            panel1.Location = new Point(0, 583);
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
            tbAtendente.Controls.Add(btnUploadImage);
            tbAtendente.Controls.Add(lblFotoAtendente);
            tbAtendente.Controls.Add(ptbImagemAtendente);
            tbAtendente.Controls.Add(cmbListaDeSetores);
            tbAtendente.Controls.Add(lblMsgErroAtendente);
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
            tbAtendente.Size = new Size(1043, 780);
            tbAtendente.TabIndex = 3;
            tbAtendente.Text = "Atendente";
            tbAtendente.UseVisualStyleBackColor = true;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackgroundImage = (Image)resources.GetObject("btnUploadImage.BackgroundImage");
            btnUploadImage.BackgroundImageLayout = ImageLayout.Stretch;
            btnUploadImage.Location = new Point(435, 386);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(74, 69);
            btnUploadImage.TabIndex = 56;
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // lblFotoAtendente
            // 
            lblFotoAtendente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFotoAtendente.AutoSize = true;
            lblFotoAtendente.Font = new Font("Segoe UI", 15.75F);
            lblFotoAtendente.Location = new Point(390, 306);
            lblFotoAtendente.Name = "lblFotoAtendente";
            lblFotoAtendente.Size = new Size(157, 30);
            lblFotoAtendente.TabIndex = 55;
            lblFotoAtendente.Text = "Foto Atendente";
            // 
            // ptbImagemAtendente
            // 
            ptbImagemAtendente.Location = new Point(573, 306);
            ptbImagemAtendente.Name = "ptbImagemAtendente";
            ptbImagemAtendente.Size = new Size(218, 237);
            ptbImagemAtendente.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagemAtendente.TabIndex = 54;
            ptbImagemAtendente.TabStop = false;
            // 
            // cmbListaDeSetores
            // 
            cmbListaDeSetores.Font = new Font("Segoe UI", 15.75F);
            cmbListaDeSetores.FormattingEnabled = true;
            cmbListaDeSetores.Location = new Point(78, 321);
            cmbListaDeSetores.Name = "cmbListaDeSetores";
            cmbListaDeSetores.Size = new Size(253, 38);
            cmbListaDeSetores.TabIndex = 53;
            // 
            // lblMsgErroAtendente
            // 
            lblMsgErroAtendente.Anchor = AnchorStyles.None;
            lblMsgErroAtendente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblMsgErroAtendente.ForeColor = Color.Black;
            lblMsgErroAtendente.Location = new Point(76, 605);
            lblMsgErroAtendente.Name = "lblMsgErroAtendente";
            lblMsgErroAtendente.Size = new Size(787, 25);
            lblMsgErroAtendente.TabIndex = 52;
            lblMsgErroAtendente.Text = "                                            ";
            lblMsgErroAtendente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 15.75F);
            lblSetor.Location = new Point(80, 285);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(61, 30);
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
            btnHomeAtendentes.Location = new Point(917, 46);
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
            btnCadastraAtendente.Location = new Point(343, 647);
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
            txtEmail2.Font = new Font("Segoe UI", 15.75F);
            txtEmail2.Location = new Point(76, 242);
            txtEmail2.Margin = new Padding(3, 2, 3, 2);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(785, 35);
            txtEmail2.TabIndex = 43;
            // 
            // txtNome2
            // 
            txtNome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome2.Font = new Font("Segoe UI", 15.75F);
            txtNome2.Location = new Point(78, 162);
            txtNome2.Margin = new Padding(3, 2, 3, 2);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(785, 35);
            txtNome2.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(78, 207);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 41;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F);
            label6.Location = new Point(80, 127);
            label6.Name = "label6";
            label6.Size = new Size(70, 30);
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
            tbAdmin.Controls.Add(lblMsgErroAdmin);
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
            tbAdmin.Size = new Size(1043, 780);
            tbAdmin.TabIndex = 2;
            tbAdmin.Text = "Usuário";
            tbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblMsgErroAdmin
            // 
            lblMsgErroAdmin.Anchor = AnchorStyles.None;
            lblMsgErroAdmin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblMsgErroAdmin.ForeColor = Color.Black;
            lblMsgErroAdmin.Location = new Point(97, 495);
            lblMsgErroAdmin.Name = "lblMsgErroAdmin";
            lblMsgErroAdmin.Size = new Size(765, 25);
            lblMsgErroAdmin.TabIndex = 53;
            lblMsgErroAdmin.Text = "                                            ";
            lblMsgErroAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHomeAdmin
            // 
            btnHomeAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeAdmin.BackColor = Color.Gainsboro;
            btnHomeAdmin.BackgroundImage = (Image)resources.GetObject("btnHomeAdmin.BackgroundImage");
            btnHomeAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeAdmin.FlatAppearance.BorderSize = 0;
            btnHomeAdmin.Location = new Point(917, 46);
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
            button9.Location = new Point(343, 643);
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
            txtEmail.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtEmail.Location = new Point(77, 249);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(785, 31);
            txtEmail.TabIndex = 24;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmaSenha.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtConfirmaSenha.Location = new Point(77, 409);
            txtConfirmaSenha.Margin = new Padding(3, 2, 3, 2);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(785, 31);
            txtConfirmaSenha.TabIndex = 29;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtNome.Location = new Point(79, 169);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(785, 31);
            txtNome.TabIndex = 23;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Font = new Font("Microsoft Sans Serif", 15.75F);
            txtSenha.Location = new Point(77, 329);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(785, 31);
            txtSenha.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F);
            lblEmail.Location = new Point(77, 209);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 30);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F);
            lblNome.Location = new Point(79, 129);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 30);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI", 15.75F);
            lblConfirmarSenha.Location = new Point(77, 369);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(168, 30);
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
            lblSenha.Font = new Font("Segoe UI", 15.75F);
            lblSenha.Location = new Point(77, 289);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(70, 30);
            lblSenha.TabIndex = 25;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPerguntas
            // 
            tbPerguntas.Controls.Add(lblErroPerguntas);
            tbPerguntas.Controls.Add(label3);
            tbPerguntas.Controls.Add(cbxListaSetorPergunta);
            tbPerguntas.Controls.Add(txtAlternativa10);
            tbPerguntas.Controls.Add(txtAlternativa9);
            tbPerguntas.Controls.Add(txtAlternativa8);
            tbPerguntas.Controls.Add(txtAlternativa7);
            tbPerguntas.Controls.Add(txtAlternativa6);
            tbPerguntas.Controls.Add(txtAlternativa5);
            tbPerguntas.Controls.Add(txtAlternativa4);
            tbPerguntas.Controls.Add(txtAlternativa3);
            tbPerguntas.Controls.Add(button2);
            tbPerguntas.Controls.Add(btnCadastrarPergunta);
            tbPerguntas.Controls.Add(txtPergunta);
            tbPerguntas.Controls.Add(txtAlternativa2);
            tbPerguntas.Controls.Add(txtAlternativa1);
            tbPerguntas.Controls.Add(label1);
            tbPerguntas.Controls.Add(lblTituloPergunta);
            tbPerguntas.Controls.Add(label7);
            tbPerguntas.Controls.Add(btnAdicionarAlternativa);
            tbPerguntas.Location = new Point(4, 24);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3);
            tbPerguntas.Size = new Size(1043, 780);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // lblErroPerguntas
            // 
            lblErroPerguntas.Anchor = AnchorStyles.None;
            lblErroPerguntas.BackColor = Color.Transparent;
            lblErroPerguntas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErroPerguntas.ForeColor = Color.Black;
            lblErroPerguntas.Location = new Point(71, 605);
            lblErroPerguntas.Name = "lblErroPerguntas";
            lblErroPerguntas.Size = new Size(671, 37);
            lblErroPerguntas.TabIndex = 54;
            lblErroPerguntas.Text = "                                            ";
            lblErroPerguntas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(749, 195);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 38;
            label3.Text = "Setor:";
            // 
            // cbxListaSetorPergunta
            // 
            cbxListaSetorPergunta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxListaSetorPergunta.FormattingEnabled = true;
            cbxListaSetorPergunta.Location = new Point(815, 188);
            cbxListaSetorPergunta.Name = "cbxListaSetorPergunta";
            cbxListaSetorPergunta.Size = new Size(185, 38);
            cbxListaSetorPergunta.TabIndex = 37;
            // 
            // txtAlternativa10
            // 
            txtAlternativa10.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa10.Location = new Point(71, 551);
            txtAlternativa10.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa10.Multiline = true;
            txtAlternativa10.Name = "txtAlternativa10";
            txtAlternativa10.Size = new Size(671, 32);
            txtAlternativa10.TabIndex = 36;
            // 
            // txtAlternativa9
            // 
            txtAlternativa9.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa9.Location = new Point(72, 515);
            txtAlternativa9.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa9.Multiline = true;
            txtAlternativa9.Name = "txtAlternativa9";
            txtAlternativa9.Size = new Size(671, 32);
            txtAlternativa9.TabIndex = 35;
            // 
            // txtAlternativa8
            // 
            txtAlternativa8.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa8.Location = new Point(72, 480);
            txtAlternativa8.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa8.Multiline = true;
            txtAlternativa8.Name = "txtAlternativa8";
            txtAlternativa8.Size = new Size(671, 32);
            txtAlternativa8.TabIndex = 34;
            // 
            // txtAlternativa7
            // 
            txtAlternativa7.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa7.Location = new Point(72, 445);
            txtAlternativa7.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa7.Multiline = true;
            txtAlternativa7.Name = "txtAlternativa7";
            txtAlternativa7.Size = new Size(671, 32);
            txtAlternativa7.TabIndex = 33;
            // 
            // txtAlternativa6
            // 
            txtAlternativa6.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa6.Location = new Point(72, 409);
            txtAlternativa6.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa6.Multiline = true;
            txtAlternativa6.Name = "txtAlternativa6";
            txtAlternativa6.Size = new Size(671, 32);
            txtAlternativa6.TabIndex = 32;
            // 
            // txtAlternativa5
            // 
            txtAlternativa5.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa5.Location = new Point(72, 374);
            txtAlternativa5.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa5.Multiline = true;
            txtAlternativa5.Name = "txtAlternativa5";
            txtAlternativa5.Size = new Size(671, 32);
            txtAlternativa5.TabIndex = 31;
            // 
            // txtAlternativa4
            // 
            txtAlternativa4.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa4.Location = new Point(72, 339);
            txtAlternativa4.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa4.Multiline = true;
            txtAlternativa4.Name = "txtAlternativa4";
            txtAlternativa4.Size = new Size(671, 32);
            txtAlternativa4.TabIndex = 30;
            // 
            // txtAlternativa3
            // 
            txtAlternativa3.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa3.Location = new Point(72, 303);
            txtAlternativa3.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa3.Multiline = true;
            txtAlternativa3.Name = "txtAlternativa3";
            txtAlternativa3.Size = new Size(671, 32);
            txtAlternativa3.TabIndex = 29;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Gainsboro;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(917, 46);
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
            btnCadastrarPergunta.FlatStyle = FlatStyle.Flat;
            btnCadastrarPergunta.Location = new Point(499, 653);
            btnCadastrarPergunta.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(243, 62);
            btnCadastrarPergunta.TabIndex = 21;
            btnCadastrarPergunta.UseVisualStyleBackColor = true;
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
            // 
            // txtPergunta
            // 
            txtPergunta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPergunta.Location = new Point(72, 141);
            txtPergunta.Margin = new Padding(3, 2, 3, 2);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(671, 56);
            txtPergunta.TabIndex = 1;
            // 
            // txtAlternativa2
            // 
            txtAlternativa2.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa2.Location = new Point(72, 268);
            txtAlternativa2.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa2.Multiline = true;
            txtAlternativa2.Name = "txtAlternativa2";
            txtAlternativa2.Size = new Size(671, 32);
            txtAlternativa2.TabIndex = 19;
            // 
            // txtAlternativa1
            // 
            txtAlternativa1.Font = new Font("Segoe UI", 9.75F);
            txtAlternativa1.Location = new Point(72, 232);
            txtAlternativa1.Margin = new Padding(3, 2, 3, 2);
            txtAlternativa1.Multiline = true;
            txtAlternativa1.Name = "txtAlternativa1";
            txtAlternativa1.Size = new Size(671, 32);
            txtAlternativa1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 205);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 18;
            label1.Text = "Alternativas";
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPergunta.Location = new Point(71, 114);
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
            btnAdicionarAlternativa.Location = new Point(72, 653);
            btnAdicionarAlternativa.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            btnAdicionarAlternativa.Size = new Size(251, 56);
            btnAdicionarAlternativa.TabIndex = 9;
            btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            btnAdicionarAlternativa.Click += btnAdicionarAlternativa_Click;
            // 
            // tbSetor
            // 
            tbSetor.Controls.Add(lblErroSetor);
            tbSetor.Controls.Add(btnVoltarParaMenu);
            tbSetor.Controls.Add(btnCadastrarSetor);
            tbSetor.Controls.Add(txtNomeSetor);
            tbSetor.Controls.Add(label2);
            tbSetor.Controls.Add(lblTituloSetor);
            tbSetor.ForeColor = Color.Transparent;
            tbSetor.Location = new Point(4, 24);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3);
            tbSetor.Size = new Size(1043, 780);
            tbSetor.TabIndex = 0;
            tbSetor.Text = "Setor";
            tbSetor.UseVisualStyleBackColor = true;
            // 
            // lblErroSetor
            // 
            lblErroSetor.Anchor = AnchorStyles.None;
            lblErroSetor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErroSetor.ForeColor = Color.Black;
            lblErroSetor.Location = new Point(58, 554);
            lblErroSetor.Name = "lblErroSetor";
            lblErroSetor.Size = new Size(671, 25);
            lblErroSetor.TabIndex = 54;
            lblErroSetor.Text = "                                            ";
            lblErroSetor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVoltarParaMenu
            // 
            btnVoltarParaMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVoltarParaMenu.BackColor = Color.Gainsboro;
            btnVoltarParaMenu.BackgroundImage = (Image)resources.GetObject("btnVoltarParaMenu.BackgroundImage");
            btnVoltarParaMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltarParaMenu.FlatAppearance.BorderSize = 0;
            btnVoltarParaMenu.Location = new Point(917, 46);
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
            btnCadastrarSetor.FlatStyle = FlatStyle.Flat;
            btnCadastrarSetor.Location = new Point(343, 634);
            btnCadastrarSetor.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarSetor.Name = "btnCadastrarSetor";
            btnCadastrarSetor.Size = new Size(342, 77);
            btnCadastrarSetor.TabIndex = 26;
            btnCadastrarSetor.UseVisualStyleBackColor = true;
            btnCadastrarSetor.Click += btnCadastrarSetor_Click;
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeSetor.Location = new Point(58, 275);
            txtNomeSetor.Margin = new Padding(3, 2, 3, 2);
            txtNomeSetor.Multiline = true;
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(671, 47);
            txtNomeSetor.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(58, 243);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
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
            tbcPaginas.Location = new Point(260, -26);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(1051, 808);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 8;
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 749);
            Controls.Add(tbcPaginas);
            Controls.Add(pnlMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)ptbImagemAtendente).EndInit();
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
        private TextBox txtPergunta;
        private TextBox txtAlternativa2;
        private TextBox txtAlternativa1;
        private Label label1;
        private Label lblTituloPergunta;
        private Label label7;
        private Button btnAdicionarAlternativa;
        private TabPage tbSetor;
        private Button btnVoltarParaMenu;
        private Button btnCadastrarSetor;
        private TextBox txtNomeSetor;
        private Label label2;
        private Label lblTituloSetor;
        private TabControl tbcPaginas;
        private Label lblMsgErroAtendente;
        private Label lblMsgErroAdmin;
        private Label lblErroSetor;
        private ComboBox cmbListaDeSetores;
        private TextBox txtAlternativa6;
        private TextBox txtAlternativa5;
        private TextBox txtAlternativa4;
        private TextBox txtAlternativa3;
        private TextBox txtAlternativa8;
        private TextBox txtAlternativa7;
        private TextBox txtAlternativa10;
        private TextBox txtAlternativa9;
        private ComboBox cbxListaSetorPergunta;
        private Label label3;
        private Label lblErroPerguntas;
        private Button btnUploadImage;
        private Label lblFotoAtendente;
        private PictureBox ptbImagemAtendente;
    }
}