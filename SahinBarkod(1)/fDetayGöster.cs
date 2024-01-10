using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fDetayGöster : Form
    {
        public fDetayGöster()
        {
            InitializeComponent();
        }
        public int İslemNo { get; set; }
        private void fDetayGöster_Load(object sender, EventArgs e)
        {
            lislemno.Text = "İşlem No : " + İslemNo.ToString();
            using (var db = new Barkod1Entities())
            {
                GridListe.DataSource = db.Satisid.Select(s => new { s.islemno, s.Urunad, s.Miktar, s.Satisfiyat, s.Toplam }).Where(x => x.islemno == İslemNo).ToList();
                islemler.GridDuzenle(GridListe);
            }
        }
    }
}
