// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fnakitkart
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
  public class fnakitkart : Form
  {
    private IContainer components = (IContainer) null;
    private TextBox tNakit;
    private Label label6;
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
    private Button bEnter;

    public fnakitkart() => this.InitializeComponent();

    private void tNakit_KeyDown(object sender, KeyEventArgs e)
    {
      if (!(this.tNakit.Text != "") || e.KeyCode != Keys.Return)
        return;
      this.hesapla();
    }

    private void hesapla()
    {
      Form1 openForm = (Form1) Application.OpenForms["Form1"];
      double num1 = islemler.DoubleYap(this.tNakit.Text);
      double num2 = islemler.DoubleYap(openForm.tGenelToplam.Text) - num1;
      openForm.lNakit.Text = num1.ToString("C2");
      openForm.lKart.Text = num2.ToString("C2");
      openForm.SatisYap("Kart-Nakit");
      this.Hide();
    }

    private void bNx_Click(object sender, EventArgs e)
    {
      Button button = (Button) sender;
      if (button.Text == ",")
      {
        if (this.tNakit.Text.Count<char>((Func<char, bool>) (x => x == ',')) >= 1)
          return;
        this.tNakit.Text += button.Text;
      }
      else if (button.Text == "<")
      {
        if (this.tNakit.Text.Length <= 0)
          return;
        this.tNakit.Text = this.tNakit.Text.Substring(0, this.tNakit.Text.Length - 1);
      }
      else
        this.tNakit.Text += button.Text;
    }

    private void fnakitkart_Load(object sender, EventArgs e)
    {
    }

    private void bEnter_Click(object sender, EventArgs e)
    {
      if (!(this.tNakit.Text != ""))
        return;
      this.hesapla();
    }

    private void tNakit_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
        return;
      e.Handled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fnakitkart));
      this.tNakit = new TextBox();
      this.label6 = new Label();
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
      this.bEnter = new Button();
      this.tableLayoutPanel8.SuspendLayout();
      this.SuspendLayout();
      this.tNakit.BorderStyle = BorderStyle.FixedSingle;
      this.tNakit.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tNakit.Location = new Point(32, 53);
      this.tNakit.Name = "tNakit";
      this.tNakit.Size = new Size(374, 29);
      this.tNakit.TabIndex = 0;
      this.tNakit.KeyDown += new KeyEventHandler(this.tNakit_KeyDown);
      this.tNakit.KeyPress += new KeyPressEventHandler(this.tNakit_KeyPress);
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.ForeColor = Color.DarkOrange;
      this.label6.Location = new Point(29, 20);
      this.label6.Name = "label6";
      this.label6.Size = new Size(162, 18);
      this.label6.TabIndex = 2;
      this.label6.Text = "Nakit Miktarı Giriniz:";
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
      this.tableLayoutPanel8.Location = new Point(32, 95);
      this.tableLayoutPanel8.Margin = new Padding(1);
      this.tableLayoutPanel8.Name = "tableLayoutPanel8";
      this.tableLayoutPanel8.RowCount = 4;
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));
      this.tableLayoutPanel8.Size = new Size(338, 297);
      this.tableLayoutPanel8.TabIndex = 3;
      this.bN1.BackColor = Color.DimGray;
      this.bN1.Dock = DockStyle.Fill;
      this.bN1.FlatStyle = FlatStyle.Flat;
      this.bN1.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN1.ForeColor = Color.White;
      this.bN1.Location = new Point(1, 1);
      this.bN1.Margin = new Padding(1);
      this.bN1.Name = "bN1";
      this.bN1.Size = new Size(110, 72);
      this.bN1.TabIndex = 0;
      this.bN1.Text = "1";
      this.bN1.UseVisualStyleBackColor = false;
      this.bN1.Click += new EventHandler(this.bNx_Click);
      this.bN2.BackColor = Color.DimGray;
      this.bN2.Dock = DockStyle.Fill;
      this.bN2.FlatStyle = FlatStyle.Flat;
      this.bN2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN2.ForeColor = Color.White;
      this.bN2.Location = new Point(113, 1);
      this.bN2.Margin = new Padding(1);
      this.bN2.Name = "bN2";
      this.bN2.Size = new Size(110, 72);
      this.bN2.TabIndex = 1;
      this.bN2.Text = "2";
      this.bN2.UseVisualStyleBackColor = false;
      this.bN2.Click += new EventHandler(this.bNx_Click);
      this.bN3.BackColor = Color.DimGray;
      this.bN3.Dock = DockStyle.Fill;
      this.bN3.FlatStyle = FlatStyle.Flat;
      this.bN3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN3.ForeColor = Color.White;
      this.bN3.Location = new Point(225, 1);
      this.bN3.Margin = new Padding(1);
      this.bN3.Name = "bN3";
      this.bN3.Size = new Size(112, 72);
      this.bN3.TabIndex = 2;
      this.bN3.Text = "3";
      this.bN3.UseVisualStyleBackColor = false;
      this.bN3.Click += new EventHandler(this.bNx_Click);
      this.bN4.BackColor = Color.DimGray;
      this.bN4.Dock = DockStyle.Fill;
      this.bN4.FlatStyle = FlatStyle.Flat;
      this.bN4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN4.ForeColor = Color.White;
      this.bN4.Location = new Point(1, 75);
      this.bN4.Margin = new Padding(1);
      this.bN4.Name = "bN4";
      this.bN4.Size = new Size(110, 72);
      this.bN4.TabIndex = 3;
      this.bN4.Text = "4";
      this.bN4.UseVisualStyleBackColor = false;
      this.bN4.Click += new EventHandler(this.bNx_Click);
      this.bN5.BackColor = Color.DimGray;
      this.bN5.Dock = DockStyle.Fill;
      this.bN5.FlatStyle = FlatStyle.Flat;
      this.bN5.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN5.ForeColor = Color.White;
      this.bN5.Location = new Point(113, 75);
      this.bN5.Margin = new Padding(1);
      this.bN5.Name = "bN5";
      this.bN5.Size = new Size(110, 72);
      this.bN5.TabIndex = 4;
      this.bN5.Text = "5";
      this.bN5.UseVisualStyleBackColor = false;
      this.bN5.Click += new EventHandler(this.bNx_Click);
      this.bN6.BackColor = Color.DimGray;
      this.bN6.Dock = DockStyle.Fill;
      this.bN6.FlatStyle = FlatStyle.Flat;
      this.bN6.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN6.ForeColor = Color.White;
      this.bN6.Location = new Point(225, 75);
      this.bN6.Margin = new Padding(1);
      this.bN6.Name = "bN6";
      this.bN6.Size = new Size(112, 72);
      this.bN6.TabIndex = 5;
      this.bN6.Text = "6";
      this.bN6.UseVisualStyleBackColor = false;
      this.bN6.Click += new EventHandler(this.bNx_Click);
      this.bN7.BackColor = Color.DimGray;
      this.bN7.Dock = DockStyle.Fill;
      this.bN7.FlatStyle = FlatStyle.Flat;
      this.bN7.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN7.ForeColor = Color.White;
      this.bN7.Location = new Point(1, 149);
      this.bN7.Margin = new Padding(1);
      this.bN7.Name = "bN7";
      this.bN7.Size = new Size(110, 72);
      this.bN7.TabIndex = 6;
      this.bN7.Text = "7";
      this.bN7.UseVisualStyleBackColor = false;
      this.bN7.Click += new EventHandler(this.bNx_Click);
      this.bN8.BackColor = Color.DimGray;
      this.bN8.Dock = DockStyle.Fill;
      this.bN8.FlatStyle = FlatStyle.Flat;
      this.bN8.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN8.ForeColor = Color.White;
      this.bN8.Location = new Point(113, 149);
      this.bN8.Margin = new Padding(1);
      this.bN8.Name = "bN8";
      this.bN8.Size = new Size(110, 72);
      this.bN8.TabIndex = 7;
      this.bN8.Text = "8";
      this.bN8.UseVisualStyleBackColor = false;
      this.bN8.Click += new EventHandler(this.bNx_Click);
      this.bN9.BackColor = Color.DimGray;
      this.bN9.Dock = DockStyle.Fill;
      this.bN9.FlatStyle = FlatStyle.Flat;
      this.bN9.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN9.ForeColor = Color.White;
      this.bN9.Location = new Point(225, 149);
      this.bN9.Margin = new Padding(1);
      this.bN9.Name = "bN9";
      this.bN9.Size = new Size(112, 72);
      this.bN9.TabIndex = 8;
      this.bN9.Text = "9";
      this.bN9.UseVisualStyleBackColor = false;
      this.bN9.Click += new EventHandler(this.bNx_Click);
      this.bNB.BackColor = Color.DimGray;
      this.bNB.Dock = DockStyle.Fill;
      this.bNB.FlatStyle = FlatStyle.Flat;
      this.bNB.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNB.ForeColor = Color.White;
      this.bNB.Location = new Point(1, 223);
      this.bNB.Margin = new Padding(1);
      this.bNB.Name = "bNB";
      this.bNB.Size = new Size(110, 73);
      this.bNB.TabIndex = 9;
      this.bNB.Text = "<";
      this.bNB.UseVisualStyleBackColor = false;
      this.bNB.Click += new EventHandler(this.bNx_Click);
      this.bN0.BackColor = Color.DimGray;
      this.bN0.Dock = DockStyle.Fill;
      this.bN0.FlatStyle = FlatStyle.Flat;
      this.bN0.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bN0.ForeColor = Color.White;
      this.bN0.Location = new Point(113, 223);
      this.bN0.Margin = new Padding(1);
      this.bN0.Name = "bN0";
      this.bN0.Size = new Size(110, 73);
      this.bN0.TabIndex = 10;
      this.bN0.Text = "0";
      this.bN0.UseVisualStyleBackColor = false;
      this.bN0.Click += new EventHandler(this.bNx_Click);
      this.bNV.BackColor = Color.DimGray;
      this.bNV.Dock = DockStyle.Fill;
      this.bNV.FlatStyle = FlatStyle.Flat;
      this.bNV.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bNV.ForeColor = Color.White;
      this.bNV.Location = new Point(225, 223);
      this.bNV.Margin = new Padding(1);
      this.bNV.Name = "bNV";
      this.bNV.Size = new Size(112, 73);
      this.bNV.TabIndex = 11;
      this.bNV.Text = ",";
      this.bNV.UseVisualStyleBackColor = false;
      this.bNV.Click += new EventHandler(this.bNx_Click);
      this.bEnter.BackColor = Color.Tomato;
      this.bEnter.FlatAppearance.BorderColor = Color.Tomato;
      this.bEnter.FlatStyle = FlatStyle.Flat;
      this.bEnter.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bEnter.ForeColor = SystemColors.ButtonHighlight;
      this.bEnter.Image = (Image) componentResourceManager.GetObject("bEnter.Image");
      this.bEnter.Location = new Point(371, 97);
      this.bEnter.Margin = new Padding(1);
      this.bEnter.Name = "bEnter";
      this.bEnter.Size = new Size(113, 295);
      this.bEnter.TabIndex = 4;
      this.bEnter.Text = "ENTER";
      this.bEnter.TextImageRelation = TextImageRelation.TextAboveImage;
      this.bEnter.UseVisualStyleBackColor = false;
      this.bEnter.Click += new EventHandler(this.bEnter_Click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.GradientInactiveCaption;
      this.ClientSize = new Size(492, 405);
      this.Controls.Add((Control) this.bEnter);
      this.Controls.Add((Control) this.tableLayoutPanel8);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.tNakit);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximumSize = new Size(510, 500);
      this.MinimumSize = new Size(510, 450);
      this.Name = nameof (fnakitkart);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = nameof (fnakitkart);
      this.Load += new EventHandler(this.fnakitkart_Load);
      this.tableLayoutPanel8.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
