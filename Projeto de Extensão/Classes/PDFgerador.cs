using System;
using System.Data;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using Projeto_de_Extensao.Properties;
using System.Drawing;

namespace Projeto_de_Extensao.Classes
{
    internal class PDFgerador
    {
        public void Export(DataTable data, string filePath)
        {
            // Criando um documento PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Dados Exportados";

            // Adicionando uma página ao documento
            PdfPage page = document.AddPage();

            // Criando um objeto de desenho (Graphics)
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Definindo uma fonte para o texto
            XFont font = new XFont("Verdana", 12);

            // Adicionando o título
            gfx.DrawString("Dados Exportados", new XFont("Verdana", 20), XBrushes.Black, new XPoint(page.Width / 2, 50), XStringFormats.Center);

            // Desenhando o logo
            DrawLogo(gfx, page);

            // Desenhando a tabela
            DrawTable(gfx, data, page);

            // Salvando o documento
            document.Save(filePath);
        }

        private void DrawLogo(XGraphics gfx, PdfPage page)
        {
            // Carregar a imagem do logo
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap logoBitmap = Properties.Resources.LOGO_UNISAGRADO;
                logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                XImage logo = XImage.FromStream(ms);

                // Desenhando a imagem (logo)
                double logoWidth = 200;
                double logoHeight = (logo.PixelHeight / (double)logo.PixelWidth) * logoWidth;
                gfx.DrawImage(logo, (page.Width - logoWidth) / 2, 80, logoWidth, logoHeight);
            }
        }

        private void DrawTable(XGraphics gfx, DataTable data, PdfPage page)
        {
            // Definindo posições de início e tamanho da tabela
            double x = 50;
            double y = 200;
            double tableWidth = page.Width - 100;
            double rowHeight = 20;

            // Desenhando o cabeçalho da tabela
//            PdfSharp.Drawing.XFont xfont = new PdfSharp.Drawing.XFont(GetFont(), new PdfSharp.Drawing.XPdfFontOptions(PdfSharp.Pdf.PdfFontEncoding.Unicode, PdfSharp.Pdf.PdfFontEmbedding.Always));

            XFont headerFont = new XFont("Verdana", 12.5);

            for (int col = 0; col < data.Columns.Count; col++)
            {
                gfx.DrawRectangle(XBrushes.LightGray, x + (col * (tableWidth / data.Columns.Count)), y, tableWidth / data.Columns.Count, rowHeight);
                gfx.DrawString(data.Columns[col].ColumnName, headerFont, XBrushes.Black, new XPoint(x + (col * (tableWidth / data.Columns.Count)) + 5, y + 15));
            }

            // Desenhando as linhas da tabela
            XFont cellFont = new XFont("Verdana", 10);
            y += rowHeight; // Avançar para a linha seguinte
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int col = 0; col < data.Columns.Count; col++)
                {
                    gfx.DrawRectangle(XBrushes.White, x + (col * (tableWidth / data.Columns.Count)), y, tableWidth / data.Columns.Count, rowHeight);
                    gfx.DrawString(data.Rows[i][col].ToString(), cellFont, XBrushes.Black, new XPoint(x + (col * (tableWidth / data.Columns.Count)) + 5, y + 15));
                }
                y += rowHeight; // Avançar para a próxima linha
            }
        }
    }
}
