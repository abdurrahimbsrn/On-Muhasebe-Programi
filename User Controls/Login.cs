using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcaMuhasebe.User_Controls
{
    public partial class Login : UserControl
    {
        Anasayfa anasayfa;
        SqlServer sqlServer = new SqlServer();
        
        public Login(Anasayfa sayfa)
        {
            InitializeComponent();
            anasayfa = sayfa;
            
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre= "";

            string sorgu = $"SELECT KullaniciSifresi FROM Kullanici WHERE KullaniciID = '{kullaniciAdi}';";

            dataTable = sqlServer.sqlSorgu(sorgu);

            foreach (DataRow row in dataTable.Rows)
                sifre = row["KullaniciSifresi"].ToString();

            if (sifre==txtSifre.Text && sifre!="") { 
            
                anasayfa.Giris();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }

        }
    }
}
