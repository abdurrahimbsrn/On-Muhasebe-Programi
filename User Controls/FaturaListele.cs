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

    public partial class FaturaListele : UserControl
    {
        DataTable dataTable = new DataTable();
        SqlServer sqlServer = new SqlServer();
        Islem islem = new Islem();
        public FaturaListele()
        {
            InitializeComponent();
            Listele();
        }
        public void Listele()
        {
            const string sorgu = "SELECT f.FaturaID, m.VergiNo, CONCAT(m.Adi, ' ', m.Soyadi) AS MusteriAdiSoyadi, GROUP_CONCAT(CONCAT(p.ParcaID,' - ',p.ParcaAd, ' * ', s.SatilanAdet, ' = ', s.SatilanAdet * p.SatisFiyati, '₺') SEPARATOR ', ') AS SatilanParcalar, SUM(s.SatilanAdet * p.SatisFiyati) AS ToplamTutar, SUM(s.SatilanAdet * p.SatisFiyati * (p.KdvOrani/100)) AS ToplamKDV, f.OdemeYontemi, f.EklemeTarihi FROM Fatura f JOIN Musteri m ON f.MusteriID = m.MusteriID JOIN Satis s ON f.FaturaID = s.FaturaID JOIN Parcalar p ON s.ParcaID = p.ParcaID GROUP BY f.FaturaID, m.VergiNo, f.EklemeTarihi;";
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
                decimal kdv = Convert.ToDecimal(row["ToplamKDV"]);
                dGridFatura.Rows[i].Cells[5].Value = kdv.ToString("F2");
                dGridFatura.Rows[i].Cells[6].Value = row["OdemeYontemi"].ToString();
                dGridFatura.Rows[i].Cells[7].Value = Convert.ToDateTime(row["EklemeTarihi"]).ToString("yyyy-MM-dd");
            }
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToUpper();
            islem.Ara(dGridFatura, aranan);
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            islem.Aktar(dGridFatura);
        }
    }
}
