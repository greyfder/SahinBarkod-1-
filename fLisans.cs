// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fLisans
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fLisans : Form
  {
    private IContainer components = (IContainer) null;
    private tstandart tLisansno;
    private lstandart lstandart2;
    internal lstandart lKontrolNo;
    private Button bTamam;

    public fLisans() => this.InitializeComponent();

    private void bTamam_Click(object sender, EventArgs e)
    {
      if (!(this.tLisansno.Text != ""))
        return;
      new Kontrol().Lisansla(this.tLisansno.Text);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.tLisansno = new tstandart();
      this.lstandart2 = new lstandart();
      this.lKontrolNo = new lstandart();
      this.bTamam = new Button();
      this.SuspendLayout();
      this.tLisansno.BackColor = Color.White;
      this.tLisansno.Font = new Font("Microsoft Sans Serif", 12f);
      this.tLisansno.Location = new Point(54, 86);
      this.tLisansno.Name = "tLisansno";
      this.tLisansno.Size = new Size(250, 29);
      this.tLisansno.TabIndex = 1;
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(49, 9);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(150, 25);
      this.lstandart2.TabIndex = 0;
      this.lstandart2.Text = "KONTROL NO:";
      this.lKontrolNo.AutoSize = true;
      this.lKontrolNo.Font = new Font("Microsoft Sans Serif", 12f);
      this.lKontrolNo.ForeColor = Color.DarkCyan;
      this.lKontrolNo.Location = new Point(49, 47);
      this.lKontrolNo.Name = "lKontrolNo";
      this.lKontrolNo.Size = new Size(97, 25);
      this.lKontrolNo.TabIndex = 0;
      this.lKontrolNo.Text = "lstandart1";
      this.bTamam.Location = new Point(71, 150);
      this.bTamam.Name = "bTamam";
      this.bTamam.Size = new Size(166, 56);
      this.bTamam.TabIndex = 2;
      this.bTamam.Text = "Ekle";
      this.bTamam.UseVisualStyleBackColor = true;
      this.bTamam.Click += new EventHandler(this.bTamam_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(329, 267);
      this.Controls.Add((Control) this.bTamam);
      this.Controls.Add((Control) this.tLisansno);
      this.Controls.Add((Control) this.lstandart2);
      this.Controls.Add((Control) this.lKontrolNo);
      this.Name = nameof (fLisans);
      this.Text = "LİSANS İŞLEMİ";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
