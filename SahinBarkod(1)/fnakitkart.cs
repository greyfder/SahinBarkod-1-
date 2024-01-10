using System;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fnakitkart : Form
    {
        public fnakitkart()
        {
            InitializeComponent();
        }

        private void tNakit_KeyDown(object sender, KeyEventArgs e)
        {
            if (tNakit.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    hesapla();
                }
            }
        }
        private void hesapla()
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];// açık olan forma gitme
            double nakit = islemler.DoubleYap(tNakit.Text);
            double geneltoplam = islemler.DoubleYap(f.tGenelToplam.Text);
            double kart = geneltoplam - nakit;
            f.lNakit.Text = nakit.ToString("C2");
            f.lKart.Text = kart.ToString("C2");
            f.SatisYap("Kart-Nakit");
            this.Hide();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tNakit.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNakit.Text += b.Text;
                }

            }
            else if (b.Text == "<")
            {
                if (tNakit.Text.Length > 0)
                {
                    tNakit.Text = tNakit.Text.Substring(0, tNakit.Text.Length - 1);
                }
            }
            else
            {
                tNakit.Text += b.Text;
            }
        }

        private void fnakitkart_Load(object sender, EventArgs e)
        {

        }

        private void bEnter_Click(object sender, EventArgs e)
        {

            if (tNakit.Text != "")
            {
                hesapla();
            }
        }

        private void tNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08) // 08 klavyede silme tuşu
            {
                e.Handled = true; // TExtboxa sadece rakam girmemizi sağlıyor 
            }
        }
    }
}
