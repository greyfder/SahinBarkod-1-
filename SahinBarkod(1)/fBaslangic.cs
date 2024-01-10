using System;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void bSatisislemi_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Form1 f = new Form1();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bGenelRapor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fRapor f = new fRapor();
            f.lkullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bStok_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fStok f = new fStok();
            f.lkullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bUrunGiris_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fUrunGiris f = new fUrunGiris();
            f.lkullanici.Text = lKullanici.Text;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void bCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bFiyatGuncelle_Click(object sender, EventArgs e)
        {
            fFiyatGuncelle f = new fFiyatGuncelle();
            f.ShowDialog();
        }

        private void bAyarlar_Click(object sender, EventArgs e)
        {
            fAyarlar f = new fAyarlar();
            f.lKullanici.Text = lKullanici.Text;
            f.ShowDialog();
        }

        private void bYedekleme_Click(object sender, EventArgs e)
        {
            islemler.Backup();
        }

        private void bKullaniciDegistir_Click(object sender, EventArgs e)
        {
            fLogin login = new fLogin();
            login.Show();
            this.Hide();
        }
    }
}
