namespace Projeto_de_Extensao.Formulários.Perguntas
{
    partial class FrmEscolhaSetorAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEscolhaSetorAvaliacao));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            pnlListaSetores = new Panel();
            lstItems = new ListBox();
            lblDireitos = new Label();
            btnAvancarAtendentes = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            pnlListaSetores.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1225, 652);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 81.08911F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.91089F));
            tableLayoutPanel2.Size = new Size(606, 648);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 528);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(0, 0, 0, 8);
            pictureBox2.Size = new Size(600, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(pnlListaSetores, 0, 1);
            tableLayoutPanel3.Controls.Add(lblDireitos, 0, 3);
            tableLayoutPanel3.Controls.Add(btnAvancarAtendentes, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(615, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.63837F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 83.36163F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.Size = new Size(607, 646);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(565, 50);
            label1.TabIndex = 12;
            label1.Text = "QUAL SETOR DESEJA AVALIAR?";
            // 
            // pnlListaSetores
            // 
            pnlListaSetores.AutoScroll = true;
            pnlListaSetores.Controls.Add(lstItems);
            pnlListaSetores.Dock = DockStyle.Fill;
            pnlListaSetores.Location = new Point(3, 87);
            pnlListaSetores.Name = "pnlListaSetores";
            pnlListaSetores.Size = new Size(601, 419);
            pnlListaSetores.TabIndex = 13;
            // 
            // lstItems
            // 
            lstItems.Anchor = AnchorStyles.None;
            lstItems.FormattingEnabled = true;
            lstItems.ItemHeight = 15;
            lstItems.Location = new Point(18, 42);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(577, 349);
            lstItems.TabIndex = 0;
            // 
            // lblDireitos
            // 
            lblDireitos.Anchor = AnchorStyles.None;
            lblDireitos.AutoSize = true;
            lblDireitos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireitos.ForeColor = SystemColors.AppWorkspace;
            lblDireitos.Location = new Point(203, 619);
            lblDireitos.Name = "lblDireitos";
            lblDireitos.Size = new Size(200, 17);
            lblDireitos.TabIndex = 11;
            lblDireitos.Text = "Reserved directs to Unisagrado";
            // 
            // btnAvancarAtendentes
            // 
            btnAvancarAtendentes.Anchor = AnchorStyles.None;
            btnAvancarAtendentes.BackColor = Color.Brown;
            btnAvancarAtendentes.BackgroundImage = (Image)resources.GetObject("btnAvancarAtendentes.BackgroundImage");
            btnAvancarAtendentes.BackgroundImageLayout = ImageLayout.Stretch;
            btnAvancarAtendentes.Location = new Point(134, 528);
            btnAvancarAtendentes.Name = "btnAvancarAtendentes";
            btnAvancarAtendentes.Size = new Size(338, 62);
            btnAvancarAtendentes.TabIndex = 14;
            btnAvancarAtendentes.UseVisualStyleBackColor = false;
            btnAvancarAtendentes.Click += btnAvancarAtendentes_Click;
            // 
            // FrmEscolhaSetorAvaliacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 652);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEscolhaSetorAvaliacao";
            Text = "FrmEscolhaSetorAvaliacao";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            pnlListaSetores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblDireitos;
        private Label label1;
        private Panel pnlListaSetores;
        private ListBox lstItems;
        private Button btnAvancarAtendentes;
    }
}