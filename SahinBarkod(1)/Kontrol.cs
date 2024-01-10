using Lisans;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public class Kontrol
    {
        Barkod1Entities db = new Barkod1Entities();
        Sbt guvenlik = new Sbt();
        lic lic = new lic();
        public bool KontolYap()
        {
            bool durum = false;
            if (db.Sbt.Count() == 0)
            {
                LisansFormuAc();
            }
            else
            {
                lic lic = new lic();
                var guvenlik = db.Sbt.First();
                if (lic.TarihCoz(guvenlik.Kart) < DateTime.Now)
                {
                    guvenlik.Kart = lic.TarihSifrele(DateTime.Now);
                    db.SaveChanges();
                    durum = true;
                }
                if (lic.TarihKontrol(lic.TarihCoz(guvenlik.Kart), lic.TarihCoz(guvenlik.Yazici)))
                {
                    durum = true;
                }
                else
                {
                    durum = false;
                    LisansFormuAc();
                }
            }
            return durum;
        }
        public void LisansFormuAc()
        {
            lic lic = new lic();
            fLisans f = new fLisans();
            f.lKontrolNo.Text = lic.EkrandaGoster().ToString();
            f.Show();
        }
        public void Lisansla(string girilenkod)
        {
            int durum = lic.GirilenLisansiKontolEt(girilenkod);
            switch (durum)
            {
                case 0://Hatalı lisans kod
                    System.Windows.Forms.MessageBox.Show("Girilen Lisans Numarası Geçersizdir.");
                    break;
                case 1:
                    DemoOlustur();
                    break;
                case 2:
                    YillikOlustur();
                    break;
                default:
                    break;
            }
        }

        private int GuvenlikEkliMi()
        {
            return db.Sbt.Count();
        }

        private void GuvenlikEkle(string baslangic, string bitis)
        {
            guvenlik.Kart = baslangic;
            guvenlik.Yazici = bitis;
            db.Sbt.Add(guvenlik);
            db.SaveChanges();
        }

        private void GuvenlikGuncelle(string baslangic, string bitis)
        {
            var guvenlikguncelle = db.Sbt.First();
            guvenlikguncelle.Kart = baslangic;
            guvenlikguncelle.Yazici = bitis;
            db.SaveChanges();
        }

        private void DemoOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    // db ekleme işlemi
                    GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihiOlustur()));
                }
                else
                {
                    //db güncelle işlemi
                    GuvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.DemoTarihiOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("10 Günlük Demo Hesabınız Açılmıştır. \n Programı Tekrar Başlatınız...");
                Application.Exit();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }
        private void YillikOlustur()
        {
            try
            {
                if (GuvenlikEkliMi() == 0)
                {
                    // db ekleme işlemi
                    GuvenlikEkle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                else
                {
                    //db güncelle işlemi
                    GuvenlikGuncelle(lic.TarihSifrele(DateTime.Now), lic.TarihSifrele(lic.YillikTarihOlustur()));
                }
                System.Windows.Forms.MessageBox.Show("Yıllık Lisansınız Tanımlanmıştır.\n Programı Tekrar Başlatınız...");
                Application.Exit();
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }

        }
    }
}
