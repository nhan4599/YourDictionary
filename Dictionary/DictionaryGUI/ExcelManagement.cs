using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using DictionaryGUI.Data;
using System.IO;

namespace DictionaryGUI
{
    class ExcelManagement
    {
        private readonly string path;
        Excel._Application xlsApp;
        Excel.Workbook xlsFile;
        Excel.Worksheet sheet;

        public ExcelManagement(string path)
        {
            this.path = path;
            xlsApp = new Excel.Application();
            if (!File.Exists(path))
            {
                this.CreateNewFile(path);
            }else
            {
                xlsFile = xlsApp.Workbooks.Open(path);
            }
            sheet = xlsFile.Sheets[1];
        }

        public void WriteFile(List<Word> t)
        {
            for (int i = 1; i <= t.Count; i++)
            {
                Word temp = t[i - 1];
                sheet.Cells[i, 1].Value2 = temp.word_o;
                sheet.Cells[i, 2].Value2 = temp.type_id;
                sheet.Cells[i, 3].Value2 = temp.word_m;
            }
        }

        public void Save()
        {
            xlsFile.Save();
        }

        public void SaveAs(string path)
        {
            xlsFile.SaveAs(path);
        }

        public void CreateNewFile(string path)
        {
            xlsFile = xlsApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            sheet = xlsFile.ActiveSheet;
            this.SaveAs(path);
        }

        public void Close()
        {
            xlsFile.Close();
        }

        public void ClearData()
        {
            sheet.Cells.ClearContents();
        }
    }
}
