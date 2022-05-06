using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace hardware_store
{
    class Excel
    {
      
        _Application excel = new _Excel.Application();
        Workbook workbook;
        Worksheet worksheet;
        public Excel()
        {
            
            //workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            //string path = @"C:\Users\User\" + "WorkReport " + $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}" + ".xlsx";
            //workbook.SaveAs(path);
            //workbook.Close();
            //workbook = excel.Workbooks.Open(path);
            //worksheet = workbook.Worksheets[1];

        }
        public Excel(string path)
        {
            workbook = excel.Workbooks.Open(path);
            worksheet = workbook.Worksheets[1];
        }
        public void CreateFile()
        {
            workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public void WriteToCell(int i,int j,string str)
        {
            i++;j++;
            worksheet.Cells[j, i].Value2 = str;
        }
        public void SaveFiles()
        {

            workbook.Save();
           
            
           
            Marshal.ReleaseComObject(worksheet);
            workbook.Close();
            Marshal.ReleaseComObject(excel);

        }
        public void Close()
        {
            workbook.Close();
           
        }
    }
}
