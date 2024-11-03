namespace Projeto_de_Extensao.Formulários.Relatórios
{
    partial class FrmGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chtGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnCarregar = new Button();
            chtGrafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtGrafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chtGrafico3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            btnExportarPdf = new Button();
            btnExportarExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)chtGrafico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico3).BeginInit();
            SuspendLayout();
            // 
            // chtGrafico
            // 
            chtGrafico.Anchor = AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            chtGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtGrafico.Legends.Add(legend1);
            chtGrafico.Location = new Point(12, 80);
            chtGrafico.Name = "chtGrafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chtGrafico.Series.Add(series1);
            chtGrafico.Size = new Size(501, 268);
            chtGrafico.TabIndex = 0;
            chtGrafico.Text = "Gráfico";
            // 
            // btnCarregar
            // 
            btnCarregar.Anchor = AnchorStyles.Bottom;
            btnCarregar.Location = new Point(514, 596);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(94, 29);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // chtGrafico1
            // 
            chtGrafico1.Anchor = AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            chtGrafico1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chtGrafico1.Legends.Add(legend2);
            chtGrafico1.Location = new Point(574, 80);
            chtGrafico1.Name = "chtGrafico1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chtGrafico1.Series.Add(series2);
            chtGrafico1.Size = new Size(501, 268);
            chtGrafico1.TabIndex = 2;
            chtGrafico1.Text = "Gráfico";
            // 
            // chtGrafico2
            // 
            chtGrafico2.Anchor = AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            chtGrafico2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chtGrafico2.Legends.Add(legend3);
            chtGrafico2.Location = new Point(12, 363);
            chtGrafico2.Name = "chtGrafico2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chtGrafico2.Series.Add(series3);
            chtGrafico2.Size = new Size(501, 227);
            chtGrafico2.TabIndex = 3;
            chtGrafico2.Text = "Gráfico";
            // 
            // chtGrafico3
            // 
            chtGrafico3.Anchor = AnchorStyles.None;
            chartArea4.Name = "ChartArea1";
            chtGrafico3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chtGrafico3.Legends.Add(legend4);
            chtGrafico3.Location = new Point(574, 363);
            chtGrafico3.Name = "chtGrafico3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chtGrafico3.Series.Add(series4);
            chtGrafico3.Size = new Size(501, 227);
            chtGrafico3.TabIndex = 4;
            chtGrafico3.Text = "Gráfico";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 20);
            label1.Name = "label1";
            label1.Size = new Size(364, 31);
            label1.TabIndex = 5;
            label1.Text = "Gráficos - Usuarios e Atendentes";
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Anchor = AnchorStyles.None;
            btnExportarPdf.Location = new Point(28, 25);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(94, 29);
            btnExportarPdf.TabIndex = 6;
            btnExportarPdf.Text = "pdf";
            btnExportarPdf.UseVisualStyleBackColor = true;
            btnExportarPdf.Click += btnExportarPdf_Click;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.Anchor = AnchorStyles.None;
            btnExportarExcel.Location = new Point(154, 25);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(94, 29);
            btnExportarExcel.TabIndex = 7;
            btnExportarExcel.Text = "excel";
            btnExportarExcel.UseVisualStyleBackColor = true;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // FrmGraficos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 630);
            Controls.Add(btnExportarExcel);
            Controls.Add(btnExportarPdf);
            Controls.Add(label1);
            Controls.Add(chtGrafico3);
            Controls.Add(chtGrafico2);
            Controls.Add(chtGrafico1);
            Controls.Add(btnCarregar);
            Controls.Add(chtGrafico);
            Name = "FrmGraficos";
            Text = "FrmGraficoscs";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)chtGrafico).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chtGrafico3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico;
        private Button btnCarregar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGrafico3;
        private Label label1;
        private Button btnExportarPdf;
        private Button btnExportarExcel;
    }
}