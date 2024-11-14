using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OfficeOpenXml;
using System.IO;

namespace Projeto_de_Extensao.Classes
{
    internal class EXCELgerador
    {
        public void Export(DataTable data, string filePath)
        {
            // Definindo o contexto da licença para uso gratuito
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


            using (ExcelPackage excel = new ExcelPackage())
            {
                var workSheet = excel.Workbook.Worksheets.Add("Dados");
                workSheet.Cells["A1"].LoadFromDataTable(data, true);

                FileInfo fi = new FileInfo(filePath);
                excel.SaveAs(fi);
            }
        }
    }
}
