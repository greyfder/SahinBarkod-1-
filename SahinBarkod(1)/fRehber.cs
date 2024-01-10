using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SahinBarkod_1_
{
    public partial class fRehber : Form
    {
        public fRehber()
        {
            InitializeComponent();
        }
        Barkod1Entities db=new Barkod1Entities();
        private void fRehber_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

            
            
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            
            string urunad = tUrunAra.Text;
            GridUrunler.DataSource = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
            GridUrunler.Columns["SatisFiyat"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["SatisFiyat2"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["SatisFiyat3"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["SatisFiyat4"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["SatisFiyat5"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["Barkod"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["UrunAd"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            GridUrunler.Columns["Barkod"].Width = 5;
            GridUrunler.Columns["UrunGrup"].Visible = false;
            GridUrunler.Columns["SatisFiyat"].Width = 100;
            GridUrunler.Columns["SatisFiyat2"].Width = 90;
            GridUrunler.Columns["SatisFiyat3"].Width = 90;
            GridUrunler.Columns["SatisFiyat4"].Width = 90;
            GridUrunler.Columns["SatisFiyat5"].Width = 90;
           
            GridUrunler.Columns["UrunAd"].Width = 350;
            GridUrunler.Columns["Onay"].Visible = false;
            GridUrunler.Columns["KdvTutari"].Visible = false;
            GridUrunler.Columns["KdvOrani"].Visible = false;
            GridUrunler.Columns["Kullanci"].Visible = false;
            GridUrunler.Columns["Miktar"].Visible = false;
            GridUrunler.Columns["Birim"].Visible = false;
            GridUrunler.Columns["AlisFiyat"].Visible = false;
            GridUrunler.Columns["Urunid"].Visible = false;
            GridUrunler.Columns["Acıklama"].Visible = false;
            GridUrunler.Columns["Tarih"].Visible = false;
            islemler.GridDuzenle(GridUrunler);
            
        }
        private void getir()
        {
            if (GridUrunler.RowCount == 0) return;
            Form1 f = (Form1)Application.OpenForms["Form1"];
            var rehber = GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
            int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == rehber).Select(b => b.Urunid).FirstOrDefault());
            var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();//onu  urune tanımla
            f.UrunGetirListeye(urun, urunid, 1); // void oluşturduk
            f.GenelToplam();
            this.Close();
        }
        private void duzenle()
        {
            if (GridUrunler.RowCount == 0) return;
            fUrunGiris f = new fUrunGiris();
            f.tbarkod.Text = GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
            f.tbarkodGetir(f.tbarkod.Text);
            f.ShowDialog();
            this.Close();
        }
        private void GridUrunler_DoubleClick(object sender, EventArgs e)
        {
            getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            duzenle();
        }
    }
}
