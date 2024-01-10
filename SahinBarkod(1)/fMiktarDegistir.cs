using System;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fMiktarDegistir : Form
    {
        public fMiktarDegistir()
        {
            InitializeComponent();
        }
        internal string eskiMiktar = string.Empty;

        private void fMiktarDegistir_Load(object sender, EventArgs e)
        {
            tEskiMiktar.Text = eskiMiktar;
            tYeniMiktar.Focus();
        }

        private void btamam_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            if (tYeniMiktar.Text != string.Empty)
            {
                if (tYeniMiktar.Text != null)
                {
                    f.yenimiktar = Convert.ToDouble(tYeniMiktar.Text);
                }
            }
            else
            {
                f.yenimiktar = Convert.ToDouble(tEskiMiktar.Text);
            }
            this.Close();
        }

        private void bstandart1_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];

            f.yenimiktar = Convert.ToDouble(tEskiMiktar.Text);
            this.Close();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tYeniMiktar.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tYeniMiktar.Text += b.Text;
                }

            }
            else if (b.Text == "<")
            {
                if (tYeniMiktar.Text.Length > 0)
                {
                    tYeniMiktar.Text = tYeniMiktar.Text.Substring(0, tYeniMiktar.Text.Length - 1);
                }
            }
            else
            {
                tYeniMiktar.Text += b.Text;
            }
        }

        private void fMiktarDegistir_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Divide)
            //    SendKeys.Send("{ESC}");
        }

    }
}
