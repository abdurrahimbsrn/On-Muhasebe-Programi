using ParcaMuhasebe.Sınıflar;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParcaMuhasebe.User_Controls
{
    public partial class ParcaEkle : UserControl
    {
        SqlServer sqlServer = new SqlServer();
        Islem islem = new Islem();

        Parca parca = new Parca();
        public ParcaEkle()
        {
            InitializeComponent();
        }
        private void ParcaEkle_Load(object sender, EventArgs e)
        {
            Listele();
            TreeViewSorgu();
            numericStok.Value = 1;
        }

        private void Listele()
        {
            const string sorgu = "SELECT p.ParcaID, a.Marka, a.Model, p.ParcaAd, p.ParcaMarka, p.Stok, p.AlisFiyati, p.SatisFiyati, p.KdvOrani, p.EklemeTarihi FROM Parcalar p JOIN Araclar a ON p.AracID = a.AracID ORDER BY p.ParcaID asc, p.ParcaID;";

            dGridParcalar.Rows.Clear(); // DataGridView'deki tüm satırları temizle
            treeViewArac.Nodes.Clear(); // TreeView'i temizle

            DataTable dataTable = sqlServer.sqlSorgu(sorgu); // Parcalar tablosundaki verileri getir

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
                parca.SatisFiyati = Convert.ToDecimal(row["SatisFiyati"]);
                parca.KdvOrani = Convert.ToDecimal(row["KdvOrani"]);
                dGridParcalar.Rows[i].Cells[9].Value = parca.KdvTutari.ToString("F2");
                dGridParcalar.Rows[i].Cells[10].Value = Convert.ToDateTime(row["EklemeTarihi"]).ToString("yyyy-MM-dd");
            }

            // TreeView sorgusu
            TreeViewSorgu();
        }
        public void TreeViewSorgu()
        {

            treeViewArac.Nodes.Clear();

            string sorgu = "Select * from araclar";
            DataTable dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
            {
                // Her aracın modeline göre ana düğüm varsa o düğümü getirir yoksa yeni düğüm oluştur
                TreeNode markaNode = DugumBul(treeViewArac.Nodes, row["Marka"].ToString());
                TreeNode modelNode = DugumBul(markaNode.Nodes, row["Model"].ToString());
                TreeNode uretimYiliNode = DugumBul(modelNode.Nodes, row["UretimYili"].ToString());
                TreeNode kasaNode = DugumBul(uretimYiliNode.Nodes, row["Kasa"].ToString());
                TreeNode motorNode = DugumBul(kasaNode.Nodes, row["Motor"].ToString());

            }
        }
        private TreeNode DugumBul(TreeNodeCollection nodes, string text)
        {
            foreach (TreeNode node in nodes)// Düğüm mevcut mu?
            {
                if (node.Text == text)
                {
                    return node; // Varsa aynı düğümü döndür
                }
            }

            TreeNode newNode = new TreeNode(text); // Yoksa yeni düğüm oluştur.
            nodes.Add(newNode);
            return newNode;
        }

        string aracSorgu;
        private void treeViewArac_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeViewArac.SelectedNode;

            string secilenArac = "";
            string[] Arac = new string[5];

            int kontrol = 0; // aracın en son düğümü seçildi mi?
            while (node != null)
            {
                Arac[kontrol] = node.Text;
                kontrol++;
                secilenArac = node.Text + " " + secilenArac;
                node = node.Parent;
            }
            if (kontrol < 5)
                MessageBox.Show("Lütfen motor bölümünden seçim yapın.".Trim());
            else
            {
                labelSecilenArac.Text = "Seçilen araç = " + secilenArac;

                aracSorgu = $"SELECT * FROM Araclar WHERE Marka = '{Arac[4]}' and Model='{Arac[3]}' and UretimYili='{Arac[2]}' and Kasa='{Arac[1]}' and Motor='{Arac[0]}';"; // Gönderilecek sorgu
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataTable dataTable;

            if (aracSorgu == null || txtParcaAdi.Text == "" || txtMarka.Text == "" || txtSatisFiyati.Text == "" || txtAlisFiyat.Text == "" || txtKDVOrani.Text == "")
                MessageBox.Show("Lütfen tüm alanları doldurun!".Trim());
            else
            {

                dataTable = sqlServer.sqlSorgu(aracSorgu);

                // TextBox'lardan gelen verileri aliyoruz
                int parcaID; // Güncelleme işlemlerinde kullanılacak
                parca.AracID = Convert.ToInt32(dataTable.Rows[0]["AracID"]);
                parca.ParcaAd = txtParcaAdi.Text;
                parca.ParcaMarka = txtMarka.Text;
                parca.Stok= Convert.ToInt32(numericStok.Value);
                parca.AlisFiyati = Convert.ToDecimal(txtAlisFiyat.Text);
                parca.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
                parca.KdvOrani = Convert.ToDecimal(txtKDVOrani.Text);

                SqlServer sql = new SqlServer(); // Veri tabanı bağlantılarının açılmaıs
                string query;


                if (txtParcaID.Text == "") // ParcaID boş olduğunda yeni kayıt yapılır
                {

                    query = "INSERT INTO parcalar (AracID,ParcaAd,ParcaMarka,Stok,AlisFiyati,SatisFiyati,KdvOrani) " +
                                   $"VALUES ('{parca.AracID}', '{parca.ParcaAd}', '{parca.ParcaMarka}', '{parca.Stok}', '{parca.AlisFiyati}', '{parca.SatisFiyati}', '{parca.KdvOrani}');";

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
                else if (txtParcaID.Text != "")
                {
                    parcaID = Convert.ToInt32(txtParcaID.Text);

                    query = $"UPDATE parcalar SET AracID = '{parca.AracID}', ParcaAd = '{parca.ParcaAd}', ParcaMarka = '{parca.ParcaMarka}', " +
                         $"Stok = '{parca.Stok}', AlisFiyati = {parca.AlisFiyati.ToString(CultureInfo.InvariantCulture)}, SatisFiyati = {parca.SatisFiyati.ToString(CultureInfo.InvariantCulture)}, KdvOrani = '{parca.KdvOrani}'" +
                         $"WHERE ParcaID = '{parcaID}';"; // alış fiyatı ve satış fiyatı '.' hale getirlir.                   

                    // Veritabanına veriyi ekleyin
                    bool veritabaniKontrol = sql.sqlEkle(query);

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
            Listele(); // Parça eklendikten sonra tabloyu güncelliyoruz

            // textboxları temizledik
            txtParcaID.Clear();
            txtParcaAdi.Clear();
            txtMarka.Clear();
            txtSatisFiyati.Clear();
            txtKDVOrani.Clear();
            txtAlisFiyat.Clear();
            numericStok.Value = 1;
        }

        private void dGridParcalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = dGridParcalar.SelectedCells[0].RowIndex;

            parca.ParcaID = Convert.ToInt32(dGridParcalar.Rows[seciliAlan].Cells[0].Value); // ParcaId araçlar tablosuna sorgu olarak gönderilecek.

            string sorgu = $"SELECT AracID from parcalar where ParcaID={parca.ParcaID};"; // parclar tablosundan AracID verisini alıyoruz
            DataTable dataTable = sqlServer.sqlSorgu(sorgu);

            parca.AracID = Convert.ToInt32(dataTable.Rows[0]["AracID"]); // Parçalar tablosundan çektiğimiz AraçID değerini Araclar tablosuna sorgu olarak göndereceğiz

            sorgu = $"SELECT * from Araclar where AracID={parca.AracID};";
            dataTable = sqlServer.sqlSorgu(sorgu);


            List<string> veriTabaniSonuclari = new List<string>(); // Araçlar tablosundan veriler alınıp listeye eklenir
            // Verileri ekle
            foreach (DataRow row in dataTable.Rows)
            {
                veriTabaniSonuclari.Add(row["Marka"].ToString());
                veriTabaniSonuclari.Add(row["Model"].ToString());
                veriTabaniSonuclari.Add(row["UretimYili"].ToString());
                veriTabaniSonuclari.Add(row["Kasa"].ToString());
                veriTabaniSonuclari.Add(row["Motor"].ToString());
            }

            // Seçilen Aracın Ağaç yapısında bulunup seçilmesi


            // Ağaç yapısındaki kökler aşağıda aranır. Bulunan kökün düğümleri
            //treeNodeAra methoduna gönderilir ve aramaya orada devam edilir.

            string aranacakDugum = veriTabaniSonuclari[0];
            veriTabaniSonuclari.RemoveAt(0);
            foreach (TreeNode dugum in treeViewArac.Nodes)
            {
                if (dugum.Text == aranacakDugum)
                {
                    treeNodeAra(dugum, veriTabaniSonuclari, treeViewArac);
                }
            }


            // textBoxlara değerler yazılıt.

            txtParcaID.Text = dGridParcalar.Rows[seciliAlan].Cells[0].Value.ToString();
            txtParcaAdi.Text = dGridParcalar.Rows[seciliAlan].Cells[3].Value.ToString();
            txtMarka.Text = dGridParcalar.Rows[seciliAlan].Cells[4].Value.ToString();
           numericStok.Value = Convert.ToUInt32(dGridParcalar.Rows[seciliAlan].Cells[5].Value);
            txtAlisFiyat.Text = dGridParcalar.Rows[seciliAlan].Cells[6].Value.ToString();
            txtSatisFiyati.Text = dGridParcalar.Rows[seciliAlan].Cells[7].Value.ToString();
            txtKDVOrani.Text = dGridParcalar.Rows[seciliAlan].Cells[8].Value.ToString();
        }
        // Düzenleme/ güncelleme işlemi için ağaç yapısından kullanılan değeri seçili hale getiriyoruz.
        private void treeNodeAra(TreeNode node, List<string> aranacakDegerler, System.Windows.Forms.TreeView tView)
        {                       // üst düğüm,   aranacak değerlerin bulunduğı liste, seçme işleminin yapılacağı ağaç

            if (aranacakDegerler.Count == 0) //Liste boşaldığında/değer bulunduğunda
                tView.SelectedNode = node; // Bulunan düğümü seçili hale getir.
            else
            {
                string aranacakDugum = aranacakDegerler[0]; // listenin en başındaki eleman(en üstteki düğüm yüklenir)
                aranacakDegerler.RemoveAt(0);               // baştaki düğüm listeden çıkarılır.
                foreach (TreeNode dugum in node.Nodes)      // aldığımız düğümün alt düğümlerini gezerek arama yapıyoruz
                {
                    if (dugum.Text == aranacakDugum)
                    {
                        treeNodeAra(dugum, aranacakDegerler, tView); // Bulduğumuzda yeni üst düğüm bulunan düğüm olarak metot tekrar çağrılır.
                    }
                }
            }
        }

        // Arama işlemi
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.Trim().ToUpper();
            islem.Ara(dGridParcalar, aranan);
        }
        //Silme işlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliAlan = dGridParcalar.SelectedCells[0].RowIndex;

            parca.ParcaID = Convert.ToInt32(dGridParcalar.Rows[seciliAlan].Cells[0].Value);

            string sorgu = $"DELETE FROM parcalar WHERE ParcaID={parca.ParcaID};";
            bool kontrol = sqlServer.sqlEkle(sorgu);

            if (kontrol)
                MessageBox.Show("Kayıt Silindi");
            else
                MessageBox.Show("Kayıt Silinemedi");

            Listele();
        }

        private void dGridParcalar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) // Stoga gore satır renklendirme
        {
            for (int i = 0; i < dGridParcalar.RowCount - 1; i++)
            {
                if (Convert.ToInt32(dGridParcalar.Rows[i].Cells["dataGridViewTextBoxColumn6"].Value.ToString()) < 10)
                {
                    dGridParcalar.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dGridParcalar.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (Convert.ToInt32(dGridParcalar.Rows[i].Cells["dataGridViewTextBoxColumn6"].Value.ToString()) < 20)
                {
                    dGridParcalar.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dGridParcalar.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            islem.Aktar(dGridParcalar);

        }
    }
}
