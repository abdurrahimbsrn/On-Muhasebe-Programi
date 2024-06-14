using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcaMuhasebe.Sınıflar;

namespace ParcaMuhasebe.User_Controls
{
    public partial class AracEkle : UserControl
    {
        SqlServer sqlServer = new SqlServer();
        DataTable dataTable = new DataTable();
        Islem islem = new Islem();
        ParcaEkle parcaEkle = new ParcaEkle();

        Arac arac = new Arac();
        public AracEkle()
        {
            InitializeComponent();
        }
        private void AracEkle_Load(object sender, EventArgs e)
        {
            numericUretimYili.Maximum = DateTime.Now.Year;
            numericUretimYili.Value = DateTime.Now.Year;

            Listele();
        }
        private void Listele()
        {
            dGridAraclar.Rows.Clear();

            string sorgu = "SELECT * FROM araclar ORDER BY AracID ASC;";
            dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridAraclar.Rows.Add(); // Her döngüde yeni bir satır ekle

                dGridAraclar.Rows[i].Cells[0].Value = row["AracID"].ToString();
                dGridAraclar.Rows[i].Cells[1].Value = row["Marka"].ToString();
                dGridAraclar.Rows[i].Cells[2].Value = row["Model"].ToString();
                dGridAraclar.Rows[i].Cells[3].Value = row["UretimYili"].ToString();
                dGridAraclar.Rows[i].Cells[4].Value = row["Kasa"].ToString();
                dGridAraclar.Rows[i].Cells[5].Value = row["Motor"].ToString();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtAracMarka.Text == "" || txtModel.Text == "" || txtKasa.Text == "" || txtMotor.Text == "")
                MessageBox.Show("Lütfen tüm alanları doldurun!".Trim());
            else
            {
                // TextBox'lardan gelen verileri aliyoruz

                arac.AracMarka = txtAracMarka.Text;
                arac.AracModel = txtModel.Text;
                arac.AracKasa = txtKasa.Text;
                arac.AracMotor = txtMotor.Text;
                arac.AracUretimYili = Convert.ToInt32(numericUretimYili.Value);

                string query;


                if (txtAracID.Text == "") // AracID boş olduğunda yeni kayıt yapılır
                {

                    query = "INSERT INTO Araclar (Marka,Model,UretimYili,Kasa,Motor) " +
                                   $"VALUES ('{arac.AracMarka}', '{arac.AracModel}',{arac.AracUretimYili},'{arac.AracKasa}', '{arac.AracMotor}');";

                    bool veritabaniKontrol = sqlServer.sqlEkle(query);

                    if (veritabaniKontrol)
                    {
                        MessageBox.Show("Kayıt başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenirken bir hata oluştu.");
                    }
                }
                else if (txtAracID.Text != "")
                {
                    arac.AracID = Convert.ToInt32(txtAracID.Text);

                    query = $"UPDATE Araclar SET Marka = '{arac.AracMarka}', Model = '{arac.AracModel}', UretimYili = '{arac.AracUretimYili}', " +
                         $"Kasa = '{arac.AracKasa}', Motor = '{arac.AracMotor}' WHERE AracID = '{arac.AracID}';"; // Güncelleme sorgusu                

                    // Veritabanına veriyi ekleyin
                    bool veritabaniKontrol = sqlServer.sqlEkle(query);

                    if (veritabaniKontrol)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenirken bir hata oluştu.");
                    }

                }
            }
            Listele();
            parcaEkle.TreeViewSorgu(); // Parcalar sayfasındaki ağaç yapısnı yeniden oluştur

            txtAracID.Clear();
            txtAracMarka.Clear();
            txtKasa.Clear();
            txtModel.Clear();
            txtMotor.Clear();
            numericUretimYili.Value = 1980;

        }


        private void dGridAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dGridAraclar.SelectedCells[0].RowIndex;

            // textBoxlara değerler yazılıt.
            txtAracID.Text = dGridAraclar.Rows[seciliAlan].Cells[0].Value.ToString();
            txtAracMarka.Text = dGridAraclar.Rows[seciliAlan].Cells[1].Value.ToString();
            txtModel.Text = dGridAraclar.Rows[seciliAlan].Cells[2].Value.ToString();
            numericUretimYili.Value = Convert.ToInt32(dGridAraclar.Rows[seciliAlan].Cells[3].Value);
            txtKasa.Text = dGridAraclar.Rows[seciliAlan].Cells[4].Value.ToString();
            txtMotor.Text = dGridAraclar.Rows[seciliAlan].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliAlan = dGridAraclar.SelectedCells[0].RowIndex;

            arac.AracID = Convert.ToInt32(dGridAraclar.Rows[seciliAlan].Cells[0].Value);

            string sorgu = $"DELETE FROM Araclar WHERE AracID={arac.AracID};";
            bool kontrol = sqlServer.sqlEkle(sorgu);

            if (kontrol)
                MessageBox.Show("Araç Kaydı Silindi");
            else
                MessageBox.Show("Kayıt Silinemedi");

            Listele();
        }
        // Arama işlemi
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToUpper();
            islem.Ara(dGridAraclar, aranan);
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            islem.Aktar(dGridAraclar);
        }
    }
}
