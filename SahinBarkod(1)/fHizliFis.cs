using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    public partial class fHizliFis : Form
    {
        public fHizliFis()
        {
            InitializeComponent();
        }

        private void bGöster_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; // İşlem yaparken Fare nasıl görünecek 
            DateTime baslangic = DateTime.Parse(dtBaslangıc.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(dtBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1);// +1 ekliyoruz öyle algılıyor
            using (var db = new Barkod1Entities())
            {
                db.islemOzet.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).OrderByDescending(x => x.Tarih).Load();
                var islemozet = db.islemOzet.Local.ToBindingList();
                GridListe.DataSource = islemozet;
                GridListe.Columns[7].Visible = false;
                GridListe.Columns[6].Visible = false;
                GridListe.Columns[8].Visible = false;
                GridListe.Columns[9].Visible = false;
                Cursor.Current = Cursors.Default; // İşlem yaparken Fare nasıl görünecek 
            }
        }

        private void fHizliFis_Load(object sender, EventArgs e)
        {
            bGöster_Click(null, null);
        }

        private void GridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 6 || e.ColumnIndex == 7) // 2. 6. ve 7. sütünlarda 
            {
                if (e.Value is bool) // tabloda true false olanları evet hayır yazıcaz 
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Evet" : "Hayır";
                    e.FormattingApplied = true;

                }
            }
        }

        private void GridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                if (islemno != 0)
                {
                    fDetayGöster f = new fDetayGöster();
                    f.İslemNo = islemno;
                    f.ShowDialog();

                }
            }
        }

        private void tYazdır_Click(object sender, EventArgs e)
        {
            if (GridListe.Rows.Count > 0)
            {
                int islemno = Convert.ToInt32(GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
                DateTime? dt = Convert.ToDateTime(GridListe.CurrentRow.Cells["Tarih"].Value.ToString());
                if (islemno != 0)
                {
                    Yazdir yazdir = new Yazdir(islemno,dt);
                    yazdir.YazdirmayaBasla();

                }
                this.Close();
            }
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.didi = Convert.ToDouble(GridListe.CurrentRow.Cells["İslemNo"].Value);
            f.duzenle(f.didi);
            this.Close();

        }

        private void bCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
