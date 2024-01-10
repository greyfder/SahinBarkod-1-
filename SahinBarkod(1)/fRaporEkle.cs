using System;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fRaporEkle : Form
    {
        public fRaporEkle()
        {
            InitializeComponent();
        }

        private void fRaporEkle_Load(object sender, EventArgs e)
        {

            reportViewer1.Dock = DockStyle.Fill;



            this.reportViewer1.RefreshReport();
        }
    }
}
