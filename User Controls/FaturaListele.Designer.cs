namespace ParcaMuhasebe.User_Controls
{
    partial class FaturaListele
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
            txtAra = new TextBox();
            label2 = new Label();
            btnAktar = new Button();
            dGridFatura = new DataGridView();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            Column25 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dGridFatura).BeginInit();
            SuspendLayout();
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAra.Location = new Point(72, 25);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(245, 27);
            txtAra.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 30);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 89;
            label2.Text = "Ara:";
            // 
            // btnAktar
            // 
            btnAktar.Anchor = AnchorStyles.Top;
            btnAktar.BackColor = Color.FromArgb(36, 46, 56);
            btnAktar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAktar.ForeColor = Color.White;
            btnAktar.Location = new Point(1100, 12);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(204, 44);
            btnAktar.TabIndex = 94;
            btnAktar.Text = "Aktar";
            btnAktar.UseVisualStyleBackColor = false;
            btnAktar.Click += btnAktar_Click;
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
            dGridFatura.Enabled = false;
            dGridFatura.EnableHeadersVisualStyles = false;
            dGridFatura.Location = new Point(29, 62);
            dGridFatura.Name = "dGridFatura";
            dGridFatura.ReadOnly = true;
            dGridFatura.RowHeadersVisible = false;
            dGridFatura.RowHeadersWidth = 40;
            dGridFatura.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dGridFatura.RowTemplate.Height = 29;
            dGridFatura.RowTemplate.ReadOnly = true;
            dGridFatura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridFatura.Size = new Size(1275, 650);
            dGridFatura.TabIndex = 95;
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
            // FaturaListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dGridFatura);
            Controls.Add(btnAktar);
            Controls.Add(txtAra);
            Controls.Add(label2);
            Name = "FaturaListele";
            Size = new Size(1330, 715);
            ((System.ComponentModel.ISupportInitialize)dGridFatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAra;
        private Label label2;
        private Button btnAktar;
        private DataGridView dGridFatura;
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
