namespace ParcaMuhasebe.User_Controls
{
    partial class CariEkle
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
            labelSecilenArac = new Label();
            dGridMusteri = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnSil = new Button();
            label11 = new Label();
            btnKaydet = new Button();
            txtMusteriID = new TextBox();
            label14 = new Label();
            txtAdi = new TextBox();
            label13 = new Label();
            txtSoyadi = new TextBox();
            label1 = new Label();
            txtVergiNumarasi = new TextBox();
            label17 = new Label();
            txtTelefon = new MaskedTextBox();
            txtAra = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGridMusteri).BeginInit();
            SuspendLayout();
            // 
            // labelSecilenArac
            // 
            labelSecilenArac.AutoSize = true;
            labelSecilenArac.Location = new Point(237, 97);
            labelSecilenArac.Name = "labelSecilenArac";
            labelSecilenArac.Size = new Size(0, 20);
            labelSecilenArac.TabIndex = 76;
            // 
            // dGridMusteri
            // 
            dGridMusteri.AllowUserToAddRows = false;
            dGridMusteri.AllowUserToDeleteRows = false;
            dGridMusteri.AllowUserToResizeColumns = false;
            dGridMusteri.AllowUserToResizeRows = false;
            dGridMusteri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dGridMusteri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridMusteri.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridMusteri.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridMusteri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridMusteri.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dGridMusteri.EnableHeadersVisualStyles = false;
            dGridMusteri.Location = new Point(31, 242);
            dGridMusteri.Name = "dGridMusteri";
            dGridMusteri.ReadOnly = true;
            dGridMusteri.RowHeadersVisible = false;
            dGridMusteri.RowHeadersWidth = 40;
            dGridMusteri.RowTemplate.Height = 29;
            dGridMusteri.RowTemplate.ReadOnly = true;
            dGridMusteri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridMusteri.Size = new Size(1275, 458);
            dGridMusteri.TabIndex = 74;
            dGridMusteri.CellClick += dGridMusteri_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Müşteri ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Müşteri Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Müşteri Soyadı";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefon";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Vergi Numarası";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.Brown;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(1137, 192);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(169, 41);
            btnSil.TabIndex = 69;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(487, 87);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 67;
            label11.Text = "Telefon";
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top;
            btnKaydet.BackColor = Color.FromArgb(36, 46, 56);
            btnKaydet.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(1027, 90);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(276, 63);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtMusteriID
            // 
            txtMusteriID.Location = new Point(142, 28);
            txtMusteriID.Name = "txtMusteriID";
            txtMusteriID.ReadOnly = true;
            txtMusteriID.Size = new Size(197, 27);
            txtMusteriID.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(31, 28);
            label14.Name = "label14";
            label14.Size = new Size(105, 25);
            label14.TabIndex = 63;
            label14.Text = "Müşteri ID";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(142, 88);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(197, 27);
            txtAdi.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(29, 90);
            label13.Name = "label13";
            label13.Size = new Size(42, 25);
            label13.TabIndex = 64;
            label13.Text = "Adı";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(587, 30);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(197, 27);
            txtSoyadi.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(492, 29);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 65;
            label1.Text = "Soyadı";
            // 
            // txtVergiNumarasi
            // 
            txtVergiNumarasi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtVergiNumarasi.Location = new Point(1089, 30);
            txtVergiNumarasi.MaxLength = 10;
            txtVergiNumarasi.Name = "txtVergiNumarasi";
            txtVergiNumarasi.Size = new Size(214, 27);
            txtVergiNumarasi.TabIndex = 4;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(934, 32);
            label17.Name = "label17";
            label17.Size = new Size(149, 25);
            label17.TabIndex = 55;
            label17.Text = "Vergi Numarası";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(587, 88);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(197, 27);
            txtTelefon.TabIndex = 3;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAra.Location = new Point(94, 209);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(245, 27);
            txtAra.TabIndex = 79;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(40, 208);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 78;
            label2.Text = "Ara:";
            // 
            // CariEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtAra);
            Controls.Add(label2);
            Controls.Add(txtTelefon);
            Controls.Add(labelSecilenArac);
            Controls.Add(dGridMusteri);
            Controls.Add(btnSil);
            Controls.Add(label11);
            Controls.Add(btnKaydet);
            Controls.Add(txtMusteriID);
            Controls.Add(label14);
            Controls.Add(txtAdi);
            Controls.Add(label13);
            Controls.Add(txtSoyadi);
            Controls.Add(label1);
            Controls.Add(txtVergiNumarasi);
            Controls.Add(label17);
            Name = "CariEkle";
            Size = new Size(1330, 715);
            ((System.ComponentModel.ISupportInitialize)dGridMusteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecilenArac;
        private DataGridView dGridMusteri;
        private Button btnSil;
        private Label label11;
        private Button btnKaydet;
        private TextBox txtMusteriID;
        private Label label14;
        private TextBox txtAdi;
        private Label label13;
        private TextBox txtSoyadi;
        private Label label1;
        private TextBox txtVergiNumarasi;
        private Label label17;
        public MaskedTextBox txtTelefon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtAra;
        private Label label2;
    }
}
