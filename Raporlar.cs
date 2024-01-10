// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.Raporlar
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal static class Raporlar
  {
    public static string Baslık { get; set; }

    public static string TarihBaslangic { get; set; }

    public static string TarihBitis { get; set; }

    public static string SatisNakit { get; set; }

    public static string SatisKart { get; set; }

    public static string İadeNakit { get; set; }

    public static string İadeKart { get; set; }

    public static string GelirNakit { get; set; }

    public static string GelirKart { get; set; }

    public static string GiderNakit { get; set; }

    public static string GiderKart { get; set; }

    public static string KdvToplam { get; set; }

    public static string KartKomisyon { get; set; }

    public static void RaporSayfasiRaporu(DataGridView dgv)
    {
      Cursor.Current = Cursors.WaitCursor;
      List<islemOzet> islemOzetList = new List<islemOzet>();
      islemOzetList.Clear();
      for (int index = 0; index < dgv.Rows.Count; ++index)
        islemOzetList.Add(new islemOzet()
        {
          İslemNo = new int?(Convert.ToInt32(dgv.Rows[index].Cells["İslemNo"].Value.ToString())),
          İade = new bool?(Convert.ToBoolean(dgv.Rows[index].Cells["İade"].Value)),
          OdemeSekli = dgv.Rows[index].Cells["OdemeSekli"].Value.ToString(),
          Nakit = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["Nakit"].Value.ToString())),
          Kart = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["Kart"].Value.ToString())),
          Gelir = new bool?(Convert.ToBoolean(dgv.Rows[index].Cells["Gelir"].Value)),
          Gider = new bool?(Convert.ToBoolean(dgv.Rows[index].Cells["Gider"].Value)),
          AlısFiyatToplam = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["AlısFiyatToplam"].Value.ToString())),
          Acıklama = dgv.Rows[index].Cells["OdemeSekli"].Value.ToString(),
          Tarih = new DateTime?(Convert.ToDateTime(dgv.Rows[index].Cells["Tarih"].Value.ToString())),
          Kullanici = dgv.Rows[index].Cells["Kullanici"].Value.ToString()
        });
      ReportDataSource reportDataSource = new ReportDataSource();
      reportDataSource.Name = "dsGenelRapor";
      reportDataSource.Value = (object) islemOzetList;
      fRaporEkle fRaporEkle = new fRaporEkle();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Clear();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
      fRaporEkle.reportViewer1.LocalReport.ReportPath = "C:\\Users\\ŞAHİNŞAHİN\\Source\\Repos\\SahinBarkod(1)\\SahinBarkod(1)\\bin\\Debug\\rpGenelRapor.rdlc";
      ReportParameter[] parameters = new ReportParameter[13]
      {
        new ReportParameter("Baslık", Raporlar.Baslık),
        new ReportParameter("TarihBaslangic", Raporlar.TarihBaslangic),
        new ReportParameter("TarihBitis", Raporlar.TarihBitis),
        new ReportParameter("SatisNakit", Raporlar.SatisNakit),
        new ReportParameter("SatisKart", Raporlar.SatisKart),
        new ReportParameter("İadeNakit", Raporlar.İadeNakit),
        new ReportParameter("İadeKart", Raporlar.İadeKart),
        new ReportParameter("GelirNakit", Raporlar.GelirNakit),
        new ReportParameter("GelirKart", Raporlar.GelirKart),
        new ReportParameter("GiderNakit", Raporlar.GiderNakit),
        new ReportParameter("GiderKart", Raporlar.GiderKart),
        new ReportParameter("KdvToplam", Raporlar.KdvToplam),
        new ReportParameter("KartKomisyon", Raporlar.KartKomisyon)
      };
      fRaporEkle.reportViewer1.LocalReport.SetParameters((IEnumerable<ReportParameter>) parameters);
      fRaporEkle.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
      fRaporEkle.reportViewer1.ZoomMode = ZoomMode.PageWidth;
      int num = (int) fRaporEkle.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    public static void StokRaporu(DataGridView dgv)
    {
      Cursor.Current = Cursors.WaitCursor;
      List<Urun> urunList = new List<Urun>();
      urunList.Clear();
      for (int index = 0; index < dgv.Rows.Count; ++index)
        urunList.Add(new Urun()
        {
          UrunAd = dgv.Rows[index].Cells["UrunAd"].Value.ToString(),
          UrunGrup = dgv.Rows[index].Cells["UrunGrup"].Value.ToString(),
          Birim = dgv.Rows[index].Cells["Birim"].Value.ToString(),
          SatisFiyat = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["SatisFiyat"].Value.ToString())),
          Miktar = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["Miktar"].Value.ToString())),
          SatisFiyat2 = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["SatisFiyat2"].Value.ToString())),
          SatisFiyat3 = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["SatisFiyat3"].Value.ToString())),
          SatisFiyat4 = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["SatisFiyat4"].Value.ToString())),
          SatisFiyat5 = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["SatisFiyat5"].Value.ToString()))
        });
      ReportDataSource reportDataSource = new ReportDataSource();
      reportDataSource.Name = "dsStokUrun";
      reportDataSource.Value = (object) urunList;
      fRaporEkle fRaporEkle = new fRaporEkle();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Clear();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
      fRaporEkle.reportViewer1.LocalReport.ReportPath = "C:\\Users\\ŞAHİNŞAHİN\\Source\\Repos\\SahinBarkod(1)\\SahinBarkod(1)\\bin\\Debug\\rpStokUrun.rdlc";
      ReportParameter[] parameters = new ReportParameter[3]
      {
        new ReportParameter("Baslık", Raporlar.Baslık),
        new ReportParameter("TarihBaslangic", Raporlar.TarihBaslangic),
        new ReportParameter("TarihBitis", Raporlar.TarihBitis)
      };
      fRaporEkle.reportViewer1.LocalReport.SetParameters((IEnumerable<ReportParameter>) parameters);
      fRaporEkle.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
      fRaporEkle.reportViewer1.ZoomMode = ZoomMode.PageWidth;
      int num = (int) fRaporEkle.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    public static void StokizlemeRaporu(DataGridView dgv)
    {
      Cursor.Current = Cursors.WaitCursor;
      List<StokHareket> stokHareketList = new List<StokHareket>();
      stokHareketList.Clear();
      for (int index = 0; index < dgv.Rows.Count; ++index)
        stokHareketList.Add(new StokHareket()
        {
          UrunAd = dgv.Rows[index].Cells["UrunAd"].Value.ToString(),
          UrunGrup = dgv.Rows[index].Cells["UrunGrup"].Value.ToString(),
          Birim = dgv.Rows[index].Cells["Birim"].Value.ToString(),
          Barkod = dgv.Rows[index].Cells["Barkod"].Value.ToString(),
          Miktar = new double?(islemler.DoubleYap(dgv.Rows[index].Cells["Miktar"].Value.ToString())),
          Kullanici = dgv.Rows[index].Cells["Kullanici"].Value.ToString(),
          Tarih = new DateTime?(Convert.ToDateTime(dgv.Rows[index].Cells["Tarih"].Value.ToString()))
        });
      ReportDataSource reportDataSource = new ReportDataSource();
      reportDataSource.Name = "dsStokizleme";
      reportDataSource.Value = (object) stokHareketList;
      fRaporEkle fRaporEkle = new fRaporEkle();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Clear();
      fRaporEkle.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
      fRaporEkle.reportViewer1.LocalReport.ReportPath = "C:\\Users\\ŞAHİNŞAHİN\\Source\\Repos\\SahinBarkod(1)\\SahinBarkod(1)\\bin\\Debug\\rpStokizleme.rdlc";
      ReportParameter[] parameters = new ReportParameter[3]
      {
        new ReportParameter("Baslık", Raporlar.Baslık),
        new ReportParameter("TarihBaslangic", Raporlar.TarihBaslangic),
        new ReportParameter("TarihBitis", Raporlar.TarihBitis)
      };
      fRaporEkle.reportViewer1.LocalReport.SetParameters((IEnumerable<ReportParameter>) parameters);
      fRaporEkle.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
      fRaporEkle.reportViewer1.ZoomMode = ZoomMode.PageWidth;
      int num = (int) fRaporEkle.ShowDialog();
      Cursor.Current = Cursors.Default;
    }
  }
}
