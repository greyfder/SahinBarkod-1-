// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fAyarlar
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fAyarlar : Form
  {
    private IContainer components = (IContainer) null;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private SplitContainer splitContainer1;
    private CheckBox chYedekleme;
    private CheckBox chStok;
    private CheckBox chAyarlar;
    private CheckBox chUrunGiris;
    private CheckBox chRapor;
    private CheckBox chSatisEkrani;
    private lstandart lstandart8;
    private bstandart biptal;
    private bstandart bKaydet;
    private MaskedTextBox tTelefon;
    private tstandart tSifreTekrar;
    private tstandart tSifre;
    private lstandart lstandart7;
    private lstandart lstandart6;
    private tstandart tKullaniciAdi;
    private lstandart lstandart5;
    private tstandart tEPosta;
    private lstandart lstandart4;
    private lstandart lstandart3;
    private tstandart tAdSoyad;
    private lstandart lstandart2;
    private lstandart lstandart1;
    private gridozel GridListeKulanici;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem düzenleToolStripMenuItem;
    private ToolStripMenuItem silToolStripMenuItem;
    private lstandart lkullaniciid;
    private lstandart lstandart9;
    private Panel panel1;
    private CheckBox chYazmaDurumu;
    private lstandart lstandart10;
    private Panel panel2;
    private tnumeric tKartKomisyon;
    private Button bGelirEkle;
    private lstandart lstandart11;
    private Panel panel3;
    private ComboBox cmbTeraziOnEk;
    private Button bTeraziOnEk;
    private tnumeric tTeraziOnEk;
    private Button bTeraziOnEkSil;
    private lstandart lstandart19;
    private bstandart bisyerikaydet;
    private MaskedTextBox mskisyeritelefon;
    private tstandart tisyerieposta;
    private lstandart lstandart20;
    private lstandart lstandart21;
    private tstandart tisyeriadres;
    private tstandart tisyeriunvan;
    private tstandart tisyeriadsoyad;
    private lstandart lstandart22;
    private lstandart lstandart18;
    private lstandart lstandart24;
    private lstandart lstandart23;
    private TabPage tabPage3;
    private lstandart lstandart12;
    private bstandart bYedektenYukle;
    internal lstandart lKullanici;
    private lstandart lstandart13;
    private bstandart bKullanılmayan;

    public fAyarlar() => this.InitializeComponent();

    private void temizle()
    {
      this.tAdSoyad.Clear();
      this.tTelefon.Clear();
      this.tEPosta.Clear();
      this.tKullaniciAdi.Clear();
      this.tSifre.Clear();
      this.tSifreTekrar.Clear();
      this.chSatisEkrani.Checked = false;
      this.chRapor.Checked = false;
      this.chStok.Checked = false;
      this.chUrunGiris.Checked = false;
      this.chAyarlar.Checked = false;
      this.chYedekleme.Checked = false;
    }

    private void bKaydet_Click(object sender, EventArgs e)
    {
      if (this.bKaydet.Text == "KAYDET")
      {
        if (this.tAdSoyad.Text != "" && this.tKullaniciAdi.Text != "" && this.tSifre.Text != "" && this.tSifreTekrar.Text != "")
        {
          if (this.tSifre.Text == this.tSifreTekrar.Text)
          {
            try
            {
              using (Barkod1Entities barkod1Entities = new Barkod1Entities())
              {
                if (!barkod1Entities.Kullanici.Any<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.KullaniciAd == this.tKullaniciAdi.Text)))
                {
                  barkod1Entities.Kullanici.Add(new Kullanici()
                  {
                    AdSoyad = this.tAdSoyad.Text,
                    Telefon = this.tTelefon.Text,
                    EPosta = this.tEPosta.Text,
                    KullaniciAd = this.tKullaniciAdi.Text.Trim(),
                    Sifre = this.tSifre.Text,
                    Satis = new bool?(this.chSatisEkrani.Checked),
                    Rapor = new bool?(this.chRapor.Checked),
                    Stok = new bool?(this.chStok.Checked),
                    UrunGiris = new bool?(this.chUrunGiris.Checked),
                    Ayarlar = new bool?(this.chAyarlar.Checked),
                    Yedekleme = new bool?(this.chYedekleme.Checked)
                  });
                  barkod1Entities.SaveChanges();
                  this.doldur();
                  this.temizle();
                }
                else
                {
                  int num = (int) MessageBox.Show("Bu Kullanıcı Zaten Kayıtlı.");
                }
              }
            }
            catch (Exception ex)
            {
              int num = (int) MessageBox.Show(ex.ToString());
            }
          }
          else
          {
            int num1 = (int) MessageBox.Show("Şifreler Uyuşmuyor.");
          }
        }
        else
        {
          int num2 = (int) MessageBox.Show("Lütfen ** ile Belirtilen Zorunlu Alanları Doldurun.\nAd Soyad\nKullanıcı Adı\nŞifre\nŞifre Tekrar");
        }
      }
      else
      {
        if (!(this.bKaydet.Text == "Düzenle/Kaydet"))
          return;
        if (this.tAdSoyad.Text != "" && this.tKullaniciAdi.Text != "" && this.tSifre.Text != "" && this.tSifreTekrar.Text != "")
        {
          if (this.tSifre.Text == this.tSifreTekrar.Text)
          {
            int id = Convert.ToInt32(this.lkullaniciid.Text);
            using (Barkod1Entities barkod1Entities = new Barkod1Entities())
            {
              Kullanici kullanici = barkod1Entities.Kullanici.Where<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.Id == id)).FirstOrDefault<Kullanici>();
              kullanici.AdSoyad = this.tAdSoyad.Text;
              kullanici.Telefon = this.tTelefon.Text;
              kullanici.EPosta = this.tEPosta.Text;
              kullanici.KullaniciAd = this.tKullaniciAdi.Text.Trim();
              kullanici.Sifre = this.tSifre.Text;
              kullanici.Satis = new bool?(this.chSatisEkrani.Checked);
              kullanici.Rapor = new bool?(this.chRapor.Checked);
              kullanici.Stok = new bool?(this.chStok.Checked);
              kullanici.UrunGiris = new bool?(this.chUrunGiris.Checked);
              kullanici.Ayarlar = new bool?(this.chAyarlar.Checked);
              kullanici.Yedekleme = new bool?(this.chYedekleme.Checked);
              barkod1Entities.SaveChanges();
              int num3 = (int) MessageBox.Show("Güncelleme Yapılmıştır");
              this.doldur();
              this.temizle();
              this.bKaydet.Text = "KAYDET";
            }
          }
          else
          {
            int num4 = (int) MessageBox.Show("Şifreler Uyuşmuyor.");
          }
        }
        else
        {
          int num5 = (int) MessageBox.Show("Lütfen ** ile Belirtilen Zorunlu Alanları Doldurun.\nAd Soyad\nKullanıcı Adı\nŞifre\nŞifre Tekrar");
        }
      }
    }

    private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.GridListeKulanici.Rows.Count > 0)
      {
        int id = Convert.ToInt32(this.GridListeKulanici.CurrentRow.Cells["Id"].Value.ToString());
        this.lkullaniciid.Text = id.ToString();
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          Kullanici kullanici = barkod1Entities.Kullanici.Where<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.Id == id)).FirstOrDefault<Kullanici>();
          this.tAdSoyad.Text = kullanici.AdSoyad;
          this.tTelefon.Text = kullanici.Telefon;
          this.tEPosta.Text = kullanici.EPosta;
          this.tKullaniciAdi.Text = kullanici.KullaniciAd;
          this.tSifre.Text = kullanici.Sifre;
          this.tSifreTekrar.Text = kullanici.Sifre;
          this.chSatisEkrani.Checked = kullanici.Satis.Value;
          CheckBox chRapor = this.chRapor;
          bool? nullable = kullanici.Rapor;
          int num1 = nullable.Value ? 1 : 0;
          chRapor.Checked = num1 != 0;
          CheckBox chStok = this.chStok;
          nullable = kullanici.Stok;
          int num2 = nullable.Value ? 1 : 0;
          chStok.Checked = num2 != 0;
          CheckBox chUrunGiris = this.chUrunGiris;
          nullable = kullanici.UrunGiris;
          int num3 = nullable.Value ? 1 : 0;
          chUrunGiris.Checked = num3 != 0;
          CheckBox chAyarlar = this.chAyarlar;
          nullable = kullanici.Ayarlar;
          int num4 = nullable.Value ? 1 : 0;
          chAyarlar.Checked = num4 != 0;
          CheckBox chYedekleme = this.chYedekleme;
          nullable = kullanici.Yedekleme;
          int num5 = nullable.Value ? 1 : 0;
          chYedekleme.Checked = num5 != 0;
          this.bKaydet.Text = "Düzenle/Kaydet";
          this.doldur();
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Kullanıcı Seçiniz.");
      }
    }

    private void fAyarlar_Load(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      this.doldur();
      Cursor.Current = Cursors.Default;
    }

    private void doldur()
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (barkod1Entities.Kullanici.Any<Kullanici>())
          this.GridListeKulanici.DataSource = (object) barkod1Entities.Kullanici.Select(x => new
          {
            Id = x.Id,
            AdSoyad = x.AdSoyad,
            KullaniciAd = x.KullaniciAd,
            Telefon = x.Telefon
          }).ToList();
        islemler.SabitVarsayilan();
        this.chYazmaDurumu.Checked = barkod1Entities.Sabit.FirstOrDefault<Sabit>().Yazici.Value;
        Sabit sabit = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
        this.tKartKomisyon.Text = sabit.KartKomisyon.ToString();
        List<Terazi> list = barkod1Entities.Terazi.ToList<Terazi>();
        this.cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
        this.cmbTeraziOnEk.ValueMember = "Id";
        this.cmbTeraziOnEk.DataSource = (object) list;
        this.tisyeriadsoyad.Text = sabit.AdSoyad;
        this.tisyeriunvan.Text = sabit.Unvan;
        this.tisyeriadres.Text = sabit.Adres;
        this.mskisyeritelefon.Text = sabit.Telefon;
        this.tisyerieposta.Text = sabit.EPosta;
      }
    }

    private void silToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int id = (int) Convert.ToInt16(this.GridListeKulanici.CurrentRow.Cells["Id"].Value.ToString());
      if (MessageBox.Show(this.GridListeKulanici.CurrentRow.Cells["AdSoyad"].Value.ToString() + "Kullanıcısını Silmek İstiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        Kullanici entity = barkod1Entities.Kullanici.FirstOrDefault<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.Id == id));
        barkod1Entities.Kullanici.Remove(entity);
        barkod1Entities.SaveChanges();
        this.doldur();
      }
    }

    private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (this.chYazmaDurumu.Checked)
        {
          islemler.SabitVarsayilan();
          barkod1Entities.Sabit.FirstOrDefault<Sabit>().Yazici = new bool?(true);
          barkod1Entities.SaveChanges();
          this.chYazmaDurumu.Text = "Yazma Durumu AKTİF";
        }
        else
        {
          islemler.SabitVarsayilan();
          barkod1Entities.Sabit.FirstOrDefault<Sabit>().Yazici = new bool?(false);
          barkod1Entities.SaveChanges();
          this.chYazmaDurumu.Text = "Yazma Durumu PASİF";
        }
      }
    }

    private void bGelirEkle_Click(object sender, EventArgs e)
    {
      if (this.tKartKomisyon.Text != "")
      {
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          barkod1Entities.Sabit.FirstOrDefault<Sabit>().KartKomisyon = new int?((int) Convert.ToInt16(this.tKartKomisyon.Text));
          barkod1Entities.SaveChanges();
          int num = (int) MessageBox.Show("Kart Komisyon Ayarlandı.");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Kart Komisyon Bilgisi Giriniz");
      }
    }

    private void bTeraziOnEk_Click(object sender, EventArgs e)
    {
      int OnEk = (int) Convert.ToInt16(this.tTeraziOnEk.Text);
      if (this.tTeraziOnEk.Text != "")
      {
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          if (barkod1Entities.Terazi.Any<Terazi>((Expression<Func<Terazi, bool>>) (x => x.Id == OnEk)))
          {
            int num1 = (int) MessageBox.Show(OnEk.ToString() + "Önek zaten kayıtlı");
          }
          else
          {
            barkod1Entities.Terazi.Add(new Terazi()
            {
              TeraziOnEk = new int?(OnEk)
            });
            barkod1Entities.SaveChanges();
            this.cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
            this.cmbTeraziOnEk.ValueMember = "Id";
            this.cmbTeraziOnEk.DataSource = (object) barkod1Entities.Terazi.ToList<Terazi>();
            this.tTeraziOnEk.Clear();
            int num2 = (int) MessageBox.Show("Bilgiler Kaydedildi.");
          }
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Terazi Ön Ek Bilgisi Giriniz.");
      }
    }

    private void bTeraziOnEkSil_Click(object sender, EventArgs e)
    {
      if (this.cmbTeraziOnEk.Text != "")
      {
        int int16 = (int) Convert.ToInt16(this.cmbTeraziOnEk.SelectedValue);
        if (MessageBox.Show(this.cmbTeraziOnEk.Text + " Oneki Silmek İstiyor Musunuz?", "Terazi Önek Silme İşlemi", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          Terazi entity = barkod1Entities.Terazi.Find(new object[1]
          {
            (object) int16
          });
          barkod1Entities.Terazi.Remove(entity);
          barkod1Entities.SaveChanges();
          this.cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
          this.cmbTeraziOnEk.ValueMember = "Id";
          this.cmbTeraziOnEk.DataSource = (object) barkod1Entities.Terazi.ToList<Terazi>();
          this.tTeraziOnEk.Clear();
          int num = (int) MessageBox.Show("Önek Silinmiştir.");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Önek Seçiniz.");
      }
    }

    private void tisyeriunvan_TextChanged(object sender, EventArgs e)
    {
    }

    private void bisyerikaydet_Click(object sender, EventArgs e)
    {
      if (!(this.tisyeriadsoyad.Text != "") || !(this.tisyeriunvan.Text != "") || !(this.tisyeriadres.Text != "") || !(this.mskisyeritelefon.Text != ""))
        return;
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        Sabit sabit1 = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
        sabit1.AdSoyad = this.tisyeriadsoyad.Text;
        sabit1.Unvan = this.tisyeriunvan.Text;
        sabit1.Adres = this.tisyeriadres.Text;
        sabit1.Telefon = this.mskisyeritelefon.Text;
        sabit1.EPosta = this.tisyerieposta.Text;
        barkod1Entities.SaveChanges();
        int num = (int) MessageBox.Show("İşyeri Bilgileri Kaydedilmiştir.");
        Sabit sabit2 = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
        this.tisyeriadsoyad.Text = sabit2.AdSoyad;
        this.tisyeriunvan.Text = sabit2.Unvan;
        this.tisyeriadres.Text = sabit2.Adres;
        this.mskisyeritelefon.Text = sabit2.Telefon;
        this.tisyerieposta.Text = sabit2.EPosta;
      }
    }

    private void bYedektenYukle_Click(object sender, EventArgs e)
    {
      Process.Start(Application.StartupPath + "\\ProgramRestore.exe");
      Application.Exit();
    }

    private void bKullanılmayan_Click(object sender, EventArgs e)
    {
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        if (MessageBox.Show("!! Lütfen Dikkat: \n Ürün fiyat düzenlemelerinin TAMAMINI yaptıysanız \n Bu işlemi onaylayınız.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
          return;
        Cursor.Current = Cursors.WaitCursor;
        IQueryable<Urun> source = barkod1Entities.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (x => x.Onay == (bool?) false));
        Expression<Func<Urun, int>> selector = (Expression<Func<Urun, int>>) (x => x.Urunid);
        foreach (int num in source.Select<Urun, int>(selector).ToList<int>())
        {
          int item = num;
          List<CokluB> list = barkod1Entities.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (x => x.Urunid == (int?) item)).ToList<CokluB>();
          barkod1Entities.CokluB.RemoveRange((IEnumerable<CokluB>) list);
          barkod1Entities.SaveChanges();
        }
        barkod1Entities.Urun.RemoveRange((IEnumerable<Urun>) barkod1Entities.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (x => x.Onay == (bool?) false)));
        barkod1Entities.SaveChanges();
        int num1 = (int) MessageBox.Show("Kullanılmayan ürünler silindi.");
        Cursor.Current = Cursors.Default;
      }
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fAyarlar));
      this.tabControl1 = new TabControl();
      this.tabPage1 = new TabPage();
      this.splitContainer1 = new SplitContainer();
      this.lKullanici = new lstandart();
      this.lkullaniciid = new lstandart();
      this.chYedekleme = new CheckBox();
      this.chStok = new CheckBox();
      this.chAyarlar = new CheckBox();
      this.chUrunGiris = new CheckBox();
      this.chRapor = new CheckBox();
      this.chSatisEkrani = new CheckBox();
      this.lstandart8 = new lstandart();
      this.biptal = new bstandart();
      this.bKaydet = new bstandart();
      this.tTelefon = new MaskedTextBox();
      this.tSifreTekrar = new tstandart();
      this.tSifre = new tstandart();
      this.lstandart7 = new lstandart();
      this.lstandart6 = new lstandart();
      this.tKullaniciAdi = new tstandart();
      this.lstandart5 = new lstandart();
      this.tEPosta = new tstandart();
      this.lstandart4 = new lstandart();
      this.lstandart3 = new lstandart();
      this.tAdSoyad = new tstandart();
      this.lstandart2 = new lstandart();
      this.lstandart1 = new lstandart();
      this.GridListeKulanici = new gridozel();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.düzenleToolStripMenuItem = new ToolStripMenuItem();
      this.silToolStripMenuItem = new ToolStripMenuItem();
      this.tabPage2 = new TabPage();
      this.lstandart24 = new lstandart();
      this.lstandart23 = new lstandart();
      this.lstandart19 = new lstandart();
      this.bisyerikaydet = new bstandart();
      this.mskisyeritelefon = new MaskedTextBox();
      this.tisyerieposta = new tstandart();
      this.lstandart20 = new lstandart();
      this.lstandart21 = new lstandart();
      this.tisyeriadres = new tstandart();
      this.tisyeriunvan = new tstandart();
      this.tisyeriadsoyad = new tstandart();
      this.lstandart22 = new lstandart();
      this.lstandart18 = new lstandart();
      this.lstandart11 = new lstandart();
      this.panel3 = new Panel();
      this.bTeraziOnEkSil = new Button();
      this.tTeraziOnEk = new tnumeric();
      this.bTeraziOnEk = new Button();
      this.cmbTeraziOnEk = new ComboBox();
      this.lstandart10 = new lstandart();
      this.panel2 = new Panel();
      this.bGelirEkle = new Button();
      this.tKartKomisyon = new tnumeric();
      this.lstandart9 = new lstandart();
      this.panel1 = new Panel();
      this.chYazmaDurumu = new CheckBox();
      this.tabPage3 = new TabPage();
      this.lstandart13 = new lstandart();
      this.bKullanılmayan = new bstandart();
      this.lstandart12 = new lstandart();
      this.bYedektenYukle = new bstandart();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.GridListeKulanici).BeginInit();
      this.contextMenuStrip1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.SuspendLayout();
      this.tabControl1.Controls.Add((Control) this.tabPage1);
      this.tabControl1.Controls.Add((Control) this.tabPage2);
      this.tabControl1.Controls.Add((Control) this.tabPage3);
      this.tabControl1.Dock = DockStyle.Fill;
      this.tabControl1.Location = new Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new Size(1067, 583);
      this.tabControl1.TabIndex = 0;
      this.tabPage1.Controls.Add((Control) this.splitContainer1);
      this.tabPage1.Location = new Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new Padding(3);
      this.tabPage1.Size = new Size(1059, 554);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "KULLANICI";
      this.tabPage1.UseVisualStyleBackColor = true;
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(3, 3);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.lKullanici);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lkullaniciid);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chYedekleme);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chStok);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chAyarlar);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chUrunGiris);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chRapor);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chSatisEkrani);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart8);
      this.splitContainer1.Panel1.Controls.Add((Control) this.biptal);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bKaydet);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tTelefon);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSifreTekrar);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSifre);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart7);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart6);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tKullaniciAdi);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart5);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tEPosta);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tAdSoyad);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridListeKulanici);
      this.splitContainer1.Size = new Size(1053, 548);
      this.splitContainer1.SplitterDistance = 548;
      this.splitContainer1.TabIndex = 0;
      this.lKullanici.AutoSize = true;
      this.lKullanici.Font = new Font("Microsoft Sans Serif", 12f);
      this.lKullanici.ForeColor = Color.DarkCyan;
      this.lKullanici.Location = new Point(29, 564);
      this.lKullanici.Name = "lKullanici";
      this.lKullanici.Size = new Size(85, 25);
      this.lKullanici.TabIndex = 15;
      this.lKullanici.Text = "Kullanıcı";
      this.lkullaniciid.AutoSize = true;
      this.lkullaniciid.Font = new Font("Microsoft Sans Serif", 12f);
      this.lkullaniciid.ForeColor = Color.DarkCyan;
      this.lkullaniciid.Location = new Point(278, 33);
      this.lkullaniciid.Name = "lkullaniciid";
      this.lkullaniciid.Size = new Size(97, 25);
      this.lkullaniciid.TabIndex = 14;
      this.lkullaniciid.Text = "lstandart9";
      this.lkullaniciid.Visible = false;
      this.chYedekleme.AutoSize = true;
      this.chYedekleme.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chYedekleme.Location = new Point(396, 291);
      this.chYedekleme.Name = "chYedekleme";
      this.chYedekleme.Size = new Size(129, 29);
      this.chYedekleme.TabIndex = 11;
      this.chYedekleme.Text = "Yedekleme";
      this.chYedekleme.UseVisualStyleBackColor = true;
      this.chStok.AutoSize = true;
      this.chStok.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chStok.Location = new Point(396, 183);
      this.chStok.Name = "chStok";
      this.chStok.Size = new Size(131, 29);
      this.chStok.TabIndex = 8;
      this.chStok.Text = "Stok Ekranı";
      this.chStok.UseVisualStyleBackColor = true;
      this.chAyarlar.AutoSize = true;
      this.chAyarlar.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chAyarlar.Location = new Point(396, 256);
      this.chAyarlar.Name = "chAyarlar";
      this.chAyarlar.Size = new Size(93, 29);
      this.chAyarlar.TabIndex = 10;
      this.chAyarlar.Text = "Ayarlar";
      this.chAyarlar.UseVisualStyleBackColor = true;
      this.chUrunGiris.AutoSize = true;
      this.chUrunGiris.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chUrunGiris.Location = new Point(396, 221);
      this.chUrunGiris.Name = "chUrunGiris";
      this.chUrunGiris.Size = new Size(117, 29);
      this.chUrunGiris.TabIndex = 9;
      this.chUrunGiris.Text = "Ürün Giriş";
      this.chUrunGiris.UseVisualStyleBackColor = true;
      this.chRapor.AutoSize = true;
      this.chRapor.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chRapor.Location = new Point(396, 148);
      this.chRapor.Name = "chRapor";
      this.chRapor.Size = new Size(143, 29);
      this.chRapor.TabIndex = 7;
      this.chRapor.Text = "Rapor Ekranı";
      this.chRapor.UseVisualStyleBackColor = true;
      this.chSatisEkrani.AutoSize = true;
      this.chSatisEkrani.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chSatisEkrani.Location = new Point(396, 113);
      this.chSatisEkrani.Name = "chSatisEkrani";
      this.chSatisEkrani.Size = new Size(135, 29);
      this.chSatisEkrani.TabIndex = 6;
      this.chSatisEkrani.Text = "Satış Ekranı";
      this.chSatisEkrani.UseVisualStyleBackColor = true;
      this.lstandart8.AutoSize = true;
      this.lstandart8.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart8.ForeColor = Color.DarkCyan;
      this.lstandart8.Location = new Point(391, 75);
      this.lstandart8.Name = "lstandart8";
      this.lstandart8.Size = new Size(107, 25);
      this.lstandart8.TabIndex = 12;
      this.lstandart8.Text = "YETKİLER";
      this.biptal.BackColor = Color.DimGray;
      this.biptal.FlatAppearance.BorderColor = Color.DimGray;
      this.biptal.FlatStyle = FlatStyle.Flat;
      this.biptal.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.biptal.ForeColor = SystemColors.ButtonHighlight;
      this.biptal.Image = (Image) Resources.cancel24;
      this.biptal.Location = new Point(46, 399);
      this.biptal.Margin = new Padding(1);
      this.biptal.Name = "biptal";
      this.biptal.Size = new Size(130, 57);
      this.biptal.TabIndex = 13;
      this.biptal.Text = "İPTAL";
      this.biptal.TextImageRelation = TextImageRelation.ImageAboveText;
      this.biptal.UseVisualStyleBackColor = false;
      this.bKaydet.BackColor = Color.Tomato;
      this.bKaydet.FlatAppearance.BorderColor = Color.Tomato;
      this.bKaydet.FlatStyle = FlatStyle.Flat;
      this.bKaydet.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bKaydet.ForeColor = SystemColors.ButtonHighlight;
      this.bKaydet.Location = new Point(198, 399);
      this.bKaydet.Margin = new Padding(1);
      this.bKaydet.Name = "bKaydet";
      this.bKaydet.Size = new Size(128, 57);
      this.bKaydet.TabIndex = 12;
      this.bKaydet.Text = "KAYDET";
      this.bKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bKaydet.UseVisualStyleBackColor = false;
      this.bKaydet.Click += new EventHandler(this.bKaydet_Click);
      this.tTelefon.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tTelefon.Location = new Point(47, 128);
      this.tTelefon.Mask = "(999) 000-0000";
      this.tTelefon.Name = "tTelefon";
      this.tTelefon.Size = new Size(279, 29);
      this.tTelefon.TabIndex = 1;
      this.tSifreTekrar.BackColor = Color.White;
      this.tSifreTekrar.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSifreTekrar.Location = new Point(47, 366);
      this.tSifreTekrar.Name = "tSifreTekrar";
      this.tSifreTekrar.PasswordChar = '*';
      this.tSifreTekrar.Size = new Size(279, 29);
      this.tSifreTekrar.TabIndex = 5;
      this.tSifre.BackColor = Color.White;
      this.tSifre.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSifre.Location = new Point(47, 309);
      this.tSifre.Name = "tSifre";
      this.tSifre.PasswordChar = '*';
      this.tSifre.Size = new Size(279, 29);
      this.tSifre.TabIndex = 4;
      this.lstandart7.AutoSize = true;
      this.lstandart7.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart7.ForeColor = Color.DarkCyan;
      this.lstandart7.Location = new Point(50, 341);
      this.lstandart7.Name = "lstandart7";
      this.lstandart7.Size = new Size(124, 22);
      this.lstandart7.TabIndex = 9;
      this.lstandart7.Text = "Şifre Tekrar:**";
      this.lstandart6.AutoSize = true;
      this.lstandart6.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart6.ForeColor = Color.DarkCyan;
      this.lstandart6.Location = new Point(50, 284);
      this.lstandart6.Name = "lstandart6";
      this.lstandart6.Size = new Size(66, 22);
      this.lstandart6.TabIndex = 9;
      this.lstandart6.Text = "Şifre:**";
      this.tKullaniciAdi.BackColor = Color.White;
      this.tKullaniciAdi.Font = new Font("Microsoft Sans Serif", 12f);
      this.tKullaniciAdi.Location = new Point(47, 243);
      this.tKullaniciAdi.Name = "tKullaniciAdi";
      this.tKullaniciAdi.Size = new Size(279, 29);
      this.tKullaniciAdi.TabIndex = 3;
      this.lstandart5.AutoSize = true;
      this.lstandart5.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart5.ForeColor = Color.DarkCyan;
      this.lstandart5.Location = new Point(49, 218);
      this.lstandart5.Name = "lstandart5";
      this.lstandart5.Size = new Size((int) sbyte.MaxValue, 22);
      this.lstandart5.TabIndex = 7;
      this.lstandart5.Text = "Kullanıcı Adı:**";
      this.tEPosta.BackColor = Color.White;
      this.tEPosta.Font = new Font("Microsoft Sans Serif", 12f);
      this.tEPosta.Location = new Point(47, 186);
      this.tEPosta.Name = "tEPosta";
      this.tEPosta.Size = new Size(279, 29);
      this.tEPosta.TabIndex = 2;
      this.lstandart4.AutoSize = true;
      this.lstandart4.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart4.ForeColor = Color.DarkCyan;
      this.lstandart4.Location = new Point(50, 161);
      this.lstandart4.Name = "lstandart4";
      this.lstandart4.Size = new Size(78, 22);
      this.lstandart4.TabIndex = 5;
      this.lstandart4.Text = "E Posta:";
      this.lstandart3.AutoSize = true;
      this.lstandart3.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart3.ForeColor = Color.DarkCyan;
      this.lstandart3.Location = new Point(52, 103);
      this.lstandart3.Name = "lstandart3";
      this.lstandart3.Size = new Size(76, 22);
      this.lstandart3.TabIndex = 3;
      this.lstandart3.Text = "Telefon:";
      this.tAdSoyad.BackColor = Color.White;
      this.tAdSoyad.Font = new Font("Microsoft Sans Serif", 12f);
      this.tAdSoyad.Location = new Point(47, 71);
      this.tAdSoyad.Name = "tAdSoyad";
      this.tAdSoyad.Size = new Size(279, 29);
      this.tAdSoyad.TabIndex = 0;
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 11f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(52, 46);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(107, 22);
      this.lstandart2.TabIndex = 1;
      this.lstandart2.Text = "Ad Soyad:**";
      this.lstandart1.AutoSize = true;
      this.lstandart1.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart1.ForeColor = Color.DarkCyan;
      this.lstandart1.Location = new Point(31, 10);
      this.lstandart1.Name = "lstandart1";
      this.lstandart1.Size = new Size(222, 25);
      this.lstandart1.TabIndex = 0;
      this.lstandart1.Text = "KULLANICI İŞLEMLERİ";
      this.GridListeKulanici.AllowUserToAddRows = false;
      this.GridListeKulanici.AllowUserToDeleteRows = false;
      this.GridListeKulanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridListeKulanici.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridListeKulanici.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridListeKulanici.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridListeKulanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridListeKulanici.ContextMenuStrip = this.contextMenuStrip1;
      this.GridListeKulanici.DefaultCellStyle = gridViewCellStyle1;
      this.GridListeKulanici.Dock = DockStyle.Fill;
      this.GridListeKulanici.EnableHeadersVisualStyles = false;
      this.GridListeKulanici.Location = new Point(0, 0);
      this.GridListeKulanici.Margin = new Padding(1);
      this.GridListeKulanici.Name = "GridListeKulanici";
      this.GridListeKulanici.ReadOnly = true;
      this.GridListeKulanici.RowHeadersVisible = false;
      this.GridListeKulanici.RowHeadersWidth = 49;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = Color.White;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.Padding = new Padding(3);
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.GridListeKulanici.RowsDefaultCellStyle = gridViewCellStyle2;
      this.GridListeKulanici.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridListeKulanici.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridListeKulanici.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridListeKulanici.RowTemplate.Height = 33;
      this.GridListeKulanici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridListeKulanici.Size = new Size(501, 548);
      this.GridListeKulanici.TabIndex = 3;
      this.contextMenuStrip1.ImageScalingSize = new Size(19, 19);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.düzenleToolStripMenuItem,
        (ToolStripItem) this.silToolStripMenuItem
      });
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new Size(133, 52);
      this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
      this.düzenleToolStripMenuItem.Size = new Size(132, 24);
      this.düzenleToolStripMenuItem.Text = "Düzenle";
      this.düzenleToolStripMenuItem.Click += new EventHandler(this.düzenleToolStripMenuItem_Click);
      this.silToolStripMenuItem.Name = "silToolStripMenuItem";
      this.silToolStripMenuItem.Size = new Size(132, 24);
      this.silToolStripMenuItem.Text = "Sil";
      this.silToolStripMenuItem.Click += new EventHandler(this.silToolStripMenuItem_Click);
      this.tabPage2.Controls.Add((Control) this.lstandart24);
      this.tabPage2.Controls.Add((Control) this.lstandart23);
      this.tabPage2.Controls.Add((Control) this.lstandart19);
      this.tabPage2.Controls.Add((Control) this.bisyerikaydet);
      this.tabPage2.Controls.Add((Control) this.mskisyeritelefon);
      this.tabPage2.Controls.Add((Control) this.tisyerieposta);
      this.tabPage2.Controls.Add((Control) this.lstandart20);
      this.tabPage2.Controls.Add((Control) this.lstandart21);
      this.tabPage2.Controls.Add((Control) this.tisyeriadres);
      this.tabPage2.Controls.Add((Control) this.tisyeriunvan);
      this.tabPage2.Controls.Add((Control) this.tisyeriadsoyad);
      this.tabPage2.Controls.Add((Control) this.lstandart22);
      this.tabPage2.Controls.Add((Control) this.lstandart18);
      this.tabPage2.Controls.Add((Control) this.lstandart11);
      this.tabPage2.Controls.Add((Control) this.panel3);
      this.tabPage2.Controls.Add((Control) this.lstandart10);
      this.tabPage2.Controls.Add((Control) this.panel2);
      this.tabPage2.Controls.Add((Control) this.lstandart9);
      this.tabPage2.Controls.Add((Control) this.panel1);
      this.tabPage2.Location = new Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new Padding(3);
      this.tabPage2.Size = new Size(1059, 554);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "YAZICI-TERAZİ-KOMİSYON-İŞYERİ BİLGİ";
      this.tabPage2.UseVisualStyleBackColor = true;
      this.lstandart24.AutoSize = true;
      this.lstandart24.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart24.ForeColor = Color.DarkCyan;
      this.lstandart24.Location = new Point(718, 218);
      this.lstandart24.Name = "lstandart24";
      this.lstandart24.Size = new Size(64, 25);
      this.lstandart24.TabIndex = 27;
      this.lstandart24.Text = "Adres";
      this.lstandart23.AutoSize = true;
      this.lstandart23.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart23.ForeColor = Color.DarkCyan;
      this.lstandart23.Location = new Point(718, 150);
      this.lstandart23.Name = "lstandart23";
      this.lstandart23.Size = new Size(69, 25);
      this.lstandart23.TabIndex = 26;
      this.lstandart23.Text = "Ünvan";
      this.lstandart19.AutoSize = true;
      this.lstandart19.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart19.ForeColor = Color.DarkCyan;
      this.lstandart19.Location = new Point(718, 24);
      this.lstandart19.Name = "lstandart19";
      this.lstandart19.Size = new Size(260, 25);
      this.lstandart19.TabIndex = 25;
      this.lstandart19.Text = " İŞYERİ BİLGİ DÜZENLEME";
      this.bisyerikaydet.BackColor = Color.Tomato;
      this.bisyerikaydet.FlatAppearance.BorderColor = Color.Tomato;
      this.bisyerikaydet.FlatStyle = FlatStyle.Flat;
      this.bisyerikaydet.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bisyerikaydet.ForeColor = SystemColors.ButtonHighlight;
      this.bisyerikaydet.Location = new Point(854, 480);
      this.bisyerikaydet.Margin = new Padding(1);
      this.bisyerikaydet.Name = "bisyerikaydet";
      this.bisyerikaydet.Size = new Size(128, 68);
      this.bisyerikaydet.TabIndex = 5;
      this.bisyerikaydet.Text = "KAYDET";
      this.bisyerikaydet.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bisyerikaydet.UseVisualStyleBackColor = false;
      this.bisyerikaydet.Click += new EventHandler(this.bisyerikaydet_Click);
      this.mskisyeritelefon.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.mskisyeritelefon.Location = new Point(703, 355);
      this.mskisyeritelefon.Mask = "(999) 000-0000";
      this.mskisyeritelefon.Name = "mskisyeritelefon";
      this.mskisyeritelefon.Size = new Size(279, 29);
      this.mskisyeritelefon.TabIndex = 3;
      this.tisyerieposta.BackColor = Color.White;
      this.tisyerieposta.Font = new Font("Microsoft Sans Serif", 12f);
      this.tisyerieposta.Location = new Point(703, 433);
      this.tisyerieposta.Name = "tisyerieposta";
      this.tisyerieposta.Size = new Size(279, 29);
      this.tisyerieposta.TabIndex = 4;
      this.lstandart20.AutoSize = true;
      this.lstandart20.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart20.ForeColor = Color.DarkCyan;
      this.lstandart20.Location = new Point(718, 405);
      this.lstandart20.Name = "lstandart20";
      this.lstandart20.Size = new Size(86, 25);
      this.lstandart20.TabIndex = 23;
      this.lstandart20.Text = "E Posta:";
      this.lstandart21.AutoSize = true;
      this.lstandart21.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart21.ForeColor = Color.DarkCyan;
      this.lstandart21.Location = new Point(718, 327);
      this.lstandart21.Name = "lstandart21";
      this.lstandart21.Size = new Size(84, 25);
      this.lstandart21.TabIndex = 22;
      this.lstandart21.Text = "Telefon:";
      this.tisyeriadres.BackColor = Color.White;
      this.tisyeriadres.Font = new Font("Microsoft Sans Serif", 12f);
      this.tisyeriadres.Location = new Point(703, 246);
      this.tisyeriadres.Multiline = true;
      this.tisyeriadres.Name = "tisyeriadres";
      this.tisyeriadres.Size = new Size(279, 64);
      this.tisyeriadres.TabIndex = 2;
      this.tisyeriunvan.BackColor = Color.White;
      this.tisyeriunvan.Font = new Font("Microsoft Sans Serif", 12f);
      this.tisyeriunvan.Location = new Point(703, 178);
      this.tisyeriunvan.Name = "tisyeriunvan";
      this.tisyeriunvan.Size = new Size(279, 29);
      this.tisyeriunvan.TabIndex = 1;
      this.tisyeriadsoyad.BackColor = Color.White;
      this.tisyeriadsoyad.Font = new Font("Microsoft Sans Serif", 12f);
      this.tisyeriadsoyad.Location = new Point(703, 100);
      this.tisyeriadsoyad.Name = "tisyeriadsoyad";
      this.tisyeriadsoyad.Size = new Size(279, 29);
      this.tisyeriadsoyad.TabIndex = 0;
      this.lstandart22.AutoSize = true;
      this.lstandart22.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart22.ForeColor = Color.DarkCyan;
      this.lstandart22.Location = new Point(718, 72);
      this.lstandart22.Name = "lstandart22";
      this.lstandart22.Size = new Size(99, 25);
      this.lstandart22.TabIndex = 20;
      this.lstandart22.Text = "Ad Soyad";
      this.lstandart18.AutoSize = true;
      this.lstandart18.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart18.ForeColor = Color.DarkCyan;
      this.lstandart18.Location = new Point(23, 26);
      this.lstandart18.Name = "lstandart18";
      this.lstandart18.Size = new Size(376, 25);
      this.lstandart18.TabIndex = 15;
      this.lstandart18.Text = "YAZICI-TERAZİ-KOMİSYON İŞLEMLERİ";
      this.lstandart11.AutoSize = true;
      this.lstandart11.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart11.ForeColor = Color.DarkCyan;
      this.lstandart11.Location = new Point(36, 326);
      this.lstandart11.Name = "lstandart11";
      this.lstandart11.Size = new Size(198, 25);
      this.lstandart11.TabIndex = 0;
      this.lstandart11.Text = "Terazi Ön Ek Ayarları";
      this.panel3.BorderStyle = BorderStyle.FixedSingle;
      this.panel3.Controls.Add((Control) this.bTeraziOnEkSil);
      this.panel3.Controls.Add((Control) this.tTeraziOnEk);
      this.panel3.Controls.Add((Control) this.bTeraziOnEk);
      this.panel3.Controls.Add((Control) this.cmbTeraziOnEk);
      this.panel3.Location = new Point(28, 354);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(279, 163);
      this.panel3.TabIndex = 2;
      this.bTeraziOnEkSil.BackColor = Color.Brown;
      this.bTeraziOnEkSil.FlatAppearance.BorderColor = Color.Brown;
      this.bTeraziOnEkSil.Image = (Image) Resources.remove;
      this.bTeraziOnEkSil.Location = new Point(194, 3);
      this.bTeraziOnEkSil.Name = "bTeraziOnEkSil";
      this.bTeraziOnEkSil.Size = new Size(79, 47);
      this.bTeraziOnEkSil.TabIndex = 11;
      this.bTeraziOnEkSil.UseVisualStyleBackColor = false;
      this.bTeraziOnEkSil.Click += new EventHandler(this.bTeraziOnEkSil_Click);
      this.tTeraziOnEk.BackColor = Color.White;
      this.tTeraziOnEk.Font = new Font("Microsoft Sans Serif", 12f);
      this.tTeraziOnEk.Location = new Point(4, 56);
      this.tTeraziOnEk.Name = "tTeraziOnEk";
      this.tTeraziOnEk.Size = new Size(189, 29);
      this.tTeraziOnEk.TabIndex = 12;
      this.tTeraziOnEk.TextAlign = HorizontalAlignment.Right;
      this.bTeraziOnEk.BackColor = Color.YellowGreen;
      this.bTeraziOnEk.FlatAppearance.BorderColor = Color.YellowGreen;
      this.bTeraziOnEk.Image = (Image) Resources.save24;
      this.bTeraziOnEk.Location = new Point(195, 56);
      this.bTeraziOnEk.Name = "bTeraziOnEk";
      this.bTeraziOnEk.Size = new Size(79, 47);
      this.bTeraziOnEk.TabIndex = 11;
      this.bTeraziOnEk.UseVisualStyleBackColor = false;
      this.bTeraziOnEk.Click += new EventHandler(this.bTeraziOnEk_Click);
      this.cmbTeraziOnEk.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbTeraziOnEk.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cmbTeraziOnEk.FormattingEnabled = true;
      this.cmbTeraziOnEk.Location = new Point(3, 14);
      this.cmbTeraziOnEk.Name = "cmbTeraziOnEk";
      this.cmbTeraziOnEk.Size = new Size(189, 32);
      this.cmbTeraziOnEk.TabIndex = 0;
      this.lstandart10.AutoSize = true;
      this.lstandart10.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart10.ForeColor = Color.DarkCyan;
      this.lstandart10.Location = new Point(36, 201);
      this.lstandart10.Name = "lstandart10";
      this.lstandart10.Size = new Size(140, 25);
      this.lstandart10.TabIndex = 0;
      this.lstandart10.Text = "Kart Komisyon";
      this.panel2.BorderStyle = BorderStyle.FixedSingle;
      this.panel2.Controls.Add((Control) this.bGelirEkle);
      this.panel2.Controls.Add((Control) this.tKartKomisyon);
      this.panel2.Location = new Point(28, 229);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(279, 80);
      this.panel2.TabIndex = 2;
      this.bGelirEkle.BackColor = Color.YellowGreen;
      this.bGelirEkle.FlatAppearance.BorderColor = Color.YellowGreen;
      this.bGelirEkle.Image = (Image) Resources.save24;
      this.bGelirEkle.Location = new Point(194, 3);
      this.bGelirEkle.Name = "bGelirEkle";
      this.bGelirEkle.Size = new Size(79, 47);
      this.bGelirEkle.TabIndex = 11;
      this.bGelirEkle.UseVisualStyleBackColor = false;
      this.bGelirEkle.Click += new EventHandler(this.bGelirEkle_Click);
      this.tKartKomisyon.BackColor = Color.White;
      this.tKartKomisyon.Font = new Font("Microsoft Sans Serif", 12f);
      this.tKartKomisyon.Location = new Point(3, 15);
      this.tKartKomisyon.Name = "tKartKomisyon";
      this.tKartKomisyon.Size = new Size(185, 29);
      this.tKartKomisyon.TabIndex = 0;
      this.tKartKomisyon.TextAlign = HorizontalAlignment.Center;
      this.lstandart9.AutoSize = true;
      this.lstandart9.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart9.ForeColor = Color.DarkCyan;
      this.lstandart9.Location = new Point(36, 79);
      this.lstandart9.Name = "lstandart9";
      this.lstandart9.Size = new Size(156, 25);
      this.lstandart9.TabIndex = 1;
      this.lstandart9.Text = "Yazıcı Aktif/Pasif";
      this.panel1.BorderStyle = BorderStyle.FixedSingle;
      this.panel1.Controls.Add((Control) this.chYazmaDurumu);
      this.panel1.Location = new Point(28, 107);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(279, 80);
      this.panel1.TabIndex = 0;
      this.chYazmaDurumu.Appearance = Appearance.Button;
      this.chYazmaDurumu.AutoSize = true;
      this.chYazmaDurumu.BackColor = Color.Crimson;
      this.chYazmaDurumu.FlatAppearance.BorderColor = Color.LavenderBlush;
      this.chYazmaDurumu.FlatAppearance.CheckedBackColor = Color.DarkOliveGreen;
      this.chYazmaDurumu.FlatStyle = FlatStyle.Flat;
      this.chYazmaDurumu.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.chYazmaDurumu.ForeColor = Color.White;
      this.chYazmaDurumu.Location = new Point(3, 8);
      this.chYazmaDurumu.Name = "chYazmaDurumu";
      this.chYazmaDurumu.Size = new Size(242, 35);
      this.chYazmaDurumu.TabIndex = 0;
      this.chYazmaDurumu.Text = "Yazma Durumu Pasif";
      this.chYazmaDurumu.UseVisualStyleBackColor = false;
      this.chYazmaDurumu.CheckedChanged += new EventHandler(this.chYazmaDurumu_CheckedChanged);
      this.tabPage3.Controls.Add((Control) this.lstandart13);
      this.tabPage3.Controls.Add((Control) this.bKullanılmayan);
      this.tabPage3.Controls.Add((Control) this.lstandart12);
      this.tabPage3.Controls.Add((Control) this.bYedektenYukle);
      this.tabPage3.Location = new Point(4, 25);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new Padding(3);
      this.tabPage3.Size = new Size(1059, 554);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "YEDEĞİ YÜKLE";
      this.tabPage3.UseVisualStyleBackColor = true;
      this.lstandart13.AutoSize = true;
      this.lstandart13.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart13.ForeColor = Color.DarkCyan;
      this.lstandart13.Location = new Point(582, 36);
      this.lstandart13.Name = "lstandart13";
      this.lstandart13.Size = new Size(414, 75);
      this.lstandart13.TabIndex = 16;
      this.lstandart13.Text = "Gerekli ürünlerin fiyat güncellemesi yapıldıktan \r\nsonra güncelleme yapılmayan\r\nÜrünlerin silinmesini sağlar.\r\n";
      this.bKullanılmayan.BackColor = Color.Red;
      this.bKullanılmayan.FlatAppearance.BorderColor = Color.Red;
      this.bKullanılmayan.FlatStyle = FlatStyle.Flat;
      this.bKullanılmayan.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bKullanılmayan.ForeColor = SystemColors.ButtonHighlight;
      this.bKullanılmayan.Image = (Image) Resources.duzenle32;
      this.bKullanılmayan.Location = new Point(587, 112);
      this.bKullanılmayan.Margin = new Padding(1);
      this.bKullanılmayan.Name = "bKullanılmayan";
      this.bKullanılmayan.Size = new Size(396, 122);
      this.bKullanılmayan.TabIndex = 15;
      this.bKullanılmayan.Text = "KULLANILMAYAN ÜRÜNLERİ SİL";
      this.bKullanılmayan.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bKullanılmayan.UseVisualStyleBackColor = false;
      this.bKullanılmayan.Click += new EventHandler(this.bKullanılmayan_Click);
      this.lstandart12.AutoSize = true;
      this.lstandart12.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart12.ForeColor = Color.DarkCyan;
      this.lstandart12.Location = new Point(12, 34);
      this.lstandart12.Name = "lstandart12";
      this.lstandart12.Size = new Size(389, 75);
      this.lstandart12.TabIndex = 14;
      this.lstandart12.Text = "Önceden aldığınız yedeği seçiniz.\r\nButona tıklayıp yedeği tekrar yükleyiniz.\r\nBu işlemi sadece gerekli olduğunda yapınız.";
      this.bYedektenYukle.BackColor = Color.Tomato;
      this.bYedektenYukle.FlatAppearance.BorderColor = Color.Tomato;
      this.bYedektenYukle.FlatStyle = FlatStyle.Flat;
      this.bYedektenYukle.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bYedektenYukle.ForeColor = SystemColors.ButtonHighlight;
      this.bYedektenYukle.Image = (Image) Resources.restore4854;
      this.bYedektenYukle.Location = new Point(56, 112);
      this.bYedektenYukle.Margin = new Padding(1);
      this.bYedektenYukle.Name = "bYedektenYukle";
      this.bYedektenYukle.Size = new Size(396, 122);
      this.bYedektenYukle.TabIndex = 13;
      this.bYedektenYukle.Text = "YEDEKTEN YÜKLE (RESTORE)";
      this.bYedektenYukle.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bYedektenYukle.UseVisualStyleBackColor = false;
      this.bYedektenYukle.Click += new EventHandler(this.bYedektenYukle_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1067, 583);
      this.Controls.Add((Control) this.tabControl1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fAyarlar);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "AYARLAR";
      this.Load += new EventHandler(this.fAyarlar_Load);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.GridListeKulanici).EndInit();
      this.contextMenuStrip1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
