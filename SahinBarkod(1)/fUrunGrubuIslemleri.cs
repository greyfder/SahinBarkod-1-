using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fUrunGrubuIslemleri : Form
    {
        public fUrunGrubuIslemleri()
        {
            InitializeComponent();
        }
        Barkod1Entities db = new Barkod1Entities();
        private void fUrunGrubuIslemleri_Load(object sender, EventArgs e)
        {
            GrupDoldur();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (tUrunGrupAd.Text != "")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd = tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                MessageBox.Show("Ürün Grubu Eklenmiştir.");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"]; // halihazırda açıklan formu çağır ve işlem yap 
                if (f != null)
                {
                    f.GrupDoldur();
                }

            }
            else
            {
                MessageBox.Show("Mesaj Bilgisi Ekleyiniz.");
            }
        }
        private void GrupDoldur()
        {
            listurungrup.DisplayMember = "UrunGrupAd";
            listurungrup.ValueMember = "Id";
            listurungrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listurungrup.SelectedValue.ToString());
            string grupad = listurungrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "Grubu Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupad + "Ürünü Silindi.");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"]; // halihazırda açıklan formu çağır ve işlem yap
                if (f != null)
                {
                    f.GrupDoldur();
                }
            }

        }
    }
}
