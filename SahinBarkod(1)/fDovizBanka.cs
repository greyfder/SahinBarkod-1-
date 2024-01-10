using System;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.Xml;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Text.RegularExpressions;

namespace SahinBarkod_1_
{
    public partial class fDovizBanka : Form
    {
        public fDovizBanka()
        {
            InitializeComponent();
        }

        private void fDovizBanka_Load(object sender, EventArgs e)
        {
            //Uri url = new Uri("https://www.tcmb.gov.tr/kurlar/today.xml");
            //WebClient client = new WebClient();
            //string html = client.DownloadString(url);
            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(html);
            //HtmlNodeCollection basliklar = doc.DocumentNode.SelectNodes("//a");
            //foreach (var baslik in basliklar)
            //{
            //    string link = baslik.Attributes["href"].Value;
            //    listBox1.Items.Add(baslik.InnerText);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            string USDa = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteBuying").InnerXml;
            label1.Text=string.Format(" USD Alış ;{0}",USDa);
            string USDs = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            label2.Text = string.Format("Tarih {0} USD Satış ;{1}", USDs);
            string Eura = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            label3.Text = string.Format("Tarih {0} EURO Satış ;{1}", Eura);
            string Eurs = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            label4.Text = string.Format("Tarih {0} EURO Satış ;{1}", Eurs);
           
            label5.Text = string.Format("Tarih {0} ", tarih.ToLongDateString());
        }

        private void button2_Click(object sender, EventArgs e)
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

            label1.Text = "Alış Kur : " + buyValue;
            label2.Text = "Satış Kur : " + sellValue;
            label3.Text="Alış Kur :"+buyeuro.InnerText;
            label4.Text = "Alış Kur :" + selleuro.InnerText;
        }

        private void button3_Click(object sender, EventArgs e)
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
            label1.Text = "Dolar Alış : " + alis1;
            label2.Text = "Dolar Satış : " + alis2;
            // Euro alış kuru
            string euroBuy = doc.DocumentNode.SelectSingleNode("//div[@class='col-md-4 col-sm-6'][2]//div[@class='alphabox']//div[@class='cellbox insidebox'][1]/p").InnerText;

            // Euro satış kuru
            string euroSell = doc.DocumentNode.SelectSingleNode("//div[@class='col-md-4 col-sm-6'][2]//div[@class='alphabox']//div[@class='cellbox insidebox'][2]/p").InnerText;
            var euroBuy1 = Regex.Match(euroBuy, @"\d+\,*\d*").Value;
            var euroSell1 = Regex.Match(euroSell, @"\d+\,*\d*").Value;
            // Euro alış kuru label'e ata
            label3.Text = "EURO Alış :"+euroBuy1;

            // Euro satış kuru label'e ata
            label4.Text = "EURO Satış :" + euroSell1;

        }

        private void button4_Click(object sender, EventArgs e)
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
            var alis2 = Regex.Match(satis, @"\d+\,*\d*").Value;
            label1.Text = "Dolar Alış : " + alis1;
            label2.Text = "Dolar Satış : " + alis2;
            // Euro alış kuru
            string euroBuy = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[2]/td[3]").InnerText;

            // Euro satış kuru
            string euroSell = doc.DocumentNode.SelectSingleNode("//*[@id=\"result-dovizkur\"]/div[2]/div/table/tbody/tr[2]/td[4]").InnerText;
            var euroBuy1 = Regex.Match(euroBuy, @"\d+\,*\d*").Value;
            var euroSell1 = Regex.Match(euroSell, @"\d+\,*\d*").Value;
            // Euro alış kuru label'e ata
            label3.Text = "EURO Alış :" + euroBuy1;

            // Euro satış kuru label'e ata
            label4.Text = "EURO Satış :" + euroSell1;
        }
    }
}
