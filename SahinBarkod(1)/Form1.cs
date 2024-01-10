using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using System.Threading;

namespace SahinBarkod_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tBarkod.GotFocus += tBarkod_GotFocus; // seçilince ne olacağını belirledik
            tBarkod.LostFocus += tBarkod_LostFocus;// seçilince ne olacağını belirledik
        }
        internal double yenifiyat = 0;
        internal double yenimiktar = 0;
        internal double didi = 0;
        internal string resim = "";
        internal int butonid = 0;
        public int digerbarkod = (int)1;
        internal string rehber = "";

        private void tBarkod_GotFocus(Object sender, EventArgs e)// seçilince ne olacağını belirledik
        {
            tBarkod.BackColor = SystemColors.Window;// seçilince ne olacağını belirledik
        }
        private void tBarkod_LostFocus(Object sender, EventArgs e)// seçilince ne olacağını belirledik
        {

            tBarkod.BackColor = SystemColors.ScrollBar;// seçilince ne olacağını belirledik
        }
        internal void HızlıUrunDoldur()
        {
            foreach (HızlıUrun hızlıUrun in this.db.HızlıUrun.ToList<HızlıUrun>())
            {
                if (((IEnumerable<Control>)this.Controls.Find("bh" + hızlıUrun.Id.ToString(), true)).FirstOrDefault<Control>() is Button button)
                {
                    double num = islemler.DoubleYap(hızlıUrun.Fiyat.ToString());
                    button.Font = new Font("Microsoft JhengHei UI", 0.2f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
                    button.ForeColor = SystemColors.WindowText;
                    Label label1 = new Label();
                    label1.BackColor = Color.Lavender;
                    label1.Location = new Point(3, 2);
                    label1.Font = new Font("Microsoft JhengHei UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
                    label1.AutoSize = true;
                    label1.Text = num.ToString("C2");
                    button.Controls.Add((Control)label1);
                    Label label2 = new Label();
                    label2.BackColor = Color.Lavender;
                    label2.Location = new Point(3, 87);
                    label2.Font = new Font("Microsoft JhengHei UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
                    label2.AutoSize = true;
                    label2.BorderStyle = BorderStyle.None;
                    label2.Text = hızlıUrun.UrunAd.ToString();
                    button.Controls.Add((Control)label2);
                    button.Text = hızlıUrun.UrunAd + "\n" + num.ToString("C2");
                }
            }
        }
        Barkod1Entities db = new Barkod1Entities();

        internal int Digerbarkod { get => digerbarkod; set => digerbarkod = value; }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void resimgetir2()
        {

            try
            {
                var resim1 = db.HızlıUrun.Where(x => x.Id == 1).Select(x => x.Resim).FirstOrDefault();
                if (resim1 != "-")
                {
                    var FD1 = new System.Windows.Forms.OpenFileDialog();
                    FD1.FileName = @"" + resim1.ToString() + "";
                    bh1.BackgroundImage = Image.FromFile(FD1.FileName);
                }
                else
                {
                    bh1.BackgroundImage = null;
                }
                var resim2 = db.HızlıUrun.Where(x => x.Id == 2).Select(x => x.Resim).FirstOrDefault();
                if (resim2 != "-")
                {
                    var FD2 = new System.Windows.Forms.OpenFileDialog();
                    FD2.FileName = @"" + resim2.ToString() + "";
                    bh2.BackgroundImage = Image.FromFile(FD2.FileName);
                }
                else
                {
                    bh2.BackgroundImage = null;
                }
                var resim3 = db.HızlıUrun.Where(x => x.Id == 3).Select(x => x.Resim).FirstOrDefault();
                if (resim3 != "-")
                {
                    var FD3 = new System.Windows.Forms.OpenFileDialog();
                    FD3.FileName = @"" + resim3.ToString() + "";
                    bh3.BackgroundImage = Image.FromFile(FD3.FileName);
                }
                else
                {
                    bh3.BackgroundImage = null;
                }
                var resim4 = db.HızlıUrun.Where(x => x.Id == 4).Select(x => x.Resim).FirstOrDefault();
                if (resim4 != "-")
                {
                    var FD4 = new System.Windows.Forms.OpenFileDialog();
                    FD4.FileName = @"" + resim4.ToString() + "";
                    bh4.BackgroundImage = Image.FromFile(FD4.FileName);
                }
                else
                {
                    bh4.BackgroundImage = null;
                }
                var resim5 = db.HızlıUrun.Where(x => x.Id == 5).Select(x => x.Resim).FirstOrDefault();
                if (resim5 != "-")
                {
                    var FD5 = new System.Windows.Forms.OpenFileDialog();
                    FD5.FileName = @"" + resim5.ToString() + "";
                    bh5.BackgroundImage = Image.FromFile(FD5.FileName);
                }
                else
                {
                    bh5.BackgroundImage = null;
                }
                var resim6 = db.HızlıUrun.Where(x => x.Id == 6).Select(x => x.Resim).FirstOrDefault();
                if (resim6 != "-")
                {
                    var FD6 = new System.Windows.Forms.OpenFileDialog();
                    FD6.FileName = @"" + resim6.ToString() + "";
                    bh6.BackgroundImage = Image.FromFile(FD6.FileName);
                }
                else
                {
                    bh6.BackgroundImage = null;
                }
                var resim7 = db.HızlıUrun.Where(x => x.Id == 7).Select(x => x.Resim).FirstOrDefault();
                if (resim7 != "-")
                {
                    var FD7 = new System.Windows.Forms.OpenFileDialog();
                    FD7.FileName = @"" + resim7.ToString() + "";
                    bh7.BackgroundImage = Image.FromFile(FD7.FileName);
                }
                else
                {
                    bh7.BackgroundImage = null;
                }
                var resim8 = db.HızlıUrun.Where(x => x.Id == 8).Select(x => x.Resim).FirstOrDefault();
                if (resim8 != "-")
                {
                    var FD8 = new System.Windows.Forms.OpenFileDialog();
                    FD8.FileName = @"" + resim8.ToString() + "";
                    bh8.BackgroundImage = Image.FromFile(FD8.FileName);

                }
                else
                {
                    bh8.BackgroundImage = null;
                }
                var resim9 = db.HızlıUrun.Where(x => x.Id == 9).Select(x => x.Resim).FirstOrDefault();
                if (resim9 != "-")
                {
                    var FD9 = new System.Windows.Forms.OpenFileDialog();
                    FD9.FileName = @"" + resim9.ToString() + "";
                    bh9.BackgroundImage = Image.FromFile(FD9.FileName);

                }
                else
                {
                    bh9.BackgroundImage = null;
                }
                var resim10 = db.HızlıUrun.Where(x => x.Id == 10).Select(x => x.Resim).FirstOrDefault();
                if ((resim10 != "-"))
                {
                    var FD10 = new System.Windows.Forms.OpenFileDialog();
                    FD10.FileName = @"" + resim10.ToString() + "";
                    bh10.BackgroundImage = Image.FromFile(FD10.FileName);

                }
                else
                {
                    bh10.BackgroundImage = null;
                }
                var resim11 = db.HızlıUrun.Where(x => x.Id == 11).Select(x => x.Resim).FirstOrDefault();
                if (resim11 != "-")
                {
                    var FD11 = new System.Windows.Forms.OpenFileDialog();
                    FD11.FileName = @"" + resim11.ToString() + "";
                    bh11.BackgroundImage = Image.FromFile(FD11.FileName);
                }
                else
                {
                    bh11.BackgroundImage = null;
                }
                var resim12 = db.HızlıUrun.Where(x => x.Id == 12).Select(x => x.Resim).FirstOrDefault();
                if (resim12 != "-")
                {
                    var FD12 = new System.Windows.Forms.OpenFileDialog();
                    FD12.FileName = @"" + resim12.ToString() + "";
                    bh12.BackgroundImage = Image.FromFile(FD12.FileName);

                }
                else
                {
                    bh12.BackgroundImage = null;
                }
                var resim13 = db.HızlıUrun.Where(x => x.Id == 13).Select(x => x.Resim).FirstOrDefault();
                if ((resim13 != "-"))
                {
                    var FD13 = new System.Windows.Forms.OpenFileDialog();
                    FD13.FileName = @"" + resim13.ToString() + "";
                    bh13.BackgroundImage = Image.FromFile(FD13.FileName);

                }
                else
                {
                    bh13.BackgroundImage = null;
                }
                var resim14 = db.HızlıUrun.Where(x => x.Id == 14).Select(x => x.Resim).FirstOrDefault();
                if (resim14 != "-")
                {
                    var FD14 = new System.Windows.Forms.OpenFileDialog();
                    FD14.FileName = @"" + resim14.ToString() + "";
                    bh14.BackgroundImage = Image.FromFile(FD14.FileName);

                }
                else
                {
                    bh14.BackgroundImage = null;
                }
                var resim15 = db.HızlıUrun.Where(x => x.Id == 15).Select(x => x.Resim).FirstOrDefault();
                if (resim15 != "-")
                {
                    var FD15 = new System.Windows.Forms.OpenFileDialog();
                    FD15.FileName = @"" + resim15.ToString() + "";
                    bh15.BackgroundImage = Image.FromFile(FD15.FileName);

                }
                else
                {
                    bh15.BackgroundImage = null;
                }
                var resim16 = db.HızlıUrun.Where(x => x.Id == 16).Select(x => x.Resim).FirstOrDefault();
                if (resim16 != "-")
                {
                    var FD16 = new System.Windows.Forms.OpenFileDialog();
                    FD16.FileName = @"" + resim16.ToString() + "";
                    bh16.BackgroundImage = Image.FromFile(FD16.FileName);
                }
                else
                {
                    bh16.BackgroundImage = null;
                }
                var resim17 = db.HızlıUrun.Where(x => x.Id == 17).Select(x => x.Resim).FirstOrDefault();
                if ((resim17 != "-"))
                {
                    var FD17 = new System.Windows.Forms.OpenFileDialog();
                    FD17.FileName = @"" + resim17.ToString() + "";
                    bh17.BackgroundImage = Image.FromFile(FD17.FileName);

                }
                else
                {
                    bh17.BackgroundImage = null;
                }
                var resim18 = db.HızlıUrun.Where(x => x.Id == 18).Select(x => x.Resim).FirstOrDefault();
                if (resim18 != "-")
                {
                    var FD18 = new System.Windows.Forms.OpenFileDialog();
                    FD18.FileName = @"" + resim18.ToString() + "";
                    bh18.BackgroundImage = Image.FromFile(FD18.FileName);

                }
                else
                {
                    bh18.BackgroundImage = null;
                }
                var resim19 = db.HızlıUrun.Where(x => x.Id == 19).Select(x => x.Resim).FirstOrDefault();
                if (resim19 != "-")
                {
                    var FD19 = new System.Windows.Forms.OpenFileDialog();
                    FD19.FileName = @"" + resim19.ToString() + "";
                    bh19.BackgroundImage = Image.FromFile(FD19.FileName);

                }
                else
                {
                    bh19.BackgroundImage = null;
                }
                var resim20 = db.HızlıUrun.Where(x => x.Id == 20).Select(x => x.Resim).FirstOrDefault();
                if ((resim20 != "-"))
                {
                    var FD20 = new System.Windows.Forms.OpenFileDialog();
                    FD20.FileName = @"" + resim20.ToString() + "";
                    bh20.BackgroundImage = Image.FromFile(FD20.FileName);
                }
                else
                {
                    bh20.BackgroundImage = null;
                }
                var resim21 = db.HızlıUrun.Where(x => x.Id == 21).Select(x => x.Resim).FirstOrDefault();
                if (resim21 != "-")
                {
                    var FD21 = new System.Windows.Forms.OpenFileDialog();
                    FD21.FileName = @"" + resim21.ToString() + "";
                    bh21.BackgroundImage = Image.FromFile(FD21.FileName);
                }
                else
                {
                    bh21.BackgroundImage = null;
                }
                var resim22 = db.HızlıUrun.Where(x => x.Id == 22).Select(x => x.Resim).FirstOrDefault();
                if (resim22 != "-")
                {
                    var FD22 = new System.Windows.Forms.OpenFileDialog();
                    FD22.FileName = @"" + resim22.ToString() + "";
                    bh22.BackgroundImage = Image.FromFile(FD22.FileName);
                }
                else
                {
                    bh22.BackgroundImage = null;
                }
                var resim23 = db.HızlıUrun.Where(x => x.Id == 23).Select(x => x.Resim).FirstOrDefault();
                if ((resim23 != "-"))
                {
                    var FD23 = new System.Windows.Forms.OpenFileDialog();
                    FD23.FileName = @"" + resim23.ToString() + "";
                    bh23.BackgroundImage = Image.FromFile(FD23.FileName);

                }
                else
                {
                    bh23.BackgroundImage = null;
                }
                var resim24 = db.HızlıUrun.Where(x => x.Id == 24).Select(x => x.Resim).FirstOrDefault();
                if (resim24 != "-")
                {
                    var FD24 = new System.Windows.Forms.OpenFileDialog();
                    FD24.FileName = @"" + resim24.ToString() + "";
                    bh24.BackgroundImage = Image.FromFile(FD24.FileName);

                }
                else
                {
                    bh24.BackgroundImage = null;
                }
                var resim25 = db.HızlıUrun.Where(x => x.Id == 25).Select(x => x.Resim).FirstOrDefault();
                if (resim25 != "-")
                {
                    var FD25 = new System.Windows.Forms.OpenFileDialog();
                    FD25.FileName = @"" + resim25.ToString() + "";
                    bhesap.BackgroundImage = Image.FromFile(FD25.FileName);

                }
                else
                {
                    bhesap.BackgroundImage = null;
                }
                //var loc =resim1.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HIZLI ÜRÜN RESİMLERİNDEN BİRİ KAYIP. \n YENİ BİR RESİM BELİRLEYİN\n" + ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            HızlıUrunDoldur();
            //b10.Text = 10.ToString("C2");
            //b20.Text = 20.ToString("C2");
            //b50.Text = 50.ToString("C2");


            using (var db = new Barkod1Entities())
            {
                var sabit = db.Sabit.FirstOrDefault();
                chYazdirma.Checked = Convert.ToBoolean(sabit.Yazici);
            }
            resimgetir2();


        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {

                int virgul = tNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNumarator.Text += b.Text;
                    tmiktar.Text += b.Text;
                }
                tBarkod.Focus();
            }
            else if (b.Text == "<")
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                    tmiktar.Text = tmiktar.Text.Substring(0, tmiktar.Text.Length - 1);
                }
                tBarkod.Focus();
            }
            else
            {
                tNumarator.Text += b.Text;
                tmiktar.Text += b.Text;
                tBarkod.Focus();
            }
        }
        private void tBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // enter tuşuna bastığımızda
            {
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                string barkod = tBarkod.Text.Trim();
                if (barkod.Length <= 1)
                {
                    //tmiktar.Text = barkod;
                    //tBarkod.Clear();
                    //tBarkod.Focus();
                }
                else
                {
                    if (db.CokluB.Any(a => a.Barkod == barkod))//any gelen bilgi data base mevcut mu diye kontrol ediyor varsa
                    {
                        int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                        var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();//onu  urune tanımla
                        UrunGetirListeye(urun, urunid, Convert.ToDouble(tmiktar.Text)); // void oluşturduk

                    }
                    else // Yoksa Terazi Tablosunda var mı diye kontrol et
                    {
                        try
                        {
                            int onek = Convert.ToInt16(barkod.Substring(0, 2));//substring ilk iki rakamını oku ve int olduğu için convert ettik

                            if (db.Terazi.Any(a => a.TeraziOnEk == onek))// terazide var mı diye kontrol et
                            {
                                string teraziurunno = barkod.Substring(2, 5);// barkodun ilk 2 rakamını alma
                                if (db.CokluB.Any(a => a.Barkod == teraziurunno))// ürün var ise
                                {
                                    int Urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == teraziurunno).Select(b => b.Urunid).FirstOrDefault());
                                    var urunterazi = db.Urun.Where(a => a.Urunid == Urunid).FirstOrDefault();
                                    double miktarkg = Convert.ToDouble(barkod.Substring(7, 5)) / 1000;// barkodun 7 rakamından başla bine böl kg i versin barkodta gr değeri veriyor
                                    UrunGetirListeye(urunterazi, Urunid, miktarkg);
                                }
                                else
                                {
                                    Console.Beep(900, 2000); // 27 ile başlarsa barkod kg ürünü kaydeymesini söyleyecek
                                    MessageBox.Show("Kg urun ekleme sayfası");
                                }
                            }
                            else
                            {
                                DialogResult onay = MessageBox.Show("Ürün Kayıtlı değil! \n Kaydetmek ister misiniz?", "Ürün Kaydetme İşlemi", MessageBoxButtons.YesNo);
                                if (onay == DialogResult.Yes)
                                {
                                    fUrunGiris f = new fUrunGiris();
                                    f.tbarkod.Text = barkod;
                                    f.ShowDialog();
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            DialogResult onay = MessageBox.Show("Ürün Kayıtlı değil! \n Kaydetmek ister misiniz?", "Ürün Kaydetme İşlemi", MessageBoxButtons.YesNo);
                            if (onay == DialogResult.Yes)
                            {
                                fUrunGiris f = new fUrunGiris();
                                f.tbarkod.Text = barkod;
                                f.ShowDialog();
                            }
                        }

                    }



                }
                GridSatis.ClearSelection(); // temizle
                GenelToplam(); // genel toplamı çağır
            }


        }
        public void UrunGetirListeye(Urun urun, int urunid, double miktar) //void oluşturduk
        {
            int satirsayisi = GridSatis.Rows.Count;
            //double miktar = Convert.ToDouble(tmiktar.Text);
            bool eklenmismi = false;
            if (tmiktar.Text == "")
                tmiktar.Text = "1";

            if (satirsayisi > 0)
            {
                for (int i = 0; i < satirsayisi; i++)// satır sayısı kadar kontrol et
                {
                    //if (GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "1111111111116" && GridSatis.Rows[i].Cells["Urunid"].Value.ToString() == urunid.ToString())
                    if (GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "1" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "2" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "3" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "4" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "5" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "6" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "7" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "8" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "9" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "10" && GridSatis.Rows[i].Cells["Barkod"].Value.ToString() != "11" && GridSatis.Rows[i].Cells["Urunid"].Value.ToString() == urunid.ToString())// seçili satırdaki barkod db ile aynı ise
                    {
                        //eğer bir değeri okutmuş isek yeni eklediğimiz kadar mevcut miktarın üstüne ekle aslanım dedik
                        GridSatis.Rows[i].Cells["Miktar"].Value = miktar + Convert.ToDouble(GridSatis.Rows[i].Cells["Miktar"].Value);
                        GridSatis.Rows[i].Cells["Toplam"].Value = Math.Round(Convert.ToDouble(GridSatis.Rows[i].Cells["Miktar"].Value) * Convert.ToDouble(GridSatis.Rows[i].Cells["Fiyat"].Value), 2);
                        //Math.Round 2. basamaktan sonra yuvarlaması gerektiğini söyler
                        eklenmismi = true;
                    }
                }
            }
            if (!eklenmismi && urun != null)
            {
                GridSatis.Rows.Add();
                //GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urunid;
                GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;

                if (rsatis1.Checked == true)
                {

                    double fiyat = Convert.ToDouble(urun.SatisFiyat);
                    if (fiyat > 0)
                    {
                        GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;
                        GridSatis.Rows[satirsayisi].Cells["Fiyat"].Value = fiyat;
                        GridSatis.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                        GridSatis.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * fiyat, 2);
                        GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urun.Barkod;
                        GridSatis.Rows[satirsayisi].Cells["Urunad"].Value = urun.UrunAd;
                        GridSatis.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                        GridSatis.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;

                        // mathround 2 basamaktan sonrasını yuvarla DB gelen bilgi double dedik
                        GridSatis.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        GridSatis.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat2"].Value = urun.SatisFiyat2;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat3"].Value = urun.SatisFiyat3;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat4"].Value = urun.SatisFiyat4;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat5"].Value = urun.SatisFiyat5;
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                    }
                    else
                    {
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                        MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TekSatırSil();
                    }
                }
                else if (rsatis2.Checked == true)
                {
                    double fiyat = Convert.ToDouble(urun.SatisFiyat2);
                    if (fiyat > 0)
                    {
                        GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;
                        GridSatis.Rows[satirsayisi].Cells["Fiyat"].Value = fiyat;
                        GridSatis.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                        GridSatis.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * fiyat, 2);
                        GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urun.Barkod;
                        GridSatis.Rows[satirsayisi].Cells["Urunad"].Value = urun.UrunAd;
                        GridSatis.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                        GridSatis.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;

                        // mathround 2 basamaktan sonrasını yuvarla DB gelen bilgi double dedik
                        GridSatis.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        GridSatis.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat2"].Value = urun.SatisFiyat2;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat3"].Value = urun.SatisFiyat3;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat4"].Value = urun.SatisFiyat4;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat5"].Value = urun.SatisFiyat5;
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                    }
                    else
                    {
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                        MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TekSatırSil();
                    }

                }
                else if (rsatis3.Checked == true)
                {

                    double fiyat = Convert.ToDouble(urun.SatisFiyat3);
                    if (fiyat > 0)
                    {
                        GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;
                        GridSatis.Rows[satirsayisi].Cells["Fiyat"].Value = fiyat;
                        GridSatis.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                        GridSatis.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * fiyat, 2);
                        GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urun.Barkod;
                        GridSatis.Rows[satirsayisi].Cells["Urunad"].Value = urun.UrunAd;
                        GridSatis.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                        GridSatis.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;

                        // mathround 2 basamaktan sonrasını yuvarla DB gelen bilgi double dedik
                        GridSatis.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        GridSatis.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat2"].Value = urun.SatisFiyat2;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat3"].Value = urun.SatisFiyat3;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat4"].Value = urun.SatisFiyat4;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat5"].Value = urun.SatisFiyat5;
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                    }
                    else
                    {
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                        MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TekSatırSil();
                    }

                }
                else if (rsatis4.Checked == true)
                {
                    double fiyat = Convert.ToDouble(urun.SatisFiyat4);
                    if (fiyat > 0)
                    {
                        GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;
                        GridSatis.Rows[satirsayisi].Cells["Fiyat"].Value = fiyat;
                        GridSatis.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                        GridSatis.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * fiyat, 2);
                        GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urun.Barkod;
                        GridSatis.Rows[satirsayisi].Cells["Urunad"].Value = urun.UrunAd;
                        GridSatis.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                        GridSatis.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;

                        // mathround 2 basamaktan sonrasını yuvarla DB gelen bilgi double dedik
                        GridSatis.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        GridSatis.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat2"].Value = urun.SatisFiyat2;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat3"].Value = urun.SatisFiyat3;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat4"].Value = urun.SatisFiyat4;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat5"].Value = urun.SatisFiyat5;
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                    }
                    else
                    {
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                        MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TekSatırSil();
                    }
                }
                else if (rsatis5.Checked == true)
                {
                    double fiyat = Convert.ToDouble(urun.SatisFiyat5);
                    if (fiyat > 0)
                    {
                        GridSatis.Rows[satirsayisi].Cells["Urunid"].Value = urunid;
                        GridSatis.Rows[satirsayisi].Cells["Fiyat"].Value = fiyat;
                        GridSatis.Rows[satirsayisi].Cells["Miktar"].Value = miktar;
                        GridSatis.Rows[satirsayisi].Cells["Toplam"].Value = Math.Round(miktar * fiyat, 2);
                        GridSatis.Rows[satirsayisi].Cells["Barkod"].Value = urun.Barkod;
                        GridSatis.Rows[satirsayisi].Cells["Urunad"].Value = urun.UrunAd;
                        GridSatis.Rows[satirsayisi].Cells["UrunGrup"].Value = urun.UrunGrup;
                        GridSatis.Rows[satirsayisi].Cells["Birim"].Value = urun.Birim;

                        // mathround 2 basamaktan sonrasını yuvarla DB gelen bilgi double dedik
                        GridSatis.Rows[satirsayisi].Cells["AlisFiyat"].Value = urun.AlisFiyat;
                        GridSatis.Rows[satirsayisi].Cells["KdvTutar"].Value = urun.KdvTutari;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat2"].Value = urun.SatisFiyat2;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat3"].Value = urun.SatisFiyat3;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat4"].Value = urun.SatisFiyat4;
                        //GridSatis.Rows[satirsayisi].Cells["Fiyat5"].Value = urun.SatisFiyat5;
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                    }
                    else
                    {
                        if (satirsayisi > 0)
                        {
                            this.GridSatis.Rows[satirsayisi].Selected = true;
                            this.GridSatis.Rows[satirsayisi].Cells[0].Selected = true;
                        }
                        MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TekSatırSil();
                    }

                }
            }
        }
        private void HızlıButonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (tmiktar.Text == "")
                tmiktar.Text = "1";
            int butonid = Convert.ToUInt16(b.Name.ToString().Substring(2, b.Name.Length - 2));

            if (b.Text.ToString().StartsWith("-")) // tire ile başlıyorsa ürün tanılı değilse ekleme sayfası yapacağız
            {
                fHızlıButonUrunEkle f = new fHızlıButonUrunEkle();
                f.lbutonid.Text = butonid.ToString(); // diğer forma buton numarısını gönderdik
                f.ShowDialog();
                tBarkod.Focus();
            }
            else
            {
                //butonlar bh1..25 olarak ayarlamışitık ilk iki harfi almadık substring ile 

                var barkodid = db.HızlıUrun.Where(a => a.Id == butonid).Select(a => a.Barkod).FirstOrDefault(); //sadece barkod seç
                var urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkodid).Select(a => a.Urunid).FirstOrDefault());
                var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                UrunGetirListeye(urun, urunid, Convert.ToDouble(tmiktar.Text));
                GenelToplam();
            }

        }
        internal void GenelToplam()
        {
            double toplam = 0;
            double miktar = 0;
            for (int i = 0; i < GridSatis.Rows.Count; i++) // hücresi mikatrı kadar toplam seç
            {
                toplam += Convert.ToDouble(GridSatis.Rows[i].Cells["Toplam"].Value); // += her döngüde toplam değerini artırmasını söyler
                miktar += Convert.ToDouble(GridSatis.Rows[i].Cells["Miktar"].Value);
            }

            tGenelToplam.Text = toplam.ToString("c2");
            //textBox1.Text = toplam.ToString("c2");// yazdır c2 tl değeri olarak yazdırır 


            textBox2.Text = miktar.ToString();
            tBarkod.Focus(); //barkod textboxısa fokuslan
            tBarkod.Clear();//temizle
            tmiktar.Text = "";
            tNumarator.Text = "";
        }

        private void GridSatis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 14) // eğer 9(gizli olanlar dahil) sutuna tıklarsa seçili satırı silmesi söylüyoruz
            {
                GridSatis.Rows.Remove(GridSatis.CurrentRow);
                GridSatis.ClearSelection();
                GenelToplam();
                tBarkod.Focus();
            }
            if (e.ColumnIndex == 7 | e.ColumnIndex == 8)
            {
                var barkod = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
                if (barkod.Length < 2) return;
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                fFiyatDegistir fr = new fFiyatDegistir();
                fr.eskifiyat = GridSatis.CurrentRow.Cells["Fiyat"].Value.ToString();
                fr.ShowDialog();
                var yf = yenifiyat.ToString("N2");


                if (barkod != "1111111111116")
                {
                    GridSatis.CurrentRow.Cells["Fiyat"].Value = yf;
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();
                    tBarkod.Focus();
                }
            }
            if (e.ColumnIndex == 6 | e.ColumnIndex == 2)
            {
                var barkod = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
                if (barkod.Length < 2) return;
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                fMiktarDegistir fr = new fMiktarDegistir();
                fr.eskiMiktar = GridSatis.CurrentRow.Cells["Miktar"].Value.ToString();
                fr.ShowDialog();
                var yf = yenimiktar.ToString();
                if (barkod != "1111111111116")
                {
                    GridSatis.CurrentRow.Cells["Miktar"].Value = yf;
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();
                    tBarkod.Focus();
                }
            }
        }
        private void bh_MouseDown(object sender, MouseEventArgs e) // saü tık özelleği ekle
        {
            if (e.Button == MouseButtons.Right) // sağ tuşa balsıldığında
            {
                Button b = (Button)sender; //secilen button
                if (!b.Text.StartsWith("-") || b.BackgroundImage != null) // eğer - den farklıysa
                {
                    int butonid = Convert.ToInt16(b.Name.ToString().Substring(2, b.Name.Length - 2)); //bg hariç. buton id si bul
                    ContextMenuStrip s = new ContextMenuStrip();// sağtık menusu
                    ToolStripMenuItem sil = new ToolStripMenuItem();// sil itemi ekle
                    sil.Text = "Temizle - Buton No:" + butonid.ToString();// bu yazsın üstünde
                    sil.Click += Sil_Click; // += yazınca oto yeni sil_click özeliği yazıyor altta dolduracaz
                    s.Items.Add(sil);// itemi ekledi

                    this.ContextMenuStrip = s;//sağtık tablosuna
                }
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int butonid = Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));// temizle-buton top 19 karakter onları sildirdik
            var guncelle = db.HızlıUrun.Find(butonid); // tabloda id ye göre bul
            guncelle.Barkod = "-"; // -yap
            guncelle.UrunAd = "-";// -yap
            guncelle.Fiyat = 0;//0 yap
            guncelle.Resim = "-";
            db.SaveChanges();// veri tabanı kaydet

            double fiyat = 0;// tl yazması için değişken kullanmak zorunda kaldık
            Button b = this.Controls.Find("bh" + butonid, true).FirstOrDefault() as Button;// bu da programı tekrar başlatmadan düzgün yazsın diye butonu seçer
            //b.BackgroundImage = null;
            b.Text = "-" + "\n" + fiyat.ToString("C2");// null değerlerini ayazdırırız  c2 tl yazması için 
            resimgetir2();
        }

        private void bAdet_Click(object sender, EventArgs e)
        {
            //if (tNumarator.Text != "")
            //{
            //    tmiktar.Text = tNumarator.Text;
            //    tNumarator.Clear();
            //    tBarkod.Clear();
            //}
            tNumarator.Clear();
            tBarkod.Clear();
            tmiktar.Clear();
            tBarkod.Focus();

        }

        private void bs10_Click(object sender, EventArgs e)
        {
            tmiktar.Text = "10";
            tBarkod.Focus();

        }

        private void bs5_Click(object sender, EventArgs e)
        {
            tmiktar.Text = "5";
            tBarkod.Focus();

        }

        private void bs4_Click(object sender, EventArgs e)
        {
            tmiktar.Text = "4";
            tBarkod.Focus();
        }

        private void bs3_Click(object sender, EventArgs e)
        {
            tmiktar.Text = "3";
            tBarkod.Focus();
        }

        private void bs2_Click(object sender, EventArgs e)
        {


            tmiktar.Text = "2";
            tBarkod.Focus();


        }

        private void bsaz_Click(object sender, EventArgs e)
        {
            if (tmiktar.Text == "")
                tmiktar.Text = "1";
            double sayi = 0;
            sayi = Convert.ToDouble(tmiktar.Text) - 1;
            if (sayi > 0)
            {
                tmiktar.Text = sayi.ToString();
            }
            tBarkod.Focus();
        }

        private void bsar_Click(object sender, EventArgs e)
        {
            if (tmiktar.Text == "")
                tmiktar.Text = "1";
            double sayi = 0;
            sayi = Convert.ToDouble(tmiktar.Text) + 1;
            if (sayi > 0)
            {
                tmiktar.Text = sayi.ToString();
            }
            tBarkod.Focus();
        }

        private void bOdenen_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                double sonuc = islemler.DoubleYap(tGenelToplam.Text) - islemler.DoubleYap(tNumarator.Text);
                tOdenen.Text = tNumarator.Text.ToString();
                tParaustu.Text = sonuc.ToString();
                tNumarator.Clear();
                tBarkod.Focus();
            }
        }

        private void bBarkod_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != null)
            {
                if (db.Urun.Any(a => a.Barkod == tNumarator.Text))
                {
                    var urun = db.Urun.Where(a => a.Barkod == tNumarator.Text).FirstOrDefault();
                    UrunGetirListeye(urun, Convert.ToInt32(tNumarator.Text), Convert.ToDouble(tmiktar.Text));
                    tNumarator.Text = "";
                    tBarkod.Focus();
                }
                else
                {
                    MessageBox.Show("Ürün ekleme sayfası aç");
                }
            }
        }

        private void bDigerUrun_Click(object sender, EventArgs e)
        {
            if (tNumarator.Text != "")
            {
                int satırsayısı = GridSatis.Rows.Count;

                for (int i = 0; i < satırsayısı; i++)
                {
                    if (GridSatis.Rows[i].Cells["Barkod"].Value.ToString() == digerbarkod.ToString())
                        digerbarkod++;
                }


                GridSatis.Rows.Add();
                //GridSatis.Rows[satırsayısı].Cells["Barkod"].Value = "1111111111116";
                GridSatis.Rows[satırsayısı].Cells["Barkod"].Value = digerbarkod.ToString();
                GridSatis.Rows[satırsayısı].Cells["UrunAd"].Value = "Birinci  Fiş";
                GridSatis.Rows[satırsayısı].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                GridSatis.Rows[satırsayısı].Cells["Birim"].Value = "Adet";
                GridSatis.Rows[satırsayısı].Cells["Miktar"].Value = 1;
                GridSatis.Rows[satırsayısı].Cells["AlisFiyat"].Value = 0;
                GridSatis.Rows[satırsayısı].Cells["Fiyat"].Value = Convert.ToDouble(tNumarator.Text);
                GridSatis.Rows[satırsayısı].Cells["KdvTutar"].Value = 0;
                GridSatis.Rows[satırsayısı].Cells["Toplam"].Value = Convert.ToDouble(tNumarator.Text);
                tNumarator.Text = "";
                GenelToplam();
                if (satırsayısı > 0)
                {
                    this.GridSatis.Rows[satırsayısı].Selected = true;
                    this.GridSatis.Rows[satırsayısı].Cells[0].Selected = true;
                }
                tBarkod.Focus();
            }
            else
            {
                //tNumarator.Text = "0";
                tBarkod.Focus();
            }
        }

        private void biade_Click(object sender, EventArgs e)
        {
            if (chsatisiadeislemi.Checked)
            {
                chsatisiadeislemi.Checked = false;
                chsatisiadeislemi.Text = "Satış Yapılıyor.";
            }
            else
            {
                chsatisiadeislemi.Checked = true;
                chsatisiadeislemi.Text = "İade İşlemi.";
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            this.tmiktar.Text = "";
            this.tBarkod.Clear();
            this.tOdenen.Text = "";
            this.tParaustu.Text = "";
            this.tGenelToplam.Text = 0.ToString("C2");
            this.chsatisiadeislemi.Checked = false;
            this.tNumarator.Text = "";
            this.GridSatis.Rows.Clear();
            this.textBox2.Text = "";
            this.tBarkod.Focus();
        }
        public void SatisYap(string odemesekli)
        {
            int satirsayisi = GridSatis.Rows.Count;
            bool satisiade = chsatisiadeislemi.Checked;
            double alisfiyattoplam = 0;
            if (satirsayisi > 0)
            {
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                int? islemno = db.islem.First().islemno;
                DateTime? date = DateTime.Now;
                Satisid satis = new Satisid();
                for (int i = 0; i < satirsayisi; i++)
                {
                    satis.islemno = islemno;
                    satis.Urunad = GridSatis.Rows[i].Cells["UrunAd"].Value.ToString();
                    satis.Urungrup = GridSatis.Rows[i].Cells["UrunGrup"].Value.ToString();
                    satis.Barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    satis.Birim = GridSatis.Rows[i].Cells["Birim"].Value.ToString();
                    satis.Alisfiyat = islemler.DoubleYap(GridSatis.Rows[i].Cells["AlisFiyat"].Value.ToString());
                    satis.Satisfiyat = islemler.DoubleYap(GridSatis.Rows[i].Cells["Fiyat"].Value.ToString());
                    satis.Miktar = islemler.DoubleYap(GridSatis.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Toplam = islemler.DoubleYap(GridSatis.Rows[i].Cells["Toplam"].Value.ToString());
                    //satis.Satisfiyat2 = islemler.DoubleYap(GridSatis.Rows[i].Cells["Fiyat2"].Value.ToString());
                    //satis.Satisfiyat3 = islemler.DoubleYap(GridSatis.Rows[i].Cells["Fiyat3"].Value.ToString());
                    //satis.Satisfiyat4 = islemler.DoubleYap(GridSatis.Rows[i].Cells["Fiyat4"].Value.ToString());
                    //satis.Satisfiyat5 = islemler.DoubleYap(GridSatis.Rows[i].Cells["Fiyat5"].Value.ToString());
                    satis.Kdvtutari = islemler.DoubleYap(GridSatis.Rows[i].Cells["KdvTutar"].Value.ToString()) * islemler.DoubleYap(GridSatis.Rows[i].Cells["Miktar"].Value.ToString());
                    satis.Odemesekli = odemesekli;
                    satis.İade = satisiade;
                    satis.Tarih = DateTime.Now;
                    satis.Kullanici = lKullanici.Text;
                    db.Satisid.Add(satis); // veri tabanına ekle
                    db.SaveChanges();
                    if (!satisiade)
                    {
                        islemler.StokAzalt(GridSatis.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(GridSatis.Rows[i].Cells["Miktar"].Value.ToString()));
                    }
                    else
                    {
                        islemler.StokArttır(GridSatis.Rows[i].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(GridSatis.Rows[i].Cells["Miktar"].Value.ToString()));

                    }
                    alisfiyattoplam += islemler.DoubleYap(GridSatis.Rows[i].Cells["AlisFiyat"].Value.ToString()) * islemler.DoubleYap(GridSatis.Rows[i].Cells["Miktar"].Value.ToString());
                }
                islemOzet io = new islemOzet();
                io.İslemNo = islemno;
                io.İade = satisiade;
                io.AlısFiyatToplam = alisfiyattoplam;
                io.Gelir = false;
                io.Gider = false;
                if (!satisiade)
                {
                    io.Acıklama = odemesekli + "Satış";
                }
                else
                {
                    io.Acıklama = "İade işlemi (" + odemesekli + ")";
                }
                io.OdemeSekli = odemesekli;
                io.Kullanici = lKullanici.Text;
                io.Tarih = DateTime.Now;
                switch (odemesekli)
                {

                    case "Nakit":
                        io.Nakit = islemler.DoubleYap(tGenelToplam.Text);
                        io.Kart = 0; break;
                    case "Kart":
                        io.Nakit = 0;
                        io.Kart = islemler.DoubleYap(tGenelToplam.Text); break;
                    case "Kart-Nakit":
                        io.Nakit = islemler.DoubleYap(lNakit.Text);
                        io.Kart = islemler.DoubleYap(lKart.Text); break;
                }
                db.islemOzet.Add(io);
                db.SaveChanges();
                var islemnoartir = db.islem.First();
                islemnoartir.islemno += 1;
                db.SaveChanges();
                if (chYazdirma.Checked)
                {
                    //Yazdır...
                    Yazdir yazdir = new Yazdir(islemno, date);
                    yazdir.YazdirmayaBasla();
                }
                temizle();
                digerbarkod = 1;
                ikinciislem();
            }

        }
        private void labelYap()
        {

            var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
            var num = db.Satisid.Where(x => x.islemno == did).Sum(x => x.Miktar);
            Label label1 = new Label();
            label1.BackColor = Color.DarkOliveGreen;
            label1.Location = new Point(1, 1);
            label1.Font = new Font("Microsoft JhengHei UI", 16.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            label1.AutoSize = true;
            label1.Text = num.ToString();
            textBox3.Controls.Add((Control)label1);
        }
        private void ikinciislem()
        {

            var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
            var did2 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Nakit).FirstOrDefault();
            var did3 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Kart).FirstOrDefault();
            var did4 = did2 + did3;
            if (did3 == 0)
            {
                bDuzelt.Text = did2.ToString();
                textBox3.Controls.Clear();
                labelYap();
            }
            else if (did2 == 0)
            {
                bDuzelt.Text = did3.ToString();
                textBox3.Controls.Clear();
                labelYap();
            }
            else
            {
                bDuzelt.Text = did4.ToString();
                textBox3.Controls.Clear();
                labelYap();
            }
        }
        private void bNakit_Click(object sender, EventArgs e)
        {
            SatisYap("Nakit");
            //if (db.islemOzet.Any())
            //{
            //    var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
            //    var did2 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Nakit).FirstOrDefault();
            //    bDuzelt.Text = did2.ToString();
            //    textBox3.Controls.Clear();
            //    labelYap();

            //}

        }

        private void bKart_Click(object sender, EventArgs e)
        {
            SatisYap("Kart");
            //if (db.islemOzet.Any())
            //{
            //    var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
            //    var did2 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Kart).FirstOrDefault();
            //    bDuzelt.Text = did2.ToString();
            //    textBox3.Controls.Clear();
            //    labelYap();
            //}
        }

        private void bKartnakit_Click(object sender, EventArgs e)
        {
            fnakitkart f = new fnakitkart();
            f.ShowDialog();
        }

        private void tmiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44) // 08 klavyede silme tuşu 44 virgül
            {
                e.Handled = true; // TExtboxa sadece rakam girmemizi sağlıyor 
            }
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tNumarator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44) // 08 klavyede silme tuşu 44 virgül
            {
                e.Handled = true; // TExtboxa sadece rakam girmemizi sağlıyor 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                SatisYap("Nakit");
                //if (db.islemOzet.Any())
                //{
                //    var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
                //    var did2 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Nakit).FirstOrDefault();
                //    bDuzelt.Text = did2.ToString();
                //    textBox3.Controls.Clear();
                //    labelYap();
                //}
            }

            if (e.KeyCode == Keys.F2)
            {
                SatisYap("Kart");
                //if (db.islemOzet.Any())
                //{
                //    var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
                //    var did2 = db.islemOzet.Where(x => x.İslemNo == did).Select(x => x.Kart).FirstOrDefault();
                //    bDuzelt.Text = did2.ToString();
                //    textBox3.Controls.Clear();
                //    labelYap();
                //}
            }
            if (e.KeyCode == Keys.F3)
            {
                fnakitkart f = new fnakitkart();
                f.ShowDialog();
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (GridSatis.RowCount == 0) return;
                var barkod = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
                if (barkod.Length < 2) return;
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                fMiktarDegistir fr = new fMiktarDegistir();

                fr.eskiMiktar = GridSatis.CurrentRow.Cells["Miktar"].Value.ToString();
                fr.ShowDialog();
                var yf = yenimiktar.ToString();


                GridSatis.CurrentRow.Cells["Miktar"].Value = yf;
                int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();

                UrunGetirListeye(urun, urunid, 0);
                GenelToplam();

                tBarkod.Focus();

            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (GridSatis.RowCount == 0) return;
                var barkod = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
                if (barkod.Length < 2) return;
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                fFiyatDegistir fr = new fFiyatDegistir();
                fr.eskifiyat = GridSatis.CurrentRow.Cells["Fiyat"].Value.ToString();
                fr.ShowDialog();
                var yf = yenifiyat.ToString("N2");

                //if (barkod != "1111111111116")
                //{
                GridSatis.CurrentRow.Cells["Fiyat"].Value = yf;

                int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                UrunGetirListeye(urun, urunid, 0);
                GenelToplam();
                tBarkod.Focus();
                //}
            }
            if (e.KeyCode == Keys.Right)
            {
                tNumarator.Clear();
                tBarkod.Clear();
                tmiktar.Clear();
                tBarkod.Focus();

            }
            if (e.KeyCode == Keys.Left)
            {
                bDigerUrun.PerformClick();

            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.F6)
            {
                temizle();
            }
            if (e.KeyCode == Keys.Insert)
            {
                donusum1();
            }
            if (e.KeyCode == Keys.Home)
            {
                rsatis1.PerformClick();
            }
            if (e.KeyCode == Keys.PageUp)
            {
                rsatis2.PerformClick();
            }
            if (e.KeyCode == Keys.PageDown)
            {
                rsatis5.PerformClick();
            }
            if (e.KeyCode == Keys.End)
            {
                rsatis4.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                rsatis3.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                tmiktar.Text += "0";
                tNumarator.Text += "0";
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                tmiktar.Text += "1";
                tNumarator.Text += "1";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                tmiktar.Text += "2";
                tNumarator.Text += "2";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                tmiktar.Text += "3";
                tNumarator.Text += "3";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                tmiktar.Text += "4";
                tNumarator.Text += "4";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                tmiktar.Text += "5";
                tNumarator.Text += "5";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                tmiktar.Text += "6";
                tNumarator.Text += "6";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                tmiktar.Text += "7";
                tNumarator.Text += "7";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                tmiktar.Text += "8";
                tNumarator.Text += "8";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                tmiktar.Text += "9";
                tNumarator.Text += "9";
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D1)
            {
                tBarkod.Text += "1";
                tBarkod.Focus();
                tBarkod.Select(tBarkod.Text.Length, 0);
            }
            if (e.KeyCode == Keys.D2)
            {
                tBarkod.Text += "2";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();

            }
            if (e.KeyCode == Keys.D3)
            {
                tBarkod.Text += "3";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D4)
            {
                tBarkod.Text += "4";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D5)
            {
                tBarkod.Text += "5";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D6)
            {
                tBarkod.Text += "6";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D7)
            {
                tBarkod.Text += "7";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D8)
            {
                tBarkod.Text += "8";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D9)
            {
                tBarkod.Text += "9";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.D0)
            {
                tBarkod.Text += "0";
                tBarkod.Select(tBarkod.Text.Length, 0);
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.Add)
            {
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                var f = Convert.ToDouble(tmiktar.Text);
                f++;
                tmiktar.Text = f.ToString();
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (tmiktar.Text == "")
                    tmiktar.Text = "1";
                var f = Convert.ToDouble(tmiktar.Text);
                f--;
                tmiktar.Text = f.ToString();
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                int virgul = tNumarator.Text.Count(x => x == ',');
                if (virgul < 1)
                {
                    tNumarator.Text += ",";
                    tmiktar.Text += ",";
                }
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.Back)
            {
                if (tNumarator.Text.Length > 0)
                {
                    tNumarator.Text = tNumarator.Text.Substring(0, tNumarator.Text.Length - 1);
                    tmiktar.Text = tmiktar.Text.Substring(0, tmiktar.Text.Length - 1);
                }
                tBarkod.Focus();
            }
            if (e.KeyCode == Keys.Pause)
            {
                if (tmiktar.Text == "")
                {
                    tmiktar.Text = "10";
                }
                else
                {

                    var f = Convert.ToDouble(tmiktar.Text);
                    f = f + 10;
                    tmiktar.Text = f.ToString();
                    tNumarator.Text = f.ToString();
                    tBarkod.Focus();
                }
            }


        }
        private void donusum1()
        {
            if (GridSatis.RowCount == 0) return;

            var rowsayisi = GridSatis.RowCount;
            if (rsatis5.Checked)
            {
                for (int i = 0; i < rowsayisi; i++)
                {

                    if (tmiktar.Text == "")
                        tmiktar.Text = "1";
                    var barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    if (barkod.Length < 2) continue;
                    var eskifiyat = GridSatis.Rows[i].Cells["Fiyat"].Value.ToString();
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    var yf1 = urun.SatisFiyat5;
                    GridSatis.Rows[i].Cells["Fiyat"].Value = yf1;
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();

                }
            }
            else if (rsatis4.Checked)
            {
                for (int i = 0; i < rowsayisi; i++)
                {

                    if (tmiktar.Text == "")
                        tmiktar.Text = "1";
                    var barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    if (barkod.Length < 2) continue;
                    var eskifiyat = GridSatis.Rows[i].Cells["Fiyat"].Value.ToString();
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    var yf1 = urun.SatisFiyat4;
                    GridSatis.Rows[i].Cells["Fiyat"].Value = yf1;
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();

                }
            }
            else if (rsatis3.Checked)
            {
                for (int i = 0; i < rowsayisi; i++)
                {

                    if (tmiktar.Text == "")
                        tmiktar.Text = "1";
                    var barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    if (barkod.Length < 2) continue;
                    var eskifiyat = GridSatis.Rows[i].Cells["Fiyat"].Value.ToString();
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    var yf1 = urun.SatisFiyat3;
                    GridSatis.Rows[i].Cells["Fiyat"].Value = yf1;
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();

                }
            }
            else if (rsatis2.Checked)
            {
                for (int i = 0; i < rowsayisi; i++)
                {

                    if (tmiktar.Text == "")
                        tmiktar.Text = "1";
                    var barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    if (barkod.Length < 2) continue;
                    var eskifiyat = GridSatis.Rows[i].Cells["Fiyat"].Value.ToString();
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    var yf1 = urun.SatisFiyat2;
                    GridSatis.Rows[i].Cells["Fiyat"].Value = yf1;
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();

                }
            }
            else if (rsatis1.Checked)
            {
                for (int i = 0; i < rowsayisi; i++)
                {

                    if (tmiktar.Text == "")
                        tmiktar.Text = "1";
                    var barkod = GridSatis.Rows[i].Cells["Barkod"].Value.ToString();
                    if (barkod.Length < 2) continue;
                    var eskifiyat = GridSatis.Rows[i].Cells["Fiyat"].Value.ToString();
                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == barkod).Select(b => b.Urunid).FirstOrDefault());
                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();
                    var yf1 = urun.SatisFiyat;
                    GridSatis.Rows[i].Cells["Fiyat"].Value = yf1;
                    UrunGetirListeye(urun, urunid, 0);
                    GenelToplam();

                }
            }

            tBarkod.Focus();
        }
        private void bİslemBeklet_Click(object sender, EventArgs e)
        {
            if (bİslemBeklet.Text == "İşlem Beklet") // ismi aynıysa işleme başla
            {
                Bekle();
                bİslemBeklet.BackColor = System.Drawing.Color.OrangeRed; // buton rengi değiştir
                bİslemBeklet.Text = "Bekleyen İşlem 1"; // buton adı değiştir
                GridSatis.Rows.Clear(); // açık olan listeyi temizle
            }
            else if (GridSatis.Rows.Count == 0)
            {
                BeklemedenCık();
                bİslemBeklet.BackColor = System.Drawing.Color.DimGray; // eskiye dön
                bİslemBeklet.Text = "İşlem Beklet"; // eskiye dön
                GridBekle.Rows.Clear(); // gizli olanı sıfırla
            }
        }
        private void Bekle()
        {
            tGenelToplam.Text = "0";

            int satir = GridSatis.Rows.Count; // say
            int sutun = GridSatis.Columns.Count; // say
            if (satir > 0) //satır varsa
            {
                for (int i = 0; i < satir; i++)// her satır için
                {
                    GridBekle.Rows.Add();// yeni gride satır ekle
                    for (int j = 0; j < sutun - 1; j++) //her sütün için
                    {
                        GridBekle.Rows[i].Cells[j].Value = GridSatis.Rows[i].Cells[j].Value; // grid satıştaki verileri oraya taşı
                    }
                }
            }
            tBarkod.Focus();
        }
        private void BeklemedenCık() // yerlerni değiştir
        {
            tGenelToplam.Text = "0";
            int satir = GridBekle.Rows.Count;
            int sutun = GridBekle.Columns.Count;
            if (satir > 0)
            {
                for (int i = 0; i < satir; i++)
                {
                    GridSatis.Rows.Add();
                    for (int j = 0; j < sutun - 1; j++)
                    {
                        GridSatis.Rows[i].Cells[j].Value = GridBekle.Rows[i].Cells[j].Value;
                        GenelToplam();
                    }
                }
            }
            tBarkod.Focus();
        }

        private void chAzart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chsatisiadeislemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chsatisiadeislemi.Checked)
            {
                chsatisiadeislemi.Text = "İade Yapılıyor...";
            }
            else
            {
                chsatisiadeislemi.Text = "Satış İşlemi Yapılıyor.";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tmiktar.Text == "")
                tmiktar.Text = "1";
            double sayi = 0;
            sayi = -Convert.ToDouble(tmiktar.Text);


            tmiktar.Text = sayi.ToString();
            tBarkod.Focus();

        }

        private void rsatis1_CheckedChanged(object sender, EventArgs e)
        {
            if (rsatis1.Checked == true)
            {
                tBarkod.Focus();
                rsatis1.BackColor = SystemColors.Highlight;
                rsatis2.BackColor = SystemColors.Control;
                rsatis3.BackColor = SystemColors.Control;
                rsatis4.BackColor = SystemColors.Control;
                rsatis5.BackColor = SystemColors.Control;
            }

        }

        private void rsatis2_CheckedChanged(object sender, EventArgs e)
        {
            if (rsatis2.Checked == true)
            {
                tBarkod.Focus();
                rsatis1.BackColor = SystemColors.Control;
                rsatis2.BackColor = SystemColors.Highlight;
                rsatis3.BackColor = SystemColors.Control;
                rsatis4.BackColor = SystemColors.Control;
                rsatis5.BackColor = SystemColors.Control;
            }

        }

        private void rsatis3_CheckedChanged(object sender, EventArgs e)
        {
            if (rsatis3.Checked == true)
            {
                tBarkod.Focus();
                rsatis1.BackColor = SystemColors.Control;
                rsatis2.BackColor = SystemColors.Control;
                rsatis3.BackColor = SystemColors.Highlight;
                rsatis4.BackColor = SystemColors.Control;
                rsatis5.BackColor = SystemColors.Control;
            }
        }

        private void rsatis4_CheckedChanged(object sender, EventArgs e)
        {
            if (rsatis4.Checked == true)
            {
                tBarkod.Focus();
                rsatis1.BackColor = SystemColors.Control;
                rsatis2.BackColor = SystemColors.Control;
                rsatis3.BackColor = SystemColors.Control;
                rsatis4.BackColor = SystemColors.Highlight;
                rsatis5.BackColor = SystemColors.Control;
            }
        }

        private void rsatis5_CheckedChanged(object sender, EventArgs e)
        {
            if (rsatis5.Checked == true)
            {
                tBarkod.Focus();
                rsatis1.BackColor = SystemColors.Control;
                rsatis2.BackColor = SystemColors.Control;
                rsatis3.BackColor = SystemColors.Control;
                rsatis4.BackColor = SystemColors.Control;
                rsatis5.BackColor = SystemColors.Highlight;
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            fHizliFis f = new fHizliFis();
            f.ShowDialog();
            tBarkod.Focus();
        }

        private void tmiktar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tmiktar_Click(object sender, EventArgs e)
        {
            tmiktar.Focus(); // beraber kullanınca çalışıyor
            tmiktar.SelectAll();
        }

        private void tNumarator_Click(object sender, EventArgs e)
        {

        }

        private void bGiris_Click(object sender, EventArgs e)
        {
            int satir = GridSatis.RowCount;
            fUrunGiris f = new fUrunGiris();
            if (satir > 0)
            {
                f.tbarkod.Text = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
                f.tbarkodGetir(f.tbarkod.Text);
            }
            tBarkod.Focus();
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bDuzelt_Click(object sender, EventArgs e)
        {
            var did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
            duzenle(did);
            //var sayi = db.Satisid.Where(x => x.islemno == did).Count();
            //var barkod = db.Satisid.Where(x => x.islemno == did).Select(x => x.Barkod).ToList();


            //using (var db1 = new Barkod1Entities())
            //{

            //    foreach (var bark in barkod)
            //    {
            //        var miktar = db.Satisid.Where(x => x.Barkod == bark && x.islemno == did).Select(x => x.Miktar).ToList();
            //        var fiyat = db.Satisid.Where(x => x.Barkod == bark && x.islemno == did).Select(x => x.Satisfiyat).ToList();
            //        foreach (var mik in miktar)
            //        {
            //            foreach (var fiy in fiyat)
            //            {
            //                if (db.CokluB.Any(a => a.Barkod == bark))//any gelen bilgi data base mevcut mu diye kontrol ediyor varsa
            //                {
            //                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == bark).Select(b => b.Urunid).FirstOrDefault());
            //                    String urunid2 = urunid.ToString();
            //                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();//onu  urune tanımla
            //                    var mik2 = Convert.ToDouble(mik);
            //                    string mik22 = mik2.ToString();
            //                    var mik3 = Convert.ToDouble(fiy);
            //                    UrunGetirListeye(urun, urunid, mik2); // void oluşturduk

            //                    int satirsayisi = GridSatis.Rows.Count;
            //                    if (satirsayisi > 0)
            //                    {
            //                        for (int i = 0; i < satirsayisi; i++)// satır sayısı kadar kontrol et
            //                        {
            //                            if (urunid2 ==GridSatis.Rows[i].Cells["Urunid"].Value.ToString())// seçili satırdaki barkod db ile aynı ise
            //                            {
            //                                if(mik22 == GridSatis.Rows[i].Cells["Miktar"].Value.ToString())
            //                                {
            //                                    GridSatis.Rows[i].Cells["Fiyat"].Value = mik3;
            //                                    GridSatis.Rows[i].Cells["Toplam"].Value = mik3 * mik2;
            //                                    GridSatis.ClearSelection();
            //                                    GenelToplam();
            //                                }


            //                            }

            //                        }
            //                    }

            //                }

            //                GenelToplam();

            //            }
            //        }
            //    }

            //}
        }

        public void duzenle(double did)
        {
            {
                GridSatis.Rows.Clear();
#pragma warning disable CS0219 // 'diger' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
                var diger = "1111111111116";
#pragma warning restore CS0219 // 'diger' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
                //did = Convert.ToDouble(db.islemOzet.Max(x => x.İslemNo).Value.ToString());
                var sayi = db.Satisid.Where(x => x.islemno == did).Count();
                var barkod = db.Satisid.Where(x => x.islemno == did).Select(x => x.Barkod).ToList();
                //var fiy1 = db.Satisid.Where(x => x.Barkod.Equals(diger) && x.islemno == did).Select(x => x.Satisid1).ToList();


                using (var db1 = new Barkod1Entities())
                {

                    foreach (var bark in barkod)
                    {
                        var barksle = Convert.ToDouble(bark.Length);
                        if (barksle == 1)
                        {

                            var fiy = db.Satisid.Where(x => x.Barkod == bark && x.islemno == did).Select(x => x.Satisfiyat).FirstOrDefault();


                            var satırsayısı = GridSatis.Rows.Count;
                            GridSatis.Rows.Add();
                            GridSatis.Rows[satırsayısı].Cells["Barkod"].Value = bark;
                            GridSatis.Rows[satırsayısı].Cells["UrunAd"].Value = "Birinci Fiş";
                            GridSatis.Rows[satırsayısı].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                            GridSatis.Rows[satırsayısı].Cells["Birim"].Value = "Adet";
                            GridSatis.Rows[satırsayısı].Cells["Miktar"].Value = 1;
                            GridSatis.Rows[satırsayısı].Cells["AlisFiyat"].Value = 0;
                            GridSatis.Rows[satırsayısı].Cells["Fiyat"].Value = Convert.ToDouble(fiy);
                            GridSatis.Rows[satırsayısı].Cells["KdvTutar"].Value = 0;
                            GridSatis.Rows[satırsayısı].Cells["Toplam"].Value = Convert.ToDouble(fiy);
                            GridSatis.Rows[satırsayısı].Cells["Urunid"].Value = "0";
                            tNumarator.Text = "";

                            GenelToplam();

                        }

                        var miktar = db.Satisid.Where(x => x.Barkod == bark && x.islemno == did).Select(x => x.Miktar).ToList();
                        var fiyat = db.Satisid.Where(x => x.Barkod == bark && x.islemno == did).Select(x => x.Satisfiyat).ToList();
                        foreach (var mik in miktar)
                        {
                            if (barksle == 1)
                            {

                                continue;
                            }
                            foreach (var fiy in fiyat)
                            {

                                if (db.CokluB.Any(a => a.Barkod == bark))//any gelen bilgi data base mevcut mu diye kontrol ediyor varsa
                                {
                                    int urunid = Convert.ToInt32(db.CokluB.Where(a => a.Barkod == bark).Select(b => b.Urunid).FirstOrDefault());
                                    String urunid2 = urunid.ToString();
                                    var urun = db.Urun.Where(a => a.Urunid == urunid).FirstOrDefault();//onu  urune tanımla
                                    var mik2 = Convert.ToDouble(mik);
                                    string mik22 = mik2.ToString();
                                    var mik3 = Convert.ToDouble(fiy);
                                    UrunGetirListeye(urun, urunid, mik2); // void oluşturduk

                                    int satirsayisi = GridSatis.Rows.Count;
                                    if (satirsayisi > 0)
                                    {
                                        for (int i = 0; i < satirsayisi; i++)// satır sayısı kadar kontrol et
                                        {
                                            if (barksle == 1)
                                            {
                                                i++;
                                                continue;

                                            }
                                            if (urunid2 == GridSatis.Rows[i].Cells["Urunid"].Value.ToString() && barksle != 1)// seçili satırdaki barkod db ile aynı ise
                                            {
                                                if (mik22 == GridSatis.Rows[i].Cells["Miktar"].Value.ToString())
                                                {
                                                    GridSatis.Rows[i].Cells["Fiyat"].Value = mik3;
                                                    GridSatis.Rows[i].Cells["Toplam"].Value = mik3 * mik2;
                                                    GridSatis.ClearSelection();

                                                    GenelToplam();
                                                }
                                            }
                                        }
                                    }
                                }

                                //else if (bark.Equals("1111111111116"))
                                //{

                                //    int satırsayısı = GridSatis.Rows.Count;
                                //    GridSatis.Rows.Add();
                                //    GridSatis.Rows[satırsayısı].Cells["Barkod"].Value = "1111111111116";
                                //    GridSatis.Rows[satırsayısı].Cells["UrunAd"].Value = "Birinci Fiş";
                                //    GridSatis.Rows[satırsayısı].Cells["UrunGrup"].Value = "Barkodsuz Ürün";
                                //    GridSatis.Rows[satırsayısı].Cells["Birim"].Value = "Adet";
                                //    GridSatis.Rows[satırsayısı].Cells["Miktar"].Value = 1;
                                //    GridSatis.Rows[satırsayısı].Cells["AlisFiyat"].Value = 0;
                                //    GridSatis.Rows[satırsayısı].Cells["Fiyat"].Value = Convert.ToDouble(fiy);
                                //    GridSatis.Rows[satırsayısı].Cells["KdvTutar"].Value = 0;
                                //    GridSatis.Rows[satırsayısı].Cells["Toplam"].Value = Convert.ToDouble(fiy);
                                //    tNumarator.Text = "";

                                //    GenelToplam();

                                //}
                                GenelToplam();
                            }
                        }
                    }

                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUrunGiris f = new fUrunGiris();
            f.tbarkod.Text = GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
            f.tbarkodGetir(f.tbarkod.Text);
            tBarkod.Focus();
            f.ShowDialog();
        }

        private void b200_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b100_Click(object sender, EventArgs e)
        {
            fFiyatGuncelle f = new fFiyatGuncelle();
            f.ShowDialog();
            tBarkod.Focus();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            if (tmiktar.Text == "")
                tmiktar.Text = "1";
            double sayi = 0;
            sayi = Convert.ToDouble(tmiktar.Text) / 10;


            tmiktar.Text = sayi.ToString();
            tBarkod.Focus();
        }
        private void TekSatırSil()
        {
            if (GridSatis.Rows.Count > 0)
            {
                GridSatis.Rows.Remove(GridSatis.CurrentRow);
                GridSatis.ClearSelection();
                GenelToplam();
            }

            tBarkod.Focus();

        }
        private void b50_Click(object sender, EventArgs e)
        {
            TekSatırSil();
        }

        private void bhesap_Click(object sender, EventArgs e)
        {
            Doviz f = new Doviz();
            f.ShowDialog();
            tBarkod.Focus();
        }

        private void bRheber_Click(object sender, EventArgs e)
        {
            fRehber f = new fRehber();
            f.ShowDialog();
            tBarkod.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tBarkod.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    tmiktar.Text += e.KeyChar;
            //    tNumarator.Text += e.KeyChar;
            //}

        }

        private void tBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '+' || e.KeyChar == '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                e.Handled = true;
            }
        }

        private void bN1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right) // sağ tuşa balsıldığında
            {
                tNumarator.Text = b.Text+"0";
                tmiktar.Text = b.Text+"0";
                tBarkod.Focus();
            }
        }
    }

}



