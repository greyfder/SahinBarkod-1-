// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fUrunGrubuIslemleri
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fUrunGrubuIslemleri : Form
  {
    private Barkod1Entities db = new Barkod1Entities();
    private IContainer components = (IContainer) null;
    private lstandart lstandart1;
    private tstandart tUrunGrupAd;
    private ListBox listurungrup;
    private bstandart bEkle;
    private bstandart bSil;

    public fUrunGrubuIslemleri() => this.InitializeComponent();

    private void fUrunGrubuIslemleri_Load(object sender, EventArgs e) => this.GrupDoldur();

    private void bEkle_Click(object sender, EventArgs e)
    {
      if (this.tUrunGrupAd.Text != "")
      {
        this.db.UrunGrup.Add(new UrunGrup()
        {
          UrunGrupAd = this.tUrunGrupAd.Text
        });
        this.db.SaveChanges();
        this.GrupDoldur();
        this.tUrunGrupAd.Clear();
        int num = (int) MessageBox.Show("Ürün Grubu Eklenmiştir.");
        ((fUrunGiris) Application.OpenForms["fUrunGiris"])?.GrupDoldur();
      }
      else
      {
        int num1 = (int) MessageBox.Show("Mesaj Bilgisi Ekleyiniz.");
      }
    }

    private void GrupDoldur()
    {
      this.listurungrup.DisplayMember = "UrunGrupAd";
      this.listurungrup.ValueMember = "Id";
      this.listurungrup.DataSource = (object) this.db.UrunGrup.OrderBy<UrunGrup, string>((Expression<Func<UrunGrup, string>>) (a => a.UrunGrupAd)).ToList<UrunGrup>();
    }

    private void bSil_Click(object sender, EventArgs e)
    {
      int grupid = Convert.ToInt32(this.listurungrup.SelectedValue.ToString());
      string text = this.listurungrup.Text;
      if (MessageBox.Show(text + "Grubu Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo) != DialogResult.Yes)
        return;
      this.db.UrunGrup.Remove(this.db.UrunGrup.FirstOrDefault<UrunGrup>((Expression<Func<UrunGrup, bool>>) (x => x.Id == grupid)));
      this.db.SaveChanges();
      this.GrupDoldur();
      this.tUrunGrupAd.Focus();
      int num = (int) MessageBox.Show(text + "Ürünü Silindi.");
      ((fUrunGiris) Application.OpenForms["fUrunGiris"])?.GrupDoldur();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fUrunGrubuIslemleri));
      this.listurungrup = new ListBox();
      this.bEkle = new bstandart();
      this.tUrunGrupAd = new tstandart();
      this.lstandart1 = new lstandart();
      this.bSil = new bstandart();
      this.SuspendLayout();
      this.listurungrup.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.listurungrup.FormattingEnabled = true;
      this.listurungrup.ItemHeight = 24;
      this.listurungrup.Location = new Point(17, 73);
      this.listurungrup.Name = "listurungrup";
      this.listurungrup.Size = new Size(250, 244);
      this.listurungrup.TabIndex = 2;
      this.bEkle.BackColor = Color.Tomato;
      this.bEkle.FlatAppearance.BorderColor = Color.Tomato;
      this.bEkle.FlatStyle = FlatStyle.Flat;
      this.bEkle.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bEkle.ForeColor = SystemColors.ButtonHighlight;
      this.bEkle.Image = (Image) Resources.Ekle24;
      this.bEkle.Location = new Point(138, 321);
      this.bEkle.Margin = new Padding(1);
      this.bEkle.Name = "bEkle";
      this.bEkle.Size = new Size(129, 73);
      this.bEkle.TabIndex = 0;
      this.bEkle.Text = "Ekle";
      this.bEkle.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bEkle.UseVisualStyleBackColor = false;
      this.bEkle.Click += new EventHandler(this.bEkle_Click);
      this.tUrunGrupAd.BackColor = Color.White;
      this.tUrunGrupAd.Font = new Font("Microsoft Sans Serif", 12f);
      this.tUrunGrupAd.Location = new Point(17, 37);
      this.tUrunGrupAd.Name = "tUrunGrupAd";
      this.tUrunGrupAd.Size = new Size(250, 29);
      this.tUrunGrupAd.TabIndex = 1;
      this.lstandart1.AutoSize = true;
      this.lstandart1.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart1.ForeColor = Color.DarkCyan;
      this.lstandart1.Location = new Point(12, 9);
      this.lstandart1.Name = "lstandart1";
      this.lstandart1.Size = new Size(153, 25);
      this.lstandart1.TabIndex = 0;
      this.lstandart1.Text = "Ürün Grubu Adı:";
      this.bSil.BackColor = Color.Maroon;
      this.bSil.FlatAppearance.BorderColor = Color.Maroon;
      this.bSil.FlatStyle = FlatStyle.Flat;
      this.bSil.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bSil.ForeColor = SystemColors.ButtonHighlight;
      this.bSil.Image = (Image) Resources.clear4848;
      this.bSil.Location = new Point(17, 321);
      this.bSil.Margin = new Padding(1);
      this.bSil.Name = "bSil";
      this.bSil.Size = new Size(119, 73);
      this.bSil.TabIndex = 3;
      this.bSil.Text = "Sil";
      this.bSil.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bSil.UseVisualStyleBackColor = false;
      this.bSil.Click += new EventHandler(this.bSil_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(281, 404);
      this.Controls.Add((Control) this.bSil);
      this.Controls.Add((Control) this.bEkle);
      this.Controls.Add((Control) this.listurungrup);
      this.Controls.Add((Control) this.tUrunGrupAd);
      this.Controls.Add((Control) this.lstandart1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fUrunGrubuIslemleri);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (fUrunGrubuIslemleri);
      this.Load += new EventHandler(this.fUrunGrubuIslemleri_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
