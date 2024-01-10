using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEPosta.Clear();
            tKullaniciAdi.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRapor.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chYedekleme.Checked = false;
        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "KAYDET")
            {
                if (tAdSoyad.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new Barkod1Entities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tKullaniciAdi.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEPosta.Text;
                                    k.KullaniciAd = tKullaniciAdi.Text.Trim();
                                    k.Sifre = tSifre.Text;
                                    k.Satis = chSatisEkrani.Checked;
                                    k.Rapor = chRapor.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.Yedekleme = chYedekleme.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    doldur();
                                    temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu Kullanıcı Zaten Kayıtlı.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen ** ile Belirtilen Zorunlu Alanları Doldurun." + "\nAd Soyad" + "\nKullanıcı Adı" + "\nŞifre" + "\nŞifre Tekrar");
                }
            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {
                if (tAdSoyad.Text != "" && tKullaniciAdi.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lkullaniciid.Text);
                        using (var db = new Barkod1Entities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.EPosta = tEPosta.Text;
                            guncelle.KullaniciAd = tKullaniciAdi.Text.Trim();
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satis = chSatisEkrani.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.Yedekleme = chYedekleme.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapılmıştır");
                            doldur();
                            temizle();
                            bKaydet.Text = "KAYDET";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen ** ile Belirtilen Zorunlu Alanları Doldurun." + "\nAd Soyad" + "\nKullanıcı Adı" + "\nŞifre" + "\nŞifre Tekrar");

                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridListeKulanici.Rows.Count > 0)
            {

                int id = Convert.ToInt32(GridListeKulanici.CurrentRow.Cells["Id"].Value.ToString());
                lkullaniciid.Text = id.ToString();
                using (var db = new Barkod1Entities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEPosta.Text = getir.EPosta;
                    tKullaniciAdi.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSatisEkrani.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chYedekleme.Checked = (bool)getir.Yedekleme;
                    bKaydet.Text = "Düzenle/Kaydet";
                    doldur();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz.");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            doldur();
            Cursor.Current = Cursors.Default;
        }
        private void doldur()
        {

            using (var db = new Barkod1Entities())
            {
                if (db.Kullanici.Any())
                {
                    GridListeKulanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                }
                //GridListeKulanici.Rows[0].Visible = false;
                islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chYazmaDurumu.Checked = (bool)yazici.Yazici;

                var Sabitler = db.Sabit.FirstOrDefault();
                tKartKomisyon.Text = Sabitler.KartKomisyon.ToString();

                var TeraziOnEk = db.Terazi.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource = TeraziOnEk;

                tisyeriadsoyad.Text = Sabitler.AdSoyad;
                tisyeriunvan.Text = Sabitler.Unvan;
                tisyeriadres.Text = Sabitler.Adres;
                mskisyeritelefon.Text = Sabitler.Telefon;
                tisyerieposta.Text = Sabitler.EPosta;
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(GridListeKulanici.CurrentRow.Cells["Id"].Value.ToString());
            string adsoyad = GridListeKulanici.CurrentRow.Cells["AdSoyad"].Value.ToString();

            DialogResult onay = MessageBox.Show(adsoyad + "Kullanıcısını Silmek İstiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                using (var db = new Barkod1Entities())
                {
                    var kullan = db.Kullanici.FirstOrDefault(x => x.Id == id);
                    db.Kullanici.Remove(kullan);
                    db.SaveChanges();
                    doldur();
                }
            }
        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Barkod1Entities())
            {
                if (chYazmaDurumu.Checked)
                {
                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu AKTİF";

                }
                else
                {
                    islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = false;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu PASİF";
                }

            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using (var db = new Barkod1Entities())
                {
                    var sabit = db.Sabit.FirstOrDefault();

                    sabit.KartKomisyon = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart Komisyon Ayarlandı.");
                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisi Giriniz");
            }

        }

        private void bTeraziOnEk_Click(object sender, EventArgs e)
        {
            int OnEk = Convert.ToInt16(tTeraziOnEk.Text);
            if (tTeraziOnEk.Text != "")
            {
                using (var db = new Barkod1Entities())
                {
                    if (db.Terazi.Any(x => x.Id == OnEk))
                    {
                        MessageBox.Show(OnEk.ToString() + "Önek zaten kayıtlı");
                    }
                    else
                    {
                        Terazi f = new Terazi();
                        f.TeraziOnEk = OnEk;
                        db.Terazi.Add(f);
                        db.SaveChanges();
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        tTeraziOnEk.Clear();
                        MessageBox.Show("Bilgiler Kaydedildi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi Ön Ek Bilgisi Giriniz.");
            }
        }

        private void bTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnEk.Text != "")
            {
                int onekid = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + " Oneki Silmek İstiyor Musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using (var db = new Barkod1Entities())
                    {
                        var onek = db.Terazi.Find(onekid);
                        db.Terazi.Remove(onek);
                        db.SaveChanges();
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazi.ToList();
                        tTeraziOnEk.Clear();
                        MessageBox.Show("Önek Silinmiştir.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Önek Seçiniz.");
            }
        }

        private void tisyeriunvan_TextChanged(object sender, EventArgs e)
        {

        }

        private void bisyerikaydet_Click(object sender, EventArgs e)
        {
            if (tisyeriadsoyad.Text != "" && tisyeriunvan.Text != "" && tisyeriadres.Text != "" && mskisyeritelefon.Text != "")
            {
                using (var db = new Barkod1Entities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tisyeriadsoyad.Text;
                    isyeri.Unvan = tisyeriunvan.Text;
                    isyeri.Adres = tisyeriadres.Text;
                    isyeri.Telefon = mskisyeritelefon.Text;
                    isyeri.EPosta = tisyerieposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("İşyeri Bilgileri Kaydedilmiştir.");
                    var yeni = db.Sabit.FirstOrDefault();
                    tisyeriadsoyad.Text = yeni.AdSoyad;
                    tisyeriunvan.Text = yeni.Unvan;
                    tisyeriadres.Text = yeni.Adres;
                    mskisyeritelefon.Text = yeni.Telefon;
                    tisyerieposta.Text = yeni.EPosta;

                }
            }

        }

        private void bYedektenYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }

        private void bKullanılmayan_Click(object sender, EventArgs e)
        {
            using (var db = new Barkod1Entities())
            {
                DialogResult onay = MessageBox.Show("!! Lütfen Dikkat: \n Ürün fiyat düzenlemelerinin TAMAMINI yaptıysanız \n Bu işlemi onaylayınız.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (onay == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    db.Urun.RemoveRange(db.Urun.Where(x => x.Onay == false));
                    db.SaveChanges();
                    MessageBox.Show("Kullanılmayan ürünler silindi.");
                    Cursor.Current = Cursors.Default;
                }
            }
        }
    }
}
