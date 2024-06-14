using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcaMuhasebe.Sınıflar;

namespace ParcaMuhasebe.User_Controls
{
    public partial class CariEkle : UserControl
    {
        public CariEkle()
        {
            InitializeComponent();
            Listele();
        }
        SqlServer sqlServer = new SqlServer();
        DataTable dataTable = new DataTable();
        Islem islem = new Islem();
        Cari cari = new Cari();
        private void Listele()
        {
            dGridMusteri.Rows.Clear();

            string sorgu = "SELECT * FROM Musteri ORDER BY MusteriID ASC;";
            dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridMusteri.Rows.Add(); // Her döngüde yeni bir satır ekle

                dGridMusteri.Rows[i].Cells[0].Value = row["MusteriID"].ToString();
                dGridMusteri.Rows[i].Cells[1].Value = row["Adi"].ToString();
                dGridMusteri.Rows[i].Cells[2].Value = row["Soyadi"].ToString();
                dGridMusteri.Rows[i].Cells[3].Value = row["Telefon"].ToString();
                dGridMusteri.Rows[i].Cells[4].Value = row["VergiNo"].ToString();
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || txtTelefon.Text == "" || txtVergiNumarasi.Text == "")
                MessageBox.Show("Lütfen tüm alanları doldurun!".Trim());
            else
            {
                // TextBox'lardan gelen verileri aliyoruz
               
                cari.MusteriAdi = txtAdi.Text;
                cari.MusteriSoyadi = txtSoyadi.Text;
                cari.MusteriTelefon= txtTelefon.Text;
                cari.MusteriVergiNo = txtVergiNumarasi.Text;

                string query;


                if (txtMusteriID.Text == "") // AracID boş olduğunda yeni kayıt yapılır
                {

                    query = "INSERT INTO Musteri (Adi, Soyadi, Telefon, VergiNo) " +
                                   $"VALUES ('{cari.MusteriAdi}', '{cari.MusteriSoyadi}','{cari.MusteriTelefon}','{cari.MusteriVergiNo}');";

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
                else if (txtMusteriID.Text != "")
                {
                    cari.MusteriID = Convert.ToInt32(txtMusteriID.Text);

                    query = $"UPDATE Musteri SET Adi = '{cari.MusteriAdi}', Soyadi = '{cari.MusteriSoyadi}', Telefon = '{cari.MusteriTelefon}', " +
                         $"VergiNo= '{cari.MusteriVergiNo}' where MusteriID={cari.MusteriID};"; // Güncelleme sorgusu                

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

            txtMusteriID.Clear();
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtVergiNumarasi.Clear();
        }

        private void dGridMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dGridMusteri.SelectedCells[0].RowIndex;

            // textBoxlara değerler yazılıt.
            txtMusteriID.Text = dGridMusteri.Rows[seciliAlan].Cells[0].Value.ToString();
            txtAdi.Text = dGridMusteri.Rows[seciliAlan].Cells[1].Value.ToString();
            txtSoyadi.Text = dGridMusteri.Rows[seciliAlan].Cells[2].Value.ToString();
            txtTelefon.Text = dGridMusteri.Rows[seciliAlan].Cells[3].Value.ToString();
            txtVergiNumarasi.Text = dGridMusteri.Rows[seciliAlan].Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliAlan = dGridMusteri.SelectedCells[0].RowIndex;

            cari.MusteriID = Convert.ToInt32(dGridMusteri.Rows[seciliAlan].Cells[0].Value);

            string sorgu = $"DELETE FROM Musteri WHERE MusteriID={cari.MusteriID};";
            bool kontrol = sqlServer.sqlEkle(sorgu);

            if (kontrol)
                MessageBox.Show("Cari Kaydı Silindi");
            else
                MessageBox.Show("Kayıt Silinemedi");

            Listele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToUpper();
            islem.Ara(dGridMusteri, aranan);  
        }
    }
}
