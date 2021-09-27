using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace Film_Arsiv
{
    public partial class FrmFilmListesi : Form
    {
        public FrmFilmListesi()
        {
            InitializeComponent();
        }
        SQLiteConnection _baglanti = new SQLiteConnection(@"Data Source=Filmler.db3;Version=3;ReadOnly=False;");
        string _adBuyuk, _turBuyuk;
        private void Frm_Film_Listesi_Load(object sender, EventArgs e)
        {
            try
            {
                _baglanti.Open();
                SQLiteDataAdapter dr = new SQLiteDataAdapter("Select FilmID as 'Film No',FilmAd as 'Film Adı',FilmTur as 'Film Türü',FilmYil as 'Film Çıkış Yılı' From Tbl_Filmler", _baglanti);
                DataTable dataTable = new DataTable();
                dr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                _baglanti.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Lbl_ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txt_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Txt_Film_Tur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            Txt_Yil.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            Btn_Guncelle.Enabled = true;
        }
        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Buyut();

                _baglanti.Open();
                SQLiteCommand komut = new SQLiteCommand("Update Tbl_Filmler set FilmAd=@p1, FilmTur=@p2, FilmYil=@p3 Where FilmID=@p4", _baglanti);
                komut.Parameters.AddWithValue("@p1", _adBuyuk);
                komut.Parameters.AddWithValue("@p2", _turBuyuk);
                komut.Parameters.AddWithValue("@p3", Txt_Yil.Text);
                komut.Parameters.AddWithValue("@p4", Lbl_ID.Text);
                komut.ExecuteNonQuery();
                _baglanti.Close();

                _baglanti.Open();
                SQLiteDataAdapter dr = new SQLiteDataAdapter("Select FilmID as 'Film No',FilmAd as 'Film Adı',FilmTur as 'Film Türü',FilmYil as 'Film Çıkış Yılı' From Tbl_Filmler", _baglanti);
                DataTable dataTable = new DataTable();
                dr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                _baglanti.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }
        private void Txt_Ara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _baglanti.Open();
                SQLiteDataAdapter dr = new SQLiteDataAdapter("Select FilmID as 'Film No',FilmAd as 'Film Adı',FilmTur as 'Film Türü',FilmYil as 'Film Çıkış Yılı' From Tbl_Filmler where FilmAd like '%" + Txt_Ara.Text.Trim() + "%'", _baglanti);

                DataTable dataTable = new DataTable();
                dr.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                _baglanti.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
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