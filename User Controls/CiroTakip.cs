using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using ParcaMuhasebe.Sınıflar;


namespace ParcaMuhasebe.User_Controls
{
    public partial class CiroTakip : UserControl
    {
        DataTable dataTable = new DataTable();
        SqlServer sqlServer = new SqlServer();
        Islem islem = new Islem();
        Parca parca = new Parca();

        public CiroTakip()
        {
            InitializeComponent();


            dateTimeAlt.MaxDate = DateTime.Now;
            dateTimeUst.MinDate = DateTime.Now;

            Listele();
        }
        public void Listele()
        {
            rBtnGunluk.Select();
            const string sorgu = "SELECT p.ParcaID, p.ParcaAd, SUM(s.SatilanAdet) AS SatilanAdet, p.SatisFiyati, p.AlisFiyati, p.KdvOrani, p.EklemeTarihi FROM Satis s JOIN Parcalar p ON s.ParcaID = p.ParcaID GROUP BY p.ParcaID, p.ParcaAd, p.SatisFiyati, p.AlisFiyati, p.KdvOrani, p.EklemeTarihi ORDER BY p.ParcaID ASC;";

            dGridCiro.Rows.Clear();// DataGridView'deki tüm satırları temizle

            dataTable = sqlServer.sqlSorgu(sorgu); // Parcalar tablosundaki son eklenen 10 parca listelenir.

            // Verileri ekle
            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridCiro.Rows.Add(); // Her döngüde yeni bir satır ekle

                dGridCiro.Rows[i].Cells[0].Value = row["ParcaID"].ToString();
                dGridCiro.Rows[i].Cells[1].Value = row["ParcaAd"].ToString();
                dGridCiro.Rows[i].Cells[2].Value = row["SatilanAdet"].ToString();

                // Kdv Tutarını hesapla ve ekle
                parca.SatisFiyati = Convert.ToDecimal(row["SatisFiyati"]);
                parca.AlisFiyati = Convert.ToDecimal(row["AlisFiyati"]);
                parca.KdvOrani = Convert.ToDecimal(row["KdvOrani"]);

                SatisSinif satis = new SatisSinif(parca.SatisFiyati, parca.AlisFiyati, parca.KdvOrani);
                satis.SatilanAdet = Convert.ToInt32(row["SatilanAdet"]);


                dGridCiro.Rows[i].Cells[3].Value = satis.Hasilat.ToString("F2");
                dGridCiro.Rows[i].Cells[4].Value = satis.Maliyet.ToString("F2");
                dGridCiro.Rows[i].Cells[5].Value = satis.Kar.ToString("F2");
                dGridCiro.Rows[i].Cells[6].Value = satis.KdvTutari.ToString("F2");

                dGridCiro.Rows[i].Cells[7].Value = Convert.ToDateTime(row["EklemeTarihi"]).ToString("yyyy-MM-dd");
            }
        }
        private void TabloListele(string tarih)
        {
            string sorgu = "SELECT " +
            "SUM(S.SatilanAdet) AS ToplamSatilanAdet, " +
            "COUNT(DISTINCT S.FaturaID) AS KesilenFaturaAdedi, " +
            "SUM(S.SatilanAdet * P.SatisFiyati) AS ToplamHasilat, " +
            "SUM(S.SatilanAdet * P.AlisFiyati) AS ToplamMaliyet, " +
            "SUM(S.SatilanAdet * P.SatisFiyati) - SUM(S.SatilanAdet * P.AlisFiyati) AS Kar, " +
            "SUM(S.SatilanAdet * (P.KdvOrani / 100) * P.SatisFiyati) AS ToplamKDV " +
            "FROM Satis S " +
            "JOIN Parcalar P ON S.ParcaID = P.ParcaID " +
            "JOIN Fatura F ON S.FaturaID = F.FaturaID " +
            $"{tarih};";

            dataTable = sqlServer.sqlSorgu(sorgu);
            foreach (DataRow row in dataTable.Rows)
            {
                lblHasilat.Text = row["ToplamHasilat"].ToString();
                lblKar.Text = row["Kar"].ToString();
                decimal kdv = Convert.ToDecimal(row["ToplamKDV"]);
                lblKdv.Text = kdv.ToString("F2");
                lblSatilanParca.Text = row["ToplamSatilanAdet"].ToString();
                lblKesilenFatura.Text = row["KesilenFaturaAdedi"].ToString();
                lblMaliyet.Text = row["ToplamMaliyet"].ToString();
            }
        }
        private void rBtnGunluk_CheckedChanged(object sender, EventArgs e)
        {
            TabloListele("WHERE DATE(F.EklemeTarihi) = CURDATE()");
        }
        private void rBtnHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            TabloListele("WHERE F.EklemeTarihi >= CURDATE() - INTERVAL 7 DAY");
        }

        private void rBtnAylik_CheckedChanged(object sender, EventArgs e)
        {
            TabloListele("WHERE F.EklemeTarihi >= CURDATE() - INTERVAL 1 MOUNTH");
        }

        private void rBtnYillik_CheckedChanged(object sender, EventArgs e)
        {
            TabloListele("WHERE F.EklemeTarihi >= CURDATE() - INTERVAL 1 YEAR");
        }

        private void rBtnTum_CheckedChanged(object sender, EventArgs e)
        {
            TabloListele("");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            string altTarih = dateTimeAlt.Value.ToString("yyyy-MM-dd");
            string ustTarih = dateTimeUst.Value.ToString("yyyy-MM-dd");
            TabloListele($"Where F.EklemeTarihi BETWEEN '{altTarih}' AND '{ustTarih}'");
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToUpper();
            islem.Ara(dGridCiro, aranan);
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            islem.Aktar(dGridCiro);
        }
    }
}
