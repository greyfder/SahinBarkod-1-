// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fRaporEkle
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using Microsoft.Reporting.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fRaporEkle : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    public ReportViewer reportViewer1;

    public fRaporEkle() => this.InitializeComponent();

    private void fRaporEkle_Load(object sender, EventArgs e)
    {
      this.reportViewer1.Dock = DockStyle.Fill;
      this.reportViewer1.RefreshReport();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fRaporEkle));
      this.panel1 = new Panel();
      this.reportViewer1 = new ReportViewer();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.reportViewer1);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(800, 450);
      this.panel1.TabIndex = 0;
      this.reportViewer1.Dock = DockStyle.Fill;
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "SahinBarkod_1_.rpGenelRapor.rdlc";
      this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\ŞAHİNŞAHİN\\Source\\Repos\\SahinBarkod(1)\\SahinBarkod(1)\\bin\\Debug\\rpGenelRapor.rdlc";
      this.reportViewer1.Location = new Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = (string) null;
      this.reportViewer1.Size = new Size(800, 450);
      this.reportViewer1.TabIndex = 0;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fRaporEkle);
      this.Text = nameof (fRaporEkle);
      this.Load += new EventHandler(this.fRaporEkle_Load);
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
