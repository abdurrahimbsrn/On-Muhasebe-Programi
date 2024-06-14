namespace ParcaMuhasebe.User_Controls
{
    partial class Login
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnGirisYap);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(520, 257);
            panel1.Name = "panel1";
            panel1.Size = new Size(660, 380);
            panel1.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(36, 46, 56);
            btnGirisYap.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGirisYap.ForeColor = SystemColors.ControlLightLight;
            btnGirisYap.Location = new Point(310, 274);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(224, 43);
            btnGirisYap.TabIndex = 14;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(310, 241);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(224, 27);
            txtSifre.TabIndex = 13;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(310, 206);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(224, 27);
            txtKullaniciAdi.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 243);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 11;
            label3.Text = "Şifre: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 208);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 12;
            label4.Text = "Kullanıcı Adı: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(74, 68);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 660);
            panel2.Name = "panel2";
            panel2.Size = new Size(1330, 55);
            panel2.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 46, 56);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Size = new Size(1330, 715);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}
