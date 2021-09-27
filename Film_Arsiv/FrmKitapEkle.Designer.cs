namespace Film_Arsiv
{
    partial class FrmKitapEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.Cmb_Yazar = new System.Windows.Forms.ComboBox();
            this.Cmb_YayinEvi = new System.Windows.Forms.ComboBox();
            this.Cmb_Tur = new System.Windows.Forms.ComboBox();
            this.Chk_Okundu = new System.Windows.Forms.CheckBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Rch_Not = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lbl_ID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Txt_Sayfa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_OkunmusSayfa = new System.Windows.Forms.Label();
            this.Lbl_OkunmusKit_Sayisi = new System.Windows.Forms.Label();
            this.Lbl_OkunmamisSayfa = new System.Windows.Forms.Label();
            this.Lbl_OkunmamisKit_Sayisi = new System.Windows.Forms.Label();
            this.Lbl_Top_Kit_Sayisi = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Ara = new System.Windows.Forms.Button();
            this.Txt_Ara = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yayın Evi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tür:";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(184, 21);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(201, 26);
            this.Txt_Ad.TabIndex = 0;
            // 
            // Cmb_Yazar
            // 
            this.Cmb_Yazar.FormattingEnabled = true;
            this.Cmb_Yazar.Items.AddRange(new object[] {
            "Sabahattin Ali",
            "Şinasi Gündüz",
            "Farabi",
            "Gazali",
            "Bayram Ali Çetinkaya",
            "Platon",
            "İbni Sina",
            "Tomas More",
            "Cengiz Aytmatov",
            "Dostoyevski",
            "Victor Hugo",
            "Ahmet Hamdi Tanpınar",
            "Franz Kafka",
            "Adnan Demircan",
            "Said Nursi",
            "Jack London",
            "Harper Lee",
            "Peyami Safa",
            "Vail bin Hallak",
            "Ömer Aydın"});
            this.Cmb_Yazar.Location = new System.Drawing.Point(184, 53);
            this.Cmb_Yazar.Name = "Cmb_Yazar";
            this.Cmb_Yazar.Size = new System.Drawing.Size(201, 28);
            this.Cmb_Yazar.TabIndex = 1;
            // 
            // Cmb_YayinEvi
            // 
            this.Cmb_YayinEvi.FormattingEnabled = true;
            this.Cmb_YayinEvi.Items.AddRange(new object[] {
            "Yapı Kredi",
            "Grafiker",
            "İş Bankası",
            "Litera",
            "Martı",
            "Vadi",
            "Ensar",
            "Can",
            "Ötüken",
            "Oskar",
            "Nora",
            "Artemis",
            "Dergah",
            "Ravza",
            "Nobel",
            "Klasik",
            "Koridor",
            "İsam",
            "April",
            "İmge",
            "İşaret"});
            this.Cmb_YayinEvi.Location = new System.Drawing.Point(184, 88);
            this.Cmb_YayinEvi.Name = "Cmb_YayinEvi";
            this.Cmb_YayinEvi.Size = new System.Drawing.Size(201, 28);
            this.Cmb_YayinEvi.TabIndex = 2;
            // 
            // Cmb_Tur
            // 
            this.Cmb_Tur.FormattingEnabled = true;
            this.Cmb_Tur.Items.AddRange(new object[] {
            "Tarih",
            "Fantastik",
            "Araştırma-İnceleme",
            "Dini Kitap",
            "Felsefe",
            "Roman",
            "Hikaye",
            "Polisiye",
            "Biyografi",
            "Siyasi",
            "Psikoloji"});
            this.Cmb_Tur.Location = new System.Drawing.Point(184, 122);
            this.Cmb_Tur.Name = "Cmb_Tur";
            this.Cmb_Tur.Size = new System.Drawing.Size(201, 28);
            this.Cmb_Tur.TabIndex = 3;
            // 
            // Chk_Okundu
            // 
            this.Chk_Okundu.AutoSize = true;
            this.Chk_Okundu.Location = new System.Drawing.Point(184, 188);
            this.Chk_Okundu.Name = "Chk_Okundu";
            this.Chk_Okundu.Size = new System.Drawing.Size(74, 24);
            this.Chk_Okundu.TabIndex = 10;
            this.Chk_Okundu.Text = "Okundu";
            this.Chk_Okundu.UseVisualStyleBackColor = true;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(153, 309);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(201, 41);
            this.Btn_Ekle.TabIndex = 7;
            this.Btn_Ekle.Text = "Kütüphaneye Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 348);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Not:";
            // 
            // Rch_Not
            // 
            this.Rch_Not.Location = new System.Drawing.Point(456, 21);
            this.Rch_Not.Name = "Rch_Not";
            this.Rch_Not.Size = new System.Drawing.Size(312, 206);
            this.Rch_Not.TabIndex = 6;
            this.Rch_Not.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Lbl_ID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Rch_Not);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Btn_Guncelle);
            this.panel1.Controls.Add(this.Btn_Ekle);
            this.panel1.Controls.Add(this.Txt_Sayfa);
            this.panel1.Controls.Add(this.Txt_Ad);
            this.panel1.Controls.Add(this.Chk_Okundu);
            this.panel1.Controls.Add(this.Cmb_Yazar);
            this.panel1.Controls.Add(this.Cmb_Tur);
            this.panel1.Controls.Add(this.Cmb_YayinEvi);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 353);
            this.panel1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(184, 219);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Lbl_ID
            // 
            this.Lbl_ID.AutoSize = true;
            this.Lbl_ID.Location = new System.Drawing.Point(3, 21);
            this.Lbl_ID.Name = "Lbl_ID";
            this.Lbl_ID.Size = new System.Drawing.Size(31, 20);
            this.Lbl_ID.TabIndex = 7;
            this.Lbl_ID.Text = "Tür:";
            this.Lbl_ID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sayfa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ekleme Tarihi:";
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(567, 309);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(201, 41);
            this.Btn_Sil.TabIndex = 7;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(360, 309);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(201, 41);
            this.Btn_Guncelle.TabIndex = 7;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Txt_Sayfa
            // 
            this.Txt_Sayfa.Location = new System.Drawing.Point(184, 156);
            this.Txt_Sayfa.Name = "Txt_Sayfa";
            this.Txt_Sayfa.Size = new System.Drawing.Size(201, 26);
            this.Txt_Sayfa.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_OkunmusSayfa);
            this.panel2.Controls.Add(this.Lbl_OkunmusKit_Sayisi);
            this.panel2.Controls.Add(this.Lbl_OkunmamisSayfa);
            this.panel2.Controls.Add(this.Lbl_OkunmamisKit_Sayisi);
            this.panel2.Controls.Add(this.Lbl_Top_Kit_Sayisi);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 388);
            this.panel2.TabIndex = 8;
            // 
            // Lbl_OkunmusSayfa
            // 
            this.Lbl_OkunmusSayfa.AutoSize = true;
            this.Lbl_OkunmusSayfa.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Lbl_OkunmusSayfa.Location = new System.Drawing.Point(971, 359);
            this.Lbl_OkunmusSayfa.Name = "Lbl_OkunmusSayfa";
            this.Lbl_OkunmusSayfa.Size = new System.Drawing.Size(51, 20);
            this.Lbl_OkunmusSayfa.TabIndex = 6;
            this.Lbl_OkunmusSayfa.Text = "000000";
            // 
            // Lbl_OkunmusKit_Sayisi
            // 
            this.Lbl_OkunmusKit_Sayisi.AutoSize = true;
            this.Lbl_OkunmusKit_Sayisi.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Lbl_OkunmusKit_Sayisi.Location = new System.Drawing.Point(563, 359);
            this.Lbl_OkunmusKit_Sayisi.Name = "Lbl_OkunmusKit_Sayisi";
            this.Lbl_OkunmusKit_Sayisi.Size = new System.Drawing.Size(51, 20);
            this.Lbl_OkunmusKit_Sayisi.TabIndex = 6;
            this.Lbl_OkunmusKit_Sayisi.Text = "000000";
            // 
            // Lbl_OkunmamisSayfa
            // 
            this.Lbl_OkunmamisSayfa.AutoSize = true;
            this.Lbl_OkunmamisSayfa.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Lbl_OkunmamisSayfa.Location = new System.Drawing.Point(774, 359);
            this.Lbl_OkunmamisSayfa.Name = "Lbl_OkunmamisSayfa";
            this.Lbl_OkunmamisSayfa.Size = new System.Drawing.Size(51, 20);
            this.Lbl_OkunmamisSayfa.TabIndex = 6;
            this.Lbl_OkunmamisSayfa.Text = "000000";
            // 
            // Lbl_OkunmamisKit_Sayisi
            // 
            this.Lbl_OkunmamisKit_Sayisi.AutoSize = true;
            this.Lbl_OkunmamisKit_Sayisi.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Lbl_OkunmamisKit_Sayisi.Location = new System.Drawing.Point(368, 359);
            this.Lbl_OkunmamisKit_Sayisi.Name = "Lbl_OkunmamisKit_Sayisi";
            this.Lbl_OkunmamisKit_Sayisi.Size = new System.Drawing.Size(51, 20);
            this.Lbl_OkunmamisKit_Sayisi.TabIndex = 6;
            this.Lbl_OkunmamisKit_Sayisi.Text = "000000";
            // 
            // Lbl_Top_Kit_Sayisi
            // 
            this.Lbl_Top_Kit_Sayisi.AutoSize = true;
            this.Lbl_Top_Kit_Sayisi.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.Lbl_Top_Kit_Sayisi.Location = new System.Drawing.Point(155, 359);
            this.Lbl_Top_Kit_Sayisi.Name = "Lbl_Top_Kit_Sayisi";
            this.Lbl_Top_Kit_Sayisi.Size = new System.Drawing.Size(51, 20);
            this.Lbl_Top_Kit_Sayisi.TabIndex = 6;
            this.Lbl_Top_Kit_Sayisi.Text = "000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label13.Location = new System.Drawing.Point(831, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Okunmuş Sayfa Sayısı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label11.Location = new System.Drawing.Point(425, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Okunmuş Kitap Sayısı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label12.Location = new System.Drawing.Point(620, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Okunmamış Sayfa Sayısı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label10.Location = new System.Drawing.Point(216, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Okunmamış Kitap Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.label9.Location = new System.Drawing.Point(27, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Toplam Kitap Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Btn_Ara);
            this.groupBox1.Controls.Add(this.Txt_Ara);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(790, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 353);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama ve Filtre";
            // 
            // Btn_Ara
            // 
            this.Btn_Ara.Location = new System.Drawing.Point(6, 309);
            this.Btn_Ara.Name = "Btn_Ara";
            this.Btn_Ara.Size = new System.Drawing.Size(247, 41);
            this.Btn_Ara.TabIndex = 7;
            this.Btn_Ara.Text = "Ara";
            this.Btn_Ara.UseVisualStyleBackColor = true;
            this.Btn_Ara.Click += new System.EventHandler(this.Btn_Ara_Click);
            // 
            // Txt_Ara
            // 
            this.Txt_Ara.Location = new System.Drawing.Point(6, 277);
            this.Txt_Ara.Name = "Txt_Ara";
            this.Txt_Ara.Size = new System.Drawing.Size(247, 26);
            this.Txt_Ara.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hepsi",
            "Okundu",
            "Okunmadı"});
            this.comboBox2.Location = new System.Drawing.Point(6, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(247, 28);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ad",
            "Yazar",
            "Tür",
            "Yayın Evi"});
            this.comboBox1.Location = new System.Drawing.Point(6, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Göre";
            // 
            // Frm_Kitap_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1049, 757);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1065, 796);
            this.Name = "FrmKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Kitap_Ekle_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Kitap_Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.ComboBox Cmb_Yazar;
        private System.Windows.Forms.ComboBox Cmb_YayinEvi;
        private System.Windows.Forms.ComboBox Cmb_Tur;
        private System.Windows.Forms.CheckBox Chk_Okundu;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Rch_Not;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Ara;
        private System.Windows.Forms.TextBox Txt_Ara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Sayfa;
        private System.Windows.Forms.Label Lbl_OkunmusSayfa;
        private System.Windows.Forms.Label Lbl_OkunmusKit_Sayisi;
        private System.Windows.Forms.Label Lbl_OkunmamisSayfa;
        private System.Windows.Forms.Label Lbl_OkunmamisKit_Sayisi;
        private System.Windows.Forms.Label Lbl_Top_Kit_Sayisi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}