// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fRapor
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fRapor : Form
  {
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private ListBox listfiltrelemeturu;
    private lstandart lstandart1;
    private DateTimePicker dtBitis;
    private lstandart lBitisTarih;
    private lstandart lBaslangıctarih;
    private DateTimePicker dtBaslangıc;
    private Button bGiderEkle;
    private Button bGelirEkle;
    private tnumeric tGiderKart;
    private tnumeric tGelirKart;
    private tnumeric tİadeKart;
    private tnumeric tKartKomisyon;
    private tnumeric tKdvToplam;
    private tnumeric tSatisKart;
    private tnumeric tGiderNakit;
    private tnumeric tGelirNakit;
    private tnumeric tİadeNakit;
    private tnumeric tSatisNakit;
    private lstandart lstandart10;
    private lstandart lstandart9;
    private lstandart lstandart7;
    private lstandart lstandart6;
    private lstandart lstandart4;
    private lstandart lstandart8;
    private lstandart lstandart12;
    private lstandart lstandart3;
    private lstandart lstandart11;
    private lstandart lstandart5;
    private lstandart lKart;
    private lstandart lstandart2;
    private lstandart lSatısToplam;
    private lstandart lNakit;
    private bstandart bGöster;
    private gridozel GridListe;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem detayGösterToolStripMenuItem;
    private ToolStripMenuItem silToolStripMenuItem;
    private ToolStripMenuItem düzenleToolStripMenuItem;
    private bstandart bRaporAl;
    internal lstandart lkullanici;
    private ToolStripMenuItem yazdırToolStripMenuItem;
    private bstandart tYazdır;
    private Button b200;
    private Panel panel1;

    public fRapor() => this.InitializeComponent();

    private void dateBaslangic_ValueChanged(object sender, EventArgs e)
    {
    }

    private void lBitisTarih_Click(object sender, EventArgs e)
    {
    }

    private void lBaslangıctarih_Click(object sender, EventArgs e)
    {
    }

    private void dateBitis_ValueChanged(object sender, EventArgs e)
    {
    }

    public void bGöster_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      DateTime baslangic = DateTime.Parse(this.dtBaslangıc.Value.ToShortDateString());
      DateTime bitis = DateTime.Parse(this.dtBitis.Value.ToShortDateString());
      bitis = bitis.AddDays(1.0);
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (this.listfiltrelemeturu.SelectedIndex == 0)
        {
          barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis)).OrderByDescending<islemOzet, DateTime?>((Expression<Func<islemOzet, DateTime?>>) (x => x.Tarih)).Load();
          BindingList<islemOzet> bindingList1 = barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
          this.GridListe.DataSource = (object) bindingList1;
          tnumeric tSatisNakit = this.tSatisNakit;
          double num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag1 = false;
            if (İade.GetValueOrDefault() == flag1 & İade.HasValue)
            {
              bool? gelir = x.Gelir;
              bool flag2 = false;
              if (gelir.GetValueOrDefault() == flag2 & gelir.HasValue)
              {
                bool? gider = x.Gider;
                bool flag3 = false;
                return gider.GetValueOrDefault() == flag3 & gider.HasValue;
              }
            }
            return false;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Nakit)));
          string str1 = num1.ToString("C2");
          tSatisNakit.Text = str1;
          tnumeric tSatisKart = this.tSatisKart;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag4 = false;
            if (İade.GetValueOrDefault() == flag4 & İade.HasValue)
            {
              bool? gelir = x.Gelir;
              bool flag5 = false;
              if (gelir.GetValueOrDefault() == flag5 & gelir.HasValue)
              {
                bool? gider = x.Gider;
                bool flag6 = false;
                return gider.GetValueOrDefault() == flag6 & gider.HasValue;
              }
            }
            return false;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Kart)));
          string str2 = num1.ToString("C2");
          tSatisKart.Text = str2;
          tnumeric tİadeNakit = this.tİadeNakit;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag = true;
            return İade.GetValueOrDefault() == flag & İade.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Nakit)));
          string str3 = num1.ToString("C2");
          tİadeNakit.Text = str3;
          tnumeric tİadeKart = this.tİadeKart;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag = true;
            return İade.GetValueOrDefault() == flag & İade.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Kart)));
          string str4 = num1.ToString("C2");
          tİadeKart.Text = str4;
          tnumeric tGelirNakit = this.tGelirNakit;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? gelir = x.Gelir;
            bool flag = true;
            return gelir.GetValueOrDefault() == flag & gelir.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Nakit)));
          string str5 = num1.ToString("C2");
          tGelirNakit.Text = str5;
          tnumeric tGelirKart = this.tGelirKart;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? gelir = x.Gelir;
            bool flag = true;
            return gelir.GetValueOrDefault() == flag & gelir.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Kart)));
          string str6 = num1.ToString("C2");
          tGelirKart.Text = str6;
          tnumeric tGiderNakit = this.tGiderNakit;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? gider = x.Gider;
            bool flag = true;
            return gider.GetValueOrDefault() == flag & gider.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Nakit)));
          string str7 = num1.ToString("C2");
          tGiderNakit.Text = str7;
          tnumeric tGiderKart = this.tGiderKart;
          num1 = Convert.ToDouble((object) bindingList1.Where<islemOzet>((Func<islemOzet, bool>) (x =>
          {
            bool? gider = x.Gider;
            bool flag = true;
            return gider.GetValueOrDefault() == flag & gider.HasValue;
          })).Sum<islemOzet>((Func<islemOzet, double?>) (x => x.Kart)));
          string str8 = num1.ToString("C2");
          tGiderKart.Text = str8;
          barkod1Entities.Satisid.Where<Satisid>((Expression<Func<Satisid, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis)).Load();
          BindingList<Satisid> bindingList2 = barkod1Entities.Satisid.Local.ToBindingList<Satisid>();
          double? nullable = bindingList2.Where<Satisid>((Func<Satisid, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag = false;
            return İade.GetValueOrDefault() == flag & İade.HasValue;
          })).Sum<Satisid>((Func<Satisid, double?>) (x => x.Kdvtutari));
          double num2 = islemler.DoubleYap(nullable.ToString());
          nullable = bindingList2.Where<Satisid>((Func<Satisid, bool>) (x =>
          {
            bool? İade = x.İade;
            bool flag = true;
            return İade.GetValueOrDefault() == flag & İade.HasValue;
          })).Sum<Satisid>((Func<Satisid, double?>) (x => x.Kdvtutari));
          double num3 = islemler.DoubleYap(nullable.ToString());
          tnumeric tKdvToplam = this.tKdvToplam;
          num1 = num2 - num3;
          string str9 = num1.ToString("C2");
          tKdvToplam.Text = str9;
        }
        else if (this.listfiltrelemeturu.SelectedIndex == 1)
        {
          barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis && x.İade == (bool?) false && x.Gelir == (bool?) false && x.Gider == (bool?) false)).Load();
          this.GridListe.DataSource = (object) barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
        }
        else if (this.listfiltrelemeturu.SelectedIndex == 2)
        {
          barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis && x.İade == (bool?) true)).Load();
          this.GridListe.DataSource = (object) barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
        }
        else if (this.listfiltrelemeturu.SelectedIndex == 3)
        {
          barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis && x.Gelir == (bool?) true)).Load();
          this.GridListe.DataSource = (object) barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
        }
        else if (this.listfiltrelemeturu.SelectedIndex == 4)
        {
          barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis && x.Gider == (bool?) true)).Load();
          this.GridListe.DataSource = (object) barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
        }
      }
      islemler.GridDuzenle((DataGridView) this.GridListe);
      Cursor.Current = Cursors.Default;
    }

    private void fRapor_Load(object sender, EventArgs e)
    {
      this.listfiltrelemeturu.SelectedIndex = 0;
      this.tKartKomisyon.Text = islemler.KartKomisyon().ToString();
      this.bGöster_Click((object) null, (EventArgs) null);
    }

    private void GridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex != 2 && e.ColumnIndex != 6 && e.ColumnIndex != 7 || !(e.Value is bool))
        return;
      bool flag = (bool) e.Value;
      e.Value = flag ? (object) "Evet" : (object) "Hayır";
      e.FormattingApplied = true;
    }

    private void bGelirEkle_Click(object sender, EventArgs e)
    {
      int num = (int) new fGelirGider()
      {
        gelirgider = "GELİR",
        kullanici = this.lkullanici.Text
      }.ShowDialog();
    }

    private void bGiderEkle_Click(object sender, EventArgs e)
    {
      int num = (int) new fGelirGider()
      {
        gelirgider = "GELİR",
        kullanici = this.lkullanici.Text
      }.ShowDialog();
    }

    private void detayGösterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
      {
        int num = (int) new fDetayGöster()
        {
          İslemNo = int32
        }.ShowDialog();
      }
    }

    private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
    {
    }

    private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void bRaporAl_Click(object sender, EventArgs e)
    {
      Raporlar.Baslık = "GENEL RAPOR";
      Raporlar.SatisKart = this.tSatisKart.Text;
      Raporlar.SatisNakit = this.tSatisNakit.Text;
      Raporlar.İadeKart = this.tİadeKart.Text;
      Raporlar.İadeNakit = this.tİadeNakit.Text;
      Raporlar.GelirKart = this.tGelirKart.Text;
      Raporlar.GelirNakit = this.tGelirNakit.Text;
      Raporlar.GiderNakit = this.tGiderNakit.Text;
      Raporlar.GiderKart = this.tGiderKart.Text;
      Raporlar.TarihBaslangic = this.dtBaslangıc.Value.ToShortDateString();
      Raporlar.TarihBitis = this.dtBitis.Value.ToShortDateString();
      Raporlar.KdvToplam = this.tKdvToplam.Text;
      Raporlar.KartKomisyon = this.tKartKomisyon.Text;
      Raporlar.RaporSayfasiRaporu((DataGridView) this.GridListe);
    }

    private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
        new Yazdir(new int?(int32)).YazdirmayaBasla();
    }

    private void tYazdır_Click(object sender, EventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
        new Yazdir(new int?(int32)).YazdirmayaBasla();
    }

    private void GridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
      {
        int num = (int) new fDetayGöster()
        {
          İslemNo = int32
        }.ShowDialog();
      }
    }

    private void b200_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fRapor));
      this.splitContainer1 = new SplitContainer();
      this.b200 = new Button();
      this.tYazdır = new bstandart();
      this.bRaporAl = new bstandart();
      this.lkullanici = new lstandart();
      this.bGiderEkle = new Button();
      this.bGelirEkle = new Button();
      this.tGiderKart = new tnumeric();
      this.tGelirKart = new tnumeric();
      this.tİadeKart = new tnumeric();
      this.tKartKomisyon = new tnumeric();
      this.tKdvToplam = new tnumeric();
      this.tSatisKart = new tnumeric();
      this.tGiderNakit = new tnumeric();
      this.tGelirNakit = new tnumeric();
      this.tİadeNakit = new tnumeric();
      this.tSatisNakit = new tnumeric();
      this.lstandart10 = new lstandart();
      this.lstandart9 = new lstandart();
      this.lstandart7 = new lstandart();
      this.lstandart6 = new lstandart();
      this.lstandart4 = new lstandart();
      this.lstandart8 = new lstandart();
      this.lstandart12 = new lstandart();
      this.lstandart3 = new lstandart();
      this.lstandart11 = new lstandart();
      this.lstandart5 = new lstandart();
      this.lKart = new lstandart();
      this.lstandart2 = new lstandart();
      this.lSatısToplam = new lstandart();
      this.lNakit = new lstandart();
      this.bGöster = new bstandart();
      this.dtBitis = new DateTimePicker();
      this.lBitisTarih = new lstandart();
      this.lBaslangıctarih = new lstandart();
      this.dtBaslangıc = new DateTimePicker();
      this.listfiltrelemeturu = new ListBox();
      this.lstandart1 = new lstandart();
      this.GridListe = new gridozel();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.detayGösterToolStripMenuItem = new ToolStripMenuItem();
      this.silToolStripMenuItem = new ToolStripMenuItem();
      this.düzenleToolStripMenuItem = new ToolStripMenuItem();
      this.yazdırToolStripMenuItem = new ToolStripMenuItem();
      this.panel1 = new Panel();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.GridListe).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.panel1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.b200);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tYazdır);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bRaporAl);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lkullanici);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bGiderEkle);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bGelirEkle);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tGiderKart);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tGelirKart);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tİadeKart);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tKartKomisyon);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tKdvToplam);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisKart);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tGiderNakit);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tGelirNakit);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tİadeNakit);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisNakit);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart10);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart9);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart7);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart6);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart8);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart12);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart11);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart5);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lKart);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lSatısToplam);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lNakit);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bGöster);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dtBitis);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lBitisTarih);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lBaslangıctarih);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dtBaslangıc);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridListe);
      this.splitContainer1.Size = new Size(1118, 694);
      this.splitContainer1.SplitterDistance = 348;
      this.splitContainer1.TabIndex = 0;
      this.b200.BackColor = Color.DimGray;
      this.b200.FlatAppearance.BorderColor = Color.DimGray;
      this.b200.FlatStyle = FlatStyle.Flat;
      this.b200.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b200.ForeColor = Color.White;
      this.b200.Image = (Image) Resources.exit4854;
      this.b200.Location = new Point(392, (int) byte.MaxValue);
      this.b200.Margin = new Padding(1);
      this.b200.Name = "b200";
      this.b200.Size = new Size(147, 74);
      this.b200.TabIndex = 21;
      this.b200.UseVisualStyleBackColor = false;
      this.b200.Click += new EventHandler(this.b200_Click);
      this.tYazdır.BackColor = Color.RosyBrown;
      this.tYazdır.FlatAppearance.BorderColor = Color.Tomato;
      this.tYazdır.FlatStyle = FlatStyle.Flat;
      this.tYazdır.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tYazdır.ForeColor = SystemColors.ButtonHighlight;
      this.tYazdır.Image = (Image) Resources.printer;
      this.tYazdır.Location = new Point(32, (int) byte.MaxValue);
      this.tYazdır.Margin = new Padding(1);
      this.tYazdır.Name = "tYazdır";
      this.tYazdır.Size = new Size(144, 74);
      this.tYazdır.TabIndex = 20;
      this.tYazdır.Text = "YAZDIR";
      this.tYazdır.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.tYazdır.UseVisualStyleBackColor = false;
      this.tYazdır.Click += new EventHandler(this.tYazdır_Click);
      this.bRaporAl.BackColor = Color.Red;
      this.bRaporAl.FlatAppearance.BorderColor = Color.Red;
      this.bRaporAl.FlatStyle = FlatStyle.Flat;
      this.bRaporAl.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bRaporAl.ForeColor = SystemColors.ButtonHighlight;
      this.bRaporAl.Image = (Image) Resources.export__3_;
      this.bRaporAl.Location = new Point(212, (int) byte.MaxValue);
      this.bRaporAl.Margin = new Padding(1);
      this.bRaporAl.Name = "bRaporAl";
      this.bRaporAl.Size = new Size(137, 74);
      this.bRaporAl.TabIndex = 19;
      this.bRaporAl.Text = "Rapor Al";
      this.bRaporAl.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bRaporAl.UseVisualStyleBackColor = false;
      this.bRaporAl.Click += new EventHandler(this.bRaporAl_Click);
      this.lkullanici.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lkullanici.AutoSize = true;
      this.lkullanici.Font = new Font("Microsoft Sans Serif", 12f);
      this.lkullanici.ForeColor = Color.DarkCyan;
      this.lkullanici.Location = new Point(756, 24);
      this.lkullanici.Name = "lkullanici";
      this.lkullanici.Size = new Size(81, 25);
      this.lkullanici.TabIndex = 11;
      this.lkullanici.Text = "Kullancı";
      this.bGiderEkle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bGiderEkle.BackColor = Color.DarkCyan;
      this.bGiderEkle.FlatAppearance.BorderColor = Color.DarkCyan;
      this.bGiderEkle.Image = (Image) Resources.Ekle24;
      this.bGiderEkle.Location = new Point(1031, 252);
      this.bGiderEkle.Name = "bGiderEkle";
      this.bGiderEkle.Size = new Size(75, 60);
      this.bGiderEkle.TabIndex = 10;
      this.bGiderEkle.UseVisualStyleBackColor = false;
      this.bGiderEkle.Click += new EventHandler(this.bGiderEkle_Click);
      this.bGelirEkle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bGelirEkle.BackColor = Color.YellowGreen;
      this.bGelirEkle.FlatAppearance.BorderColor = Color.YellowGreen;
      this.bGelirEkle.Image = (Image) Resources.Ekle24;
      this.bGelirEkle.Location = new Point(1031, 133);
      this.bGelirEkle.Name = "bGelirEkle";
      this.bGelirEkle.Size = new Size(75, 60);
      this.bGelirEkle.TabIndex = 10;
      this.bGelirEkle.UseVisualStyleBackColor = false;
      this.bGelirEkle.Click += new EventHandler(this.bGelirEkle_Click);
      this.tGiderKart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tGiderKart.BackColor = Color.WhiteSmoke;
      this.tGiderKart.BorderStyle = BorderStyle.None;
      this.tGiderKart.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tGiderKart.Location = new Point(937, 294);
      this.tGiderKart.Name = "tGiderKart";
      this.tGiderKart.Size = new Size(88, 19);
      this.tGiderKart.TabIndex = 9;
      this.tGiderKart.TextAlign = HorizontalAlignment.Center;
      this.tGelirKart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tGelirKart.BackColor = Color.WhiteSmoke;
      this.tGelirKart.BorderStyle = BorderStyle.None;
      this.tGelirKart.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tGelirKart.Location = new Point(937, 172);
      this.tGelirKart.Name = "tGelirKart";
      this.tGelirKart.Size = new Size(88, 19);
      this.tGelirKart.TabIndex = 9;
      this.tGelirKart.TextAlign = HorizontalAlignment.Center;
      this.tİadeKart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tİadeKart.BackColor = Color.WhiteSmoke;
      this.tİadeKart.BorderStyle = BorderStyle.None;
      this.tİadeKart.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tİadeKart.Location = new Point(790, 174);
      this.tİadeKart.Name = "tİadeKart";
      this.tİadeKart.Size = new Size(88, 19);
      this.tİadeKart.TabIndex = 9;
      this.tİadeKart.TextAlign = HorizontalAlignment.Center;
      this.tKartKomisyon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tKartKomisyon.BackColor = Color.WhiteSmoke;
      this.tKartKomisyon.BorderStyle = BorderStyle.None;
      this.tKartKomisyon.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tKartKomisyon.Location = new Point(761, 283);
      this.tKartKomisyon.Name = "tKartKomisyon";
      this.tKartKomisyon.Size = new Size(88, 19);
      this.tKartKomisyon.TabIndex = 9;
      this.tKartKomisyon.TextAlign = HorizontalAlignment.Center;
      this.tKdvToplam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tKdvToplam.BackColor = Color.WhiteSmoke;
      this.tKdvToplam.BorderStyle = BorderStyle.None;
      this.tKdvToplam.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tKdvToplam.Location = new Point(618, 283);
      this.tKdvToplam.Name = "tKdvToplam";
      this.tKdvToplam.Size = new Size(88, 19);
      this.tKdvToplam.TabIndex = 9;
      this.tKdvToplam.TextAlign = HorizontalAlignment.Center;
      this.tSatisKart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tSatisKart.BackColor = Color.WhiteSmoke;
      this.tSatisKart.BorderStyle = BorderStyle.None;
      this.tSatisKart.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tSatisKart.Location = new Point(633, 173);
      this.tSatisKart.Name = "tSatisKart";
      this.tSatisKart.Size = new Size(88, 19);
      this.tSatisKart.TabIndex = 9;
      this.tSatisKart.TextAlign = HorizontalAlignment.Center;
      this.tGiderNakit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tGiderNakit.BackColor = Color.WhiteSmoke;
      this.tGiderNakit.BorderStyle = BorderStyle.None;
      this.tGiderNakit.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tGiderNakit.Location = new Point(937, 252);
      this.tGiderNakit.Name = "tGiderNakit";
      this.tGiderNakit.Size = new Size(88, 19);
      this.tGiderNakit.TabIndex = 9;
      this.tGiderNakit.TextAlign = HorizontalAlignment.Center;
      this.tGelirNakit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tGelirNakit.BackColor = Color.WhiteSmoke;
      this.tGelirNakit.BorderStyle = BorderStyle.None;
      this.tGelirNakit.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tGelirNakit.Location = new Point(937, 132);
      this.tGelirNakit.Name = "tGelirNakit";
      this.tGelirNakit.Size = new Size(88, 19);
      this.tGelirNakit.TabIndex = 9;
      this.tGelirNakit.TextAlign = HorizontalAlignment.Center;
      this.tİadeNakit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tİadeNakit.BackColor = Color.WhiteSmoke;
      this.tİadeNakit.BorderStyle = BorderStyle.None;
      this.tİadeNakit.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tİadeNakit.Location = new Point(790, 132);
      this.tİadeNakit.Name = "tİadeNakit";
      this.tİadeNakit.Size = new Size(88, 19);
      this.tİadeNakit.TabIndex = 9;
      this.tİadeNakit.TextAlign = HorizontalAlignment.Center;
      this.tSatisNakit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tSatisNakit.BackColor = Color.WhiteSmoke;
      this.tSatisNakit.BorderStyle = BorderStyle.None;
      this.tSatisNakit.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
      this.tSatisNakit.Location = new Point(633, 131);
      this.tSatisNakit.Name = "tSatisNakit";
      this.tSatisNakit.Size = new Size(88, 19);
      this.tSatisNakit.TabIndex = 9;
      this.tSatisNakit.TextAlign = HorizontalAlignment.Center;
      this.lstandart10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart10.AutoSize = true;
      this.lstandart10.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart10.ForeColor = Color.DarkCyan;
      this.lstandart10.Location = new Point(882, 292);
      this.lstandart10.Name = "lstandart10";
      this.lstandart10.Size = new Size(43, 22);
      this.lstandart10.TabIndex = 8;
      this.lstandart10.Text = "Kart";
      this.lstandart9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart9.AutoSize = true;
      this.lstandart9.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart9.ForeColor = Color.SaddleBrown;
      this.lstandart9.Location = new Point(932, 224);
      this.lstandart9.Name = "lstandart9";
      this.lstandart9.Size = new Size(59, 25);
      this.lstandart9.TabIndex = 8;
      this.lstandart9.Text = "Gider";
      this.lstandart7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart7.AutoSize = true;
      this.lstandart7.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart7.ForeColor = Color.DarkCyan;
      this.lstandart7.Location = new Point(882, 170);
      this.lstandart7.Name = "lstandart7";
      this.lstandart7.Size = new Size(43, 22);
      this.lstandart7.TabIndex = 8;
      this.lstandart7.Text = "Kart";
      this.lstandart6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart6.AutoSize = true;
      this.lstandart6.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart6.ForeColor = Color.SaddleBrown;
      this.lstandart6.Location = new Point(932, 102);
      this.lstandart6.Name = "lstandart6";
      this.lstandart6.Size = new Size(52, 25);
      this.lstandart6.TabIndex = 8;
      this.lstandart6.Text = "Gelir";
      this.lstandart4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart4.AutoSize = true;
      this.lstandart4.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart4.ForeColor = Color.DarkCyan;
      this.lstandart4.Location = new Point(739, 174);
      this.lstandart4.Name = "lstandart4";
      this.lstandart4.Size = new Size(43, 22);
      this.lstandart4.TabIndex = 8;
      this.lstandart4.Text = "Kart";
      this.lstandart8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart8.AutoSize = true;
      this.lstandart8.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart8.ForeColor = Color.DarkCyan;
      this.lstandart8.Location = new Point(882, 247);
      this.lstandart8.Name = "lstandart8";
      this.lstandart8.Size = new Size(51, 22);
      this.lstandart8.TabIndex = 8;
      this.lstandart8.Text = "Nakit";
      this.lstandart12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart12.AutoSize = true;
      this.lstandart12.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart12.ForeColor = Color.DarkCyan;
      this.lstandart12.Location = new Point(738, (int) byte.MaxValue);
      this.lstandart12.Name = "lstandart12";
      this.lstandart12.Size = new Size(140, 25);
      this.lstandart12.TabIndex = 8;
      this.lstandart12.Text = "Kart Komisyon";
      this.lstandart3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart3.AutoSize = true;
      this.lstandart3.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart3.ForeColor = Color.SaddleBrown;
      this.lstandart3.Location = new Point(750, 88);
      this.lstandart3.Name = "lstandart3";
      this.lstandart3.Size = new Size(121, 25);
      this.lstandart3.TabIndex = 8;
      this.lstandart3.Text = "İade Toplam";
      this.lstandart11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart11.AutoSize = true;
      this.lstandart11.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart11.ForeColor = Color.DarkCyan;
      this.lstandart11.Location = new Point(590, (int) byte.MaxValue);
      this.lstandart11.Name = "lstandart11";
      this.lstandart11.Size = new Size(125, 25);
      this.lstandart11.TabIndex = 8;
      this.lstandart11.Text = "KDV Toplam";
      this.lstandart5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart5.AutoSize = true;
      this.lstandart5.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart5.ForeColor = Color.DarkCyan;
      this.lstandart5.Location = new Point(882, 125);
      this.lstandart5.Name = "lstandart5";
      this.lstandart5.Size = new Size(51, 22);
      this.lstandart5.TabIndex = 8;
      this.lstandart5.Text = "Nakit";
      this.lKart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lKart.AutoSize = true;
      this.lKart.Font = new Font("Microsoft Sans Serif", 11f);
      this.lKart.ForeColor = Color.DarkCyan;
      this.lKart.Location = new Point(584, 171);
      this.lKart.Name = "lKart";
      this.lKart.Size = new Size(43, 22);
      this.lKart.TabIndex = 8;
      this.lKart.Text = "Kart";
      this.lstandart2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(739, 129);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(51, 22);
      this.lstandart2.TabIndex = 8;
      this.lstandart2.Text = "Nakit";
      this.lSatısToplam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lSatısToplam.AutoSize = true;
      this.lSatısToplam.Font = new Font("Microsoft Sans Serif", 12f);
      this.lSatısToplam.ForeColor = Color.SaddleBrown;
      this.lSatısToplam.Location = new Point(594, 86);
      this.lSatısToplam.Name = "lSatısToplam";
      this.lSatısToplam.Size = new Size((int) sbyte.MaxValue, 25);
      this.lSatısToplam.TabIndex = 8;
      this.lSatısToplam.Text = "Satış Toplam";
      this.lNakit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.lNakit.AutoSize = true;
      this.lNakit.Font = new Font("Microsoft Sans Serif", 11f);
      this.lNakit.ForeColor = Color.DarkCyan;
      this.lNakit.Location = new Point(584, 126);
      this.lNakit.Name = "lNakit";
      this.lNakit.Size = new Size(51, 22);
      this.lNakit.TabIndex = 8;
      this.lNakit.Text = "Nakit";
      this.bGöster.BackColor = Color.Tomato;
      this.bGöster.FlatAppearance.BorderColor = Color.Tomato;
      this.bGöster.FlatStyle = FlatStyle.Flat;
      this.bGöster.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bGöster.ForeColor = SystemColors.ButtonHighlight;
      this.bGöster.Image = (Image) Resources.Ara32;
      this.bGöster.Location = new Point(457, 117);
      this.bGöster.Margin = new Padding(1);
      this.bGöster.Name = "bGöster";
      this.bGöster.Size = new Size(123, 86);
      this.bGöster.TabIndex = 0;
      this.bGöster.Text = "Göster";
      this.bGöster.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bGöster.UseVisualStyleBackColor = false;
      this.bGöster.Click += new EventHandler(this.bGöster_Click);
      this.dtBitis.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dtBitis.Location = new Point(186, 174);
      this.dtBitis.Name = "dtBitis";
      this.dtBitis.Size = new Size(267, 29);
      this.dtBitis.TabIndex = 7;
      this.dtBitis.ValueChanged += new EventHandler(this.dateBitis_ValueChanged);
      this.lBitisTarih.AutoSize = true;
      this.lBitisTarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBitisTarih.ForeColor = Color.DarkCyan;
      this.lBitisTarih.Location = new Point(181, 146);
      this.lBitisTarih.Name = "lBitisTarih";
      this.lBitisTarih.Size = new Size(108, 25);
      this.lBitisTarih.TabIndex = 6;
      this.lBitisTarih.Text = "Bitiş Tarihi:";
      this.lBitisTarih.Click += new EventHandler(this.lBitisTarih_Click);
      this.lBaslangıctarih.AutoSize = true;
      this.lBaslangıctarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBaslangıctarih.ForeColor = Color.DarkCyan;
      this.lBaslangıctarih.Location = new Point(181, 89);
      this.lBaslangıctarih.Name = "lBaslangıctarih";
      this.lBaslangıctarih.Size = new Size(157, 25);
      this.lBaslangıctarih.TabIndex = 5;
      this.lBaslangıctarih.Text = "Başlangıç Tarihi:";
      this.lBaslangıctarih.Click += new EventHandler(this.lBaslangıctarih_Click);
      this.dtBaslangıc.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dtBaslangıc.Location = new Point(186, 117);
      this.dtBaslangıc.Name = "dtBaslangıc";
      this.dtBaslangıc.Size = new Size(267, 29);
      this.dtBaslangıc.TabIndex = 4;
      this.dtBaslangıc.ValueChanged += new EventHandler(this.dateBaslangic_ValueChanged);
      this.listfiltrelemeturu.BackColor = Color.WhiteSmoke;
      this.listfiltrelemeturu.BorderStyle = BorderStyle.None;
      this.listfiltrelemeturu.Dock = DockStyle.Fill;
      this.listfiltrelemeturu.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.listfiltrelemeturu.FormattingEnabled = true;
      this.listfiltrelemeturu.ItemHeight = 24;
      this.listfiltrelemeturu.Items.AddRange(new object[5]
      {
        (object) "Tümü",
        (object) "Satışlar",
        (object) "İade",
        (object) "Gelir(Satış Hariç)",
        (object) "Gider(İade Hariç)"
      });
      this.listfiltrelemeturu.Location = new Point(0, 0);
      this.listfiltrelemeturu.Name = "listfiltrelemeturu";
      this.listfiltrelemeturu.Size = new Size(168, 180);
      this.listfiltrelemeturu.TabIndex = 1;
      this.lstandart1.AutoSize = true;
      this.lstandart1.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart1.ForeColor = Color.DarkCyan;
      this.lstandart1.Location = new Point(7, 19);
      this.lstandart1.Name = "lstandart1";
      this.lstandart1.Size = new Size(142, 25);
      this.lstandart1.TabIndex = 0;
      this.lstandart1.Text = "Filtreleme Türü";
      this.GridListe.AllowUserToAddRows = false;
      this.GridListe.AllowUserToDeleteRows = false;
      this.GridListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridListe.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridListe.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridListe.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridListe.ContextMenuStrip = this.contextMenuStrip1;
      this.GridListe.DefaultCellStyle = gridViewCellStyle1;
      this.GridListe.Dock = DockStyle.Fill;
      this.GridListe.EnableHeadersVisualStyles = false;
      this.GridListe.Location = new Point(0, 0);
      this.GridListe.Margin = new Padding(1);
      this.GridListe.Name = "GridListe";
      this.GridListe.ReadOnly = true;
      this.GridListe.RowHeadersVisible = false;
      this.GridListe.RowHeadersWidth = 49;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = Color.White;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.Padding = new Padding(3);
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.GridListe.RowsDefaultCellStyle = gridViewCellStyle2;
      this.GridListe.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridListe.RowTemplate.Height = 33;
      this.GridListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridListe.Size = new Size(1118, 342);
      this.GridListe.TabIndex = 2;
      this.GridListe.CellDoubleClick += new DataGridViewCellEventHandler(this.GridListe_CellDoubleClick);
      this.GridListe.CellFormatting += new DataGridViewCellFormattingEventHandler(this.GridListe_CellFormatting);
      this.contextMenuStrip1.ImageScalingSize = new Size(19, 19);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.detayGösterToolStripMenuItem,
        (ToolStripItem) this.silToolStripMenuItem,
        (ToolStripItem) this.düzenleToolStripMenuItem,
        (ToolStripItem) this.yazdırToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(165, 100);
      this.contextMenuStrip1.Opening += new CancelEventHandler(this.contextMenuStrip1_Opening);
      this.detayGösterToolStripMenuItem.Name = "detayGösterToolStripMenuItem";
      this.detayGösterToolStripMenuItem.Size = new Size(164, 24);
      this.detayGösterToolStripMenuItem.Text = "Detay Göster";
      this.detayGösterToolStripMenuItem.Click += new EventHandler(this.detayGösterToolStripMenuItem_Click);
      this.silToolStripMenuItem.Name = "silToolStripMenuItem";
      this.silToolStripMenuItem.Size = new Size(164, 24);
      this.silToolStripMenuItem.Text = "Sil";
      this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
      this.düzenleToolStripMenuItem.Size = new Size(164, 24);
      this.düzenleToolStripMenuItem.Text = "Düzenle";
      this.düzenleToolStripMenuItem.Click += new EventHandler(this.düzenleToolStripMenuItem_Click);
      this.yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
      this.yazdırToolStripMenuItem.Size = new Size(164, 24);
      this.yazdırToolStripMenuItem.Text = "Yazdır";
      this.yazdırToolStripMenuItem.Click += new EventHandler(this.yazdırToolStripMenuItem_Click);
      this.panel1.Controls.Add((Control) this.listfiltrelemeturu);
      this.panel1.Location = new Point(12, 60);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(168, 180);
      this.panel1.TabIndex = 22;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1118, 694);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fRapor);
      this.Text = "Raporlama Sayfası";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fRapor_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.GridListe).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
