// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.Kontrol
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using Lisans;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class Kontrol
  {
    private Barkod1Entities db = new Barkod1Entities();
    private Sbt guvenlik = new Sbt();
    private lic lic = new lic();

    public bool KontolYap()
    {
      bool flag = false;
      if (this.db.Sbt.Count<Sbt>() == 0)
      {
        this.LisansFormuAc();
      }
      else
      {
        lic lic = new lic();
        Sbt sbt = this.db.Sbt.First<Sbt>();
        if (lic.TarihCoz(sbt.Kart) < DateTime.Now)
        {
          sbt.Kart = lic.TarihSifrele(DateTime.Now);
          this.db.SaveChanges();
        }
        if (lic.TarihKontrol(lic.TarihCoz(sbt.Kart), lic.TarihCoz(sbt.Yazici)))
        {
          flag = true;
        }
        else
        {
          flag = false;
          this.LisansFormuAc();
        }
      }
      return flag;
    }

    public void LisansFormuAc()
    {
      lic lic = new lic();
      fLisans fLisans = new fLisans();
      fLisans.lKontrolNo.Text = lic.EkrandaGoster().ToString();
      fLisans.Show();
    }

    public void Lisansla(string girilenkod)
    {
      switch (this.lic.GirilenLisansiKontolEt(girilenkod))
      {
        case 0:
          int num = (int) MessageBox.Show("Girilen Lisans Numarası Geçersizdir.");
          break;
        case 1:
          this.DemoOlustur();
          break;
        case 2:
          this.YillikOlustur();
          break;
      }
    }

    private int GuvenlikEkliMi() => this.db.Sbt.Count<Sbt>();

    private void GuvenlikEkle(string baslangic, string bitis)
    {
      this.guvenlik.Kart = baslangic;
      this.guvenlik.Yazici = bitis;
      this.db.Sbt.Add(this.guvenlik);
      this.db.SaveChanges();
    }

    private void GuvenlikGuncelle(string baslangic, string bitis)
    {
      Sbt sbt = this.db.Sbt.First<Sbt>();
      sbt.Kart = baslangic;
      sbt.Yazici = bitis;
      this.db.SaveChanges();
    }

    private void DemoOlustur()
    {
      try
      {
        if (this.GuvenlikEkliMi() == 0)
          this.GuvenlikEkle(this.lic.TarihSifrele(DateTime.Now), this.lic.TarihSifrele(this.lic.DemoTarihiOlustur()));
        else
          this.GuvenlikGuncelle(this.lic.TarihSifrele(DateTime.Now), this.lic.TarihSifrele(this.lic.DemoTarihiOlustur()));
        int num = (int) MessageBox.Show("10 Günlük Demo Hesabınız Açılmıştır. \n Programı Tekrar Başlatınız...");
        Application.Exit();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void YillikOlustur()
    {
      try
      {
        if (this.GuvenlikEkliMi() == 0)
          this.GuvenlikEkle(this.lic.TarihSifrele(DateTime.Now), this.lic.TarihSifrele(this.lic.YillikTarihOlustur()));
        else
          this.GuvenlikGuncelle(this.lic.TarihSifrele(DateTime.Now), this.lic.TarihSifrele(this.lic.YillikTarihOlustur()));
        int num = (int) MessageBox.Show("Yıllık Lisansınız Tanımlanmıştır.\n Programı Tekrar Başlatınız...");
        Application.Exit();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }
  }
}
