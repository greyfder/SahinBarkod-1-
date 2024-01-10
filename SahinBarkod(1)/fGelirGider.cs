using System;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }
        public string gelirgider { get; set; }
        public string kullanici { get; set; }
        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = gelirgider + " İŞLEMİ YAPILIYOR.";
        }

        private void cmİslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmİslemTuru.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }
            else if (cmİslemTuru.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }
            else if (cmİslemTuru.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmİslemTuru.Text != "")
            {
                if (tNakit.Text != "" || tKart.Text != "" && tNakit.Text != "0" && tKart.Text != "0")
                {
                    using (var db = new Barkod1Entities())
                    {
                        islemOzet io = new islemOzet();
                        io.İslemNo = 0;
                        io.İade = false;
                        io.OdemeSekli = cmİslemTuru.Text;
                        io.Nakit = islemler.DoubleYap(tNakit.Text);
                        io.Kart = islemler.DoubleYap(tKart.Text);
                        if (gelirgider == "GELİR")
                        {
                            io.Gelir = true;
                            io.Gider = false;
                        }
                        else
                        {
                            io.Gider = false;
                            io.Gider = true;
                        }
                        io.AlısFiyatToplam = 0;
                        io.Acıklama = gelirgider + " - işlemi " + tAcıklama.Text;
                        io.Tarih = dtTarih.Value;
                        io.Kullanici = kullanici;
                        db.islemOzet.Add(io);
                        db.SaveChanges();
                        MessageBox.Show(gelirgider + " işlemi kaydedildi.");
                        tNakit.Text = "0";
                        tKart.Text = "0";
                        tAcıklama.Text = "";
                        cmİslemTuru.Text = "";
                        fRapor f = (fRapor)Application.OpenForms["fRapor"];
                        if (f != null)
                        {
                            f.bGöster_Click(null, null); // diğer formdaki butonu kullandık
                        }
                        this.Hide();

                    }
                }
            }
            else
            {
                MessageBox.Show("LÜtfen Ödeme Türünü Belirleyiniz.");
            }
        }
    }
}
