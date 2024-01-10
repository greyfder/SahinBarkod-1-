// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fGelirGider
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
  public class fGelirGider : Form
  {
    private IContainer components = (IContainer) null;
    private lstandart lGelirGider;
    private ComboBox cmİslemTuru;
    private lstandart tOdemeTuru;
    private tnumeric tNakit;
    private tnumeric tKart;
    private lstandart lNakit;
    private lstandart lKart;
    private tstandart tAcıklama;
    private lstandart lstandart2;
    private lstandart lstandart3;
    private DateTimePicker dtTarih;
    private bstandart bEkle;

    public fGelirGider() => this.InitializeComponent();

    public string gelirgider { get; set; }

    public string kullanici { get; set; }

    private void fGelirGider_Load(object sender, EventArgs e) => this.lGelirGider.Text = this.gelirgider + " İŞLEMİ YAPILIYOR.";

    private void cmİslemTuru_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.cmİslemTuru.SelectedIndex == 0)
      {
        this.tNakit.Enabled = true;
        this.tKart.Enabled = false;
      }
      else if (this.cmİslemTuru.SelectedIndex == 1)
      {
        this.tNakit.Enabled = false;
        this.tKart.Enabled = true;
      }
      else if (this.cmİslemTuru.SelectedIndex == 2)
      {
        this.tNakit.Enabled = true;
        this.tKart.Enabled = true;
      }
      this.tNakit.Text = "0";
      this.tKart.Text = "0";
    }

    private void bEkle_Click(object sender, EventArgs e)
    {
      if (this.cmİslemTuru.Text != "")
      {
        if (!(this.tNakit.Text != "") && (!(this.tKart.Text != "") || !(this.tNakit.Text != "0") || !(this.tKart.Text != "0")))
          return;
        using (Barkod1Entities barkod1Entities = new Barkod1Entities())
        {
          islemOzet entity = new islemOzet();
          entity.İslemNo = new int?(0);
          entity.İade = new bool?(false);
          entity.OdemeSekli = this.cmİslemTuru.Text;
          entity.Nakit = new double?(islemler.DoubleYap(this.tNakit.Text));
          entity.Kart = new double?(islemler.DoubleYap(this.tKart.Text));
          if (this.gelirgider == "GELİR")
          {
            entity.Gelir = new bool?(true);
            entity.Gider = new bool?(false);
          }
          else
          {
            entity.Gider = new bool?(false);
            entity.Gider = new bool?(true);
          }
          entity.AlısFiyatToplam = new double?(0.0);
          entity.Acıklama = this.gelirgider + " - işlemi " + this.tAcıklama.Text;
          entity.Tarih = new DateTime?(this.dtTarih.Value);
          entity.Kullanici = this.kullanici;
          barkod1Entities.islemOzet.Add(entity);
          barkod1Entities.SaveChanges();
          int num = (int) MessageBox.Show(this.gelirgider + " işlemi kaydedildi.");
          this.tNakit.Text = "0";
          this.tKart.Text = "0";
          this.tAcıklama.Text = "";
          this.cmİslemTuru.Text = "";
          ((fRapor) Application.OpenForms["fRapor"])?.bGöster_Click((object) null, (EventArgs) null);
          this.Hide();
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("LÜtfen Ödeme Türünü Belirleyiniz.");
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fGelirGider));
      this.cmİslemTuru = new ComboBox();
      this.dtTarih = new DateTimePicker();
      this.bEkle = new bstandart();
      this.lstandart3 = new lstandart();
      this.lstandart2 = new lstandart();
      this.tAcıklama = new tstandart();
      this.lKart = new lstandart();
      this.lNakit = new lstandart();
      this.tKart = new tnumeric();
      this.tNakit = new tnumeric();
      this.tOdemeTuru = new lstandart();
      this.lGelirGider = new lstandart();
      this.SuspendLayout();
      this.cmİslemTuru.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmİslemTuru.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.cmİslemTuru.FormattingEnabled = true;
      this.cmİslemTuru.Items.AddRange(new object[3]
      {
        (object) "NAKİT",
        (object) "KART",
        (object) "KART-NAKİT"
      });
      this.cmİslemTuru.Location = new Point(12, 79);
      this.cmİslemTuru.Name = "cmİslemTuru";
      this.cmİslemTuru.Size = new Size(281, 32);
      this.cmİslemTuru.TabIndex = 2;
      this.cmİslemTuru.SelectedIndexChanged += new EventHandler(this.cmİslemTuru_SelectedIndexChanged);
      this.dtTarih.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dtTarih.Location = new Point(12, 409);
      this.dtTarih.Name = "dtTarih";
      this.dtTarih.Size = new Size(281, 29);
      this.dtTarih.TabIndex = 10;
      this.bEkle.BackColor = Color.Tomato;
      this.bEkle.FlatAppearance.BorderColor = Color.Tomato;
      this.bEkle.FlatStyle = FlatStyle.Flat;
      this.bEkle.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bEkle.ForeColor = SystemColors.ButtonHighlight;
      this.bEkle.Image = (Image) Resources.Ekle32;
      this.bEkle.Location = new Point(158, 442);
      this.bEkle.Margin = new Padding(1);
      this.bEkle.Name = "bEkle";
      this.bEkle.Size = new Size(135, 69);
      this.bEkle.TabIndex = 11;
      this.bEkle.Text = " EKLE";
      this.bEkle.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bEkle.UseVisualStyleBackColor = false;
      this.bEkle.Click += new EventHandler(this.bEkle_Click);
      this.lstandart3.AutoSize = true;
      this.lstandart3.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart3.ForeColor = Color.DarkCyan;
      this.lstandart3.Location = new Point(13, 381);
      this.lstandart3.Name = "lstandart3";
      this.lstandart3.Size = new Size(57, 25);
      this.lstandart3.TabIndex = 9;
      this.lstandart3.Text = "Tarih";
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(18, 203);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(92, 25);
      this.lstandart2.TabIndex = 8;
      this.lstandart2.Text = "Açıklama";
      this.tAcıklama.BackColor = Color.White;
      this.tAcıklama.Font = new Font("Microsoft Sans Serif", 12f);
      this.tAcıklama.Location = new Point(12, 231);
      this.tAcıklama.Multiline = true;
      this.tAcıklama.Name = "tAcıklama";
      this.tAcıklama.Size = new Size(281, 133);
      this.tAcıklama.TabIndex = 7;
      this.lKart.AutoSize = true;
      this.lKart.Font = new Font("Microsoft Sans Serif", 12f);
      this.lKart.ForeColor = Color.DarkCyan;
      this.lKart.Location = new Point(144, 118);
      this.lKart.Name = "lKart";
      this.lKart.Size = new Size(48, 25);
      this.lKart.TabIndex = 6;
      this.lKart.Text = "Kart";
      this.lNakit.AutoSize = true;
      this.lNakit.Font = new Font("Microsoft Sans Serif", 12f);
      this.lNakit.ForeColor = Color.DarkCyan;
      this.lNakit.Location = new Point(15, 118);
      this.lNakit.Name = "lNakit";
      this.lNakit.Size = new Size(56, 25);
      this.lNakit.TabIndex = 5;
      this.lNakit.Text = "Nakit";
      this.tKart.BackColor = Color.White;
      this.tKart.Enabled = false;
      this.tKart.Font = new Font("Microsoft Sans Serif", 12f);
      this.tKart.Location = new Point(149, 149);
      this.tKart.Name = "tKart";
      this.tKart.Size = new Size(144, 29);
      this.tKart.TabIndex = 4;
      this.tKart.Text = "0";
      this.tKart.TextAlign = HorizontalAlignment.Center;
      this.tNakit.BackColor = Color.White;
      this.tNakit.Enabled = false;
      this.tNakit.Font = new Font("Microsoft Sans Serif", 12f);
      this.tNakit.Location = new Point(15, 149);
      this.tNakit.Name = "tNakit";
      this.tNakit.Size = new Size(128, 29);
      this.tNakit.TabIndex = 3;
      this.tNakit.Text = "0";
      this.tNakit.TextAlign = HorizontalAlignment.Center;
      this.tOdemeTuru.AutoSize = true;
      this.tOdemeTuru.Font = new Font("Microsoft Sans Serif", 12f);
      this.tOdemeTuru.ForeColor = Color.DarkCyan;
      this.tOdemeTuru.Location = new Point(13, 49);
      this.tOdemeTuru.Name = "tOdemeTuru";
      this.tOdemeTuru.Size = new Size(123, 25);
      this.tOdemeTuru.TabIndex = 0;
      this.tOdemeTuru.Text = "Ödeme Türü";
      this.lGelirGider.AutoSize = true;
      this.lGelirGider.Font = new Font("Microsoft Sans Serif", 12f);
      this.lGelirGider.ForeColor = Color.SaddleBrown;
      this.lGelirGider.Location = new Point(13, 13);
      this.lGelirGider.Name = "lGelirGider";
      this.lGelirGider.Size = new Size(136, 25);
      this.lGelirGider.TabIndex = 0;
      this.lGelirGider.Text = "GELİR-GİDER";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(303, 525);
      this.Controls.Add((Control) this.bEkle);
      this.Controls.Add((Control) this.dtTarih);
      this.Controls.Add((Control) this.lstandart3);
      this.Controls.Add((Control) this.lstandart2);
      this.Controls.Add((Control) this.tAcıklama);
      this.Controls.Add((Control) this.lKart);
      this.Controls.Add((Control) this.lNakit);
      this.Controls.Add((Control) this.tKart);
      this.Controls.Add((Control) this.tNakit);
      this.Controls.Add((Control) this.cmİslemTuru);
      this.Controls.Add((Control) this.tOdemeTuru);
      this.Controls.Add((Control) this.lGelirGider);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(321, 570);
      this.MinimumSize = new Size(321, 570);
      this.Name = nameof (fGelirGider);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Gelir-Gider İşlemleri";
      this.Load += new EventHandler(this.fGelirGider_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
