using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fStok : Form
    {

        public fStok()
        {
            InitializeComponent();


        }
        Barkod1Entities dbx = new Barkod1Entities();
        public class ProductContext : DbContext
        {
            public DbSet<Urun> Categories { get; set; }
            public DbSet<CokluB> Products { get; set; }
        }
        private void bAra_Click(object sender, EventArgs e)
        {


            GridListe.DataSource = null;
            using (Barkod1Entities db = new Barkod1Entities())
            {
                if (cmİslemTuru.Text != "")
                {

                    string urungrubu = cmUrunGrup.Text;
                    if (cmİslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked == true)
                        {

                            db.Urun.OrderBy(x => x.Miktar).Load();
                            GridListe.DataSource = db.Urun.Local.ToBindingList();
                            this.GridListe.Columns["Urunid"].Visible = false;
                            this.GridListe.Columns["SatisFiyat2"].Visible = false;
                            this.GridListe.Columns["SatisFiyat3"].Visible = false;
                            this.GridListe.Columns["SatisFiyat4"].Visible = false;
                            this.GridListe.Columns["SatisFiyat5"].Visible = false;
                            this.GridListe.Columns["AlisFiyat"].Visible = false;
                            this.GridListe.Columns["KdvTutari"].Visible = false;
                            this.GridListe.Columns["Acıklama"].Visible = false;


                        }
                        else if (rdUrunGrubu.Checked == true)
                        {

                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            GridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz.");
                        }
                    }
                    else if (cmİslemTuru.SelectedIndex == 1)
                    {

                        DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                        DateTime bitis = DateTime.Parse(dateBitis.Value.ToShortDateString());
                        bitis = bitis.AddDays(1);// bir gün ekledik tam gelmiyordu 
                        if (rdTumu.Checked == true)
                        {
                            GridListe.Rows.Clear();
                            GridListe.Refresh();
                            GridListe.DataSource = null;
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).Load();
                            GridListe.DataSource = db.StokHareket.Local.ToBindingList();


                        }
                        else if (rdUrunGrubu.Checked == true)
                        {
                            db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                            GridListe.DataSource = db.StokHareket.Local.ToBindingList();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen İşelem Türü Seçiniz.");
                }

            }
            islemler.GridDuzenle(GridListe);
        }

        private void fStok_Load(object sender, EventArgs e)
        {
            cmUrunGrup.DisplayMember = "UrunGrupAd";
            cmUrunGrup.ValueMember = "Id";
            cmUrunGrup.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text.Length >= 2)
            {
                string urunad = tUrunAra.Text;
                using (var dba = new Barkod1Entities())
                {

                    //dba.Configuration.LazyLoadingEnabled = false;
                    if (cmİslemTuru.SelectedIndex == 0)
                    {

                        dba.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        GridListe.DataSource = dba.Urun.Local.ToBindingList();
                    }
                    else if (cmİslemTuru.SelectedIndex == 1)
                    {
                        dba.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        GridListe.DataSource = dba.StokHareket.Local.ToBindingList();
                    }
                }
                islemler.GridDuzenle(GridListe);
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {
            if (cmİslemTuru.SelectedIndex == 0)
            {
                Raporlar.Baslık = cmİslemTuru.Text + " Raporu";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokRaporu(GridListe);
            }
            else if (cmİslemTuru.SelectedIndex == 1)
            {
                Raporlar.Baslık = cmİslemTuru.Text + " Raporu";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitis.Value.ToShortDateString();
                Raporlar.StokizlemeRaporu(GridListe);
            }
        }

        private void b200_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
