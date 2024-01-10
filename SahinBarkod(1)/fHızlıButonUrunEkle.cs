using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SahinBarkod_1_
{
    public partial class fHızlıButonUrunEkle : Form
    {
        public fHızlıButonUrunEkle()
        {
            InitializeComponent();
        }
        Barkod1Entities db = new Barkod1Entities();
        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAra.Text != "")
            {
                string urunad = tUrunAra.Text;
                var urunler = db.Urun.Where(a => a.UrunAd.Contains(urunad)).ToList();
                GridUrunler.DataSource = urunler;
                GridUrunler.Columns[0].Width = 50;
                GridUrunler.Columns[1].Width = 150;
                GridUrunler.Columns[2].Width = 475;
                GridUrunler.Columns[3].Width = 95;
                GridUrunler.Columns[4].Width = 150;
                GridUrunler.Columns[5].Width = 60;
                GridUrunler.Columns[7].Width = 50;
                GridUrunler.Columns[7].Width = 60;
                GridUrunler.Columns[17].Width = 75;
            }
            islemler.GridDuzenle(GridUrunler);
        }

        private void GridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUrunler.Rows.Count > 0)
            {
                string Barkod = GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string Urunad = GridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double Fiyat = Convert.ToDouble(GridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
                int id = Convert.ToInt16(lbutonid.Text);
                var guncellenecek = db.HızlıUrun.Find(id);
                guncellenecek.Barkod = Barkod;
                guncellenecek.UrunAd = Urunad;
                guncellenecek.Fiyat = Fiyat;
                db.SaveChanges();
                MessageBox.Show("Ürün Tanımlandı.");
                Form1 f = (Form1)Application.OpenForms["Form1"];
                if (f != null)
                {
                    Button b = f.Controls.Find("bh" + id, true).FirstOrDefault() as Button;
                    b.Text = Urunad + "\n" + Fiyat.ToString("C2");
                }
            }
        }

        private void fHızlıButonUrunEkle_Load(object sender, EventArgs e)
        {
            tUrunAra.Focus();

        }

        private void chtumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chtumu.Checked) //seçiliyle tüm ürünleri göster
            {
                GridUrunler.DataSource = db.Urun.ToList();
                GridUrunler.Columns["AlisFiyat"].Visible = false;
                GridUrunler.Columns["SatisFiyat"].Visible = false;
                GridUrunler.Columns["KdvOrani"].Visible = false;
                GridUrunler.Columns["KdvTutari"].Visible = false;
                GridUrunler.Columns["Miktar"].Visible = false;
                GridUrunler.Columns["SatisFiyat2"].Visible = false;
                GridUrunler.Columns["SatisFiyat3"].Visible = false;
                GridUrunler.Columns["SatisFiyat4"].Visible = false;
                GridUrunler.Columns["SatisFiyat5"].Visible = false;
                islemler.GridDuzenle(GridUrunler);
                GridUrunler.Columns[0].Width = 50;
                GridUrunler.Columns[1].Width = 150;
                GridUrunler.Columns[2].Width = 475;
                GridUrunler.Columns[3].Width = 95;
                GridUrunler.Columns[4].Width = 150;
                GridUrunler.Columns[5].Width = 60;
                GridUrunler.Columns[7].Width = 50;
                GridUrunler.Columns[7].Width = 60;
                GridUrunler.Columns[17].Width = 75;
            }
            else // değilse boş
            {
                GridUrunler.DataSource = null;
            }
            islemler.GridDuzenle(GridUrunler);
        }

        private void bstandart1_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "jpeg files|*.png";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = FD.FileName;
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                //BackgroundImage = Image.FromFile(FD.FileName);
                f.resim = fileToOpen;
                tResim.Text = fileToOpen;
                //System.IO.File.Delete(@"C:\Sam.jpeg");
                //Image.FromFile(FD.FileName).Save(@"C:\Sam.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                f.butonid = Convert.ToInt32(lbutonid.Text);
                var guncellenecek = db.HızlıUrun.Find(Convert.ToInt32(lbutonid.Text));
                guncellenecek.Resim = fileToOpen;
                db.SaveChanges();
                f.butonid = Convert.ToInt32(lbutonid.Text);
                f.resimgetir2();
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


        private void bgeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
