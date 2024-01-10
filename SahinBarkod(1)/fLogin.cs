using Lisans; // burdan çağırdık
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        private void girisyap()
        {
            if (tKullaniciAdi.Text != "" && tSifre.Text != "")
            {
                try
                {
                    using (var db = new Barkod1Entities())
                    {
                        if (db.Kullanici.Any())
                        {
                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text && x.Sifre == tSifre.Text).FirstOrDefault();
                            if (bak != null)
                            {
                                Cursor.Current = Cursors.WaitCursor;
                                Kontrol kontrol = new Kontrol();
                                if (kontrol.KontolYap())
                                {
                                    fBaslangic f = new fBaslangic();
                                    f.bSatisislemi.Enabled = (bool)bak.Satis;
                                    f.bGenelRapor.Enabled = (bool)bak.Rapor;
                                    f.bStok.Enabled = (bool)bak.Stok;
                                    f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                                    f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                                    f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                                    //f.bFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                                    f.lKullanici.Text = bak.AdSoyad;
                                    var isyeri = db.Sabit.FirstOrDefault();
                                    f.lisyeri.Text = isyeri.Unvan;
                                    f.Show();
                                    this.Hide();
                                }
                                Cursor.Current = Cursors.Default;
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Giriş Yaptınız.");
                            }
                        }
                        else
                        {
                            Cursor.Current = Cursors.WaitCursor;
                            Kullanici k = new Kullanici();
                            k.AdSoyad = "admin";
                            k.Ayarlar = true;
                            k.EPosta = "eposta";
                            k.FiyatGuncelle = true;
                            k.KullaniciAd = "admin";
                            k.Rapor = true;
                            k.Satis = true;
                            k.Sifre = "admin";
                            k.Stok = true;
                            k.Telefon = "telefon";
                            k.UrunGiris = true;
                            k.Yedekleme = true;
                            db.Kullanici.Add(k);
                            db.SaveChanges();

                            var bak = db.Kullanici.Where(x => x.KullaniciAd == tKullaniciAdi.Text && x.Sifre == tSifre.Text).FirstOrDefault();

                            fBaslangic f = new fBaslangic();
                            f.bSatisislemi.Enabled = (bool)bak.Satis;
                            f.bGenelRapor.Enabled = (bool)bak.Rapor;
                            f.bStok.Enabled = (bool)bak.Stok;
                            f.bUrunGiris.Enabled = (bool)bak.UrunGiris;
                            f.bAyarlar.Enabled = (bool)bak.Ayarlar;
                            f.bYedekleme.Enabled = (bool)bak.Yedekleme;
                            f.bFiyatGuncelle.Enabled = (bool)bak.FiyatGuncelle;
                            f.lKullanici.Text = bak.AdSoyad;
                            var isyeri = db.Sabit.FirstOrDefault();
                            f.lisyeri.Text = isyeri.Unvan;
                            f.Show();
                            this.Hide();
                            Cursor.Current = Cursors.Default;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

        }
        private void bGiris_Click(object sender, EventArgs e)
        {
            girisyap();
        }

        private void bGiris_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                girisyap();
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lic lic = new lic();
            label1.Text = lic.CpuNo() + "\n" + lic.CpuKarekterToplam().ToString();
        }
    }
}
