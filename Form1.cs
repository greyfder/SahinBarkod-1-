// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.Form1
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class Form1 : Form
  {
    internal double yenifiyat = 0.0;
    internal double yenimiktar = 0.0;
    internal double didi = 0.0;
    internal string resim = "";
    internal int butonid = 0;
    private Barkod1Entities db = new Barkod1Entities();
    private IContainer components = (IContainer) null;
    private TableLayoutPanel tableLayoutPanel7;
    private TextBox tNumarator;
    private TableLayoutPanel tableLayoutPanel8;
    private Button bN1;
    private Button bN2;
    private Button bN3;
    private Button bN4;
    private Button bN5;
    private Button bN6;
    private Button bN7;
    private Button bN8;
    private Button bN9;
    private Button bNB;
    private Button bN0;
    private Button bNV;
    private Button bh25;
    private Button bh24;
    private Button bh23;
    private TableLayoutPanel tableLayoutPanel4;
    private Button bh22;
    private Button bh21;
    private Button bh20;
    private Button bh19;
    private Button bh18;
    private Button bh17;
    private Button bh16;
    private Button bh15;
    private Button bh14;
    private Button bh13;
    private Button bh12;
    private Button bh11;
    private Button bh10;
    private Button bh9;
    private Button bh8;
    private Button bh7;
    private Button bh6;
    private Button bh5;
    private Button bh4;
    private Button bh3;
    private Button bh2;
    private Button bh1;
    private Button bDigerUrun;
    private Button bİslemBeklet;
    private Button bBarkod;
    private Button biade;
    private Button bOdenen;
    private Button bFisYazdır;
    private Button bAdet;
    private Button button53;
    private TableLayoutPanel tableLayoutPanel9;
    private Button bKartnakit;
    private Button bKart;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel10;
    private TableLayoutPanel tableLayoutPanel11;
    private Label label1;
    private TableLayoutPanel tableLayoutPanel12;
    private Label label2;
    private Label tOdenen;
    private TableLayoutPanel tableLayoutPanel2;
    private Button bNakit;
    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView GridSatis;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private TableLayoutPanel tableLayoutPanel5;
    private TableLayoutPanel tableLayoutPanel6;
    private Button b200;
    private Button b100;
    private Button b50;
    private Button b20;
    private Button button8;
    private DataGridViewImageColumn dataGridViewImageColumn2;
    private Button bGiris;
    private Label tParaustu;
    private TableLayoutPanel tableLayoutPanel13;
    private TextBox textBox3;
    private Button bDuzelt;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem düzenleToolStripMenuItem;
    private DataGridViewTextBoxColumn Barkod;
    private DataGridViewTextBoxColumn Urunad;
    private DataGridViewTextBoxColumn Birim;
    private DataGridViewTextBoxColumn KdvTutar;
    private DataGridViewTextBoxColumn AlisFiyat;
    private DataGridViewTextBoxColumn UrunGrup;
    private DataGridViewTextBoxColumn Miktar;
    private DataGridViewTextBoxColumn Fiyat;
    private DataGridViewTextBoxColumn Toplam;
    private DataGridViewTextBoxColumn Fiyat2;
    private DataGridViewTextBoxColumn Fiyat3;
    private DataGridViewTextBoxColumn Fiyat4;
    private DataGridViewTextBoxColumn Fiyat5;
    private DataGridViewTextBoxColumn Urunid;
    private DataGridViewImageColumn Sil;
    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel14;
    private TableLayoutPanel tableLayoutPanel17;
    private Label label5;
    private TextBox tBarkod;
    private Label label6;
    private TextBox tmiktar;
    private TableLayoutPanel tableLayoutPanel16;
    private RadioButton rsatis5;
    private RadioButton rsatis4;
    private RadioButton rsatis3;
    private RadioButton rsatis2;
    private RadioButton rsatis1;
    private TableLayoutPanel tableLayoutPanel15;
    private Panel panel2;
    private CheckBox chsatisiadeislemi;
    private CheckBox chYazdirma;
    public Label lNakit;
    internal Label lKullanici;
    public Label lKart;
    private DataGridView GridBekle;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private DataGridViewImageColumn dataGridViewImageColumn1;
    private TableLayoutPanel tableLayoutPanel18;
    private Button bs10;
    private Button bsar;
    private Button bs5;
    private Button bsaz;
    private Button bs4;
    private Button bs2;
    private Button bs3;
    private TableLayoutPanel tableLayoutPanel19;
    private Label label3;
    private TextBox textBox2;
    public TextBox tGenelToplam;
    private Button button1;

    public Form1()
    {
      this.InitializeComponent();
      this.tBarkod.GotFocus += new EventHandler(this.tBarkod_GotFocus);
      this.tBarkod.LostFocus += new EventHandler(this.tBarkod_LostFocus);
    }

    private void tBarkod_GotFocus(object sender, EventArgs e) => this.tBarkod.BackColor = SystemColors.Window;

    private void tBarkod_LostFocus(object sender, EventArgs e) => this.tBarkod.BackColor = SystemColors.ScrollBar;

    public void HızlıUrunDoldur()
    {
      foreach (HızlıUrun hızlıUrun in this.db.HızlıUrun.ToList<HızlıUrun>())
      {
        if (((IEnumerable<Control>) this.Controls.Find("bh" + hızlıUrun.Id.ToString(), true)).FirstOrDefault<Control>() is Button button)
        {
          double num = islemler.DoubleYap(hızlıUrun.Fiyat.ToString());
          button.Font = new Font("Microsoft JhengHei UI", 0.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
          button.ForeColor = SystemColors.WindowText;
          Label label1 = new Label();
          label1.BackColor = Color.Lavender;
          label1.Location = new Point(3, 2);
          label1.Font = new Font("Microsoft JhengHei UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
          label1.AutoSize = true;
          label1.Text = num.ToString("C2");
          button.Controls.Add((Control) label1);
          Label label2 = new Label();
          label2.BackColor = Color.Lavender;
          label2.Location = new Point(3, 90);
          label2.Font = new Font("Microsoft JhengHei UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
          label2.AutoSize = true;
          label2.BorderStyle = BorderStyle.None;
          label2.Text = hızlıUrun.UrunAd.ToString();
          button.Controls.Add((Control) label2);
          button.Text = hızlıUrun.UrunAd + "\n" + num.ToString("C2");
        }
      }
    }

    public void resimgetir2()
    {
      try
      {
        string str1 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 1)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str1 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str1.ToString() ?? "";
          this.bh1.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh1.BackgroundImage = (Image) null;
        string str2 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 2)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str2 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str2.ToString() ?? "";
          this.bh2.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh2.BackgroundImage = (Image) null;
        string str3 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 3)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str3 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str3.ToString() ?? "";
          this.bh3.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh3.BackgroundImage = (Image) null;
        string str4 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 4)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str4 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str4.ToString() ?? "";
          this.bh4.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh4.BackgroundImage = (Image) null;
        string str5 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 5)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str5 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str5.ToString() ?? "";
          this.bh5.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh5.BackgroundImage = (Image) null;
        string str6 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 6)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str6 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str6.ToString() ?? "";
          this.bh6.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh6.BackgroundImage = (Image) null;
        string str7 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 7)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str7 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str7.ToString() ?? "";
          this.bh7.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh7.BackgroundImage = (Image) null;
        string str8 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 8)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str8 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str8.ToString() ?? "";
          this.bh8.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh8.BackgroundImage = (Image) null;
        string str9 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 9)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str9 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str9.ToString() ?? "";
          this.bh9.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh9.BackgroundImage = (Image) null;
        string str10 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 10)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str10 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str10.ToString() ?? "";
          this.bh10.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh10.BackgroundImage = (Image) null;
        string str11 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 11)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str11 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str11.ToString() ?? "";
          this.bh11.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh11.BackgroundImage = (Image) null;
        string str12 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 12)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str12 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str12.ToString() ?? "";
          this.bh12.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh12.BackgroundImage = (Image) null;
        string str13 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 13)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str13 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str13.ToString() ?? "";
          this.bh13.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh13.BackgroundImage = (Image) null;
        string str14 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 14)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str14 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str14.ToString() ?? "";
          this.bh14.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh14.BackgroundImage = (Image) null;
        string str15 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 15)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str15 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str15.ToString() ?? "";
          this.bh15.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh15.BackgroundImage = (Image) null;
        string str16 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 16)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str16 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str16.ToString() ?? "";
          this.bh16.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh16.BackgroundImage = (Image) null;
        string str17 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 17)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str17 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str17.ToString() ?? "";
          this.bh17.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh17.BackgroundImage = (Image) null;
        string str18 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 18)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str18 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str18.ToString() ?? "";
          this.bh18.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh18.BackgroundImage = (Image) null;
        string str19 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 19)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str19 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str19.ToString() ?? "";
          this.bh19.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh19.BackgroundImage = (Image) null;
        string str20 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 20)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str20 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str20.ToString() ?? "";
          this.bh20.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh20.BackgroundImage = (Image) null;
        string str21 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 21)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str21 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str21.ToString() ?? "";
          this.bh21.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh21.BackgroundImage = (Image) null;
        string str22 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 22)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str22 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str22.ToString() ?? "";
          this.bh22.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh22.BackgroundImage = (Image) null;
        string str23 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 23)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str23 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str23.ToString() ?? "";
          this.bh23.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh23.BackgroundImage = (Image) null;
        string str24 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 24)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str24 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str24.ToString() ?? "";
          this.bh24.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh24.BackgroundImage = (Image) null;
        string str25 = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Id == 25)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (x => x.Resim)).FirstOrDefault<string>();
        if (str25 != "-")
        {
          OpenFileDialog openFileDialog = new OpenFileDialog();
          openFileDialog.FileName = str25.ToString() ?? "";
          this.bh25.BackgroundImage = Image.FromFile(openFileDialog.FileName);
        }
        else
          this.bh25.BackgroundImage = (Image) null;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("HIZLI ÜRÜN RESİMLERİNDEN BİRİ KAYIP. \n YENİ BİR RESİM BELİRLEYİN\n" + ex.ToString());
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.tBarkod.Focus();
      this.HızlıUrunDoldur();
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        this.chYazdirma.Checked = Convert.ToBoolean((object) barkod1Entities.Sabit.FirstOrDefault<Sabit>().Yazici);
      this.resimgetir2();
    }

    private void bNx_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      if (button.Text == ",")
      {
        if (this.tNumarator.Text.Count<char>((Func<char, bool>) (x => x == ',')) >= 1)
          return;
        this.tNumarator.Text += button.Text;
      }
      else if (button.Text == "<")
      {
        if (this.tNumarator.Text.Length <= 0)
          return;
        this.tNumarator.Text = this.tNumarator.Text.Substring(0, this.tNumarator.Text.Length - 1);
      }
      else
        this.tNumarator.Text += button.Text;
    }

    private void tBarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      string barkod = this.tBarkod.Text.Trim();
      if (barkod.Length >= 2)
      {
        if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)))
        {
          int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
          this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).FirstOrDefault<Urun>(), urunid, Convert.ToDouble(this.tmiktar.Text));
        }
        else
        {
          try
          {
            int onek = (int) Convert.ToInt16(barkod.Substring(0, 2));
            if (this.db.Terazi.Any<Terazi>((Expression<Func<Terazi, bool>>) (a => a.TeraziOnEk == (int?) onek)))
            {
              string teraziurunno = barkod.Substring(2, 5);
              if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == teraziurunno)))
              {
                int Urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == teraziurunno)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
                Urun urun = this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == Urunid)).FirstOrDefault<Urun>();
                double miktar = Convert.ToDouble(barkod.Substring(7, 5)) / 1000.0;
                this.UrunGetirListeye(urun, Urunid, miktar);
              }
              else
              {
                Console.Beep(900, 2000);
                int num = (int) MessageBox.Show("Kg urun ekleme sayfası");
              }
            }
            else if (MessageBox.Show("Ürün Kayıtlı değil! \n Kaydetmek ister misiniz?", "Ürün Kaydetme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              fUrunGiris fUrunGiris = new fUrunGiris();
              fUrunGiris.tbarkod.Text = barkod;
              int num = (int) fUrunGiris.ShowDialog();
            }
          }
          catch (FormatException ex)
          {
            if (MessageBox.Show("Ürün Kayıtlı değil! \n Kaydetmek ister misiniz?", "Ürün Kaydetme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
              fUrunGiris fUrunGiris = new fUrunGiris();
              fUrunGiris.tbarkod.Text = barkod;
              int num = (int) fUrunGiris.ShowDialog();
            }
          }
        }
      }
      this.GridSatis.ClearSelection();
      this.GenelToplam();
    }

    public void UrunGetirListeye(Urun urun, int urunid, double miktar)
    {
      int count = this.GridSatis.Rows.Count;
      bool flag = false;
      if (count > 0)
      {
        for (int index = 0; index < count; ++index)
        {
          if (this.GridSatis.Rows[index].Cells["Barkod"].Value.ToString() != "1111111111116" && this.GridSatis.Rows[index].Cells["Urunid"].Value.ToString() == urunid.ToString())
          {
            this.GridSatis.Rows[index].Cells["Miktar"].Value = (object) (miktar + Convert.ToDouble(this.GridSatis.Rows[index].Cells["Miktar"].Value));
            this.GridSatis.Rows[index].Cells["Toplam"].Value = (object) Math.Round(Convert.ToDouble(this.GridSatis.Rows[index].Cells["Miktar"].Value) * Convert.ToDouble(this.GridSatis.Rows[index].Cells["Fiyat"].Value), 2);
            flag = true;
          }
        }
      }
      if (flag)
        return;
      this.GridSatis.Rows.Add();
      this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urunid;
      this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
      if (this.rsatis1.Checked)
      {
        double num1 = Convert.ToDouble((object) urun.SatisFiyat);
        if (num1 > 0.0)
        {
          this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
          this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) num1;
          this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) miktar;
          this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Math.Round(miktar * num1, 2);
          this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urun.Barkod;
          this.GridSatis.Rows[count].Cells["Urunad"].Value = (object) urun.UrunAd;
          this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) urun.UrunGrup;
          this.GridSatis.Rows[count].Cells["Birim"].Value = (object) urun.Birim;
          this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) urun.AlisFiyat;
          this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) urun.KdvTutari;
          if (count > 0)
          {
            this.GridSatis.Rows[count].Selected = true;
            this.GridSatis.Rows[count].Cells[0].Selected = true;
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.GridSatis.Rows.Clear();
        }
      }
      else if (this.rsatis2.Checked)
      {
        double num3 = Convert.ToDouble((object) urun.SatisFiyat2);
        if (num3 > 0.0)
        {
          this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
          this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) num3;
          this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) miktar;
          this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Math.Round(miktar * num3, 2);
          this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urun.Barkod;
          this.GridSatis.Rows[count].Cells["Urunad"].Value = (object) urun.UrunAd;
          this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) urun.UrunGrup;
          this.GridSatis.Rows[count].Cells["Birim"].Value = (object) urun.Birim;
          this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) urun.AlisFiyat;
          this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) urun.KdvTutari;
          if (count > 0)
          {
            this.GridSatis.Rows[count].Selected = true;
            this.GridSatis.Rows[count].Cells[0].Selected = true;
          }
        }
        else
        {
          int num4 = (int) MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.GridSatis.Rows.Clear();
        }
      }
      else if (this.rsatis3.Checked)
      {
        double num5 = Convert.ToDouble((object) urun.SatisFiyat3);
        if (num5 > 0.0)
        {
          this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
          this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) num5;
          this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) miktar;
          this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Math.Round(miktar * num5, 2);
          this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urun.Barkod;
          this.GridSatis.Rows[count].Cells["Urunad"].Value = (object) urun.UrunAd;
          this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) urun.UrunGrup;
          this.GridSatis.Rows[count].Cells["Birim"].Value = (object) urun.Birim;
          this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) urun.AlisFiyat;
          this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) urun.KdvTutari;
          if (count > 0)
          {
            this.GridSatis.Rows[count].Selected = true;
            this.GridSatis.Rows[count].Cells[0].Selected = true;
          }
        }
        else
        {
          int num6 = (int) MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.GridSatis.Rows.Clear();
        }
      }
      else if (this.rsatis4.Checked)
      {
        double num7 = Convert.ToDouble((object) urun.SatisFiyat4);
        if (num7 > 0.0)
        {
          this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
          this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) num7;
          this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) miktar;
          this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Math.Round(miktar * num7, 2);
          this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urun.Barkod;
          this.GridSatis.Rows[count].Cells["Urunad"].Value = (object) urun.UrunAd;
          this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) urun.UrunGrup;
          this.GridSatis.Rows[count].Cells["Birim"].Value = (object) urun.Birim;
          this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) urun.AlisFiyat;
          this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) urun.KdvTutari;
          if (count > 0)
          {
            this.GridSatis.Rows[count].Selected = true;
            this.GridSatis.Rows[count].Cells[0].Selected = true;
          }
        }
        else
        {
          int num8 = (int) MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.GridSatis.Rows.Clear();
        }
      }
      else if (this.rsatis5.Checked)
      {
        double num9 = Convert.ToDouble((object) urun.SatisFiyat5);
        if (num9 > 0.0)
        {
          this.GridSatis.Rows[count].Cells["Urunid"].Value = (object) urunid;
          this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) num9;
          this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) miktar;
          this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Math.Round(miktar * num9, 2);
          this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) urun.Barkod;
          this.GridSatis.Rows[count].Cells["Urunad"].Value = (object) urun.UrunAd;
          this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) urun.UrunGrup;
          this.GridSatis.Rows[count].Cells["Birim"].Value = (object) urun.Birim;
          this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) urun.AlisFiyat;
          this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) urun.KdvTutari;
          if (count > 0)
          {
            this.GridSatis.Rows[count].Selected = true;
            this.GridSatis.Rows[count].Cells[0].Selected = true;
          }
        }
        else
        {
          int num10 = (int) MessageBox.Show("Ürün Fiyat Güncelle", "Dİkkat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          this.GridSatis.Rows.Clear();
        }
      }
    }

    private void HızlıButonClick(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      int butonid = (int) Convert.ToUInt16(button.Name.ToString().Substring(2, button.Name.Length - 2));
      if (button.Text.ToString().StartsWith("-"))
      {
        fHızlıButonUrunEkle hızlıButonUrunEkle = new fHızlıButonUrunEkle();
        hızlıButonUrunEkle.lbutonid.Text = butonid.ToString();
        int num = (int) hızlıButonUrunEkle.ShowDialog();
      }
      else
      {
        string barkodid = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (a => a.Id == butonid)).Select<HızlıUrun, string>((Expression<Func<HızlıUrun, string>>) (a => a.Barkod)).FirstOrDefault<string>();
        int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkodid)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (a => a.Urunid)).FirstOrDefault<int?>());
        this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).FirstOrDefault<Urun>(), urunid, Convert.ToDouble(this.tmiktar.Text));
        this.GenelToplam();
      }
    }

    private void GenelToplam()
    {
      double num1 = 0.0;
      double num2 = 0.0;
      for (int index = 0; index < this.GridSatis.Rows.Count; ++index)
      {
        num1 += Convert.ToDouble(this.GridSatis.Rows[index].Cells["Toplam"].Value);
        num2 += Convert.ToDouble(this.GridSatis.Rows[index].Cells["Miktar"].Value);
      }
      this.tGenelToplam.Text = num1.ToString("c2");
      this.textBox2.Text = num2.ToString();
      this.tBarkod.Focus();
      this.tBarkod.Clear();
      this.tmiktar.Text = "1";
    }

    private void GridSatis_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == 14)
      {
        this.GridSatis.Rows.Remove(this.GridSatis.CurrentRow);
        this.GridSatis.ClearSelection();
        this.GenelToplam();
        this.tBarkod.Focus();
      }
      if (e.ColumnIndex == 7 | e.ColumnIndex == 8)
      {
        int num = (int) new fFiyatDegistir()
        {
          eskifiyat = this.GridSatis.CurrentRow.Cells["Fiyat"].Value.ToString()
        }.ShowDialog();
        string str = this.yenifiyat.ToString();
        string barkod = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
        this.GridSatis.CurrentRow.Cells["Fiyat"].Value = (object) str;
        int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
        this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).FirstOrDefault<Urun>(), urunid, Convert.ToDouble(this.tmiktar.Text) - 1.0);
        this.GenelToplam();
        this.tBarkod.Focus();
      }
      if (!(e.ColumnIndex == 6 | e.ColumnIndex == 2))
        return;
      int num1 = (int) new fMiktarDegistir()
      {
        eskiMiktar = this.GridSatis.CurrentRow.Cells["Miktar"].Value.ToString()
      }.ShowDialog();
      this.GridSatis.CurrentRow.Cells["Miktar"].Value = (object) this.yenimiktar.ToString();
      string barkod1 = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
      int urunid1 = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod1)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
      this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid1)).FirstOrDefault<Urun>(), urunid1, Convert.ToDouble(this.tmiktar.Text) - 1.0);
      this.GenelToplam();
      this.tBarkod.Focus();
    }

    private void bh_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right)
        return;
      Button button = (Button) sender;
      if (!button.Text.StartsWith("-") || button.BackgroundImage != null)
      {
        int int16 = (int) Convert.ToInt16(button.Name.ToString().Substring(2, button.Name.Length - 2));
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
        toolStripMenuItem.Text = "Temizle - Buton No:" + int16.ToString();
        toolStripMenuItem.Click += new EventHandler(this.Sil_Click);
        contextMenuStrip.Items.Add((ToolStripItem) toolStripMenuItem);
        this.ContextMenuStrip = contextMenuStrip;
      }
    }

    private void Sil_Click(object sender, EventArgs e)
    {
      int int16 = (int) Convert.ToInt16(sender.ToString().Substring(19, sender.ToString().Length - 19));
      HızlıUrun hızlıUrun = this.db.HızlıUrun.Find(new object[1]
      {
        (object) int16
      });
      hızlıUrun.Barkod = "-";
      hızlıUrun.UrunAd = "-";
      hızlıUrun.Fiyat = new double?(0.0);
      hızlıUrun.Resim = "-";
      this.db.SaveChanges();
      double num = 0.0;
      (((IEnumerable<Control>) this.Controls.Find("bh" + int16.ToString(), true)).FirstOrDefault<Control>() as Button).Text = "-\n" + num.ToString("C2");
      this.HızlıUrunDoldur();
      this.resimgetir2();
    }

    private void bAdet_Click(object sender, EventArgs e)
    {
      if (!(this.tNumarator.Text != ""))
        return;
      this.tmiktar.Text = this.tNumarator.Text;
      this.tNumarator.Clear();
      this.tBarkod.Clear();
      this.tBarkod.Focus();
    }

    private void bs10_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = "10";
      this.tBarkod.Focus();
    }

    private void bs5_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = "5";
      this.tBarkod.Focus();
    }

    private void bs4_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = "4";
      this.tBarkod.Focus();
    }

    private void bs3_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = "3";
      this.tBarkod.Focus();
    }

    private void bs2_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = "2";
      this.tBarkod.Focus();
    }

    private void bsaz_Click(object sender, EventArgs e)
    {
      double num = Convert.ToDouble(this.tmiktar.Text) - 1.0;
      if (num > 0.0)
        this.tmiktar.Text = num.ToString();
      this.tBarkod.Focus();
    }

    private void bsar_Click(object sender, EventArgs e)
    {
      double num = Convert.ToDouble(this.tmiktar.Text) + 1.0;
      if (num > 0.0)
        this.tmiktar.Text = num.ToString();
      this.tBarkod.Focus();
    }

    private void bOdenen_Click(object sender, EventArgs e)
    {
      if (this.tNumarator.Text != "")
      {
        double num = islemler.DoubleYap(this.tGenelToplam.Text) - islemler.DoubleYap(this.tNumarator.Text);
        this.tOdenen.Text = this.tNumarator.Text.ToString();
        this.tParaustu.Text = num.ToString();
        this.tNumarator.Clear();
        this.tBarkod.Focus();
      }
      else
      {
        if (!(this.tOdenen.Text != ""))
          return;
        this.tParaustu.Text = (islemler.DoubleYap(this.tGenelToplam.Text) - islemler.DoubleYap(this.tOdenen.Text)).ToString();
        this.tNumarator.Clear();
        this.tBarkod.Focus();
      }
    }

    private void bBarkod_Click(object sender, EventArgs e)
    {
      if (this.tNumarator.Text == null)
        return;
      if (this.db.Urun.Any<Urun>((Expression<Func<Urun, bool>>) (a => a.Barkod == this.tNumarator.Text)))
      {
        this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Barkod == this.tNumarator.Text)).FirstOrDefault<Urun>(), Convert.ToInt32(this.tNumarator.Text), Convert.ToDouble(this.tmiktar.Text));
        this.tNumarator.Text = "";
        this.tBarkod.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("Ürün ekleme sayfası aç");
      }
    }

    private void bDigerUrun_Click(object sender, EventArgs e)
    {
      if (this.tNumarator.Text != "")
      {
        int count = this.GridSatis.Rows.Count;
        this.GridSatis.Rows.Add();
        this.GridSatis.Rows[count].Cells["Barkod"].Value = (object) "1111111111116";
        this.GridSatis.Rows[count].Cells["UrunAd"].Value = (object) "Birinci Fiş";
        this.GridSatis.Rows[count].Cells["UrunGrup"].Value = (object) "Barkodsuz Ürün";
        this.GridSatis.Rows[count].Cells["Birim"].Value = (object) "Adet";
        this.GridSatis.Rows[count].Cells["Miktar"].Value = (object) 1;
        this.GridSatis.Rows[count].Cells["AlisFiyat"].Value = (object) 0;
        this.GridSatis.Rows[count].Cells["Fiyat"].Value = (object) Convert.ToDouble(this.tNumarator.Text);
        this.GridSatis.Rows[count].Cells["KdvTutar"].Value = (object) 0;
        this.GridSatis.Rows[count].Cells["Toplam"].Value = (object) Convert.ToDouble(this.tNumarator.Text);
        this.tNumarator.Text = "";
        this.GenelToplam();
        this.tBarkod.Focus();
        if (count <= 0)
          return;
        this.GridSatis.Rows[count].Selected = true;
        this.GridSatis.Rows[count].Cells[0].Selected = true;
      }
      else
        this.tNumarator.Text = "0";
    }

    private void biade_Click(object sender, EventArgs e)
    {
      if (this.chsatisiadeislemi.Checked)
      {
        this.chsatisiadeislemi.Checked = false;
        this.chsatisiadeislemi.Text = "Satış Yapılıyor.";
      }
      else
      {
        this.chsatisiadeislemi.Checked = true;
        this.chsatisiadeislemi.Text = "İade İşlemi.";
      }
    }

    private void button53_Click(object sender, EventArgs e) => this.temizle();

    private void temizle()
    {
      this.tmiktar.Text = "1";
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
      int count = this.GridSatis.Rows.Count;
      bool flag = this.chsatisiadeislemi.Checked;
      double num = 0.0;
      if (count <= 0)
        return;
      int? islemno1 = this.db.islem.First<islem>().islemno;
      Satisid entity1 = new Satisid();
      for (int index = 0; index < count; ++index)
      {
        entity1.islemno = islemno1;
        entity1.Urunad = this.GridSatis.Rows[index].Cells["UrunAd"].Value.ToString();
        entity1.Urungrup = this.GridSatis.Rows[index].Cells["UrunGrup"].Value.ToString();
        entity1.Barkod = this.GridSatis.Rows[index].Cells["Barkod"].Value.ToString();
        entity1.Birim = this.GridSatis.Rows[index].Cells["Birim"].Value.ToString();
        entity1.Alisfiyat = new double?(islemler.DoubleYap(this.GridSatis.Rows[index].Cells["AlisFiyat"].Value.ToString()));
        entity1.Satisfiyat = new double?(islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Fiyat"].Value.ToString()));
        entity1.Miktar = new double?(islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString()));
        entity1.Toplam = new double?(islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Toplam"].Value.ToString()));
        entity1.Kdvtutari = new double?(islemler.DoubleYap(this.GridSatis.Rows[index].Cells["KdvTutar"].Value.ToString()) * islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString()));
        entity1.Odemesekli = odemesekli;
        entity1.İade = new bool?(flag);
        entity1.Tarih = new DateTime?(DateTime.Now);
        entity1.Kullanici = this.lKullanici.Text;
        this.db.Satisid.Add(entity1);
        this.db.SaveChanges();
        if (!flag)
          islemler.StokAzalt(this.GridSatis.Rows[index].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString()));
        else
          islemler.StokArttır(this.GridSatis.Rows[index].Cells["Barkod"].Value.ToString(), islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString()));
        num += islemler.DoubleYap(this.GridSatis.Rows[index].Cells["AlisFiyat"].Value.ToString()) * islemler.DoubleYap(this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString());
      }
      islemOzet entity2 = new islemOzet();
      entity2.İslemNo = islemno1;
      entity2.İade = new bool?(flag);
      entity2.AlısFiyatToplam = new double?(num);
      entity2.Gelir = new bool?(false);
      entity2.Gider = new bool?(false);
      entity2.Acıklama = flag ? "İade işlemi (" + odemesekli + ")" : odemesekli + "Satış";
      entity2.OdemeSekli = odemesekli;
      entity2.Kullanici = this.lKullanici.Text;
      entity2.Tarih = new DateTime?(DateTime.Now);
      string str = odemesekli;
      if (!(str == "Nakit"))
      {
        if (!(str == "Kart"))
        {
          if (str == "Kart-Nakit")
          {
            entity2.Nakit = new double?(islemler.DoubleYap(this.lNakit.Text));
            entity2.Kart = new double?(islemler.DoubleYap(this.lKart.Text));
          }
        }
        else
        {
          entity2.Nakit = new double?(0.0);
          entity2.Kart = new double?(islemler.DoubleYap(this.tGenelToplam.Text));
        }
      }
      else
      {
        entity2.Nakit = new double?(islemler.DoubleYap(this.tGenelToplam.Text));
        entity2.Kart = new double?(0.0);
      }
      this.db.islemOzet.Add(entity2);
      this.db.SaveChanges();
      islem islem = this.db.islem.First<islem>();
      int? islemno2 = islem.islemno;
      islem.islemno = islemno2.HasValue ? new int?(islemno2.GetValueOrDefault() + 1) : new int?();
      this.db.SaveChanges();
      if (this.chYazdirma.Checked)
        new Yazdir(islemno1).YazdirmayaBasla();
      this.temizle();
    }

    private void bNakit_Click(object sender, EventArgs e)
    {
      this.SatisYap("Nakit");
      if (!this.db.islemOzet.Any<islemOzet>())
        return;
      double did = Convert.ToDouble(this.db.islemOzet.Max<islemOzet, int?>((Expression<Func<islemOzet, int?>>) (x => x.İslemNo)).Value.ToString());
      this.bDuzelt.Text = this.db.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => (double?) x.İslemNo == (double?) did)).Select<islemOzet, double?>((Expression<Func<islemOzet, double?>>) (x => x.Nakit)).FirstOrDefault<double?>().ToString();
    }

    private void bKart_Click(object sender, EventArgs e)
    {
      this.SatisYap("Kart");
      if (!this.db.islemOzet.Any<islemOzet>())
        return;
      double did = Convert.ToDouble(this.db.islemOzet.Max<islemOzet, int?>((Expression<Func<islemOzet, int?>>) (x => x.İslemNo)).Value.ToString());
      this.bDuzelt.Text = this.db.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => (double?) x.İslemNo == (double?) did)).Select<islemOzet, double?>((Expression<Func<islemOzet, double?>>) (x => x.Kart)).FirstOrDefault<double?>().ToString();
    }

    private void bKartnakit_Click(object sender, EventArgs e)
    {
      int num = (int) new fnakitkart().ShowDialog();
    }

    private void tmiktar_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
        return;
      e.Handled = true;
    }

    private void tNumarator_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
        return;
      e.Handled = true;
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F1)
      {
        this.SatisYap("Nakit");
        if (this.db.islemOzet.Any<islemOzet>())
        {
          double did = Convert.ToDouble(this.db.islemOzet.Max<islemOzet, int?>((Expression<Func<islemOzet, int?>>) (x => x.İslemNo)).Value.ToString());
          this.bDuzelt.Text = this.db.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => (double?) x.İslemNo == (double?) did)).Select<islemOzet, double?>((Expression<Func<islemOzet, double?>>) (x => x.Nakit)).FirstOrDefault<double?>().ToString();
        }
      }
      if (e.KeyCode == Keys.F2)
      {
        this.SatisYap("Kart");
        if (this.db.islemOzet.Any<islemOzet>())
        {
          double did = Convert.ToDouble(this.db.islemOzet.Max<islemOzet, int?>((Expression<Func<islemOzet, int?>>) (x => x.İslemNo)).Value.ToString());
          this.bDuzelt.Text = this.db.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => (double?) x.İslemNo == (double?) did)).Select<islemOzet, double?>((Expression<Func<islemOzet, double?>>) (x => x.Kart)).FirstOrDefault<double?>().ToString();
        }
      }
      if (e.KeyCode == Keys.F3)
      {
        int num1 = (int) new fnakitkart().ShowDialog();
      }
      if (e.KeyCode == Keys.Divide)
      {
        int num2 = (int) new fMiktarDegistir()
        {
          eskiMiktar = this.GridSatis.CurrentRow.Cells["Miktar"].Value.ToString()
        }.ShowDialog();
        this.GridSatis.CurrentRow.Cells["Miktar"].Value = (object) this.yenimiktar.ToString();
        string barkod = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
        int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
        this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).FirstOrDefault<Urun>(), urunid, Convert.ToDouble(this.tmiktar.Text) - 1.0);
        this.GenelToplam();
        this.tBarkod.Focus();
      }
      if (e.KeyCode != Keys.Multiply)
        return;
      int num3 = (int) new fFiyatDegistir()
      {
        eskifiyat = this.GridSatis.CurrentRow.Cells["Fiyat"].Value.ToString()
      }.ShowDialog();
      string str = this.yenifiyat.ToString();
      string barkod1 = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
      this.GridSatis.CurrentRow.Cells["Fiyat"].Value = (object) str;
      int urunid1 = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod1)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
      this.UrunGetirListeye(this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid1)).FirstOrDefault<Urun>(), urunid1, Convert.ToDouble(this.tmiktar.Text) - 1.0);
      this.GenelToplam();
      this.tBarkod.Focus();
    }

    private void bİslemBeklet_Click(object sender, EventArgs e)
    {
      if (this.bİslemBeklet.Text == "İşlem Beklet")
      {
        this.Bekle();
        this.bİslemBeklet.BackColor = Color.OrangeRed;
        this.bİslemBeklet.Text = "Bekleyen İşlem 1";
        this.GridSatis.Rows.Clear();
      }
      else if (this.GridSatis.Rows.Count == 0)
      {
        this.BeklemedenCık();
        this.bİslemBeklet.BackColor = Color.DimGray;
        this.bİslemBeklet.Text = "İşlem Beklet";
        this.GridBekle.Rows.Clear();
      }
    }

    private void Bekle()
    {
      this.tGenelToplam.Text = "0";
      int count1 = this.GridSatis.Rows.Count;
      int count2 = this.GridSatis.Columns.Count;
      if (count1 > 0)
      {
        for (int index1 = 0; index1 < count1; ++index1)
        {
          this.GridBekle.Rows.Add();
          for (int index2 = 0; index2 < count2 - 1; ++index2)
            this.GridBekle.Rows[index1].Cells[index2].Value = this.GridSatis.Rows[index1].Cells[index2].Value;
        }
      }
      this.tBarkod.Focus();
    }

    private void BeklemedenCık()
    {
      this.tGenelToplam.Text = "0";
      int count1 = this.GridBekle.Rows.Count;
      int count2 = this.GridBekle.Columns.Count;
      if (count1 > 0)
      {
        for (int index1 = 0; index1 < count1; ++index1)
        {
          this.GridSatis.Rows.Add();
          for (int index2 = 0; index2 < count2 - 1; ++index2)
          {
            this.GridSatis.Rows[index1].Cells[index2].Value = this.GridBekle.Rows[index1].Cells[index2].Value;
            this.GenelToplam();
          }
        }
      }
      this.tBarkod.Focus();
    }

    private void chsatisiadeislemi_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chsatisiadeislemi.Checked)
        this.chsatisiadeislemi.Text = "İade Yapılıyor...";
      else
        this.chsatisiadeislemi.Text = "Satış İşlemi Yapılıyor.";
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = (-Convert.ToDouble(this.tmiktar.Text)).ToString();
      this.tBarkod.Focus();
    }

    private void rsatis1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rsatis1.Checked)
        return;
      this.tBarkod.Focus();
      this.rsatis1.BackColor = SystemColors.ControlDark;
      this.rsatis2.BackColor = SystemColors.Control;
      this.rsatis3.BackColor = SystemColors.Control;
      this.rsatis4.BackColor = SystemColors.Control;
      this.rsatis5.BackColor = SystemColors.Control;
    }

    private void rsatis2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rsatis2.Checked)
        return;
      this.tBarkod.Focus();
      this.rsatis1.BackColor = SystemColors.Control;
      this.rsatis2.BackColor = SystemColors.ControlDark;
      this.rsatis3.BackColor = SystemColors.Control;
      this.rsatis4.BackColor = SystemColors.Control;
      this.rsatis5.BackColor = SystemColors.Control;
    }

    private void rsatis3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rsatis3.Checked)
        return;
      this.tBarkod.Focus();
      this.rsatis1.BackColor = SystemColors.Control;
      this.rsatis2.BackColor = SystemColors.Control;
      this.rsatis3.BackColor = SystemColors.ControlDark;
      this.rsatis4.BackColor = SystemColors.Control;
      this.rsatis5.BackColor = SystemColors.Control;
    }

    private void rsatis4_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rsatis4.Checked)
        return;
      this.tBarkod.Focus();
      this.rsatis1.BackColor = SystemColors.Control;
      this.rsatis2.BackColor = SystemColors.Control;
      this.rsatis3.BackColor = SystemColors.Control;
      this.rsatis4.BackColor = SystemColors.ControlDark;
      this.rsatis5.BackColor = SystemColors.Control;
    }

    private void rsatis5_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.rsatis5.Checked)
        return;
      this.tBarkod.Focus();
      this.rsatis1.BackColor = SystemColors.Control;
      this.rsatis2.BackColor = SystemColors.Control;
      this.rsatis3.BackColor = SystemColors.Control;
      this.rsatis4.BackColor = SystemColors.Control;
      this.rsatis5.BackColor = SystemColors.ControlDark;
    }

    private void button51_Click(object sender, EventArgs e)
    {
      int num = (int) new fHizliFis().ShowDialog();
    }

    private void tmiktar_Click(object sender, EventArgs e)
    {
      this.tmiktar.Focus();
      this.tmiktar.SelectAll();
    }

    private void tNumarator_Click(object sender, EventArgs e)
    {
      this.tNumarator.Focus();
      this.tNumarator.SelectAll();
    }

    private void bGiris_Click(object sender, EventArgs e)
    {
      int rowCount = this.GridSatis.RowCount;
      fUrunGiris fUrunGiris = new fUrunGiris();
      if (rowCount > 0)
      {
        fUrunGiris.tbarkod.Text = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
        fUrunGiris.tbarkodGetir(fUrunGiris.tbarkod.Text);
      }
      this.tBarkod.Focus();
      int num = (int) fUrunGiris.ShowDialog();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void bDuzelt_Click(object sender, EventArgs e) => this.duzenle(Convert.ToDouble(this.db.islemOzet.Max<islemOzet, int?>((Expression<Func<islemOzet, int?>>) (x => x.İslemNo)).Value.ToString()));

    public void duzenle(double did)
    {
      this.GridSatis.Rows.Clear();
      this.db.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => (double?) x.islemno == (double?) did)).Count<Satisid>();
      List<string> list1 = this.db.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => (double?) x.islemno == (double?) did)).Select<Satisid, string>((Expression<Func<Satisid, string>>) (x => x.Barkod)).ToList<string>();
      using (new Barkod1Entities())
      {
        foreach (string str1 in list1)
        {
          string bark = str1;
          List<double?> list2 = this.db.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => x.Barkod == bark && (double?) x.islemno == (double?) did)).Select<Satisid, double?>((Expression<Func<Satisid, double?>>) (x => x.Miktar)).ToList<double?>();
          List<double?> list3 = this.db.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => x.Barkod == bark && (double?) x.islemno == (double?) did)).Select<Satisid, double?>((Expression<Func<Satisid, double?>>) (x => x.Satisfiyat)).ToList<double?>();
          foreach (double? nullable1 in list2)
          {
            foreach (double? nullable2 in list3)
            {
              if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == bark)))
              {
                int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == bark)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
                string str2 = urunid.ToString();
                Urun urun = this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).FirstOrDefault<Urun>();
                double miktar = Convert.ToDouble((object) nullable1);
                string str3 = miktar.ToString();
                double num = Convert.ToDouble((object) nullable2);
                this.UrunGetirListeye(urun, urunid, miktar);
                int count = this.GridSatis.Rows.Count;
                if (count > 0)
                {
                  for (int index = 0; index < count; ++index)
                  {
                    if (str2 == this.GridSatis.Rows[index].Cells["Urunid"].Value.ToString() && str3 == this.GridSatis.Rows[index].Cells["Miktar"].Value.ToString())
                    {
                      this.GridSatis.Rows[index].Cells["Fiyat"].Value = (object) num;
                      this.GridSatis.Rows[index].Cells["Toplam"].Value = (object) (num * miktar);
                      this.GridSatis.ClearSelection();
                      this.GenelToplam();
                    }
                  }
                }
              }
              this.GenelToplam();
            }
          }
        }
      }
    }

    private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      fUrunGiris fUrunGiris = new fUrunGiris();
      fUrunGiris.tbarkod.Text = this.GridSatis.CurrentRow.Cells["Barkod"].Value.ToString();
      fUrunGiris.tbarkodGetir(fUrunGiris.tbarkod.Text);
      this.tBarkod.Focus();
      int num = (int) fUrunGiris.ShowDialog();
    }

    private void b200_Click(object sender, EventArgs e) => this.Close();

    private void b100_Click(object sender, EventArgs e)
    {
      int num = (int) new fFiyatGuncelle().ShowDialog();
    }

    private void b20_Click(object sender, EventArgs e)
    {
      this.tmiktar.Text = (Convert.ToDouble(this.tmiktar.Text) / 10.0).ToString();
      this.tBarkod.Focus();
    }

    private void b50_Click(object sender, EventArgs e)
    {
      if (this.GridSatis.Rows.Count <= 0)
        return;
      this.GridSatis.Rows.Remove(this.GridSatis.CurrentRow);
      this.GridSatis.ClearSelection();
      this.GenelToplam();
      this.tBarkod.Focus();
    }

    private void tBarkod_TextChanged(object sender, EventArgs e)
    {
    }

    private void tGenelToplam_TextChanged(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle13 = new DataGridViewCellStyle();
      this.tableLayoutPanel7 = new TableLayoutPanel();
      this.tNumarator = new TextBox();
      this.tableLayoutPanel8 = new TableLayoutPanel();
      this.bN1 = new Button();
      this.bN2 = new Button();
      this.bN3 = new Button();
      this.bN4 = new Button();
      this.bN5 = new Button();
      this.bN6 = new Button();
      this.bN7 = new Button();
      this.bN8 = new Button();
      this.bN9 = new Button();
      this.bNB = new Button();
      this.bN0 = new Button();
      this.bNV = new Button();
      this.bh25 = new Button();
      this.bh24 = new Button();
      this.bh23 = new Button();
      this.tableLayoutPanel4 = new TableLayoutPanel();
      this.bh22 = new Button();
      this.bh21 = new Button();
      this.bh20 = new Button();
      this.bh19 = new Button();
      this.bh18 = new Button();
      this.bh17 = new Button();
      this.bh16 = new Button();
      this.bh15 = new Button();
      this.bh14 = new Button();
      this.bh13 = new Button();
      this.bh12 = new Button();
      this.bh11 = new Button();
      this.bh10 = new Button();
      this.bh9 = new Button();
      this.bh8 = new Button();
      this.bh7 = new Button();
      this.bh6 = new Button();
      this.bh5 = new Button();
      this.bh4 = new Button();
      this.bh3 = new Button();
      this.bh2 = new Button();
      this.bh1 = new Button();
      this.bDigerUrun = new Button();
      this.bİslemBeklet = new Button();
      this.bBarkod = new Button();
      this.biade = new Button();
      this.bOdenen = new Button();
      this.bFisYazdır = new Button();
      this.bAdet = new Button();
      this.tableLayoutPanel9 = new TableLayoutPanel();
      this.button1 = new Button();
      this.button53 = new Button();
      this.tableLayoutPanel3 = new TableLayoutPanel();
      this.tableLayoutPanel10 = new TableLayoutPanel();
      this.tableLayoutPanel11 = new TableLayoutPanel();
      this.tParaustu = new Label();
      this.label1 = new Label();
      this.tableLayoutPanel12 = new TableLayoutPanel();
      this.label2 = new Label();
      this.tOdenen = new Label();
      this.tableLayoutPanel13 = new TableLayoutPanel();
      this.textBox3 = new TextBox();
      this.bDuzelt = new Button();
      this.tableLayoutPanel2 = new TableLayoutPanel();
      this.bKartnakit = new Button();
      this.bKart = new Button();
      this.bNakit = new Button();
      this.button8 = new Button();
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.GridSatis = new DataGridView();
      this.Barkod = new DataGridViewTextBoxColumn();
      this.Urunad = new DataGridViewTextBoxColumn();
      this.Birim = new DataGridViewTextBoxColumn();
      this.KdvTutar = new DataGridViewTextBoxColumn();
      this.AlisFiyat = new DataGridViewTextBoxColumn();
      this.UrunGrup = new DataGridViewTextBoxColumn();
      this.Miktar = new DataGridViewTextBoxColumn();
      this.Fiyat = new DataGridViewTextBoxColumn();
      this.Toplam = new DataGridViewTextBoxColumn();
      this.Fiyat2 = new DataGridViewTextBoxColumn();
      this.Fiyat3 = new DataGridViewTextBoxColumn();
      this.Fiyat4 = new DataGridViewTextBoxColumn();
      this.Fiyat5 = new DataGridViewTextBoxColumn();
      this.Urunid = new DataGridViewTextBoxColumn();
      this.Sil = new DataGridViewImageColumn();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.düzenleToolStripMenuItem = new ToolStripMenuItem();
      this.panel1 = new Panel();
      this.tableLayoutPanel14 = new TableLayoutPanel();
      this.tableLayoutPanel17 = new TableLayoutPanel();
      this.label5 = new Label();
      this.tBarkod = new TextBox();
      this.label6 = new Label();
      this.tmiktar = new TextBox();
      this.tableLayoutPanel16 = new TableLayoutPanel();
      this.rsatis5 = new RadioButton();
      this.rsatis4 = new RadioButton();
      this.rsatis3 = new RadioButton();
      this.rsatis2 = new RadioButton();
      this.rsatis1 = new RadioButton();
      this.tableLayoutPanel15 = new TableLayoutPanel();
      this.tGenelToplam = new TextBox();
      this.panel2 = new Panel();
      this.chsatisiadeislemi = new CheckBox();
      this.chYazdirma = new CheckBox();
      this.lNakit = new Label();
      this.lKullanici = new Label();
      this.lKart = new Label();
      this.GridBekle = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
      this.dataGridViewImageColumn1 = new DataGridViewImageColumn();
      this.tableLayoutPanel18 = new TableLayoutPanel();
      this.bs10 = new Button();
      this.bsar = new Button();
      this.bs5 = new Button();
      this.bsaz = new Button();
      this.bs4 = new Button();
      this.bs2 = new Button();
      this.bs3 = new Button();
      this.tableLayoutPanel19 = new TableLayoutPanel();
      this.textBox2 = new TextBox();
      this.label3 = new Label();
      this.splitContainer1 = new SplitContainer();
      this.splitContainer2 = new SplitContainer();
      this.tableLayoutPanel5 = new TableLayoutPanel();
      this.tableLayoutPanel6 = new TableLayoutPanel();
      this.bGiris = new Button();
      this.b100 = new Button();
      this.b200 = new Button();
      this.b50 = new Button();
      this.b20 = new Button();
      this.dataGridViewImageColumn2 = new DataGridViewImageColumn();
      this.tableLayoutPanel7.SuspendLayout();
      this.tableLayoutPanel8.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel9.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel10.SuspendLayout();
      this.tableLayoutPanel11.SuspendLayout();
      this.tableLayoutPanel12.SuspendLayout();
      this.tableLayoutPanel13.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((ISupportInitialize) this.GridSatis).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel14.SuspendLayout();
      this.tableLayoutPanel17.SuspendLayout();
      this.tableLayoutPanel16.SuspendLayout();
      this.tableLayoutPanel15.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.GridBekle).BeginInit();
      this.tableLayoutPanel18.SuspendLayout();
      this.tableLayoutPanel19.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      this.SuspendLayout();
      this.tableLayoutPanel7.ColumnCount = 1;
      this.tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel7.Controls.Add((Control) this.tNumarator, 0, 0);
      this.tableLayoutPanel7.Controls.Add((Control) this.tableLayoutPanel8, 0, 1);
      this.tableLayoutPanel7.Dock = DockStyle.Fill;
      this.tableLayoutPanel7.Location = new Point(101, 0);
      this.tableLayoutPanel7.Margin = new Padding(0);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 2;
      this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
      this.tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel7.Size = new Size(304, 418);
      this.tableLayoutPanel7.TabIndex = 1;
      this.tNumarator.Dock = DockStyle.Fill;
      this.tNumarator.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tNumarator.Location = new Point(1, 1);
      this.tNumarator.Margin = new Padding(1);
      this.tNumarator.Name = "tNumarator";
      this.tNumarator.Size = new Size(302, 31);
      this.tNumarator.TabIndex = 1;
      this.tNumarator.Click += new EventHandler(this.tNumarator_Click);
      this.tNumarator.KeyPress += new KeyPressEventHandler(this.tNumarator_KeyPress);
      this.tableLayoutPanel8.BackColor = Color.DimGray;
      this.tableLayoutPanel8.ColumnCount = 3;
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.Controls.Add((Control) this.bN1, 0, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN2, 1, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN3, 2, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN4, 0, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN5, 1, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN6, 2, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN7, 0, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN8, 1, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN9, 2, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bNB, 0, 3);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN0, 1, 3);
      this.tableLayoutPanel8.Controls.Add((Control) this.bNV, 2, 3);
      this.tableLayoutPanel8.Dock = DockStyle.Fill;
      this.tableLayoutPanel8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tableLayoutPanel8.ForeColor = Color.White;
      this.tableLayoutPanel8.Location = new Point(1, 36);
      this.tableLayoutPanel8.Margin = new Padding(1);
      this.tableLayoutPanel8.Name = "tableLayoutPanel8";
      this.tableLayoutPanel8.RowCount = 4;
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.Size = new Size(302, 381);
      this.tableLayoutPanel8.TabIndex = 0;
      this.bN1.BackColor = Color.Gray;
      this.bN1.Dock = DockStyle.Fill;
      this.bN1.FlatAppearance.BorderColor = Color.Black;
      this.bN1.FlatStyle = FlatStyle.Flat;
      this.bN1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN1.ForeColor = Color.White;
      this.bN1.Location = new Point(1, 1);
      this.bN1.Margin = new Padding(1);
      this.bN1.Name = "bN1";
      this.bN1.Size = new Size(98, 93);
      this.bN1.TabIndex = 0;
      this.bN1.Text = "1";
      this.bN1.UseVisualStyleBackColor = false;
      this.bN1.Click += new EventHandler(this.bNx_Click);
      this.bN2.BackColor = Color.Gray;
      this.bN2.Dock = DockStyle.Fill;
      this.bN2.FlatAppearance.BorderColor = Color.Black;
      this.bN2.FlatStyle = FlatStyle.Flat;
      this.bN2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN2.ForeColor = Color.White;
      this.bN2.Location = new Point(101, 1);
      this.bN2.Margin = new Padding(1);
      this.bN2.Name = "bN2";
      this.bN2.Size = new Size(98, 93);
      this.bN2.TabIndex = 1;
      this.bN2.Text = "2";
      this.bN2.UseVisualStyleBackColor = false;
      this.bN2.Click += new EventHandler(this.bNx_Click);
      this.bN3.BackColor = Color.Gray;
      this.bN3.Dock = DockStyle.Fill;
      this.bN3.FlatAppearance.BorderColor = Color.Black;
      this.bN3.FlatStyle = FlatStyle.Flat;
      this.bN3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN3.ForeColor = Color.White;
      this.bN3.Location = new Point(201, 1);
      this.bN3.Margin = new Padding(1);
      this.bN3.Name = "bN3";
      this.bN3.Size = new Size(100, 93);
      this.bN3.TabIndex = 2;
      this.bN3.Text = "3";
      this.bN3.UseVisualStyleBackColor = false;
      this.bN3.Click += new EventHandler(this.bNx_Click);
      this.bN4.BackColor = Color.Gray;
      this.bN4.Dock = DockStyle.Fill;
      this.bN4.FlatAppearance.BorderColor = Color.Black;
      this.bN4.FlatStyle = FlatStyle.Flat;
      this.bN4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN4.ForeColor = Color.White;
      this.bN4.Location = new Point(1, 96);
      this.bN4.Margin = new Padding(1);
      this.bN4.Name = "bN4";
      this.bN4.Size = new Size(98, 93);
      this.bN4.TabIndex = 3;
      this.bN4.Text = "4";
      this.bN4.UseVisualStyleBackColor = false;
      this.bN4.Click += new EventHandler(this.bNx_Click);
      this.bN5.BackColor = Color.Gray;
      this.bN5.Dock = DockStyle.Fill;
      this.bN5.FlatAppearance.BorderColor = Color.Black;
      this.bN5.FlatStyle = FlatStyle.Flat;
      this.bN5.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN5.ForeColor = Color.White;
      this.bN5.Location = new Point(101, 96);
      this.bN5.Margin = new Padding(1);
      this.bN5.Name = "bN5";
      this.bN5.Size = new Size(98, 93);
      this.bN5.TabIndex = 4;
      this.bN5.Text = "5";
      this.bN5.UseVisualStyleBackColor = false;
      this.bN5.Click += new EventHandler(this.bNx_Click);
      this.bN6.BackColor = Color.Gray;
      this.bN6.Dock = DockStyle.Fill;
      this.bN6.FlatAppearance.BorderColor = Color.Black;
      this.bN6.FlatStyle = FlatStyle.Flat;
      this.bN6.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN6.ForeColor = Color.White;
      this.bN6.Location = new Point(201, 96);
      this.bN6.Margin = new Padding(1);
      this.bN6.Name = "bN6";
      this.bN6.Size = new Size(100, 93);
      this.bN6.TabIndex = 5;
      this.bN6.Text = "6";
      this.bN6.UseVisualStyleBackColor = false;
      this.bN6.Click += new EventHandler(this.bNx_Click);
      this.bN7.BackColor = Color.Gray;
      this.bN7.Dock = DockStyle.Fill;
      this.bN7.FlatAppearance.BorderColor = Color.Black;
      this.bN7.FlatStyle = FlatStyle.Flat;
      this.bN7.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN7.ForeColor = Color.White;
      this.bN7.Location = new Point(1, 191);
      this.bN7.Margin = new Padding(1);
      this.bN7.Name = "bN7";
      this.bN7.Size = new Size(98, 93);
      this.bN7.TabIndex = 6;
      this.bN7.Text = "7";
      this.bN7.UseVisualStyleBackColor = false;
      this.bN7.Click += new EventHandler(this.bNx_Click);
      this.bN8.BackColor = Color.Gray;
      this.bN8.Dock = DockStyle.Fill;
      this.bN8.FlatAppearance.BorderColor = Color.Black;
      this.bN8.FlatStyle = FlatStyle.Flat;
      this.bN8.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN8.ForeColor = Color.White;
      this.bN8.Location = new Point(101, 191);
      this.bN8.Margin = new Padding(1);
      this.bN8.Name = "bN8";
      this.bN8.Size = new Size(98, 93);
      this.bN8.TabIndex = 7;
      this.bN8.Text = "8";
      this.bN8.UseVisualStyleBackColor = false;
      this.bN8.Click += new EventHandler(this.bNx_Click);
      this.bN9.BackColor = Color.Gray;
      this.bN9.Dock = DockStyle.Fill;
      this.bN9.FlatAppearance.BorderColor = Color.Black;
      this.bN9.FlatStyle = FlatStyle.Flat;
      this.bN9.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN9.ForeColor = Color.White;
      this.bN9.Location = new Point(201, 191);
      this.bN9.Margin = new Padding(1);
      this.bN9.Name = "bN9";
      this.bN9.Size = new Size(100, 93);
      this.bN9.TabIndex = 8;
      this.bN9.Text = "9";
      this.bN9.UseVisualStyleBackColor = false;
      this.bN9.Click += new EventHandler(this.bNx_Click);
      this.bNB.BackColor = Color.Gray;
      this.bNB.Dock = DockStyle.Fill;
      this.bNB.FlatAppearance.BorderColor = Color.Black;
      this.bNB.FlatStyle = FlatStyle.Flat;
      this.bNB.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNB.ForeColor = Color.White;
      this.bNB.Location = new Point(1, 286);
      this.bNB.Margin = new Padding(1);
      this.bNB.Name = "bNB";
      this.bNB.Size = new Size(98, 94);
      this.bNB.TabIndex = 9;
      this.bNB.Text = "<";
      this.bNB.UseVisualStyleBackColor = false;
      this.bNB.Click += new EventHandler(this.bNx_Click);
      this.bN0.BackColor = Color.Gray;
      this.bN0.Dock = DockStyle.Fill;
      this.bN0.FlatAppearance.BorderColor = Color.Black;
      this.bN0.FlatStyle = FlatStyle.Flat;
      this.bN0.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN0.ForeColor = Color.White;
      this.bN0.Location = new Point(101, 286);
      this.bN0.Margin = new Padding(1);
      this.bN0.Name = "bN0";
      this.bN0.Size = new Size(98, 94);
      this.bN0.TabIndex = 10;
      this.bN0.Text = "0";
      this.bN0.UseVisualStyleBackColor = false;
      this.bN0.Click += new EventHandler(this.bNx_Click);
      this.bNV.BackColor = Color.Gray;
      this.bNV.Dock = DockStyle.Fill;
      this.bNV.FlatAppearance.BorderColor = Color.Black;
      this.bNV.FlatStyle = FlatStyle.Flat;
      this.bNV.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNV.ForeColor = Color.White;
      this.bNV.Location = new Point(201, 286);
      this.bNV.Margin = new Padding(1);
      this.bNV.Name = "bNV";
      this.bNV.Size = new Size(100, 94);
      this.bNV.TabIndex = 11;
      this.bNV.Text = ",";
      this.bNV.UseVisualStyleBackColor = false;
      this.bNV.Click += new EventHandler(this.bNx_Click);
      this.bh25.BackColor = SystemColors.GradientActiveCaption;
      this.bh25.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh25.Dock = DockStyle.Fill;
      this.bh25.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh25.FlatStyle = FlatStyle.Flat;
      this.bh25.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh25.ForeColor = Color.Black;
      this.bh25.Location = new Point(432, 441);
      this.bh25.Margin = new Padding(1);
      this.bh25.Name = "bh25";
      this.bh25.Size = new Size(108, 110);
      this.bh25.TabIndex = 24;
      this.bh25.Text = "button27";
      this.bh25.UseVisualStyleBackColor = false;
      this.bh25.Click += new EventHandler(this.HızlıButonClick);
      this.bh25.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh24.BackColor = SystemColors.GradientActiveCaption;
      this.bh24.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh24.Dock = DockStyle.Fill;
      this.bh24.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh24.FlatStyle = FlatStyle.Flat;
      this.bh24.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh24.ForeColor = Color.Black;
      this.bh24.Location = new Point(329, 441);
      this.bh24.Margin = new Padding(1);
      this.bh24.Name = "bh24";
      this.bh24.Size = new Size(101, 110);
      this.bh24.TabIndex = 23;
      this.bh24.Text = "button26";
      this.bh24.UseVisualStyleBackColor = false;
      this.bh24.Click += new EventHandler(this.HızlıButonClick);
      this.bh24.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh23.BackColor = SystemColors.GradientActiveCaption;
      this.bh23.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh23.Dock = DockStyle.Fill;
      this.bh23.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh23.FlatStyle = FlatStyle.Flat;
      this.bh23.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh23.ForeColor = Color.Black;
      this.bh23.Location = new Point(217, 441);
      this.bh23.Margin = new Padding(1);
      this.bh23.Name = "bh23";
      this.bh23.Size = new Size(110, 110);
      this.bh23.TabIndex = 22;
      this.bh23.Text = "button25";
      this.bh23.UseVisualStyleBackColor = false;
      this.bh23.Click += new EventHandler(this.HızlıButonClick);
      this.bh23.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.tableLayoutPanel4.ColumnCount = 5;
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.82111f));
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.06158f));
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.Controls.Add((Control) this.bh25, 4, 4);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh24, 3, 4);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh23, 2, 4);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh22, 1, 4);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh21, 0, 4);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh20, 4, 3);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh19, 3, 3);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh18, 2, 3);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh17, 1, 3);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh16, 0, 3);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh15, 4, 2);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh14, 3, 2);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh13, 2, 2);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh12, 1, 2);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh11, 0, 2);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh10, 4, 1);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh9, 3, 1);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh8, 2, 1);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh7, 1, 1);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh6, 0, 1);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh5, 4, 0);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh4, 3, 0);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh3, 2, 0);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh2, 1, 0);
      this.tableLayoutPanel4.Controls.Add((Control) this.bh1, 0, 0);
      this.tableLayoutPanel4.Dock = DockStyle.Fill;
      this.tableLayoutPanel4.Location = new Point(0, 0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 5;
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel4.Size = new Size(541, 552);
      this.tableLayoutPanel4.TabIndex = 1;
      this.bh22.BackColor = SystemColors.GradientActiveCaption;
      this.bh22.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh22.Dock = DockStyle.Fill;
      this.bh22.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh22.FlatStyle = FlatStyle.Flat;
      this.bh22.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh22.ForeColor = Color.Black;
      this.bh22.Location = new Point(109, 441);
      this.bh22.Margin = new Padding(1);
      this.bh22.Name = "bh22";
      this.bh22.Size = new Size(106, 110);
      this.bh22.TabIndex = 21;
      this.bh22.Text = "button24";
      this.bh22.UseVisualStyleBackColor = false;
      this.bh22.Click += new EventHandler(this.HızlıButonClick);
      this.bh22.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh21.BackColor = SystemColors.GradientActiveCaption;
      this.bh21.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh21.Dock = DockStyle.Fill;
      this.bh21.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh21.FlatStyle = FlatStyle.Flat;
      this.bh21.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh21.ForeColor = Color.Black;
      this.bh21.Location = new Point(1, 441);
      this.bh21.Margin = new Padding(1);
      this.bh21.Name = "bh21";
      this.bh21.Size = new Size(106, 110);
      this.bh21.TabIndex = 20;
      this.bh21.Text = "button23";
      this.bh21.UseVisualStyleBackColor = false;
      this.bh21.Click += new EventHandler(this.HızlıButonClick);
      this.bh21.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh20.BackColor = SystemColors.GradientActiveCaption;
      this.bh20.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh20.Dock = DockStyle.Fill;
      this.bh20.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh20.FlatStyle = FlatStyle.Flat;
      this.bh20.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh20.ForeColor = Color.Black;
      this.bh20.Location = new Point(432, 331);
      this.bh20.Margin = new Padding(1);
      this.bh20.Name = "bh20";
      this.bh20.Size = new Size(108, 108);
      this.bh20.TabIndex = 19;
      this.bh20.Text = "button22";
      this.bh20.UseVisualStyleBackColor = false;
      this.bh20.Click += new EventHandler(this.HızlıButonClick);
      this.bh20.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh19.BackColor = SystemColors.GradientActiveCaption;
      this.bh19.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh19.Dock = DockStyle.Fill;
      this.bh19.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh19.FlatStyle = FlatStyle.Flat;
      this.bh19.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh19.ForeColor = Color.Black;
      this.bh19.Location = new Point(329, 331);
      this.bh19.Margin = new Padding(1);
      this.bh19.Name = "bh19";
      this.bh19.Size = new Size(101, 108);
      this.bh19.TabIndex = 18;
      this.bh19.Text = "button21";
      this.bh19.UseVisualStyleBackColor = false;
      this.bh19.Click += new EventHandler(this.HızlıButonClick);
      this.bh19.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh18.BackColor = SystemColors.GradientActiveCaption;
      this.bh18.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh18.Dock = DockStyle.Fill;
      this.bh18.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh18.FlatStyle = FlatStyle.Flat;
      this.bh18.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh18.ForeColor = Color.Black;
      this.bh18.Location = new Point(217, 331);
      this.bh18.Margin = new Padding(1);
      this.bh18.Name = "bh18";
      this.bh18.Size = new Size(110, 108);
      this.bh18.TabIndex = 17;
      this.bh18.Text = "button20";
      this.bh18.UseVisualStyleBackColor = false;
      this.bh18.Click += new EventHandler(this.HızlıButonClick);
      this.bh18.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh17.BackColor = SystemColors.GradientActiveCaption;
      this.bh17.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh17.Dock = DockStyle.Fill;
      this.bh17.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh17.FlatStyle = FlatStyle.Flat;
      this.bh17.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh17.ForeColor = Color.Black;
      this.bh17.Location = new Point(109, 331);
      this.bh17.Margin = new Padding(1);
      this.bh17.Name = "bh17";
      this.bh17.Size = new Size(106, 108);
      this.bh17.TabIndex = 16;
      this.bh17.Text = "button19";
      this.bh17.UseVisualStyleBackColor = false;
      this.bh17.Click += new EventHandler(this.HızlıButonClick);
      this.bh17.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh16.BackColor = SystemColors.GradientActiveCaption;
      this.bh16.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh16.Dock = DockStyle.Fill;
      this.bh16.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh16.FlatStyle = FlatStyle.Flat;
      this.bh16.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh16.ForeColor = Color.Black;
      this.bh16.Location = new Point(1, 331);
      this.bh16.Margin = new Padding(1);
      this.bh16.Name = "bh16";
      this.bh16.Size = new Size(106, 108);
      this.bh16.TabIndex = 15;
      this.bh16.Text = "button18";
      this.bh16.UseVisualStyleBackColor = false;
      this.bh16.Click += new EventHandler(this.HızlıButonClick);
      this.bh16.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh15.BackColor = SystemColors.GradientActiveCaption;
      this.bh15.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh15.Dock = DockStyle.Fill;
      this.bh15.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh15.FlatStyle = FlatStyle.Flat;
      this.bh15.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh15.ForeColor = Color.Black;
      this.bh15.Location = new Point(432, 221);
      this.bh15.Margin = new Padding(1);
      this.bh15.Name = "bh15";
      this.bh15.Size = new Size(108, 108);
      this.bh15.TabIndex = 14;
      this.bh15.Text = "button17";
      this.bh15.UseVisualStyleBackColor = false;
      this.bh15.Click += new EventHandler(this.HızlıButonClick);
      this.bh15.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh14.BackColor = SystemColors.GradientActiveCaption;
      this.bh14.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh14.Dock = DockStyle.Fill;
      this.bh14.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh14.FlatStyle = FlatStyle.Flat;
      this.bh14.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh14.ForeColor = Color.Black;
      this.bh14.Location = new Point(329, 221);
      this.bh14.Margin = new Padding(1);
      this.bh14.Name = "bh14";
      this.bh14.Size = new Size(101, 108);
      this.bh14.TabIndex = 13;
      this.bh14.Text = "button16";
      this.bh14.UseVisualStyleBackColor = false;
      this.bh14.Click += new EventHandler(this.HızlıButonClick);
      this.bh14.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh13.BackColor = SystemColors.GradientActiveCaption;
      this.bh13.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh13.Dock = DockStyle.Fill;
      this.bh13.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh13.FlatStyle = FlatStyle.Flat;
      this.bh13.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh13.ForeColor = Color.Black;
      this.bh13.Location = new Point(217, 221);
      this.bh13.Margin = new Padding(1);
      this.bh13.Name = "bh13";
      this.bh13.Size = new Size(110, 108);
      this.bh13.TabIndex = 12;
      this.bh13.Text = "button15";
      this.bh13.UseVisualStyleBackColor = false;
      this.bh13.Click += new EventHandler(this.HızlıButonClick);
      this.bh13.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh12.BackColor = SystemColors.GradientActiveCaption;
      this.bh12.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh12.Dock = DockStyle.Fill;
      this.bh12.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh12.FlatStyle = FlatStyle.Flat;
      this.bh12.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh12.ForeColor = Color.Black;
      this.bh12.Location = new Point(109, 221);
      this.bh12.Margin = new Padding(1);
      this.bh12.Name = "bh12";
      this.bh12.Size = new Size(106, 108);
      this.bh12.TabIndex = 11;
      this.bh12.Text = "button14";
      this.bh12.UseVisualStyleBackColor = false;
      this.bh12.Click += new EventHandler(this.HızlıButonClick);
      this.bh12.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh11.BackColor = SystemColors.GradientActiveCaption;
      this.bh11.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh11.Dock = DockStyle.Fill;
      this.bh11.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh11.FlatStyle = FlatStyle.Flat;
      this.bh11.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh11.ForeColor = Color.Black;
      this.bh11.Location = new Point(1, 221);
      this.bh11.Margin = new Padding(1);
      this.bh11.Name = "bh11";
      this.bh11.Size = new Size(106, 108);
      this.bh11.TabIndex = 10;
      this.bh11.Text = "button13";
      this.bh11.UseVisualStyleBackColor = false;
      this.bh11.Click += new EventHandler(this.HızlıButonClick);
      this.bh11.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh10.BackColor = SystemColors.GradientActiveCaption;
      this.bh10.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh10.Dock = DockStyle.Fill;
      this.bh10.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh10.FlatStyle = FlatStyle.Flat;
      this.bh10.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh10.ForeColor = Color.Black;
      this.bh10.Location = new Point(432, 111);
      this.bh10.Margin = new Padding(1);
      this.bh10.Name = "bh10";
      this.bh10.Size = new Size(108, 108);
      this.bh10.TabIndex = 9;
      this.bh10.Text = "button12";
      this.bh10.UseVisualStyleBackColor = false;
      this.bh10.Click += new EventHandler(this.HızlıButonClick);
      this.bh10.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh9.BackColor = SystemColors.GradientActiveCaption;
      this.bh9.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh9.Dock = DockStyle.Fill;
      this.bh9.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh9.FlatStyle = FlatStyle.Flat;
      this.bh9.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh9.ForeColor = Color.Black;
      this.bh9.Location = new Point(329, 111);
      this.bh9.Margin = new Padding(1);
      this.bh9.Name = "bh9";
      this.bh9.Size = new Size(101, 108);
      this.bh9.TabIndex = 8;
      this.bh9.Text = "button11";
      this.bh9.UseVisualStyleBackColor = false;
      this.bh9.Click += new EventHandler(this.HızlıButonClick);
      this.bh9.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh8.BackColor = SystemColors.GradientActiveCaption;
      this.bh8.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh8.Dock = DockStyle.Fill;
      this.bh8.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh8.FlatStyle = FlatStyle.Flat;
      this.bh8.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh8.ForeColor = Color.Black;
      this.bh8.Location = new Point(217, 111);
      this.bh8.Margin = new Padding(1);
      this.bh8.Name = "bh8";
      this.bh8.Size = new Size(110, 108);
      this.bh8.TabIndex = 7;
      this.bh8.Text = "button10";
      this.bh8.UseVisualStyleBackColor = false;
      this.bh8.Click += new EventHandler(this.HızlıButonClick);
      this.bh8.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh7.BackColor = SystemColors.GradientActiveCaption;
      this.bh7.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh7.Dock = DockStyle.Fill;
      this.bh7.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh7.FlatStyle = FlatStyle.Flat;
      this.bh7.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh7.ForeColor = Color.Black;
      this.bh7.Location = new Point(109, 111);
      this.bh7.Margin = new Padding(1);
      this.bh7.Name = "bh7";
      this.bh7.Size = new Size(106, 108);
      this.bh7.TabIndex = 6;
      this.bh7.Text = "button9";
      this.bh7.UseVisualStyleBackColor = false;
      this.bh7.Click += new EventHandler(this.HızlıButonClick);
      this.bh7.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh6.BackColor = SystemColors.GradientActiveCaption;
      this.bh6.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh6.Dock = DockStyle.Fill;
      this.bh6.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh6.FlatStyle = FlatStyle.Flat;
      this.bh6.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh6.ForeColor = Color.Black;
      this.bh6.Location = new Point(1, 111);
      this.bh6.Margin = new Padding(1);
      this.bh6.Name = "bh6";
      this.bh6.Size = new Size(106, 108);
      this.bh6.TabIndex = 5;
      this.bh6.Text = "button8";
      this.bh6.UseVisualStyleBackColor = false;
      this.bh6.Click += new EventHandler(this.HızlıButonClick);
      this.bh6.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh5.BackColor = SystemColors.GradientActiveCaption;
      this.bh5.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh5.Dock = DockStyle.Fill;
      this.bh5.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh5.FlatStyle = FlatStyle.Flat;
      this.bh5.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh5.ForeColor = Color.Black;
      this.bh5.Location = new Point(432, 1);
      this.bh5.Margin = new Padding(1);
      this.bh5.Name = "bh5";
      this.bh5.Size = new Size(108, 108);
      this.bh5.TabIndex = 4;
      this.bh5.Text = "button7";
      this.bh5.UseVisualStyleBackColor = false;
      this.bh5.Click += new EventHandler(this.HızlıButonClick);
      this.bh5.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh4.BackColor = SystemColors.GradientActiveCaption;
      this.bh4.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh4.Dock = DockStyle.Fill;
      this.bh4.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh4.FlatStyle = FlatStyle.Flat;
      this.bh4.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh4.ForeColor = Color.Black;
      this.bh4.Location = new Point(329, 1);
      this.bh4.Margin = new Padding(1);
      this.bh4.Name = "bh4";
      this.bh4.Size = new Size(101, 108);
      this.bh4.TabIndex = 3;
      this.bh4.Text = "button6";
      this.bh4.UseVisualStyleBackColor = false;
      this.bh4.Click += new EventHandler(this.HızlıButonClick);
      this.bh4.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh3.BackColor = SystemColors.GradientActiveCaption;
      this.bh3.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh3.Dock = DockStyle.Fill;
      this.bh3.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh3.FlatStyle = FlatStyle.Flat;
      this.bh3.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh3.ForeColor = Color.Black;
      this.bh3.Location = new Point(217, 1);
      this.bh3.Margin = new Padding(1);
      this.bh3.Name = "bh3";
      this.bh3.Size = new Size(110, 108);
      this.bh3.TabIndex = 2;
      this.bh3.Text = "button5";
      this.bh3.UseVisualStyleBackColor = false;
      this.bh3.Click += new EventHandler(this.HızlıButonClick);
      this.bh3.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh2.BackColor = SystemColors.GradientActiveCaption;
      this.bh2.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh2.Dock = DockStyle.Fill;
      this.bh2.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh2.FlatStyle = FlatStyle.Flat;
      this.bh2.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh2.ForeColor = Color.Black;
      this.bh2.Location = new Point(109, 1);
      this.bh2.Margin = new Padding(1);
      this.bh2.Name = "bh2";
      this.bh2.Size = new Size(106, 108);
      this.bh2.TabIndex = 1;
      this.bh2.Text = "button4";
      this.bh2.UseVisualStyleBackColor = false;
      this.bh2.Click += new EventHandler(this.HızlıButonClick);
      this.bh2.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bh1.BackColor = SystemColors.GradientActiveCaption;
      this.bh1.BackgroundImageLayout = ImageLayout.Stretch;
      this.bh1.Dock = DockStyle.Fill;
      this.bh1.FlatAppearance.BorderColor = Color.FromArgb(0, 174, 219);
      this.bh1.FlatStyle = FlatStyle.Flat;
      this.bh1.Font = new Font("Microsoft Sans Serif", 12.77391f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bh1.ForeColor = Color.Black;
      this.bh1.ImageAlign = ContentAlignment.TopCenter;
      this.bh1.Location = new Point(1, 1);
      this.bh1.Margin = new Padding(1);
      this.bh1.Name = "bh1";
      this.bh1.Size = new Size(106, 108);
      this.bh1.TabIndex = 0;
      this.bh1.Text = "bHızlı";
      this.bh1.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.bh1.UseVisualStyleBackColor = false;
      this.bh1.Click += new EventHandler(this.HızlıButonClick);
      this.bh1.MouseDown += new MouseEventHandler(this.bh_MouseDown);
      this.bDigerUrun.BackColor = Color.Goldenrod;
      this.bDigerUrun.Dock = DockStyle.Fill;
      this.bDigerUrun.FlatAppearance.BorderColor = Color.Goldenrod;
      this.bDigerUrun.FlatStyle = FlatStyle.Flat;
      this.bDigerUrun.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bDigerUrun.ForeColor = Color.White;
      this.bDigerUrun.Location = new Point(1, 313);
      this.bDigerUrun.Margin = new Padding(1);
      this.bDigerUrun.Name = "bDigerUrun";
      this.bDigerUrun.Size = new Size(66, 104);
      this.bDigerUrun.TabIndex = 0;
      this.bDigerUrun.Text = "Diğer Ürün";
      this.bDigerUrun.UseVisualStyleBackColor = false;
      this.bDigerUrun.Click += new EventHandler(this.bDigerUrun_Click);
      this.bİslemBeklet.BackColor = Color.Gray;
      this.bİslemBeklet.Dock = DockStyle.Fill;
      this.bİslemBeklet.FlatAppearance.BorderColor = Color.Black;
      this.bİslemBeklet.FlatStyle = FlatStyle.Flat;
      this.bİslemBeklet.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bİslemBeklet.ForeColor = Color.White;
      this.bİslemBeklet.Location = new Point(69, 105);
      this.bİslemBeklet.Margin = new Padding(1);
      this.bİslemBeklet.Name = "bİslemBeklet";
      this.bİslemBeklet.Size = new Size(66, 102);
      this.bİslemBeklet.TabIndex = 1;
      this.bİslemBeklet.Text = "İşlem Beklet";
      this.bİslemBeklet.UseVisualStyleBackColor = false;
      this.bİslemBeklet.Click += new EventHandler(this.bİslemBeklet_Click);
      this.bBarkod.BackColor = Color.Gray;
      this.bBarkod.FlatAppearance.BorderColor = Color.Black;
      this.bBarkod.FlatStyle = FlatStyle.Flat;
      this.bBarkod.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bBarkod.ForeColor = Color.White;
      this.bBarkod.Location = new Point(177, -6);
      this.bBarkod.Margin = new Padding(1);
      this.bBarkod.Name = "bBarkod";
      this.bBarkod.Size = new Size(66, 102);
      this.bBarkod.TabIndex = 2;
      this.bBarkod.Text = "Barkod";
      this.bBarkod.UseVisualStyleBackColor = false;
      this.bBarkod.Visible = false;
      this.bBarkod.Click += new EventHandler(this.bBarkod_Click);
      this.biade.BackColor = Color.Gray;
      this.biade.Dock = DockStyle.Fill;
      this.biade.FlatAppearance.BorderColor = Color.Black;
      this.biade.FlatStyle = FlatStyle.Flat;
      this.biade.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.biade.ForeColor = Color.White;
      this.biade.Location = new Point(1, 105);
      this.biade.Margin = new Padding(1);
      this.biade.Name = "biade";
      this.biade.Size = new Size(66, 102);
      this.biade.TabIndex = 3;
      this.biade.Text = "İade";
      this.biade.UseVisualStyleBackColor = false;
      this.biade.Click += new EventHandler(this.biade_Click);
      this.bOdenen.BackColor = Color.Gray;
      this.bOdenen.Dock = DockStyle.Fill;
      this.bOdenen.FlatAppearance.BorderColor = Color.Black;
      this.bOdenen.FlatStyle = FlatStyle.Flat;
      this.bOdenen.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bOdenen.ForeColor = Color.White;
      this.bOdenen.Location = new Point(1, 209);
      this.bOdenen.Margin = new Padding(1);
      this.bOdenen.Name = "bOdenen";
      this.bOdenen.Size = new Size(66, 102);
      this.bOdenen.TabIndex = 4;
      this.bOdenen.Text = "Ödenen";
      this.bOdenen.UseVisualStyleBackColor = false;
      this.bOdenen.Click += new EventHandler(this.bOdenen_Click);
      this.bFisYazdır.BackColor = Color.Gray;
      this.bFisYazdır.Dock = DockStyle.Fill;
      this.bFisYazdır.FlatAppearance.BorderColor = Color.Black;
      this.bFisYazdır.FlatStyle = FlatStyle.Flat;
      this.bFisYazdır.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bFisYazdır.ForeColor = Color.White;
      this.bFisYazdır.Location = new Point(69, 209);
      this.bFisYazdır.Margin = new Padding(1);
      this.bFisYazdır.Name = "bFisYazdır";
      this.bFisYazdır.Size = new Size(66, 102);
      this.bFisYazdır.TabIndex = 5;
      this.bFisYazdır.Text = "Fiş Yazdır";
      this.bFisYazdır.UseVisualStyleBackColor = false;
      this.bFisYazdır.Click += new EventHandler(this.button51_Click);
      this.bAdet.BackColor = Color.Goldenrod;
      this.bAdet.Dock = DockStyle.Fill;
      this.bAdet.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption;
      this.bAdet.FlatStyle = FlatStyle.Flat;
      this.bAdet.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bAdet.ForeColor = Color.White;
      this.bAdet.Location = new Point(69, 1);
      this.bAdet.Margin = new Padding(1);
      this.bAdet.Name = "bAdet";
      this.bAdet.Size = new Size(66, 102);
      this.bAdet.TabIndex = 6;
      this.bAdet.Text = "Adet";
      this.bAdet.UseVisualStyleBackColor = false;
      this.bAdet.Click += new EventHandler(this.bAdet_Click);
      this.tableLayoutPanel9.ColumnCount = 2;
      this.tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel9.Controls.Add((Control) this.button1, 0, 0);
      this.tableLayoutPanel9.Controls.Add((Control) this.bOdenen, 0, 2);
      this.tableLayoutPanel9.Controls.Add((Control) this.bFisYazdır, 1, 2);
      this.tableLayoutPanel9.Controls.Add((Control) this.button53, 1, 3);
      this.tableLayoutPanel9.Controls.Add((Control) this.bDigerUrun, 0, 3);
      this.tableLayoutPanel9.Controls.Add((Control) this.bAdet, 1, 0);
      this.tableLayoutPanel9.Controls.Add((Control) this.biade, 0, 1);
      this.tableLayoutPanel9.Controls.Add((Control) this.bİslemBeklet, 1, 1);
      this.tableLayoutPanel9.Dock = DockStyle.Fill;
      this.tableLayoutPanel9.Location = new Point(405, 0);
      this.tableLayoutPanel9.Margin = new Padding(0);
      this.tableLayoutPanel9.Name = "tableLayoutPanel9";
      this.tableLayoutPanel9.RowCount = 4;
      this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel9.Size = new Size(136, 418);
      this.tableLayoutPanel9.TabIndex = 2;
      this.button1.BackColor = Color.Goldenrod;
      this.button1.Dock = DockStyle.Fill;
      this.button1.FlatAppearance.BorderColor = SystemColors.GradientActiveCaption;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button1.ForeColor = Color.White;
      this.button1.Location = new Point(1, 1);
      this.button1.Margin = new Padding(1);
      this.button1.Name = "button1";
      this.button1.Size = new Size(66, 102);
      this.button1.TabIndex = 8;
      this.button1.Text = "Adet";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.bAdet_Click);
      this.button53.BackColor = Color.Gray;
      this.button53.Dock = DockStyle.Fill;
      this.button53.FlatAppearance.BorderColor = Color.Black;
      this.button53.FlatStyle = FlatStyle.Flat;
      this.button53.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.button53.ForeColor = Color.White;
      this.button53.Image = (Image) Resources.clear4848;
      this.button53.Location = new Point(69, 313);
      this.button53.Margin = new Padding(1);
      this.button53.Name = "button53";
      this.button53.Size = new Size(66, 104);
      this.button53.TabIndex = 7;
      this.button53.Text = "Temizle";
      this.button53.TextImageRelation = TextImageRelation.ImageAboveText;
      this.button53.UseVisualStyleBackColor = false;
      this.button53.Click += new EventHandler(this.button53_Click);
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel3.Controls.Add((Control) this.tableLayoutPanel10, 0, 1);
      this.tableLayoutPanel3.Controls.Add((Control) this.tableLayoutPanel13, 0, 0);
      this.tableLayoutPanel3.Dock = DockStyle.Fill;
      this.tableLayoutPanel3.Location = new Point(411, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
      this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));
      this.tableLayoutPanel3.Size = new Size(266, 163);
      this.tableLayoutPanel3.TabIndex = 3;
      this.tableLayoutPanel10.BackColor = Color.Honeydew;
      this.tableLayoutPanel10.ColumnCount = 2;
      this.tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel10.Controls.Add((Control) this.tableLayoutPanel11, 1, 0);
      this.tableLayoutPanel10.Controls.Add((Control) this.tableLayoutPanel12, 0, 0);
      this.tableLayoutPanel10.Dock = DockStyle.Fill;
      this.tableLayoutPanel10.Location = new Point(0, 97);
      this.tableLayoutPanel10.Margin = new Padding(0);
      this.tableLayoutPanel10.Name = "tableLayoutPanel10";
      this.tableLayoutPanel10.RowCount = 1;
      this.tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      this.tableLayoutPanel10.Size = new Size(266, 66);
      this.tableLayoutPanel10.TabIndex = 3;
      this.tableLayoutPanel11.BackColor = Color.DimGray;
      this.tableLayoutPanel11.ColumnCount = 1;
      this.tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel11.Controls.Add((Control) this.tParaustu, 0, 1);
      this.tableLayoutPanel11.Controls.Add((Control) this.label1, 0, 0);
      this.tableLayoutPanel11.Dock = DockStyle.Fill;
      this.tableLayoutPanel11.Location = new Point(133, 0);
      this.tableLayoutPanel11.Margin = new Padding(0);
      this.tableLayoutPanel11.Name = "tableLayoutPanel11";
      this.tableLayoutPanel11.RowCount = 2;
      this.tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));
      this.tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
      this.tableLayoutPanel11.Size = new Size(133, 66);
      this.tableLayoutPanel11.TabIndex = 0;
      this.tParaustu.AutoSize = true;
      this.tParaustu.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tParaustu.ForeColor = Color.White;
      this.tParaustu.Location = new Point(3, 26);
      this.tParaustu.Name = "tParaustu";
      this.tParaustu.Size = new Size(26, 29);
      this.tParaustu.TabIndex = 2;
      this.tParaustu.Text = "0";
      this.tParaustu.TextAlign = ContentAlignment.MiddleCenter;
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(84, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Para Üstü:";
      this.tableLayoutPanel12.BackColor = Color.Tan;
      this.tableLayoutPanel12.ColumnCount = 1;
      this.tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel12.Controls.Add((Control) this.label2, 0, 0);
      this.tableLayoutPanel12.Controls.Add((Control) this.tOdenen, 0, 1);
      this.tableLayoutPanel12.Dock = DockStyle.Fill;
      this.tableLayoutPanel12.Location = new Point(0, 0);
      this.tableLayoutPanel12.Margin = new Padding(0);
      this.tableLayoutPanel12.Name = "tableLayoutPanel12";
      this.tableLayoutPanel12.RowCount = 2;
      this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 40f));
      this.tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 60f));
      this.tableLayoutPanel12.Size = new Size(133, 66);
      this.tableLayoutPanel12.TabIndex = 1;
      this.label2.AutoSize = true;
      this.label2.BackColor = Color.BurlyWood;
      this.label2.Dock = DockStyle.Fill;
      this.label2.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(0, 0);
      this.label2.Margin = new Padding(0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(133, 26);
      this.label2.TabIndex = 1;
      this.label2.Text = "Ödenen Tutar:\r\n";
      this.tOdenen.AutoSize = true;
      this.tOdenen.BackColor = Color.BurlyWood;
      this.tOdenen.Dock = DockStyle.Fill;
      this.tOdenen.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tOdenen.ForeColor = Color.White;
      this.tOdenen.Location = new Point(3, 26);
      this.tOdenen.Name = "tOdenen";
      this.tOdenen.Size = new Size((int) sbyte.MaxValue, 40);
      this.tOdenen.TabIndex = 2;
      this.tOdenen.Text = "0";
      this.tOdenen.TextAlign = ContentAlignment.MiddleCenter;
      this.tableLayoutPanel13.ColumnCount = 1;
      this.tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel13.Controls.Add((Control) this.textBox3, 0, 0);
      this.tableLayoutPanel13.Controls.Add((Control) this.bDuzelt, 0, 1);
      this.tableLayoutPanel13.Dock = DockStyle.Fill;
      this.tableLayoutPanel13.Location = new Point(0, 0);
      this.tableLayoutPanel13.Margin = new Padding(0);
      this.tableLayoutPanel13.Name = "tableLayoutPanel13";
      this.tableLayoutPanel13.RowCount = 2;
      this.tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
      this.tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
      this.tableLayoutPanel13.Size = new Size(266, 97);
      this.tableLayoutPanel13.TabIndex = 4;
      this.textBox3.BackColor = Color.Olive;
      this.textBox3.BorderStyle = BorderStyle.None;
      this.textBox3.Dock = DockStyle.Fill;
      this.textBox3.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textBox3.ForeColor = Color.White;
      this.textBox3.Location = new Point(0, 0);
      this.textBox3.Margin = new Padding(0);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(266, 29);
      this.textBox3.TabIndex = 4;
      this.textBox3.Text = "Önceki İşlem";
      this.textBox3.TextAlign = HorizontalAlignment.Center;
      this.bDuzelt.BackColor = Color.Olive;
      this.bDuzelt.Dock = DockStyle.Fill;
      this.bDuzelt.FlatAppearance.BorderColor = Color.Olive;
      this.bDuzelt.FlatStyle = FlatStyle.Flat;
      this.bDuzelt.Font = new Font("Microsoft Sans Serif", 30f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bDuzelt.ForeColor = Color.White;
      this.bDuzelt.Location = new Point(0, 29);
      this.bDuzelt.Margin = new Padding(0);
      this.bDuzelt.Name = "bDuzelt";
      this.bDuzelt.Size = new Size(266, 68);
      this.bDuzelt.TabIndex = 13;
      this.bDuzelt.Text = "00";
      this.bDuzelt.UseVisualStyleBackColor = false;
      this.bDuzelt.Click += new EventHandler(this.bDuzelt_Click);
      this.tableLayoutPanel2.ColumnCount = 4;
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
      this.tableLayoutPanel2.Controls.Add((Control) this.bKartnakit, 0, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.bKart, 0, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.bNakit, 0, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.tableLayoutPanel3, 3, 0);
      this.tableLayoutPanel2.Dock = DockStyle.Fill;
      this.tableLayoutPanel2.Location = new Point(0, 805);
      this.tableLayoutPanel2.Margin = new Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel2.Size = new Size(680, 169);
      this.tableLayoutPanel2.TabIndex = 2;
      this.bKartnakit.BackColor = Color.DarkKhaki;
      this.bKartnakit.Dock = DockStyle.Fill;
      this.bKartnakit.FlatAppearance.BorderColor = Color.Olive;
      this.bKartnakit.FlatStyle = FlatStyle.Flat;
      this.bKartnakit.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bKartnakit.ForeColor = SystemColors.ButtonHighlight;
      this.bKartnakit.Image = (Image) componentResourceManager.GetObject("bKartnakit.Image");
      this.bKartnakit.Location = new Point(273, 1);
      this.bKartnakit.Margin = new Padding(1);
      this.bKartnakit.Name = "bKartnakit";
      this.bKartnakit.Size = new Size(134, 167);
      this.bKartnakit.TabIndex = 2;
      this.bKartnakit.Text = "NAKİT KART\r\n(F3)";
      this.bKartnakit.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bKartnakit.UseVisualStyleBackColor = false;
      this.bKartnakit.Click += new EventHandler(this.bKartnakit_Click);
      this.bKart.BackColor = Color.SeaGreen;
      this.bKart.Dock = DockStyle.Fill;
      this.bKart.FlatAppearance.BorderColor = Color.SeaGreen;
      this.bKart.FlatStyle = FlatStyle.Flat;
      this.bKart.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bKart.ForeColor = SystemColors.ButtonHighlight;
      this.bKart.Image = (Image) componentResourceManager.GetObject("bKart.Image");
      this.bKart.Location = new Point(137, 1);
      this.bKart.Margin = new Padding(1);
      this.bKart.Name = "bKart";
      this.bKart.Size = new Size(134, 167);
      this.bKart.TabIndex = 1;
      this.bKart.Text = "KREDİ KARTI\r\n(F2)";
      this.bKart.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bKart.UseVisualStyleBackColor = false;
      this.bKart.Click += new EventHandler(this.bKart_Click);
      this.bNakit.BackColor = Color.DarkSlateGray;
      this.bNakit.Dock = DockStyle.Fill;
      this.bNakit.FlatAppearance.BorderColor = Color.DarkSlateGray;
      this.bNakit.FlatStyle = FlatStyle.Flat;
      this.bNakit.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNakit.ForeColor = SystemColors.ButtonHighlight;
      this.bNakit.Image = (Image) componentResourceManager.GetObject("bNakit.Image");
      this.bNakit.Location = new Point(1, 1);
      this.bNakit.Margin = new Padding(1);
      this.bNakit.Name = "bNakit";
      this.bNakit.Size = new Size(134, 167);
      this.bNakit.TabIndex = 0;
      this.bNakit.Text = "NAKİT\r\n(F1)";
      this.bNakit.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bNakit.UseVisualStyleBackColor = false;
      this.bNakit.Click += new EventHandler(this.bNakit_Click);
      this.button8.BackColor = Color.Firebrick;
      this.button8.Dock = DockStyle.Fill;
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.Font = new Font("Microsoft Sans Serif", 21.91304f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button8.ForeColor = Color.Transparent;
      this.button8.Location = new Point(1, 1);
      this.button8.Margin = new Padding(1);
      this.button8.Name = "button8";
      this.button8.Size = new Size(99, 67);
      this.button8.TabIndex = 5;
      this.button8.Text = "(-)";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel1.Controls.Add((Control) this.GridSatis, 0, -1);
      this.tableLayoutPanel1.Controls.Add((Control) this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.panel1, 0, 0);
      this.tableLayoutPanel1.Dock = DockStyle.Fill;
      this.tableLayoutPanel1.Location = new Point(0, 0);
      this.tableLayoutPanel1.Margin = new Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.93326f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57.84517f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.22157f));
      this.tableLayoutPanel1.Size = new Size(680, 974);
      this.tableLayoutPanel1.TabIndex = 0;
      this.GridSatis.AllowUserToAddRows = false;
      this.GridSatis.AllowUserToDeleteRows = false;
      this.GridSatis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridSatis.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridSatis.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.DimGray;
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridSatis.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridSatis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridSatis.Columns.AddRange((DataGridViewColumn) this.Barkod, (DataGridViewColumn) this.Urunad, (DataGridViewColumn) this.Birim, (DataGridViewColumn) this.KdvTutar, (DataGridViewColumn) this.AlisFiyat, (DataGridViewColumn) this.UrunGrup, (DataGridViewColumn) this.Miktar, (DataGridViewColumn) this.Fiyat, (DataGridViewColumn) this.Toplam, (DataGridViewColumn) this.Fiyat2, (DataGridViewColumn) this.Fiyat3, (DataGridViewColumn) this.Fiyat4, (DataGridViewColumn) this.Fiyat5, (DataGridViewColumn) this.Urunid, (DataGridViewColumn) this.Sil);
      this.GridSatis.ContextMenuStrip = this.contextMenuStrip1;
      this.GridSatis.Dock = DockStyle.Fill;
      this.GridSatis.EnableHeadersVisualStyles = false;
      this.GridSatis.Location = new Point(1, 243);
      this.GridSatis.Margin = new Padding(1);
      this.GridSatis.MultiSelect = false;
      this.GridSatis.Name = "GridSatis";
      this.GridSatis.ReadOnly = true;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
      gridViewCellStyle2.BackColor = SystemColors.Control;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = SystemColors.WindowText;
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.GridSatis.RowHeadersDefaultCellStyle = gridViewCellStyle2;
      this.GridSatis.RowHeadersVisible = false;
      this.GridSatis.RowHeadersWidth = 49;
      gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 13.77391f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.GridSatis.RowsDefaultCellStyle = gridViewCellStyle3;
      this.GridSatis.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridSatis.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridSatis.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridSatis.RowTemplate.Height = 33;
      this.GridSatis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridSatis.Size = new Size(678, 561);
      this.GridSatis.TabIndex = 1;
      this.GridSatis.CellContentClick += new DataGridViewCellEventHandler(this.GridSatis_CellContentClick);
      this.Barkod.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      this.Barkod.Frozen = true;
      this.Barkod.HeaderText = "Barkod";
      this.Barkod.MinimumWidth = 6;
      this.Barkod.Name = "Barkod";
      this.Barkod.ReadOnly = true;
      this.Barkod.Width = 85;
      this.Urunad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      this.Urunad.Frozen = true;
      this.Urunad.HeaderText = "Ürün Adı";
      this.Urunad.MinimumWidth = 6;
      this.Urunad.Name = "Urunad";
      this.Urunad.ReadOnly = true;
      this.Urunad.Width = 170;
      this.Birim.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Birim.DefaultCellStyle = gridViewCellStyle4;
      this.Birim.Frozen = true;
      this.Birim.HeaderText = "Birim";
      this.Birim.MinimumWidth = 6;
      this.Birim.Name = "Birim";
      this.Birim.ReadOnly = true;
      this.Birim.Width = 75;
      this.KdvTutar.HeaderText = "KdvTutar";
      this.KdvTutar.MinimumWidth = 6;
      this.KdvTutar.Name = "KdvTutar";
      this.KdvTutar.ReadOnly = true;
      this.KdvTutar.Visible = false;
      this.AlisFiyat.HeaderText = "AlıisFiyat";
      this.AlisFiyat.MinimumWidth = 6;
      this.AlisFiyat.Name = "AlisFiyat";
      this.AlisFiyat.ReadOnly = true;
      this.AlisFiyat.Visible = false;
      this.UrunGrup.HeaderText = "UrunGrup";
      this.UrunGrup.MinimumWidth = 6;
      this.UrunGrup.Name = "UrunGrup";
      this.UrunGrup.ReadOnly = true;
      this.UrunGrup.Visible = false;
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.Miktar.DefaultCellStyle = gridViewCellStyle5;
      this.Miktar.HeaderText = "Miktar";
      this.Miktar.MinimumWidth = 6;
      this.Miktar.Name = "Miktar";
      this.Miktar.ReadOnly = true;
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle6.Format = "C2";
      gridViewCellStyle6.NullValue = (object) null;
      this.Fiyat.DefaultCellStyle = gridViewCellStyle6;
      this.Fiyat.HeaderText = "Fiyat";
      this.Fiyat.MinimumWidth = 6;
      this.Fiyat.Name = "Fiyat";
      this.Fiyat.ReadOnly = true;
      gridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle7.Format = "C2";
      gridViewCellStyle7.NullValue = (object) null;
      this.Toplam.DefaultCellStyle = gridViewCellStyle7;
      this.Toplam.HeaderText = "Toplam";
      this.Toplam.MinimumWidth = 6;
      this.Toplam.Name = "Toplam";
      this.Toplam.ReadOnly = true;
      this.Fiyat2.HeaderText = "Fiyat2";
      this.Fiyat2.MinimumWidth = 6;
      this.Fiyat2.Name = "Fiyat2";
      this.Fiyat2.ReadOnly = true;
      this.Fiyat2.Visible = false;
      this.Fiyat3.HeaderText = "Fiyat3";
      this.Fiyat3.MinimumWidth = 6;
      this.Fiyat3.Name = "Fiyat3";
      this.Fiyat3.ReadOnly = true;
      this.Fiyat3.Visible = false;
      this.Fiyat4.HeaderText = "Fiyat4";
      this.Fiyat4.MinimumWidth = 6;
      this.Fiyat4.Name = "Fiyat4";
      this.Fiyat4.ReadOnly = true;
      this.Fiyat4.Visible = false;
      this.Fiyat5.HeaderText = "Fiyat5";
      this.Fiyat5.MinimumWidth = 6;
      this.Fiyat5.Name = "Fiyat5";
      this.Fiyat5.ReadOnly = true;
      this.Fiyat5.Visible = false;
      this.Urunid.HeaderText = "Ürün ID";
      this.Urunid.MinimumWidth = 6;
      this.Urunid.Name = "Urunid";
      this.Urunid.ReadOnly = true;
      this.Urunid.Visible = false;
      this.Sil.HeaderText = "Sİl";
      this.Sil.Image = (Image) Resources.remove1;
      this.Sil.MinimumWidth = 6;
      this.Sil.Name = "Sil";
      this.Sil.ReadOnly = true;
      this.contextMenuStrip1.Font = new Font("Segoe UI", 12f);
      this.contextMenuStrip1.ImageScalingSize = new Size(19, 19);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[1]
      {
        (ToolStripItem) this.düzenleToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(155, 36);
      this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
      this.düzenleToolStripMenuItem.Size = new Size(154, 32);
      this.düzenleToolStripMenuItem.Text = "Düzenle";
      this.düzenleToolStripMenuItem.Click += new EventHandler(this.düzenleToolStripMenuItem_Click);
      this.panel1.Controls.Add((Control) this.tableLayoutPanel14);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Margin = new Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(680, 242);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.tableLayoutPanel14.ColumnCount = 1;
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel14.Controls.Add((Control) this.tableLayoutPanel17, 0, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.tableLayoutPanel16, 0, 1);
      this.tableLayoutPanel14.Controls.Add((Control) this.tableLayoutPanel15, 0, 2);
      this.tableLayoutPanel14.Controls.Add((Control) this.tableLayoutPanel18, 0, 3);
      this.tableLayoutPanel14.Dock = DockStyle.Fill;
      this.tableLayoutPanel14.Location = new Point(0, 0);
      this.tableLayoutPanel14.Margin = new Padding(0);
      this.tableLayoutPanel14.Name = "tableLayoutPanel14";
      this.tableLayoutPanel14.RowCount = 4;
      this.tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 19.50536f));
      this.tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 11.47568f));
      this.tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 31.50865f));
      this.tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5103f));
      this.tableLayoutPanel14.Size = new Size(680, 242);
      this.tableLayoutPanel14.TabIndex = 0;
      this.tableLayoutPanel17.ColumnCount = 4;
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.36844f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.31886f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.21257f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.10013f));
      this.tableLayoutPanel17.Controls.Add((Control) this.label5, 0, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.tBarkod, 3, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.label6, 2, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.tmiktar, 1, 0);
      this.tableLayoutPanel17.Dock = DockStyle.Fill;
      this.tableLayoutPanel17.Location = new Point(0, 0);
      this.tableLayoutPanel17.Margin = new Padding(0);
      this.tableLayoutPanel17.Name = "tableLayoutPanel17";
      this.tableLayoutPanel17.RowCount = 1;
      this.tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel17.Size = new Size(680, 47);
      this.tableLayoutPanel17.TabIndex = 25;
      this.label5.AutoSize = true;
      this.label5.Dock = DockStyle.Fill;
      this.label5.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label5.ForeColor = Color.DarkOrange;
      this.label5.Location = new Point(3, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(64, 47);
      this.label5.TabIndex = 21;
      this.label5.Text = "Miktar:";
      this.tBarkod.BackColor = SystemColors.ScrollBar;
      this.tBarkod.BorderStyle = BorderStyle.FixedSingle;
      this.tBarkod.Dock = DockStyle.Fill;
      this.tBarkod.Font = new Font("Microsoft Sans Serif", 19f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tBarkod.Location = new Point(277, 0);
      this.tBarkod.Margin = new Padding(0);
      this.tBarkod.Name = "tBarkod";
      this.tBarkod.Size = new Size(403, 42);
      this.tBarkod.TabIndex = 0;
      this.tBarkod.TextChanged += new EventHandler(this.tBarkod_TextChanged);
      this.tBarkod.KeyDown += new KeyEventHandler(this.tBarkod_KeyDown);
      this.label6.AutoSize = true;
      this.label6.Dock = DockStyle.Fill;
      this.label6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.ForeColor = Color.DarkOrange;
      this.label6.Location = new Point(197, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(77, 47);
      this.label6.TabIndex = 20;
      this.label6.Text = "Barkod:";
      this.tmiktar.BorderStyle = BorderStyle.FixedSingle;
      this.tmiktar.Dock = DockStyle.Fill;
      this.tmiktar.Font = new Font("Microsoft Sans Serif", 19f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tmiktar.Location = new Point(73, 3);
      this.tmiktar.Name = "tmiktar";
      this.tmiktar.Size = new Size(118, 42);
      this.tmiktar.TabIndex = 22;
      this.tmiktar.TabStop = false;
      this.tmiktar.Text = "1";
      this.tmiktar.TextAlign = HorizontalAlignment.Center;
      this.tmiktar.Click += new EventHandler(this.tmiktar_Click);
      this.tableLayoutPanel16.AutoSize = true;
      this.tableLayoutPanel16.ColumnCount = 5;
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis5, 4, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis4, 3, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis3, 2, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis2, 1, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis1, 0, 0);
      this.tableLayoutPanel16.Dock = DockStyle.Fill;
      this.tableLayoutPanel16.Location = new Point(0, 47);
      this.tableLayoutPanel16.Margin = new Padding(0);
      this.tableLayoutPanel16.Name = "tableLayoutPanel16";
      this.tableLayoutPanel16.RowCount = 1;
      this.tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel16.Size = new Size(680, 27);
      this.tableLayoutPanel16.TabIndex = 26;
      this.rsatis5.AutoSize = true;
      this.rsatis5.Dock = DockStyle.Fill;
      this.rsatis5.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis5.Location = new Point(544, 0);
      this.rsatis5.Margin = new Padding(0);
      this.rsatis5.Name = "rsatis5";
      this.rsatis5.Size = new Size(136, 27);
      this.rsatis5.TabIndex = 8;
      this.rsatis5.TabStop = true;
      this.rsatis5.Text = "Fiyat 5";
      this.rsatis5.UseVisualStyleBackColor = true;
      this.rsatis5.CheckedChanged += new EventHandler(this.rsatis5_CheckedChanged);
      this.rsatis4.AutoSize = true;
      this.rsatis4.Dock = DockStyle.Fill;
      this.rsatis4.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis4.Location = new Point(408, 0);
      this.rsatis4.Margin = new Padding(0);
      this.rsatis4.Name = "rsatis4";
      this.rsatis4.Size = new Size(136, 27);
      this.rsatis4.TabIndex = 9;
      this.rsatis4.TabStop = true;
      this.rsatis4.Text = "Fiyat 4";
      this.rsatis4.UseVisualStyleBackColor = true;
      this.rsatis4.Click += new EventHandler(this.rsatis4_CheckedChanged);
      this.rsatis3.AutoSize = true;
      this.rsatis3.Dock = DockStyle.Fill;
      this.rsatis3.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis3.Location = new Point(272, 0);
      this.rsatis3.Margin = new Padding(0);
      this.rsatis3.Name = "rsatis3";
      this.rsatis3.Size = new Size(136, 27);
      this.rsatis3.TabIndex = 10;
      this.rsatis3.TabStop = true;
      this.rsatis3.Text = "Fiyat 3";
      this.rsatis3.UseVisualStyleBackColor = true;
      this.rsatis3.Click += new EventHandler(this.rsatis3_CheckedChanged);
      this.rsatis2.AutoSize = true;
      this.rsatis2.Dock = DockStyle.Fill;
      this.rsatis2.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis2.Location = new Point(136, 0);
      this.rsatis2.Margin = new Padding(0);
      this.rsatis2.Name = "rsatis2";
      this.rsatis2.Size = new Size(136, 27);
      this.rsatis2.TabIndex = 11;
      this.rsatis2.TabStop = true;
      this.rsatis2.Text = "Fiyat 2";
      this.rsatis2.UseVisualStyleBackColor = true;
      this.rsatis2.Click += new EventHandler(this.rsatis2_CheckedChanged);
      this.rsatis1.AutoSize = true;
      this.rsatis1.BackColor = SystemColors.ControlDark;
      this.rsatis1.Checked = true;
      this.rsatis1.Dock = DockStyle.Fill;
      this.rsatis1.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis1.Location = new Point(0, 0);
      this.rsatis1.Margin = new Padding(0);
      this.rsatis1.Name = "rsatis1";
      this.rsatis1.Size = new Size(136, 27);
      this.rsatis1.TabIndex = 12;
      this.rsatis1.TabStop = true;
      this.rsatis1.Text = "Fiyat 1";
      this.rsatis1.UseVisualStyleBackColor = false;
      this.rsatis1.Click += new EventHandler(this.rsatis1_CheckedChanged);
      this.tableLayoutPanel15.ColumnCount = 2;
      this.tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60f));
      this.tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f));
      this.tableLayoutPanel15.Controls.Add((Control) this.tGenelToplam, 0, 0);
      this.tableLayoutPanel15.Controls.Add((Control) this.panel2, 1, 0);
      this.tableLayoutPanel15.Dock = DockStyle.Fill;
      this.tableLayoutPanel15.Location = new Point(3, 77);
      this.tableLayoutPanel15.Name = "tableLayoutPanel15";
      this.tableLayoutPanel15.RowCount = 1;
      this.tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel15.Size = new Size(674, 70);
      this.tableLayoutPanel15.TabIndex = 27;
      this.tGenelToplam.BackColor = Color.DarkOliveGreen;
      this.tGenelToplam.BorderStyle = BorderStyle.None;
      this.tGenelToplam.Dock = DockStyle.Fill;
      this.tGenelToplam.Font = new Font("Microsoft Sans Serif", 42f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tGenelToplam.ForeColor = Color.White;
      this.tGenelToplam.Location = new Point(0, 0);
      this.tGenelToplam.Margin = new Padding(0);
      this.tGenelToplam.Name = "tGenelToplam";
      this.tGenelToplam.ReadOnly = true;
      this.tGenelToplam.Size = new Size(404, 76);
      this.tGenelToplam.TabIndex = 3;
      this.tGenelToplam.Text = "00";
      this.tGenelToplam.TextAlign = HorizontalAlignment.Center;
      this.tGenelToplam.TextChanged += new EventHandler(this.tGenelToplam_TextChanged);
      this.panel2.Controls.Add((Control) this.chsatisiadeislemi);
      this.panel2.Controls.Add((Control) this.bBarkod);
      this.panel2.Controls.Add((Control) this.chYazdirma);
      this.panel2.Controls.Add((Control) this.lNakit);
      this.panel2.Controls.Add((Control) this.lKullanici);
      this.panel2.Controls.Add((Control) this.lKart);
      this.panel2.Controls.Add((Control) this.GridBekle);
      this.panel2.Dock = DockStyle.Fill;
      this.panel2.Location = new Point(404, 0);
      this.panel2.Margin = new Padding(0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(270, 70);
      this.panel2.TabIndex = 4;
      this.chsatisiadeislemi.Appearance = Appearance.Button;
      this.chsatisiadeislemi.AutoSize = true;
      this.chsatisiadeislemi.BackColor = Color.Olive;
      this.chsatisiadeislemi.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
      this.chsatisiadeislemi.FlatAppearance.CheckedBackColor = Color.DarkRed;
      this.chsatisiadeislemi.FlatStyle = FlatStyle.Flat;
      this.chsatisiadeislemi.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.chsatisiadeislemi.ForeColor = Color.White;
      this.chsatisiadeislemi.Location = new Point(3, 28);
      this.chsatisiadeislemi.Name = "chsatisiadeislemi";
      this.chsatisiadeislemi.Size = new Size(149, 32);
      this.chsatisiadeislemi.TabIndex = 14;
      this.chsatisiadeislemi.Text = "Satış Yapılıyor";
      this.chsatisiadeislemi.UseVisualStyleBackColor = false;
      this.chYazdirma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chYazdirma.AutoSize = true;
      this.chYazdirma.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chYazdirma.Location = new Point(137, 25);
      this.chYazdirma.Name = "chYazdirma";
      this.chYazdirma.Size = new Size(117, 29);
      this.chYazdirma.TabIndex = 13;
      this.chYazdirma.Text = "Fiş Yazdır";
      this.chYazdirma.UseVisualStyleBackColor = true;
      this.lNakit.AutoSize = true;
      this.lNakit.Location = new Point(54, 1);
      this.lNakit.Name = "lNakit";
      this.lNakit.Size = new Size(38, 16);
      this.lNakit.TabIndex = 12;
      this.lNakit.Text = "Nakit";
      this.lNakit.Visible = false;
      this.lKullanici.AutoSize = true;
      this.lKullanici.Location = new Point(198, 1);
      this.lKullanici.Name = "lKullanici";
      this.lKullanici.Size = new Size(59, 16);
      this.lKullanici.TabIndex = 11;
      this.lKullanici.Text = "Kullanıcı:";
      this.lKart.AutoSize = true;
      this.lKart.Location = new Point(18, 1);
      this.lKart.Name = "lKart";
      this.lKart.Size = new Size(30, 16);
      this.lKart.TabIndex = 10;
      this.lKart.Text = "Kart";
      this.lKart.Visible = false;
      this.GridBekle.AllowUserToAddRows = false;
      this.GridBekle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridBekle.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridBekle.BorderStyle = BorderStyle.None;
      gridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle8.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle8.ForeColor = Color.White;
      gridViewCellStyle8.Padding = new Padding(3);
      gridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle8.WrapMode = DataGridViewTriState.True;
      this.GridBekle.ColumnHeadersDefaultCellStyle = gridViewCellStyle8;
      this.GridBekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridBekle.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2, (DataGridViewColumn) this.dataGridViewTextBoxColumn3, (DataGridViewColumn) this.dataGridViewTextBoxColumn4, (DataGridViewColumn) this.dataGridViewTextBoxColumn5, (DataGridViewColumn) this.dataGridViewTextBoxColumn6, (DataGridViewColumn) this.dataGridViewTextBoxColumn7, (DataGridViewColumn) this.dataGridViewTextBoxColumn8, (DataGridViewColumn) this.dataGridViewTextBoxColumn9, (DataGridViewColumn) this.dataGridViewTextBoxColumn10, (DataGridViewColumn) this.dataGridViewTextBoxColumn11, (DataGridViewColumn) this.dataGridViewTextBoxColumn12, (DataGridViewColumn) this.dataGridViewTextBoxColumn13, (DataGridViewColumn) this.dataGridViewTextBoxColumn14, (DataGridViewColumn) this.dataGridViewImageColumn1);
      this.GridBekle.EnableHeadersVisualStyles = false;
      this.GridBekle.Location = new Point(57, 31);
      this.GridBekle.Margin = new Padding(1);
      this.GridBekle.Name = "GridBekle";
      this.GridBekle.RowHeadersVisible = false;
      this.GridBekle.RowHeadersWidth = 49;
      gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.GridBekle.RowsDefaultCellStyle = gridViewCellStyle9;
      this.GridBekle.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridBekle.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridBekle.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridBekle.RowTemplate.Height = 33;
      this.GridBekle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridBekle.Size = new Size(81, 18);
      this.GridBekle.TabIndex = 14;
      this.GridBekle.Visible = false;
      this.dataGridViewTextBoxColumn1.HeaderText = "Barkod";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      gridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle10;
      this.dataGridViewTextBoxColumn3.HeaderText = "Birim";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn4.HeaderText = "KdvTutar";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Visible = false;
      this.dataGridViewTextBoxColumn5.HeaderText = "AlıisFiyat";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Visible = false;
      this.dataGridViewTextBoxColumn6.HeaderText = "UrunGrup";
      this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Visible = false;
      gridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle11;
      this.dataGridViewTextBoxColumn7.HeaderText = "Miktar";
      this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      gridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle12.Format = "C2";
      gridViewCellStyle12.NullValue = (object) null;
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = gridViewCellStyle12;
      this.dataGridViewTextBoxColumn8.HeaderText = "Fiyat";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      gridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle13.Format = "C2";
      gridViewCellStyle13.NullValue = (object) null;
      this.dataGridViewTextBoxColumn9.DefaultCellStyle = gridViewCellStyle13;
      this.dataGridViewTextBoxColumn9.HeaderText = "Toplam";
      this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn10.HeaderText = "Fiyat2";
      this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.Visible = false;
      this.dataGridViewTextBoxColumn11.HeaderText = "Fiyat3";
      this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.Visible = false;
      this.dataGridViewTextBoxColumn12.HeaderText = "Fiyat4";
      this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.Visible = false;
      this.dataGridViewTextBoxColumn13.HeaderText = "Fiyat5";
      this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.Visible = false;
      this.dataGridViewTextBoxColumn14.HeaderText = "Ürün ID";
      this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewImageColumn1.HeaderText = "Sİl";
      this.dataGridViewImageColumn1.Image = (Image) componentResourceManager.GetObject("dataGridViewImageColumn1.Image");
      this.dataGridViewImageColumn1.MinimumWidth = 6;
      this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
      this.tableLayoutPanel18.ColumnCount = 8;
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel18.Controls.Add((Control) this.bs10, 6, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bsar, 0, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bs5, 5, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bsaz, 1, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bs4, 4, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bs2, 2, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.bs3, 3, 0);
      this.tableLayoutPanel18.Controls.Add((Control) this.tableLayoutPanel19, 7, 0);
      this.tableLayoutPanel18.Dock = DockStyle.Fill;
      this.tableLayoutPanel18.Location = new Point(0, 150);
      this.tableLayoutPanel18.Margin = new Padding(0);
      this.tableLayoutPanel18.Name = "tableLayoutPanel18";
      this.tableLayoutPanel18.RowCount = 1;
      this.tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Absolute, 92f));
      this.tableLayoutPanel18.Size = new Size(680, 92);
      this.tableLayoutPanel18.TabIndex = 28;
      this.bs10.BackColor = Color.Gray;
      this.bs10.Dock = DockStyle.Fill;
      this.bs10.FlatAppearance.BorderColor = Color.Black;
      this.bs10.FlatStyle = FlatStyle.Flat;
      this.bs10.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs10.ForeColor = Color.White;
      this.bs10.Location = new Point(511, 1);
      this.bs10.Margin = new Padding(1);
      this.bs10.Name = "bs10";
      this.bs10.Size = new Size(83, 90);
      this.bs10.TabIndex = 7;
      this.bs10.Text = "10";
      this.bs10.UseVisualStyleBackColor = false;
      this.bs10.Click += new EventHandler(this.bs10_Click);
      this.bsar.BackColor = Color.Gray;
      this.bsar.Dock = DockStyle.Fill;
      this.bsar.FlatAppearance.BorderColor = Color.Black;
      this.bsar.FlatStyle = FlatStyle.Flat;
      this.bsar.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bsar.ForeColor = Color.White;
      this.bsar.Location = new Point(1, 1);
      this.bsar.Margin = new Padding(1);
      this.bsar.Name = "bsar";
      this.bsar.Size = new Size(83, 90);
      this.bsar.TabIndex = 6;
      this.bsar.Text = "X(+)";
      this.bsar.UseVisualStyleBackColor = false;
      this.bsar.Click += new EventHandler(this.bsar_Click);
      this.bs5.BackColor = Color.Gray;
      this.bs5.Dock = DockStyle.Fill;
      this.bs5.FlatAppearance.BorderColor = Color.Black;
      this.bs5.FlatStyle = FlatStyle.Flat;
      this.bs5.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs5.ForeColor = Color.White;
      this.bs5.Location = new Point(426, 1);
      this.bs5.Margin = new Padding(1);
      this.bs5.Name = "bs5";
      this.bs5.Size = new Size(83, 90);
      this.bs5.TabIndex = 8;
      this.bs5.Text = "5";
      this.bs5.UseVisualStyleBackColor = false;
      this.bs5.Click += new EventHandler(this.bs5_Click);
      this.bsaz.BackColor = Color.Gray;
      this.bsaz.Dock = DockStyle.Fill;
      this.bsaz.FlatAppearance.BorderColor = Color.Black;
      this.bsaz.FlatStyle = FlatStyle.Flat;
      this.bsaz.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bsaz.ForeColor = Color.White;
      this.bsaz.Location = new Point(86, 1);
      this.bsaz.Margin = new Padding(1);
      this.bsaz.Name = "bsaz";
      this.bsaz.Size = new Size(83, 90);
      this.bsaz.TabIndex = 12;
      this.bsaz.Text = "X(-)";
      this.bsaz.UseVisualStyleBackColor = false;
      this.bsaz.Click += new EventHandler(this.bsaz_Click);
      this.bs4.BackColor = Color.Gray;
      this.bs4.Dock = DockStyle.Fill;
      this.bs4.FlatAppearance.BorderColor = Color.Black;
      this.bs4.FlatStyle = FlatStyle.Flat;
      this.bs4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs4.ForeColor = Color.White;
      this.bs4.Location = new Point(341, 1);
      this.bs4.Margin = new Padding(1);
      this.bs4.Name = "bs4";
      this.bs4.Size = new Size(83, 90);
      this.bs4.TabIndex = 9;
      this.bs4.Text = "4";
      this.bs4.UseVisualStyleBackColor = false;
      this.bs4.Click += new EventHandler(this.bs4_Click);
      this.bs2.BackColor = Color.Gray;
      this.bs2.Dock = DockStyle.Fill;
      this.bs2.FlatAppearance.BorderColor = Color.Black;
      this.bs2.FlatStyle = FlatStyle.Flat;
      this.bs2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs2.ForeColor = Color.White;
      this.bs2.Location = new Point(171, 1);
      this.bs2.Margin = new Padding(1);
      this.bs2.Name = "bs2";
      this.bs2.Size = new Size(83, 90);
      this.bs2.TabIndex = 11;
      this.bs2.Text = "2";
      this.bs2.UseVisualStyleBackColor = false;
      this.bs2.Click += new EventHandler(this.bs2_Click);
      this.bs3.BackColor = Color.Gray;
      this.bs3.Dock = DockStyle.Fill;
      this.bs3.FlatAppearance.BorderColor = Color.Black;
      this.bs3.FlatStyle = FlatStyle.Flat;
      this.bs3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs3.ForeColor = Color.White;
      this.bs3.Location = new Point(256, 1);
      this.bs3.Margin = new Padding(1);
      this.bs3.Name = "bs3";
      this.bs3.Size = new Size(83, 90);
      this.bs3.TabIndex = 10;
      this.bs3.Text = "3";
      this.bs3.UseVisualStyleBackColor = false;
      this.bs3.Click += new EventHandler(this.bs3_Click);
      this.tableLayoutPanel19.ColumnCount = 1;
      this.tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel19.Controls.Add((Control) this.textBox2, 0, 1);
      this.tableLayoutPanel19.Controls.Add((Control) this.label3, 0, 0);
      this.tableLayoutPanel19.Dock = DockStyle.Fill;
      this.tableLayoutPanel19.Location = new Point(595, 0);
      this.tableLayoutPanel19.Margin = new Padding(0);
      this.tableLayoutPanel19.Name = "tableLayoutPanel19";
      this.tableLayoutPanel19.RowCount = 2;
      this.tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
      this.tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
      this.tableLayoutPanel19.Size = new Size(85, 92);
      this.tableLayoutPanel19.TabIndex = 13;
      this.textBox2.Dock = DockStyle.Fill;
      this.textBox2.Font = new Font("Microsoft Sans Serif", 20.03478f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textBox2.Location = new Point(3, 30);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(79, 44);
      this.textBox2.TabIndex = 8;
      this.label3.AutoSize = true;
      this.label3.Dock = DockStyle.Fill;
      this.label3.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label3.ForeColor = Color.DarkOrange;
      this.label3.Location = new Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(79, 27);
      this.label3.TabIndex = 3;
      this.label3.Text = "ADET:";
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Margin = new Padding(2);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.tableLayoutPanel1);
      this.splitContainer1.Panel2.AutoScroll = true;
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Size = new Size(1225, 974);
      this.splitContainer1.SplitterDistance = 680;
      this.splitContainer1.TabIndex = 1;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.FixedPanel = FixedPanel.Panel1;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Margin = new Padding(1);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = Orientation.Horizontal;
      this.splitContainer2.Panel1.Controls.Add((Control) this.tableLayoutPanel5);
      this.splitContainer2.Panel2.Controls.Add((Control) this.tableLayoutPanel4);
      this.splitContainer2.Size = new Size(541, 974);
      this.splitContainer2.SplitterDistance = 418;
      this.splitContainer2.TabIndex = 0;
      this.tableLayoutPanel5.ColumnCount = 3;
      this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
      this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45f));
      this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel5.Controls.Add((Control) this.tableLayoutPanel6, 0, 0);
      this.tableLayoutPanel5.Controls.Add((Control) this.tableLayoutPanel7, 1, 0);
      this.tableLayoutPanel5.Controls.Add((Control) this.tableLayoutPanel9, 2, 0);
      this.tableLayoutPanel5.Dock = DockStyle.Fill;
      this.tableLayoutPanel5.Location = new Point(0, 0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel5.Size = new Size(541, 418);
      this.tableLayoutPanel5.TabIndex = 1;
      this.tableLayoutPanel6.ColumnCount = 1;
      this.tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel6.Controls.Add((Control) this.bGiris, 0, 5);
      this.tableLayoutPanel6.Controls.Add((Control) this.button8, 0, 0);
      this.tableLayoutPanel6.Controls.Add((Control) this.b100, 0, 3);
      this.tableLayoutPanel6.Controls.Add((Control) this.b200, 0, 4);
      this.tableLayoutPanel6.Controls.Add((Control) this.b50, 0, 2);
      this.tableLayoutPanel6.Controls.Add((Control) this.b20, 0, 1);
      this.tableLayoutPanel6.Dock = DockStyle.Fill;
      this.tableLayoutPanel6.Location = new Point(0, 0);
      this.tableLayoutPanel6.Margin = new Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 6;
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667f));
      this.tableLayoutPanel6.Size = new Size(101, 418);
      this.tableLayoutPanel6.TabIndex = 0;
      this.bGiris.BackColor = Color.Gray;
      this.bGiris.Dock = DockStyle.Fill;
      this.bGiris.FlatAppearance.BorderColor = Color.Black;
      this.bGiris.FlatStyle = FlatStyle.Flat;
      this.bGiris.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bGiris.ForeColor = Color.Transparent;
      this.bGiris.Image = (Image) Resources.barcode4832;
      this.bGiris.Location = new Point(1, 346);
      this.bGiris.Margin = new Padding(1);
      this.bGiris.Name = "bGiris";
      this.bGiris.Size = new Size(99, 71);
      this.bGiris.TabIndex = 13;
      this.bGiris.UseVisualStyleBackColor = false;
      this.bGiris.Click += new EventHandler(this.bGiris_Click);
      this.b100.BackColor = Color.Gray;
      this.b100.Dock = DockStyle.Fill;
      this.b100.FlatAppearance.BorderColor = Color.Black;
      this.b100.FlatStyle = FlatStyle.Flat;
      this.b100.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b100.ForeColor = Color.White;
      this.b100.Image = (Image) componentResourceManager.GetObject("b100.Image");
      this.b100.Location = new Point(1, 208);
      this.b100.Margin = new Padding(1);
      this.b100.Name = "b100";
      this.b100.Size = new Size(99, 67);
      this.b100.TabIndex = 4;
      this.b100.UseVisualStyleBackColor = false;
      this.b100.Click += new EventHandler(this.b100_Click);
      this.b200.BackColor = Color.Gray;
      this.b200.Dock = DockStyle.Fill;
      this.b200.FlatAppearance.BorderColor = Color.Black;
      this.b200.FlatStyle = FlatStyle.Flat;
      this.b200.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b200.ForeColor = Color.White;
      this.b200.Image = (Image) Resources.exit4854;
      this.b200.Location = new Point(1, 277);
      this.b200.Margin = new Padding(1);
      this.b200.Name = "b200";
      this.b200.Size = new Size(99, 67);
      this.b200.TabIndex = 5;
      this.b200.UseVisualStyleBackColor = false;
      this.b200.Click += new EventHandler(this.b200_Click);
      this.b50.BackColor = Color.Gray;
      this.b50.Dock = DockStyle.Fill;
      this.b50.FlatAppearance.BorderColor = Color.Black;
      this.b50.FlatStyle = FlatStyle.Flat;
      this.b50.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b50.ForeColor = Color.White;
      this.b50.Image = (Image) Resources.cancel24;
      this.b50.Location = new Point(1, 139);
      this.b50.Margin = new Padding(1);
      this.b50.Name = "b50";
      this.b50.Size = new Size(99, 67);
      this.b50.TabIndex = 3;
      this.b50.UseVisualStyleBackColor = false;
      this.b50.Click += new EventHandler(this.b50_Click);
      this.b20.BackColor = Color.Gray;
      this.b20.Dock = DockStyle.Fill;
      this.b20.FlatAppearance.BorderColor = Color.Black;
      this.b20.FlatStyle = FlatStyle.Flat;
      this.b20.Font = new Font("Microsoft Sans Serif", 20.03478f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b20.ForeColor = Color.White;
      this.b20.Location = new Point(1, 70);
      this.b20.Margin = new Padding(1);
      this.b20.Name = "b20";
      this.b20.Size = new Size(99, 67);
      this.b20.TabIndex = 2;
      this.b20.Text = "(/)";
      this.b20.UseVisualStyleBackColor = false;
      this.b20.Click += new EventHandler(this.b20_Click);
      this.dataGridViewImageColumn2.HeaderText = "Sİl";
      this.dataGridViewImageColumn2.Image = (Image) componentResourceManager.GetObject("dataGridViewImageColumn2.Image");
      this.dataGridViewImageColumn2.MinimumWidth = 6;
      this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
      this.dataGridViewImageColumn2.Width = 113;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1225, 974);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Name = nameof (Form1);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Şatış Ekranı";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.Form1_Load);
      this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
      this.tableLayoutPanel7.ResumeLayout(false);
      this.tableLayoutPanel7.PerformLayout();
      this.tableLayoutPanel8.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel9.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel10.ResumeLayout(false);
      this.tableLayoutPanel11.ResumeLayout(false);
      this.tableLayoutPanel11.PerformLayout();
      this.tableLayoutPanel12.ResumeLayout(false);
      this.tableLayoutPanel12.PerformLayout();
      this.tableLayoutPanel13.ResumeLayout(false);
      this.tableLayoutPanel13.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((ISupportInitialize) this.GridSatis).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.tableLayoutPanel14.ResumeLayout(false);
      this.tableLayoutPanel14.PerformLayout();
      this.tableLayoutPanel17.ResumeLayout(false);
      this.tableLayoutPanel17.PerformLayout();
      this.tableLayoutPanel16.ResumeLayout(false);
      this.tableLayoutPanel16.PerformLayout();
      this.tableLayoutPanel15.ResumeLayout(false);
      this.tableLayoutPanel15.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((ISupportInitialize) this.GridBekle).EndInit();
      this.tableLayoutPanel18.ResumeLayout(false);
      this.tableLayoutPanel19.ResumeLayout(false);
      this.tableLayoutPanel19.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel6.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
