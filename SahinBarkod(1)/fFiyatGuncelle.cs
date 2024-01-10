using HtmlAgilityPack;
using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace SahinBarkod_1_
{
    public partial class fFiyatGuncelle : Form
    {
        public fFiyatGuncelle()
        {
            InitializeComponent();
            InitializeAsync();

                //Timer timer = new Timer();
                //timer.Interval = 3000; // 5000 milisaniye = 5 saniye
                //timer.Tick += new EventHandler(timer_Tick);
                //timer.Start();
        
        }
        //void timer_Tick(object sender, EventArgs e)
        //{
        //    İsBank();
        //    kuveyt();
        //    yapikredi();
        //    ziraat();
        //    MerkezBank();
        //}
        private void fFiyatGuncelle_Load(object sender, EventArgs e)
        {


        }
        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private void b200_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool sayi = false;
        private void WebView_CoreWebView2Ready(object sender, EventArgs e)
        {
            this.Close();
            //try
            //{
            //    webView21.CoreWebView2.Navigate("https://www.youtube.com/watch?v=KY8heuw1QgM&ab_channel=FutureOfDotNET");
            //}
            //catch (Exception ex)
            //{

            //    ex.ToString();
            //}
            //// Now I know that CoreWebView2 is not null, I can do some work with it

        }
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (sayi == false)
                {
                    webView21.CoreWebView2.Navigate("https://www.haremaltin.com/canli-piyasalar/doviz-kurlari");
                    sayi = true;
                }
                else
                {

                    webView21.CoreWebView2.Navigate("https://dovizborsa.com/serbest-piyasa/");
                    sayi = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }


        }
        private void İsBank()
        {
            try
            {
                string url = "https://www.isbank.com.tr/doviz-kurlari";
                string html;

                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                }

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode alisNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ctl18_g_1e38731d_affa_44fc_85c6_ae10fda79f73_ctl00_FxRatesRepeater_ctl00_fxItem\"]/td[2]/text()");
                HtmlNode satisNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ctl18_g_1e38731d_affa_44fc_85c6_ae10fda79f73_ctl00_FxRatesRepeater_ctl00_fxItem\"]/td[3]/text()");

                string alis = alisNode.InnerText;
                string satis = satisNode.InnerText;

                var alis1 = Regex.Match(alis, @"\d+\,*\d*").Value;
                var satis1 = Regex.Match(satis, @"\d+\,*\d*").Value;
                label13.Text = "USD Alış : " + alis1;
                label14.Text = "USD Satış : " + satis1;
                // Euro alış kuru
                string euroBuy = doc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ctl18_g_1e38731d_affa_44fc_85c6_ae10fda79f73_ctl00_FxRatesRepeater_ctl01_fxItem\"]/td[2]/text()").InnerText;

                // Euro satış kuru
                string euroSell = doc.DocumentNode.SelectSingleNode("//*[@id=\"ctl00_ctl18_g_1e38731d_affa_44fc_85c6_ae10fda79f73_ctl00_FxRatesRepeater_ctl01_fxItem\"]/td[3]/text()").InnerText;
                var euroBuy1 = Regex.Match(euroBuy, @"\d+\,*\d*").Value;
                var euroSell1 = Regex.Match(euroSell, @"\d+\,*\d*").Value;
                // Euro alış kuru label'e ata
                label15.Text = "EURO Alış :" + euroBuy1;

                // Euro satış kuru label'e ata
                label16.Text = "EURO Satış :" + euroSell1;
            }
            catch 
            {

                
            }
            
        }
        private void MerkezBank()
        {
            try
            {
                string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
                var xmldoc = new XmlDocument();
                xmldoc.Load(bugun);
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string USDa = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
                label25.Text = string.Format(" USD Alış ;{0}", USDa);
                string USDs = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
                label26.Text = string.Format(" USD Satış ;{0}", USDs);
                string Eura = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteBuying").InnerXml;
                label27.Text = string.Format(" EURO Alış ;{0}", Eura);
                string Eurs = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
                label28.Text = string.Format(" EURO Satış ;{0}", Eurs);
            }
            catch 
            {


            }
            
        }
        private void ziraat()
        {
            try
            {
                string url = "https://www.ziraatbank.com.tr/tr/fiyatlar-ve-oranlar";
                string html;

                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                }

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode alisNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[1]/td[3]");
                HtmlNode satisNode = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[1]/td[4]");

                string alis = alisNode.InnerText;
                string satis = satisNode.InnerText;

                var alis1 = Regex.Match(alis, @"\d+\,*\d*").Value;
                var satis2 = Regex.Match(satis, @"\d+\,*\d*").Value;
                label9.Text = "USD Alış : " + alis;
                label10.Text = "USD Satış : " + satis;
                // Euro alış kuru
                string euroBuy = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[2]/td[3]").InnerText;

                // Euro satış kuru
                string euroSell = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[2]/td[4]").InnerText;
                // var euroBuy1 = Regex.Match(euroBuy, @"\d+\,*\d*").Value;
                // var euroSell1 = Regex.Match(euroSell, @"\d+\,*\d*").Value;
                // Euro alış kuru label'e ata
                label11.Text = "EURO Alış :" + euroBuy;

                // Euro satış kuru label'e ata
                label12.Text = "EURO Satış :" + euroSell;
            }
            catch 
            {

                
            }
           
        }
        private void kuveyt()
        {
            try
            {
                string url = "https://www.kuveytturk.com.tr/finans-portali/";
                string html;

                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                }

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode alisNode = doc.DocumentNode.SelectSingleNode("//div[@class='omegabox']//div[@class='alphabox']//div[@class='cellbox insidebox'][1]/p");
                HtmlNode satisNode = doc.DocumentNode.SelectSingleNode("//div[@class='omegabox']//div[@class='alphabox']//div[@class='cellbox insidebox'][2]/p");

                string alis = alisNode.InnerText;
                string satis = satisNode.InnerText;

                var alis1 = Regex.Match(alis, @"\d+\,*\d*").Value;
                var alis2 = Regex.Match(satis, @"\d+\,*\d*").Value;
                label1.Text = "USD Alış : " + alis1;
                label2.Text = "USD Satış : " + alis2;
                // Euro alış kuru
                string euroBuy = doc.DocumentNode.SelectSingleNode("//div[@class='col-md-4 col-sm-6'][2]//div[@class='alphabox']//div[@class='cellbox insidebox'][1]/p").InnerText;

                // Euro satış kuru
                string euroSell = doc.DocumentNode.SelectSingleNode("//div[@class='col-md-4 col-sm-6'][2]//div[@class='alphabox']//div[@class='cellbox insidebox'][2]/p").InnerText;
                var euroBuy1 = Regex.Match(euroBuy, @"\d+\,*\d*").Value;
                var euroSell1 = Regex.Match(euroSell, @"\d+\,*\d*").Value;
                // Euro alış kuru label'e ata
                label3.Text = "EURO Alış : " + euroBuy1;

                // Euro satış kuru label'e ata
                label4.Text = "EURO Satış : " + euroSell1;
            }
            catch 
            {

                
            }
            
        }
        private void yapikredi()
        {
            try
            {
                string url = "https://www.yapikredi.com.tr/yatirimci-kosesi/doviz-bilgileri";
                string html;

                using (WebClient client = new WebClient())
                {
                    html = client.DownloadString(url);
                }

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);

                // Find the tbody element with id "currencyResultContent"
                HtmlNode tbodyNode = doc.DocumentNode.SelectSingleNode("//tbody[@id='currencyResultContent']");

                // Find the first tr element under tbody
                HtmlNode trNode = tbodyNode.SelectSingleNode("tr");
                HtmlNode trNode1 = tbodyNode.SelectSingleNode("//tr[td[1]='EUR']");
                // Find the first td element under tr and select the third and forth td for buy and sell values
                HtmlNode buyNode = trNode.SelectSingleNode("td[3]");
                HtmlNode sellNode = trNode.SelectSingleNode("td[4]");
                HtmlNode buyeuro = trNode1.SelectSingleNode("td[3]");
                HtmlNode selleuro = trNode1.SelectSingleNode("td[4]");
                string buyValue = buyNode.InnerText;
                string sellValue = sellNode.InnerText;

                label5.Text = "USD Alış : " + buyValue;
                label6.Text = "USD Satış " + sellValue;
                label7.Text = "EURO Alış " + buyeuro.InnerText;
                label8.Text = "EURO Satış :" + selleuro.InnerText;
            }
            catch 
            {

                
            }
           
        }

        private void bhesap_Click(object sender, EventArgs e)
        {
            Doviz f = new Doviz();
            f.ShowDialog();
        }

        private void bKuveyt_Click(object sender, EventArgs e)
        {
            kuveyt();
        }

        private void bYapi_Click(object sender, EventArgs e)
        {
            yapikredi();
        }

        private void bZiraat_Click(object sender, EventArgs e)
        {
            ziraat();
        }

        private void bIsBank_Click(object sender, EventArgs e)
        {
            İsBank();
        }

        private void bMerkez_Click(object sender, EventArgs e)
        {
            MerkezBank();
        }
        //bool ensure = false;

        //private void webView21_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        //{
        //    ensure = true;
        //}
    }
}
