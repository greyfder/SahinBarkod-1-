// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.Yazdir
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal class Yazdir
  {
    private PrintDocument pd = new PrintDocument();

    public int? IslemNo { get; set; }

    public Yazdir(int? ıslemNo) => this.IslemNo = ıslemNo;

    public void YazdirmayaBasla()
    {
      try
      {
        this.pd.PrintPage += new PrintPageEventHandler(this.Pd_PrintPage);
        this.pd.Print();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void Pd_PrintPage(object sender, PrintPageEventArgs e)
    {
      Barkod1Entities barkod1Entities = new Barkod1Entities();
      Sabit sabit = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
      List<Satisid> list = barkod1Entities.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => x.islemno == this.IslemNo)).ToList<Satisid>();
      if (sabit == null || list == null)
        return;
      int num1 = 135;
      for (int index = 0; index < list.Count; ++index)
        num1 += 15;
      this.pd.DefaultPageSettings.PaperSize = new PaperSize("58mm Termal", 220, num1 + 310);
      Font font1 = new Font("Calibri", 13f, FontStyle.Bold);
      Font font2 = new Font("arial", 10f, FontStyle.Regular);
      Font font3 = new Font("arial", 7f, FontStyle.Regular);
      Font font4 = new Font("Calibri", 9f, FontStyle.Underline);
      Font font5 = new Font("verdana", 11f, FontStyle.Regular);
      StringFormat format = new StringFormat(StringFormatFlags.FitBlackBox);
      format.Alignment = StringAlignment.Center;
      RectangleF layoutRectangle = new RectangleF(0.0f, 15f, 180f, 20f);
      e.Graphics.DrawString(sabit.Unvan, font1, Brushes.Black, layoutRectangle, format);
      e.Graphics.DrawString("Telefon: " + sabit.Telefon, font2, Brushes.Black, (PointF) new Point(5, 45));
      e.Graphics.DrawString("İşlem No:" + this.IslemNo.ToString(), font2, Brushes.Black, (PointF) new Point(5, 65));
      e.Graphics.DrawString(DateTime.Now.ToString(), font2, Brushes.Black, (PointF) new Point(5, 85));
      e.Graphics.DrawString("----------------------------------", font2, Brushes.Black, (PointF) new Point(5, 103));
      e.Graphics.DrawString("Miktar", font4, Brushes.Black, (PointF) new Point(0, 120));
      e.Graphics.DrawString("Ürün Adı", font4, Brushes.Black, (PointF) new Point(40, 120));
      e.Graphics.DrawString("Fiyat", font4, Brushes.Black, (PointF) new Point(97, 120));
      e.Graphics.DrawString("Tutar", font4, Brushes.Black, (PointF) new Point(149, 120));
      double num2 = 0.0;
      int y = 150;
      double num3 = 0.0;
      foreach (Satisid satisid in list)
      {
        e.Graphics.DrawString(satisid.Miktar.ToString(), font2, Brushes.Black, (PointF) new Point(0, y));
        if (satisid.Urunad.Length < 11)
          e.Graphics.DrawString(satisid.Urunad, font3, Brushes.Black, (PointF) new Point(35, y));
        else if (satisid.Urunad.Length > 18)
        {
          e.Graphics.DrawString(satisid.Urunad.Substring(0, 9), font3, Brushes.Black, (PointF) new Point(35, y - 3));
          e.Graphics.DrawString(satisid.Urunad.Substring(9, 9), font3, Brushes.Black, (PointF) new Point(35, y + 8));
        }
        else
        {
          e.Graphics.DrawString(satisid.Urunad.Substring(0, 9), font3, Brushes.Black, (PointF) new Point(35, y - 3));
          e.Graphics.DrawString(satisid.Urunad.Substring(9), font3, Brushes.Black, (PointF) new Point(35, y + 8));
        }
        Graphics graphics1 = e.Graphics;
        double num4 = Convert.ToDouble((object) satisid.Satisfiyat);
        string s1 = num4.ToString();
        Font font6 = font2;
        Brush black1 = Brushes.Black;
        PointF point1 = (PointF) new Point(100, y);
        graphics1.DrawString(s1, font6, black1, point1);
        Graphics graphics2 = e.Graphics;
        num4 = Convert.ToDouble((object) satisid.Toplam);
        string s2 = num4.ToString();
        Font font7 = font2;
        Brush black2 = Brushes.Black;
        PointF point2 = (PointF) new Point(150, y);
        graphics2.DrawString(s2, font7, black2, point2);
        y += 25;
        num3 += Convert.ToDouble((object) satisid.Toplam);
        num2 += Convert.ToDouble((object) satisid.Miktar);
      }
      e.Graphics.DrawString("----------------------------------", font2, Brushes.Black, (PointF) new Point(5, y));
      e.Graphics.DrawString("Toplam: " + num3.ToString() + " TL", font5, Brushes.Black, (PointF) new Point(5, y + 20));
      e.Graphics.DrawString("----------------------------------", font2, Brushes.Black, (PointF) new Point(5, y + 40));
      e.Graphics.DrawString("(Mali Değeri Yoktur)", font2, Brushes.Black, (PointF) new Point(5, y + 60));
      int count = list.Count;
      e.Graphics.DrawString(count.ToString() + " Kalem Ürün vardır.", font5, Brushes.Black, (PointF) new Point(5, y + 80));
      e.Graphics.DrawString(num2.ToString() + " Adet Ürün vardır.", font5, Brushes.Black, (PointF) new Point(5, y + 100));
    }
  }
}
