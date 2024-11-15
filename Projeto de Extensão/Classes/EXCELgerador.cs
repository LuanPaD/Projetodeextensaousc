using System;
using System.Data;
using System.IO;
using ClosedXML.Excel;

namespace Projeto_de_Extensao.Classes
{
    internal class EXCELgerador
    {
        public void Export(DataTable data, string filePath, string sheetName = "Dados")
        {
            // Validar entradas
            if (data == null || data.Rows.Count == 0)
                throw new ArgumentException("O DataTable está vazio ou nulo.", nameof(data));

            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("O caminho do arquivo é inválido.", nameof(filePath));

            try
            {
                // Criando um novo arquivo Excel
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(sheetName);

                    // Carregando os dados do DataTable
                    worksheet.Cell(1, 1).InsertTable(data);

                    // Ajustando automaticamente a largura das colunas
                    worksheet.Columns().AdjustToContents();

                    // Salvando o arquivo no caminho especificado
                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                // Lidar com erros (pode ser substituído por um logger)
                throw new IOException($"Erro ao salvar o arquivo Excel: {ex.Message}", ex);
            }
        }
    }
}
