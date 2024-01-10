// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fFiyatGuncelle
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using Microsoft.Web.WebView2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fFiyatGuncelle : Form
  {
    private bool sayi = false;
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private Button button1;
    private Button b200;
    private Microsoft.Web.WebView2.WinForms.WebView2 webView21;

    public fFiyatGuncelle()
    {
      this.InitializeComponent();
      this.InitializeAsync();
    }

    private void fFiyatGuncelle_Load(object sender, EventArgs e)
    {
    }

    private async void InitializeAsync() => await this.webView21.EnsureCoreWebView2Async();

    private void b200_Click(object sender, EventArgs e) => this.Close();

    private void WebView_CoreWebView2Ready(object sender, EventArgs e) => this.Close();

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.sayi)
        {
          this.webView21.CoreWebView2.Navigate("https://dovizborsa.com/doviz/");
          this.sayi = true;
        }
        else
        {
          this.webView21.CoreWebView2.Navigate("https://haremaltin.com/canli-piyasalar/");
          this.sayi = false;
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fFiyatGuncelle));
      this.splitContainer1 = new SplitContainer();
      this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
      this.splitContainer2 = new SplitContainer();
      this.button1 = new Button();
      this.b200 = new Button();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.webView21).BeginInit();
      this.splitContainer2.BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel2;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.webView21);
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Size = new Size(1082, 855);
      this.splitContainer1.SplitterDistance = 769;
      this.splitContainer1.TabIndex = 1;
      this.webView21.AllowExternalDrop = true;
      this.webView21.CreationProperties = (CoreWebView2CreationProperties) null;
      this.webView21.DefaultBackgroundColor = Color.White;
      this.webView21.Dock = DockStyle.Fill;
      this.webView21.Location = new Point(0, 0);
      this.webView21.Name = "webView21";
      this.webView21.Size = new Size(1082, 769);
      this.webView21.Source = new Uri("https://haremaltin.com/canli-piyasalar/", UriKind.Absolute);
      this.webView21.TabIndex = 0;
      this.webView21.ZoomFactor = 1.0;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Panel1.Controls.Add((Control) this.button1);
      this.splitContainer2.Panel2.Controls.Add((Control) this.b200);
      this.splitContainer2.Size = new Size(1082, 82);
      this.splitContainer2.SplitterDistance = 544;
      this.splitContainer2.TabIndex = 0;
      this.button1.BackColor = Color.RosyBrown;
      this.button1.Dock = DockStyle.Fill;
      this.button1.FlatAppearance.BorderColor = Color.DimGray;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.button1.ForeColor = Color.White;
      this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
      this.button1.Location = new Point(0, 0);
      this.button1.Margin = new Padding(1);
      this.button1.Name = "button1";
      this.button1.Size = new Size(544, 82);
      this.button1.TabIndex = 7;
      this.button1.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.b200.BackColor = Color.DimGray;
      this.b200.Dock = DockStyle.Fill;
      this.b200.FlatAppearance.BorderColor = Color.DimGray;
      this.b200.FlatStyle = FlatStyle.Flat;
      this.b200.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.b200.ForeColor = Color.White;
      this.b200.Image = (Image) componentResourceManager.GetObject("b200.Image");
      this.b200.Location = new Point(0, 0);
      this.b200.Margin = new Padding(1);
      this.b200.Name = "b200";
      this.b200.Size = new Size(534, 82);
      this.b200.TabIndex = 6;
      this.b200.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.b200.UseVisualStyleBackColor = false;
      this.b200.Click += new EventHandler(this.WebView_CoreWebView2Ready);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1082, 855);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fFiyatGuncelle);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Döviz";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fFiyatGuncelle_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.webView21).EndInit();
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel2.ResumeLayout(false);
      this.splitContainer2.EndInit();
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
