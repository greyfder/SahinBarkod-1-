// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fBaslangic
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fBaslangic : Form
  {
    private IContainer components = (IContainer) null;
    private TableLayoutPanel tableLayoutPanel1;
    private Button bCıkıs;
    private Button bKullaniciDegistir;
    public Button bSatisislemi;
    public Button bYedekleme;
    public Button bFiyatGuncelle;
    public Button bAyarlar;
    public Button bUrunGiris;
    public Button bStok;
    public Button bGenelRapor;
    internal lstandart lKullanici;
    internal lstandart lisyeri;

    public fBaslangic() => this.InitializeComponent();

    private void bSatisislemi_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      Form1 form1 = new Form1();
      form1.lKullanici.Text = this.lKullanici.Text;
      int num = (int) form1.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void bGenelRapor_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      fRapor fRapor = new fRapor();
      fRapor.lkullanici.Text = this.lKullanici.Text;
      int num = (int) fRapor.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void bStok_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      fStok fStok = new fStok();
      fStok.lkullanici.Text = this.lKullanici.Text;
      int num = (int) fStok.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void bUrunGiris_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      fUrunGiris fUrunGiris = new fUrunGiris();
      fUrunGiris.lkullanici.Text = this.lKullanici.Text;
      int num = (int) fUrunGiris.ShowDialog();
      Cursor.Current = Cursors.Default;
    }

    private void bCıkıs_Click(object sender, EventArgs e) => Application.Exit();

    private void bFiyatGuncelle_Click(object sender, EventArgs e)
    {
      int num = (int) new fFiyatGuncelle().ShowDialog();
    }

    private void bAyarlar_Click(object sender, EventArgs e)
    {
      fAyarlar fAyarlar = new fAyarlar();
      fAyarlar.lKullanici.Text = this.lKullanici.Text;
      int num = (int) fAyarlar.ShowDialog();
    }

    private void bYedekleme_Click(object sender, EventArgs e) => islemler.Backup();

    private void bKullaniciDegistir_Click(object sender, EventArgs e)
    {
      new fLogin().Show();
      this.Hide();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fBaslangic));
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.bCıkıs = new Button();
      this.bKullaniciDegistir = new Button();
      this.bYedekleme = new Button();
      this.bFiyatGuncelle = new Button();
      this.bAyarlar = new Button();
      this.bUrunGiris = new Button();
      this.bStok = new Button();
      this.bGenelRapor = new Button();
      this.bSatisislemi = new Button();
      this.lisyeri = new lstandart();
      this.lKullanici = new lstandart();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333f));
      this.tableLayoutPanel1.Controls.Add((Control) this.bCıkıs, 2, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.bKullaniciDegistir, 1, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.bYedekleme, 0, 2);
      this.tableLayoutPanel1.Controls.Add((Control) this.bFiyatGuncelle, 2, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.bAyarlar, 1, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.bUrunGiris, 0, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.bStok, 2, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.bGenelRapor, 1, 0);
      this.tableLayoutPanel1.Controls.Add((Control) this.bSatisislemi, 0, 0);
      this.tableLayoutPanel1.Location = new Point(27, 41);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel1.Size = new Size(797, 391);
      this.tableLayoutPanel1.TabIndex = 0;
      this.bCıkıs.BackColor = Color.Tomato;
      this.bCıkıs.Dock = DockStyle.Fill;
      this.bCıkıs.FlatAppearance.BorderColor = Color.Tomato;
      this.bCıkıs.FlatStyle = FlatStyle.Flat;
      this.bCıkıs.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bCıkıs.ForeColor = Color.White;
      this.bCıkıs.Image = (Image) Resources.exit4854;
      this.bCıkıs.Location = new Point(533, 263);
      this.bCıkıs.Name = "bCıkıs";
      this.bCıkıs.Size = new Size(261, 125);
      this.bCıkıs.TabIndex = 8;
      this.bCıkıs.Text = "Çıkış";
      this.bCıkıs.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bCıkıs.UseVisualStyleBackColor = false;
      this.bCıkıs.Click += new EventHandler(this.bCıkıs_Click);
      this.bKullaniciDegistir.BackColor = Color.DimGray;
      this.bKullaniciDegistir.Dock = DockStyle.Fill;
      this.bKullaniciDegistir.FlatAppearance.BorderColor = Color.DimGray;
      this.bKullaniciDegistir.FlatStyle = FlatStyle.Flat;
      this.bKullaniciDegistir.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bKullaniciDegistir.ForeColor = Color.White;
      this.bKullaniciDegistir.Image = (Image) Resources.kullanicidegistir32;
      this.bKullaniciDegistir.Location = new Point(268, 263);
      this.bKullaniciDegistir.Name = "bKullaniciDegistir";
      this.bKullaniciDegistir.Size = new Size(259, 125);
      this.bKullaniciDegistir.TabIndex = 7;
      this.bKullaniciDegistir.Text = "Kullanıcı Değiştir";
      this.bKullaniciDegistir.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bKullaniciDegistir.UseVisualStyleBackColor = false;
      this.bKullaniciDegistir.Click += new EventHandler(this.bKullaniciDegistir_Click);
      this.bYedekleme.BackColor = Color.SlateGray;
      this.bYedekleme.Dock = DockStyle.Fill;
      this.bYedekleme.FlatAppearance.BorderColor = Color.SlateGray;
      this.bYedekleme.FlatStyle = FlatStyle.Flat;
      this.bYedekleme.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bYedekleme.ForeColor = Color.White;
      this.bYedekleme.Image = (Image) Resources.backup4854;
      this.bYedekleme.Location = new Point(3, 263);
      this.bYedekleme.Name = "bYedekleme";
      this.bYedekleme.Size = new Size(259, 125);
      this.bYedekleme.TabIndex = 6;
      this.bYedekleme.Text = "Yedekleme";
      this.bYedekleme.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bYedekleme.UseVisualStyleBackColor = false;
      this.bYedekleme.Click += new EventHandler(this.bYedekleme_Click);
      this.bFiyatGuncelle.BackColor = Color.DarkSlateGray;
      this.bFiyatGuncelle.Dock = DockStyle.Fill;
      this.bFiyatGuncelle.FlatAppearance.BorderColor = Color.DarkSlateGray;
      this.bFiyatGuncelle.FlatStyle = FlatStyle.Flat;
      this.bFiyatGuncelle.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bFiyatGuncelle.ForeColor = Color.White;
      this.bFiyatGuncelle.Image = (Image) componentResourceManager.GetObject("bFiyatGuncelle.Image");
      this.bFiyatGuncelle.Location = new Point(533, 133);
      this.bFiyatGuncelle.Name = "bFiyatGuncelle";
      this.bFiyatGuncelle.Size = new Size(261, 124);
      this.bFiyatGuncelle.TabIndex = 5;
      this.bFiyatGuncelle.Text = "Döviz/ Exchange";
      this.bFiyatGuncelle.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bFiyatGuncelle.UseVisualStyleBackColor = false;
      this.bFiyatGuncelle.Click += new EventHandler(this.bFiyatGuncelle_Click);
      this.bAyarlar.BackColor = Color.Sienna;
      this.bAyarlar.Dock = DockStyle.Fill;
      this.bAyarlar.FlatAppearance.BorderColor = Color.Sienna;
      this.bAyarlar.FlatStyle = FlatStyle.Flat;
      this.bAyarlar.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bAyarlar.ForeColor = Color.White;
      this.bAyarlar.Image = (Image) Resources.settings4854;
      this.bAyarlar.Location = new Point(268, 133);
      this.bAyarlar.Name = "bAyarlar";
      this.bAyarlar.Size = new Size(259, 124);
      this.bAyarlar.TabIndex = 4;
      this.bAyarlar.Text = "Ayarlar";
      this.bAyarlar.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bAyarlar.UseVisualStyleBackColor = false;
      this.bAyarlar.Click += new EventHandler(this.bAyarlar_Click);
      this.bUrunGiris.BackColor = Color.DarkGoldenrod;
      this.bUrunGiris.Dock = DockStyle.Fill;
      this.bUrunGiris.FlatAppearance.BorderColor = Color.DarkGoldenrod;
      this.bUrunGiris.FlatStyle = FlatStyle.Flat;
      this.bUrunGiris.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bUrunGiris.ForeColor = Color.White;
      this.bUrunGiris.Image = (Image) Resources.urungiris4854;
      this.bUrunGiris.Location = new Point(3, 133);
      this.bUrunGiris.Name = "bUrunGiris";
      this.bUrunGiris.Size = new Size(259, 124);
      this.bUrunGiris.TabIndex = 3;
      this.bUrunGiris.Text = "Ürün Giriş";
      this.bUrunGiris.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bUrunGiris.UseVisualStyleBackColor = false;
      this.bUrunGiris.Click += new EventHandler(this.bUrunGiris_Click);
      this.bStok.BackColor = Color.DarkCyan;
      this.bStok.Dock = DockStyle.Fill;
      this.bStok.FlatAppearance.BorderColor = Color.DarkCyan;
      this.bStok.FlatStyle = FlatStyle.Flat;
      this.bStok.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bStok.ForeColor = Color.White;
      this.bStok.Image = (Image) Resources.stok4854;
      this.bStok.Location = new Point(533, 3);
      this.bStok.Name = "bStok";
      this.bStok.Size = new Size(261, 124);
      this.bStok.TabIndex = 2;
      this.bStok.Text = "Stok Takibi";
      this.bStok.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bStok.UseVisualStyleBackColor = false;
      this.bStok.Click += new EventHandler(this.bStok_Click);
      this.bGenelRapor.BackColor = Color.ForestGreen;
      this.bGenelRapor.Dock = DockStyle.Fill;
      this.bGenelRapor.FlatAppearance.BorderColor = Color.DeepSkyBlue;
      this.bGenelRapor.FlatStyle = FlatStyle.Flat;
      this.bGenelRapor.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bGenelRapor.ForeColor = Color.White;
      this.bGenelRapor.Image = (Image) Resources.rapor4854;
      this.bGenelRapor.Location = new Point(268, 3);
      this.bGenelRapor.Name = "bGenelRapor";
      this.bGenelRapor.Size = new Size(259, 124);
      this.bGenelRapor.TabIndex = 1;
      this.bGenelRapor.Text = "Genel Rapor";
      this.bGenelRapor.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bGenelRapor.UseVisualStyleBackColor = false;
      this.bGenelRapor.Click += new EventHandler(this.bGenelRapor_Click);
      this.bSatisislemi.BackColor = Color.DeepSkyBlue;
      this.bSatisislemi.Dock = DockStyle.Fill;
      this.bSatisislemi.FlatAppearance.BorderColor = Color.DeepSkyBlue;
      this.bSatisislemi.FlatStyle = FlatStyle.Flat;
      this.bSatisislemi.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.bSatisislemi.ForeColor = Color.White;
      this.bSatisislemi.Image = (Image) Resources.tl4854;
      this.bSatisislemi.Location = new Point(3, 3);
      this.bSatisislemi.Name = "bSatisislemi";
      this.bSatisislemi.Size = new Size(259, 124);
      this.bSatisislemi.TabIndex = 0;
      this.bSatisislemi.Text = "Satış İşlemi";
      this.bSatisislemi.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bSatisislemi.UseVisualStyleBackColor = false;
      this.bSatisislemi.Click += new EventHandler(this.bSatisislemi_Click);
      this.lisyeri.AutoSize = true;
      this.lisyeri.BackColor = Color.Transparent;
      this.lisyeri.Font = new Font("Microsoft Sans Serif", 15f);
      this.lisyeri.ForeColor = Color.White;
      this.lisyeri.Location = new Point(25, 9);
      this.lisyeri.Name = "lisyeri";
      this.lisyeri.Size = new Size(100, 29);
      this.lisyeri.TabIndex = 1;
      this.lisyeri.Text = "kullanıcı";
      this.lKullanici.AutoSize = true;
      this.lKullanici.BackColor = Color.Transparent;
      this.lKullanici.Font = new Font("Microsoft Sans Serif", 12f);
      this.lKullanici.ForeColor = Color.White;
      this.lKullanici.Location = new Point(42, 435);
      this.lKullanici.Name = "lKullanici";
      this.lKullanici.Size = new Size(81, 25);
      this.lKullanici.TabIndex = 1;
      this.lKullanici.Text = "kullanıcı";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Black;
      this.ClientSize = new Size(858, 477);
      this.ControlBox = false;
      this.Controls.Add((Control) this.lisyeri);
      this.Controls.Add((Control) this.lKullanici);
      this.Controls.Add((Control) this.tableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (fBaslangic);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Barkodlu Satış Programı";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
