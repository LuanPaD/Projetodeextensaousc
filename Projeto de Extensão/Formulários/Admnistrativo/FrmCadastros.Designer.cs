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
            tlpBotoesEscolha = new TableLayoutPanel();
            btnAjuda = new Button();
            btnCadrastoAdmin = new Button();
            btnSetor = new Button();
            btnPerguntas = new Button();
            btnAtendentes = new Button();
            panelTopo = new Panel();
            pictureBoxLogo = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnSair = new Button();
            tbcPaginas = new TabControl();
            tbSetor = new TabPage();
            lblTituloSetor = new Label();
            tbPerguntas = new TabPage();
            btnCadastrarPergunta = new Button();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            lblTituloPergunta = new Label();
            label7 = new Label();
            btnAdicionarAlternativa = new Button();
            tbUsuario = new TabPage();
            tbcTipoCadastro = new TabControl();
            tabCadastroAdmin = new TabPage();
            btnCadastrar = new Button();
            btnPaginaAtendente = new Button();
            txtEmail = new TextBox();
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
            tabUsuarioCadastrado = new TabPage();
            btnCarregar = new Button();
            dgvUsuariosCadastrados = new DataGridView();
            label4 = new Label();
            tbAjuda = new TabPage();
            lblTituloAjuda = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox5 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            pnlMenu.SuspendLayout();
            tlpBotoesEscolha.SuspendLayout();
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
            tabUsuarioCadastrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosCadastrados).BeginInit();
            tbAjuda.SuspendLayout();
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
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(297, 964);
            pnlMenu.TabIndex = 8;
            // 
            // tlpBotoesEscolha
            // 
            tlpBotoesEscolha.ColumnCount = 1;
            tlpBotoesEscolha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBotoesEscolha.Controls.Add(btnAjuda, 0, 4);
            tlpBotoesEscolha.Controls.Add(btnCadrastoAdmin, 0, 2);
            tlpBotoesEscolha.Controls.Add(btnSetor, 0, 0);
            tlpBotoesEscolha.Controls.Add(btnPerguntas, 0, 1);
            tlpBotoesEscolha.Controls.Add(btnAtendentes, 0, 3);
            tlpBotoesEscolha.Location = new Point(0, 176);
            tlpBotoesEscolha.Margin = new Padding(3, 4, 3, 4);
            tlpBotoesEscolha.Name = "tlpBotoesEscolha";
            tlpBotoesEscolha.RowCount = 5;
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpBotoesEscolha.Size = new Size(297, 444);
            tlpBotoesEscolha.TabIndex = 0;
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
            btnAjuda.Location = new Point(3, 356);
            btnAjuda.Margin = new Padding(3, 4, 3, 4);
            btnAjuda.Name = "btnAjuda";
            btnAjuda.Size = new Size(291, 84);
            btnAjuda.TabIndex = 15;
            btnAjuda.UseVisualStyleBackColor = false;
            btnAjuda.Click += btnAjuda_Click;
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
            btnCadrastoAdmin.Location = new Point(3, 180);
            btnCadrastoAdmin.Margin = new Padding(3, 4, 3, 4);
            btnCadrastoAdmin.Name = "btnCadrastoAdmin";
            btnCadrastoAdmin.Size = new Size(291, 80);
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
            btnSetor.Location = new Point(3, 4);
            btnSetor.Margin = new Padding(3, 4, 3, 4);
            btnSetor.Name = "btnSetor";
            btnSetor.Size = new Size(291, 80);
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
            btnPerguntas.Location = new Point(3, 92);
            btnPerguntas.Margin = new Padding(3, 4, 3, 4);
            btnPerguntas.Name = "btnPerguntas";
            btnPerguntas.Size = new Size(291, 80);
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
            btnAtendentes.Location = new Point(3, 268);
            btnAtendentes.Margin = new Padding(3, 4, 3, 4);
            btnAtendentes.Name = "btnAtendentes";
            btnAtendentes.Size = new Size(291, 80);
            btnAtendentes.TabIndex = 14;
            btnAtendentes.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(0, 743);
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
            tbcPaginas.Location = new Point(297, -37);
            tbcPaginas.Margin = new Padding(3, 4, 3, 4);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(1158, 1000);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 9;
            // 
            // tbSetor
            // 
            tbSetor.Controls.Add(button3);
            tbSetor.Controls.Add(button4);
            tbSetor.Controls.Add(textBox5);
            tbSetor.Controls.Add(label2);
            tbSetor.Controls.Add(lblTituloSetor);
            tbSetor.ForeColor = Color.Transparent;
            tbSetor.Location = new Point(4, 29);
            tbSetor.Margin = new Padding(3, 4, 3, 4);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3, 4, 3, 4);
            tbSetor.Size = new Size(1150, 967);
            tbSetor.TabIndex = 0;
            tbSetor.Text = "Setor";
            tbSetor.UseVisualStyleBackColor = true;
            // 
            // lblTituloSetor
            // 
            lblTituloSetor.AutoSize = true;
            lblTituloSetor.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTituloSetor.ForeColor = Color.Black;
            lblTituloSetor.Location = new Point(70, 65);
            lblTituloSetor.Name = "lblTituloSetor";
            lblTituloSetor.Size = new Size(185, 81);
            lblTituloSetor.TabIndex = 14;
            lblTituloSetor.Text = "Setor";
            // 
            // tbPerguntas
            // 
            tbPerguntas.Controls.Add(btnCadastrarPergunta);
            tbPerguntas.Controls.Add(textBox4);
            tbPerguntas.Controls.Add(textBox2);
            tbPerguntas.Controls.Add(label1);
            tbPerguntas.Controls.Add(textBox3);
            tbPerguntas.Controls.Add(lblTituloPergunta);
            tbPerguntas.Controls.Add(label7);
            tbPerguntas.Controls.Add(btnAdicionarAlternativa);
            tbPerguntas.Location = new Point(4, 29);
            tbPerguntas.Margin = new Padding(3, 4, 3, 4);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3, 4, 3, 4);
            tbPerguntas.Size = new Size(1150, 967);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.Anchor = AnchorStyles.Left;
            btnCadastrarPergunta.BackgroundImage = (Image)resources.GetObject("btnCadastrarPergunta.BackgroundImage");
            btnCadastrarPergunta.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrarPergunta.Location = new Point(570, 693);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(278, 82);
            btnCadastrarPergunta.TabIndex = 21;
            btnCadastrarPergunta.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 264);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(766, 41);
            textBox4.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(82, 424);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(766, 41);
            textBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 333);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 18;
            label1.Text = "Alternativas";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(82, 367);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(766, 41);
            textBox3.TabIndex = 17;
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPergunta.Location = new Point(76, 230);
            lblTituloPergunta.Name = "lblTituloPergunta";
            lblTituloPergunta.Size = new Size(106, 31);
            lblTituloPergunta.TabIndex = 16;
            lblTituloPergunta.Text = "Pergunta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label7.Location = new Point(70, 65);
            label7.Name = "label7";
            label7.Size = new Size(316, 81);
            label7.TabIndex = 14;
            label7.Text = "Perguntas";
            // 
            // btnAdicionarAlternativa
            // 
            btnAdicionarAlternativa.Anchor = AnchorStyles.Left;
            btnAdicionarAlternativa.BackgroundImage = (Image)resources.GetObject("btnAdicionarAlternativa.BackgroundImage");
            btnAdicionarAlternativa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionarAlternativa.Location = new Point(82, 697);
            btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            btnAdicionarAlternativa.Size = new Size(287, 75);
            btnAdicionarAlternativa.TabIndex = 9;
            btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            // 
            // tbUsuario
            // 
            tbUsuario.Controls.Add(tbcTipoCadastro);
            tbUsuario.Location = new Point(4, 29);
            tbUsuario.Margin = new Padding(3, 4, 3, 4);
            tbUsuario.Name = "tbUsuario";
            tbUsuario.Padding = new Padding(3, 4, 3, 4);
            tbUsuario.Size = new Size(1150, 967);
            tbUsuario.TabIndex = 2;
            tbUsuario.Text = "Usuário";
            tbUsuario.UseVisualStyleBackColor = true;
            // 
            // tbcTipoCadastro
            // 
            tbcTipoCadastro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcTipoCadastro.Controls.Add(tabCadastroAdmin);
            tbcTipoCadastro.Controls.Add(tabCadastroAtendentes);
            tbcTipoCadastro.Controls.Add(tabUsuarioCadastrado);
            tbcTipoCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbcTipoCadastro.Location = new Point(3, 4);
            tbcTipoCadastro.Margin = new Padding(3, 4, 3, 4);
            tbcTipoCadastro.Name = "tbcTipoCadastro";
            tbcTipoCadastro.SelectedIndex = 0;
            tbcTipoCadastro.Size = new Size(1142, 955);
            tbcTipoCadastro.TabIndex = 19;
            // 
            // tabCadastroAdmin
            // 
            tabCadastroAdmin.Controls.Add(btnCadastrar);
            tabCadastroAdmin.Controls.Add(btnPaginaAtendente);
            tabCadastroAdmin.Controls.Add(txtEmail);
            tabCadastroAdmin.Controls.Add(lblEmail);
            tabCadastroAdmin.Controls.Add(txtConfirmaSenha);
            tabCadastroAdmin.Controls.Add(lblNome);
            tabCadastroAdmin.Controls.Add(lblConfirmaSenha);
            tabCadastroAdmin.Controls.Add(txtNome);
            tabCadastroAdmin.Controls.Add(lblTitulo);
            tabCadastroAdmin.Controls.Add(lblSenha);
            tabCadastroAdmin.Controls.Add(txtSenha);
            tabCadastroAdmin.Location = new Point(4, 29);
            tabCadastroAdmin.Margin = new Padding(3, 4, 3, 4);
            tabCadastroAdmin.Name = "tabCadastroAdmin";
            tabCadastroAdmin.Padding = new Padding(3, 4, 3, 4);
            tabCadastroAdmin.Size = new Size(1134, 922);
            tabCadastroAdmin.TabIndex = 0;
            tabCadastroAdmin.Text = "Cadastro Adminstradores";
            tabCadastroAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Anchor = AnchorStyles.None;
            btnCadastrar.BackColor = Color.Transparent;
            btnCadastrar.BackgroundImage = (Image)resources.GetObject("btnCadastrar.BackgroundImage");
            btnCadastrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 0, 0);
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 212, 214);
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(82, 569);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(391, 103);
            btnCadastrar.TabIndex = 20;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnPaginaAtendente
            // 
            btnPaginaAtendente.Anchor = AnchorStyles.None;
            btnPaginaAtendente.BackgroundImage = (Image)resources.GetObject("btnPaginaAtendente.BackgroundImage");
            btnPaginaAtendente.BackgroundImageLayout = ImageLayout.Stretch;
            btnPaginaAtendente.Location = new Point(629, 569);
            btnPaginaAtendente.Margin = new Padding(3, 4, 3, 4);
            btnPaginaAtendente.Name = "btnPaginaAtendente";
            btnPaginaAtendente.Size = new Size(391, 103);
            btnPaginaAtendente.TabIndex = 19;
            btnPaginaAtendente.UseVisualStyleBackColor = true;
            btnPaginaAtendente.Click += btnPaginaAtendente_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(82, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(487, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblEmail.Location = new Point(82, 261);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 32);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmaSenha.Location = new Point(82, 468);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(487, 27);
            txtConfirmaSenha.TabIndex = 15;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblNome.Location = new Point(85, 176);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 32);
            lblNome.TabIndex = 7;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConfirmaSenha
            // 
            lblConfirmaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmaSenha.AutoSize = true;
            lblConfirmaSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblConfirmaSenha.Location = new Point(82, 432);
            lblConfirmaSenha.Name = "lblConfirmaSenha";
            lblConfirmaSenha.Size = new Size(197, 32);
            lblConfirmaSenha.TabIndex = 14;
            lblConfirmaSenha.Text = "Confirmar Senha";
            lblConfirmaSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(85, 212);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(487, 27);
            txtNome.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTitulo.Location = new Point(70, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(851, 81);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Cadastro de Administradores";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblSenha.Location = new Point(82, 347);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(81, 32);
            lblSenha.TabIndex = 11;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(82, 383);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(487, 27);
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
            tabCadastroAtendentes.Location = new Point(4, 29);
            tabCadastroAtendentes.Margin = new Padding(3, 4, 3, 4);
            tabCadastroAtendentes.Name = "tabCadastroAtendentes";
            tabCadastroAtendentes.Padding = new Padding(3, 4, 3, 4);
            tabCadastroAtendentes.Size = new Size(1134, 922);
            tabCadastroAtendentes.TabIndex = 1;
            tabCadastroAtendentes.Text = "Cadastro Atendentes";
            tabCadastroAtendentes.UseVisualStyleBackColor = true;
            // 
            // lblErro2
            // 
            lblErro2.AutoSize = true;
            lblErro2.ForeColor = Color.Red;
            lblErro2.Location = new Point(331, 472);
            lblErro2.Name = "lblErro2";
            lblErro2.Size = new Size(213, 20);
            lblErro2.TabIndex = 10;
            lblErro2.Text = "                                                   ";
            // 
            // btnSecretaria
            // 
            btnSecretaria.Location = new Point(70, 487);
            btnSecretaria.Margin = new Padding(3, 4, 3, 4);
            btnSecretaria.Name = "btnSecretaria";
            btnSecretaria.Size = new Size(162, 59);
            btnSecretaria.TabIndex = 9;
            btnSecretaria.Text = "Secretaria";
            btnSecretaria.UseVisualStyleBackColor = true;
            btnSecretaria.Click += btnSecretaria_Click;
            // 
            // btnFinanceiro
            // 
            btnFinanceiro.Location = new Point(70, 420);
            btnFinanceiro.Margin = new Padding(3, 4, 3, 4);
            btnFinanceiro.Name = "btnFinanceiro";
            btnFinanceiro.Size = new Size(162, 59);
            btnFinanceiro.TabIndex = 8;
            btnFinanceiro.Text = "Financeiro";
            btnFinanceiro.UseVisualStyleBackColor = true;
            btnFinanceiro.Click += btnFinanceiro_Click;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblSetor.Location = new Point(70, 371);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(72, 32);
            lblSetor.TabIndex = 7;
            lblSetor.Text = "Setor";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(519, 687);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(160, 76);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmail2
            // 
            txtEmail2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail2.Location = new Point(70, 315);
            txtEmail2.Margin = new Padding(3, 4, 3, 4);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(700, 27);
            txtEmail2.TabIndex = 5;
            // 
            // lnlEmail2
            // 
            lnlEmail2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lnlEmail2.AutoSize = true;
            lnlEmail2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lnlEmail2.Location = new Point(70, 277);
            lnlEmail2.Name = "lnlEmail2";
            lnlEmail2.Size = new Size(72, 32);
            lnlEmail2.TabIndex = 4;
            lnlEmail2.Text = "Email";
            // 
            // txtNome2
            // 
            txtNome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome2.Location = new Point(70, 217);
            txtNome2.Margin = new Padding(3, 4, 3, 4);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(700, 27);
            txtNome2.TabIndex = 3;
            // 
            // lblNome2
            // 
            lblNome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNome2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblNome2.Location = new Point(70, 180);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(497, 33);
            lblNome2.TabIndex = 2;
            lblNome2.Text = "Nome";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 65);
            label3.Name = "label3";
            label3.Size = new Size(914, 83);
            label3.TabIndex = 1;
            label3.Text = "Cadastro de Atendentes";
            // 
            // btnPaginaAdmin
            // 
            btnPaginaAdmin.Anchor = AnchorStyles.None;
            btnPaginaAdmin.Location = new Point(863, 155);
            btnPaginaAdmin.Margin = new Padding(3, 4, 3, 4);
            btnPaginaAdmin.Name = "btnPaginaAdmin";
            btnPaginaAdmin.Size = new Size(115, 65);
            btnPaginaAdmin.TabIndex = 0;
            btnPaginaAdmin.Text = "Cadastrar Admin";
            btnPaginaAdmin.UseVisualStyleBackColor = true;
            btnPaginaAdmin.Click += btnPaginaAdmin_Click;
            // 
            // tabUsuarioCadastrado
            // 
            tabUsuarioCadastrado.Controls.Add(btnCarregar);
            tabUsuarioCadastrado.Controls.Add(dgvUsuariosCadastrados);
            tabUsuarioCadastrado.Controls.Add(label4);
            tabUsuarioCadastrado.Location = new Point(4, 29);
            tabUsuarioCadastrado.Margin = new Padding(3, 4, 3, 4);
            tabUsuarioCadastrado.Name = "tabUsuarioCadastrado";
            tabUsuarioCadastrado.Padding = new Padding(3, 4, 3, 4);
            tabUsuarioCadastrado.Size = new Size(1134, 922);
            tabUsuarioCadastrado.TabIndex = 2;
            tabUsuarioCadastrado.Text = "Usuários Cadastrados";
            tabUsuarioCadastrado.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(121, 48);
            btnCarregar.Margin = new Padding(3, 4, 3, 4);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(86, 31);
            btnCarregar.TabIndex = 4;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += button2_Click;
            // 
            // dgvUsuariosCadastrados
            // 
            dgvUsuariosCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuariosCadastrados.Location = new Point(25, 131);
            dgvUsuariosCadastrados.Margin = new Padding(3, 4, 3, 4);
            dgvUsuariosCadastrados.Name = "dgvUsuariosCadastrados";
            dgvUsuariosCadastrados.RowHeadersWidth = 51;
            dgvUsuariosCadastrados.Size = new Size(829, 457);
            dgvUsuariosCadastrados.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(286, 35);
            label4.Name = "label4";
            label4.Size = new Size(313, 41);
            label4.TabIndex = 2;
            label4.Text = "Usuários Cadastrados";
            // 
            // tbAjuda
            // 
            tbAjuda.Controls.Add(lblTituloAjuda);
            tbAjuda.Location = new Point(4, 29);
            tbAjuda.Margin = new Padding(3, 4, 3, 4);
            tbAjuda.Name = "tbAjuda";
            tbAjuda.Padding = new Padding(3, 4, 3, 4);
            tbAjuda.Size = new Size(1150, 967);
            tbAjuda.TabIndex = 3;
            tbAjuda.Text = "Ajuda";
            tbAjuda.UseVisualStyleBackColor = true;
            // 
            // lblTituloAjuda
            // 
            lblTituloAjuda.AutoSize = true;
            lblTituloAjuda.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTituloAjuda.Location = new Point(70, 65);
            lblTituloAjuda.Name = "lblTituloAjuda";
            lblTituloAjuda.Size = new Size(316, 81);
            lblTituloAjuda.TabIndex = 15;
            lblTituloAjuda.Text = "Perguntas";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(66, 375);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(766, 41);
            textBox5.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 341);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 23;
            label2.Text = "Nome";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(554, 827);
            button3.Name = "button3";
            button3.Size = new Size(278, 82);
            button3.TabIndex = 26;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(66, 831);
            button4.Name = "button4";
            button4.Size = new Size(287, 75);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmCadastros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 964);
            Controls.Add(tbcPaginas);
            Controls.Add(pnlMenu);
            Name = "FrmCadastros";
            Text = "FrmCadastros";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            tlpBotoesEscolha.ResumeLayout(false);
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
            tabUsuarioCadastrado.ResumeLayout(false);
            tabUsuarioCadastrado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuariosCadastrados).EndInit();
            tbAjuda.ResumeLayout(false);
            tbAjuda.PerformLayout();
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
        private Button btnCadrastoAdmin;
        private Button btnPerguntas;
        private TabControl tbcPaginas;
        private TabPage tbSetor;
        private TabPage tbPerguntas;
        private TabPage tbUsuario;
        private TabPage tbAjuda;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnSair;
        private TextBox txtConfirmaSenha;
        private Label lblConfirmaSenha;
        private Label lblTitulo;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnAdicionarAlternativa;
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
        private TabPage tabUsuarioCadastrado;
        private Button btnCarregar;
        private DataGridView dgvUsuariosCadastrados;
        private Label label4;
        private Button btnCadastrar;
        private Button btnAjuda;
        private Label lblTituloSetor;
        private Label label7;
        private Label lblTituloAjuda;
        private Label label1;
        private TextBox textBox3;
        private Label lblTituloPergunta;
        private TextBox textBox4;
        private TextBox textBox2;
        private Button btnCadastrarPergunta;
        private TextBox textBox5;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}