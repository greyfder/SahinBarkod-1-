// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fMiktarDegistir
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using SahinBarkod_1_.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fMiktarDegistir : Form
  {
    internal string eskiMiktar = string.Empty;
    private IContainer components = (IContainer) null;
    private bstandart bstandart1;
    private bstandart btamam;
    private lstandart lstandart2;
    internal tnumeric tYeniMiktar;
    internal tnumeric tEskiMiktar;
    private lstandart lstandart1;
    private TableLayoutPanel tableLayoutPanel8;
    private Button bN1;
    private Button bN2;
    private Button bN3;
    private Button bN4;
    private Button bN5;
    private Button bN6;
    private Button bN7;
    private Button bN8;
    private Button bN9;
    private Button bNB;
    private Button bN0;
    private Button bNV;

    public fMiktarDegistir() => this.InitializeComponent();

    private void fMiktarDegistir_Load(object sender, EventArgs e)
    {
      this.tEskiMiktar.Text = this.eskiMiktar;
      this.tYeniMiktar.Focus();
    }

    private void btamam_Click(object sender, EventArgs e)
    {
      if (!(this.tYeniMiktar.Text != string.Empty))
        return;
      ((Form1) Application.OpenForms["Form1"]).yenimiktar = Convert.ToDouble(this.tYeniMiktar.Text);
      this.Close();
    }

    private void bstandart1_Click(object sender, EventArgs e)
    {
      ((Form1) Application.OpenForms["Form1"]).yenimiktar = Convert.ToDouble(this.tEskiMiktar.Text);
      this.Close();
    }

    private void bNx_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      if (button.Text == ",")
      {
        if (this.tYeniMiktar.Text.Count<char>((Func<char, bool>) (x => x == ',')) >= 1)
          return;
        this.tYeniMiktar.Text += button.Text;
      }
      else if (button.Text == "<")
      {
        if (this.tYeniMiktar.Text.Length <= 0)
          return;
        this.tYeniMiktar.Text = this.tYeniMiktar.Text.Substring(0, this.tYeniMiktar.Text.Length - 1);
      }
      else
        this.tYeniMiktar.Text += button.Text;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.bstandart1 = new bstandart();
      this.btamam = new bstandart();
      this.lstandart2 = new lstandart();
      this.tYeniMiktar = new tnumeric();
      this.tEskiMiktar = new tnumeric();
      this.lstandart1 = new lstandart();
      this.tableLayoutPanel8 = new TableLayoutPanel();
      this.bN1 = new Button();
      this.bN2 = new Button();
      this.bN3 = new Button();
      this.bN4 = new Button();
      this.bN5 = new Button();
      this.bN6 = new Button();
      this.bN7 = new Button();
      this.bN8 = new Button();
      this.bN9 = new Button();
      this.bNB = new Button();
      this.bN0 = new Button();
      this.bNV = new Button();
      this.tableLayoutPanel8.SuspendLayout();
      this.SuspendLayout();
      this.bstandart1.BackColor = Color.DimGray;
      this.bstandart1.DialogResult = DialogResult.Cancel;
      this.bstandart1.FlatAppearance.BorderColor = Color.DimGray;
      this.bstandart1.FlatStyle = FlatStyle.Flat;
      this.bstandart1.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bstandart1.ForeColor = SystemColors.ButtonHighlight;
      this.bstandart1.Image = (Image) Resources.cancel24;
      this.bstandart1.Location = new Point(16, 168);
      this.bstandart1.Margin = new Padding(1);
      this.bstandart1.Name = "bstandart1";
      this.bstandart1.Size = new Size(177, 71);
      this.bstandart1.TabIndex = 2;
      this.bstandart1.Text = "İptal";
      this.bstandart1.TextImageRelation = TextImageRelation.ImageAboveText;
      this.bstandart1.UseVisualStyleBackColor = false;
      this.bstandart1.Click += new EventHandler(this.bstandart1_Click);
      this.btamam.BackColor = Color.Tomato;
      this.btamam.FlatAppearance.BorderColor = Color.Tomato;
      this.btamam.FlatStyle = FlatStyle.Flat;
      this.btamam.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.btamam.ForeColor = SystemColors.ButtonHighlight;
      this.btamam.Image = (Image) Resources.fiyatguncelletl4854;
      this.btamam.Location = new Point(222, 168);
      this.btamam.Margin = new Padding(1);
      this.btamam.Name = "btamam";
      this.btamam.Size = new Size(177, 71);
      this.btamam.TabIndex = 1;
      this.btamam.Text = "DEĞİŞTİR";
      this.btamam.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.btamam.UseVisualStyleBackColor = false;
      this.btamam.Click += new EventHandler(this.btamam_Click);
      this.lstandart2.AutoSize = true;
      this.lstandart2.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart2.ForeColor = Color.DarkCyan;
      this.lstandart2.Location = new Point(31, 80);
      this.lstandart2.Name = "lstandart2";
      this.lstandart2.Size = new Size(109, 25);
      this.lstandart2.TabIndex = 8;
      this.lstandart2.Text = "Yeni Miktar";
      this.tYeniMiktar.BackColor = Color.White;
      this.tYeniMiktar.Font = new Font("Microsoft Sans Serif", 18.15652f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tYeniMiktar.Location = new Point(16, 108);
      this.tYeniMiktar.Name = "tYeniMiktar";
      this.tYeniMiktar.Size = new Size(383, 40);
      this.tYeniMiktar.TabIndex = 0;
      this.tYeniMiktar.TextAlign = HorizontalAlignment.Right;
      this.tEskiMiktar.BackColor = Color.White;
      this.tEskiMiktar.Font = new Font("Microsoft Sans Serif", 18.15652f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tEskiMiktar.Location = new Point(16, 37);
      this.tEskiMiktar.Name = "tEskiMiktar";
      this.tEskiMiktar.ReadOnly = true;
      this.tEskiMiktar.Size = new Size(383, 40);
      this.tEskiMiktar.TabIndex = 9;
      this.tEskiMiktar.TextAlign = HorizontalAlignment.Right;
      this.lstandart1.AutoSize = true;
      this.lstandart1.Font = new Font("Microsoft Sans Serif", 12f);
      this.lstandart1.ForeColor = Color.DarkCyan;
      this.lstandart1.Location = new Point(33, 9);
      this.lstandart1.Name = "lstandart1";
      this.lstandart1.Size = new Size(107, 25);
      this.lstandart1.TabIndex = 6;
      this.lstandart1.Text = "Eski Miktar";
      this.tableLayoutPanel8.BackColor = Color.DimGray;
      this.tableLayoutPanel8.ColumnCount = 3;
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334f));
      this.tableLayoutPanel8.Controls.Add((Control) this.bN1, 0, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN2, 1, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN3, 2, 0);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN4, 0, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN5, 1, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN6, 2, 1);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN7, 0, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN8, 1, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN9, 2, 2);
      this.tableLayoutPanel8.Controls.Add((Control) this.bNB, 0, 3);
      this.tableLayoutPanel8.Controls.Add((Control) this.bN0, 1, 3);
      this.tableLayoutPanel8.Controls.Add((Control) this.bNV, 2, 3);
      this.tableLayoutPanel8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tableLayoutPanel8.ForeColor = Color.White;
      this.tableLayoutPanel8.Location = new Point(16, 250);
      this.tableLayoutPanel8.Margin = new Padding(1);
      this.tableLayoutPanel8.Name = "tableLayoutPanel8";
      this.tableLayoutPanel8.RowCount = 4;
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.Size = new Size(385, 381);
      this.tableLayoutPanel8.TabIndex = 10;
      this.bN1.BackColor = Color.DimGray;
      this.bN1.Dock = DockStyle.Fill;
      this.bN1.FlatStyle = FlatStyle.Flat;
      this.bN1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN1.ForeColor = Color.White;
      this.bN1.Location = new Point(1, 1);
      this.bN1.Margin = new Padding(1);
      this.bN1.Name = "bN1";
      this.bN1.Size = new Size(126, 93);
      this.bN1.TabIndex = 0;
      this.bN1.Text = "1";
      this.bN1.UseVisualStyleBackColor = false;
      this.bN1.Click += new EventHandler(this.bNx_Click);
      this.bN2.BackColor = Color.DimGray;
      this.bN2.Dock = DockStyle.Fill;
      this.bN2.FlatStyle = FlatStyle.Flat;
      this.bN2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN2.ForeColor = Color.White;
      this.bN2.Location = new Point(129, 1);
      this.bN2.Margin = new Padding(1);
      this.bN2.Name = "bN2";
      this.bN2.Size = new Size(126, 93);
      this.bN2.TabIndex = 1;
      this.bN2.Text = "2";
      this.bN2.UseVisualStyleBackColor = false;
      this.bN2.Click += new EventHandler(this.bNx_Click);
      this.bN3.BackColor = Color.DimGray;
      this.bN3.Dock = DockStyle.Fill;
      this.bN3.FlatStyle = FlatStyle.Flat;
      this.bN3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN3.ForeColor = Color.White;
      this.bN3.Location = new Point(257, 1);
      this.bN3.Margin = new Padding(1);
      this.bN3.Name = "bN3";
      this.bN3.Size = new Size((int) sbyte.MaxValue, 93);
      this.bN3.TabIndex = 2;
      this.bN3.Text = "3";
      this.bN3.UseVisualStyleBackColor = false;
      this.bN3.Click += new EventHandler(this.bNx_Click);
      this.bN4.BackColor = Color.DimGray;
      this.bN4.Dock = DockStyle.Fill;
      this.bN4.FlatStyle = FlatStyle.Flat;
      this.bN4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN4.ForeColor = Color.White;
      this.bN4.Location = new Point(1, 96);
      this.bN4.Margin = new Padding(1);
      this.bN4.Name = "bN4";
      this.bN4.Size = new Size(126, 93);
      this.bN4.TabIndex = 3;
      this.bN4.Text = "4";
      this.bN4.UseVisualStyleBackColor = false;
      this.bN4.Click += new EventHandler(this.bNx_Click);
      this.bN5.BackColor = Color.DimGray;
      this.bN5.Dock = DockStyle.Fill;
      this.bN5.FlatStyle = FlatStyle.Flat;
      this.bN5.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN5.ForeColor = Color.White;
      this.bN5.Location = new Point(129, 96);
      this.bN5.Margin = new Padding(1);
      this.bN5.Name = "bN5";
      this.bN5.Size = new Size(126, 93);
      this.bN5.TabIndex = 4;
      this.bN5.Text = "5";
      this.bN5.UseVisualStyleBackColor = false;
      this.bN5.Click += new EventHandler(this.bNx_Click);
      this.bN6.BackColor = Color.DimGray;
      this.bN6.Dock = DockStyle.Fill;
      this.bN6.FlatStyle = FlatStyle.Flat;
      this.bN6.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN6.ForeColor = Color.White;
      this.bN6.Location = new Point(257, 96);
      this.bN6.Margin = new Padding(1);
      this.bN6.Name = "bN6";
      this.bN6.Size = new Size((int) sbyte.MaxValue, 93);
      this.bN6.TabIndex = 5;
      this.bN6.Text = "6";
      this.bN6.UseVisualStyleBackColor = false;
      this.bN6.Click += new EventHandler(this.bNx_Click);
      this.bN7.BackColor = Color.DimGray;
      this.bN7.Dock = DockStyle.Fill;
      this.bN7.FlatStyle = FlatStyle.Flat;
      this.bN7.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN7.ForeColor = Color.White;
      this.bN7.Location = new Point(1, 191);
      this.bN7.Margin = new Padding(1);
      this.bN7.Name = "bN7";
      this.bN7.Size = new Size(126, 93);
      this.bN7.TabIndex = 6;
      this.bN7.Text = "7";
      this.bN7.UseVisualStyleBackColor = false;
      this.bN7.Click += new EventHandler(this.bNx_Click);
      this.bN8.BackColor = Color.DimGray;
      this.bN8.Dock = DockStyle.Fill;
      this.bN8.FlatStyle = FlatStyle.Flat;
      this.bN8.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN8.ForeColor = Color.White;
      this.bN8.Location = new Point(129, 191);
      this.bN8.Margin = new Padding(1);
      this.bN8.Name = "bN8";
      this.bN8.Size = new Size(126, 93);
      this.bN8.TabIndex = 7;
      this.bN8.Text = "8";
      this.bN8.UseVisualStyleBackColor = false;
      this.bN8.Click += new EventHandler(this.bNx_Click);
      this.bN9.BackColor = Color.DimGray;
      this.bN9.Dock = DockStyle.Fill;
      this.bN9.FlatStyle = FlatStyle.Flat;
      this.bN9.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN9.ForeColor = Color.White;
      this.bN9.Location = new Point(257, 191);
      this.bN9.Margin = new Padding(1);
      this.bN9.Name = "bN9";
      this.bN9.Size = new Size((int) sbyte.MaxValue, 93);
      this.bN9.TabIndex = 8;
      this.bN9.Text = "9";
      this.bN9.UseVisualStyleBackColor = false;
      this.bN9.Click += new EventHandler(this.bNx_Click);
      this.bNB.BackColor = Color.DimGray;
      this.bNB.Dock = DockStyle.Fill;
      this.bNB.FlatStyle = FlatStyle.Flat;
      this.bNB.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNB.ForeColor = Color.White;
      this.bNB.Location = new Point(1, 286);
      this.bNB.Margin = new Padding(1);
      this.bNB.Name = "bNB";
      this.bNB.Size = new Size(126, 94);
      this.bNB.TabIndex = 9;
      this.bNB.Text = "<";
      this.bNB.UseVisualStyleBackColor = false;
      this.bNB.Click += new EventHandler(this.bNx_Click);
      this.bN0.BackColor = Color.DimGray;
      this.bN0.Dock = DockStyle.Fill;
      this.bN0.FlatStyle = FlatStyle.Flat;
      this.bN0.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN0.ForeColor = Color.White;
      this.bN0.Location = new Point(129, 286);
      this.bN0.Margin = new Padding(1);
      this.bN0.Name = "bN0";
      this.bN0.Size = new Size(126, 94);
      this.bN0.TabIndex = 10;
      this.bN0.Text = "0";
      this.bN0.UseVisualStyleBackColor = false;
      this.bN0.Click += new EventHandler(this.bNx_Click);
      this.bNV.BackColor = Color.DimGray;
      this.bNV.Dock = DockStyle.Fill;
      this.bNV.FlatStyle = FlatStyle.Flat;
      this.bNV.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNV.ForeColor = Color.White;
      this.bNV.Location = new Point(257, 286);
      this.bNV.Margin = new Padding(1);
      this.bNV.Name = "bNV";
      this.bNV.Size = new Size((int) sbyte.MaxValue, 94);
      this.bNV.TabIndex = 11;
      this.bNV.Text = ",";
      this.bNV.UseVisualStyleBackColor = false;
      this.bNV.Click += new EventHandler(this.bNx_Click);
      this.AcceptButton = (IButtonControl) this.btamam;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientActiveCaption;
      this.CancelButton = (IButtonControl) this.bstandart1;
      this.ClientSize = new Size(415, 641);
      this.Controls.Add((Control) this.tableLayoutPanel8);
      this.Controls.Add((Control) this.bstandart1);
      this.Controls.Add((Control) this.btamam);
      this.Controls.Add((Control) this.lstandart2);
      this.Controls.Add((Control) this.tYeniMiktar);
      this.Controls.Add((Control) this.tEskiMiktar);
      this.Controls.Add((Control) this.lstandart1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = nameof (fMiktarDegistir);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (fMiktarDegistir);
      this.Load += new EventHandler(this.fMiktarDegistir_Load);
      this.tableLayoutPanel8.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
