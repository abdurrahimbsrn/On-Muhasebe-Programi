namespace ParcaMuhasebe.User_Controls
{
    partial class AnaSayfaControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dGridFatura = new DataGridView();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            Column25 = new DataGridViewTextBoxColumn();
            label20 = new Label();
            dGridAraclar = new DataGridView();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            label19 = new Label();
            label18 = new Label();
            Column11 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dGridParcalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dGridFatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridAraclar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).BeginInit();
            SuspendLayout();
            // 
            // dGridFatura
            // 
            dGridFatura.AllowUserToAddRows = false;
            dGridFatura.AllowUserToDeleteRows = false;
            dGridFatura.AllowUserToResizeColumns = false;
            dGridFatura.AllowUserToResizeRows = false;
            dGridFatura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridFatura.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridFatura.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridFatura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridFatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridFatura.Columns.AddRange(new DataGridViewColumn[] { Column18, Column19, Column20, Column21, Column22, Column23, Column24, Column25 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dGridFatura.DefaultCellStyle = dataGridViewCellStyle2;
            dGridFatura.EnableHeadersVisualStyles = false;
            dGridFatura.Location = new Point(26, 301);
            dGridFatura.Name = "dGridFatura";
            dGridFatura.ReadOnly = true;
            dGridFatura.RowHeadersVisible = false;
            dGridFatura.RowHeadersWidth = 40;
            dGridFatura.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dGridFatura.RowTemplate.Height = 29;
            dGridFatura.RowTemplate.ReadOnly = true;
            dGridFatura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridFatura.Size = new Size(1275, 422);
            dGridFatura.TabIndex = 25;
            // 
            // Column18
            // 
            Column18.FillWeight = 61.1153374F;
            Column18.HeaderText = "FaturaID";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.FillWeight = 61.1153374F;
            Column19.HeaderText = "Vergi Numarası";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            // 
            // Column20
            // 
            Column20.FillWeight = 61.1153374F;
            Column20.HeaderText = "Müşteri Adı Soyadı";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            // 
            // Column21
            // 
            Column21.FillWeight = 372.192566F;
            Column21.HeaderText = "Parça Bilgileri";
            Column21.MinimumWidth = 90;
            Column21.Name = "Column21";
            Column21.ReadOnly = true;
            // 
            // Column22
            // 
            Column22.FillWeight = 61.1153374F;
            Column22.HeaderText = "Toplam Fiyat";
            Column22.MinimumWidth = 6;
            Column22.Name = "Column22";
            Column22.ReadOnly = true;
            // 
            // Column23
            // 
            Column23.FillWeight = 61.1153374F;
            Column23.HeaderText = "KDV Tutarı";
            Column23.MinimumWidth = 6;
            Column23.Name = "Column23";
            Column23.ReadOnly = true;
            // 
            // Column24
            // 
            Column24.FillWeight = 61.1153374F;
            Column24.HeaderText = "Ödeme Yöntemi";
            Column24.MinimumWidth = 6;
            Column24.Name = "Column24";
            Column24.ReadOnly = true;
            // 
            // Column25
            // 
            Column25.FillWeight = 61.1153374F;
            Column25.HeaderText = "Fatura Tarihi";
            Column25.MinimumWidth = 6;
            Column25.Name = "Column25";
            Column25.ReadOnly = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(26, 268);
            label20.Name = "label20";
            label20.Size = new Size(217, 28);
            label20.TabIndex = 24;
            label20.Text = "Son Kesilen Faturalar:";
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
            dGridAraclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridAraclar.Columns.AddRange(new DataGridViewColumn[] { Column12, Column13, Column14, Column15, Column16, Column17 });
            dGridAraclar.DefaultCellStyle = dataGridViewCellStyle2;
            dGridAraclar.Enabled = false;
            dGridAraclar.EnableHeadersVisualStyles = false;
            dGridAraclar.Location = new Point(26, 177);
            dGridAraclar.Name = "dGridAraclar";
            dGridAraclar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dGridAraclar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dGridAraclar.RowHeadersVisible = false;
            dGridAraclar.RowHeadersWidth = 40;
            dGridAraclar.RowTemplate.Height = 29;
            dGridAraclar.RowTemplate.ReadOnly = true;
            dGridAraclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridAraclar.Size = new Size(1275, 77);
            dGridAraclar.TabIndex = 22;
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
            // Column14
            // 
            Column14.HeaderText = "Üretim Yılı";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // Column15
            // 
            Column15.HeaderText = "Model";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(26, 146);
            label19.Name = "label19";
            label19.Size = new Size(207, 28);
            label19.TabIndex = 23;
            label19.Text = "Son Eklenen Araçlar:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(26, 7);
            label18.Name = "label18";
            label18.Size = new Size(216, 28);
            label18.TabIndex = 20;
            label18.Text = "Son Eklenen Parçalar:";
            // 
            // Column11
            // 
            Column11.HeaderText = "Ekleme Tarihi";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.HeaderText = "KDV Tutarı";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.HeaderText = "KDV Oranı";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.HeaderText = "Satış Fiyatı";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Alış Fiyatı";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Stok";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Marka";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Parça Adı";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Araç Modeli";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Araç Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Parça ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dGridParcalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dGridParcalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridParcalar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dGridParcalar.DefaultCellStyle = dataGridViewCellStyle5;
            dGridParcalar.Enabled = false;
            dGridParcalar.EnableHeadersVisualStyles = false;
            dGridParcalar.Location = new Point(26, 38);
            dGridParcalar.Name = "dGridParcalar";
            dGridParcalar.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dGridParcalar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dGridParcalar.RowHeadersVisible = false;
            dGridParcalar.RowHeadersWidth = 40;
            dGridParcalar.RowTemplate.Height = 29;
            dGridParcalar.RowTemplate.ReadOnly = true;
            dGridParcalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridParcalar.Size = new Size(1275, 100);
            dGridParcalar.TabIndex = 21;
            // 
            // AnaSayfaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dGridFatura);
            Controls.Add(label20);
            Controls.Add(dGridAraclar);
            Controls.Add(label19);
            Controls.Add(dGridParcalar);
            Controls.Add(label18);
            Name = "AnaSayfaControl";
            Size = new Size(1330, 715);
            ((System.ComponentModel.ISupportInitialize)dGridFatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridAraclar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridParcalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGridFatura;
        private Label label20;
        private DataGridView dGridAraclar;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private Label label19;
        private Label label18;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dGridParcalar;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
    }
}
