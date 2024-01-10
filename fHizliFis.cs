// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fHizliFis
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fHizliFis : Form
  {
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private gridozel GridListe;
    private DateTimePicker dtBitis;
    private lstandart lBitisTarih;
    private lstandart lBaslangıctarih;
    private DateTimePicker dtBaslangıc;
    private bstandart bGöster;
    private bstandart tYazdır;
    private bstandart bGetir;
    private Button bCikis;

    public fHizliFis() => this.InitializeComponent();

    private void bGöster_Click(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      DateTime baslangic = DateTime.Parse(this.dtBaslangıc.Value.ToShortDateString());
      DateTime bitis = DateTime.Parse(this.dtBitis.Value.ToShortDateString());
      bitis = bitis.AddDays(1.0);
      using (Barkod1Entities barkod1Entities = new Barkod1Entities())
      {
        barkod1Entities.islemOzet.Where<islemOzet>((Expression<Func<islemOzet, bool>>) (x => x.Tarih >= (DateTime?) baslangic && x.Tarih <= (DateTime?) bitis)).OrderByDescending<islemOzet, DateTime?>((Expression<Func<islemOzet, DateTime?>>) (x => x.Tarih)).Load();
        this.GridListe.DataSource = (object) barkod1Entities.islemOzet.Local.ToBindingList<islemOzet>();
        this.GridListe.Columns[7].Visible = false;
        this.GridListe.Columns[6].Visible = false;
        this.GridListe.Columns[8].Visible = false;
        this.GridListe.Columns[9].Visible = false;
        Cursor.Current = Cursors.Default;
      }
    }

    private void fHizliFis_Load(object sender, EventArgs e) => this.bGöster_Click((object) null, (EventArgs) null);

    private void GridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex != 2 && e.ColumnIndex != 6 && e.ColumnIndex != 7 || !(e.Value is bool))
        return;
      bool flag = (bool) e.Value;
      e.Value = flag ? (object) "Evet" : (object) "Hayır";
      e.FormattingApplied = true;
    }

    private void GridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
      {
        int num = (int) new fDetayGöster()
        {
          İslemNo = int32
        }.ShowDialog();
      }
    }

    private void tYazdır_Click(object sender, EventArgs e)
    {
      if (this.GridListe.Rows.Count <= 0)
        return;
      int int32 = Convert.ToInt32(this.GridListe.CurrentRow.Cells["İslemNo"].Value.ToString());
      if (int32 != 0)
        new Yazdir(new int?(int32)).YazdirmayaBasla();
      this.Close();
    }

    private void bGetir_Click(object sender, EventArgs e)
    {
      Form1 openForm = (Form1) Application.OpenForms["Form1"];
      openForm.didi = Convert.ToDouble(this.GridListe.CurrentRow.Cells["İslemNo"].Value);
      openForm.duzenle(openForm.didi);
      this.Close();
    }

    private void bCikis_Click(object sender, EventArgs e) => this.Close();

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
      this.splitContainer1 = new SplitContainer();
      this.bCikis = new Button();
      this.bGetir = new bstandart();
      this.tYazdır = new bstandart();
      this.bGöster = new bstandart();
      this.dtBitis = new DateTimePicker();
      this.lBitisTarih = new lstandart();
      this.lBaslangıctarih = new lstandart();
      this.dtBaslangıc = new DateTimePicker();
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
      this.splitContainer1.Panel1.Controls.Add((Control) this.bCikis);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bGetir);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tYazdır);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bGöster);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dtBitis);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lBitisTarih);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lBaslangıctarih);
      this.splitContainer1.Panel1.Controls.Add((Control) this.dtBaslangıc);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridListe);
      this.splitContainer1.Size = new Size(1082, 605);
      this.splitContainer1.SplitterDistance = 156;
      this.splitContainer1.TabIndex = 0;
      this.bCikis.BackColor = Color.DimGray;
      this.bCikis.FlatAppearance.BorderColor = Color.DimGray;
      this.bCikis.FlatStyle = FlatStyle.Flat;
      this.bCikis.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bCikis.ForeColor = Color.White;
      this.bCikis.Image = (Image) Resources.exit4854;
      this.bCikis.Location = new Point(891, 41);
      this.bCikis.Margin = new Padding(1);
      this.bCikis.Name = "bCikis";
      this.bCikis.Size = new Size(181, 85);
      this.bCikis.TabIndex = 22;
      this.bCikis.UseVisualStyleBackColor = false;
      this.bCikis.Click += new EventHandler(this.bCikis_Click);
      this.bGetir.BackColor = Color.LightCoral;
      this.bGetir.FlatAppearance.BorderColor = Color.Tomato;
      this.bGetir.FlatStyle = FlatStyle.Flat;
      this.bGetir.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bGetir.ForeColor = SystemColors.ButtonHighlight;
      this.bGetir.Image = (Image) Resources.goz24;
      this.bGetir.Location = new Point(502, 41);
      this.bGetir.Margin = new Padding(1);
      this.bGetir.Name = "bGetir";
      this.bGetir.Size = new Size(185, 86);
      this.bGetir.TabIndex = 12;
      this.bGetir.Text = "GETİR";
      this.bGetir.TextAlign = ContentAlignment.MiddleRight;
      this.bGetir.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.bGetir.UseVisualStyleBackColor = false;
      this.bGetir.Click += new EventHandler(this.bGetir_Click);
      this.tYazdır.BackColor = Color.RosyBrown;
      this.tYazdır.FlatAppearance.BorderColor = Color.Tomato;
      this.tYazdır.FlatStyle = FlatStyle.Flat;
      this.tYazdır.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tYazdır.ForeColor = SystemColors.ButtonHighlight;
      this.tYazdır.Image = (Image) Resources.printer;
      this.tYazdır.Location = new Point(701, 41);
      this.tYazdır.Margin = new Padding(1);
      this.tYazdır.Name = "tYazdır";
      this.tYazdır.Size = new Size(176, 85);
      this.tYazdır.TabIndex = 12;
      this.tYazdır.Text = "YAZDIR";
      this.tYazdır.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.tYazdır.UseVisualStyleBackColor = false;
      this.tYazdır.Click += new EventHandler(this.tYazdır_Click);
      this.bGöster.BackColor = Color.Tomato;
      this.bGöster.FlatAppearance.BorderColor = Color.Tomato;
      this.bGöster.FlatStyle = FlatStyle.Flat;
      this.bGöster.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bGöster.ForeColor = SystemColors.ButtonHighlight;
      this.bGöster.Image = (Image) Resources.Ara32;
      this.bGöster.Location = new Point(309, 42);
      this.bGöster.Margin = new Padding(1);
      this.bGöster.Name = "bGöster";
      this.bGöster.Size = new Size(181, 86);
      this.bGöster.TabIndex = 12;
      this.bGöster.Text = "Göster";
      this.bGöster.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bGöster.UseVisualStyleBackColor = false;
      this.bGöster.Click += new EventHandler(this.bGöster_Click);
      this.dtBitis.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dtBitis.Location = new Point(22, 99);
      this.dtBitis.Name = "dtBitis";
      this.dtBitis.Size = new Size(260, 29);
      this.dtBitis.TabIndex = 11;
      this.lBitisTarih.AutoSize = true;
      this.lBitisTarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBitisTarih.ForeColor = Color.DarkCyan;
      this.lBitisTarih.Location = new Point(17, 71);
      this.lBitisTarih.Name = "lBitisTarih";
      this.lBitisTarih.Size = new Size(108, 25);
      this.lBitisTarih.TabIndex = 10;
      this.lBitisTarih.Text = "Bitiş Tarihi:";
      this.lBaslangıctarih.AutoSize = true;
      this.lBaslangıctarih.Font = new Font("Microsoft Sans Serif", 12f);
      this.lBaslangıctarih.ForeColor = Color.DarkCyan;
      this.lBaslangıctarih.Location = new Point(17, 14);
      this.lBaslangıctarih.Name = "lBaslangıctarih";
      this.lBaslangıctarih.Size = new Size(157, 25);
      this.lBaslangıctarih.TabIndex = 9;
      this.lBaslangıctarih.Text = "Başlangıç Tarihi:";
      this.dtBaslangıc.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.dtBaslangıc.Location = new Point(22, 42);
      this.dtBaslangıc.Name = "dtBaslangıc";
      this.dtBaslangıc.Size = new Size(260, 29);
      this.dtBaslangıc.TabIndex = 8;
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
      this.GridListe.Size = new Size(1082, 445);
      this.GridListe.TabIndex = 3;
      this.GridListe.CellDoubleClick += new DataGridViewCellEventHandler(this.GridListe_CellDoubleClick);
      this.GridListe.CellFormatting += new DataGridViewCellFormattingEventHandler(this.GridListe_CellFormatting);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1082, 605);
      this.Controls.Add((Control) this.splitContainer1);
      this.Name = nameof (fHizliFis);
      this.Text = nameof (fHizliFis);
      this.Load += new EventHandler(this.fHizliFis_Load);
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
