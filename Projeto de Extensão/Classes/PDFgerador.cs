using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;
using System.Data;
using System.IO;
using System.Reflection.Metadata;

using Document = iText.Layout.Document;
using Image = iText.Layout.Element.Image;
using HorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;

namespace Projeto_de_Extensao.Classes
{
    internal class PDFgerador
    {
        public void Export(DataTable data, string filePath, string logoPath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (PdfWriter writer = new PdfWriter(fs))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Adicionando logo
                        if (!string.IsNullOrEmpty(logoPath))
                        {
                            ImageData imageData = ImageDataFactory.Create(logoPath);
                            Image image = new Image(imageData);
                            image.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                            document.Add(image);
                        }

                        // Título
                        document.Add(new Paragraph("Dados Exportados").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20));

                        // Criando a tabela
                        Table table = new Table(data.Columns.Count);
                        foreach (DataColumn column in data.Columns)
                        {
                            table.AddHeaderCell(column.ColumnName);
                        }

                        foreach (DataRow row in data.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                table.AddCell(cell.ToString());
                            }
                        }

                        document.Add(table);
                        document.Close();
                    }
                }
            }
        }
    }
}
