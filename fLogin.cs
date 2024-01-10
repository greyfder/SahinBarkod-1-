// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fLogin
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using Lisans;
using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fLogin : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private TextBox tKullaniciAdi;
    private Label label2;
    private TextBox tSifre;
    private PictureBox pictureBox1;
    private Label label3;
    private Label label4;
    private Button bGiris;
    private Button button1;

    public fLogin() => this.InitializeComponent();

    private void girisyap()
    {
      if (!(this.tKullaniciAdi.Text != "") || !(this.tSifre.Text != ""))
        return;
      try
      {
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          if (barkod1Entities.Kullanici.Any<Kullanici>())
          {
            Kullanici kullanici = barkod1Entities.Kullanici.Where<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.KullaniciAd == this.tKullaniciAdi.Text && x.Sifre == this.tSifre.Text)).FirstOrDefault<Kullanici>();
            if (kullanici != null)
            {
              Cursor.Current = Cursors.WaitCursor;
              if (new Kontrol().KontolYap())
              {
                fBaslangic fBaslangic = new fBaslangic();
                Button bSatisislemi = fBaslangic.bSatisislemi;
                bool? nullable = kullanici.Satis;
                int num1 = nullable.Value ? 1 : 0;
                bSatisislemi.Enabled = num1 != 0;
                Button bGenelRapor = fBaslangic.bGenelRapor;
                nullable = kullanici.Rapor;
                int num2 = nullable.Value ? 1 : 0;
                bGenelRapor.Enabled = num2 != 0;
                Button bStok = fBaslangic.bStok;
                nullable = kullanici.Stok;
                int num3 = nullable.Value ? 1 : 0;
                bStok.Enabled = num3 != 0;
                Button bUrunGiris = fBaslangic.bUrunGiris;
                nullable = kullanici.UrunGiris;
                int num4 = nullable.Value ? 1 : 0;
                bUrunGiris.Enabled = num4 != 0;
                Button bAyarlar = fBaslangic.bAyarlar;
                nullable = kullanici.Ayarlar;
                int num5 = nullable.Value ? 1 : 0;
                bAyarlar.Enabled = num5 != 0;
                Button bYedekleme = fBaslangic.bYedekleme;
                nullable = kullanici.Yedekleme;
                int num6 = nullable.Value ? 1 : 0;
                bYedekleme.Enabled = num6 != 0;
                fBaslangic.lKullanici.Text = kullanici.AdSoyad;
                Sabit sabit = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
                fBaslangic.lisyeri.Text = sabit.Unvan;
                fBaslangic.Show();
                this.Hide();
              }
              Cursor.Current = Cursors.Default;
            }
            else
            {
              int num = (int) MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
          }
          else
          {
            Cursor.Current = Cursors.WaitCursor;
            barkod1Entities.Kullanici.Add(new Kullanici()
            {
              AdSoyad = "admin",
              Ayarlar = new bool?(true),
              EPosta = "eposta",
              FiyatGuncelle = new bool?(true),
              KullaniciAd = "admin",
              Rapor = new bool?(true),
              Satis = new bool?(true),
              Sifre = "admin",
              Stok = new bool?(true),
              Telefon = "telefon",
              UrunGiris = new bool?(true),
              Yedekleme = new bool?(true)
            });
            barkod1Entities.SaveChanges();
            Kullanici kullanici = barkod1Entities.Kullanici.Where<Kullanici>((Expression<Func<Kullanici, bool>>) (x => x.KullaniciAd == this.tKullaniciAdi.Text && x.Sifre == this.tSifre.Text)).FirstOrDefault<Kullanici>();
            fBaslangic fBaslangic = new fBaslangic();
            fBaslangic.bSatisislemi.Enabled = kullanici.Satis.Value;
            fBaslangic.bGenelRapor.Enabled = kullanici.Rapor.Value;
            fBaslangic.bStok.Enabled = kullanici.Stok.Value;
            fBaslangic.bUrunGiris.Enabled = kullanici.UrunGiris.Value;
            Button bAyarlar = fBaslangic.bAyarlar;
            bool? nullable = kullanici.Ayarlar;
            int num7 = nullable.Value ? 1 : 0;
            bAyarlar.Enabled = num7 != 0;
            Button bYedekleme = fBaslangic.bYedekleme;
            nullable = kullanici.Yedekleme;
            int num8 = nullable.Value ? 1 : 0;
            bYedekleme.Enabled = num8 != 0;
            Button bFiyatGuncelle = fBaslangic.bFiyatGuncelle;
            nullable = kullanici.FiyatGuncelle;
            int num9 = nullable.Value ? 1 : 0;
            bFiyatGuncelle.Enabled = num9 != 0;
            fBaslangic.lKullanici.Text = kullanici.AdSoyad;
            Sabit sabit = barkod1Entities.Sabit.FirstOrDefault<Sabit>();
            fBaslangic.lisyeri.Text = sabit.Unvan;
            fBaslangic.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
          }
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void bGiris_Click(object sender, EventArgs e) => this.girisyap();

    private void bGiris_KeyDown(object sender, KeyEventArgs e)
    {
    }

    private void fLogin_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this.girisyap();
    }

    private void fLogin_Load(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lic lic = new lic();
      this.label1.Text = lic.CpuNo() + "\n" + lic.CpuKarekterToplam().ToString();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fLogin));
      this.label1 = new Label();
      this.tKullaniciAdi = new TextBox();
      this.label2 = new Label();
      this.tSifre = new TextBox();
      this.pictureBox1 = new PictureBox();
      this.label3 = new Label();
      this.label4 = new Label();
      this.bGiris = new Button();
      this.button1 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.ForeColor = SystemColors.ControlLightLight;
      this.label1.Location = new Point(17, 141);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(151, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "Kullanıcı Adı:";
      this.tKullaniciAdi.Location = new Point(181, 138);
      this.tKullaniciAdi.Margin = new Padding(4, 3, 4, 3);
      this.tKullaniciAdi.Name = "tKullaniciAdi";
      this.tKullaniciAdi.Size = new Size(204, 33);
      this.tKullaniciAdi.TabIndex = 0;
      this.label2.AutoSize = true;
      this.label2.ForeColor = SystemColors.ControlLightLight;
      this.label2.Location = new Point(99, 186);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(69, 29);
      this.label2.TabIndex = 0;
      this.label2.Text = "Şifre:";
      this.tSifre.Location = new Point(181, 186);
      this.tSifre.Margin = new Padding(4, 3, 4, 3);
      this.tSifre.Name = "tSifre";
      this.tSifre.PasswordChar = '*';
      this.tSifre.Size = new Size(204, 33);
      this.tSifre.TabIndex = 1;
      this.pictureBox1.Image = (Image) Resources.scan_barcode_with_scanner_tool;
      this.pictureBox1.Location = new Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(100, 110);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Segoe Print", 16f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label3.ForeColor = SystemColors.ControlLightLight;
      this.label3.Location = new Point(186, 90);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(344, 45);
      this.label3.TabIndex = 0;
      this.label3.Text = "Barkodlu Satış Programı";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Segoe Print", 30f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.label4.ForeColor = SystemColors.ControlLightLight;
      this.label4.Location = new Point(119, 9);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(422, 84);
      this.label4.TabIndex = 0;
      this.label4.Text = "Şahin Şahinoğlu";
      this.bGiris.BackColor = Color.Teal;
      this.bGiris.FlatAppearance.BorderColor = Color.Teal;
      this.bGiris.FlatStyle = FlatStyle.Flat;
      this.bGiris.ForeColor = SystemColors.ControlLightLight;
      this.bGiris.Location = new Point(392, 138);
      this.bGiris.Name = "bGiris";
      this.bGiris.Size = new Size(138, 81);
      this.bGiris.TabIndex = 3;
      this.bGiris.Text = "Giriş";
      this.bGiris.UseVisualStyleBackColor = false;
      this.bGiris.Click += new EventHandler(this.bGiris_Click);
      this.bGiris.KeyDown += new KeyEventHandler(this.bGiris_KeyDown);
      this.button1.Location = new Point(143, 39);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 44);
      this.button1.TabIndex = 4;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(13f, 26f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.DimGray;
      this.ClientSize = new Size(553, 239);
      this.Controls.Add((Control) this.bGiris);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.tSifre);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.tKullaniciAdi);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Margin = new Padding(5, 4, 5, 4);
      this.Name = nameof (fLogin);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Load += new EventHandler(this.fLogin_Load);
      this.KeyDown += new KeyEventHandler(this.fLogin_KeyDown);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
