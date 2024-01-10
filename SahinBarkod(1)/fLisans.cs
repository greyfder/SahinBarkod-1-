using System;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fLisans : Form
    {
        public fLisans()
        {
            InitializeComponent();
        }

        private void bTamam_Click(object sender, EventArgs e)
        {
            if (tLisansno.Text != "")
            {
                Kontrol k = new Kontrol();
                k.Lisansla(tLisansno.Text);
            }
        }
    }
}
