using System;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fRapor : Form
    {
        public fRapor()
        {
            InitializeComponent();
        }

        private void dateBaslangic_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lBitisTarih_Click(object sender, EventArgs e)
        {

        }

        private void lBaslangıctarih_Click(object sender, EventArgs e)
        {

        }

        private void dateBitis_ValueChanged(object sender, EventArgs e)
        {

        }

        public void bGöster_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor; // İşlem yaparken Fare nasıl görünecek 
            DateTime baslangic = DateTime.Parse(dtBaslangıc.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);// +1 ekliyoruz öyle algılıyor
            using (var db = new Barkod1Entities())
            {
                if (listfiltrelemeturu.SelectedIndex == 0) // tümünü getir
                {
                    db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                    var islemozet = db.islemOzet.Local.ToBindingList();
                    GridListe.DataSource = islemozet;
                    tSatisNakit.Text = Convert.ToDouble(islemozet.Where(x => x.İade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Nakit)).ToString("C2");
                    tSatisKart.Text = Convert.ToDouble(islemozet.Where(x => x.İade == false && x.Gelir == false && x.Gider == false).Sum(x => x.Kart)).ToString("C2");

                    tİadeNakit.Text = Convert.ToDouble(islemozet.Where(x => x.İade == true).Sum(x => x.Nakit)).ToString("C2");
                    tİadeKart.Text = Convert.ToDouble(islemozet.Where(x => x.İade == true).Sum(x => x.Kart)).ToString("C2");

                    tGelirNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Nakit)).ToString("C2");
                    tGelirKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gelir == true).Sum(x => x.Kart)).ToString("C2");

                    tGiderNakit.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Nakit)).ToString("C2");
                    tGiderKart.Text = Convert.ToDouble(islemozet.Where(x => x.Gider == true).Sum(x => x.Kart)).ToString("C2");

                    db.Satisid.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                    var satistablosu = db.Satisid.Local.ToBindingList();
                    double KdvTutariSatis = islemler.DoubleYap(satistablosu.Where(x => x.İade == false).Sum(x => x.Kdvtutari).ToString());
                    double KdvTutariİade = islemler.DoubleYap(satistablosu.Where(x => x.İade == true).Sum(x => x.Kdvtutari).ToString());
                    tKdvToplam.Text = (KdvTutariSatis - KdvTutariİade).ToString("C2");


                }
                else if (listfiltrelemeturu.SelectedIndex == 1)// Satışlar
                {
                    db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.İade == false && x.Gelir == false && x.Gider == false).Load();
                    var islemozet = db.islemOzet.Local.ToBindingList();
                    GridListe.DataSource = islemozet;
                }
                else if (listfiltrelemeturu.SelectedIndex == 2) // İadeler
                {
                    db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.İade == true).Load();
                    GridListe.DataSource = db.islemOzet.Local.ToBindingList();
                }
                else if (listfiltrelemeturu.SelectedIndex == 3) // Gelirler
                {
                    db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gelir == true).Load();
                    GridListe.DataSource = db.islemOzet.Local.ToBindingList();
                }
                else if (listfiltrelemeturu.SelectedIndex == 4) // Giderler
                {
                    db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.Gider == true).Load();
                    GridListe.DataSource = db.islemOzet.Local.ToBindingList();
                }
            }

            islemler.GridDuzenle(GridListe);
            Cursor.Current = Cursors.Default;
        }

        private void fRapor_Load(object sender, EventArgs e)
        {
            listfiltrelemeturu.SelectedIndex = 0;
            tKartKomisyon.Text = islemler.KartKomisyon().ToString();
            bGöster_Click(null, null);
        }

        private void GridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7) // 2. 6. ve 7. sütünlarda 
            {
                if (e.Value is bool) // tabloda true false olanları evet hayır yazıcaz 
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;

                }
            }
        }

        private void bGelirEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void bGiderEkle_Click(object sender, EventArgs e)
        {
            fGelirGider f = new fGelirGider();
            f.gelirgider = "GELİR";
            f.kullanici = lkullanici.Text;
            f.ShowDialog();
        }

        private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGöster f = new fDetayGöster();
                    f.İslemNo = islemno;
                    f.ShowDialog();

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (GridListe.Rows.Count > 0)
            //{
            //    int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());

            //    using (var db = new Barkod1Entities())
            //    {
            //        Form1 f = new Form1();
            //        string barkod1 = db.Satisid.Where(x => x.islemno == islemno).Select(s => s.Barkod).ToString();
            //        var miktar = db.Satisid.Where(x => x.islemno == islemno).Select(s => s.Miktar);


            //        if (db.CokluB.Any(a => a.Barkod == barkod1))//any gelen bilgi data base mevcut mu diye kontrol ediyor varsa
            //        {
            //            int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod1).Select(b => b.Urunid).FirstOrDefault());
            //            var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();//onu  urune tanımla
            //            f.UrunGetirListeye(urun, urunid, Convert.ToDouble(miktar.ToString())); // void oluşturduk

            //        }

            //        f.ShowDialog();
            //        this.Hide();



            //    }
            //}
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            Raporlar.Baslık = "GENEL RAPOR";
            Raporlar.SatisKart = tSatisKart.Text;
            Raporlar.SatisNakit = tSatisNakit.Text;
            Raporlar.İadeKart = tİadeKart.Text;
            Raporlar.İadeNakit = tİadeNakit.Text;
            Raporlar.GelirKart = tGelirKart.Text;
            Raporlar.GelirNakit = tGelirNakit.Text;
            Raporlar.GiderNakit = tGiderNakit.Text;
            Raporlar.GiderKart = tGiderKart.Text;
            Raporlar.TarihBaslangic = dtBaslangıc.Value.ToShortDateString();
            Raporlar.TarihBitis = dtBitis.Value.ToShortDateString();
            Raporlar.KdvToplam = tKdvToplam.Text;
            Raporlar.KartKomisyon = tKartKomisyon.Text;
            Raporlar.RaporSayfasiRaporu(GridListe);
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                DateTime? dt = DateTime.Now;
                if (islemno != 0)
                {
                    Yazdir yazdir = new Yazdir(islemno, dt);
                    yazdir.YazdirmayaBasla();

                }
            }
        }

        private void tYazdır_Click(object sender, EventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                DateTime? dt = Convert.ToDateTime(GridListe.CurrentRow.Cells["Tarih"].Value.ToString());
                if (islemno != 0)
                {
                    Yazdir yazdir = new Yazdir(islemno, dt);
                    yazdir.YazdirmayaBasla();

                }
            }
        }

        private void GridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGöster f = new fDetayGöster();
                    f.İslemNo = islemno;
                    f.ShowDialog();

                }
            }
        }

        private void b200_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
