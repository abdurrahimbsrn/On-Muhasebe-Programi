using Org.BouncyCastle.Math.EC;
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
    public partial class Satis : UserControl
    {
        DataTable dataTable = new DataTable();
        SqlServer sqlServer = new SqlServer();
        Islem islem = new Islem();
        Anasayfa anasayfa;

        CiroTakip ciro = new CiroTakip();
        FaturaListele faturaListele = new FaturaListele();
        Parca parca = new Parca();
        Cari cari = new Cari();


        public Satis(Anasayfa sayfa)
        {
            InitializeComponent();
            SayfaYukle();
            anasayfa = sayfa;
        }
        public void SayfaYukle()
        {
            MusteriSec();

            numericAdet.Value = 1;
            cBovOdeme.SelectedIndex = 0;
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dGridMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir cari seçin.");
                return;
            }
            var selectedRow = dGridMusteri.SelectedRows[0];
            cari.MusteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);
            lblAdi.Text = "Adı: " + selectedRow.Cells["MusteriAd"].Value.ToString();
            lblSoyadi.Text = "Soyadı: " + selectedRow.Cells["MusteriSoyad"].Value.ToString();
            lblTelefon.Text = "Telefon: " + selectedRow.Cells["Telefon"].Value.ToString();
            lblVergiNumarasi.Text = "Vergi Numarası: " + selectedRow.Cells["VergiNo"].Value.ToString();

            panelSatis.Show();
            panelSatis.Enabled = true;
            groupBoxMusteri.Hide();
            groupBoxMusteri.Enabled = false;
            ParcaListele();
        }
        private void MusteriSec()
        {
            groupBoxMusteri.Show();
            groupBoxMusteri.Enabled = true;
            panelSatis.Hide();
            panelSatis.Enabled = false;

            dGridMusteri.Rows.Clear();

            string sorgu = "SELECT * FROM Musteri ORDER BY MusteriID ASC;";
            dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridMusteri.Rows.Add();

                dGridMusteri.Rows[i].Cells[0].Value = row["MusteriID"].ToString();
                dGridMusteri.Rows[i].Cells[1].Value = row["Adi"].ToString();
                dGridMusteri.Rows[i].Cells[2].Value = row["Soyadi"].ToString();
                dGridMusteri.Rows[i].Cells[3].Value = row["Telefon"].ToString();
                dGridMusteri.Rows[i].Cells[4].Value = row["VergiNo"].ToString();
            }
        }

        private void btnMusteriDegistir_Click(object sender, EventArgs e)
        {
            cari.MusteriID=-1;
            groupBoxMusteri.Show();
            groupBoxMusteri.Enabled = true;
            MusteriSec();
            
        }
        decimal toplam;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            toplam = 0;

            if (dGridParcalar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen sepete eklemek için bir parça seçin.");
                return;
            }
            var selectedRow = dGridParcalar.SelectedRows[0];
            parca.ParcaID = Convert.ToInt32(selectedRow.Cells["ParcaID"].Value);
            parca.ParcaAd = selectedRow.Cells["ParcaAd"].Value.ToString();
            parca.SatisFiyati = Convert.ToDecimal(selectedRow.Cells["SatisFiyati"].Value);
            decimal kdv = Convert.ToDecimal(selectedRow.Cells["KDVTutari"].Value);
            int adet = Convert.ToInt32(numericAdet.Value);

            decimal toplamTutar = parca.SatisFiyati * adet, toplamKdv = kdv * adet;

            toplam = toplam + toplamTutar;// Sepetteki toplam tutar

            if (adet > Convert.ToInt32(selectedRow.Cells["Stok"].Value))
            {
                MessageBox.Show("Stok Yetersiz!");
                return;
            }

            dGridSepet.Rows.Add(parca.ParcaID, parca.ParcaAd, parca.SatisFiyati, adet, toplamTutar, toplamKdv);

            lblToplamTutar.Text = $"Toplam Tutar: {toplam:C}";
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtMusteriAra.Text.Trim().ToUpper();
            islem.Ara(dGridMusteri, aranan);
        }
        private void ParcaListele()
        {
            const string sorgu = "SELECT p.ParcaID,CONCAT(a.Marka, ' ', a.Model,' ',a.UretimYili,' ',a.Kasa,' ',a.Motor) AS AracBilgisi, p.ParcaAd, p.ParcaMarka, p.SatisFiyati, p.Stok, p.SatisFiyati, SUM(p.SatisFiyati * (p.KdvOrani/100)) AS KDV FROM Parcalar p JOIN Araclar a ON p.AracID = a.AracID group by p.ParcaID, a.Marka, a.Model, a.UretimYili, a.Kasa, a.Motor, p.ParcaAd, p.ParcaMarka, p.SatisFiyati, p.Stok order BY p.ParcaID asc;";

            dGridParcalar.Rows.Clear();// DataGridView'deki tüm satırları temizle

            dataTable = sqlServer.sqlSorgu(sorgu);

            // Verileri ekle
            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridParcalar.Rows.Add(); // Her döngüde yeni bir satır ekle
                decimal kdv;

                int stok = Convert.ToInt32(row["Stok"]);

                dGridParcalar.Rows[i].Cells[0].Value = row["ParcaID"].ToString();
                dGridParcalar.Rows[i].Cells[1].Value = row["AracBilgisi"].ToString();
                dGridParcalar.Rows[i].Cells[2].Value = row["ParcaAd"].ToString();
                dGridParcalar.Rows[i].Cells[3].Value = row["ParcaMarka"].ToString();
                dGridParcalar.Rows[i].Cells[4].Value = row["Stok"].ToString();
                dGridParcalar.Rows[i].Cells[5].Value = row["SatisFiyati"].ToString();
                kdv = Convert.ToDecimal(row["KDV"].ToString());
                dGridParcalar.Rows[i].Cells[6].Value = kdv.ToString("F2");

                if (stok == 0)
                    dGridParcalar.Rows.Remove(dGridParcalar.Rows[i]);

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dGridSepet.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen sepetten çıkartmak için bir parça seçin.");
                return;
            }

            var selectedRow = dGridSepet.SelectedRows[0];
            toplam = toplam - Convert.ToInt32(selectedRow.Cells["sFiyat"].Value); // Toplam tutarı yeniden hesapla
            dGridSepet.Rows.Remove(selectedRow);

            lblToplamTutar.Text = $"Toplam Tutar: {toplam}: ₺";
        }
        private void textParcaAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtMusteriAra.Text.Trim().ToUpper();
            islem.Ara(dGridMusteri, aranan);
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            // Ödeme yönteminin belirlenmesi
            string odemeYontemi;
            if (cBovOdeme.SelectedIndex == 0)
                odemeYontemi = "Nakit";
            else if (cBovOdeme.SelectedIndex == 1)
                odemeYontemi = "Kredi Kartı";
            else
                odemeYontemi = "Havale";

            string faturaQuery = $"INSERT INTO Fatura (MusteriID, OdemeYontemi) VALUES ({cari.MusteriID}, '{odemeYontemi}');";
            sqlServer.sqlEkle(faturaQuery); // Fatura tablosuna veri girişi

            string sorgu = "Select FaturaID from Fatura ORDER BY FaturaID desc LIMIT 1 ";
            dataTable = sqlServer.sqlSorgu(sorgu); // FaturaID sorgusu
            int faturaID = Convert.ToInt32(dataTable.Rows[0]["FaturaID"]);


            foreach (DataGridViewRow row in dGridSepet.Rows)// Satış tablosuna satılan parcaların kaydı
            {
                int parcaID = Convert.ToInt32(row.Cells["sParcaID"].Value);
                int adet = Convert.ToInt32(row.Cells["sAdet"].Value);

                string satisQuery = $"INSERT INTO Satis (FaturaID, ParcaID, SatilanAdet) VALUES ({faturaID}, {parcaID}, {adet});";
                sqlServer.sqlEkle(satisQuery);
            }
            ParcaListele();
            MessageBox.Show("Satış başarıyla tamamlandı.");
            dGridSepet.Rows.Clear();
            lblToplamTutar.Text = "Toplam Tutar: 0₺";

            // Diğer sayfalardaki bilgileri güncelleyelim
            anasayfa.ustBilgi();
            faturaListele.Listele();
            ciro.Listele();
        }

    }
}
