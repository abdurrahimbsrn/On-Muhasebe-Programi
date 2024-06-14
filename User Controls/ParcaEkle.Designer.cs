namespace ParcaMuhasebe.User_Controls
{
    partial class ParcaEkle
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnKaydet = new Button();
            label14 = new Label();
            txtParcaAdi = new TextBox();
            label13 = new Label();
            txtMarka = new TextBox();
            label1 = new Label();
            txtAlisFiyat = new TextBox();
            label17 = new Label();
            txtSatisFiyati = new TextBox();
            label16 = new Label();
            txtKDVOrani = new TextBox();
            label15 = new Label();
            label11 = new Label();
            btnSil = new Button();
            btnAktar = new Button();
            txtAra = new TextBox();
            dGridParcalar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            treeViewArac = new TreeView();
            labelSecilenArac = new Label();
            txtParcaID = new TextBox();
            numericStok = new NumericUpDown();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top;
            btnKaydet.BackColor = Color.FromArgb(36, 46, 56);
            btnKaydet.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(1017, 265);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(276, 69);
            btnKaydet.TabIndex = 41;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(21, 33);
            label14.Name = "label14";
            label14.Size = new Size(86, 25);
            label14.TabIndex = 38;
            label14.Text = "Parça ID";
            // 
            // txtParcaAdi
            // 
            txtParcaAdi.Location = new Point(121, 93);
            txtParcaAdi.Name = "txtParcaAdi";
            txtParcaAdi.Size = new Size(197, 27);
            txtParcaAdi.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(19, 95);
            label13.Name = "label13";
            label13.Size = new Size(96, 25);
            label13.TabIndex = 39;
            label13.Text = "Parça Adı";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(120, 168);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(197, 27);
            txtMarka.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 170);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 40;
            label1.Text = "Marka";
            // 
            // txtAlisFiyat
            // 
            txtAlisFiyat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtAlisFiyat.Location = new Point(1079, 44);
            txtAlisFiyat.Name = "txtAlisFiyat";
            txtAlisFiyat.Size = new Size(214, 27);
            txtAlisFiyat.TabIndex = 28;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(968, 43);
            label17.Name = "label17";
            label17.Size = new Size(95, 25);
            label17.TabIndex = 31;
            label17.Text = "Alış Fiyatı";
            // 
            // txtSatisFiyati
            // 
            txtSatisFiyati.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSatisFiyati.Location = new Point(1079, 117);
            txtSatisFiyati.Name = "txtSatisFiyati";
            txtSatisFiyati.Size = new Size(214, 27);
            txtSatisFiyati.TabIndex = 29;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(968, 119);
            label16.Name = "label16";
            label16.Size = new Size(105, 25);
            label16.TabIndex = 32;
            label16.Text = "Satış Fiyatı";
            // 
            // txtKDVOrani
            // 
            txtKDVOrani.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtKDVOrani.Location = new Point(1079, 192);
            txtKDVOrani.Name = "txtKDVOrani";
            txtKDVOrani.Size = new Size(214, 27);
            txtKDVOrani.TabIndex = 30;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(968, 192);
            label15.Name = "label15";
            label15.Size = new Size(105, 25);
            label15.TabIndex = 33;
            label15.Text = "KDV Oranı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(21, 404);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 42;
            label11.Text = "Ara:";
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top;
            btnSil.BackColor = Color.Brown;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(1124, 385);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(169, 42);
            btnSil.TabIndex = 44;
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
            btnAktar.Location = new Point(929, 385);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(189, 42);
            btnAktar.TabIndex = 46;
            btnAktar.Text = "Aktar";
            btnAktar.UseVisualStyleBackColor = false;
            btnAktar.Click += btnAktar_Click;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAra.Location = new Point(75, 402);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(196, 27);
            txtAra.TabIndex = 43;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // dGridParcalar
            // 
            dGridParcalar.AllowUserToAddRows = false;
            dGridParcalar.AllowUserToDeleteRows = false;
            dGridParcalar.AllowUserToResizeColumns = false;
            dGridParcalar.AllowUserToResizeRows = false;
            dGridParcalar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dGridParcalar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dGridParcalar.EnableHeadersVisualStyles = false;
            dGridParcalar.Location = new Point(18, 435);
            dGridParcalar.Name = "dGridParcalar";
            dGridParcalar.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dGridParcalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dGridParcalar.RowHeadersVisible = false;
            dGridParcalar.RowHeadersWidth = 40;
            dGridParcalar.RowTemplate.Height = 29;
            dGridParcalar.RowTemplate.ReadOnly = true;
            dGridParcalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridParcalar.Size = new Size(1275, 288);
            dGridParcalar.TabIndex = 49;
            dGridParcalar.CellClick += dGridParcalar_CellClick;
            dGridParcalar.CellFormatting += dGridParcalar_CellFormatting;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Parça ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Araç Adı";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Araç Modeli";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Parça Adı";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Marka";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Stok";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Alış Fiyatı";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Satış Fiyatı";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "KDV Oranı";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "KDV Tutarı";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Ekleme Tarihi";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(459, 33);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 31;
            label2.Text = "Araç Seçimi";
            // 
            // treeViewArac
            // 
            treeViewArac.Location = new Point(459, 61);
            treeViewArac.Name = "treeViewArac";
            treeViewArac.Size = new Size(438, 204);
            treeViewArac.TabIndex = 50;
            treeViewArac.AfterSelect += treeViewArac_AfterSelect;
            // 
            // labelSecilenArac
            // 
            labelSecilenArac.AutoSize = true;
            labelSecilenArac.Location = new Point(459, 290);
            labelSecilenArac.Name = "labelSecilenArac";
            labelSecilenArac.Size = new Size(0, 20);
            labelSecilenArac.TabIndex = 51;
            // 
            // txtParcaID
            // 
            txtParcaID.Location = new Point(120, 31);
            txtParcaID.Name = "txtParcaID";
            txtParcaID.ReadOnly = true;
            txtParcaID.Size = new Size(197, 27);
            txtParcaID.TabIndex = 34;
            // 
            // numericStok
            // 
            numericStok.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numericStok.Location = new Point(124, 25);
            numericStok.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericStok.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericStok.Name = "numericStok";
            numericStok.Size = new Size(138, 30);
            numericStok.TabIndex = 90;
            numericStok.TextAlign = HorizontalAlignment.Center;
            numericStok.Value = new decimal(new int[] { 999, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 40;
            label3.Text = "Stok";
            // 
            // panel1
            // 
            panel1.Controls.Add(numericStok);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(18, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 62);
            panel1.TabIndex = 91;
            // 
            // ParcaEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(labelSecilenArac);
            Controls.Add(treeViewArac);
            Controls.Add(dGridParcalar);
            Controls.Add(btnSil);
            Controls.Add(btnAktar);
            Controls.Add(txtAra);
            Controls.Add(label11);
            Controls.Add(btnKaydet);
            Controls.Add(txtParcaID);
            Controls.Add(label14);
            Controls.Add(txtParcaAdi);
            Controls.Add(label13);
            Controls.Add(txtMarka);
            Controls.Add(label1);
            Controls.Add(txtAlisFiyat);
            Controls.Add(label2);
            Controls.Add(label17);
            Controls.Add(txtSatisFiyati);
            Controls.Add(label16);
            Controls.Add(txtKDVOrani);
            Controls.Add(label15);
            Name = "ParcaEkle";
            Size = new Size(1330, 715);
            Load += ParcaEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericStok).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label14;
        private TextBox txtParcaAdi;
        private Label label13;
        private TextBox txtMarka;
        private Label label1;
        private TextBox txtAlisFiyat;
        private Label label17;
        private TextBox txtSatisFiyati;
        private Label label16;
        private TextBox txtKDVOrani;
        private Label label15;
        private Label label11;
        private Button btnSil;
        private Button btnAktar;
        private TextBox txtAra;
        private DataGridView dGridParcalar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Label label2;
        private TreeView treeViewArac;
        private Label labelSecilenArac;
        private TextBox txtParcaID;
        private NumericUpDown numericStok;
        private Label label3;
        private Panel panel1;
    }
}
