using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    static class Raporlar
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
            List<islemOzet> list = new List<islemOzet>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new islemOzet
                {
                    İslemNo = Convert.ToInt32(dgv.Rows[i].Cells["İslemNo"].Value.ToString()),
                    İade = Convert.ToBoolean(dgv.Rows[i].Cells["İade"].Value),
                    OdemeSekli = dgv.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Nakit = islemler.DoubleYap(dgv.Rows[i].Cells["Nakit"].Value.ToString()),
                    Kart = islemler.DoubleYap(dgv.Rows[i].Cells["Kart"].Value.ToString()),
                    Gelir = Convert.ToBoolean(dgv.Rows[i].Cells["Gelir"].Value),
                    Gider = Convert.ToBoolean(dgv.Rows[i].Cells["Gider"].Value),
                    AlısFiyatToplam = islemler.DoubleYap(dgv.Rows[i].Cells["AlısFiyatToplam"].Value.ToString()),
                    Acıklama = dgv.Rows[i].Cells["OdemeSekli"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString(),

                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsGenelRapor";
            rs.Value = list;
            fRaporEkle f = new fRaporEkle();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = @"C:\Users\ŞAHİNŞAHİN\Source\Repos\SahinBarkod(1)\SahinBarkod(1)\bin\Debug\rpGenelRapor.rdlc";

            ReportParameter[] prm = new ReportParameter[13];
            prm[0] = new ReportParameter("Baslık", Baslık);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);
            prm[3] = new ReportParameter("SatisNakit", SatisNakit);
            prm[4] = new ReportParameter("SatisKart", SatisKart);
            prm[5] = new ReportParameter("İadeNakit", İadeNakit);
            prm[6] = new ReportParameter("İadeKart", İadeKart);
            prm[7] = new ReportParameter("GelirNakit", GelirNakit);
            prm[8] = new ReportParameter("GelirKart", GelirKart);
            prm[9] = new ReportParameter("GiderNakit", GiderNakit);
            prm[10] = new ReportParameter("GiderKart", GiderKart);
            prm[11] = new ReportParameter("KdvToplam", KdvToplam);
            prm[12] = new ReportParameter("KartKomisyon", KartKomisyon);
            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<Urun> list = new List<Urun>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new Urun
                {
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    UrunGrup = dgv.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    SatisFiyat = islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat"].Value.ToString()),
                    Miktar = islemler.DoubleYap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    SatisFiyat2 = islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat2"].Value.ToString()),
                    SatisFiyat3 = islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat3"].Value.ToString()),
                    SatisFiyat4 = islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat4"].Value.ToString()),
                    SatisFiyat5 = islemler.DoubleYap(dgv.Rows[i].Cells["SatisFiyat5"].Value.ToString()),
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokUrun";
            rs.Value = list;
            fRaporEkle f = new fRaporEkle();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = @"C:\Users\ŞAHİNŞAHİN\Source\Repos\SahinBarkod(1)\SahinBarkod(1)\bin\Debug\rpStokUrun.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslık", Baslık);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);

            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }
        public static void StokizlemeRaporu(DataGridView dgv)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<StokHareket> list = new List<StokHareket>();
            list.Clear();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(new StokHareket
                {
                    UrunAd = dgv.Rows[i].Cells["UrunAd"].Value.ToString(),
                    UrunGrup = dgv.Rows[i].Cells["UrunGrup"].Value.ToString(),
                    Birim = dgv.Rows[i].Cells["Birim"].Value.ToString(),
                    Barkod = dgv.Rows[i].Cells["Barkod"].Value.ToString(),
                    Miktar = islemler.DoubleYap(dgv.Rows[i].Cells["Miktar"].Value.ToString()),
                    Kullanici = dgv.Rows[i].Cells["Kullanici"].Value.ToString(),
                    Tarih = Convert.ToDateTime(dgv.Rows[i].Cells["Tarih"].Value.ToString())
                });
            }


            ReportDataSource rs = new ReportDataSource();
            rs.Name = "dsStokizleme";
            rs.Value = list;
            fRaporEkle f = new fRaporEkle();
            f.reportViewer1.LocalReport.DataSources.Clear();
            f.reportViewer1.LocalReport.DataSources.Add(rs);
            f.reportViewer1.LocalReport.ReportPath = @"C:\Users\ŞAHİNŞAHİN\Source\Repos\SahinBarkod(1)\SahinBarkod(1)\bin\Debug\rpStokizleme.rdlc";

            ReportParameter[] prm = new ReportParameter[3];
            prm[0] = new ReportParameter("Baslık", Baslık);
            prm[1] = new ReportParameter("TarihBaslangic", TarihBaslangic);
            prm[2] = new ReportParameter("TarihBitis", TarihBitis);

            f.reportViewer1.LocalReport.SetParameters(prm);
            f.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            f.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }


    }
}
