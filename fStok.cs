// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fStok
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
  public class fStok : Form
  {
    private Barkod1Entities dbx = new Barkod1Entities();
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private Panel panel4;
    private ComboBox cmİslemTuru;
    private lstandart lİslemTuru;
    private bstandart bAra;
    private Panel panelTarihler;
    private DateTimePicker dateBitis;
    private lstandart lBitisTarih;
    private lstandart lBaslangıctarih;
    private DateTimePicker dateBaslangic;
    private Panel panel2;
    private ComboBox cmUrunGrup;
    private lstandart lUrunGrubu;
    private Panel panel1;
    private RadioButton rdUrunGrubu;
    private RadioButton rdTumu;
    private lstandart lFilitreTuru;
    private SplitContainer splitContainer2;
    private tstandart tUrunAra;
    private lstandart lUrunAra;
    private gridozel GridListe;
    private bstandart bRaporAl;
    internal lstandart lkullanici;
    private Button b200;

    public fStok() => this.InitializeComponent();

    private void bAra_Click(object sender, EventArgs e)
    {
      this.GridListe.DataSource = (object) null;
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (this.cmİslemTuru.Text != "")
        {
          string urungrubu = this.cmUrunGrup.Text;
          if (this.cmİslemTuru.SelectedIndex == 0)
          {
            if (this.rdTumu.Checked)
            {
              barkod1Entities.Urun.OrderBy<Urun, double?>((Expression<Func<Urun, double?>>) (x => x.Miktar)).Load();
              this.GridListe.DataSource = (object) barkod1Entities.Urun.Local.ToBindingList<Urun>();
              this.GridListe.Columns["Urunid"].Visible = false;
              this.GridListe.Columns["SatisFiyat2"].Visible = false;
              this.GridListe.Columns["SatisFiyat3"].Visible = false;
              this.GridListe.Columns["SatisFiyat4"].Visible = false;
              this.GridListe.Columns["SatisFiyat5"].Visible = false;
              this.GridListe.Columns["AlisFiyat"].Visible = false;
              this.GridListe.Columns["KdvTutari"].Visible = false;
              this.GridListe.Columns["Acıklama"].Visible = false;
            }
            else if (this.rdUrunGrubu.Checked)
            {
              barkod1Entities.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (x => x.UrunGrup == urungrubu)).OrderBy<Urun, double?>((Expression<Func<Urun, double?>>) (x => x.Miktar)).Load();
              this.GridListe.DataSource = (object) barkod1Entities.Urun.Local.ToBindingList<Urun>();
            }
            else
            {
              int num1 = (int) MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz.");
            }
          }
          else if (this.cmİslemTuru.SelectedIndex == 1)
          {
            DateTime baslangic = DateTime.Parse(this.dateBaslangic.Value.ToShortDateString());
            DateTime bitis = DateTime.Parse(this.dateBitis.Value.ToShortDateString());
            bitis = bitis.AddDays(1.0);
            if (this.rdTumu.Checked)
            {
              this.GridListe.Rows.Clear();
              this.GridListe.Refresh();
              this.GridListe.DataSource = (object) null;
              barkod1Entities.StokHareket.OrderByDescending<StokHareket, DateTime?>((Expression<Func<StokHareket, DateTime?>>) (x => x.Tarih)).Where<StokHareket>((Expression<Func<StokHareket, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis)).Load();
              this.GridListe.DataSource = (object) barkod1Entities.StokHareket.Local.ToBindingList<StokHareket>();
            }
            else if (this.rdUrunGrubu.Checked)
            {
              barkod1Entities.StokHareket.OrderByDescending<StokHareket, DateTime?>((Expression<Func<StokHareket, DateTime?>>) (x => x.Tarih)).Where<StokHareket>((Expression<Func<StokHareket, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis && x.UrunGrup.Contains(urungrubu))).Load();
              this.GridListe.DataSource = (object) barkod1Entities.StokHareket.Local.ToBindingList<StokHareket>();
            }
            else
            {
              int num2 = (int) MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz.");
            }
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Lütfen İşelem Türü Seçiniz.");
        }
      }
      islemler.GridDuzenle((DataGridView) this.GridListe);
    }

    private void fStok_Load(object sender, EventArgs e)
    {
      this.cmUrunGrup.DisplayMember = "UrunGrupAd";
      this.cmUrunGrup.ValueMember = "Id";
      this.cmUrunGrup.DataSource = (object) this.dbx.UrunGrup.ToList<UrunGrup>();
    }

    private void tUrunAra_TextChanged(object sender, EventArgs e)
    {
      if (this.tUrunAra.Text.Length < 2)
        return;
      string urunad = this.tUrunAra.Text;
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (this.cmİslemTuru.SelectedIndex == 0)
        {
          barkod1Entities.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (x => x.UrunAd.Contains(urunad))).Load();
          this.GridListe.DataSource = (object) barkod1Entities.Urun.Local.ToBindingList<Urun>();
        }
        else if (this.cmİslemTuru.SelectedIndex == 1)
        {
          barkod1Entities.StokHareket.Where<StokHareket>((Expression<Func<StokHareket, bool>>) (x => x.UrunAd.Contains(urunad))).Load();
          this.GridListe.DataSource = (object) barkod1Entities.StokHareket.Local.ToBindingList<StokHareket>();
        }
      }
      islemler.GridDuzenle((DataGridView) this.GridListe);
    }

    private void bRaporAl_Click(object sender, EventArgs e)
    {
      if (this.cmİslemTuru.SelectedIndex == 0)
      {
        Raporlar.Baslık = this.cmİslemTuru.Text + " Raporu";
        Raporlar.TarihBaslangic = this.dateBaslangic.Value.ToShortDateString();
        Raporlar.TarihBitis = this.dateBitis.Value.ToShortDateString();
        Raporlar.StokRaporu((DataGridView) this.GridListe);
      }
      else
      {
        if (this.cmİslemTuru.SelectedIndex != 1)
          return;
        Raporlar.Baslık = this.cmİslemTuru.Text + " Raporu";
        Raporlar.TarihBaslangic = this.dateBaslangic.Value.ToShortDateString();
        Raporlar.TarihBitis = this.dateBitis.Value.ToShortDateString();
        Raporlar.StokizlemeRaporu((DataGridView) this.GridListe);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fStok));
      this.splitContainer1 = new SplitContainer();
      this.b200 = new Button();
      this.panel4 = new Panel();
      this.cmİslemTuru = new ComboBox();
      this.lİslemTuru = new lstandart();
      this.bAra = new bstandart();
      this.panelTarihler = new Panel();
      this.dateBitis = new DateTimePicker();
      this.lBitisTarih = new lstandart();
      this.lBaslangıctarih = new lstandart();
      this.dateBaslangic = new DateTimePicker();
      this.panel2 = new Panel();
      this.cmUrunGrup = new ComboBox();
      this.lUrunGrubu = new lstandart();
      this.panel1 = new Panel();
      this.rdUrunGrubu = new RadioButton();
      this.rdTumu = new RadioButton();
      this.lFilitreTuru = new lstandart();
      this.splitContainer2 = new SplitContainer();
      this.lkullanici = new lstandart();
      this.bRaporAl = new bstandart();
      this.tUrunAra = new tstandart();
      this.lUrunAra = new lstandart();
      this.GridListe = new gridozel();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panelTarihler.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((ISupportInitialize) this.GridListe).BeginInit();
      this.SuspendLayout();
      this.splitContainer1.BackColor = SystemColors.ButtonFace;
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Margin = new Padding(0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.BackColor = SystemColors.ButtonFace;
      this.splitContainer1.Panel1.Controls.Add((Control) this.b200);
      this.splitContainer1.Panel1.Controls.Add((Control) this.panel4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bAra);
      this.splitContainer1.Panel1.Controls.Add((Control) this.panelTarihler);
      this.splitContainer1.Panel1.Controls.Add((Control) this.panel2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.panel1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Size = new Size(1100, 599);
      this.splitContainer1.SplitterDistance = 293;
      this.splitContainer1.TabIndex = 0;
      this.b200.BackColor = Color.DimGray;
      this.b200.FlatAppearance.BorderColor = Color.DimGray;
      this.b200.FlatStyle = FlatStyle.Flat;
      this.b200.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b200.ForeColor = Color.White;
      this.b200.Image = (Image) Resources.exit4854;
      this.b200.Location = new Point(6, 536);
      this.b200.Margin = new Padding(1);
      this.b200.Name = "b200";
      this.b200.Size = new Size(130, 53);
      this.b200.TabIndex = 7;
      this.b200.UseVisualStyleBackColor = false;
      this.b200.Click += new EventHandler(this.b200_Click);
      this.panel4.Controls.Add((Control) this.cmİslemTuru);
      this.panel4.Controls.Add((Control) this.lİslemTuru);
      this.panel4.Location = new Point(3, 3);
      this.panel4.Margin = new Padding(0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(282, 69);
      this.panel4.TabIndex = 6;
      this.cmİslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmİslemTuru.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cmİslemTuru.FormattingEnabled = true;
      this.cmİslemTuru.Items.AddRange(new object[2]
      {
        (object) "Stok Durumu:",
        (object) "Stok Giriş İzleme:"
      });
      this.cmİslemTuru.Location = new Point(22, 34);
      this.cmİslemTuru.Name = "cmİslemTuru";
      this.cmİslemTuru.Size = new Size(257, 32);
      this.cmİslemTuru.TabIndex = 1;
      this.lİslemTuru.AutoSize = true;
      this.lİslemTuru.Font = new Font("Microsoft Sans Serif", 12f);
      this.lİslemTuru.ForeColor = Color.OrangeRed;
      this.lİslemTuru.Location = new Point(17, 6);
      this.lİslemTuru.Name = "lİslemTuru";
      this.lİslemTuru.Size = new Size(110, 25);
      this.lİslemTuru.TabIndex = 0;
      this.lİslemTuru.Text = "İşlem Türü:";
      this.bAra.BackColor = Color.Tomato;
      this.bAra.FlatAppearance.BorderColor = Color.Tomato;
      this.bAra.FlatStyle = FlatStyle.Flat;
      this.bAra.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bAra.ForeColor = SystemColors.ButtonHighlight;
      this.bAra.Image = (Image) Resources.ara3232;
      this.bAra.Location = new Point(140, 413);
      this.bAra.Margin = new Padding(1);
      this.bAra.Name = "bAra";
      this.bAra.Size = new Size(142, 69);
      this.bAra.TabIndex = 0;
      this.bAra.Text = "ARA";
      this.bAra.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bAra.UseVisualStyleBackColor = false;
      this.bAra.Click += new EventHandler(this.bAra_Click);
      this.panelTarihler.Controls.Add((Control) this.dateBitis);
      this.panelTarihler.Controls.Add((Control) this.lBitisTarih);
      this.panelTarihler.Controls.Add((Control) this.lBaslangıctarih);
      this.panelTarihler.Controls.Add((Control) this.dateBaslangic);
      this.panelTarihler.Location = new Point(0, 269);
      this.panelTarihler.Name = "panelTarihler";
      this.panelTarihler.Size = new Size(285, 140);
      this.panelTarihler.TabIndex = 5;
      this.dateBitis.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateBitis.Location = new Point(22, 108);
      this.dateBitis.Name = "dateBitis";
      this.dateBitis.Size = new Size(260, 29);
      this.dateBitis.TabIndex = 3;
      this.lBitisTarih.AutoSize = true;
      this.lBitisTarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBitisTarih.ForeColor = Color.DarkCyan;
      this.lBitisTarih.Location = new Point(17, 80);
      this.lBitisTarih.Name = "lBitisTarih";
      this.lBitisTarih.Size = new Size(108, 25);
      this.lBitisTarih.TabIndex = 2;
      this.lBitisTarih.Text = "Bitiş Tarihi:";
      this.lBaslangıctarih.AutoSize = true;
      this.lBaslangıctarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBaslangıctarih.ForeColor = Color.DarkCyan;
      this.lBaslangıctarih.Location = new Point(17, 12);
      this.lBaslangıctarih.Name = "lBaslangıctarih";
      this.lBaslangıctarih.Size = new Size(157, 25);
      this.lBaslangıctarih.TabIndex = 1;
      this.lBaslangıctarih.Text = "Başlangıç Tarihi:";
      this.dateBaslangic.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dateBaslangic.Location = new Point(22, 40);
      this.dateBaslangic.Name = "dateBaslangic";
      this.dateBaslangic.Size = new Size(260, 29);
      this.dateBaslangic.TabIndex = 0;
      this.panel2.Controls.Add((Control) this.cmUrunGrup);
      this.panel2.Controls.Add((Control) this.lUrunGrubu);
      this.panel2.Location = new Point(0, 189);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(285, 74);
      this.panel2.TabIndex = 4;
      this.cmUrunGrup.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmUrunGrup.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cmUrunGrup.FormattingEnabled = true;
      this.cmUrunGrup.Location = new Point(22, 32);
      this.cmUrunGrup.Name = "cmUrunGrup";
      this.cmUrunGrup.Size = new Size(260, 32);
      this.cmUrunGrup.TabIndex = 1;
      this.lUrunGrubu.AutoSize = true;
      this.lUrunGrubu.Font = new Font("Microsoft Sans Serif", 12f);
      this.lUrunGrubu.ForeColor = Color.DarkCyan;
      this.lUrunGrubu.Location = new Point(17, 4);
      this.lUrunGrubu.Name = "lUrunGrubu";
      this.lUrunGrubu.Size = new Size(119, 25);
      this.lUrunGrubu.TabIndex = 0;
      this.lUrunGrubu.Text = "Ürün Grubu:";
      this.panel1.Controls.Add((Control) this.rdUrunGrubu);
      this.panel1.Controls.Add((Control) this.rdTumu);
      this.panel1.Controls.Add((Control) this.lFilitreTuru);
      this.panel1.Location = new Point(3, 75);
      this.panel1.Margin = new Padding(0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(282, 108);
      this.panel1.TabIndex = 3;
      this.rdUrunGrubu.AutoSize = true;
      this.rdUrunGrubu.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.rdUrunGrubu.ForeColor = Color.DarkCyan;
      this.rdUrunGrubu.Location = new Point(19, 68);
      this.rdUrunGrubu.Name = "rdUrunGrubu";
      this.rdUrunGrubu.Size = new Size(200, 28);
      this.rdUrunGrubu.TabIndex = 4;
      this.rdUrunGrubu.TabStop = true;
      this.rdUrunGrubu.Text = "Ürün Grubuna Göre:";
      this.rdUrunGrubu.UseVisualStyleBackColor = true;
      this.rdTumu.AutoSize = true;
      this.rdTumu.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.rdTumu.ForeColor = Color.DarkCyan;
      this.rdTumu.Location = new Point(19, 37);
      this.rdTumu.Name = "rdTumu";
      this.rdTumu.Size = new Size(78, 28);
      this.rdTumu.TabIndex = 3;
      this.rdTumu.TabStop = true;
      this.rdTumu.Text = "Tümü";
      this.rdTumu.UseVisualStyleBackColor = true;
      this.lFilitreTuru.AutoSize = true;
      this.lFilitreTuru.Font = new Font("Microsoft Sans Serif", 12f);
      this.lFilitreTuru.ForeColor = Color.OrangeRed;
      this.lFilitreTuru.Location = new Point(17, 9);
      this.lFilitreTuru.Name = "lFilitreTuru";
      this.lFilitreTuru.Size = new Size(152, 25);
      this.lFilitreTuru.TabIndex = 2;
      this.lFilitreTuru.Text = "Filitreleme Türü:";
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.FixedPanel = FixedPanel.Panel1;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Margin = new Padding(0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Orientation = Orientation.Horizontal;
      this.splitContainer2.Panel1.BackColor = SystemColors.ButtonFace;
      this.splitContainer2.Panel1.Controls.Add((Control) this.lkullanici);
      this.splitContainer2.Panel1.Controls.Add((Control) this.bRaporAl);
      this.splitContainer2.Panel1.Controls.Add((Control) this.tUrunAra);
      this.splitContainer2.Panel1.Controls.Add((Control) this.lUrunAra);
      this.splitContainer2.Panel2.Controls.Add((Control) this.GridListe);
      this.splitContainer2.Size = new Size(803, 599);
      this.splitContainer2.SplitterDistance = 55;
      this.splitContainer2.TabIndex = 0;
      this.lkullanici.AutoSize = true;
      this.lkullanici.Font = new Font("Microsoft Sans Serif", 12f);
      this.lkullanici.ForeColor = Color.DarkCyan;
      this.lkullanici.Location = new Point(528, 27);
      this.lkullanici.Name = "lkullanici";
      this.lkullanici.Size = new Size(81, 25);
      this.lkullanici.TabIndex = 21;
      this.lkullanici.Text = "kullanıcı";
      this.bRaporAl.BackColor = Color.Red;
      this.bRaporAl.FlatAppearance.BorderColor = Color.Red;
      this.bRaporAl.FlatStyle = FlatStyle.Flat;
      this.bRaporAl.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bRaporAl.ForeColor = SystemColors.ButtonHighlight;
      this.bRaporAl.Location = new Point(632, 9);
      this.bRaporAl.Margin = new Padding(1);
      this.bRaporAl.Name = "bRaporAl";
      this.bRaporAl.Size = new Size(122, 45);
      this.bRaporAl.TabIndex = 20;
      this.bRaporAl.Text = "Rapor Al";
      this.bRaporAl.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bRaporAl.UseVisualStyleBackColor = false;
      this.bRaporAl.Click += new EventHandler(this.bRaporAl_Click);
      this.tUrunAra.BackColor = Color.White;
      this.tUrunAra.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunAra.Location = new Point(134, 16);
      this.tUrunAra.Name = "tUrunAra";
      this.tUrunAra.Size = new Size(331, 29);
      this.tUrunAra.TabIndex = 1;
      this.tUrunAra.TextChanged += new EventHandler(this.tUrunAra_TextChanged);
      this.lUrunAra.AutoSize = true;
      this.lUrunAra.Font = new Font("Microsoft Sans Serif", 12f);
      this.lUrunAra.ForeColor = Color.DarkCyan;
      this.lUrunAra.Location = new Point(17, 20);
      this.lUrunAra.Name = "lUrunAra";
      this.lUrunAra.Size = new Size(96, 25);
      this.lUrunAra.TabIndex = 0;
      this.lUrunAra.Text = "Ürün Ara:";
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
      this.GridListe.Size = new Size(803, 540);
      this.GridListe.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1100, 599);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fStok);
      this.Text = "Stok Takip";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fStok_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panelTarihler.ResumeLayout(false);
      this.panelTarihler.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((ISupportInitialize) this.GridListe).EndInit();
      this.ResumeLayout(false);
    }

    public class ProductContext : DbContext
    {
      public DbSet<Urun> Categories { get; set; }

      public DbSet<CokluB> Products { get; set; }
    }
  }
}
