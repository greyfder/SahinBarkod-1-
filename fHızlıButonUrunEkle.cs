// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fHızlıButonUrunEkle
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fHızlıButonUrunEkle : Form
  {
    private Barkod1Entities db = new Barkod1Entities();
    private IContainer components = (IContainer) null;
    private SplitContainer splitContainer1;
    private DataGridView GridUrunler;
    private CheckBox chtumu;
    private Label label6;
    private TextBox tUrunAra;
    private Label label1;
    public Label lbutonid;
    private bstandart bstandart1;
    private OpenFileDialog openFileDialog1;
    private PictureBox pictureBox1;
    private TextBox tResim;
    private Button bgeri;

    public fHızlıButonUrunEkle() => this.InitializeComponent();

    private void tUrunAra_TextChanged(object sender, EventArgs e)
    {
      if (this.tUrunAra.Text != "")
      {
        string urunad = this.tUrunAra.Text;
        this.GridUrunler.DataSource = (object) this.db.Urun.Where<Urun>((Expression<Func<Urun, bool>>) (a => a.UrunAd.Contains(urunad))).ToList<Urun>();
        this.GridUrunler.Columns[0].Width = 50;
        this.GridUrunler.Columns[1].Width = 150;
        this.GridUrunler.Columns[2].Width = 475;
        this.GridUrunler.Columns[3].Width = 95;
        this.GridUrunler.Columns[4].Width = 150;
        this.GridUrunler.Columns[5].Width = 60;
        this.GridUrunler.Columns[7].Width = 50;
        this.GridUrunler.Columns[7].Width = 60;
        this.GridUrunler.Columns[17].Width = 75;
      }
      islemler.GridDuzenle(this.GridUrunler);
    }

    private void GridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (this.GridUrunler.Rows.Count <= 0)
        return;
      string str1 = this.GridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
      string str2 = this.GridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
      double num1 = Convert.ToDouble(this.GridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());
      int int16 = (int) Convert.ToInt16(this.lbutonid.Text);
      HızlıUrun hızlıUrun = this.db.HızlıUrun.Find(new object[1]
      {
        (object) int16
      });
      hızlıUrun.Barkod = str1;
      hızlıUrun.UrunAd = str2;
      hızlıUrun.Fiyat = new double?(num1);
      this.db.SaveChanges();
      int num2 = (int) MessageBox.Show("Ürün Tanımlandı.");
      Form1 openForm = (Form1) Application.OpenForms["Form1"];
      if (openForm != null)
        (((IEnumerable<Control>) openForm.Controls.Find("bh" + int16.ToString(), true)).FirstOrDefault<Control>() as Button).Text = str2 + "\n" + num1.ToString("C2");
      openForm.HızlıUrunDoldur();
    }

    private void fHızlıButonUrunEkle_Load(object sender, EventArgs e) => this.tUrunAra.Focus();

    private void chtumu_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chtumu.Checked)
      {
        this.GridUrunler.DataSource = (object) this.db.Urun.ToList<Urun>();
        this.GridUrunler.Columns["AlisFiyat"].Visible = false;
        this.GridUrunler.Columns["SatisFiyat"].Visible = false;
        this.GridUrunler.Columns["KdvOrani"].Visible = false;
        this.GridUrunler.Columns["KdvTutari"].Visible = false;
        this.GridUrunler.Columns["Miktar"].Visible = false;
        this.GridUrunler.Columns["SatisFiyat2"].Visible = false;
        this.GridUrunler.Columns["SatisFiyat3"].Visible = false;
        this.GridUrunler.Columns["SatisFiyat4"].Visible = false;
        this.GridUrunler.Columns["SatisFiyat5"].Visible = false;
        islemler.GridDuzenle(this.GridUrunler);
        this.GridUrunler.Columns[0].Width = 50;
        this.GridUrunler.Columns[1].Width = 150;
        this.GridUrunler.Columns[2].Width = 475;
        this.GridUrunler.Columns[3].Width = 95;
        this.GridUrunler.Columns[4].Width = 150;
        this.GridUrunler.Columns[5].Width = 60;
        this.GridUrunler.Columns[7].Width = 50;
        this.GridUrunler.Columns[7].Width = 60;
        this.GridUrunler.Columns[17].Width = 75;
      }
      else
        this.GridUrunler.DataSource = (object) null;
      islemler.GridDuzenle(this.GridUrunler);
    }

    private void bstandart1_Click(object sender, EventArgs e)
    {
      Form1 openForm = (Form1) Application.OpenForms["Form1"];
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "jpeg files|*.png";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.pictureBox1.ImageLocation = openFileDialog.FileName;
      string fileName = openFileDialog.FileName;
      FileInfo fileInfo = new FileInfo(openFileDialog.FileName);
      openForm.resim = fileName;
      this.tResim.Text = fileName;
      openForm.butonid = Convert.ToInt32(this.lbutonid.Text);
      this.db.HızlıUrun.Find(new object[1]
      {
        (object) Convert.ToInt32(this.lbutonid.Text)
      }).Resim = fileName;
      this.db.SaveChanges();
      openForm.butonid = Convert.ToInt32(this.lbutonid.Text);
      openForm.resimgetir2();
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
    }

    private void bgeri_Click(object sender, EventArgs e) => this.Close();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fHızlıButonUrunEkle));
      this.splitContainer1 = new SplitContainer();
      this.bgeri = new Button();
      this.tResim = new TextBox();
      this.pictureBox1 = new PictureBox();
      this.bstandart1 = new bstandart();
      this.chtumu = new CheckBox();
      this.label1 = new Label();
      this.lbutonid = new Label();
      this.label6 = new Label();
      this.tUrunAra = new TextBox();
      this.GridUrunler = new DataGridView();
      this.openFileDialog1 = new OpenFileDialog();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      ((ISupportInitialize) this.GridUrunler).BeginInit();
      this.SuspendLayout();
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.FixedPanel = FixedPanel.Panel1;
      this.splitContainer1.Location = new Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.bgeri);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tResim);
      this.splitContainer1.Panel1.Controls.Add((Control) this.pictureBox1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.bstandart1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.chtumu);
      this.splitContainer1.Panel1.Controls.Add((Control) this.label1);
      this.splitContainer1.Panel1.Controls.Add((Control) this.lbutonid);
      this.splitContainer1.Panel1.Controls.Add((Control) this.label6);
      this.splitContainer1.Panel1.Controls.Add((Control) this.tUrunAra);
      this.splitContainer1.Panel2.Controls.Add((Control) this.GridUrunler);
      this.splitContainer1.Size = new Size(1082, 702);
      this.splitContainer1.SplitterDistance = 128;
      this.splitContainer1.TabIndex = 0;
      this.bgeri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bgeri.BackColor = Color.DimGray;
      this.bgeri.Image = (Image) Resources.exit32;
      this.bgeri.Location = new Point(919, 3);
      this.bgeri.Name = "bgeri";
      this.bgeri.Size = new Size(160, 122);
      this.bgeri.TabIndex = 8;
      this.bgeri.UseVisualStyleBackColor = false;
      this.bgeri.Click += new EventHandler(this.bgeri_Click);
      this.tResim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.tResim.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tResim.Location = new Point(707, 24);
      this.tResim.Name = "tResim";
      this.tResim.Size = new Size(208, 31);
      this.tResim.TabIndex = 7;
      this.pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.pictureBox1.Location = new Point(553, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(148, 113);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 6;
      this.pictureBox1.TabStop = false;
      this.bstandart1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.bstandart1.BackColor = Color.Tomato;
      this.bstandart1.FlatAppearance.BorderColor = Color.Tomato;
      this.bstandart1.FlatStyle = FlatStyle.Flat;
      this.bstandart1.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bstandart1.ForeColor = SystemColors.ButtonHighlight;
      this.bstandart1.Location = new Point(707, 59);
      this.bstandart1.Margin = new Padding(1);
      this.bstandart1.Name = "bstandart1";
      this.bstandart1.Size = new Size(208, 60);
      this.bstandart1.TabIndex = 0;
      this.bstandart1.Text = "Resim Seç";
      this.bstandart1.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bstandart1.UseVisualStyleBackColor = false;
      this.bstandart1.Click += new EventHandler(this.bstandart1_Click);
      this.chtumu.AutoSize = true;
      this.chtumu.Font = new Font("Microsoft Sans Serif", 13f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chtumu.ForeColor = Color.DarkCyan;
      this.chtumu.Location = new Point(366, 81);
      this.chtumu.Name = "chtumu";
      this.chtumu.Size = new Size(179, 29);
      this.chtumu.TabIndex = 4;
      this.chtumu.Text = "Tümünü Göster";
      this.chtumu.UseVisualStyleBackColor = true;
      this.chtumu.CheckedChanged += new EventHandler(this.chtumu_CheckedChanged);
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label1.ForeColor = Color.DarkOrange;
      this.label1.Location = new Point(13, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(134, 18);
      this.label1.TabIndex = 3;
      this.label1.Text = "Buton Numarası:";
      this.lbutonid.AutoSize = true;
      this.lbutonid.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.lbutonid.ForeColor = Color.DarkOrange;
      this.lbutonid.Location = new Point(163, 19);
      this.lbutonid.Name = "lbutonid";
      this.lbutonid.Size = new Size(81, 18);
      this.lbutonid.TabIndex = 3;
      this.lbutonid.Text = "Buton no;";
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.ForeColor = Color.DarkOrange;
      this.label6.Location = new Point(9, 59);
      this.label6.Name = "label6";
      this.label6.Size = new Size(79, 18);
      this.label6.TabIndex = 3;
      this.label6.Text = "Urun Ara:";
      this.tUrunAra.BorderStyle = BorderStyle.FixedSingle;
      this.tUrunAra.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tUrunAra.Location = new Point(12, 80);
      this.tUrunAra.Name = "tUrunAra";
      this.tUrunAra.Size = new Size(348, 29);
      this.tUrunAra.TabIndex = 2;
      this.tUrunAra.TextChanged += new EventHandler(this.tUrunAra_TextChanged);
      this.GridUrunler.AllowUserToAddRows = false;
      this.GridUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridUrunler.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridUrunler.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridUrunler.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridUrunler.Dock = DockStyle.Fill;
      this.GridUrunler.EnableHeadersVisualStyles = false;
      this.GridUrunler.Location = new Point(0, 0);
      this.GridUrunler.Margin = new Padding(1);
      this.GridUrunler.Name = "GridUrunler";
      this.GridUrunler.ReadOnly = true;
      this.GridUrunler.RowHeadersVisible = false;
      this.GridUrunler.RowHeadersWidth = 49;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.GridUrunler.RowsDefaultCellStyle = gridViewCellStyle2;
      this.GridUrunler.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridUrunler.RowTemplate.Height = 33;
      this.GridUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridUrunler.Size = new Size(1082, 570);
      this.GridUrunler.TabIndex = 2;
      this.GridUrunler.CellContentDoubleClick += new DataGridViewCellEventHandler(this.GridUrunler_CellContentDoubleClick);
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.FileOk += new CancelEventHandler(this.openFileDialog1_FileOk);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(1082, 702);
      this.Controls.Add((Control) this.splitContainer1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (fHızlıButonUrunEkle);
      this.Text = "Hızlı Buton Urun Ekleme";
      this.WindowState = FormWindowState.Maximized;
      this.Load += new EventHandler(this.fHızlıButonUrunEkle_Load);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      ((ISupportInitialize) this.GridUrunler).EndInit();
      this.ResumeLayout(false);
    }
  }
}
