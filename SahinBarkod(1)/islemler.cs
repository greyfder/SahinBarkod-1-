using System;
using System.Data.Entity;
using System.Globalization; //number styles için 
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    static class islemler
    {
        public static double DoubleYap(string deger) // string olan değeri
        {
            double sonuc = 0; // sonucu 0 olarak tanıttık
            double.TryParse(deger, NumberStyles.Currency, CultureInfo.CurrentUICulture.NumberFormat, out sonuc);// sonucu çevirdik  number style li arkadaş para birimi olarak gelsin diye
            return sonuc;// double olarak getir  
        }
        public static void StokAzalt(string Barkod, double Miktar)
        {
            using (var db = new Barkod1Entities())
            {
                //if (Barkod != "1111111111116")
                if (Barkod != "1" && Barkod != "2" && Barkod != "3" && Barkod != "4" && Barkod != "5" && Barkod != "6" && Barkod != "7" && Barkod != "8" && Barkod != "9" && Barkod != "10" )
                {
                  
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == Barkod);
                    //urunbilgi.Miktar= urunbilgi.Miktar - Miktar; // urun yol
                    urunbilgi.Miktar -= Miktar;// kısa yol 
                    db.SaveChanges();
                }

            }
        }
        public static void StokArttır(string Barkod, double Miktar)
        {
            using (var db = new Barkod1Entities())
            {

                //if (Barkod != "1111111111116")
                if (Barkod != "1" && Barkod != "2" && Barkod != "3" && Barkod != "4" && Barkod != "5" && Barkod != "6" && Barkod != "7" && Barkod != "8" && Barkod != "9" && Barkod != "10")
                {
                    var urunbilgi = db.Urun.SingleOrDefault(x => x.Barkod == Barkod);
                    //urunbilgi.Miktar = urunbilgi.Miktar + Miktar; // urun yol
                    urunbilgi.Miktar += Miktar;// kısa yol 
                    db.SaveChanges();
                }
            }
        }
        public static void GridDuzenle(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    switch (dgv.Columns[i].HeaderText)
                    {
                        case "Id":
                            dgv.Columns[i].HeaderText = "Numara"; break;
                        case "İslemNo":
                            dgv.Columns[i].HeaderText = "İşlem No"; break;
                        case "islemno":
                            dgv.Columns[i].HeaderText = "İşlem No"; break;
                        case "Urunid":
                            dgv.Columns[i].HeaderText = "Urun Numarası"; break;
                        case "UrunAd":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "Urunad":
                            dgv.Columns[i].HeaderText = "Ürün Adı"; break;
                        case "Acıklama":
                            dgv.Columns[i].HeaderText = "Açıklama"; break;
                        case "AlisFiyat":
                            dgv.Columns[i].HeaderText = "Alış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "AlısFiyatToplam":
                            dgv.Columns[i].HeaderText = "Alış Fiyat Toplamı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "SatisFiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "Satisfiyat":
                            dgv.Columns[i].HeaderText = "Satış Fiyatı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "KdvOrani":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].HeaderText = "Kdv Oranı"; break;
                        case "Birim":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "Miktar":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "OdemeSekli":
                            dgv.Columns[i].HeaderText = "Ödeme Şekli";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "Kart":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Nakit":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gelir":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Gider":
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Kullanici":
                            dgv.Columns[i].HeaderText = "Kullanıcı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; break;
                        case "KdvTutari":
                            dgv.Columns[i].HeaderText = "Kdv Tutarı";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;
                        case "Toplam":
                            dgv.Columns[i].HeaderText = "Toplam";
                            dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dgv.Columns[i].DefaultCellStyle.Format = "C2"; break;

                    }
                }
            }
        }
        public static void StokHareket(string barkod, string urunad, string birim, double miktar, string urungrup, string kullanici)
        {
            Barkod1Entities db = new Barkod1Entities();

            StokHareket sh = new StokHareket();
            sh.Barkod = barkod;
            sh.UrunAd = urunad;
            sh.Birim = birim;
            sh.Miktar = miktar;
            sh.UrunGrup = urungrup;
            sh.Kullanici = kullanici;
            sh.Tarih = DateTime.Now;
            db.StokHareket.Add(sh);
            db.SaveChanges();

        }
        public static int KartKomisyon()
        {
            int sonuc = 0; // soru işareti null olabilir demek
            using (var db = new Barkod1Entities())
            {
                if (db.Sabit.Any())
                {
                    sonuc = Convert.ToInt16(db.Sabit.First().KartKomisyon);
                }
                else
                {
                    sonuc = 0;
                }
            }
            return sonuc;
        }
        public static void SabitVarsayilan()
        {
            using (var db = new Barkod1Entities())
            {
                if (!db.Sabit.Any())
                {
                    Sabit s = new Sabit();
                    s.KartKomisyon = 0;
                    s.Yazici = false;
                    s.AdSoyad = "admin";
                    s.Unvan = "admin";
                    s.Adres = "admin";
                    s.Telefon = "admin";
                    s.EPosta = "admin";
                    db.Sabit.Add(s);
                    db.SaveChanges();
                }
            }
        }
        public static void Backup()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Veri yedek dosyası |0.bak";
            save.FileName = "Barkodlu_Satis_Programı_Sahin_" + DateTime.Now.ToShortDateString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (File.Exists(save.FileName))//eğer aynı günde bir kayıt var ise
                    {
                        File.Delete(save.FileName);//eskisini sil (silmezsen dosya boyutu katlar)
                    }
                    var dbHedef = save.FileName;//seçilen kaydetme yeri
                   // string dbKaynak = Application.StartupPath + @"\Barkod1.mdf";// programın kurulu olduğu dosyada db dosyası localdb adresi
                    using (var db = new Barkod1Entities())
                    {
                        string dbKaynak = db.Database.Connection.Database;//Sql Server'daki adress
                        var cmd = @"BACKUP DATABASE[" + dbKaynak + "] TO DISK='" + dbHedef + "'";//veri tabını backup komutu oluşturduk yerini söyledik
                        db.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, cmd); // komutu çalıştır
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Yedekleme Tamamlandı.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }

}
