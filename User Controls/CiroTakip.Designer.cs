namespace ParcaMuhasebe.User_Controls
{
    partial class CiroTakip
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
            dGridCiro = new DataGridView();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            Column23 = new DataGridViewTextBoxColumn();
            Column24 = new DataGridViewTextBoxColumn();
            Column25 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel6 = new Panel();
            groupBox6 = new GroupBox();
            lblKdv = new Label();
            lbl = new Label();
            panel5 = new Panel();
            groupBox5 = new GroupBox();
            lblKar = new Label();
            label9 = new Label();
            panel4 = new Panel();
            groupBox4 = new GroupBox();
            lblKesilenFatura = new Label();
            label6 = new Label();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            lblMaliyet = new Label();
            labe = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lblSatilanParca = new Label();
            label12 = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            lblHasilat = new Label();
            label3 = new Label();
            btnAktar = new Button();
            rBtnGunluk = new RadioButton();
            rBtnHaftalik = new RadioButton();
            rBtnAylik = new RadioButton();
            rBtnYillik = new RadioButton();
            rBtnTum = new RadioButton();
            dateTimeAlt = new DateTimePicker();
            label13 = new Label();
            dateTimeUst = new DateTimePicker();
            label14 = new Label();
            btnListele = new Button();
            panel7 = new Panel();
            txtAra = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dGridCiro).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel6.SuspendLayout();
            groupBox6.SuspendLayout();
            panel5.SuspendLayout();
            groupBox5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // dGridCiro
            // 
            dGridCiro.AllowUserToAddRows = false;
            dGridCiro.AllowUserToDeleteRows = false;
            dGridCiro.AllowUserToResizeColumns = false;
            dGridCiro.AllowUserToResizeRows = false;
            dGridCiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridCiro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dGridCiro.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(36, 46, 56);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGridCiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGridCiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridCiro.Columns.AddRange(new DataGridViewColumn[] { Column18, Column19, Column21, Column20, Column22, Column23, Column24, Column25 });
            dGridCiro.EnableHeadersVisualStyles = false;
            dGridCiro.Location = new Point(15, 361);
            dGridCiro.Name = "dGridCiro";
            dGridCiro.ReadOnly = true;
            dGridCiro.RowHeadersVisible = false;
            dGridCiro.RowHeadersWidth = 40;
            dGridCiro.RowTemplate.Height = 29;
            dGridCiro.RowTemplate.ReadOnly = true;
            dGridCiro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridCiro.Size = new Size(1299, 340);
            dGridCiro.TabIndex = 26;
            // 
            // Column18
            // 
            Column18.HeaderText = "Parça ID";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            // 
            // Column19
            // 
            Column19.HeaderText = "Paraça Adı";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            // 
            // Column21
            // 
            Column21.HeaderText = "Satılan Adet";
            Column21.MinimumWidth = 6;
            Column21.Name = "Column21";
            Column21.ReadOnly = true;
            // 
            // Column20
            // 
            Column20.HeaderText = "Hasılat";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            // 
            // Column22
            // 
            Column22.HeaderText = "Maliyet";
            Column22.MinimumWidth = 6;
            Column22.Name = "Column22";
            Column22.ReadOnly = true;
            // 
            // Column23
            // 
            Column23.HeaderText = "Kar";
            Column23.MinimumWidth = 6;
            Column23.Name = "Column23";
            Column23.ReadOnly = true;
            // 
            // Column24
            // 
            Column24.HeaderText = "Toplam KDV";
            Column24.MinimumWidth = 6;
            Column24.Name = "Column24";
            Column24.ReadOnly = true;
            // 
            // Column25
            // 
            Column25.HeaderText = "Eklenme Tarihi";
            Column25.MinimumWidth = 6;
            Column25.Name = "Column25";
            Column25.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 372F));
            tableLayoutPanel1.Controls.Add(panel6, 2, 1);
            tableLayoutPanel1.Controls.Add(panel5, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(74, 79);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1186, 185);
            tableLayoutPanel1.TabIndex = 79;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox6);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(817, 95);
            panel6.Name = "panel6";
            panel6.Size = new Size(366, 87);
            panel6.TabIndex = 82;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblKdv);
            groupBox6.Controls.Add(lbl);
            groupBox6.FlatStyle = FlatStyle.Popup;
            groupBox6.ForeColor = Color.FromArgb(36, 46, 56);
            groupBox6.Location = new Point(3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(333, 64);
            groupBox6.TabIndex = 81;
            groupBox6.TabStop = false;
            // 
            // lblKdv
            // 
            lblKdv.AutoSize = true;
            lblKdv.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblKdv.Location = new Point(210, 23);
            lblKdv.Name = "lblKdv";
            lblKdv.Size = new Size(0, 32);
            lblKdv.TabIndex = 79;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.ActiveCaptionText;
            lbl.Location = new Point(6, 20);
            lbl.Name = "lbl";
            lbl.Size = new Size(166, 35);
            lbl.TabIndex = 80;
            lbl.Text = "Toplam KDV:";
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(410, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(401, 87);
            panel5.TabIndex = 82;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblKar);
            groupBox5.Controls.Add(label9);
            groupBox5.FlatStyle = FlatStyle.Popup;
            groupBox5.ForeColor = Color.FromArgb(36, 46, 56);
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(333, 64);
            groupBox5.TabIndex = 80;
            groupBox5.TabStop = false;
            // 
            // lblKar
            // 
            lblKar.AutoSize = true;
            lblKar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblKar.Location = new Point(219, 20);
            lblKar.Name = "lblKar";
            lblKar.Size = new Size(0, 32);
            lblKar.TabIndex = 79;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(6, 20);
            label9.Name = "label9";
            label9.Size = new Size(113, 35);
            label9.TabIndex = 80;
            label9.Text = "Net Kar:";
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(401, 87);
            panel4.TabIndex = 82;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblKesilenFatura);
            groupBox4.Controls.Add(label6);
            groupBox4.FlatStyle = FlatStyle.Popup;
            groupBox4.ForeColor = Color.FromArgb(36, 46, 56);
            groupBox4.Location = new Point(18, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(333, 64);
            groupBox4.TabIndex = 80;
            groupBox4.TabStop = false;
            // 
            // lblKesilenFatura
            // 
            lblKesilenFatura.AutoSize = true;
            lblKesilenFatura.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblKesilenFatura.Location = new Point(219, 20);
            lblKesilenFatura.Name = "lblKesilenFatura";
            lblKesilenFatura.Size = new Size(0, 32);
            lblKesilenFatura.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(6, 20);
            label6.Name = "label6";
            label6.Size = new Size(186, 35);
            label6.TabIndex = 80;
            label6.Text = "Kesilen Fatura:";
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(817, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 86);
            panel3.TabIndex = 82;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblMaliyet);
            groupBox3.Controls.Add(labe);
            groupBox3.Location = new Point(3, 10);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(333, 64);
            groupBox3.TabIndex = 80;
            groupBox3.TabStop = false;
            // 
            // lblMaliyet
            // 
            lblMaliyet.AutoSize = true;
            lblMaliyet.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaliyet.Location = new Point(216, 23);
            lblMaliyet.Name = "lblMaliyet";
            lblMaliyet.Size = new Size(0, 32);
            lblMaliyet.TabIndex = 79;
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.FlatStyle = FlatStyle.Popup;
            labe.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labe.ForeColor = SystemColors.ActiveCaptionText;
            labe.Location = new Point(6, 20);
            labe.Name = "labe";
            labe.Size = new Size(204, 35);
            labe.TabIndex = 80;
            labe.Text = "Toplam Maliyet:";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 86);
            panel1.TabIndex = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSatilanParca);
            groupBox1.Controls.Add(label12);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.ForeColor = Color.FromArgb(36, 46, 56);
            groupBox1.Location = new Point(18, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 64);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            // 
            // lblSatilanParca
            // 
            lblSatilanParca.AutoSize = true;
            lblSatilanParca.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatilanParca.Location = new Point(219, 20);
            lblSatilanParca.Name = "lblSatilanParca";
            lblSatilanParca.Size = new Size(0, 32);
            lblSatilanParca.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(6, 20);
            label12.Name = "label12";
            label12.Size = new Size(170, 35);
            label12.TabIndex = 80;
            label12.Text = "Satılan Parça:";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(410, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 86);
            panel2.TabIndex = 81;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblHasilat);
            groupBox2.Controls.Add(label3);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.ForeColor = Color.FromArgb(36, 46, 56);
            groupBox2.Location = new Point(3, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(333, 64);
            groupBox2.TabIndex = 81;
            groupBox2.TabStop = false;
            // 
            // lblHasilat
            // 
            lblHasilat.AutoSize = true;
            lblHasilat.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHasilat.Location = new Point(219, 20);
            lblHasilat.Name = "lblHasilat";
            lblHasilat.Size = new Size(0, 32);
            lblHasilat.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(6, 20);
            label3.Name = "label3";
            label3.Size = new Size(196, 35);
            label3.TabIndex = 80;
            label3.Text = "Toplam Hasılat:";
            // 
            // btnAktar
            // 
            btnAktar.Anchor = AnchorStyles.Top;
            btnAktar.BackColor = Color.FromArgb(36, 46, 56);
            btnAktar.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAktar.ForeColor = Color.White;
            btnAktar.Location = new Point(1103, 316);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(211, 40);
            btnAktar.TabIndex = 77;
            btnAktar.Text = "Aktar";
            btnAktar.UseVisualStyleBackColor = false;
            btnAktar.Click += btnAktar_Click;
            // 
            // rBtnGunluk
            // 
            rBtnGunluk.AutoSize = true;
            rBtnGunluk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnGunluk.Location = new Point(78, 24);
            rBtnGunluk.Name = "rBtnGunluk";
            rBtnGunluk.Size = new Size(100, 32);
            rBtnGunluk.TabIndex = 80;
            rBtnGunluk.TabStop = true;
            rBtnGunluk.Text = "Günlük";
            rBtnGunluk.UseVisualStyleBackColor = true;
            rBtnGunluk.CheckedChanged += rBtnGunluk_CheckedChanged;
            // 
            // rBtnHaftalik
            // 
            rBtnHaftalik.AutoSize = true;
            rBtnHaftalik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnHaftalik.Location = new Point(184, 24);
            rBtnHaftalik.Name = "rBtnHaftalik";
            rBtnHaftalik.Size = new Size(109, 32);
            rBtnHaftalik.TabIndex = 80;
            rBtnHaftalik.TabStop = true;
            rBtnHaftalik.Text = "Haftalık";
            rBtnHaftalik.UseVisualStyleBackColor = true;
            rBtnHaftalik.CheckedChanged += rBtnHaftalik_CheckedChanged;
            // 
            // rBtnAylik
            // 
            rBtnAylik.AutoSize = true;
            rBtnAylik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnAylik.Location = new Point(305, 24);
            rBtnAylik.Name = "rBtnAylik";
            rBtnAylik.Size = new Size(81, 32);
            rBtnAylik.TabIndex = 80;
            rBtnAylik.TabStop = true;
            rBtnAylik.Text = "Aylık";
            rBtnAylik.UseVisualStyleBackColor = true;
            rBtnAylik.CheckedChanged += rBtnAylik_CheckedChanged;
            // 
            // rBtnYillik
            // 
            rBtnYillik.AutoSize = true;
            rBtnYillik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnYillik.Location = new Point(390, 24);
            rBtnYillik.Name = "rBtnYillik";
            rBtnYillik.Size = new Size(80, 32);
            rBtnYillik.TabIndex = 80;
            rBtnYillik.TabStop = true;
            rBtnYillik.Text = "Yıllık";
            rBtnYillik.UseVisualStyleBackColor = true;
            rBtnYillik.CheckedChanged += rBtnYillik_CheckedChanged;
            // 
            // rBtnTum
            // 
            rBtnTum.AutoSize = true;
            rBtnTum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnTum.Location = new Point(476, 24);
            rBtnTum.Name = "rBtnTum";
            rBtnTum.Size = new Size(144, 32);
            rBtnTum.TabIndex = 80;
            rBtnTum.TabStop = true;
            rBtnTum.Text = "Tüm Zaman";
            rBtnTum.UseVisualStyleBackColor = true;
            rBtnTum.CheckedChanged += rBtnTum_CheckedChanged;
            // 
            // dateTimeAlt
            // 
            dateTimeAlt.Location = new Point(959, 9);
            dateTimeAlt.Name = "dateTimeAlt";
            dateTimeAlt.Size = new Size(140, 27);
            dateTimeAlt.TabIndex = 81;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(859, 10);
            label13.Name = "label13";
            label13.Size = new Size(90, 25);
            label13.TabIndex = 82;
            label13.Text = "Alt Tarih:";
            // 
            // dateTimeUst
            // 
            dateTimeUst.Location = new Point(959, 39);
            dateTimeUst.Name = "dateTimeUst";
            dateTimeUst.Size = new Size(140, 27);
            dateTimeUst.TabIndex = 81;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(859, 40);
            label14.Name = "label14";
            label14.Size = new Size(94, 25);
            label14.TabIndex = 82;
            label14.Text = "Üst Tarih:";
            // 
            // btnListele
            // 
            btnListele.Anchor = AnchorStyles.Top;
            btnListele.BackColor = Color.FromArgb(36, 46, 56);
            btnListele.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.ForeColor = Color.White;
            btnListele.Location = new Point(1105, 25);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(103, 40);
            btnListele.TabIndex = 75;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(244, 130, 33);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(dateTimeUst);
            panel7.Controls.Add(dateTimeAlt);
            panel7.Controls.Add(rBtnTum);
            panel7.Controls.Add(rBtnYillik);
            panel7.Controls.Add(rBtnAylik);
            panel7.Controls.Add(rBtnHaftalik);
            panel7.Controls.Add(rBtnGunluk);
            panel7.Controls.Add(btnListele);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1330, 71);
            panel7.TabIndex = 83;
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtAra.Location = new Point(69, 329);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(245, 27);
            txtAra.TabIndex = 85;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(15, 328);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 84;
            label2.Text = "Ara:";
            // 
            // CiroTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtAra);
            Controls.Add(label2);
            Controls.Add(panel7);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnAktar);
            Controls.Add(dGridCiro);
            Name = "CiroTakip";
            Size = new Size(1330, 715);
            ((System.ComponentModel.ISupportInitialize)dGridCiro).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dGridCiro;
        private ComboBox comboBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label lblSatilanParca;
        private Label label12;
        private GroupBox groupBox5;
        private Label lblKar;
        private Label label9;
        private GroupBox groupBox4;
        private Label lblKesilenFatura;
        private Label label6;
        private GroupBox groupBox3;
        private Label lblMaliyet;
        private Label labe;
        private GroupBox groupBox2;
        private Label lblHasilat;
        private Label label3;
        private GroupBox groupBox6;
        private Label lblKdv;
        private Label lbl;
        private Button btnAktar;
        private RadioButton rBtnGunluk;
        private RadioButton rBtnHaftalik;
        private RadioButton rBtnAylik;
        private RadioButton rBtnYillik;
        private RadioButton rBtnTum;
        private DateTimePicker dateTimeAlt;
        private Label label13;
        private DateTimePicker dateTimeUst;
        private Label label14;
        private Button btnListele;
        private Panel panel7;
        private TextBox txtAra;
        private Label label2;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column22;
        private DataGridViewTextBoxColumn Column23;
        private DataGridViewTextBoxColumn Column24;
        private DataGridViewTextBoxColumn Column25;
    }
}
