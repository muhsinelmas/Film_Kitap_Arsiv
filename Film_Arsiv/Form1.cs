using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Globalization;
using System.Drawing;

namespace Film_Arsiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection _baglanti = new SQLiteConnection(@"Data Source=Filmler.db3;Version=3;ReadOnly=False;");
        bool _durum;
        string _adBuyuk,_turBuyuk;
        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Ad.Text.Trim() != "")
                {
                    Buyut();
                    Ad_Kontrol();
                    if (_durum == true)
                    {
                        _baglanti.Open();
                        SQLiteCommand komut = new SQLiteCommand("Insert Into Tbl_Filmler (FilmAd,FilmTur,FilmYil) Values(@p1,@p2,@p3)", _baglanti);
                        komut.Parameters.AddWithValue("@p1", _adBuyuk);
                        komut.Parameters.AddWithValue("@p2", _turBuyuk);
                        komut.Parameters.AddWithValue("@p3", Txt_Yil.Text);
                        komut.ExecuteNonQuery();
                        _baglanti.Close();

                        MessageBox.Show("Film eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz filmin aynısı mevcut", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Bir film adı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void Ad_Kontrol()
        {
            try
            {
                _baglanti.Open();
                SQLiteCommand komut1 = new SQLiteCommand("Select FilmAd From Tbl_Filmler Where FilmAd=@p1", _baglanti);
                komut1.Parameters.AddWithValue("@p1", _adBuyuk);
                SQLiteDataReader oku = komut1.ExecuteReader();
                if (oku.Read())
                {
                    _durum = false;
                }
                else
                {
                    _durum = true;
                }
                _baglanti.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            FrmFilmListesi frmFilmListesi = new FrmFilmListesi();
            frmFilmListesi.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("Filmler.db3"))
                {
                    SQLiteConnection.CreateFile("Filmler.db3");
                    SQLiteCommand komut = new SQLiteCommand("Create Table Tbl_Filmler (FilmID INTEGER PRIMARY KEY AUTOINCREMENT, FilmAd varchar(60), FilmTur varchar(50), FilmYil varchar(4));", _baglanti);
                    _baglanti.Open();
                    komut.ExecuteNonQuery();
                    _baglanti.Close();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.Show();
        }
        void Buyut()
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            _adBuyuk = textInfo.ToTitleCase(Txt_Ad.Text);
            _turBuyuk = textInfo.ToTitleCase(Txt_Film_Tur.Text);
        }
    }
}
