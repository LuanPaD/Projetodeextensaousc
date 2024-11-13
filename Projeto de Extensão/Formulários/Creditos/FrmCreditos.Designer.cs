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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnHomeCreditos = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNomes1 = new Label();
            lblTitle = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.48148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5185184F));
            tableLayoutPanel1.Size = new Size(1313, 675);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 526);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1307, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHomeCreditos);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblNomes1);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 517);
            panel1.TabIndex = 1;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(516, 222);
            label4.Name = "label4";
            label4.Size = new Size(212, 40);
            label4.TabIndex = 5;
            label4.Text = "Felipe Dallaqua";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(521, 177);
            label3.Name = "label3";
            label3.Size = new Size(190, 40);
            label3.TabIndex = 4;
            label3.Text = "Fabrício Júnio";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(539, 267);
            label2.Name = "label2";
            label2.Size = new Size(166, 40);
            label2.TabIndex = 3;
            label2.Text = "Kauã Limão";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(533, 312);
            label1.Name = "label1";
            label1.Size = new Size(178, 40);
            label1.TabIndex = 2;
            label1.Text = "Luan Padilha";
            // 
            // lblNomes1
            // 
            lblNomes1.Anchor = AnchorStyles.None;
            lblNomes1.AutoSize = true;
            lblNomes1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomes1.Location = new Point(514, 132);
            lblNomes1.Name = "lblNomes1";
            lblNomes1.Size = new Size(217, 40);
            lblNomes1.TabIndex = 1;
            lblNomes1.Text = "Eduardo Corrêa";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(516, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(216, 65);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Créditos";
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblNomes1;
        private Label label4;
        private Button btnHomeCreditos;
    }
}