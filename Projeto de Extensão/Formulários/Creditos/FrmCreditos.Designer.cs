namespace Projeto_de_Extensao.Formulários.Creditos
{
    partial class FrmCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreditos));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblDisciplina = new Label();
            btnHomeCreditos = new Button();
            lblTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.40741F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5925922F));
            tableLayoutPanel1.Size = new Size(1313, 675);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnHomeCreditos);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 530);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblDisciplina);
            panel2.Location = new Point(254, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 341);
            panel2.TabIndex = 39;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 190);
            label3.Name = "label3";
            label3.Size = new Size(656, 75);
            label3.TabIndex = 3;
            label3.Text = "Fonte do material do desingn : https://www.figma.com\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 115);
            label2.Name = "label2";
            label2.Size = new Size(656, 75);
            label2.TabIndex = 2;
            label2.Text = "Integrantes: Eduardo Marques Corrêa, Fabrício Júnio Almeida Dias, Kauã Limão Nunes e Luan Padilha Miranda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 73);
            label1.Name = "label1";
            label1.Size = new Size(406, 30);
            label1.TabIndex = 1;
            label1.Text = "Professor: Prof. Dr. Elvio Gilberto da Silva";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisciplina.Location = new Point(165, 21);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(414, 30);
            lblDisciplina.TabIndex = 0;
            lblDisciplina.Text = "Disciplina: Progamação de Computadores";
            // 
            // btnHomeCreditos
            // 
            btnHomeCreditos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHomeCreditos.BackColor = Color.Gainsboro;
            btnHomeCreditos.BackgroundImage = (Image)resources.GetObject("btnHomeCreditos.BackgroundImage");
            btnHomeCreditos.BackgroundImageLayout = ImageLayout.Stretch;
            btnHomeCreditos.FlatAppearance.BorderSize = 0;
            btnHomeCreditos.Location = new Point(1228, 13);
            btnHomeCreditos.Name = "btnHomeCreditos";
            btnHomeCreditos.Size = new Size(70, 68);
            btnHomeCreditos.TabIndex = 38;
            btnHomeCreditos.UseVisualStyleBackColor = false;
            btnHomeCreditos.Click += btnHomeCreditos_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(516, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Créditos";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 539);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1307, 133);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(647, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(656, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(648, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FrmCreditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 675);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCreditos";
            Text = "FrmCreditos";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTitle;
        private Button btnHomeCreditos;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label1;
        private Label lblDisciplina;
        private Label label3;
        private Label label2;
    }
}