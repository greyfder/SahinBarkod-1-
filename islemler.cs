// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.islemler
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal static class islemler
  {
    public static double DoubleYap(string deger)
    {
      double result = 0.0;
      double.TryParse(deger, NumberStyles.Currency, (IFormatProvider) CultureInfo.CurrentUICulture.NumberFormat, out result);
      return result;
    }

    public static void StokAzalt(string Barkod, double Miktar)
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (!(Barkod != "1111111111116"))
          return;
        Urun urun = barkod1Entities.Urun.SingleOrDefault<Urun>((Expression<Func<Urun, bool>>) (x => x.Barkod == Barkod));
        double? miktar = urun.Miktar;
        double num = Miktar;
        urun.Miktar = miktar.HasValue ? new double?(miktar.GetValueOrDefault() - num) : new double?();
        barkod1Entities.SaveChanges();
      }
    }

    public static void StokArttır(string Barkod, double Miktar)
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (!(Barkod != "1111111111116"))
          return;
        Urun urun = barkod1Entities.Urun.SingleOrDefault<Urun>((Expression<Func<Urun, bool>>) (x => x.Barkod == Barkod));
        double? miktar = urun.Miktar;
        double num = Miktar;
        urun.Miktar = miktar.HasValue ? new double?(miktar.GetValueOrDefault() + num) : new double?();
        barkod1Entities.SaveChanges();
      }
    }

    public static void GridDuzenle(DataGridView dgv)
    {
      if (dgv.Columns.Count <= 0)
        return;
      for (int index = 0; index < dgv.Columns.Count; ++index)
      {
        switch (dgv.Columns[index].HeaderText)
        {
          case "Acıklama":
            dgv.Columns[index].HeaderText = "Açıklama";
            break;
          case "AlisFiyat":
            dgv.Columns[index].HeaderText = "Alış Fiyatı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "AlısFiyatToplam":
            dgv.Columns[index].HeaderText = "Alış Fiyat Toplamı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Birim":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            break;
          case "Gelir":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Gider":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Id":
            dgv.Columns[index].HeaderText = "Numara";
            break;
          case "Kart":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "KdvOrani":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].HeaderText = "Kdv Oranı";
            break;
          case "KdvTutari":
            dgv.Columns[index].HeaderText = "Kdv Tutarı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Kullanici":
            dgv.Columns[index].HeaderText = "Kullanıcı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            break;
          case "Miktar":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            break;
          case "Nakit":
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "OdemeSekli":
            dgv.Columns[index].HeaderText = "Ödeme Şekli";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            break;
          case "SatisFiyat":
            dgv.Columns[index].HeaderText = "Satış Fiyatı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Satisfiyat":
            dgv.Columns[index].HeaderText = "Satış Fiyatı";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "Toplam":
            dgv.Columns[index].HeaderText = "Toplam";
            dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns[index].DefaultCellStyle.Format = "C2";
            break;
          case "UrunAd":
            dgv.Columns[index].HeaderText = "Ürün Adı";
            break;
          case "Urunad":
            dgv.Columns[index].HeaderText = "Ürün Adı";
            break;
          case "Urunid":
            dgv.Columns[index].HeaderText = "Urun Numarası";
            break;
          case "islemno":
            dgv.Columns[index].HeaderText = "İşlem No";
            break;
          case "İslemNo":
            dgv.Columns[index].HeaderText = "İşlem No";
            break;
        }
      }
    }

    public static void StokHareket(
      string barkod,
      string urunad,
      string birim,
      double miktar,
      string urungrup,
      string kullanici)
    {
      new Barkod1Entities()
      {
        StokHareket = {
          new SahinBarkod_1_.StokHareket()
          {
            Barkod = barkod,
            UrunAd = urunad,
            Birim = birim,
            Miktar = new double?(miktar),
            UrunGrup = urungrup,
            Kullanici = kullanici,
            Tarih = new DateTime?(DateTime.Now)
          }
        }
      }.SaveChanges();
    }

    public static int KartKomisyon()
    {
      int num = 0;
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        num = !barkod1Entities.Sabit.Any<Sabit>() ? 0 : (int) Convert.ToInt16((object) barkod1Entities.Sabit.First<Sabit>().KartKomisyon);
      return num;
    }

    public static void SabitVarsayilan()
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (barkod1Entities.Sabit.Any<Sabit>())
          return;
        barkod1Entities.Sabit.Add(new Sabit()
        {
          KartKomisyon = new int?(0),
          Yazici = new bool?(false),
          AdSoyad = "admin",
          Unvan = "admin",
          Adres = "admin",
          Telefon = "admin",
          EPosta = "admin"
        });
        barkod1Entities.SaveChanges();
      }
    }

    public static void Backup()
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Veri yedek dosyası |0.bak";
      saveFileDialog.FileName = "Barkodlu_Satis_Programı_Sahin_" + DateTime.Now.ToShortDateString();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        Cursor.Current = Cursors.WaitCursor;
        if (File.Exists(saveFileDialog.FileName))
          File.Delete(saveFileDialog.FileName);
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          string sql = "BACKUP DATABASE[" + (Application.StartupPath + "\\Barkod1.mdf") + "] TO DISK='" + saveFileDialog.FileName + "'";
          barkod1Entities.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sql);
        }
        Cursor.Current = Cursors.Default;
        int num = (int) MessageBox.Show("Yedekleme Tamamlandı.");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }
  }
}
