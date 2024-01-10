// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fDetayGöster
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fDetayGöster : Form
  {
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private lstandart lislemno;
    private gridozel GridListe;

    public fDetayGöster() => this.InitializeComponent();

    public int İslemNo { get; set; }

    private void fDetayGöster_Load(object sender, EventArgs e)
    {
      this.lislemno.Text = "İşlem No : " + this.İslemNo.ToString();
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        this.GridListe.DataSource = (object) barkod1Entities.Satisid.Select(s => new
        {
          islemno = s.islemno,
          Urunad = s.Urunad,
          Miktar = s.Miktar,
          Satisfiyat = s.Satisfiyat,
          Toplam = s.Toplam
        }).Where(x => x.islemno == (int?) this.İslemNo).ToList();
        islemler.GridDuzenle((DataGridView) this.GridListe);
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
      DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fDetayGöster));
      this.splitContainer1 = new SplitContainer();
      this.lislemno = new lstandart();
      this.GridListe = new gridozel();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.GridListe).BeginInit();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.lislemno);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridListe);
      this.splitContainer1.Size = new Size(800, 450);
      this.splitContainer1.SplitterDistance = 42;
      this.splitContainer1.TabIndex = 0;
      this.lislemno.AutoSize = true;
      this.lislemno.Font = new Font("Microsoft Sans Serif", 12f);
      this.lislemno.ForeColor = Color.DarkCyan;
      this.lislemno.Location = new Point(12, 9);
      this.lislemno.Name = "lislemno";
      this.lislemno.Size = new Size(83, 25);
      this.lislemno.TabIndex = 0;
      this.lislemno.Text = "lislemno";
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
      this.GridListe.Size = new Size(800, 404);
      this.GridListe.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fDetayGöster);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Detay Göster";
      this.Load += new EventHandler(this.fDetayGöster_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.GridListe).EndInit();
      this.ResumeLayout(false);
    }
  }
}
