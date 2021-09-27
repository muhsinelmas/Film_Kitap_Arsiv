using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Film_Arsiv
{
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }
        SQLiteConnection _baglanti = new SQLiteConnection(@"Data Source=Filmler.db3;Version=3;ReadOnly=False;");
        int _kayitSayisi, _okunmamisKitaplar, _okunmusKitaplar = -1;
        bool _kontrol;

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Ad.Text.Trim() != "")
                {
                    if (_kontrol == true)
                    {
                        _baglanti.Open();
                        SQLiteCommand komut = new SQLiteCommand("insert into Tbl_Kitaplar (Ad, Yazar, YayinEvi, Tur, Durum, EklenmeTarihi, Aciklama, SayfaSayisi) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", _baglanti);
                        komut.Parameters.Clear();
                        komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                        komut.Parameters.AddWithValue("@p2", Cmb_Yazar.Text);
                        komut.Parameters.AddWithValue("@p3", Cmb_YayinEvi.Text);
                        komut.Parameters.AddWithValue("@p4", Cmb_Tur.Text);
                        komut.Parameters.AddWithValue("@p5", Chk_Okundu.Checked);
                        komut.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
                        komut.Parameters.AddWithValue("@p7", Rch_Not.Text);
                        komut.Parameters.AddWithValue("@p8", Convert.ToInt32(Txt_Sayfa.Text));
                        komut.ExecuteNonQuery();
                        _baglanti.Close();

                        Getir();
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz kitabın aynısı mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen kitap adı giriniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                _baglanti.Close();
            }
        }
        private void Frm_Kitap_Ekle_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox2.Text = comboBox2.Items[0].ToString();
            Btn_Guncelle.Enabled = false;
            Btn_Sil.Enabled = false;

            Getir();
        }
        private void Getir()
        {
            try
            {
                if (comboBox2.Text == "Hepsi")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
                else if (comboBox2.Text == "Okundu")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where Durum=True", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
                else if (comboBox2.Text == "Okunmadı")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where Durum=False", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }

                //Toplam kayıt sayısı
                _baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Select Count(*) from Tbl_Kitaplar", _baglanti);
                _kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
                Lbl_Top_Kit_Sayisi.Text = _kayitSayisi.ToString();
                _baglanti.Close();

                //Okunmamış Sayfa sayısı
                _baglanti.Open();
                SQLiteCommand komut1 = new SQLiteCommand("Select Sum(SayfaSayisi) From Tbl_Kitaplar Where Durum=False", _baglanti);
                Lbl_OkunmamisSayfa.Text = komut1.ExecuteScalar().ToString();
                komut1.ExecuteNonQuery();
                _baglanti.Close();

                //Okunmamış kitap sayısı
                _baglanti.Open();
                SQLiteCommand komut2 = new SQLiteCommand("Select Count(*) from Tbl_Kitaplar Where Durum=False", _baglanti);
                _okunmamisKitaplar = Convert.ToInt32(komut2.ExecuteScalar());
                Lbl_OkunmamisKit_Sayisi.Text = _okunmamisKitaplar.ToString();
                _baglanti.Close();

                //Okunmuş kitap sayısı
                _baglanti.Open();
                SQLiteCommand komut3 = new SQLiteCommand("Select Count(*) from Tbl_Kitaplar Where Durum=True", _baglanti);
                _okunmusKitaplar = Convert.ToInt32(komut3.ExecuteScalar());
                Lbl_OkunmusKit_Sayisi.Text = _okunmusKitaplar.ToString();
                _baglanti.Close();

                //Okunmuş Sayfa sayısı
                _baglanti.Open();
                SQLiteCommand komut4 = new SQLiteCommand("Select Sum(SayfaSayisi) From Tbl_Kitaplar Where Durum=True", _baglanti);
                Lbl_OkunmusSayfa.Text = komut4.ExecuteScalar().ToString();
                komut1.ExecuteNonQuery();
                _baglanti.Close();

                //Satır renklendirme
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCellStyle renk = new DataGridViewCellStyle();

                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value) == true)
                    {
                        renk.BackColor = Color.Green;
                        renk.ForeColor = Color.White;
                    }
                    else
                    {
                        renk.BackColor = Color.Red;
                        renk.ForeColor = Color.White;
                    }
                    dataGridView1.Rows[i].DefaultCellStyle = renk;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void Frm_Kitap_Ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Lbl_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Cmb_Yazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Cmb_YayinEvi.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Cmb_Tur.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Chk_Okundu.Checked = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            Rch_Not.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            Txt_Sayfa.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            Btn_Sil.Enabled = true;
            Btn_Guncelle.Enabled = true;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getir();
        }
        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Ad")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where Ad like '%" + Txt_Ara.Text.Trim() + "%'", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
                else if (comboBox1.Text == "Yazar")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where Yazar like '%" + Txt_Ara.Text.Trim() + "%'", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
                else if (comboBox1.Text == "Yayın Evi")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where YayinEvi like '%" + Txt_Ara.Text.Trim() + "%'", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
                else if (comboBox1.Text == "Tür")
                {
                    _baglanti.Open();
                    SQLiteDataAdapter dr = new SQLiteDataAdapter("select ID as 'No', Ad as 'Ad', Yazar as 'Yazar', YayinEvi as 'Yayın Evi', Tur as 'Tür', Durum as 'Durum', EklenmeTarihi as 'Eklenme Tarihi', Aciklama as 'Açıklama', SayfaSayisi as 'Sayfa Sayısı' from Tbl_Kitaplar where Tur like '%" + Txt_Ara.Text.Trim() + "%'", _baglanti);
                    DataTable dataTable = new DataTable();
                    dr.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    _baglanti.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                _baglanti.Close();
            }
        }
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Update Tbl_Kitaplar set Ad=@p1, Yazar=@p2, YayinEvi=@p3, Tur=@p4, Durum=@p5, EklenmeTarihi=@p6, Aciklama=@p7, SayfaSayisi=@p8 Where ID=@p9", _baglanti);
                komut.Parameters.Clear();
                komut.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                komut.Parameters.AddWithValue("@p2", Cmb_Yazar.Text);
                komut.Parameters.AddWithValue("@p3", Cmb_YayinEvi.Text);
                komut.Parameters.AddWithValue("@p4", Cmb_Tur.Text);
                komut.Parameters.AddWithValue("@p5", Chk_Okundu.Checked);
                komut.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p7", Rch_Not.Text);
                komut.Parameters.AddWithValue("@p8", Convert.ToInt32(Txt_Sayfa.Text));
                komut.Parameters.AddWithValue("@p9", Lbl_ID.Text);
                komut.ExecuteNonQuery();
                _baglanti.Close();

                Temizle();

                MessageBox.Show("Kayıt güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Getir();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                _baglanti.Close();
            }
        }
        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("              Sil", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _baglanti.Open();
                    SQLiteCommand komut = new SQLiteCommand("Delete from Tbl_Kitaplar where ID='" + Lbl_ID.Text + "'", _baglanti);
                    komut.ExecuteNonQuery();
                    _baglanti.Close();

                    Getir();
                    Temizle();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                _baglanti.Close();
            }
        }
        void Temizle()
        {
            Txt_Ad.Text = "";
            Cmb_Tur.Text = "";
            Cmb_YayinEvi.Text = "";
            Cmb_Yazar.Text = "";
            Chk_Okundu.Checked = false;
            Rch_Not.Text = "";
            Txt_Sayfa.Text = "";

            Txt_Ad.Focus();

            Btn_Guncelle.Enabled = false;
            Btn_Sil.Enabled = false;
        }
        void Kontrol()
        {
            try
            {
                _baglanti.Open();
                SQLiteCommand komut1 = new SQLiteCommand("Select Ad,Yazar From Tbl_Kitaplar Where Ad=@p1 AND Yazar=@p2", _baglanti);
                komut1.Parameters.Clear();
                komut1.Parameters.AddWithValue("@p1", Txt_Ad.Text);
                komut1.Parameters.AddWithValue("@p2", Cmb_Yazar.Text);
                SQLiteDataReader oku = komut1.ExecuteReader();
                if (oku.Read())
                {
                    _kontrol = false;
                }
                else
                {
                    _kontrol = true;
                }
                _baglanti.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
