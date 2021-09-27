using System;
using System.Windows.Forms;

namespace Film_Arsiv
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void Btn_Film_Kaydet_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void Btn_Kitap_Kaydet_Click(object sender, EventArgs e)
        {
            FrmKitapEkle frm = new FrmKitapEkle();
            frm.Show();
            Hide();
        }

        private void Frm_Ana_Sayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
