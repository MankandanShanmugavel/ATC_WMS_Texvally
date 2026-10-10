using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using UIPShared;
namespace ATC_WMS
{
    class ExportExcelFile
    {
        public static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static void ExportExclFile(System.Data.DataTable dt)
        {



            if (dt.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Export Excel";
            s.Filter = "Excel files|*.xls;*.xlsx";

            DialogResult dr = s.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string Filepath = s.FileName;

                ApplicationClass excelApp = new ApplicationClass();
                Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

                int sheetIndex = 0;
                object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    rawData[0, col] = dt.Columns[col].ColumnName;
                }
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                    }
                }
                string finalColLetter = string.Empty;
                string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int colCharsetLen = colCharset.Length;

                if (dt.Columns.Count > colCharsetLen)
                {
                    finalColLetter = colCharset.Substring((dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                }

                finalColLetter += colCharset.Substring((dt.Columns.Count - 1) % colCharsetLen, 1);
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(excelWorkbook.Sheets.get_Item(++sheetIndex), Type.Missing, 1, XlSheetType.xlWorksheet);
                excelSheet.Name = DateTime.Now.ToString("ddMMyyyy");
                string excelRange = string.Format("A1:{0}{1}", finalColLetter, dt.Rows.Count + 1);
                excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;
                Excel.Range pRange = excelSheet.get_Range("A1", Alpacell(dt.Columns.Count) + "1");
                pRange.Font.Name = "Arial";
                pRange.Font.Size = 10;
                pRange.Interior.Color = Color.Yellow.ToArgb();
                pRange.Font.Bold = true;
                pRange.RowHeight = 25;
                //((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;
                //((Range)excelSheet.Rows[1, Type.Missing]).Interior.Color = Color.Yellow.ToArgb();
                //((Range)excelSheet.Rows[1, Type.Missing]).Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                //((Range)excelSheet.Rows[1, Type.Missing]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                //pRange.Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                //pRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                excelWorkbook.SaveAs(Filepath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                excelWorkbook.Close(true, Type.Missing, Type.Missing);
                excelWorkbook = null;
                excelApp.Quit();
                excelApp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                //Excel.Application xlApp;
                //Excel.Workbook xlWorkBook;
                //Excel.Worksheet xlWorkSheet;
                //object misValue = System.Reflection.Missing.Value;
                //xlApp = new Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Add(misValue);
                //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //int j = 1;
                //for (int k = 0; k < dt.Columns.Count; k++)
                //{
                //    xlWorkSheet.Cells[j, k + 1] = dt.Columns[k].ColumnName;
                //}

                //Excel.Range pRange = xlWorkSheet.get_Range("A" + j.ToString(), Alpacell(dt.Columns.Count) + j.ToString());
                //pRange.Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                //pRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //pRange.Font.Name = "Arial";
                //pRange.Font.Size = 10;
                //pRange.Interior.Color = Color.Yellow.ToArgb();
                //pRange.Font.Bold = true;
                //pRange.RowHeight = 25;
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    j = j + 1;
                //    for (int k = 0; k < dt.Columns.Count; k++)
                //    {
                //        xlWorkSheet.Cells[j, k + 1] = dt.Rows[i][k].ToString();
                //    }
                //    pRange = xlWorkSheet.get_Range("A" + j.ToString(), Alpacell(dt.Columns.Count) + j.ToString());
                //    pRange.Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                //    pRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                //    pRange.Font.Name = "Arial";
                //    pRange.Font.Size = 10;

                //}
                //xlWorkSheet.Columns.AutoFit();
                //xlWorkBook.SaveAs(Filepath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();
                //releaseObject(xlApp);
                //releaseObject(xlWorkBook);
                //releaseObject(xlWorkSheet);
                UIPShared.Shared.DisplayInformation("Export Sucessfully");
            }
            else
            {
                return;

            }
        }


        public static void GridExportToExcel(DataGridView datg)
        {

            if (datg.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Export Excel";
            s.Filter = "Excel files|*.xls;*.xlsx";

            DialogResult dr = s.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string outputPath = s.FileName;
                // Create the Excel Application object
                ApplicationClass excelApp = new ApplicationClass();

                // Create a new Excel Workbook
                Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

                int sheetIndex = 0;

                // Copy each DataTable            

                // Copy the DataTable to an object array
                object[,] rawData = new object[datg.Rows.Count + 1, datg.Columns.Count];

                // Copy the column names to the first row of the object array
                for (int col = 0; col < datg.Columns.Count; col++)
                {
                    rawData[0, col] = datg.Columns[col].Name;
                }

                // Copy the values to the object array
                for (int col = 0; col < datg.Columns.Count; col++)
                {

                    for (int row = 0; row < datg.Rows.Count; row++)
                    {
                        if (datg.Rows[row].Cells[col].Value == null)
                            rawData[row + 1, col] = "";
                        else
                            rawData[row + 1, col] = datg.Rows[row].Cells[col].Value.ToString();
                    }
                }

                // Calculate the final column letter
                string finalColLetter = string.Empty;
                string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int colCharsetLen = colCharset.Length;

                if (datg.Columns.Count > colCharsetLen)
                {
                    finalColLetter = colCharset.Substring(
                        (datg.Columns.Count - 1) / colCharsetLen - 1, 1);
                }

                finalColLetter += colCharset.Substring(
                        (datg.Columns.Count - 1) % colCharsetLen, 1);

                // Create a new Sheet
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(
                    excelWorkbook.Sheets.get_Item(++sheetIndex),
                    Type.Missing, 1, XlSheetType.xlWorksheet);

                excelSheet.Name = DateTime.Now.ToString("ddMMyyyy");

                // Fast data export to Excel
                string excelRange = string.Format("A1:{0}{1}",
                    finalColLetter, datg.Rows.Count + 1);

                excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;

                // Mark the first row as BOLD
                ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;


                // Save and Close the Workbook
                excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                excelWorkbook.Close(true, Type.Missing, Type.Missing);
                excelWorkbook = null;

                // Release the Application object
                excelApp.Quit();
                excelApp = null;

                // Collect the unreferenced objects
                GC.Collect();
                GC.WaitForPendingFinalizers();

                UIPShared.Shared.DisplayInformation("Export Sucessfully");
            }
        }

        public static string Alpacell(int count)
        {
            string s = "";
            string[] alpa = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            int C = count / 26;
            int MOD = count % 26;
            if (C != 0)
            {
                if (MOD == 0 && C == 1)
                {

                }
                else
                    s = alpa[C - 1];
            }
            if (MOD == 0)
                s = s + alpa[26 - 1];
            else
                s = s + alpa[MOD - 1];




            return s;
        }
        public static void ExportToExceldt(System.Data.DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Export Excel";
            s.Filter = "Excel files|*.xls;*.xlsx";

            DialogResult dr = s.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string outputPath = s.FileName;
                Microsoft.Office.Interop.Excel.ApplicationClass excelApp = new ApplicationClass();
                Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);

                int sheetIndex = 0;
                object[,] rawData = new object[dt.Rows.Count + 1, dt.Columns.Count];

                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    rawData[0, col] = dt.Columns[col].ColumnName;
                }
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        rawData[row + 1, col] = dt.Rows[row].ItemArray[col];
                    }
                }
                string finalColLetter = string.Empty;
                string colCharset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int colCharsetLen = colCharset.Length;

                if (dt.Columns.Count > colCharsetLen)
                {
                    finalColLetter = colCharset.Substring((dt.Columns.Count - 1) / colCharsetLen - 1, 1);
                }

                finalColLetter += colCharset.Substring((dt.Columns.Count - 1) % colCharsetLen, 1);
                Worksheet excelSheet = (Worksheet)excelWorkbook.Sheets.Add(excelWorkbook.Sheets.get_Item(++sheetIndex), Type.Missing, 1, XlSheetType.xlWorksheet);
                excelSheet.Name = DateTime.Now.ToString("ddMMyyyy");
                string excelRange = string.Format("A1:{0}{1}", finalColLetter, dt.Rows.Count + 1);
                excelSheet.get_Range(excelRange, Type.Missing).Value2 = rawData;
                ((Range)excelSheet.Rows[1, Type.Missing]).Font.Bold = true;

                excelWorkbook.SaveAs(outputPath, XlFileFormat.xlWorkbookNormal, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                excelWorkbook.Close(true, Type.Missing, Type.Missing);
                excelWorkbook = null;
                excelApp.Quit();
                excelApp = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
                UIPShared.Shared.DisplayInformation("Export Sucessfully");
            }
        }


        public static void ExportTemplate(string columnname)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Export Excel";
            s.Filter = "Excel files|*.xls;*.xlsx";

            DialogResult dr = s.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string outputPath = s.FileName;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int j = 1;

                string[] Spl = null;
                Spl = columnname.Split(',');
                int i = 1;
                foreach (var item in Spl)
                {

                    xlWorkSheet.Cells[j, i] = item;
                    i = i + 1;
                }



                Excel.Range pRange = xlWorkSheet.get_Range("A1", Alpacell(i - 1) + "1");
                pRange.Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                pRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                pRange.Font.Name = "Arial";
                pRange.Font.Size = 10;
                pRange.Interior.Color = Color.Yellow.ToArgb();
                pRange.Font.Bold = true;
                pRange.RowHeight = 25;
                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(outputPath, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);



                Shared.DisplayInformation("Export Sucessfully");
            }
        }


        public static void ExportCsvTemplate(string columnname)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Export Excel";
            s.Filter = "Excel files|*.xls;*.xlsx";

            DialogResult dr = s.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string outputPath = s.FileName;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int j = 1;

                string[] Spl = null;
                Spl = columnname.Split(',');
                int i = 1;
                foreach (var item in Spl)
                {

                    xlWorkSheet.Cells[j, i] = item;
                    i = i + 1;
                }



                Excel.Range pRange = xlWorkSheet.get_Range("A1", Alpacell(i - 1) + "1");
                pRange.Borders.Color = Color.Black.ToArgb(); //0x0000FF;
                pRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                pRange.Font.Name = "Arial";
                pRange.Font.Size = 10;
                pRange.Interior.Color = Color.Yellow.ToArgb();
                pRange.Font.Bold = true;
                pRange.RowHeight = 25;
                xlWorkSheet.Columns.AutoFit();
                xlWorkBook.SaveAs(outputPath, Excel.XlFileFormat.xlCSV, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                releaseObject(xlApp);
                releaseObject(xlWorkBook);
                releaseObject(xlWorkSheet);



                Shared.DisplayInformation("Export Sucessfully");
            }
        }
    }
}

