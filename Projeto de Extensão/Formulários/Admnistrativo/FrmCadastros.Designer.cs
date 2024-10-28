namespace Projeto_de_Extensao.Formulários.Admnistrativo
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
            btnCadrastoAdmin = new Button();
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
            btnDelPergunta1 = new Button();
            btnEditPergunta1 = new Button();
            btnAddPergunta1 = new Button();
            lblPergunta4 = new Label();
            lblPergunta3 = new Label();
            lblPergunta2 = new Label();
            lblPergunta1 = new Label();
            lblIdPergunta4 = new Label();
            lblIdPergunta3 = new Label();
            lblIdPergunta2 = new Label();
            lblIdPergunta1 = new Label();
            label1 = new Label();
            tbUsuario = new TabPage();
            tbcTipoCadastro = new TabControl();
            tabCadastroAdmin = new TabPage();
            btnPaginaAtendente = new Button();
            txtEmail = new TextBox();
            btnCadastrar = new Button();
            lblEmail = new Label();
            txtConfirmaSenha = new TextBox();
            lblNome = new Label();
            lblConfirmaSenha = new Label();
            txtNome = new TextBox();
            lblTitulo = new Label();
            lblSenha = new Label();
            txtSenha = new TextBox();
            tabCadastroAtendentes = new TabPage();
            lblErro2 = new Label();
            btnSecretaria = new Button();
            btnFinanceiro = new Button();
            lblSetor = new Label();
            button1 = new Button();
            txtEmail2 = new TextBox();
            lnlEmail2 = new Label();
            txtNome2 = new TextBox();
            lblNome2 = new Label();
            label3 = new Label();
            btnPaginaAdmin = new Button();
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
            tbcTipoCadastro.SuspendLayout();
            tabCadastroAdmin.SuspendLayout();
            tabCadastroAtendentes.SuspendLayout();
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
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(260, 545);
            pnlMenu.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnCadrastoAdmin, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSetor, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPerguntas, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAjuda, 0, 3);
            tableLayoutPanel1.Location = new Point(6, 119);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(260, 257);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCadrastoAdmin
            // 
            btnCadrastoAdmin.BackColor = Color.Brown;
            btnCadrastoAdmin.BackgroundImage = (Image)resources.GetObject("btnCadrastoAdmin.BackgroundImage");
            btnCadrastoAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadrastoAdmin.Dock = DockStyle.Fill;
            btnCadrastoAdmin.FlatAppearance.BorderSize = 0;
            btnCadrastoAdmin.FlatStyle = FlatStyle.Flat;
            btnCadrastoAdmin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadrastoAdmin.ForeColor = Color.White;
            btnCadrastoAdmin.Location = new Point(3, 131);
            btnCadrastoAdmin.Name = "btnCadrastoAdmin";
            btnCadrastoAdmin.Size = new Size(254, 58);
            btnCadrastoAdmin.TabIndex = 13;
            btnCadrastoAdmin.UseVisualStyleBackColor = false;
            btnCadrastoAdmin.Click += btnUsuario_Click;
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
            btnSetor.Size = new Size(254, 58);
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
            btnPerguntas.Location = new Point(3, 67);
            btnPerguntas.Name = "btnPerguntas";
            btnPerguntas.Size = new Size(254, 58);
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
            btnAjuda.Location = new Point(3, 195);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(254, 59);
            btnAjuda.TabIndex = 14;
            btnAjuda.UseVisualStyleBackColor = false;
            btnAjuda.Click += btnAjuda_Click;
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
            panel1.Location = new Point(0, 379);
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
            // tbcPaginas
            // 
            tbcPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcPaginas.Controls.Add(tbSetor);
            tbcPaginas.Controls.Add(tbPerguntas);
            tbcPaginas.Controls.Add(tbUsuario);
            tbcPaginas.Controls.Add(tbAjuda);
            tbcPaginas.Location = new Point(260, 6);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(789, 538);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 9;
            // 
            // tbSetor
            // 
            tbSetor.Controls.Add(label2);
            tbSetor.ForeColor = Color.Transparent;
            tbSetor.Location = new Point(4, 24);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3);
            tbSetor.Size = new Size(781, 510);
            tbSetor.TabIndex = 0;
            tbSetor.Text = "Setor";
            tbSetor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(316, 346);
            label2.Name = "label2";
            label2.Size = new Size(147, 42);
            label2.TabIndex = 1;
            label2.Text = "SETOR";
            // 
            // tbPerguntas
            // 
            tbPerguntas.Controls.Add(btnDelPergunta1);
            tbPerguntas.Controls.Add(btnEditPergunta1);
            tbPerguntas.Controls.Add(btnAddPergunta1);
            tbPerguntas.Controls.Add(lblPergunta4);
            tbPerguntas.Controls.Add(lblPergunta3);
            tbPerguntas.Controls.Add(lblPergunta2);
            tbPerguntas.Controls.Add(lblPergunta1);
            tbPerguntas.Controls.Add(lblIdPergunta4);
            tbPerguntas.Controls.Add(lblIdPergunta3);
            tbPerguntas.Controls.Add(lblIdPergunta2);
            tbPerguntas.Controls.Add(lblIdPergunta1);
            tbPerguntas.Controls.Add(label1);
            tbPerguntas.Location = new Point(4, 24);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3);
            tbPerguntas.Size = new Size(781, 510);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // btnDelPergunta1
            // 
            btnDelPergunta1.Location = new Point(629, 86);
            btnDelPergunta1.Margin = new Padding(3, 2, 3, 2);
            btnDelPergunta1.Name = "btnDelPergunta1";
            btnDelPergunta1.Size = new Size(135, 26);
            btnDelPergunta1.TabIndex = 11;
            btnDelPergunta1.Text = "RemovePergunta";
            btnDelPergunta1.UseVisualStyleBackColor = true;
            // 
            // btnEditPergunta1
            // 
            btnEditPergunta1.Location = new Point(489, 86);
            btnEditPergunta1.Margin = new Padding(3, 2, 3, 2);
            btnEditPergunta1.Name = "btnEditPergunta1";
            btnEditPergunta1.Size = new Size(135, 26);
            btnEditPergunta1.TabIndex = 10;
            btnEditPergunta1.Text = "EditaPergunta";
            btnEditPergunta1.UseVisualStyleBackColor = true;
            // 
            // btnAddPergunta1
            // 
            btnAddPergunta1.Location = new Point(349, 86);
            btnAddPergunta1.Margin = new Padding(3, 2, 3, 2);
            btnAddPergunta1.Name = "btnAddPergunta1";
            btnAddPergunta1.Size = new Size(135, 26);
            btnAddPergunta1.TabIndex = 9;
            btnAddPergunta1.Text = "AdicionaPergunta";
            btnAddPergunta1.UseVisualStyleBackColor = true;
            // 
            // lblPergunta4
            // 
            lblPergunta4.AutoSize = true;
            lblPergunta4.Location = new Point(130, 169);
            lblPergunta4.Name = "lblPergunta4";
            lblPergunta4.Size = new Size(64, 15);
            lblPergunta4.TabIndex = 8;
            lblPergunta4.Text = "Pergunta 4";
            // 
            // lblPergunta3
            // 
            lblPergunta3.AutoSize = true;
            lblPergunta3.Location = new Point(130, 145);
            lblPergunta3.Name = "lblPergunta3";
            lblPergunta3.Size = new Size(64, 15);
            lblPergunta3.TabIndex = 7;
            lblPergunta3.Text = "Pergunta 3";
            // 
            // lblPergunta2
            // 
            lblPergunta2.AutoSize = true;
            lblPergunta2.Location = new Point(130, 119);
            lblPergunta2.Name = "lblPergunta2";
            lblPergunta2.Size = new Size(64, 15);
            lblPergunta2.TabIndex = 6;
            lblPergunta2.Text = "Pergunta 2";
            // 
            // lblPergunta1
            // 
            lblPergunta1.AutoSize = true;
            lblPergunta1.Location = new Point(130, 92);
            lblPergunta1.Name = "lblPergunta1";
            lblPergunta1.Size = new Size(67, 15);
            lblPergunta1.TabIndex = 5;
            lblPergunta1.Text = "Pergunta 1 ";
            // 
            // lblIdPergunta4
            // 
            lblIdPergunta4.AutoSize = true;
            lblIdPergunta4.Location = new Point(36, 169);
            lblIdPergunta4.Name = "lblIdPergunta4";
            lblIdPergunta4.Size = new Size(70, 15);
            lblIdPergunta4.TabIndex = 4;
            lblIdPergunta4.Text = "nº Pergunta";
            // 
            // lblIdPergunta3
            // 
            lblIdPergunta3.AutoSize = true;
            lblIdPergunta3.Location = new Point(36, 145);
            lblIdPergunta3.Name = "lblIdPergunta3";
            lblIdPergunta3.Size = new Size(70, 15);
            lblIdPergunta3.TabIndex = 3;
            lblIdPergunta3.Text = "nº Pergunta";
            // 
            // lblIdPergunta2
            // 
            lblIdPergunta2.AutoSize = true;
            lblIdPergunta2.Location = new Point(36, 119);
            lblIdPergunta2.Name = "lblIdPergunta2";
            lblIdPergunta2.Size = new Size(70, 15);
            lblIdPergunta2.TabIndex = 2;
            lblIdPergunta2.Text = "nº Pergunta";
            // 
            // lblIdPergunta1
            // 
            lblIdPergunta1.AutoSize = true;
            lblIdPergunta1.Location = new Point(36, 92);
            lblIdPergunta1.Name = "lblIdPergunta1";
            lblIdPergunta1.Size = new Size(70, 15);
            lblIdPergunta1.TabIndex = 1;
            lblIdPergunta1.Text = "nº Pergunta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 359);
            label1.Name = "label1";
            label1.Size = new Size(251, 42);
            label1.TabIndex = 0;
            label1.Text = "PERGUNTAS";
            // 
            // tbUsuario
            // 
            tbUsuario.Controls.Add(tbcTipoCadastro);
            tbUsuario.Location = new Point(4, 24);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Padding = new Padding(3);
            tbUsuario.Size = new Size(781, 510);
            tbUsuario.TabIndex = 2;
            tbUsuario.Text = "Usuário";
            tbUsuario.UseVisualStyleBackColor = true;
            // 
            // tbcTipoCadastro
            // 
            tbcTipoCadastro.Anchor = AnchorStyles.None;
            tbcTipoCadastro.Controls.Add(tabCadastroAdmin);
            tbcTipoCadastro.Controls.Add(tabCadastroAtendentes);
            tbcTipoCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbcTipoCadastro.Location = new Point(3, 0);
            tbcTipoCadastro.Name = "tbcTipoCadastro";
            tbcTipoCadastro.SelectedIndex = 0;
            tbcTipoCadastro.Size = new Size(775, 507);
            tbcTipoCadastro.TabIndex = 19;
            // 
            // tabCadastroAdmin
            // 
            tabCadastroAdmin.Controls.Add(btnPaginaAtendente);
            tabCadastroAdmin.Controls.Add(txtEmail);
            tabCadastroAdmin.Controls.Add(btnCadastrar);
            tabCadastroAdmin.Controls.Add(lblEmail);
            tabCadastroAdmin.Controls.Add(txtConfirmaSenha);
            tabCadastroAdmin.Controls.Add(lblNome);
            tabCadastroAdmin.Controls.Add(lblConfirmaSenha);
            tabCadastroAdmin.Controls.Add(txtNome);
            tabCadastroAdmin.Controls.Add(lblTitulo);
            tabCadastroAdmin.Controls.Add(lblSenha);
            tabCadastroAdmin.Controls.Add(txtSenha);
            tabCadastroAdmin.Location = new Point(4, 24);
            tabCadastroAdmin.Name = "tabCadastroAdmin";
            tabCadastroAdmin.Padding = new Padding(3);
            tabCadastroAdmin.Size = new Size(767, 479);
            tabCadastroAdmin.TabIndex = 0;
            tabCadastroAdmin.Text = "Cadastro Adminstradores";
            tabCadastroAdmin.UseVisualStyleBackColor = true;
            // 
            // btnPaginaAtendente
            // 
            btnPaginaAtendente.Location = new Point(643, 30);
            btnPaginaAtendente.Name = "btnPaginaAtendente";
            btnPaginaAtendente.Size = new Size(101, 49);
            btnPaginaAtendente.TabIndex = 19;
            btnPaginaAtendente.Text = "Cadastrar Atendente";
            btnPaginaAtendente.UseVisualStyleBackColor = true;
            btnPaginaAtendente.Click += btnPaginaAtendente_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(314, 198);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 10;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.Location = new Point(318, 397);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(140, 57);
            btnCadastrar.TabIndex = 18;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(373, 177);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Anchor = AnchorStyles.None;
            txtConfirmaSenha.Location = new Point(314, 302);
            txtConfirmaSenha.Margin = new Padding(3, 2, 3, 2);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(154, 23);
            txtConfirmaSenha.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.None;
            lblNome.AutoSize = true;
            lblNome.Location = new Point(371, 123);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.Anchor = AnchorStyles.None;
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Location = new Point(343, 285);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(96, 15);
            lblConfirmaSenha.TabIndex = 14;
            lblConfirmaSenha.Text = "Confirmar Senha";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.None;
            txtNome.Location = new Point(314, 148);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(154, 23);
            txtNome.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(211, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(330, 32);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Cadastro de Administradores";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.None;
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(372, 231);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(38, 15);
            lblSenha.TabIndex = 11;
            lblSenha.Text = "senha";
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.None;
            txtSenha.Location = new Point(314, 248);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(154, 23);
            txtSenha.TabIndex = 12;
            // 
            // tabCadastroAtendentes
            // 
            tabCadastroAtendentes.Controls.Add(lblErro2);
            tabCadastroAtendentes.Controls.Add(btnSecretaria);
            tabCadastroAtendentes.Controls.Add(btnFinanceiro);
            tabCadastroAtendentes.Controls.Add(lblSetor);
            tabCadastroAtendentes.Controls.Add(button1);
            tabCadastroAtendentes.Controls.Add(txtEmail2);
            tabCadastroAtendentes.Controls.Add(lnlEmail2);
            tabCadastroAtendentes.Controls.Add(txtNome2);
            tabCadastroAtendentes.Controls.Add(lblNome2);
            tabCadastroAtendentes.Controls.Add(label3);
            tabCadastroAtendentes.Controls.Add(btnPaginaAdmin);
            tabCadastroAtendentes.Location = new Point(4, 24);
            tabCadastroAtendentes.Name = "tabCadastroAtendentes";
            tabCadastroAtendentes.Padding = new Padding(3);
            tabCadastroAtendentes.Size = new Size(767, 479);
            tabCadastroAtendentes.TabIndex = 1;
            tabCadastroAtendentes.Text = "Cadastro Atendentes";
            tabCadastroAtendentes.UseVisualStyleBackColor = true;
            // 
            // lblErro2
            // 
            lblErro2.AutoSize = true;
            lblErro2.ForeColor = Color.Red;
            lblErro2.Location = new Point(290, 325);
            lblErro2.Name = "lblErro2";
            lblErro2.Size = new Size(160, 15);
            lblErro2.TabIndex = 10;
            lblErro2.Text = "                                                   ";
            // 
            // btnSecretaria
            // 
            btnSecretaria.Location = new Point(390, 268);
            btnSecretaria.Name = "btnSecretaria";
            btnSecretaria.Size = new Size(87, 35);
            btnSecretaria.TabIndex = 9;
            btnSecretaria.Text = "Secretaria";
            btnSecretaria.UseVisualStyleBackColor = true;
            btnSecretaria.Click += btnSecretaria_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Location = new Point(279, 268);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(87, 35);
            btnFinanceiro.TabIndex = 8;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(358, 239);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(34, 15);
            lblSetor.TabIndex = 7;
            lblSetor.Text = "Setor";
            // 
            // button1
            // 
            button1.Location = new Point(289, 376);
            button1.Name = "button1";
            button1.Size = new Size(161, 37);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmail2
            // 
            txtEmail2.Location = new Point(303, 196);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(137, 23);
            txtEmail2.TabIndex = 5;
            // 
            // lnlEmail2
            // 
            lnlEmail2.AutoSize = true;
            lnlEmail2.Location = new Point(354, 175);
            lnlEmail2.Name = "lnlEmail2";
            lnlEmail2.Size = new Size(36, 15);
            lnlEmail2.TabIndex = 4;
            lnlEmail2.Text = "Email";
            // 
            // txtNome2
            // 
            txtNome2.Location = new Point(303, 143);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(137, 23);
            txtNome2.TabIndex = 3;
            // 
            // lblNome2
            // 
            lblNome2.AutoSize = true;
            lblNome2.Location = new Point(354, 122);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(40, 15);
            lblNome2.TabIndex = 2;
            lblNome2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 45);
            label3.Name = "label3";
            label3.Size = new Size(277, 32);
            label3.TabIndex = 1;
            label3.Text = "Cadastro de Atendentes";
            // 
            // btnPaginaAdmin
            // 
            btnPaginaAdmin.Location = new Point(643, 30);
            btnPaginaAdmin.Name = "btnPaginaAdmin";
            btnPaginaAdmin.Size = new Size(101, 49);
            btnPaginaAdmin.TabIndex = 0;
            btnPaginaAdmin.Text = "Cadastrar Admin";
            btnPaginaAdmin.UseVisualStyleBackColor = true;
            btnPaginaAdmin.Click += btnPaginaAdmin_Click;
            // 
            // tbAjuda
            // 
            tbAjuda.Controls.Add(lblTituloAjuda);
            tbAjuda.Location = new Point(4, 24);
            tbAjuda.Name = "tbAjuda";
            tbAjuda.Padding = new Padding(3);
            tbAjuda.Size = new Size(781, 510);
            tbAjuda.TabIndex = 3;
            tbAjuda.Text = "Ajuda";
            tbAjuda.UseVisualStyleBackColor = true;
            // 
            // lblTituloAjuda
            // 
            lblTituloAjuda.AutoSize = true;
            lblTituloAjuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloAjuda.Location = new Point(282, 129);
            lblTituloAjuda.Name = "lblTituloAjuda";
            lblTituloAjuda.Size = new Size(70, 25);
            lblTituloAjuda.TabIndex = 14;
            lblTituloAjuda.Text = "AJUDA";
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 545);
            Controls.Add(tbcPaginas);
            Controls.Add(pnlMenu);
            Margin = new Padding(3, 2, 3, 2);
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
            tbcTipoCadastro.ResumeLayout(false);
            tabCadastroAdmin.ResumeLayout(false);
            tabCadastroAdmin.PerformLayout();
            tabCadastroAtendentes.ResumeLayout(false);
            tabCadastroAtendentes.PerformLayout();
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
        private Button btnCadrastoAdmin;
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
        private Button btnEditPergunta1;
        private Button btnAddPergunta1;
        private Label lblPergunta4;
        private Label lblPergunta3;
        private Label lblPergunta2;
        private Label lblPergunta1;
        private Label lblIdPergunta4;
        private Label lblIdPergunta3;
        private Label lblIdPergunta2;
        private Label lblIdPergunta1;
        private Button btnDelPergunta1;
        private TabControl tbcTipoCadastro;
        private TabPage tabCadastroAdmin;
        private TabPage tabCadastroAtendentes;
        private Button btnPaginaAtendente;
        private Button btnPaginaAdmin;
        private Label label3;
        private Label lblNome2;
        private Label lblSetor;
        private Button button1;
        private TextBox txtEmail2;
        private Label lnlEmail2;
        private TextBox txtNome2;
        private Button btnSecretaria;
        private Button btnFinanceiro;
        private Label lblErro2;
    }
}