namespace Projeto_de_Extensao.Formulários.Relatórios
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            pnlNavBar = new Panel();
            btnVoltar = new Button();
            lblTituloPrincipal = new Label();
            pnlOpcoes = new Panel();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            btnHome = new Button();
            pictureBox1 = new PictureBox();
            pnlTitulo = new Panel();
            lblLinkHome = new Label();
            lblTituloPagina = new Label();
            panel1 = new Panel();
            lblTotalDeAvaliacoes = new Label();
            lblAvaliaçõesRespondidas = new Label();
            lblAvaliações = new Label();
            pictureBox5 = new PictureBox();
            panel2 = new Panel();
            lblTotalAtendentesAvaliados = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox7 = new PictureBox();
            panel3 = new Panel();
            lblTotalSetoresCadastrados = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel4 = new Panel();
            chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnAvancarAtendentes = new Button();
            lblSetor = new Label();
            cmbSetores = new ComboBox();
            btnExportaPdf = new Button();
            btnExportaExcel = new Button();
            pnlNavBar.SuspendLayout();
            pnlOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitulo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.Brown;
            pnlNavBar.Controls.Add(btnVoltar);
            pnlNavBar.Controls.Add(lblTituloPrincipal);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Margin = new Padding(3, 2, 3, 2);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1336, 56);
            pnlNavBar.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVoltar.BackColor = Color.Brown;
            btnVoltar.BackgroundImage = Properties.Resources.home;
            btnVoltar.BackgroundImageLayout = ImageLayout.Stretch;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Location = new Point(1251, 5);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(82, 49);
            btnVoltar.TabIndex = 2;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = Color.WhiteSmoke;
            lblTituloPrincipal.Location = new Point(3, 0);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(205, 53);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Relatórios ADMIN";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOpcoes
            // 
            pnlOpcoes.BackColor = Color.FromArgb(52, 73, 94);
            pnlOpcoes.Controls.Add(button4);
            pnlOpcoes.Controls.Add(pictureBox3);
            pnlOpcoes.Controls.Add(button3);
            pnlOpcoes.Controls.Add(pictureBox2);
            pnlOpcoes.Controls.Add(btnHome);
            pnlOpcoes.Controls.Add(pictureBox1);
            pnlOpcoes.Dock = DockStyle.Left;
            pnlOpcoes.Location = new Point(0, 56);
            pnlOpcoes.Margin = new Padding(3, 2, 3, 2);
            pnlOpcoes.Name = "pnlOpcoes";
            pnlOpcoes.Size = new Size(219, 615);
            pnlOpcoes.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 73, 94);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(69, 356);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(139, 46);
            button4.TabIndex = 5;
            button4.Text = "Sugestões";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.graph;
            pictureBox3.Location = new Point(11, 356);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(52, 73, 94);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(69, 269);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(139, 46);
            button3.TabIndex = 3;
            button3.Text = "Perguntas";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.graph;
            pictureBox2.Location = new Point(11, 269);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(52, 73, 94);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F);
            btnHome.ForeColor = Color.WhiteSmoke;
            btnHome.Location = new Point(69, 181);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(139, 46);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(11, 181);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblLinkHome);
            pnlTitulo.Controls.Add(lblTituloPagina);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(219, 56);
            pnlTitulo.Margin = new Padding(3, 2, 3, 2);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1117, 45);
            pnlTitulo.TabIndex = 2;
            // 
            // lblLinkHome
            // 
            lblLinkHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinkHome.AutoSize = true;
            lblLinkHome.Font = new Font("Segoe UI", 10F);
            lblLinkHome.Location = new Point(964, 15);
            lblLinkHome.Name = "lblLinkHome";
            lblLinkHome.Size = new Size(126, 19);
            lblLinkHome.TabIndex = 1;
            lblLinkHome.Text = "Home / Dashboard";
            // 
            // lblTituloPagina
            // 
            lblTituloPagina.AutoSize = true;
            lblTituloPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloPagina.Location = new Point(24, 15);
            lblTituloPagina.Name = "lblTituloPagina";
            lblTituloPagina.Size = new Size(82, 19);
            lblTituloPagina.TabIndex = 0;
            lblTituloPagina.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(52, 152, 219);
            panel1.Controls.Add(lblTotalDeAvaliacoes);
            panel1.Controls.Add(lblAvaliaçõesRespondidas);
            panel1.Controls.Add(lblAvaliações);
            panel1.Controls.Add(pictureBox5);
            panel1.Location = new Point(243, 125);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 136);
            panel1.TabIndex = 3;
            // 
            // lblTotalDeAvaliacoes
            // 
            lblTotalDeAvaliacoes.AutoSize = true;
            lblTotalDeAvaliacoes.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalDeAvaliacoes.ForeColor = Color.WhiteSmoke;
            lblTotalDeAvaliacoes.Location = new Point(0, 46);
            lblTotalDeAvaliacoes.Name = "lblTotalDeAvaliacoes";
            lblTotalDeAvaliacoes.Size = new Size(80, 46);
            lblTotalDeAvaliacoes.TabIndex = 6;
            lblTotalDeAvaliacoes.Text = "100";
            // 
            // lblAvaliaçõesRespondidas
            // 
            lblAvaliaçõesRespondidas.AutoSize = true;
            lblAvaliaçõesRespondidas.ForeColor = Color.WhiteSmoke;
            lblAvaliaçõesRespondidas.Location = new Point(18, 112);
            lblAvaliaçõesRespondidas.Name = "lblAvaliaçõesRespondidas";
            lblAvaliaçõesRespondidas.Size = new Size(194, 15);
            lblAvaliaçõesRespondidas.TabIndex = 5;
            lblAvaliaçõesRespondidas.Text = "Avaliações Respondidas no período";
            // 
            // lblAvaliações
            // 
            lblAvaliações.AutoSize = true;
            lblAvaliações.ForeColor = Color.WhiteSmoke;
            lblAvaliações.Location = new Point(18, 8);
            lblAvaliações.Name = "lblAvaliações";
            lblAvaliações.Size = new Size(63, 15);
            lblAvaliações.TabIndex = 4;
            lblAvaliações.Text = "Avaliações";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.graph;
            pictureBox5.Location = new Point(211, 42);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 46);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(46, 204, 113);
            panel2.Controls.Add(lblTotalAtendentesAvaliados);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(563, 125);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 136);
            panel2.TabIndex = 4;
            // 
            // lblTotalAtendentesAvaliados
            // 
            lblTotalAtendentesAvaliados.AutoSize = true;
            lblTotalAtendentesAvaliados.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalAtendentesAvaliados.ForeColor = Color.WhiteSmoke;
            lblTotalAtendentesAvaliados.Location = new Point(3, 46);
            lblTotalAtendentesAvaliados.Name = "lblTotalAtendentesAvaliados";
            lblTotalAtendentesAvaliados.Size = new Size(60, 46);
            lblTotalAtendentesAvaliados.TabIndex = 9;
            lblTotalAtendentesAvaliados.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 8;
            label3.Text = "Atendentes Avaliados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(16, 8);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Atendentes";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.about_us;
            pictureBox7.Location = new Point(360, 46);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(230, 126, 34);
            panel3.Controls.Add(lblTotalSetoresCadastrados);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox6);
            panel3.Location = new Point(1028, 125);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 136);
            panel3.TabIndex = 5;
            // 
            // lblTotalSetoresCadastrados
            // 
            lblTotalSetoresCadastrados.AutoSize = true;
            lblTotalSetoresCadastrados.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalSetoresCadastrados.ForeColor = Color.WhiteSmoke;
            lblTotalSetoresCadastrados.Location = new Point(12, 51);
            lblTotalSetoresCadastrados.Name = "lblTotalSetoresCadastrados";
            lblTotalSetoresCadastrados.Size = new Size(40, 46);
            lblTotalSetoresCadastrados.TabIndex = 12;
            lblTotalSetoresCadastrados.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(12, 112);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 11;
            label6.Text = "Setores Cadastrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(12, 8);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 10;
            label7.Text = "Setores";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user;
            pictureBox6.Location = new Point(214, 42);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 46);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(1046, 311);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 6;
            label8.Text = "Período";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(1048, 328);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(1048, 351);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 8;
            label9.Text = "até";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(1048, 368);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(262, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Location = new Point(243, 552);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(634, 77);
            panel4.TabIndex = 10;
            // 
            // chtGrafico
            // 
            chtGrafico.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtGrafico.Legends.Add(legend1);
            chtGrafico.Location = new Point(246, 484);
            chtGrafico.Margin = new Padding(3, 2, 3, 2);
            chtGrafico.Name = "chtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtGrafico.Series.Add(series1);
            chtGrafico.Size = new Size(657, 176);
            chtGrafico.TabIndex = 1;
            chtGrafico.Text = "Gráfico";
            // 
            // btnAvancarAtendentes
            // 
            btnAvancarAtendentes.Anchor = AnchorStyles.None;
            btnAvancarAtendentes.BackColor = Color.Brown;
            btnAvancarAtendentes.BackgroundImage = (Image)resources.GetObject("btnAvancarAtendentes.BackgroundImage");
            btnAvancarAtendentes.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvancarAtendentes.FlatStyle = FlatStyle.Flat;
            btnAvancarAtendentes.Location = new Point(1046, 453);
            btnAvancarAtendentes.Name = "btnAvancarAtendentes";
            btnAvancarAtendentes.Size = new Size(262, 45);
            btnAvancarAtendentes.TabIndex = 15;
            btnAvancarAtendentes.UseVisualStyleBackColor = false;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.None;
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(1048, 394);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(34, 15);
            lblSetor.TabIndex = 17;
            lblSetor.Text = "Setor";
            // 
            // cmbSetores
            // 
            cmbSetores.Anchor = AnchorStyles.None;
            cmbSetores.FormattingEnabled = true;
            cmbSetores.Location = new Point(1048, 412);
            cmbSetores.Margin = new Padding(3, 2, 3, 2);
            cmbSetores.Name = "cmbSetores";
            cmbSetores.Size = new Size(260, 23);
            cmbSetores.TabIndex = 18;
            // 
            // btnExportaPdf
            // 
            btnExportaPdf.Anchor = AnchorStyles.None;
            btnExportaPdf.BackColor = SystemColors.Control;
            btnExportaPdf.BackgroundImage = Properties.Resources.btnExportaPdf;
            btnExportaPdf.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportaPdf.FlatStyle = FlatStyle.Flat;
            btnExportaPdf.Location = new Point(1046, 523);
            btnExportaPdf.Name = "btnExportaPdf";
            btnExportaPdf.Size = new Size(262, 45);
            btnExportaPdf.TabIndex = 19;
            btnExportaPdf.UseVisualStyleBackColor = false;
            btnExportaPdf.Click += btnExportarPdf_Click;
            // 
            // btnExportaExcel
            // 
            btnExportaExcel.Anchor = AnchorStyles.None;
            btnExportaExcel.BackColor = SystemColors.Control;
            btnExportaExcel.BackgroundImage = Properties.Resources.btnExportaExcel;
            btnExportaExcel.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportaExcel.FlatStyle = FlatStyle.Flat;
            btnExportaExcel.Location = new Point(1046, 584);
            btnExportaExcel.Name = "btnExportaExcel";
            btnExportaExcel.Size = new Size(262, 45);
            btnExportaExcel.TabIndex = 20;
            btnExportaExcel.UseVisualStyleBackColor = false;
            btnExportaExcel.Click += btnExportarExcel_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 671);
            Controls.Add(chtGrafico);
            Controls.Add(btnExportaExcel);
            Controls.Add(btnExportaPdf);
            Controls.Add(cmbSetores);
            Controls.Add(lblSetor);
            Controls.Add(btnAvancarAtendentes);
            Controls.Add(panel4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label9);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlOpcoes);
            Controls.Add(pnlNavBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmDashboard";
            Text = "FrmRelatorios";
            WindowState = FormWindowState.Maximized;
            pnlNavBar.ResumeLayout(false);
            pnlOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private Panel pnlOpcoes;
        private Label lblTituloPrincipal;
        private Panel pnlTitulo;
        private Label lblLinkHome;
        private Label lblTituloPagina;
        private Button button4;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox2;
        private Button btnHome;
        private PictureBox pictureBox1;
        private Button btnVoltar;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Panel panel2;
        private PictureBox pictureBox7;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Label lblAvaliações;
        private Label lblTotalDeAvaliacoes;
        private Label lblAvaliaçõesRespondidas;
        private Label lblTotalAtendentesAvaliados;
        private Label label3;
        private Label label4;
        private Label lblTotalSetoresCadastrados;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private Button btnAvancarAtendentes;
        private Label lblSetor;
        private ComboBox cmbSetores;
        private Button btnExportaPdf;
        private Button btnExportaExcel;
    }
}