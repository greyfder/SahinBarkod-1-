// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fUrunGiris
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
  public class fUrunGiris : Form
  {
    private Barkod1Entities db = new Barkod1Entities();
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private tnumeric tUrunSayisi;
    private lstandart lstandart10;
    private tstandart tUrunAra;
    private lstandart lstandart9;
    private bstandart bRaporAl;
    private bstandart bKaydet;
    private bstandart bİptal;
    private bstandart bBarkodOlustur;
    private bstandart bUrunGrubuEkle;
    private tnumeric tKdvOrani;
    private tnumeric tMiktar;
    private tnumeric tSatisFiyati;
    private tnumeric tAlısFiyati;
    private lstandart lstandart8;
    private lstandart lstandart7;
    private lstandart lstandart6;
    private lstandart lstandart5;
    private tstandart tAcıklama;
    private tstandart tUrunAdi;
    private lstandart lstandart4;
    private lstandart lstandart3;
    private lstandart lstandart2;
    private lstandart lstandart1;
    private gridozel GridUrunler;
    internal tstandart tbarkod;
    internal lstandart lkullanici;
    private tnumeric tSatisFiyati5;
    private tnumeric tSatisFiyati4;
    private tnumeric tSatisFiyati3;
    private tnumeric tSatisFiyati2;
    private lstandart lstandart14;
    private lstandart lstandart13;
    private lstandart lstandart12;
    private lstandart lstandart11;
    public ComboBox cmbUrunGrubu;
    private ListBox listBarkod;
    private tnumeric tUrunid;
    private lstandart lid;
    private bstandart bbarkodKaydet;
    private bstandart bBarkodKaldır;
    private CheckBox chUrunTipi;
    internal tstandart tCok;
    private Button b200;

    public fUrunGiris() => this.InitializeComponent();

    private void bstandart5_Click(object sender, EventArgs e)
    {
      if (!(this.tUrunid.Text != ""))
        return;
      int urunid = Convert.ToInt32(this.tUrunid.Text);
      if (MessageBox.Show(this.tUrunAdi.Text + "Ürünü Silmek İstiyor musunuz?", "Ürün Silme İşlemi", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        this.db.CokluB.RemoveRange((IEnumerable<CokluB>) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (x => x.Urunid == (int?) urunid)).ToList<CokluB>());
        this.db.SaveChanges();
        this.barkodliste(this.GetListBarkod());
        if (this.db.Urun.Any<Urun>((Expression<Func<Urun, bool>>) (x => x.Urunid == urunid)))
        {
          Urun entity = this.db.Urun.Find(new object[1]
          {
            (object) urunid
          });
          string barkod = entity.Barkod;
          if (this.db.HızlıUrun.Any<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Barkod == barkod)))
          {
            HızlıUrun hızlıUrun = this.db.HızlıUrun.Where<HızlıUrun>((Expression<Func<HızlıUrun, bool>>) (x => x.Barkod == barkod)).SingleOrDefault<HızlıUrun>();
            hızlıUrun.Barkod = "-";
            hızlıUrun.UrunAd = "-";
            hızlıUrun.Fiyat = new double?(0.0);
            this.db.SaveChanges();
            int num = (int) MessageBox.Show("Ürün Silindi.");
            ((Form1) Application.OpenForms["Form1"]).HızlıUrunDoldur();
          }
          this.db.Urun.Remove(entity);
          this.db.SaveChanges();
        }
        this.GridUrunler.DataSource = (object) this.db.Urun.OrderByDescending<Urun, int>((Expression<Func<Urun, int>>) (a => a.Urunid)).Take<Urun>(20).ToList<Urun>();
        islemler.GridDuzenle((DataGridView) this.GridUrunler);
        this.temizle();
        this.tbarkod.Focus();
      }
    }

    public void tbarkodGetir(string barkod)
    {
      if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)))
      {
        int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
        Urun urun = this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).SingleOrDefault<Urun>();
        this.tUrunAdi.Text = urun.UrunAd;
        this.tAcıklama.Text = urun.Acıklama;
        this.cmbUrunGrubu.Text = urun.UrunGrup;
        this.tAlısFiyati.Text = urun.AlisFiyat.ToString();
        this.tSatisFiyati.Text = urun.SatisFiyat.ToString();
        tnumeric tSatisFiyati2 = this.tSatisFiyati2;
        double? nullable = urun.SatisFiyat2;
        string str1 = nullable.ToString();
        tSatisFiyati2.Text = str1;
        tnumeric tSatisFiyati3 = this.tSatisFiyati3;
        nullable = urun.SatisFiyat3;
        string str2 = nullable.ToString();
        tSatisFiyati3.Text = str2;
        tnumeric tSatisFiyati4 = this.tSatisFiyati4;
        nullable = urun.SatisFiyat4;
        string str3 = nullable.ToString();
        tSatisFiyati4.Text = str3;
        tnumeric tSatisFiyati5 = this.tSatisFiyati5;
        nullable = urun.SatisFiyat5;
        string str4 = nullable.ToString();
        tSatisFiyati5.Text = str4;
        tnumeric tMiktar = this.tMiktar;
        nullable = urun.Miktar;
        string str5 = nullable.ToString();
        tMiktar.Text = str5;
        this.tKdvOrani.Text = urun.KdvOrani.ToString();
        this.tUrunid.Text = urun.Urunid.ToString();
        this.chUrunTipi.Checked = urun.Birim == "kg";
        this.barkodliste(this.GetListBarkod());
      }
      else
      {
        int num = (int) MessageBox.Show("Ürün kayıtlı değil.Kaydet");
      }
    }

    public void tbarkod_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      string barkod = this.tbarkod.Text.Trim();
      if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)))
      {
        int urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (b => b.Urunid)).FirstOrDefault<int?>());
        Urun urun = this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == urunid)).SingleOrDefault<Urun>();
        this.tUrunAdi.Text = urun.UrunAd;
        this.tAcıklama.Text = urun.Acıklama;
        this.cmbUrunGrubu.Text = urun.UrunGrup;
        this.tAlısFiyati.Text = urun.AlisFiyat.ToString();
        this.tSatisFiyati.Text = urun.SatisFiyat.ToString();
        this.tSatisFiyati2.Text = urun.SatisFiyat2.ToString();
        tnumeric tSatisFiyati3 = this.tSatisFiyati3;
        double? nullable = urun.SatisFiyat3;
        string str1 = nullable.ToString();
        tSatisFiyati3.Text = str1;
        tnumeric tSatisFiyati4 = this.tSatisFiyati4;
        nullable = urun.SatisFiyat4;
        string str2 = nullable.ToString();
        tSatisFiyati4.Text = str2;
        tnumeric tSatisFiyati5 = this.tSatisFiyati5;
        nullable = urun.SatisFiyat5;
        string str3 = nullable.ToString();
        tSatisFiyati5.Text = str3;
        tnumeric tMiktar = this.tMiktar;
        nullable = urun.Miktar;
        string str4 = nullable.ToString();
        tMiktar.Text = str4;
        this.tKdvOrani.Text = urun.KdvOrani.ToString();
        this.tUrunid.Text = urun.Urunid.ToString();
        this.chUrunTipi.Checked = urun.Birim == "kg";
        this.barkodliste(this.GetListBarkod());
      }
      else
      {
        int num = (int) MessageBox.Show("Ürün kayıtlı değil.Kaydet");
      }
    }

    private void bKaydet_Click(object sender, EventArgs e)
    {
      if (this.tbarkod.Text != "" && this.tUrunAdi.Text != "" && this.tAlısFiyati.Text != "" && this.tSatisFiyati.Text != "" && this.tKdvOrani.Text != "" && this.tMiktar.Text != "")
      {
        int Urunid = Convert.ToInt32((object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == this.tbarkod.Text)).Select<CokluB, int?>((Expression<Func<CokluB, int?>>) (s => s.Urunid)).FirstOrDefault<int?>());
        if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == this.tbarkod.Text)))
        {
          Urun urun1 = this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.Urunid == Urunid)).SingleOrDefault<Urun>();
          urun1.UrunAd = this.tUrunAdi.Text;
          urun1.UrunGrup = this.cmbUrunGrubu.Text;
          urun1.Acıklama = this.tAcıklama.Text;
          urun1.AlisFiyat = new double?(islemler.DoubleYap(this.tAlısFiyati.Text));
          urun1.SatisFiyat = new double?(islemler.DoubleYap(this.tSatisFiyati.Text));
          urun1.SatisFiyat2 = new double?(islemler.DoubleYap(this.tSatisFiyati2.Text));
          urun1.SatisFiyat3 = new double?(islemler.DoubleYap(this.tSatisFiyati3.Text));
          urun1.SatisFiyat4 = new double?(islemler.DoubleYap(this.tSatisFiyati4.Text));
          urun1.SatisFiyat5 = new double?(islemler.DoubleYap(this.tSatisFiyati5.Text));
          urun1.KdvOrani = new int?((int) Convert.ToInt16(this.tKdvOrani.Text));
          urun1.KdvTutari = new double?(Math.Round(islemler.DoubleYap(this.tSatisFiyati.Text) * (double) Convert.ToInt16(this.tKdvOrani.Text) / 100.0, 2));
          Urun urun2 = urun1;
          double? miktar = urun2.Miktar;
          double num = Convert.ToDouble(this.tMiktar.Text);
          urun2.Miktar = miktar.HasValue ? new double?(miktar.GetValueOrDefault() + num) : new double?();
          urun1.Onay = new bool?(true);
          urun1.Birim = !this.chUrunTipi.Checked ? "Adet" : "kg";
          urun1.Tarih = new DateTime?(DateTime.Now);
          urun1.Kullanci = this.lkullanici.Text;
          this.db.SaveChanges();
          islemler.StokHareket(this.tbarkod.Text, this.tUrunAdi.Text, "Adet", Convert.ToDouble(this.tMiktar.Text), this.cmbUrunGrubu.Text, this.lkullanici.Text);
          this.GridUrunler.DataSource = (object) this.db.Urun.OrderByDescending<Urun, int>((Expression<Func<Urun, int>>) (a => a.Urunid)).Take<Urun>(20).ToList<Urun>();
        }
        else
        {
          Urun entity = new Urun();
          entity.Barkod = this.tbarkod.Text;
          entity.UrunAd = this.tUrunAdi.Text;
          entity.UrunGrup = this.cmbUrunGrubu.Text;
          entity.Acıklama = this.tAcıklama.Text;
          entity.AlisFiyat = new double?(islemler.DoubleYap(this.tAlısFiyati.Text));
          entity.SatisFiyat = new double?(islemler.DoubleYap(this.tSatisFiyati.Text));
          entity.SatisFiyat2 = new double?(islemler.DoubleYap(this.tSatisFiyati2.Text));
          entity.SatisFiyat3 = new double?(islemler.DoubleYap(this.tSatisFiyati3.Text));
          entity.SatisFiyat4 = new double?(islemler.DoubleYap(this.tSatisFiyati4.Text));
          entity.SatisFiyat5 = new double?(islemler.DoubleYap(this.tSatisFiyati5.Text));
          entity.KdvOrani = new int?((int) Convert.ToInt16(this.tKdvOrani.Text));
          entity.KdvTutari = new double?(Math.Round(islemler.DoubleYap(this.tSatisFiyati.Text) * (double) Convert.ToInt16(this.tKdvOrani.Text) / 100.0, 2));
          entity.Miktar = new double?(Convert.ToDouble(this.tMiktar.Text));
          entity.Onay = new bool?(true);
          entity.Birim = !this.chUrunTipi.Checked ? "Adet" : "kg";
          entity.Tarih = new DateTime?(DateTime.Now);
          entity.Kullanci = this.lkullanici.Text;
          this.tUrunid.Text = entity.Urunid.ToString();
          this.db.Urun.Add(entity);
          this.db.SaveChanges();
          this.tUrunid.Text = entity.Urunid.ToString();
          if (this.tbarkod.Text.Length == 8)
          {
            Barkod barkod = this.db.Barkod.First<Barkod>();
            int? barkodno = barkod.Barkodno;
            barkod.Barkodno = barkodno.HasValue ? new int?(barkodno.GetValueOrDefault() + 1) : new int?();
            this.db.SaveChanges();
          }
          this.coklubKayit();
          this.barkodliste(this.GetListBarkod());
          islemler.StokHareket(this.tbarkod.Text, this.tUrunAdi.Text, "Adet", Convert.ToDouble(this.tMiktar.Text), this.cmbUrunGrubu.Text, this.lkullanici.Text);
          this.temizle();
          this.chUrunTipi.Checked = false;
          this.GridUrunler.DataSource = (object) this.db.Urun.OrderByDescending<Urun, int>((Expression<Func<Urun, int>>) (a => a.Urunid)).Take<Urun>(20).ToList<Urun>();
          islemler.GridDuzenle((DataGridView) this.GridUrunler);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Bilgi Girişini Kontrol Ediniz.");
        this.tbarkod.Focus();
      }
    }

    private void tUrunAra_TextChanged(object sender, EventArgs e)
    {
      string urunad = this.tUrunAra.Text;
      this.GridUrunler.DataSource = (object) this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.UrunAd.Contains(urunad))).ToList<Urun>();
      islemler.GridDuzenle((DataGridView) this.GridUrunler);
    }

    private void bİptal_Click(object sender, EventArgs e) => this.temizle();

    private void temizle()
    {
      this.tbarkod.Text = "";
      this.tUrunAdi.Text = "";
      this.tAcıklama.Text = "";
      this.tAlısFiyati.Text = "0";
      this.tSatisFiyati.Text = "0";
      this.tMiktar.Text = "0";
      this.tKdvOrani.Text = "0";
      this.tSatisFiyati2.Text = "0";
      this.tSatisFiyati3.Text = "0";
      this.tSatisFiyati4.Text = "0";
      this.tSatisFiyati5.Text = "0";
      this.listBarkod.DataSource = (object) null;
      this.tUrunAra.Text = "";
      this.tUrunid.Text = "";
      this.tbarkod.Focus();
      this.chUrunTipi.Checked = false;
    }

    private void fUrunGiris_Load(object sender, EventArgs e)
    {
      this.tUrunSayisi.Text = this.db.Urun.Count<Urun>().ToString();
      this.GridUrunler.DataSource = (object) this.db.Urun.OrderByDescending<Urun, int>((Expression<Func<Urun, int>>) (a => a.Urunid)).Take<Urun>(20).ToList<Urun>();
      this.GridUrunler.Columns[0].Width = 85;
      this.GridUrunler.Columns[1].Width = 85;
      this.GridUrunler.Columns[2].Width = 250;
      this.GridUrunler.Columns[3].Width = 85;
      this.GridUrunler.Columns[4].Width = 85;
      this.GridUrunler.Columns[5].Width = 85;
      this.GridUrunler.Columns[7].Width = 85;
      this.GridUrunler.Columns[7].Width = 80;
      this.GridUrunler.Columns[17].Width = 75;
      islemler.GridDuzenle((DataGridView) this.GridUrunler);
      this.tbarkod.Focus();
      this.GrupDoldur();
    }

    private void bUrunGrubuEkle_Click(object sender, EventArgs e)
    {
      int num = (int) new fUrunGrubuIslemleri().ShowDialog();
    }

    private ListBox GetListBarkod() => this.listBarkod;

    private void barkodliste(ListBox listBarkod)
    {
      int tid = Convert.ToInt32(this.tUrunid.Text);
      listBarkod.DisplayMember = "Barkod";
      listBarkod.ValueMember = "Urunid";
      listBarkod.DataSource = (object) this.db.CokluB.Where<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Urunid == (int?) tid)).ToList<CokluB>();
    }

    public void GrupDoldur()
    {
      this.cmbUrunGrubu.DisplayMember = "UrunGrupAd";
      this.cmbUrunGrubu.ValueMember = "Id";
      this.cmbUrunGrubu.DataSource = (object) this.db.UrunGrup.OrderBy<UrunGrup, string>((Expression<Func<UrunGrup, string>>) (a => a.UrunGrupAd)).ToList<UrunGrup>();
    }

    private void bBarkodOlustur_Click(object sender, EventArgs e)
    {
      Barkod barkod = this.db.Barkod.First<Barkod>();
      int length = barkod.Barkodno.ToString().Length;
      string empty = string.Empty;
      for (int index = 0; index < 8 - length; ++index)
        empty += "0";
      this.tbarkod.Text = empty + barkod.Barkodno.ToString();
      this.tUrunAdi.Focus();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
        return;
      e.Handled = true;
    }

    private void bbarkodKaydet_Click(object sender, EventArgs e) => this.coklubKayit2();

    private void coklubKayit()
    {
      CokluB entity = new CokluB();
      string barkod = this.tbarkod.Text.Trim();
      if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)))
      {
        int num = (int) MessageBox.Show("Kayıtlı Barkod.");
      }
      else
      {
        entity.Urunid = new int?(Convert.ToInt32(this.tUrunid.Text));
        entity.Barkod = this.tbarkod.Text;
        this.db.CokluB.Add(entity);
        this.db.SaveChanges();
        this.barkodliste(this.GetListBarkod());
      }
    }

    private void coklubKayit2()
    {
      CokluB entity = new CokluB();
      string barkod = this.tCok.Text.Trim();
      if (this.db.CokluB.Any<CokluB>((Expression<Func<CokluB, bool>>) (a => a.Barkod == barkod)))
      {
        int num = (int) MessageBox.Show("Kayıtlı Barkod.");
      }
      else
      {
        entity.Urunid = new int?(Convert.ToInt32(this.tUrunid.Text));
        entity.Barkod = this.tCok.Text;
        this.db.CokluB.Add(entity);
        this.db.SaveChanges();
        this.barkodliste(this.GetListBarkod());
      }
      this.tCok.Text = "";
    }

    private void bBarkodKaldır_Click(object sender, EventArgs e)
    {
      Convert.ToInt32(this.listBarkod.SelectedValue.ToString());
      string grupad = this.listBarkod.Text;
      this.db.CokluB.Remove(this.db.CokluB.FirstOrDefault<CokluB>((Expression<Func<CokluB, bool>>) (x => x.Barkod == grupad)));
      this.db.SaveChanges();
      this.barkodliste(this.GetListBarkod());
    }

    private void chUrunTipi_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chUrunTipi.Checked)
      {
        this.chUrunTipi.Text = "Gramajlı Ürün İşlemi.";
        this.bBarkodOlustur.Enabled = false;
      }
      else
      {
        this.chUrunTipi.Text = "Barkodlu Ürün İşlemi.";
        this.bBarkodOlustur.Enabled = true;
      }
    }

    private void GridUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.GridUrunler.Rows.Count <= 0)
        return;
      this.tUrunid.Text = this.GridUrunler.CurrentRow.Cells["Urunid"].Value.ToString();
      this.tbarkod.Text = this.GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
      this.tUrunAdi.Text = this.GridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
      this.tAcıklama.Text = this.GridUrunler.CurrentRow.Cells["Acıklama"].Value.ToString();
      this.cmbUrunGrubu.Text = this.GridUrunler.CurrentRow.Cells["UrunGrup"].Value.ToString();
      this.tAlısFiyati.Text = this.GridUrunler.CurrentRow.Cells["AlisFiyat"].Value.ToString();
      this.tSatisFiyati.Text = this.GridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString();
      this.tKdvOrani.Text = this.GridUrunler.CurrentRow.Cells["KdvOrani"].Value.ToString();
      this.chUrunTipi.Checked = this.GridUrunler.CurrentRow.Cells["Birim"].Value.ToString() == "kg";
      this.tMiktar.Text = this.GridUrunler.CurrentRow.Cells["Miktar"].Value.ToString();
      this.tSatisFiyati2.Text = this.GridUrunler.CurrentRow.Cells["SatisFiyat2"].Value.ToString();
      this.tSatisFiyati3.Text = this.GridUrunler.CurrentRow.Cells["SatisFiyat3"].Value.ToString();
      this.tSatisFiyati4.Text = this.GridUrunler.CurrentRow.Cells["SatisFiyat4"].Value.ToString();
      this.tSatisFiyati5.Text = this.GridUrunler.CurrentRow.Cells["SatisFiyat5"].Value.ToString();
      this.barkodliste(this.GetListBarkod());
    }

    private void b200_Click(object sender, EventArgs e) => this.Close();

    private void tCok_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.coklubKayit2();
    }

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fUrunGiris));
      this.splitContainer1 = new SplitContainer();
      this.b200 = new Button();
      this.tCok = new tstandart();
      this.chUrunTipi = new CheckBox();
      this.bBarkodKaldır = new bstandart();
      this.bbarkodKaydet = new bstandart();
      this.listBarkod = new ListBox();
      this.lkullanici = new lstandart();
      this.tUrunSayisi = new tnumeric();
      this.lstandart10 = new lstandart();
      this.tUrunAra = new tstandart();
      this.lstandart9 = new lstandart();
      this.bRaporAl = new bstandart();
      this.bKaydet = new bstandart();
      this.bİptal = new bstandart();
      this.bBarkodOlustur = new bstandart();
      this.bUrunGrubuEkle = new bstandart();
      this.tSatisFiyati5 = new tnumeric();
      this.tSatisFiyati4 = new tnumeric();
      this.tUrunid = new tnumeric();
      this.tKdvOrani = new tnumeric();
      this.tSatisFiyati3 = new tnumeric();
      this.tMiktar = new tnumeric();
      this.tSatisFiyati2 = new tnumeric();
      this.tSatisFiyati = new tnumeric();
      this.lid = new lstandart();
      this.tAlısFiyati = new tnumeric();
      this.lstandart8 = new lstandart();
      this.lstandart7 = new lstandart();
      this.lstandart14 = new lstandart();
      this.lstandart13 = new lstandart();
      this.lstandart12 = new lstandart();
      this.lstandart11 = new lstandart();
      this.lstandart6 = new lstandart();
      this.lstandart5 = new lstandart();
      this.tAcıklama = new tstandart();
      this.tUrunAdi = new tstandart();
      this.tbarkod = new tstandart();
      this.cmbUrunGrubu = new ComboBox();
      this.lstandart4 = new lstandart();
      this.lstandart3 = new lstandart();
      this.lstandart2 = new lstandart();
      this.lstandart1 = new lstandart();
      this.GridUrunler = new gridozel();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.GridUrunler).BeginInit();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.b200);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tCok);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chUrunTipi);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bBarkodKaldır);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bbarkodKaydet);
      this.splitContainer1.Panel1.Controls.Add((Control) this.listBarkod);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lkullanici);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tUrunSayisi);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart10);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tUrunAra);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart9);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bRaporAl);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bKaydet);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bİptal);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bBarkodOlustur);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bUrunGrubuEkle);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisFiyati5);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisFiyati4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tUrunid);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tKdvOrani);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisFiyati3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tMiktar);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisFiyati2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tSatisFiyati);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lid);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tAlısFiyati);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart8);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart7);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart14);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart13);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart12);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart11);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart6);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart5);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tAcıklama);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tUrunAdi);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tbarkod);
      this.splitContainer1.Panel1.Controls.Add((Control) this.cmbUrunGrubu);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart4);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart3);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart2);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lstandart1);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridUrunler);
      this.splitContainer1.Size = new Size(1202, 629);
      this.splitContainer1.SplitterDistance = 348;
      this.splitContainer1.TabIndex = 0;
      this.b200.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.b200.BackColor = Color.DimGray;
      this.b200.FlatAppearance.BorderColor = Color.DimGray;
      this.b200.FlatStyle = FlatStyle.Flat;
      this.b200.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b200.ForeColor = Color.White;
      this.b200.Image = (Image) Resources.exit4854;
      this.b200.Location = new Point(998, 273);
      this.b200.Margin = new Padding(1);
      this.b200.Name = "b200";
      this.b200.Size = new Size(150, 74);
      this.b200.TabIndex = 14;
      this.b200.UseVisualStyleBackColor = false;
      this.b200.Click += new EventHandler(this.b200_Click);
      this.tCok.Anchor = AnchorStyles.Right;
      this.tCok.BackColor = Color.White;
      this.tCok.Font = new Font("Microsoft Sans Serif", 12f);
      this.tCok.Location = new Point(941, 4);
      this.tCok.Name = "tCok";
      this.tCok.Size = new Size(250, 29);
      this.tCok.TabIndex = 24;
      this.tCok.KeyDown += new KeyEventHandler(this.tCok_KeyDown);
      this.chUrunTipi.Appearance = Appearance.Button;
      this.chUrunTipi.AutoSize = true;
      this.chUrunTipi.BackColor = Color.Olive;
      this.chUrunTipi.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
      this.chUrunTipi.FlatAppearance.CheckedBackColor = Color.DarkRed;
      this.chUrunTipi.FlatStyle = FlatStyle.Flat;
      this.chUrunTipi.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.chUrunTipi.ForeColor = Color.White;
      this.chUrunTipi.Location = new Point(68, 3);
      this.chUrunTipi.Name = "chUrunTipi";
      this.chUrunTipi.Size = new Size(205, 32);
      this.chUrunTipi.TabIndex = 23;
      this.chUrunTipi.Text = "Barkodlu Ürün İşlemi";
      this.chUrunTipi.UseVisualStyleBackColor = false;
      this.chUrunTipi.CheckedChanged += new EventHandler(this.chUrunTipi_CheckedChanged);
      this.bBarkodKaldır.Anchor = AnchorStyles.Right;
      this.bBarkodKaldır.BackColor = Color.Tomato;
      this.bBarkodKaldır.FlatAppearance.BorderColor = Color.Tomato;
      this.bBarkodKaldır.FlatStyle = FlatStyle.Flat;
      this.bBarkodKaldır.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bBarkodKaldır.ForeColor = SystemColors.ButtonHighlight;
      this.bBarkodKaldır.Location = new Point(1065, 191);
      this.bBarkodKaldır.Margin = new Padding(1);
      this.bBarkodKaldır.Name = "bBarkodKaldır";
      this.bBarkodKaldır.Size = new Size(125, 65);
      this.bBarkodKaldır.TabIndex = 0;
      this.bBarkodKaldır.Text = "Barkod Kaldır";
      this.bBarkodKaldır.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bBarkodKaldır.UseVisualStyleBackColor = false;
      this.bBarkodKaldır.Click += new EventHandler(this.bBarkodKaldır_Click);
      this.bbarkodKaydet.Anchor = AnchorStyles.Right;
      this.bbarkodKaydet.BackColor = Color.OrangeRed;
      this.bbarkodKaydet.FlatAppearance.BorderColor = Color.OrangeRed;
      this.bbarkodKaydet.FlatStyle = FlatStyle.Flat;
      this.bbarkodKaydet.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bbarkodKaydet.ForeColor = SystemColors.ButtonHighlight;
      this.bbarkodKaydet.Location = new Point(941, 191);
      this.bbarkodKaydet.Margin = new Padding(1);
      this.bbarkodKaydet.Name = "bbarkodKaydet";
      this.bbarkodKaydet.Size = new Size(122, 65);
      this.bbarkodKaydet.TabIndex = 22;
      this.bbarkodKaydet.Text = "Barkod Ekle";
      this.bbarkodKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bbarkodKaydet.UseVisualStyleBackColor = false;
      this.bbarkodKaydet.Click += new EventHandler(this.bbarkodKaydet_Click);
      this.listBarkod.Anchor = AnchorStyles.Right;
      this.listBarkod.FormattingEnabled = true;
      this.listBarkod.ItemHeight = 16;
      this.listBarkod.Location = new Point(941, 39);
      this.listBarkod.Name = "listBarkod";
      this.listBarkod.Size = new Size(249, 148);
      this.listBarkod.TabIndex = 21;
      this.lkullanici.AutoSize = true;
      this.lkullanici.Font = new Font("Microsoft Sans Serif", 12f);
      this.lkullanici.ForeColor = Color.DarkCyan;
      this.lkullanici.Location = new Point(332, 9);
      this.lkullanici.Name = "lkullanici";
      this.lkullanici.Size = new Size(85, 25);
      this.lkullanici.TabIndex = 20;
      this.lkullanici.Text = "Kullanıcı";
      this.tUrunSayisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.tUrunSayisi.BackColor = Color.White;
      this.tUrunSayisi.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunSayisi.Location = new Point(506, 307);
      this.tUrunSayisi.Name = "tUrunSayisi";
      this.tUrunSayisi.ReadOnly = true;
      this.tUrunSayisi.Size = new Size(115, 29);
      this.tUrunSayisi.TabIndex = 17;
      this.tUrunSayisi.TextAlign = HorizontalAlignment.Right;
      this.lstandart10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lstandart10.AutoSize = true;
      this.lstandart10.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart10.ForeColor = Color.DarkCyan;
      this.lstandart10.Location = new Point(382, 310);
      this.lstandart10.Name = "lstandart10";
      this.lstandart10.Size = new Size(118, 25);
      this.lstandart10.TabIndex = 18;
      this.lstandart10.Text = "Ürün Sayısı:";
      this.tUrunAra.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.tUrunAra.BackColor = Color.White;
      this.tUrunAra.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunAra.Location = new Point(112, 307);
      this.tUrunAra.Name = "tUrunAra";
      this.tUrunAra.Size = new Size(250, 29);
      this.tUrunAra.TabIndex = 16;
      this.tUrunAra.TextChanged += new EventHandler(this.tUrunAra_TextChanged);
      this.lstandart9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.lstandart9.AutoSize = true;
      this.lstandart9.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart9.ForeColor = Color.DarkCyan;
      this.lstandart9.Location = new Point(10, 311);
      this.lstandart9.Name = "lstandart9";
      this.lstandart9.Size = new Size(96, 25);
      this.lstandart9.TabIndex = 16;
      this.lstandart9.Text = "Ürün Ara:";
      this.bRaporAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.bRaporAl.BackColor = Color.Red;
      this.bRaporAl.FlatAppearance.BorderColor = Color.Red;
      this.bRaporAl.FlatStyle = FlatStyle.Flat;
      this.bRaporAl.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bRaporAl.ForeColor = SystemColors.ButtonHighlight;
      this.bRaporAl.Image = (Image) Resources.delete;
      this.bRaporAl.Location = new Point(13, 210);
      this.bRaporAl.Margin = new Padding(1);
      this.bRaporAl.Name = "bRaporAl";
      this.bRaporAl.Size = new Size(115, 70);
      this.bRaporAl.TabIndex = 18;
      this.bRaporAl.Text = "SİL";
      this.bRaporAl.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bRaporAl.UseVisualStyleBackColor = false;
      this.bRaporAl.Click += new EventHandler(this.bstandart5_Click);
      this.bKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.bKaydet.BackColor = Color.OrangeRed;
      this.bKaydet.FlatAppearance.BorderColor = Color.OrangeRed;
      this.bKaydet.FlatStyle = FlatStyle.Flat;
      this.bKaydet.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bKaydet.ForeColor = SystemColors.ButtonHighlight;
      this.bKaydet.Image = (Image) Resources.save24;
      this.bKaydet.Location = new Point(665, 273);
      this.bKaydet.Margin = new Padding(1);
      this.bKaydet.Name = "bKaydet";
      this.bKaydet.Size = new Size(163, 74);
      this.bKaydet.TabIndex = 12;
      this.bKaydet.Text = "Kaydet";
      this.bKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bKaydet.UseVisualStyleBackColor = false;
      this.bKaydet.Click += new EventHandler(this.bKaydet_Click);
      this.bİptal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.bİptal.BackColor = Color.DimGray;
      this.bİptal.FlatAppearance.BorderColor = Color.DimGray;
      this.bİptal.FlatStyle = FlatStyle.Flat;
      this.bİptal.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bİptal.ForeColor = SystemColors.ButtonHighlight;
      this.bİptal.Image = (Image) Resources.cancel24;
      this.bİptal.Location = new Point(830, 273);
      this.bİptal.Margin = new Padding(1);
      this.bİptal.Name = "bİptal";
      this.bİptal.Size = new Size(166, 74);
      this.bİptal.TabIndex = 13;
      this.bİptal.Text = "İptal";
      this.bİptal.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bİptal.UseVisualStyleBackColor = false;
      this.bİptal.Click += new EventHandler(this.bİptal_Click);
      this.bBarkodOlustur.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.bBarkodOlustur.BackColor = Color.Sienna;
      this.bBarkodOlustur.FlatAppearance.BorderColor = Color.Sienna;
      this.bBarkodOlustur.FlatStyle = FlatStyle.Flat;
      this.bBarkodOlustur.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bBarkodOlustur.ForeColor = SystemColors.ButtonHighlight;
      this.bBarkodOlustur.Image = (Image) Resources.barcode4832;
      this.bBarkodOlustur.Location = new Point(294, 191);
      this.bBarkodOlustur.Margin = new Padding(1);
      this.bBarkodOlustur.Name = "bBarkodOlustur";
      this.bBarkodOlustur.Size = new Size(132, 102);
      this.bBarkodOlustur.TabIndex = 15;
      this.bBarkodOlustur.Text = "Barkod Oluştur";
      this.bBarkodOlustur.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bBarkodOlustur.UseVisualStyleBackColor = false;
      this.bBarkodOlustur.Click += new EventHandler(this.bBarkodOlustur_Click);
      this.bUrunGrubuEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.bUrunGrubuEkle.BackColor = Color.Coral;
      this.bUrunGrubuEkle.FlatAppearance.BorderColor = Color.Coral;
      this.bUrunGrubuEkle.FlatStyle = FlatStyle.Flat;
      this.bUrunGrubuEkle.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bUrunGrubuEkle.ForeColor = SystemColors.ButtonHighlight;
      this.bUrunGrubuEkle.Image = (Image) Resources.Ekle32;
      this.bUrunGrubuEkle.ImageAlign = ContentAlignment.TopCenter;
      this.bUrunGrubuEkle.Location = new Point(164, 191);
      this.bUrunGrubuEkle.Margin = new Padding(1);
      this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
      this.bUrunGrubuEkle.Size = new Size(128, 102);
      this.bUrunGrubuEkle.TabIndex = 14;
      this.bUrunGrubuEkle.Text = "Ürün Grubu Ekle";
      this.bUrunGrubuEkle.TextAlign = ContentAlignment.BottomCenter;
      this.bUrunGrubuEkle.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
      this.bUrunGrubuEkle.Click += new EventHandler(this.bUrunGrubuEkle_Click);
      this.tSatisFiyati5.BackColor = Color.White;
      this.tSatisFiyati5.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSatisFiyati5.Location = new Point(812, 212);
      this.tSatisFiyati5.Name = "tSatisFiyati5";
      this.tSatisFiyati5.Size = new Size(115, 29);
      this.tSatisFiyati5.TabIndex = 11;
      this.tSatisFiyati5.Text = "0";
      this.tSatisFiyati5.TextAlign = HorizontalAlignment.Right;
      this.tSatisFiyati4.BackColor = Color.White;
      this.tSatisFiyati4.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSatisFiyati4.Location = new Point(812, 168);
      this.tSatisFiyati4.Name = "tSatisFiyati4";
      this.tSatisFiyati4.Size = new Size(115, 29);
      this.tSatisFiyati4.TabIndex = 10;
      this.tSatisFiyati4.Text = "0";
      this.tSatisFiyati4.TextAlign = HorizontalAlignment.Right;
      this.tUrunid.BackColor = Color.White;
      this.tUrunid.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunid.Location = new Point(554, 162);
      this.tUrunid.Name = "tUrunid";
      this.tUrunid.ReadOnly = true;
      this.tUrunid.Size = new Size(115, 29);
      this.tUrunid.TabIndex = 7;
      this.tUrunid.TabStop = false;
      this.tUrunid.Text = "0";
      this.tUrunid.TextAlign = HorizontalAlignment.Right;
      this.tKdvOrani.BackColor = Color.White;
      this.tKdvOrani.Font = new Font("Microsoft Sans Serif", 12f);
      this.tKdvOrani.Location = new Point(554, 123);
      this.tKdvOrani.Name = "tKdvOrani";
      this.tKdvOrani.Size = new Size(115, 29);
      this.tKdvOrani.TabIndex = 6;
      this.tKdvOrani.Text = "0";
      this.tKdvOrani.TextAlign = HorizontalAlignment.Right;
      this.tSatisFiyati3.BackColor = Color.White;
      this.tSatisFiyati3.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSatisFiyati3.Location = new Point(812, 123);
      this.tSatisFiyati3.Name = "tSatisFiyati3";
      this.tSatisFiyati3.Size = new Size(115, 29);
      this.tSatisFiyati3.TabIndex = 9;
      this.tSatisFiyati3.Text = "0";
      this.tSatisFiyati3.TextAlign = HorizontalAlignment.Right;
      this.tMiktar.BackColor = Color.White;
      this.tMiktar.Font = new Font("Microsoft Sans Serif", 12f);
      this.tMiktar.Location = new Point(554, 82);
      this.tMiktar.Name = "tMiktar";
      this.tMiktar.Size = new Size(115, 29);
      this.tMiktar.TabIndex = 5;
      this.tMiktar.Text = "0";
      this.tMiktar.TextAlign = HorizontalAlignment.Right;
      this.tSatisFiyati2.BackColor = Color.White;
      this.tSatisFiyati2.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSatisFiyati2.Location = new Point(812, 77);
      this.tSatisFiyati2.Name = "tSatisFiyati2";
      this.tSatisFiyati2.Size = new Size(115, 29);
      this.tSatisFiyati2.TabIndex = 8;
      this.tSatisFiyati2.Text = "0";
      this.tSatisFiyati2.TextAlign = HorizontalAlignment.Right;
      this.tSatisFiyati.BackColor = Color.White;
      this.tSatisFiyati.Font = new Font("Microsoft Sans Serif", 12f);
      this.tSatisFiyati.Location = new Point(812, 29);
      this.tSatisFiyati.Name = "tSatisFiyati";
      this.tSatisFiyati.Size = new Size(115, 29);
      this.tSatisFiyati.TabIndex = 7;
      this.tSatisFiyati.Text = "0";
      this.tSatisFiyati.TextAlign = HorizontalAlignment.Right;
      this.lid.AutoSize = true;
      this.lid.Font = new Font("Microsoft Sans Serif", 12f);
      this.lid.ForeColor = Color.DarkCyan;
      this.lid.Location = new Point(514, 168);
      this.lid.Name = "lid";
      this.lid.Size = new Size(31, 25);
      this.lid.TabIndex = 11;
      this.lid.Text = "ID";
      this.tAlısFiyati.BackColor = Color.White;
      this.tAlısFiyati.Font = new Font("Microsoft Sans Serif", 12f);
      this.tAlısFiyati.Location = new Point(554, 41);
      this.tAlısFiyati.Name = "tAlısFiyati";
      this.tAlısFiyati.Size = new Size(115, 29);
      this.tAlısFiyati.TabIndex = 4;
      this.tAlısFiyati.Text = "0";
      this.tAlısFiyati.TextAlign = HorizontalAlignment.Right;
      this.lstandart8.AutoSize = true;
      this.lstandart8.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart8.ForeColor = Color.DarkCyan;
      this.lstandart8.Location = new Point(442, (int) sbyte.MaxValue);
      this.lstandart8.Name = "lstandart8";
      this.lstandart8.Size = new Size(106, 25);
      this.lstandart8.TabIndex = 11;
      this.lstandart8.Text = "Kdv Oranı:";
      this.lstandart7.AutoSize = true;
      this.lstandart7.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart7.ForeColor = Color.DarkCyan;
      this.lstandart7.Location = new Point(474, 85);
      this.lstandart7.Name = "lstandart7";
      this.lstandart7.Size = new Size(71, 25);
      this.lstandart7.TabIndex = 10;
      this.lstandart7.Text = "Miktar:";
      this.lstandart14.AutoSize = true;
      this.lstandart14.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart14.ForeColor = Color.DarkCyan;
      this.lstandart14.Location = new Point(682, 212);
      this.lstandart14.Name = "lstandart14";
      this.lstandart14.Size = new Size(124, 25);
      this.lstandart14.TabIndex = 9;
      this.lstandart14.Text = "Satış Fiyatı5:";
      this.lstandart13.AutoSize = true;
      this.lstandart13.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart13.ForeColor = Color.DarkCyan;
      this.lstandart13.Location = new Point(686, 171);
      this.lstandart13.Name = "lstandart13";
      this.lstandart13.Size = new Size(124, 25);
      this.lstandart13.TabIndex = 9;
      this.lstandart13.Text = "Satış Fiyatı4:";
      this.lstandart12.AutoSize = true;
      this.lstandart12.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart12.ForeColor = Color.DarkCyan;
      this.lstandart12.Location = new Point(686, 125);
      this.lstandart12.Name = "lstandart12";
      this.lstandart12.Size = new Size(124, 25);
      this.lstandart12.TabIndex = 9;
      this.lstandart12.Text = "Satış Fiyatı3:";
      this.lstandart11.AutoSize = true;
      this.lstandart11.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart11.ForeColor = Color.DarkCyan;
      this.lstandart11.Location = new Point(686, 81);
      this.lstandart11.Name = "lstandart11";
      this.lstandart11.Size = new Size(124, 25);
      this.lstandart11.TabIndex = 9;
      this.lstandart11.Text = "Satış Fiyatı2:";
      this.lstandart6.AutoSize = true;
      this.lstandart6.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart6.ForeColor = Color.DarkCyan;
      this.lstandart6.Location = new Point(697, 32);
      this.lstandart6.Name = "lstandart6";
      this.lstandart6.Size = new Size(113, 25);
      this.lstandart6.TabIndex = 9;
      this.lstandart6.Text = "Satış Fiyatı:";
      this.lstandart5.AutoSize = true;
      this.lstandart5.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart5.ForeColor = Color.DarkCyan;
      this.lstandart5.Location = new Point(447, 44);
      this.lstandart5.Name = "lstandart5";
      this.lstandart5.Size = new Size(101, 25);
      this.lstandart5.TabIndex = 8;
      this.lstandart5.Text = "Alış Fiyatı:";
      this.tAcıklama.BackColor = Color.White;
      this.tAcıklama.Font = new Font("Microsoft Sans Serif", 12f);
      this.tAcıklama.Location = new Point(176, 115);
      this.tAcıklama.Name = "tAcıklama";
      this.tAcıklama.Size = new Size(250, 29);
      this.tAcıklama.TabIndex = 2;
      this.tUrunAdi.BackColor = Color.White;
      this.tUrunAdi.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunAdi.Location = new Point(176, 77);
      this.tUrunAdi.Name = "tUrunAdi";
      this.tUrunAdi.Size = new Size(250, 29);
      this.tUrunAdi.TabIndex = 1;
      this.tbarkod.BackColor = Color.White;
      this.tbarkod.Font = new Font("Microsoft Sans Serif", 12f);
      this.tbarkod.Location = new Point(176, 39);
      this.tbarkod.Name = "tbarkod";
      this.tbarkod.Size = new Size(250, 29);
      this.tbarkod.TabIndex = 0;
      this.tbarkod.KeyDown += new KeyEventHandler(this.tbarkod_KeyDown);
      this.cmbUrunGrubu.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cmbUrunGrubu.FormattingEnabled = true;
      this.cmbUrunGrubu.Location = new Point(176, 150);
      this.cmbUrunGrubu.Name = "cmbUrunGrubu";
      this.cmbUrunGrubu.Size = new Size(250, 32);
      this.cmbUrunGrubu.TabIndex = 3;
      this.lstandart4.AutoSize = true;
      this.lstandart4.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart4.ForeColor = Color.DarkCyan;
      this.lstandart4.Location = new Point(37, 157);
      this.lstandart4.Name = "lstandart4";
      this.lstandart4.Size = new Size(119, 25);
      this.lstandart4.TabIndex = 3;
      this.lstandart4.Text = "Ürün Grubu:";
      this.lstandart3.AutoSize = true;
      this.lstandart3.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart3.ForeColor = Color.DarkCyan;
      this.lstandart3.Location = new Point(58, 119);
      this.lstandart3.Name = "lstandart3";
      this.lstandart3.Size = new Size(98, 25);
      this.lstandart3.TabIndex = 2;
      this.lstandart3.Text = "Açıklama:";
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(62, 81);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(94, 25);
      this.lstandart2.TabIndex = 1;
      this.lstandart2.Text = "Ürün Adı:";
      this.lstandart1.AutoSize = true;
      this.lstandart1.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart1.ForeColor = Color.DarkCyan;
      this.lstandart1.Location = new Point(76, 43);
      this.lstandart1.Name = "lstandart1";
      this.lstandart1.Size = new Size(80, 25);
      this.lstandart1.TabIndex = 0;
      this.lstandart1.Text = "Barkod:";
      this.GridUrunler.AllowUserToAddRows = false;
      this.GridUrunler.AllowUserToDeleteRows = false;
      this.GridUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridUrunler.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridUrunler.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridUrunler.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridUrunler.DefaultCellStyle = gridViewCellStyle1;
      this.GridUrunler.Dock = DockStyle.Fill;
      this.GridUrunler.EnableHeadersVisualStyles = false;
      this.GridUrunler.Location = new Point(0, 0);
      this.GridUrunler.Margin = new Padding(1);
      this.GridUrunler.Name = "GridUrunler";
      this.GridUrunler.ReadOnly = true;
      this.GridUrunler.RowHeadersVisible = false;
      this.GridUrunler.RowHeadersWidth = 49;
      gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle2.BackColor = Color.White;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle2.ForeColor = Color.Black;
      gridViewCellStyle2.Padding = new Padding(3);
      gridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle2.WrapMode = DataGridViewTriState.True;
      this.GridUrunler.RowsDefaultCellStyle = gridViewCellStyle2;
      this.GridUrunler.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridUrunler.RowTemplate.Height = 33;
      this.GridUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridUrunler.Size = new Size(1202, 277);
      this.GridUrunler.TabIndex = 0;
      this.GridUrunler.CellDoubleClick += new DataGridViewCellEventHandler(this.GridUrunler_CellDoubleClick);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1202, 629);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fUrunGiris);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ürün Giriş Formu";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fUrunGiris_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.GridUrunler).EndInit();
      this.ResumeLayout(false);
    }
  }
}
