using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Lisans
{
    public class lic
    {
        public string CpuNo()
        {
            string islemciid = "";
            ManagementObjectSearcher ara = new ManagementObjectSearcher("Select * from WIN32_Processor"); // işlemci noyu ara
            ManagementObjectCollection obje = ara.Get();// bulduğu nesneleri buraya getirdik
            foreach (ManagementObject item in obje)//koleksiyonun i.inde ara
            {
                islemciid = item["ProcessorId"].ToString();// işlemci id sini çek
            }
            return islemciid;
        }
        public int CpuKarekterToplam()
        {
            int toplam = 0;
            foreach (char item in CpuNo().ToCharArray()) // harflerin sayısal değerlerini getir tek tek
            {
                toplam += (int)item; // hepsini int olarak topladık
            }
            return toplam;
        }
        public string gunkarakter = "LKHJDASDOIQWEUOIASCJZXKCNZXVMFBNXCVBOIQWEHOQWIEDOWIHJDAJKLSCNZXCONZXOMCNASDHASKGDQIWEASDQASFJZXKLCJZXCHAOQWSEUDYQHMNCBVZXCBKJASHGDWOQEQOWIYUEQWETASDGASHJCVBZXNMCVASKJHDGQOWEQWRPOIYUUKLHKLJAHDFASDQWPUEYQWDHZXJKCNZXCVJBPJKDWBVQCVLACNASDBQ";
        public string aykarakter = "ASDHJDPQWOWKJCOIEUQWIOERJASKLCNZXCBZMNXCVBZMNXBCKASGDLKJHQWEPQWUIOERYQWUKDHGASHJGCHJZXVBCNZXC";
        public string yilkarakter = "SDFJQWIEVGHJFGHIYOTYJRGWQDKJDHASDJKHSAEQWYRWEUIOFPEWHVCJKXBVJZHBCZXNCNWEHUFDWEPUIORYHQUIOWHEDAHCHVQPHKDJAHSKDCNASKVCBNSDVBHXJVBZXQWDCASDFSDHDFHDVCQWQZXVFXDQNWQJZAUQWIOEJZKLXGHJKTYETWREWSDFFNZXJKCASDKASGHJKDGQIWGDQWYUIGDIAWDGHJKXHCKLJZXHVKSDHVIQWEGDIQGEJHQWHJDBASKBNCASDIGVCAIYGWDIQWGHDJHBASCHZXKCJGCKLASDHFASODHQOWHEQWJEIQWUEOIDHASCJHZXC";

        public bool TarihKontrol(DateTime baslangic, DateTime bitis)
        {
            return baslangic < DateTime.Now && DateTime.Now < bitis;
        }

        public int GirilenLisansiKontolEt(string girilenlisansbilgisi)
        {
            Cursor.Current = Cursors.WaitCursor;
            double girilen = Convert.ToDouble(girilenlisansbilgisi);
            bool demomu = girilen == (CpuKarekterToplam() * 3) + (TarihFonksiyon() * 7);
            bool yillikmi = girilen == (CpuKarekterToplam() / 2) + (TarihFonksiyon() * 8);
            int durum = 0;
            if (demomu)
            {
                durum = 1;
            }
            else if (yillikmi)
            {
                durum = 2;
            }
            else
            {
                durum = 0;
            }


            Cursor.Current = Cursors.Default;
            return durum;
        }

        public DateTime DemoTarihiOlustur()
        {
            DateTime tarih = DateTime.Now.AddDays(10);
            return tarih;
        }
        public DateTime YillikTarihOlustur()
        {
            DateTime tarih = DateTime.Now.AddYears(1);
            return tarih;
        }

        public long EkrandaGoster()
        {
            long gosterlicekno = CpuKarekterToplam() * TarihFonksiyon();
            return gosterlicekno;
        }
        public long TarihFonksiyon()
        {
            return (DateTime.Now.Day + DateTime.Now.Month) * DateTime.Now.Year;
        }

        public DateTime TarihCoz(string sifrelitarih)
        {
            string strgun = sifrelitarih.Substring(0, 2); // veri tabanından gelen verinin ilk 2 al
            string stray = sifrelitarih.Substring(2, 2);//veri tabanından gelen verinin 2den  4e al
            string stryil = sifrelitarih.Substring(4, 2);//veri tabanından gelen verinin son 2 al
            int gun = gunler().Where(x => x.Ad == strgun).FirstOrDefault().Numara; // aşağıdaki listelerden harflerin karşılığını bul
            int ay = aylar().Where(x => x.Ad == stray).FirstOrDefault().Numara;// aşağıdaki listelerden harflerin karşılığını bul
            int yil = yillar().Where(x => x.Ad == stryil).FirstOrDefault().Numara;// aşağıdaki listelerden harflerin karşılığını bul
            DateTime tarih = new DateTime(yil, ay, gun);//tarihi rakam olarak oluşturduk
            return tarih; // döndürdük
        }
        public string TarihSifrele(DateTime tarih)
        {
            int gun = tarih.Day;
            int ay = tarih.Month;
            int yil = tarih.Year;
            string strgun = gunler().Where(x => x.Numara == gun).FirstOrDefault().Ad;
            string stray = aylar().Where(x => x.Numara == ay).FirstOrDefault().Ad;
            string stryil = yillar().Where(x => x.Numara == yil).FirstOrDefault().Ad;
            string sifreliTarih = strgun + stray + stryil;
            return sifreliTarih;
        }

        public List<Sablon> gunler()
        {
            List<Sablon> listGun = new List<Sablon>();
            for (int i = 0; i < 31; i++)
            {
                listGun.Add(new Sablon { Numara = i + 1, Ad = gunkarakter.ToString().Substring(i * 2, 2) });//31 e kadar her iki harfi al
            }
            return listGun;
        }
        public List<Sablon> aylar()
        {
            List<Sablon> listAy = new List<Sablon>();
            for (int i = 0; i < 12; i++)
            {
                listAy.Add(new Sablon { Numara = i + 1, Ad = aykarakter.ToString().Substring(i * 2, 2) });
            }
            return listAy;
        }
        public List<Sablon> yillar()
        {
            List<Sablon> listYil = new List<Sablon>();
            int karaktersayisi = 0;
            for (int i = 2022; i < 2050; i++)
            {
                listYil.Add(new Sablon { Numara = i, Ad = yilkarakter.ToString().Substring(karaktersayisi * 2, 2) });
                karaktersayisi += 2;
            }
            return listYil;
        }

        public class Sablon
        {
            public int Numara { get; set; }
            public string Ad { get; set; }
        }

    }
}
