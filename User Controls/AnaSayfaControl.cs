using System.Data;
using ParcaMuhasebe.Sınıflar;

namespace ParcaMuhasebe.User_Controls
{
    public partial class AnaSayfaControl : UserControl
    {
        SqlServer sqlServer = new SqlServer();
        Parca parca = new Parca();
        public AnaSayfaControl()
        {
            InitializeComponent();
            anaSayfaListele();
        }

        public void anaSayfaListele()
        {


            dGridParcalar.Rows.Clear();// DataGridView'deki tüm satırları temizle
            dGridAraclar.Rows.Clear();
            dGridFatura.Rows.Clear();

            string sorgu = "SELECT p.ParcaID, a.Marka, a.Model, p.ParcaAd, p.ParcaMarka, p.Stok, p.AlisFiyati, p.SatisFiyati, p.KdvOrani, p.EklemeTarihi FROM Parcalar p JOIN Araclar a ON p.AracID = a.AracID ORDER BY p.EklemeTarihi DESC, p.ParcaID DESC LIMIT 2;";
            DataTable dataTable = sqlServer.sqlSorgu(sorgu); // Parcalar tablosundaki son eklenen 10 parca listelenir.

            // Verileri ekle
            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridParcalar.Rows.Add(); // Her döngüde yeni bir satır ekle

                dGridParcalar.Rows[i].Cells[0].Value = row["ParcaID"].ToString();
                dGridParcalar.Rows[i].Cells[1].Value = row["Marka"].ToString(); // Araç Markas
                dGridParcalar.Rows[i].Cells[2].Value = row["Model"].ToString(); // Araç Modeli
                dGridParcalar.Rows[i].Cells[3].Value = row["ParcaAd"].ToString();
                dGridParcalar.Rows[i].Cells[4].Value = row["ParcaMarka"].ToString();
                dGridParcalar.Rows[i].Cells[5].Value = row["Stok"].ToString();
                dGridParcalar.Rows[i].Cells[6].Value = row["AlisFiyati"].ToString();
                dGridParcalar.Rows[i].Cells[7].Value = row["SatisFiyati"].ToString();
                dGridParcalar.Rows[i].Cells[8].Value = row["KdvOrani"].ToString();
                dGridParcalar.Rows[i].Cells[9].Value = parca.KdvTutari.ToString("F2");
                dGridParcalar.Rows[i].Cells[10].Value = Convert.ToDateTime(row["EklemeTarihi"]).ToString("yyyy-MM-dd");
            }

            dGridParcalar.ClearSelection();
            // Son eklenen araclar
            sorgu = "SELECT * FROM araclar ORDER BY AracID desc LIMIT 2;";
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
            // Son kesilen faturalar

            sorgu = "SELECT f.FaturaID, m.VergiNo, CONCAT(m.Adi, ' ', m.Soyadi) AS MusteriAdiSoyadi, GROUP_CONCAT(CONCAT(p.ParcaID,' - ',p.ParcaAd, ' * ', s.SatilanAdet, ' = ', s.SatilanAdet * p.SatisFiyati, '₺') SEPARATOR ', ') AS SatilanParcalar, SUM(s.SatilanAdet * p.SatisFiyati) AS ToplamTutar, SUM(s.SatilanAdet * p.SatisFiyati * (p.KdvOrani/100)) AS ToplamKDV, f.OdemeYontemi, f.EklemeTarihi FROM Fatura f JOIN Musteri m ON f.MusteriID = m.MusteriID JOIN Satis s ON f.FaturaID = s.FaturaID JOIN Parcalar p ON s.ParcaID = p.ParcaID GROUP BY f.FaturaID, m.VergiNo, f.EklemeTarihi ORDER BY f.FaturaID DESC LIMIT 10;";

            dataTable = sqlServer.sqlSorgu(sorgu);

            dGridFatura.DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            foreach (DataRow row in dataTable.Rows)
            {
                int i = dGridFatura.Rows.Add(); // Her döngüde yeni bir satır ekle

                dGridFatura.Rows[i].Cells[0].Value = row["FaturaID"].ToString();
                dGridFatura.Rows[i].Cells[1].Value = row["VergiNo"].ToString();
                dGridFatura.Rows[i].Cells[2].Value = row["MusteriAdiSoyadi"].ToString();
                dGridFatura.Rows[i].Cells[3].Value = row["SatilanParcalar"].ToString();
                dGridFatura.Rows[i].Cells[4].Value = row["ToplamTutar"].ToString();
                decimal tkdv = Convert.ToDecimal(row["ToplamKDV"]);
                dGridFatura.Rows[i].Cells[5].Value = tkdv.ToString("F2");
                dGridFatura.Rows[i].Cells[6].Value = row["OdemeYontemi"].ToString();
                dGridFatura.Rows[i].Cells[7].Value = Convert.ToDateTime(row["EklemeTarihi"]).ToString("yyyy-MM-dd");
            }
        }

    }
}
