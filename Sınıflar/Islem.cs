using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ParcaMuhasebe.Sınıflar
{
    internal class Islem
    {

        public void Ara(DataGridView dataGridView, string aranan)
        {
            bool found = false;


            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Selected = false; // Mevcut tüm seçili satırların seçimini kaldır
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                foreach (DataGridViewCell cell in dataGridView.Rows[i].Cells) // Her satırdaki tüm hücreleri kontrol ediyorux
                {
                    if (cell.Value != null)
                    {

                        if (cell.Value.ToString().ToUpper().Contains(aranan))// Hücre değeri aranacak değerle eşleşirse
                        {
                            // Satırı seç
                            dataGridView.Rows[i].Selected = true;

                            found = true;
                            //break; // İç döngüden çık
                        }
                    }
                }
                if (found)
                {
                    break; // Dış döngüden çık
                }
            }
        }
        public void Aktar(DataGridView dGrid)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
            Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            excelApp.Visible = true;


            try
            {
                int rowCount = dGrid.Rows.Count;
                int columnCount = dGrid.Columns.Count;

                // DataGridView verilerini Excel'e aktarma
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= columnCount; j++)
                    {
                        // Excel hücrelerine veri yazma
                        excelWorksheet.Cells[i, j] = dGrid.Rows[i - 1].Cells[j - 1].Value;
                    }
                }

                // Excel dosyasını kaydetme
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                excelWorkbook.SaveAs(desktopPath + "\\ExcelParcalar.xlsx");
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi verme veya hata işleme
                MessageBox.Show("Excel'e aktarım sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Kullanılan kaynakları serbest bırakma
                Marshal.ReleaseComObject(excelWorksheet);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
