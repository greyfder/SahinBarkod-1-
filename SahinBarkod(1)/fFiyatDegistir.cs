using System;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fFiyatDegistir : Form
    {
        public fFiyatDegistir()
        {
            InitializeComponent();
        }
        internal string eskifiyat = string.Empty;


        private void fFiyatDegistir_Load(object sender, EventArgs e)
        {
            tEskiFiyat.Text = eskifiyat;
            tYeniFiyat.Focus();
        }

        private void bstandart1_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            if (tYeniFiyat.Text != string.Empty)
            {
                if (tYeniFiyat.Text != null)
                {
                    f.yenifiyat = Convert.ToDouble(tYeniFiyat.Text);
                }
            }
            else
            {
                f.yenifiyat = Convert.ToDouble(tEskiFiyat.Text);
            }
            this.Close();
        }

        private void bstandart1_Click_1(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];

            f.yenifiyat = Convert.ToDouble(tEskiFiyat.Text);
            this.Close();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                int virgul = tYeniFiyat.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tYeniFiyat.Text += b.Text;
                }

            }
            else if (b.Text == "<")
            {
                if (tYeniFiyat.Text.Length > 0)
                {
                    tYeniFiyat.Text = tYeniFiyat.Text.Substring(0, tYeniFiyat.Text.Length - 1);
                }
            }
            else
            {
                tYeniFiyat.Text += b.Text;
            }
        }

    }
}
