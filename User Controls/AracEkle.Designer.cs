namespace ParcaMuhasebe.User_Controls
{
    partial class AracEkle
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
            btnSil = new Button();
            btnAktar = new Button();
            txtAra = new TextBox();
            label11 = new Label();
            btnKaydet = new Button();
            txtAracID = new TextBox();
            label14 = new Label();
            txtAracMarka = new TextBox();
            label13 = new Label();
            txtModel = new TextBox();
            label1 = new Label();
            txtKasa = new TextBox();
            label17 = new Label();
            txtMotor = new TextBox();
            label16 = new Label();
            numericUretimYili = new NumericUpDown();
            dGridAraclar = new DataGridView();
            label2 = new Label();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUretimYili).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridAraclar).BeginInit();
            SuspendLayout();
            // 
            // labelSecilenArac
            // 
            labelSecilenArac.AutoSize = true;
            labelSecilenArac.Location = new Point(234, 154);
            labelSecilenArac.Name = "labelSecilenArac";
            labelSecilenArac.Size = new Size(0, 20);
            labelSecilenArac.TabIndex = 76;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.Brown;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(1134, 249);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(169, 42);
            btnSil.TabIndex = 69;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnAktar
            // 
            btnAktar.Anchor = AnchorStyles.Top;
            btnAktar.BackColor = Color.FromArgb(36, 46, 56);
            btnAktar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAktar.ForeColor = Color.White;
            btnAktar.Location = new Point(939, 251);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(189, 42);
            btnAktar.TabIndex = 71;
            btnAktar.Text = "Aktar";
            btnAktar.UseVisualStyleBackColor = false;
            btnAktar.Click += btnAktar_Click;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAra.Location = new Point(83, 267);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(245, 27);
            txtAra.TabIndex = 68;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(476, 89);
            label11.Name = "label11";
            label11.Size = new Size(105, 25);
            label11.TabIndex = 67;
            label11.Text = "Üretim Yılı";
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top;
            btnKaydet.BackColor = Color.FromArgb(36, 46, 56);
            btnKaydet.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(1027, 153);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(276, 69);
            btnKaydet.TabIndex = 66;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAracID
            // 
            txtAracID.Location = new Point(131, 27);
            txtAracID.Name = "txtAracID";
            txtAracID.ReadOnly = true;
            txtAracID.Size = new Size(197, 27);
            txtAracID.TabIndex = 59;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(21, 26);
            label14.Name = "label14";
            label14.Size = new Size(77, 25);
            label14.TabIndex = 63;
            label14.Text = "Araç ID";
            // 
            // txtAracMarka
            // 
            txtAracMarka.Location = new Point(131, 88);
            txtAracMarka.Name = "txtAracMarka";
            txtAracMarka.Size = new Size(197, 27);
            txtAracMarka.TabIndex = 60;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(21, 90);
            label13.Name = "label13";
            label13.Size = new Size(69, 25);
            label13.TabIndex = 64;
            label13.Text = "Marka";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(587, 26);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(197, 27);
            txtModel.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 65;
            label1.Text = "Model";
            // 
            // txtKasa
            // 
            txtKasa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtKasa.Location = new Point(1089, 18);
            txtKasa.Name = "txtKasa";
            txtKasa.Size = new Size(214, 27);
            txtKasa.TabIndex = 52;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(978, 17);
            label17.Name = "label17";
            label17.Size = new Size(52, 25);
            label17.TabIndex = 55;
            label17.Text = "Kasa";
            // 
            // txtMotor
            // 
            txtMotor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtMotor.Location = new Point(1089, 91);
            txtMotor.Name = "txtMotor";
            txtMotor.Size = new Size(214, 27);
            txtMotor.TabIndex = 53;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(978, 93);
            label16.Name = "label16";
            label16.Size = new Size(69, 25);
            label16.TabIndex = 57;
            label16.Text = "Motor";
            // 
            // numericUretimYili
            // 
            numericUretimYili.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericUretimYili.Location = new Point(680, 100);
            numericUretimYili.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUretimYili.Minimum = new decimal(new int[] { 1980, 0, 0, 0 });
            numericUretimYili.Name = "numericUretimYili";
            numericUretimYili.Size = new Size(133, 30);
            numericUretimYili.TabIndex = 78;
            numericUretimYili.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            // 
            // dGridAraclar
            // 
            dGridAraclar.AllowUserToAddRows = false;
            dGridAraclar.AllowUserToDeleteRows = false;
            dGridAraclar.AllowUserToResizeColumns = false;
            dGridAraclar.AllowUserToResizeRows = false;
            dGridAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridAraclar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridAraclar.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridAraclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridAraclar.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column15, Column14, Column16, Column17 });
            dGridAraclar.EnableHeadersVisualStyles = false;
            dGridAraclar.Location = new Point(28, 299);
            dGridAraclar.Name = "dGridAraclar";
            dGridAraclar.ReadOnly = true;
            dGridAraclar.RowHeadersVisible = false;
            dGridAraclar.RowHeadersWidth = 40;
            dGridAraclar.RowTemplate.Height = 29;
            dGridAraclar.RowTemplate.ReadOnly = true;
            dGridAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridAraclar.Size = new Size(1288, 385);
            dGridAraclar.TabIndex = 79;
            dGridAraclar.CellClick += dGridAraclar_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 266);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 64;
            label2.Text = "Ara:";
            // 
            // Column12
            // 
            Column12.HeaderText = "Araç ID";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.HeaderText = "Marka";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.HeaderText = "Model";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.HeaderText = "Üretim Yılı";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column16
            // 
            Column16.HeaderText = "Kasa";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            // 
            // Column17
            // 
            Column17.HeaderText = "Motor";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            // 
            // AracEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dGridAraclar);
            Controls.Add(numericUretimYili);
            Controls.Add(labelSecilenArac);
            Controls.Add(btnSil);
            Controls.Add(btnAktar);
            Controls.Add(txtAra);
            Controls.Add(label11);
            Controls.Add(btnKaydet);
            Controls.Add(txtAracID);
            Controls.Add(label14);
            Controls.Add(txtAracMarka);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtKasa);
            Controls.Add(label17);
            Controls.Add(txtMotor);
            Controls.Add(label16);
            Name = "AracEkle";
            Size = new Size(1330, 715);
            Load += AracEkle_Load;
            ((System.ComponentModel.ISupportInitialize)numericUretimYili).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSecilenArac;
        private Button btnSil;
        private Button btnAktar;
        private TextBox txtAra;
        private Label label11;
        private Button btnKaydet;
        private TextBox txtAracID;
        private Label label14;
        private TextBox txtAracMarka;
        private Label label13;
        private TextBox txtModel;
        private Label label1;
        private TextBox txtKasa;
        private Label label17;
        private TextBox txtMotor;
        private Label label16;
        private NumericUpDown numericUretimYili;
        private DataGridView dGridAraclar;
        private Label label2;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
    }
}
