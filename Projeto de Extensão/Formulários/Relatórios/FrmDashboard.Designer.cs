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
            button1 = new Button();
            lblTituloPrincipal = new Label();
            pnlOpcoes = new Panel();
            button5 = new Button();
            pictureBox4 = new PictureBox();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtGrafico).BeginInit();
            SuspendLayout();
            // 
            // pnlNavBar
            // 
            pnlNavBar.BackColor = Color.Brown;
            pnlNavBar.Controls.Add(btnVoltar);
            pnlNavBar.Controls.Add(button1);
            pnlNavBar.Controls.Add(lblTituloPrincipal);
            pnlNavBar.Dock = DockStyle.Top;
            pnlNavBar.Location = new Point(0, 0);
            pnlNavBar.Name = "pnlNavBar";
            pnlNavBar.Size = new Size(1527, 74);
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
            btnVoltar.Location = new Point(1430, 7);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(94, 65);
            btnVoltar.TabIndex = 2;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(262, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = Color.WhiteSmoke;
            lblTituloPrincipal.Location = new Point(3, 0);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(234, 71);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Relatórios ADMIN";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlOpcoes
            // 
            pnlOpcoes.BackColor = Color.FromArgb(52, 73, 94);
            pnlOpcoes.Controls.Add(button5);
            pnlOpcoes.Controls.Add(pictureBox4);
            pnlOpcoes.Controls.Add(button4);
            pnlOpcoes.Controls.Add(pictureBox3);
            pnlOpcoes.Controls.Add(button3);
            pnlOpcoes.Controls.Add(pictureBox2);
            pnlOpcoes.Controls.Add(button2);
            pnlOpcoes.Controls.Add(pictureBox1);
            pnlOpcoes.Dock = DockStyle.Left;
            pnlOpcoes.Location = new Point(0, 74);
            pnlOpcoes.Name = "pnlOpcoes";
            pnlOpcoes.Size = new Size(250, 821);
            pnlOpcoes.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(52, 73, 94);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11F);
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(78, 511);
            button5.Name = "button5";
            button5.Size = new Size(159, 62);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.graph;
            pictureBox4.Location = new Point(12, 511);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(52, 73, 94);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(78, 394);
            button4.Name = "button4";
            button4.Size = new Size(159, 62);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.graph;
            pictureBox3.Location = new Point(12, 394);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 62);
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
            button3.Location = new Point(78, 279);
            button3.Name = "button3";
            button3.Size = new Size(159, 62);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.graph;
            pictureBox2.Location = new Point(12, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(78, 161);
            button2.Name = "button2";
            button2.Size = new Size(159, 62);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(12, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblLinkHome);
            pnlTitulo.Controls.Add(lblTituloPagina);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(250, 74);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1277, 60);
            pnlTitulo.TabIndex = 2;
            // 
            // lblLinkHome
            // 
            lblLinkHome.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLinkHome.AutoSize = true;
            lblLinkHome.Font = new Font("Segoe UI", 10F);
            lblLinkHome.Location = new Point(1102, 20);
            lblLinkHome.Name = "lblLinkHome";
            lblLinkHome.Size = new Size(156, 23);
            lblLinkHome.TabIndex = 1;
            lblLinkHome.Text = "Home / Dashboard";
            // 
            // lblTituloPagina
            // 
            lblTituloPagina.AutoSize = true;
            lblTituloPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloPagina.Location = new Point(28, 20);
            lblTituloPagina.Name = "lblTituloPagina";
            lblTituloPagina.Size = new Size(97, 23);
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
            panel1.Location = new Point(278, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 181);
            panel1.TabIndex = 3;
            // 
            // lblTotalDeAvaliacoes
            // 
            lblTotalDeAvaliacoes.AutoSize = true;
            lblTotalDeAvaliacoes.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalDeAvaliacoes.ForeColor = Color.WhiteSmoke;
            lblTotalDeAvaliacoes.Location = new Point(0, 61);
            lblTotalDeAvaliacoes.Name = "lblTotalDeAvaliacoes";
            lblTotalDeAvaliacoes.Size = new Size(97, 57);
            lblTotalDeAvaliacoes.TabIndex = 6;
            lblTotalDeAvaliacoes.Text = "100";
            // 
            // lblAvaliaçõesRespondidas
            // 
            lblAvaliaçõesRespondidas.AutoSize = true;
            lblAvaliaçõesRespondidas.ForeColor = Color.WhiteSmoke;
            lblAvaliaçõesRespondidas.Location = new Point(20, 149);
            lblAvaliaçõesRespondidas.Name = "lblAvaliaçõesRespondidas";
            lblAvaliaçõesRespondidas.Size = new Size(247, 20);
            lblAvaliaçõesRespondidas.TabIndex = 5;
            lblAvaliaçõesRespondidas.Text = "Avaliações Respondidas no período";
            // 
            // lblAvaliações
            // 
            lblAvaliações.AutoSize = true;
            lblAvaliações.ForeColor = Color.WhiteSmoke;
            lblAvaliações.Location = new Point(20, 10);
            lblAvaliações.Name = "lblAvaliações";
            lblAvaliações.Size = new Size(80, 20);
            lblAvaliações.TabIndex = 4;
            lblAvaliações.Text = "Avaliações";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.graph;
            pictureBox5.Location = new Point(241, 56);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 62);
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
            panel2.Location = new Point(643, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 181);
            panel2.TabIndex = 4;
            // 
            // lblTotalAtendentesAvaliados
            // 
            lblTotalAtendentesAvaliados.AutoSize = true;
            lblTotalAtendentesAvaliados.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalAtendentesAvaliados.ForeColor = Color.WhiteSmoke;
            lblTotalAtendentesAvaliados.Location = new Point(3, 61);
            lblTotalAtendentesAvaliados.Name = "lblTotalAtendentesAvaliados";
            lblTotalAtendentesAvaliados.Size = new Size(73, 57);
            lblTotalAtendentesAvaliados.TabIndex = 9;
            lblTotalAtendentesAvaliados.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(18, 149);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 8;
            label3.Text = "Atendentes Avaliados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(18, 10);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 7;
            label4.Text = "Atendentes";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.about_us;
            pictureBox7.Location = new Point(412, 61);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(60, 62);
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
            panel3.Location = new Point(1175, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 181);
            panel3.TabIndex = 5;
            // 
            // lblTotalSetoresCadastrados
            // 
            lblTotalSetoresCadastrados.AutoSize = true;
            lblTotalSetoresCadastrados.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTotalSetoresCadastrados.ForeColor = Color.WhiteSmoke;
            lblTotalSetoresCadastrados.Location = new Point(14, 68);
            lblTotalSetoresCadastrados.Name = "lblTotalSetoresCadastrados";
            lblTotalSetoresCadastrados.Size = new Size(49, 57);
            lblTotalSetoresCadastrados.TabIndex = 12;
            lblTotalSetoresCadastrados.Text = "4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(14, 149);
            label6.Name = "label6";
            label6.Size = new Size(144, 20);
            label6.TabIndex = 11;
            label6.Text = "Setores Cadastrados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(14, 10);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 10;
            label7.Text = "Setores";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.user;
            pictureBox6.Location = new Point(244, 56);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(60, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(1195, 415);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 6;
            label8.Text = "Período";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(1198, 438);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(299, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new Point(1198, 468);
            label9.Name = "label9";
            label9.Size = new Size(30, 20);
            label9.TabIndex = 8;
            label9.Text = "até";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.None;
            dateTimePicker2.Location = new Point(1198, 491);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(299, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(chtGrafico);
            panel4.Location = new Point(278, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(724, 433);
            panel4.TabIndex = 10;
            // 
            // chtGrafico
            // 
            chtGrafico.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtGrafico.Legends.Add(legend1);
            chtGrafico.Location = new Point(3, 4);
            chtGrafico.Name = "chtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtGrafico.Series.Add(series1);
            chtGrafico.Size = new Size(720, 453);
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
            btnAvancarAtendentes.Location = new Point(1195, 604);
            btnAvancarAtendentes.Margin = new Padding(3, 4, 3, 4);
            btnAvancarAtendentes.Name = "btnAvancarAtendentes";
            btnAvancarAtendentes.Size = new Size(299, 60);
            btnAvancarAtendentes.TabIndex = 15;
            btnAvancarAtendentes.UseVisualStyleBackColor = false;
            // 
            // lblSetor
            // 
            lblSetor.Anchor = AnchorStyles.None;
            lblSetor.AutoSize = true;
            lblSetor.Location = new Point(1198, 526);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(44, 20);
            lblSetor.TabIndex = 17;
            lblSetor.Text = "Setor";
            // 
            // cmbSetores
            // 
            cmbSetores.Anchor = AnchorStyles.None;
            cmbSetores.FormattingEnabled = true;
            cmbSetores.Location = new Point(1198, 549);
            cmbSetores.Name = "cmbSetores";
            cmbSetores.Size = new Size(296, 28);
            cmbSetores.TabIndex = 18;
            // 
            // btnExportaPdf
            // 
            btnExportaPdf.Anchor = AnchorStyles.None;
            btnExportaPdf.BackColor = SystemColors.Control;
            btnExportaPdf.BackgroundImage = Properties.Resources.btnExportaPdf;
            btnExportaPdf.BackgroundImageLayout = ImageLayout.Stretch;
            btnExportaPdf.FlatStyle = FlatStyle.Flat;
            btnExportaPdf.Location = new Point(1195, 697);
            btnExportaPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportaPdf.Name = "btnExportaPdf";
            btnExportaPdf.Size = new Size(299, 60);
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
            btnExportaExcel.Location = new Point(1195, 779);
            btnExportaExcel.Margin = new Padding(3, 4, 3, 4);
            btnExportaExcel.Name = "btnExportaExcel";
            btnExportaExcel.Size = new Size(299, 60);
            btnExportaExcel.TabIndex = 20;
            btnExportaExcel.UseVisualStyleBackColor = false;
            btnExportaExcel.Click += btnExportarExcel_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 895);
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
            Name = "FrmDashboard";
            Text = "FrmRelatorios";
            WindowState = FormWindowState.Maximized;
            pnlNavBar.ResumeLayout(false);
            pnlOpcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtGrafico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlNavBar;
        private Panel pnlOpcoes;
        private Button button1;
        private Label lblTituloPrincipal;
        private Panel pnlTitulo;
        private Label lblLinkHome;
        private Label lblTituloPagina;
        private Button button5;
        private PictureBox pictureBox4;
        private Button button4;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button2;
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