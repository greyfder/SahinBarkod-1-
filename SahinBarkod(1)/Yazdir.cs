using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    internal class Yazdir
    {
        public int? IslemNo { get; set; }
        public DateTime? Date { get; set; }
        public Yazdir(int? ıslemNo, DateTime? date)
        {
            IslemNo = ıslemNo;
            Date = date;
        }

        PrintDocument pd = new PrintDocument();

        public void YazdirmayaBasla()
        {
            try
            {
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            Barkod1Entities db = new Barkod1Entities();
            var isyeri = db.Sabit.FirstOrDefault();
            var liste = db.Satisid.Where(x => x.islemno == IslemNo).ToList();
            if (isyeri != null && liste != null)
            {

                int kagıtuzunluk = 135;
                for (int i = 0; i < liste.Count; i++)
                {
                    kagıtuzunluk += 15;
                }

                PaperSize ps58 = new PaperSize("58mm Termal", 220, kagıtuzunluk + 310);
                pd.DefaultPageSettings.PaperSize = ps58;

                Font fontbaslik = new Font("Calibri", 13, FontStyle.Bold);
                Font fontbilgi = new Font("arial", 10, FontStyle.Regular);
                Font fonttire = new Font("arial", 7, FontStyle.Regular);
                Font fonticerikbasik = new Font("Calibri", 9, FontStyle.Underline);
                Font fonttop = new Font("verdana", 11, FontStyle.Regular);

                StringFormat ortala = new StringFormat(StringFormatFlags.FitBlackBox);
                ortala.Alignment = StringAlignment.Center;
                RectangleF rcUnvanKonum = new RectangleF(0, 15, 180, 20);
                e.Graphics.DrawString(isyeri.Unvan, fontbaslik, Brushes.Black, rcUnvanKonum, ortala);
                e.Graphics.DrawString("Telefon: " + isyeri.Telefon, fontbilgi, Brushes.Black, new Point(5, 45));
                e.Graphics.DrawString("İşlem No:" + IslemNo.ToString(), fontbilgi, Brushes.Black, new Point(5, 65));
                e.Graphics.DrawString(Date.ToString(), fontbilgi, Brushes.Black, new Point(5, 85));
                e.Graphics.DrawString("----------------------------------", fontbilgi, Brushes.Black, new Point(5, 103));
                e.Graphics.DrawString("Miktar", fonticerikbasik, Brushes.Black, new Point(0, 120));
                e.Graphics.DrawString("Ürün Adı", fonticerikbasik, Brushes.Black, new Point(40, 120));
                e.Graphics.DrawString("Fiyat", fonticerikbasik, Brushes.Black, new Point(97, 120));
                e.Graphics.DrawString("Tutar", fonticerikbasik, Brushes.Black, new Point(149, 120));
                double toplammiktar = 0;
                int yukseklik = 150;
                double geneltoplam = 0;
                foreach (var item in liste)
                {
                    e.Graphics.DrawString(item.Miktar.ToString(), fontbilgi, Brushes.Black, new Point(0, yukseklik));
                    if (item.Urunad.Length < 11)
                    {
                        e.Graphics.DrawString(item.Urunad, fonttire, Brushes.Black, new Point(35, yukseklik));

                    }
                    else if (item.Urunad.Length < 18)
                    {
                        e.Graphics.DrawString(item.Urunad.Substring(0, 9), fonttire, Brushes.Black, new Point(35, yukseklik - 3));
                        e.Graphics.DrawString(item.Urunad.Substring(9), fonttire, Brushes.Black, new Point(35, yukseklik + 8));
                    }
                    else
                    {
                        e.Graphics.DrawString(item.Urunad.Substring(0, 9), fonttire, Brushes.Black, new Point(35, yukseklik - 3));
                        e.Graphics.DrawString(item.Urunad.Substring(9, 7) + "..", fonttire, Brushes.Black, new Point(35, yukseklik + 8));
                    }
                    e.Graphics.DrawString(Convert.ToDouble(item.Satisfiyat).ToString(), fontbilgi, Brushes.Black, new Point(100, yukseklik));
                    e.Graphics.DrawString(Convert.ToDouble(item.Toplam).ToString(), fontbilgi, Brushes.Black, new Point(150, yukseklik));
                    yukseklik += 25;
                    geneltoplam += Convert.ToDouble(item.Toplam);
                    toplammiktar += Convert.ToDouble(item.Miktar);
                }
                e.Graphics.DrawString("----------------------------------", fontbilgi, Brushes.Black, new Point(5, yukseklik));
                e.Graphics.DrawString("Toplam: " + geneltoplam.ToString("n2") + " TL", fonttop, Brushes.Black, new Point(5, yukseklik + 20));
                e.Graphics.DrawString("----------------------------------", fontbilgi, Brushes.Black, new Point(5, yukseklik + 40));
                e.Graphics.DrawString("(Mali Değeri Yoktur)", fontbilgi, Brushes.Black, new Point(5, yukseklik + 60));
                var kalem = liste.Count;
                e.Graphics.DrawString(kalem.ToString() + " Kalem Ürün vardır.", fonttop, Brushes.Black, new Point(5, yukseklik + 80));
                e.Graphics.DrawString(toplammiktar.ToString() + " Adet Ürün vardır.", fonttop, Brushes.Black, new Point(5, yukseklik + 100));





            }
        }
    }
}
