using System;
using System.Windows.Forms;

namespace Lisans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lic lic = new lic();
            label1.Text = lic.CpuNo() + "\n" + lic.CpuKarekterToplam().ToString(); //  işlemci no ve toplamı getirek dedik
            DateTime gelentarih = lic.TarihCoz("HJJDFG");
            var kontrolno = lic.EkrandaGoster();
            var getirsifre = lic.TarihSifrele(DateTime.Now);
            var getir0 = lic.yillar();
            var getir = lic.gunler();
            var getir2 = lic.aylar();
        }
    }
}
