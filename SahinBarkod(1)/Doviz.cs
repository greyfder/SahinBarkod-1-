using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using MessageBox = System.Windows.Forms.MessageBox;

namespace SahinBarkod_1_
{
    public partial class Doviz : Form
    {

        string op = "";
        PrintDocument pd = new PrintDocument();
        private double memory = 0; // Hafıza için bir değişken oluşturun
        private string mm;
        private int mc = 0;


        Barkod1Entities db = new Barkod1Entities();
        private void kayit()
        {

            using (var context = new Barkod1Entities())
            {
                Hesap ho = new Hesap();
                ho.ekran = ekran.Text;
                ho.toplam = memory;
                ho.tarih = DateTime.Now;
                ho.ayrac = mc;
                db.Hesap.Add(ho);
                db.SaveChanges();
                var recordsToKeep = context.Hesap.OrderByDescending(r => r.Id).Take(10);
                var recordsToDelete = context.Hesap.Except(recordsToKeep);

                context.Hesap.RemoveRange(recordsToDelete);
                context.SaveChanges();

            }


        }
        private void ekran1()
        {
            // TextBox nesnesindeki metni alın
            string text = tNumarator1.Text;

            // İşaretleri \n ile ayrıştırın
            text = text.Replace("=", "\n= ");
            text = text.Replace("+", "\n+ ");
            text = text.Replace("-", "\n- ");
            text = text.Replace("*", "\n* ");
            text = text.Replace("/", "\n/ ");
            // Ayrıştırılmış metni RichTextBox nesnesine yazdırın

            ekran.Text += " " + text + "\n =  " + tNumarator.Text +/* "\n" + mm +*/ "\n" + mm + "-------------" + mc + mm + "\n";
            //ekran.Text += tNumarator1.Text ;

        }
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            if (tNumarator1.Text == "") return;
            mc++;
            // Hafızaya eklemek istediğiniz sayıyı alın
            double number = 0;
            double.TryParse(tNumarator.Text, out number);

            // Sayıyı hafızaya ekleyin
            memory += number;
            mm = "++";
            ekran1();
            ekran2.Text = "Toplam\n==" + memory.ToString("N2") + "\n===========\n     <<00" + mc + ">>\n";

            tNumarator1.Text = "";
            label1.Text = mc.ToString();
        }

        private void btnMRC_Click(object sender, EventArgs e)
        {
            if (memory == 0 && tNumarator1.Text.Equals(tNumarator.Text)) return;
            if (tNumarator1.Text != "" && !tNumarator1.Text.Equals(tNumarator.Text))
                toplam.PerformClick();

            // Hafızadaki sayıyı ekrana yazdırın

            //tNumarator1.Text = tNumarator.Text;
            //if (!tNumarator1.Text.Equals(tNumarator.Text))
            ekran2.Text = "Toplam\n==" + memory.ToString("N2") + "\n===========\n     <<00" + mc + ">>\n";
            //tNumarator1.Text = Math.Abs(memory).ToString("N2");
            //memory = 0;
            tNumarator1.Focus();
            //mc = 0;
        }


        public Doviz()
        {
            InitializeComponent();
        }

        private void back()
        {
            if (tNumarator1.Text == "") return;
            if (tNumarator1.Text.Length > 0)
            {
                tNumarator1.Text = tNumarator1.Text.Substring(0, tNumarator1.Text.Length - 1);
            }
            //tNumarator1.Focus();
        }
        private void bNx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == ",")
            {

                int virgul = tNumarator1.Text.Count(x => x == ',');


                tNumarator1.Text += b.Text;

                //tNumarator1.Focus();

            }
            else if (b.Text == "<")
            {
                if (tNumarator1.Text == "") return;
                if (tNumarator1.Text.Length > 0)
                {
                    tNumarator1.Text = tNumarator1.Text.Substring(0, tNumarator1.Text.Length - 1);
                }
                //tNumarator1.Focus();
            }
            else
            {
                tNumarator1.Text += b.Text;
                //tNumarator1.Focus();
            }
            tNumarator1.Focus();
        }
        private void cikarma_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            if (tNumarator1.Text == "") return;
            mc++;
            // Hafızaya eklemek istediğiniz sayıyı alın
            double number = 0;
            double.TryParse(tNumarator.Text, out number);

            // Sayıyı hafızaya ekleyin
            memory -= number;
            mm = "--";
            ekran1();
            ekran2.Text = "Toplam\n==" + memory.ToString("N2") + "\n===========\n     <<00" + mc + ">>\n";
            tNumarator1.Text = "";
            label1.Text = mc.ToString();
        }
        private void carpma_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            if (tNumarator1.Text == "") return;
            op = "*";
            tNumarator1.Text += op;
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            if (tNumarator1.Text == "") return;
            op = "/";
            tNumarator1.Text += op;
        }

        private void tNumarator1_TextChanged(object sender, EventArgs e)
        {
            string girdi = tNumarator1.Text;

            // Girdideki sayıları ve işlemleri ayrıştırın
            string[] sayilar = girdi.Split(new char[] { '+', '-', '*', '/' });

            char[] islemler = girdi.Where(c => c == '+' || c == '-' || c == '*' || c == '/').ToArray();

            // İlk sayıyı atayın
            if (tNumarator1.Text == "") return;
            if (tNumarator1.Text == ",")
            {
                tNumarator1.Text = "0,";
                return;
            }

            double sonuc = Convert.ToDouble(sayilar[0]);

            // İşlemleri önceliğe göre yapın
            for (int i = 0; i < islemler.Length; i++)
            {
                double sayi;

                try
                {
                    sayi = Convert.ToDouble(sayilar[i + 1]);
                }
                catch (FormatException)
                {
                    // Eleman sayısal değer değil, varsayılan değer atayın
                    sayi = 0;
                }

                if (islemler[i] == '*' || islemler[i] == '/')
                {

                    if (islemler[i] == '*')
                    {
                        sonuc *= sayi;
                    }
                    else if (islemler[i] == '/')
                    {
                        sonuc /= sayi;
                    }
                }
                else
                {

                    if (islemler[i] == '+')
                    {
                        sonuc += sayi;
                    }
                    else if (islemler[i] == '-')
                    {
                        sonuc -= sayi;
                    }
                }
            }

            // Sonucu gösterin
            tNumarator.Text = sonuc.ToString("N2");


        }
        private void dtemizle_Click(object sender, EventArgs e)
        {

            tNumarator1.Clear();
            memory = 0;
            ekran.Clear();
            ekran2.Clear();
            tNumarator.Clear();
            //tNumarator1.Clear();
            tNumarator1.Focus();
            mc = 0;
            label1.Text = mc.ToString();
        }
        private void yazdir_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            if (tNumarator.Text == "" && tNumarator1.Text == "") return;
            if (memory != Convert.ToDouble(tNumarator.Text))
                esittir.PerformClick();

            try
            {
                pd.PrintPage += Pd_PrintPage;
                pd.Print();
                kayit();
                listBox2.Items.Clear();
                ekleme();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void ekleme()
        {
            using (var context = new Barkod1Entities())
            {
                var latestTransactions1 = (from t in context.Hesap
                                           orderby t.tarih descending
                                           select t).Take(10);

                List<Hesap> hesaplar = latestTransactions1.ToList();
                foreach (var h in hesaplar)
                {
                    if (!listBox2.Items.Contains(h.toplam + "                @" + h.Id))
                        listBox2.Items.Add(h.toplam + "                @" + h.Id);
                }
            }
        }
        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {

            // ekran.Text'in kağıda kapladığı yerin ölçümlerini alın
            SizeF size = e.Graphics.MeasureString(ekran.Text, ekran.Font);

            // ekran.Text'i kağıda yazdırın
            e.Graphics.DrawString(ekran.Text, ekran.Font, Brushes.Black, 5, 5);

            //memory.ToString()'ın yazılacağı yerin koordinatlarını belirleyin
            float x = 10;
            float y = 7 + size.Height;

            // memory.ToString()'ı kağıda yazdırın
            e.Graphics.DrawString(ekran2.Text, ekran.Font, Brushes.Black, x, y);
        }

        private void yuzde_Click(object sender, EventArgs e)
        {
            tNumarator1.Clear();
            tNumarator1.Focus();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void Doviz_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tNumarator1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                bolme.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                carpma.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                cikarma.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                toplam.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                esittir.PerformClick();
            }
            if (e.KeyCode == Keys.Right)
            {
                yuzde.PerformClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                temizle.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                back();
            }
            if (e.KeyCode == Keys.PageDown)
            {
                bdolar.PerformClick();
            }
            if (e.KeyCode == Keys.PageUp)
            {
                bRiyal.PerformClick();
            }
        }

        private void tNumarator1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 /*&& e.KeyChar != (char)42 && e.KeyChar != (char)47*/) // 08 klavyede silme tuşu 44 virgül
            {
                e.Handled = true; // TExtboxa sadece rakam girmemizi sağlıyor
            }
            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                tNumarator1.Text += e.KeyChar;
                e.Handled = true;
            }
        }

        private void Doviz_Shown(object sender, EventArgs e)
        {

            tNumarator1.Focus();
            //var nakit = db.islemOzet.Select(x => x.Nakit).ToList();
            //var kart = db.islemOzet.Select(x => x.Kart).ToList();
            using (var context = new Barkod1Entities())
            {
                var latestTransactions = (from t in context.islemOzet
                                          orderby t.Tarih descending
                                          select t).Take(3);

                foreach (var transaction in latestTransactions)
                {
                    if (transaction.Nakit != 0 && transaction.Kart == 0)
                    {
                        listBox1.Items.Add(transaction.Nakit);
                    }
                    else if (transaction.Kart != 0 && transaction.Nakit == 0)
                    {
                        listBox1.Items.Add(transaction.Kart);
                    }
                    else
                    {
                        var NK = transaction.Nakit + transaction.Kart;
                        listBox1.Items.Add(NK);
                    }
                    ekleme();
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int startIndex = 0;
        int endIndex = 0;

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Tıklanan noktayı belirleyen değişkene tıklanan noktanın indeksini atayın
            startIndex = ekran.GetCharIndexFromPosition(e.Location);
        }
        private void richTextBox2_MouseDown(object sender, MouseEventArgs e)
        {
            // Tıklanan noktayı belirleyen değişkene tıklanan noktanın indeksini atayın
            startIndex = ekran2.GetCharIndexFromPosition(e.Location);
        }
        private void richTextBox2_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                // Tıklanan noktayı belirleyen değişkene tıklanan noktanın indeksini atayın
                endIndex = ekran2.GetCharIndexFromPosition(e.Location);

                // Eğer startIndex > endIndex ise, değerleri yer değiştirin
                if (startIndex > endIndex)
                {
                    int temp = startIndex;
                    startIndex = endIndex;
                    endIndex = temp;
                }

                // Tüm metni alın
                string text = ekran2.Text;

                // Tıklanan noktanın sol tarafında bulunan +, -, *, / ve = işaretlerini bulun
                int leftIndex = text.LastIndexOfAny(new char[] { '+', '-', '*', '/', '=' }, startIndex - 1);
                if (leftIndex == -1)
                {
                    leftIndex = 0;
                }

                // Tıklanan noktanın sağ tarafında bulunan +, -, *, / ve = işaretlerini bulun
                int rightIndex = text.IndexOfAny(new char[] { '+', '-', '*', '/', '=' }, endIndex + 1);
                if (rightIndex == -1)
                {
                    rightIndex = text.Length - 1;
                }

                // Seçili metni belirleyin
                ekran2.Select(leftIndex, rightIndex - leftIndex + 1);
                if (ekran2.SelectedText.IndexOfAny(new char[] { '+', '-', '*', '/', '=' }) != -1)
                {
                    // Seçili metni +, -, *, / ve = işaretlerini içermeyen bir şekilde belirleyin
                    string selectedText = ekran2.SelectedText;
                    selectedText = selectedText.TrimStart(new char[] { '+', '-', '*', '/', '=' });
                    selectedText = selectedText.TrimEnd(new char[] { '+', '-', '*', '/', '=' });


                    tNumarator1.Text = selectedText;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Doğru değer seçiniz.");
            }


        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Tıklanan noktayı belirleyen değişkene tıklanan noktanın indeksini atayın
                endIndex = ekran.GetCharIndexFromPosition(e.Location);

                // Eğer startIndex > endIndex ise, değerleri yer değiştirin
                if (startIndex > endIndex)
                {
                    int temp = startIndex;
                    startIndex = endIndex;
                    endIndex = temp;
                }

                // Tüm metni alın
                string text = ekran.Text;

                // Tıklanan noktanın sol tarafında bulunan +, -, *, / ve = işaretlerini bulun
                int leftIndex = text.LastIndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }, startIndex - 1);
                if (leftIndex == -1)
                {
                    leftIndex = 0;
                }

                // Tıklanan noktanın sağ tarafında bulunan +, -, *, / ve = işaretlerini bulun
                int rightIndex = text.IndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }, endIndex + 1);
                if (rightIndex == -1)
                {
                    rightIndex = text.Length - 1;
                }

                // Seçili metni belirleyin

                ekran.Select(leftIndex, rightIndex - leftIndex + 1);
                tNumarator1.Text = "";
                if (ekran.SelectedText.IndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }) != -1)
                {
                    bool op = false;
                    string selectedText = ekran.SelectedText;
                    if (selectedText.EndsWith("+"))
                    {
                        op = true;
                    }
                    else if (selectedText.EndsWith("-"))
                    {
                        op = false;
                    }
                    // Seçili metni +, -, *, / ve = işaretlerini içermeyen bir şekilde belirleyin
                    //string selectedText = ekran.SelectedText;
                    selectedText = selectedText.TrimStart(new char[] { '+', '-'/*, '*', '/', '='*/ });
                    selectedText = selectedText.TrimEnd(new char[] { '+', '-'/*, '*', '/', '=' */});
                    int index = selectedText.IndexOf("=");
                    string number = selectedText.Substring(index + 1);
                    double numberd = Convert.ToDouble(number);
                    // Sayıyı Memory hafızasından çıkartın

                    if (op == true)
                        memory -= numberd;
                    else if (op == false)
                        memory += numberd;
                    mc--;
                    esittir.PerformClick();
                    // Seçili metni silin
                    string Siltext = text.Remove(leftIndex + 1, rightIndex + 16 - leftIndex + 1);

                    //// Yerine yeni bir metin ekleyin
                    string newText = "";
                    ekran.Text = "";
                    ekran.Text = Siltext.Insert(leftIndex + 2, newText);
                }

            }
            else
            {

                try
                {
                    // Tıklanan noktayı belirleyen değişkene tıklanan noktanın indeksini atayın
                    endIndex = ekran.GetCharIndexFromPosition(e.Location);

                    // Eğer startIndex > endIndex ise, değerleri yer değiştirin
                    if (startIndex > endIndex)
                    {
                        int temp = startIndex;
                        startIndex = endIndex;
                        endIndex = temp;
                    }

                    // Tüm metni alın
                    string text = ekran.Text;

                    // Tıklanan noktanın sol tarafında bulunan +, -, *, / ve = işaretlerini bulun
                    int leftIndex = text.LastIndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }, startIndex - 1);
                    if (leftIndex == -1)
                    {
                        leftIndex = 0;
                    }

                    // Tıklanan noktanın sağ tarafında bulunan +, -, *, / ve = işaretlerini bulun
                    int rightIndex = text.IndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }, endIndex + 1);
                    if (rightIndex == -1)
                    {
                        rightIndex = text.Length - 1;
                    }

                    // Seçili metni belirleyin
                    ekran.Select(leftIndex, rightIndex - leftIndex + 1);
                    if (ekran.SelectedText.IndexOfAny(new char[] { '+', '-'/*, '*', '/', '='*/ }) != -1)
                    {

                        // Seçili metni +, -, *, / ve = işaretlerini içermeyen bir şekilde belirleyin
                        string selectedText = ekran.SelectedText;
                        selectedText = selectedText.TrimStart(new char[] { '+', '-'/*, '*', '/', '='*/ });
                        selectedText = selectedText.TrimEnd(new char[] { '+', '-'/*, '*', '/', '=' */});


                        //tNumarator1.Text = selectedText;

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Doğru değer seçiniz.");
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = listBox1.SelectedIndex;
            string selectedItem = listBox1.Items[selectedIndex].ToString();
            tNumarator1.Text = selectedItem;
            tNumarator1.Focus();
        }

        private void Doviz_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (var db = new Barkod1Entities())
            {

                int index = listBox2.SelectedIndex;
                string miktar = listBox2.Items[index].ToString().Split('@')[0].Trim();
                decimal miktar2 = decimal.Parse(miktar);
                if (Math.Abs(miktar2).ToString() == tNumarator1.Text)
                {
                    tNumarator1.Clear();
                    // Seçilen öğenin veritabanındaki detay bilgilerini oku
                    string tarih = listBox2.Items[index].ToString().Split('@')[1].Trim();
                    int tarih2 = Convert.ToInt32(tarih);
                    // Veritabanındaki detay bilgileri okunur
                    var detaylar = (from h in db.Hesap
                                    where h.Id == tarih2
                                    select h).First();

                    // Detay bilgileri TextBox veya RichTextBox nesnelerine eklenir
                    //var ab = (decimal)detaylar.toplam;
                    //var ba = Math.Abs(ab);
                    ekran.Text = detaylar.tarih + "-\n" + detaylar.ekran;
                    //tNumarator1.Text = ba.ToString("N2");

                    //ekran2.Text = "Toplam\n==" + detaylar.toplam + "\n===========\n     <<00" + detaylar.ayrac + ">>\n";
                    memory = (double)detaylar.toplam;
                    mc = (int)detaylar.ayrac;
                    esittir.PerformClick();
                }
                else
                {

                    tNumarator1.Text = Math.Abs(miktar2).ToString();

                }

            }


            tNumarator1.Focus();
        }

        private void bdolar_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            string input = tNumarator1.Text;
            if (input.Contains("*") || input.Contains("/") || input == "") return;

            int length = input.Length;
            if (length < 5)
            {
                int zerosToAdd = 5 - length;
                input = input.PadRight(zerosToAdd + length, '0');

            }
            else if (length > 5)
            {
                input = input.Substring(0, 5);
            }
            //tNumarator1.Text = (Convert.ToDouble(input) / 1000).ToString();
            double number;
            if (double.TryParse(input, out number))
            {
                string result = string.Format("{0:00.000}", (int)number);
                tNumarator1.Text = (Convert.ToDecimal(result) / 1000).ToString(); ;
                // result değişkeni 18,950 şeklinde atanacaktır.

                carpma.PerformClick();

            }
            else
            {
                // Hata handlingi için kodlar
            }
        }

        private void bRiyal_Click(object sender, EventArgs e)
        {
            tNumarator1.Focus();
            string input = tNumarator1.Text;
            if (input.Contains("*") || input.Contains("/") || input == "") return;

            int length = input.Length;
            if (length < 4)
            {
                int zerosToAdd = 4 - length;
                input = input.PadRight(zerosToAdd + length, '0');

            }
            else if (length > 4)
            {
                input = input.Substring(0, 4);
            }
            //tNumarator1.Text = (Convert.ToDouble(input) / 1000).ToString();
            double number;
            if (double.TryParse(input, out number))
            {
                string result = string.Format("{0:0.000}", (int)number);
                tNumarator1.Text = (Convert.ToDecimal(result) / 1000).ToString(); ;
                // result değişkeni 18,950 şeklinde atanacaktır.

                carpma.PerformClick();

            }
            else
            {
                // Hata handlingi için kodlar
            }
        }

        private void bN1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            if (e.Button == MouseButtons.Right) // sağ tuşa balsıldığında
            {
                tNumarator1.Text += b.Text + "00";
                
            }
        }
    }
}