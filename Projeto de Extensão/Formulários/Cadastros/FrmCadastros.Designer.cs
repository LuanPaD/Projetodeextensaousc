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
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(297, 964);
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
            btnAdmin.Location = new Point(3, 180);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(291, 80);
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
            btnAtendentes.Click += btnAtendente_Click;
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
            tbAtendente.Location = new Point(4, 29);
            tbAtendente.Margin = new Padding(3, 4, 3, 4);
            tbAtendente.Name = "tbAtendente";
            tbAtendente.Padding = new Padding(3, 4, 3, 4);
            tbAtendente.Size = new Size(1150, 930);
            tbAtendente.TabIndex = 3;
            tbAtendente.Text = "Atendente";
            tbAtendente.UseVisualStyleBackColor = true;
            // 
            // cmbListaDeSetores
            // 
            cmbListaDeSetores.FormattingEnabled = true;
            cmbListaDeSetores.Location = new Point(87, 387);
            cmbListaDeSetores.Margin = new Padding(3, 4, 3, 4);
            cmbListaDeSetores.Name = "cmbListaDeSetores";
            cmbListaDeSetores.Size = new Size(289, 28);
            cmbListaDeSetores.TabIndex = 53;
            // 
            // lblErro2
            // 
            lblErro2.Anchor = AnchorStyles.None;
            lblErro2.AutoSize = true;
            lblErro2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblErro2.ForeColor = Color.Red;
            lblErro2.Location = new Point(382, 563);
            lblErro2.Name = "lblErro2";
            lblErro2.Size = new Size(322, 32);
            lblErro2.TabIndex = 52;
            lblErro2.Text = "                                            ";
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 13.8F);
            lblSetor.Location = new Point(87, 349);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(67, 31);
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
            btnHomeAtendentes.Location = new Point(1058, 19);
            btnHomeAtendentes.Margin = new Padding(3, 4, 3, 4);
            btnHomeAtendentes.Name = "btnHomeAtendentes";
            btnHomeAtendentes.Size = new Size(80, 91);
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
            btnCadastraAtendente.Location = new Point(322, 615);
            btnCadastraAtendente.Name = "btnCadastraAtendente";
            btnCadastraAtendente.Size = new Size(391, 103);
            btnCadastraAtendente.TabIndex = 47;
            btnCadastraAtendente.UseVisualStyleBackColor = false;
            btnCadastraAtendente.Click += btnCadastraAtendente_Click;
            // 
            // txtEmail2
            // 
            txtEmail2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail2.Location = new Point(85, 303);
            txtEmail2.Name = "txtEmail2";
            txtEmail2.Size = new Size(897, 27);
            txtEmail2.TabIndex = 43;
            // 
            // txtNome2
            // 
            txtNome2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome2.Location = new Point(87, 217);
            txtNome2.Name = "txtNome2";
            txtNome2.Size = new Size(897, 27);
            txtNome2.TabIndex = 42;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F);
            label5.Location = new Point(85, 267);
            label5.Name = "label5";
            label5.Size = new Size(70, 31);
            label5.TabIndex = 41;
            label5.Text = "Email";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F);
            label6.Location = new Point(87, 181);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 40;
            label6.Text = "Nome";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label8.Location = new Point(70, 65);
            label8.Name = "label8";
            label8.Size = new Size(704, 81);
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
            tbAdmin.Location = new Point(4, 29);
            tbAdmin.Margin = new Padding(3, 4, 3, 4);
            tbAdmin.Name = "tbAdmin";
            tbAdmin.Padding = new Padding(3, 4, 3, 4);
            tbAdmin.Size = new Size(1150, 930);
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
            lblErro.Location = new Point(387, 563);
            lblErro.Name = "lblErro";
            lblErro.Size = new Size(322, 32);
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
            btnHomeAdmin.Location = new Point(1058, 8);
            btnHomeAdmin.Margin = new Padding(3, 4, 3, 4);
            btnHomeAdmin.Name = "btnHomeAdmin";
            btnHomeAdmin.Size = new Size(80, 91);
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
            button9.Location = new Point(322, 615);
            button9.Name = "button9";
            button9.Size = new Size(391, 103);
            button9.TabIndex = 30;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btnCadastrar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(88, 300);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(897, 27);
            txtEmail.TabIndex = 24;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtConfirmaSenha.Location = new Point(88, 471);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(897, 27);
            txtConfirmaSenha.TabIndex = 29;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(90, 215);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(897, 27);
            txtNome.TabIndex = 23;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.Location = new Point(88, 385);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(897, 27);
            txtSenha.TabIndex = 26;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F);
            lblEmail.Location = new Point(88, 264);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 31);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNome
            // 
            lblNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 13.8F);
            lblNome.Location = new Point(90, 179);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(76, 31);
            lblNome.TabIndex = 21;
            lblNome.Text = "Nome";
            lblNome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Font = new Font("Segoe UI", 13.8F);
            lblConfirmarSenha.Location = new Point(88, 435);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(183, 31);
            lblConfirmarSenha.TabIndex = 28;
            lblConfirmarSenha.Text = "Confirmar Senha";
            lblConfirmarSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAdministradores
            // 
            lblAdministradores.AutoSize = true;
            lblAdministradores.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblAdministradores.Location = new Point(70, 65);
            lblAdministradores.Name = "lblAdministradores";
            lblAdministradores.Size = new Size(851, 81);
            lblAdministradores.TabIndex = 27;
            lblAdministradores.Text = "Cadastro de Administradores";
            // 
            // lblSenha
            // 
            lblSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 13.8F);
            lblSenha.Location = new Point(88, 349);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(76, 31);
            lblSenha.TabIndex = 25;
            lblSenha.Text = "Senha";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPerguntas
            // 
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
            tbPerguntas.Location = new Point(4, 29);
            tbPerguntas.Margin = new Padding(3, 4, 3, 4);
            tbPerguntas.Name = "tbPerguntas";
            tbPerguntas.Padding = new Padding(3, 4, 3, 4);
            tbPerguntas.Size = new Size(1150, 930);
            tbPerguntas.TabIndex = 1;
            tbPerguntas.Text = "Perguntas";
            tbPerguntas.UseVisualStyleBackColor = true;
            // 
            // txtAlternativa10
            // 
            txtAlternativa10.Location = new Point(82, 791);
            txtAlternativa10.Multiline = true;
            txtAlternativa10.Name = "txtAlternativa10";
            txtAlternativa10.Size = new Size(766, 41);
            txtAlternativa10.TabIndex = 36;
            // 
            // txtAlternativa9
            // 
            txtAlternativa9.Location = new Point(82, 744);
            txtAlternativa9.Multiline = true;
            txtAlternativa9.Name = "txtAlternativa9";
            txtAlternativa9.Size = new Size(766, 41);
            txtAlternativa9.TabIndex = 35;
            // 
            // txtAlternativa8
            // 
            txtAlternativa8.Location = new Point(82, 697);
            txtAlternativa8.Multiline = true;
            txtAlternativa8.Name = "txtAlternativa8";
            txtAlternativa8.Size = new Size(766, 41);
            txtAlternativa8.TabIndex = 34;
            // 
            // txtAlternativa7
            // 
            txtAlternativa7.Location = new Point(82, 650);
            txtAlternativa7.Multiline = true;
            txtAlternativa7.Name = "txtAlternativa7";
            txtAlternativa7.Size = new Size(766, 41);
            txtAlternativa7.TabIndex = 33;
            // 
            // txtAlternativa6
            // 
            txtAlternativa6.Location = new Point(82, 603);
            txtAlternativa6.Multiline = true;
            txtAlternativa6.Name = "txtAlternativa6";
            txtAlternativa6.Size = new Size(766, 41);
            txtAlternativa6.TabIndex = 32;
            // 
            // txtAlternativa5
            // 
            txtAlternativa5.Location = new Point(82, 556);
            txtAlternativa5.Multiline = true;
            txtAlternativa5.Name = "txtAlternativa5";
            txtAlternativa5.Size = new Size(766, 41);
            txtAlternativa5.TabIndex = 31;
            // 
            // txtAlternativa4
            // 
            txtAlternativa4.Location = new Point(82, 509);
            txtAlternativa4.Multiline = true;
            txtAlternativa4.Name = "txtAlternativa4";
            txtAlternativa4.Size = new Size(766, 41);
            txtAlternativa4.TabIndex = 30;
            // 
            // txtAlternativa3
            // 
            txtAlternativa3.Location = new Point(82, 462);
            txtAlternativa3.Multiline = true;
            txtAlternativa3.Name = "txtAlternativa3";
            txtAlternativa3.Size = new Size(766, 41);
            txtAlternativa3.TabIndex = 29;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Gainsboro;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(1045, 27);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(80, 91);
            button2.TabIndex = 28;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnVoltarParaMenu_Click;
            // 
            // btnCadastrarPergunta
            // 
            btnCadastrarPergunta.Anchor = AnchorStyles.Left;
            btnCadastrarPergunta.BackgroundImage = (Image)resources.GetObject("btnCadastrarPergunta.BackgroundImage");
            btnCadastrarPergunta.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrarPergunta.Location = new Point(570, 852);
            btnCadastrarPergunta.Name = "btnCadastrarPergunta";
            btnCadastrarPergunta.Size = new Size(278, 83);
            btnCadastrarPergunta.TabIndex = 21;
            btnCadastrarPergunta.UseVisualStyleBackColor = true;
            btnCadastrarPergunta.Click += btnCadastrarPergunta_Click;
            // 
            // txtPergunta
            // 
            txtPergunta.Location = new Point(82, 246);
            txtPergunta.Multiline = true;
            txtPergunta.Name = "txtPergunta";
            txtPergunta.Size = new Size(766, 84);
            txtPergunta.TabIndex = 1;
            // 
            // txtAlternativa2
            // 
            txtAlternativa2.Location = new Point(82, 415);
            txtAlternativa2.Multiline = true;
            txtAlternativa2.Name = "txtAlternativa2";
            txtAlternativa2.Size = new Size(766, 41);
            txtAlternativa2.TabIndex = 19;
            // 
            // txtAlternativa1
            // 
            txtAlternativa1.Location = new Point(82, 367);
            txtAlternativa1.Multiline = true;
            txtAlternativa1.Name = "txtAlternativa1";
            txtAlternativa1.Size = new Size(766, 41);
            txtAlternativa1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 333);
            label1.Name = "label1";
            label1.Size = new Size(135, 31);
            label1.TabIndex = 18;
            label1.Text = "Alternativas";
            // 
            // lblTituloPergunta
            // 
            lblTituloPergunta.AutoSize = true;
            lblTituloPergunta.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPergunta.Location = new Point(75, 212);
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
            btnAdicionarAlternativa.Location = new Point(82, 856);
            btnAdicionarAlternativa.Name = "btnAdicionarAlternativa";
            btnAdicionarAlternativa.Size = new Size(287, 75);
            btnAdicionarAlternativa.TabIndex = 9;
            btnAdicionarAlternativa.UseVisualStyleBackColor = true;
            btnAdicionarAlternativa.Click += btnAdicionarAlternativa_Click;
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
            tbSetor.Location = new Point(4, 29);
            tbSetor.Margin = new Padding(3, 4, 3, 4);
            tbSetor.Name = "tbSetor";
            tbSetor.Padding = new Padding(3, 4, 3, 4);
            tbSetor.Size = new Size(1150, 930);
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
            lblErroSetor.Location = new Point(347, 693);
            lblErroSetor.Name = "lblErroSetor";
            lblErroSetor.Size = new Size(322, 32);
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
            btnVoltarParaMenu.Location = new Point(1045, 27);
            btnVoltarParaMenu.Margin = new Padding(3, 4, 3, 4);
            btnVoltarParaMenu.Name = "btnVoltarParaMenu";
            btnVoltarParaMenu.Size = new Size(80, 91);
            btnVoltarParaMenu.TabIndex = 27;
            btnVoltarParaMenu.UseVisualStyleBackColor = false;
            btnVoltarParaMenu.Click += btnVoltarParaMenu_Click;
            // 
            // btnCadastrarSetor
            // 
            btnCadastrarSetor.Anchor = AnchorStyles.Left;
            btnCadastrarSetor.BackgroundImage = (Image)resources.GetObject("btnCadastrarSetor.BackgroundImage");
            btnCadastrarSetor.BackgroundImageLayout = ImageLayout.Stretch;
            btnCadastrarSetor.Location = new Point(554, 792);
            btnCadastrarSetor.Name = "btnCadastrarSetor";
            btnCadastrarSetor.Size = new Size(278, 83);
            btnCadastrarSetor.TabIndex = 26;
            btnCadastrarSetor.UseVisualStyleBackColor = true;
            btnCadastrarSetor.Click += btnCadastrarSetor_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(66, 796);
            button4.Name = "button4";
            button4.Size = new Size(287, 75);
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = true;
            // 
            // txtNomeSetor
            // 
            txtNomeSetor.Location = new Point(66, 375);
            txtNomeSetor.Multiline = true;
            txtNomeSetor.Name = "txtNomeSetor";
            txtNomeSetor.Size = new Size(766, 41);
            txtNomeSetor.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(59, 341);
            label2.Name = "label2";
            label2.Size = new Size(76, 31);
            label2.TabIndex = 23;
            label2.Text = "Nome";
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
            // tbcPaginas
            // 
            tbcPaginas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbcPaginas.Controls.Add(tbSetor);
            tbcPaginas.Controls.Add(tbPerguntas);
            tbcPaginas.Controls.Add(tbAdmin);
            tbcPaginas.Controls.Add(tbAtendente);
            tbcPaginas.Location = new Point(297, 0);
            tbcPaginas.Margin = new Padding(3, 4, 3, 4);
            tbcPaginas.Name = "tbcPaginas";
            tbcPaginas.SelectedIndex = 0;
            tbcPaginas.ShowToolTips = true;
            tbcPaginas.Size = new Size(1158, 963);
            tbcPaginas.SizeMode = TabSizeMode.Fixed;
            tbcPaginas.TabIndex = 8;
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
        private Button button4;
        private TextBox txtNomeSetor;
        private Label label2;
        private Label lblTituloSetor;
        private TabControl tbcPaginas;
        private Label lblErro2;
        private Label lblErro;
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
    }
}