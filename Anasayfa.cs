using ParcaMuhasebe.User_Controls;
using System.Windows.Forms;
using System.Data;


namespace ParcaMuhasebe
{
    public partial class Anasayfa : Form
    {
       
        // UserControls tanımlamaları
        Login loginn;
        AnaSayfaControl anaSayfaControl = new AnaSayfaControl();
        ParcaEkle parcaEkle = new ParcaEkle();
        AracEkle aracEkle = new AracEkle();
        CiroTakip ciroTakip = new CiroTakip();
        CariEkle cariEkle = new CariEkle();
        FaturaListele faturaListele = new FaturaListele();
        Satis satis;

        SqlServer sqlServer = new SqlServer();
        DataTable dataTable = new DataTable();
        public Anasayfa()
        {
            InitializeComponent();
            ustBilgi();
            altBilgi();
        }
        Login logn;
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            GirisSayfasi();
        }
        private void GirisSayfasi()
        {
            panelAlt.Hide();
            panelUst.Hide();
            tLayoutMenu.Hide();
            Login logn = new Login(this);
            addUserControl(logn);
        }
        public void Giris()
        {
            panelAlt.Show();
            panelUst.Show();
            tLayoutMenu.Show();

            addUserControl(anaSayfaControl);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill; // Sayfa panele yayılır.
            panelGovde.Controls.Clear(); // Panel temizlenir.
            panelGovde.Controls.Add(userControl); // yeni sayfa eklenir
            userControl.BringToFront(); // en öne getirilir

        }
        private void parcaEkleBtn_Click_1(object sender, EventArgs e)
        {
            addUserControl(parcaEkle);
        }

        private void anaSayfaBtn_Click_1(object sender, EventArgs e)
        {
            anaSayfaControl.anaSayfaListele();
            addUserControl(anaSayfaControl);
        }
        private void aracEkleBtn_Click(object sender, EventArgs e)
        {
            addUserControl(aracEkle);
        }

        private void cariEkleBtn_Click(object sender, EventArgs e)
        {
            addUserControl(cariEkle);
        }

        private void ciroBtn_Click(object sender, EventArgs e)
        {
            addUserControl(ciroTakip);
        }


        private void btnFatura_Click(object sender, EventArgs e)
        {
            addUserControl(faturaListele);
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            Satis satis = new Satis(this);
            satis.SayfaYukle();
            addUserControl(satis);
        }
        public void ustBilgi()
        {
            string sorgu = "SELECT " +
            "SUM(S.SatilanAdet) AS ToplamSatilanAdet, " +
            "COUNT(DISTINCT S.FaturaID) AS KesilenFaturaAdedi, " +
            "SUM(S.SatilanAdet * P.SatisFiyati) AS ToplamHasilat " +
            "FROM Satis S " +
            "JOIN Parcalar P ON S.ParcaID = P.ParcaID " +
            "JOIN Fatura F ON S.FaturaID = F.FaturaID " +
            "WHERE DATE(F.EklemeTarihi) = CURDATE();";

            dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
            {
                lblGunlukHasilat.Text = "Hasılat: " + row["ToplamHasilat"].ToString();
                lblGunlukSatilanParca.Text = "Satılan Parça: " + row["ToplamSatilanAdet"].ToString();
                lblGunlukKesilenFatura.Text = "Kesilen Fatura: " + row["KesilenFaturaAdedi"].ToString();
            }
        }
        public void altBilgi()
        {
            string yazi = "", sorgu = "Select ParcaID, ParcaAd, Stok From Parcalar Where Stok <=20;";
            dataTable = sqlServer.sqlSorgu(sorgu);
            int x = 3;
            foreach (DataRow row in dataTable.Rows)
            {
                if(x>0)
                    yazi = yazi + row["ParcaID"].ToString() + " numaralı " + row["ParcaAd"] + ", ";
                x--;
            }
            if (yazi == "")
                lblDikkat.Hide();
            lblDikkatStok.Text = yazi;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            GirisSayfasi();
        }
    }
}
