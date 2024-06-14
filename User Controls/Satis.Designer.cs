namespace ParcaMuhasebe.User_Controls
{
    partial class Satis
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dGridParcalar = new DataGridView();
            ParcaID = new DataGridViewTextBoxColumn();
            AracBilgisi = new DataGridViewTextBoxColumn();
            ParcaAd = new DataGridViewTextBoxColumn();
            Marka = new DataGridViewTextBoxColumn();
            Stok = new DataGridViewTextBoxColumn();
            SatisFiyati = new DataGridViewTextBoxColumn();
            KDVTutari = new DataGridViewTextBoxColumn();
            panelSatis = new Panel();
            cBovOdeme = new ComboBox();
            btnSil = new Button();
            lblToplamTutar = new Label();
            label8 = new Label();
            panel1 = new Panel();
            btnEkle = new Button();
            numericAdet = new NumericUpDown();
            label7 = new Label();
            btnMusteriDegistir = new Button();
            btnSatis = new Button();
            groupBox1 = new GroupBox();
            lblSoyadi = new Label();
            lblTelefon = new Label();
            lblVergiNumarasi = new Label();
            lblAdi = new Label();
            textParcaAra = new TextBox();
            label1 = new Label();
            dGridSepet = new DataGridView();
            sParcaID = new DataGridViewTextBoxColumn();
            sParcaAd = new DataGridViewTextBoxColumn();
            sMarka = new DataGridViewTextBoxColumn();
            sAdet = new DataGridViewTextBoxColumn();
            sFiyat = new DataGridViewTextBoxColumn();
            sKdv = new DataGridViewTextBoxColumn();
            groupBoxMusteri = new GroupBox();
            btnSec = new Button();
            txtMusteriAra = new TextBox();
            label2 = new Label();
            dGridMusteri = new DataGridView();
            MusteriID = new DataGridViewTextBoxColumn();
            MusteriAd = new DataGridViewTextBoxColumn();
            MusteriSoyad = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            VergiNo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).BeginInit();
            panelSatis.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdet).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGridSepet).BeginInit();
            groupBoxMusteri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dGridMusteri).BeginInit();
            SuspendLayout();
            // 
            // dGridParcalar
            // 
            dGridParcalar.AllowUserToAddRows = false;
            dGridParcalar.AllowUserToDeleteRows = false;
            dGridParcalar.AllowUserToResizeColumns = false;
            dGridParcalar.AllowUserToResizeRows = false;
            dGridParcalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridParcalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridParcalar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridParcalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridParcalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridParcalar.Columns.AddRange(new DataGridViewColumn[] { ParcaID, AracBilgisi, ParcaAd, Marka, Stok, SatisFiyati, KDVTutari });
            dGridParcalar.EnableHeadersVisualStyles = false;
            dGridParcalar.Location = new Point(18, 410);
            dGridParcalar.Name = "dGridParcalar";
            dGridParcalar.ReadOnly = true;
            dGridParcalar.RowHeadersVisible = false;
            dGridParcalar.RowHeadersWidth = 40;
            dGridParcalar.RowTemplate.Height = 29;
            dGridParcalar.RowTemplate.ReadOnly = true;
            dGridParcalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridParcalar.Size = new Size(1298, 289);
            dGridParcalar.TabIndex = 79;
            // 
            // ParcaID
            // 
            ParcaID.FillWeight = 65.393425F;
            ParcaID.HeaderText = "Parça ID";
            ParcaID.MinimumWidth = 6;
            ParcaID.Name = "ParcaID";
            ParcaID.ReadOnly = true;
            // 
            // AracBilgisi
            // 
            AracBilgisi.FillWeight = 200.245972F;
            AracBilgisi.HeaderText = "Araç Bilgisi";
            AracBilgisi.MinimumWidth = 6;
            AracBilgisi.Name = "AracBilgisi";
            AracBilgisi.ReadOnly = true;
            // 
            // ParcaAd
            // 
            ParcaAd.FillWeight = 65.393425F;
            ParcaAd.HeaderText = "Parça Adı";
            ParcaAd.MinimumWidth = 6;
            ParcaAd.Name = "ParcaAd";
            ParcaAd.ReadOnly = true;
            // 
            // Marka
            // 
            Marka.FillWeight = 65.393425F;
            Marka.HeaderText = "Marka";
            Marka.MinimumWidth = 6;
            Marka.Name = "Marka";
            Marka.ReadOnly = true;
            // 
            // Stok
            // 
            Stok.FillWeight = 65.393425F;
            Stok.HeaderText = "Stok";
            Stok.MinimumWidth = 6;
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            // 
            // SatisFiyati
            // 
            SatisFiyati.FillWeight = 65.393425F;
            SatisFiyati.HeaderText = "Satış Fiyatı";
            SatisFiyati.MinimumWidth = 6;
            SatisFiyati.Name = "SatisFiyati";
            SatisFiyati.ReadOnly = true;
            // 
            // KDVTutari
            // 
            KDVTutari.FillWeight = 65.393425F;
            KDVTutari.HeaderText = "KDV Tutarı";
            KDVTutari.MinimumWidth = 6;
            KDVTutari.Name = "KDVTutari";
            KDVTutari.ReadOnly = true;
            // 
            // panelSatis
            // 
            panelSatis.Controls.Add(cBovOdeme);
            panelSatis.Controls.Add(btnSil);
            panelSatis.Controls.Add(lblToplamTutar);
            panelSatis.Controls.Add(label8);
            panelSatis.Controls.Add(panel1);
            panelSatis.Controls.Add(btnMusteriDegistir);
            panelSatis.Controls.Add(btnSatis);
            panelSatis.Controls.Add(groupBox1);
            panelSatis.Controls.Add(textParcaAra);
            panelSatis.Controls.Add(label1);
            panelSatis.Controls.Add(dGridParcalar);
            panelSatis.Controls.Add(dGridSepet);
            panelSatis.Location = new Point(0, 3);
            panelSatis.Name = "panelSatis";
            panelSatis.Size = new Size(1330, 712);
            panelSatis.TabIndex = 80;
            // 
            // cBovOdeme
            // 
            cBovOdeme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBovOdeme.FormattingEnabled = true;
            cBovOdeme.Items.AddRange(new object[] { "Nakit", "Kredi Kartı", "Havale" });
            cBovOdeme.Location = new Point(1036, 301);
            cBovOdeme.Name = "cBovOdeme";
            cBovOdeme.Size = new Size(280, 36);
            cBovOdeme.TabIndex = 101;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSil.BackColor = Color.Brown;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(499, 340);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 34);
            btnSil.TabIndex = 100;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.Location = new Point(933, 239);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(0, 31);
            lblToplamTutar.TabIndex = 99;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 12);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 97;
            label8.Text = "Sepet";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEkle);
            panel1.Controls.Add(numericAdet);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(629, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 120);
            panel1.TabIndex = 96;
            // 
            // btnEkle
            // 
            btnEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEkle.BackColor = Color.FromArgb(36, 46, 56);
            btnEkle.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(20, 46);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(200, 49);
            btnEkle.TabIndex = 95;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // numericAdet
            // 
            numericAdet.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericAdet.Location = new Point(92, 13);
            numericAdet.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAdet.Name = "numericAdet";
            numericAdet.Size = new Size(155, 30);
            numericAdet.TabIndex = 89;
            numericAdet.TextAlign = HorizontalAlignment.Center;
            numericAdet.Value = new decimal(new int[] { 999, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(20, 10);
            label7.Name = "label7";
            label7.Size = new Size(66, 30);
            label7.TabIndex = 0;
            label7.Text = "Adet:";
            // 
            // btnMusteriDegistir
            // 
            btnMusteriDegistir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMusteriDegistir.BackColor = Color.FromArgb(36, 46, 56);
            btnMusteriDegistir.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnMusteriDegistir.ForeColor = Color.White;
            btnMusteriDegistir.Location = new Point(1179, 167);
            btnMusteriDegistir.Name = "btnMusteriDegistir";
            btnMusteriDegistir.Size = new Size(137, 42);
            btnMusteriDegistir.TabIndex = 95;
            btnMusteriDegistir.Text = "Değiştir";
            btnMusteriDegistir.UseVisualStyleBackColor = false;
            btnMusteriDegistir.Click += btnMusteriDegistir_Click;
            // 
            // btnSatis
            // 
            btnSatis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSatis.BackColor = Color.FromArgb(255, 128, 0);
            btnSatis.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSatis.ForeColor = Color.White;
            btnSatis.Location = new Point(1036, 343);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(280, 61);
            btnSatis.TabIndex = 95;
            btnSatis.Text = "Satış";
            btnSatis.UseVisualStyleBackColor = false;
            btnSatis.Click += btnSatis_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSoyadi);
            groupBox1.Controls.Add(lblTelefon);
            groupBox1.Controls.Add(lblVergiNumarasi);
            groupBox1.Controls.Add(lblAdi);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(629, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 136);
            groupBox1.TabIndex = 88;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seçilen Cari";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Location = new Point(27, 97);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(0, 23);
            lblSoyadi.TabIndex = 96;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(371, 97);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(0, 23);
            lblTelefon.TabIndex = 96;
            // 
            // lblVergiNumarasi
            // 
            lblVergiNumarasi.AutoSize = true;
            lblVergiNumarasi.Location = new Point(371, 42);
            lblVergiNumarasi.Name = "lblVergiNumarasi";
            lblVergiNumarasi.Size = new Size(0, 23);
            lblVergiNumarasi.TabIndex = 96;
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(27, 42);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(0, 23);
            lblAdi.TabIndex = 96;
            // 
            // textParcaAra
            // 
            textParcaAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textParcaAra.Location = new Point(73, 377);
            textParcaAra.Name = "textParcaAra";
            textParcaAra.Size = new Size(245, 27);
            textParcaAra.TabIndex = 87;
            textParcaAra.TextChanged += textParcaAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 376);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 86;
            label1.Text = "Ara:";
            // 
            // dGridSepet
            // 
            dGridSepet.AllowUserToAddRows = false;
            dGridSepet.AllowUserToDeleteRows = false;
            dGridSepet.AllowUserToResizeColumns = false;
            dGridSepet.AllowUserToResizeRows = false;
            dGridSepet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridSepet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridSepet.BackgroundColor = Color.White;
            dGridSepet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridSepet.Columns.AddRange(new DataGridViewColumn[] { sParcaID, sParcaAd, sMarka, sAdet, sFiyat, sKdv });
            dGridSepet.EnableHeadersVisualStyles = false;
            dGridSepet.Location = new Point(16, 43);
            dGridSepet.Name = "dGridSepet";
            dGridSepet.ReadOnly = true;
            dGridSepet.RowHeadersVisible = false;
            dGridSepet.RowHeadersWidth = 40;
            dGridSepet.RowTemplate.Height = 29;
            dGridSepet.RowTemplate.ReadOnly = true;
            dGridSepet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridSepet.Size = new Size(607, 291);
            dGridSepet.TabIndex = 98;
            // 
            // sParcaID
            // 
            sParcaID.FillWeight = 65.393425F;
            sParcaID.HeaderText = "Parça ID";
            sParcaID.MinimumWidth = 6;
            sParcaID.Name = "sParcaID";
            sParcaID.ReadOnly = true;
            // 
            // sParcaAd
            // 
            sParcaAd.FillWeight = 65.393425F;
            sParcaAd.HeaderText = "Parça Adı";
            sParcaAd.MinimumWidth = 6;
            sParcaAd.Name = "sParcaAd";
            sParcaAd.ReadOnly = true;
            // 
            // sMarka
            // 
            sMarka.FillWeight = 65.393425F;
            sMarka.HeaderText = "Marka";
            sMarka.MinimumWidth = 6;
            sMarka.Name = "sMarka";
            sMarka.ReadOnly = true;
            // 
            // sAdet
            // 
            sAdet.FillWeight = 65.393425F;
            sAdet.HeaderText = "Adet";
            sAdet.MinimumWidth = 6;
            sAdet.Name = "sAdet";
            sAdet.ReadOnly = true;
            // 
            // sFiyat
            // 
            sFiyat.FillWeight = 65.393425F;
            sFiyat.HeaderText = "Fiyat";
            sFiyat.MinimumWidth = 6;
            sFiyat.Name = "sFiyat";
            sFiyat.ReadOnly = true;
            // 
            // sKdv
            // 
            sKdv.FillWeight = 65.393425F;
            sKdv.HeaderText = "KDV Tutarı";
            sKdv.MinimumWidth = 6;
            sKdv.Name = "sKdv";
            sKdv.ReadOnly = true;
            // 
            // groupBoxMusteri
            // 
            groupBoxMusteri.BackColor = Color.White;
            groupBoxMusteri.Controls.Add(btnSec);
            groupBoxMusteri.Controls.Add(txtMusteriAra);
            groupBoxMusteri.Controls.Add(label2);
            groupBoxMusteri.Controls.Add(dGridMusteri);
            groupBoxMusteri.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxMusteri.Location = new Point(115, 115);
            groupBoxMusteri.Name = "groupBoxMusteri";
            groupBoxMusteri.Size = new Size(1100, 485);
            groupBoxMusteri.TabIndex = 84;
            groupBoxMusteri.TabStop = false;
            groupBoxMusteri.Text = "Cari Seçimi";
            // 
            // btnSec
            // 
            btnSec.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnSec.BackColor = Color.FromArgb(36, 46, 56);
            btnSec.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSec.ForeColor = Color.White;
            btnSec.Location = new Point(895, 47);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(179, 41);
            btnSec.TabIndex = 86;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = false;
            btnSec.Click += btnSec_Click;
            // 
            // txtMusteriAra
            // 
            txtMusteriAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtMusteriAra.Location = new Point(75, 57);
            txtMusteriAra.Name = "txtMusteriAra";
            txtMusteriAra.Size = new Size(245, 31);
            txtMusteriAra.TabIndex = 85;
            txtMusteriAra.TextChanged += txtAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 63);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 84;
            label2.Text = "Ara:";
            // 
            // dGridMusteri
            // 
            dGridMusteri.AllowUserToAddRows = false;
            dGridMusteri.AllowUserToDeleteRows = false;
            dGridMusteri.AllowUserToResizeColumns = false;
            dGridMusteri.AllowUserToResizeRows = false;
            dGridMusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridMusteri.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridMusteri.BackgroundColor = SystemColors.ButtonHighlight;
            dGridMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridMusteri.Columns.AddRange(new DataGridViewColumn[] { MusteriID, MusteriAd, MusteriSoyad, Telefon, VergiNo });
            dGridMusteri.Location = new Point(23, 94);
            dGridMusteri.Name = "dGridMusteri";
            dGridMusteri.ReadOnly = true;
            dGridMusteri.RowHeadersVisible = false;
            dGridMusteri.RowHeadersWidth = 40;
            dGridMusteri.RowTemplate.Height = 29;
            dGridMusteri.RowTemplate.ReadOnly = true;
            dGridMusteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridMusteri.Size = new Size(1051, 358);
            dGridMusteri.TabIndex = 83;
            // 
            // MusteriID
            // 
            MusteriID.HeaderText = "Müşteri ID";
            MusteriID.MinimumWidth = 6;
            MusteriID.Name = "MusteriID";
            MusteriID.ReadOnly = true;
            // 
            // MusteriAd
            // 
            MusteriAd.HeaderText = "Müşteri Adı";
            MusteriAd.MinimumWidth = 6;
            MusteriAd.Name = "MusteriAd";
            MusteriAd.ReadOnly = true;
            // 
            // MusteriSoyad
            // 
            MusteriSoyad.HeaderText = "Müşteri Soyadı";
            MusteriSoyad.MinimumWidth = 6;
            MusteriSoyad.Name = "MusteriSoyad";
            MusteriSoyad.ReadOnly = true;
            // 
            // Telefon
            // 
            Telefon.HeaderText = "Telefon";
            Telefon.MinimumWidth = 6;
            Telefon.Name = "Telefon";
            Telefon.ReadOnly = true;
            // 
            // VergiNo
            // 
            VergiNo.HeaderText = "Vergi Numarası";
            VergiNo.MinimumWidth = 6;
            VergiNo.Name = "VergiNo";
            VergiNo.ReadOnly = true;
            // 
            // Satis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelSatis);
            Controls.Add(groupBoxMusteri);
            Name = "Satis";
            Size = new Size(1330, 715);
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).EndInit();
            panelSatis.ResumeLayout(false);
            panelSatis.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAdet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGridSepet).EndInit();
            groupBoxMusteri.ResumeLayout(false);
            groupBoxMusteri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dGridMusteri).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGridParcalar;
        private Panel panelSatis;
        private GroupBox groupBoxMusteri;
        private Button btnSec;
        private TextBox txtMusteriAra;
        private Label label2;
        private DataGridView dGridMusteri;
        private TextBox textParcaAra;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnMusteriDegistir;
        private Label lblSoyadi;
        private Label lblTelefon;
        private Label lblVergiNumarasi;
        private Label lblAdi;
        private NumericUpDown numericAdet;
        private Button btnEkle;
        private Button btnSatis;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private DataGridView dGridSepet;
        private Label lblToplamTutar;
        private DataGridViewTextBoxColumn ParcaID;
        private DataGridViewTextBoxColumn AracBilgisi;
        private DataGridViewTextBoxColumn ParcaAd;
        private DataGridViewTextBoxColumn Marka;
        private DataGridViewTextBoxColumn Stok;
        private DataGridViewTextBoxColumn SatisFiyati;
        private DataGridViewTextBoxColumn KDVTutari;
        private Button btnSil;
        private DataGridViewTextBoxColumn MusteriID;
        private DataGridViewTextBoxColumn MusteriAd;
        private DataGridViewTextBoxColumn MusteriSoyad;
        private DataGridViewTextBoxColumn Telefon;
        private DataGridViewTextBoxColumn VergiNo;
        private DataGridViewTextBoxColumn sParcaID;
        private DataGridViewTextBoxColumn sParcaAd;
        private DataGridViewTextBoxColumn sMarka;
        private DataGridViewTextBoxColumn sAdet;
        private DataGridViewTextBoxColumn sFiyat;
        private DataGridViewTextBoxColumn sKdv;
        private ComboBox cBovOdeme;
    }
}
