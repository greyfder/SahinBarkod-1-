﻿// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.fdeneme
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  public class fdeneme : Form
  {
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel17;
    private Label label5;
    private TextBox tBarkod;
    private Label label6;
    private TextBox tmiktar;
    private TableLayoutPanel tableLayoutPanel16;
    private RadioButton rsatis1;
    private RadioButton rsatis5;
    private RadioButton rsatis2;
    private RadioButton rsatis4;
    private RadioButton rsatis3;
    private TableLayoutPanel tableLayoutPanel14;
    private Button bs10;
    private Button bsar;
    private Button bs5;
    private Button bsaz;
    private Button bs4;
    private Button bs2;
    private Button bs3;
    private TableLayoutPanel tableLayoutPanel15;
    private Label label3;
    private TextBox textBox2;
    public TextBox tGenelToplam;
    private CheckBox chYazdirma;
    public Label lNakit;
    public Label lKart;
    internal Label lKullanici;
    private CheckBox chsatisiadeislemi;
    private DataGridView GridBekle;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private DataGridViewImageColumn dataGridViewImageColumn1;

    public fdeneme() => this.InitializeComponent();

    private void rsatis5_CheckedChanged(object sender, EventArgs e)
    {
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
      DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
      DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fdeneme));
      this.panel1 = new Panel();
      this.tableLayoutPanel17 = new TableLayoutPanel();
      this.label5 = new Label();
      this.tBarkod = new TextBox();
      this.label6 = new Label();
      this.tmiktar = new TextBox();
      this.tableLayoutPanel16 = new TableLayoutPanel();
      this.rsatis1 = new RadioButton();
      this.rsatis5 = new RadioButton();
      this.rsatis2 = new RadioButton();
      this.rsatis4 = new RadioButton();
      this.rsatis3 = new RadioButton();
      this.tableLayoutPanel14 = new TableLayoutPanel();
      this.bs10 = new Button();
      this.bsar = new Button();
      this.bs5 = new Button();
      this.bsaz = new Button();
      this.bs4 = new Button();
      this.bs2 = new Button();
      this.bs3 = new Button();
      this.tableLayoutPanel15 = new TableLayoutPanel();
      this.label3 = new Label();
      this.textBox2 = new TextBox();
      this.tGenelToplam = new TextBox();
      this.chYazdirma = new CheckBox();
      this.lNakit = new Label();
      this.lKart = new Label();
      this.lKullanici = new Label();
      this.chsatisiadeislemi = new CheckBox();
      this.GridBekle = new DataGridView();
      this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
      this.dataGridViewImageColumn1 = new DataGridViewImageColumn();
      this.panel1.SuspendLayout();
      this.tableLayoutPanel17.SuspendLayout();
      this.tableLayoutPanel16.SuspendLayout();
      this.tableLayoutPanel14.SuspendLayout();
      this.tableLayoutPanel15.SuspendLayout();
      ((ISupportInitialize) this.GridBekle).BeginInit();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.tableLayoutPanel17);
      this.panel1.Controls.Add((Control) this.textBox2);
      this.panel1.Controls.Add((Control) this.tableLayoutPanel16);
      this.panel1.Controls.Add((Control) this.tableLayoutPanel14);
      this.panel1.Controls.Add((Control) this.tGenelToplam);
      this.panel1.Controls.Add((Control) this.chYazdirma);
      this.panel1.Controls.Add((Control) this.chsatisiadeislemi);
      this.panel1.Controls.Add((Control) this.lNakit);
      this.panel1.Controls.Add((Control) this.lKart);
      this.panel1.Controls.Add((Control) this.lKullanici);
      this.panel1.Controls.Add((Control) this.GridBekle);
      this.panel1.Dock = DockStyle.Fill;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(1208, 590);
      this.panel1.TabIndex = 1;
      this.tableLayoutPanel17.ColumnCount = 4;
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.36844f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.31886f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.21257f));
      this.tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.10013f));
      this.tableLayoutPanel17.Controls.Add((Control) this.label5, 0, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.tBarkod, 3, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.label6, 2, 0);
      this.tableLayoutPanel17.Controls.Add((Control) this.tmiktar, 1, 0);
      this.tableLayoutPanel17.Location = new Point(9, 3);
      this.tableLayoutPanel17.Name = "tableLayoutPanel17";
      this.tableLayoutPanel17.RowCount = 1;
      this.tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel17.Size = new Size(658, 43);
      this.tableLayoutPanel17.TabIndex = 24;
      this.label5.AutoSize = true;
      this.label5.Dock = DockStyle.Fill;
      this.label5.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label5.ForeColor = Color.DarkOrange;
      this.label5.Location = new Point(3, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(62, 43);
      this.label5.TabIndex = 21;
      this.label5.Text = "Miktar:";
      this.tBarkod.BackColor = SystemColors.ScrollBar;
      this.tBarkod.BorderStyle = BorderStyle.FixedSingle;
      this.tBarkod.Dock = DockStyle.Fill;
      this.tBarkod.Font = new Font("Microsoft Sans Serif", 17f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tBarkod.Location = new Point(271, 3);
      this.tBarkod.Name = "tBarkod";
      this.tBarkod.Size = new Size(384, 38);
      this.tBarkod.TabIndex = 0;
      this.label6.AutoSize = true;
      this.label6.Dock = DockStyle.Fill;
      this.label6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label6.ForeColor = Color.DarkOrange;
      this.label6.Location = new Point(191, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(74, 43);
      this.label6.TabIndex = 20;
      this.label6.Text = "Barkod:";
      this.tmiktar.BorderStyle = BorderStyle.FixedSingle;
      this.tmiktar.Dock = DockStyle.Fill;
      this.tmiktar.Font = new Font("Microsoft Sans Serif", 15f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.tmiktar.Location = new Point(71, 3);
      this.tmiktar.Name = "tmiktar";
      this.tmiktar.Size = new Size(114, 35);
      this.tmiktar.TabIndex = 22;
      this.tmiktar.TabStop = false;
      this.tmiktar.Text = "1";
      this.tmiktar.TextAlign = HorizontalAlignment.Center;
      this.tableLayoutPanel16.ColumnCount = 5;
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20f));
      this.tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis5, 4, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis4, 3, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis3, 2, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis2, 1, 0);
      this.tableLayoutPanel16.Controls.Add((Control) this.rsatis1, 0, 0);
      this.tableLayoutPanel16.Location = new Point(15, 45);
      this.tableLayoutPanel16.Name = "tableLayoutPanel16";
      this.tableLayoutPanel16.RowCount = 1;
      this.tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel16.Size = new Size(649, 32);
      this.tableLayoutPanel16.TabIndex = 14;
      this.rsatis1.AutoSize = true;
      this.rsatis1.BackColor = SystemColors.ControlDark;
      this.rsatis1.Checked = true;
      this.rsatis1.Dock = DockStyle.Fill;
      this.rsatis1.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis1.Location = new Point(3, 3);
      this.rsatis1.Name = "rsatis1";
      this.rsatis1.Size = new Size(123, 26);
      this.rsatis1.TabIndex = 12;
      this.rsatis1.TabStop = true;
      this.rsatis1.Text = "Fiyat 1";
      this.rsatis1.UseVisualStyleBackColor = false;
      this.rsatis5.AutoSize = true;
      this.rsatis5.Dock = DockStyle.Fill;
      this.rsatis5.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis5.Location = new Point(519, 3);
      this.rsatis5.Name = "rsatis5";
      this.rsatis5.Size = new Size((int) sbyte.MaxValue, 26);
      this.rsatis5.TabIndex = 8;
      this.rsatis5.TabStop = true;
      this.rsatis5.Text = "Fiyat 5";
      this.rsatis5.UseVisualStyleBackColor = true;
      this.rsatis5.CheckedChanged += new EventHandler(this.rsatis5_CheckedChanged);
      this.rsatis2.AutoSize = true;
      this.rsatis2.Dock = DockStyle.Fill;
      this.rsatis2.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis2.Location = new Point(132, 3);
      this.rsatis2.Name = "rsatis2";
      this.rsatis2.Size = new Size(123, 26);
      this.rsatis2.TabIndex = 11;
      this.rsatis2.TabStop = true;
      this.rsatis2.Text = "Fiyat 2";
      this.rsatis2.UseVisualStyleBackColor = true;
      this.rsatis4.AutoSize = true;
      this.rsatis4.Dock = DockStyle.Fill;
      this.rsatis4.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis4.Location = new Point(390, 3);
      this.rsatis4.Name = "rsatis4";
      this.rsatis4.Size = new Size(123, 26);
      this.rsatis4.TabIndex = 9;
      this.rsatis4.TabStop = true;
      this.rsatis4.Text = "Fiyat 4";
      this.rsatis4.UseVisualStyleBackColor = true;
      this.rsatis3.AutoSize = true;
      this.rsatis3.Dock = DockStyle.Fill;
      this.rsatis3.Font = new Font("Microsoft Sans Serif", 10.01739f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.rsatis3.Location = new Point(261, 3);
      this.rsatis3.Name = "rsatis3";
      this.rsatis3.Size = new Size(123, 26);
      this.rsatis3.TabIndex = 10;
      this.rsatis3.TabStop = true;
      this.rsatis3.Text = "Fiyat 3";
      this.rsatis3.UseVisualStyleBackColor = true;
      this.tableLayoutPanel14.ColumnCount = 8;
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5f));
      this.tableLayoutPanel14.Controls.Add((Control) this.bs10, 6, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bsar, 0, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bs5, 5, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bsaz, 1, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bs4, 4, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bs2, 2, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.bs3, 3, 0);
      this.tableLayoutPanel14.Controls.Add((Control) this.tableLayoutPanel15, 7, 0);
      this.tableLayoutPanel14.Location = new Point(106, 273);
      this.tableLayoutPanel14.Name = "tableLayoutPanel14";
      this.tableLayoutPanel14.RowCount = 1;
      this.tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel14.Size = new Size(667, 57);
      this.tableLayoutPanel14.TabIndex = 13;
      this.bs10.BackColor = Color.DimGray;
      this.bs10.Dock = DockStyle.Fill;
      this.bs10.FlatStyle = FlatStyle.Flat;
      this.bs10.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs10.ForeColor = Color.White;
      this.bs10.Location = new Point(499, 1);
      this.bs10.Margin = new Padding(1);
      this.bs10.Name = "bs10";
      this.bs10.Size = new Size(81, 55);
      this.bs10.TabIndex = 7;
      this.bs10.Text = "10";
      this.bs10.UseVisualStyleBackColor = false;
      this.bsar.BackColor = Color.DimGray;
      this.bsar.Dock = DockStyle.Fill;
      this.bsar.FlatStyle = FlatStyle.Flat;
      this.bsar.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bsar.ForeColor = Color.White;
      this.bsar.Location = new Point(1, 1);
      this.bsar.Margin = new Padding(1);
      this.bsar.Name = "bsar";
      this.bsar.Size = new Size(81, 55);
      this.bsar.TabIndex = 6;
      this.bsar.Text = "X(+)";
      this.bsar.UseVisualStyleBackColor = false;
      this.bs5.BackColor = Color.DimGray;
      this.bs5.Dock = DockStyle.Fill;
      this.bs5.FlatStyle = FlatStyle.Flat;
      this.bs5.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs5.ForeColor = Color.White;
      this.bs5.Location = new Point(416, 1);
      this.bs5.Margin = new Padding(1);
      this.bs5.Name = "bs5";
      this.bs5.Size = new Size(81, 55);
      this.bs5.TabIndex = 8;
      this.bs5.Text = "5";
      this.bs5.UseVisualStyleBackColor = false;
      this.bsaz.BackColor = Color.DimGray;
      this.bsaz.Dock = DockStyle.Fill;
      this.bsaz.FlatStyle = FlatStyle.Flat;
      this.bsaz.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bsaz.ForeColor = Color.White;
      this.bsaz.Location = new Point(84, 1);
      this.bsaz.Margin = new Padding(1);
      this.bsaz.Name = "bsaz";
      this.bsaz.Size = new Size(81, 55);
      this.bsaz.TabIndex = 12;
      this.bsaz.Text = "X(-)";
      this.bsaz.UseVisualStyleBackColor = false;
      this.bs4.BackColor = Color.DimGray;
      this.bs4.Dock = DockStyle.Fill;
      this.bs4.FlatStyle = FlatStyle.Flat;
      this.bs4.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs4.ForeColor = Color.White;
      this.bs4.Location = new Point(333, 1);
      this.bs4.Margin = new Padding(1);
      this.bs4.Name = "bs4";
      this.bs4.Size = new Size(81, 55);
      this.bs4.TabIndex = 9;
      this.bs4.Text = "4";
      this.bs4.UseVisualStyleBackColor = false;
      this.bs2.BackColor = Color.DimGray;
      this.bs2.Dock = DockStyle.Fill;
      this.bs2.FlatStyle = FlatStyle.Flat;
      this.bs2.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs2.ForeColor = Color.White;
      this.bs2.Location = new Point(167, 1);
      this.bs2.Margin = new Padding(1);
      this.bs2.Name = "bs2";
      this.bs2.Size = new Size(81, 55);
      this.bs2.TabIndex = 11;
      this.bs2.Text = "2";
      this.bs2.UseVisualStyleBackColor = false;
      this.bs3.BackColor = Color.DimGray;
      this.bs3.Dock = DockStyle.Fill;
      this.bs3.FlatStyle = FlatStyle.Flat;
      this.bs3.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.bs3.ForeColor = Color.White;
      this.bs3.Location = new Point(250, 1);
      this.bs3.Margin = new Padding(1);
      this.bs3.Name = "bs3";
      this.bs3.Size = new Size(81, 55);
      this.bs3.TabIndex = 10;
      this.bs3.Text = "3";
      this.bs3.UseVisualStyleBackColor = false;
      this.tableLayoutPanel15.ColumnCount = 1;
      this.tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel15.Controls.Add((Control) this.label3, 0, 0);
      this.tableLayoutPanel15.Location = new Point(582, 1);
      this.tableLayoutPanel15.Margin = new Padding(1);
      this.tableLayoutPanel15.Name = "tableLayoutPanel15";
      this.tableLayoutPanel15.RowCount = 2;
      this.tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 30f));
      this.tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 70f));
      this.tableLayoutPanel15.Size = new Size(84, 55);
      this.tableLayoutPanel15.TabIndex = 13;
      this.label3.AutoSize = true;
      this.label3.Dock = DockStyle.Fill;
      this.label3.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.label3.ForeColor = Color.DarkOrange;
      this.label3.Location = new Point(3, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(78, 16);
      this.label3.TabIndex = 3;
      this.label3.Text = "ADET:";
      this.textBox2.Font = new Font("Microsoft Sans Serif", 20.03478f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.textBox2.Location = new Point(843, 343);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new Size(58, 44);
      this.textBox2.TabIndex = 7;
      this.tGenelToplam.BackColor = Color.Tomato;
      this.tGenelToplam.BorderStyle = BorderStyle.None;
      this.tGenelToplam.Font = new Font("Microsoft Sans Serif", 34f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.tGenelToplam.ForeColor = Color.White;
      this.tGenelToplam.Location = new Point(9, 94);
      this.tGenelToplam.Margin = new Padding(0);
      this.tGenelToplam.Name = "tGenelToplam";
      this.tGenelToplam.ReadOnly = true;
      this.tGenelToplam.Size = new Size(386, 62);
      this.tGenelToplam.TabIndex = 2;
      this.tGenelToplam.Text = "00";
      this.tGenelToplam.TextAlign = HorizontalAlignment.Center;
      this.chYazdirma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.chYazdirma.AutoSize = true;
      this.chYazdirma.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 162);
      this.chYazdirma.Location = new Point(557, 117);
      this.chYazdirma.Name = "chYazdirma";
      this.chYazdirma.Size = new Size(117, 29);
      this.chYazdirma.TabIndex = 12;
      this.chYazdirma.Text = "Fiş Yazdır";
      this.chYazdirma.UseVisualStyleBackColor = true;
      this.lNakit.AutoSize = true;
      this.lNakit.Location = new Point(420, 124);
      this.lNakit.Name = "lNakit";
      this.lNakit.Size = new Size(38, 16);
      this.lNakit.TabIndex = 10;
      this.lNakit.Text = "Nakit";
      this.lNakit.Visible = false;
      this.lKart.AutoSize = true;
      this.lKart.Location = new Point(428, 94);
      this.lKart.Name = "lKart";
      this.lKart.Size = new Size(30, 16);
      this.lKart.TabIndex = 9;
      this.lKart.Text = "Kart";
      this.lKart.Visible = false;
      this.lKullanici.AutoSize = true;
      this.lKullanici.Location = new Point(468, 94);
      this.lKullanici.Name = "lKullanici";
      this.lKullanici.Size = new Size(59, 16);
      this.lKullanici.TabIndex = 8;
      this.lKullanici.Text = "Kullanıcı:";
      this.chsatisiadeislemi.Appearance = Appearance.Button;
      this.chsatisiadeislemi.AutoSize = true;
      this.chsatisiadeislemi.BackColor = Color.Olive;
      this.chsatisiadeislemi.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
      this.chsatisiadeislemi.FlatAppearance.CheckedBackColor = Color.DarkRed;
      this.chsatisiadeislemi.FlatStyle = FlatStyle.Flat;
      this.chsatisiadeislemi.Font = new Font("Microsoft Sans Serif", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.chsatisiadeislemi.ForeColor = Color.White;
      this.chsatisiadeislemi.Location = new Point(752, 122);
      this.chsatisiadeislemi.Name = "chsatisiadeislemi";
      this.chsatisiadeislemi.Size = new Size(149, 32);
      this.chsatisiadeislemi.TabIndex = 2;
      this.chsatisiadeislemi.Text = "Satış Yapılıyor";
      this.chsatisiadeislemi.UseVisualStyleBackColor = false;
      this.GridBekle.AllowUserToAddRows = false;
      this.GridBekle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.GridBekle.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.GridBekle.BorderStyle = BorderStyle.None;
      gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
      gridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
      gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      gridViewCellStyle1.ForeColor = Color.White;
      gridViewCellStyle1.Padding = new Padding(3);
      gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
      gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
      gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
      this.GridBekle.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
      this.GridBekle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.GridBekle.Columns.AddRange((DataGridViewColumn) this.dataGridViewTextBoxColumn1, (DataGridViewColumn) this.dataGridViewTextBoxColumn2, (DataGridViewColumn) this.dataGridViewTextBoxColumn3, (DataGridViewColumn) this.dataGridViewTextBoxColumn4, (DataGridViewColumn) this.dataGridViewTextBoxColumn5, (DataGridViewColumn) this.dataGridViewTextBoxColumn6, (DataGridViewColumn) this.dataGridViewTextBoxColumn7, (DataGridViewColumn) this.dataGridViewTextBoxColumn8, (DataGridViewColumn) this.dataGridViewTextBoxColumn9, (DataGridViewColumn) this.dataGridViewTextBoxColumn10, (DataGridViewColumn) this.dataGridViewTextBoxColumn11, (DataGridViewColumn) this.dataGridViewTextBoxColumn12, (DataGridViewColumn) this.dataGridViewTextBoxColumn13, (DataGridViewColumn) this.dataGridViewTextBoxColumn14, (DataGridViewColumn) this.dataGridViewImageColumn1);
      this.GridBekle.EnableHeadersVisualStyles = false;
      this.GridBekle.Location = new Point(405, 177);
      this.GridBekle.Margin = new Padding(1);
      this.GridBekle.Name = "GridBekle";
      this.GridBekle.RowHeadersVisible = false;
      this.GridBekle.RowHeadersWidth = 49;
      gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.GridBekle.RowsDefaultCellStyle = gridViewCellStyle2;
      this.GridBekle.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.GridBekle.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.GridBekle.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.GridBekle.RowTemplate.Height = 33;
      this.GridBekle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.GridBekle.Size = new Size(81, 45);
      this.GridBekle.TabIndex = 11;
      this.GridBekle.Visible = false;
      this.dataGridViewTextBoxColumn1.HeaderText = "Barkod";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = gridViewCellStyle3;
      this.dataGridViewTextBoxColumn3.HeaderText = "Birim";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn4.HeaderText = "KdvTutar";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Visible = false;
      this.dataGridViewTextBoxColumn5.HeaderText = "AlıisFiyat";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Visible = false;
      this.dataGridViewTextBoxColumn6.HeaderText = "UrunGrup";
      this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.Visible = false;
      gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.dataGridViewTextBoxColumn7.DefaultCellStyle = gridViewCellStyle4;
      this.dataGridViewTextBoxColumn7.HeaderText = "Miktar";
      this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle5.Format = "C2";
      gridViewCellStyle5.NullValue = (object) null;
      this.dataGridViewTextBoxColumn8.DefaultCellStyle = gridViewCellStyle5;
      this.dataGridViewTextBoxColumn8.HeaderText = "Fiyat";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      gridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
      gridViewCellStyle6.Format = "C2";
      gridViewCellStyle6.NullValue = (object) null;
      this.dataGridViewTextBoxColumn9.DefaultCellStyle = gridViewCellStyle6;
      this.dataGridViewTextBoxColumn9.HeaderText = "Toplam";
      this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn10.HeaderText = "Fiyat2";
      this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.Visible = false;
      this.dataGridViewTextBoxColumn11.HeaderText = "Fiyat3";
      this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.Visible = false;
      this.dataGridViewTextBoxColumn12.HeaderText = "Fiyat4";
      this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.Visible = false;
      this.dataGridViewTextBoxColumn13.HeaderText = "Fiyat5";
      this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
      this.dataGridViewTextBoxColumn13.Visible = false;
      this.dataGridViewTextBoxColumn14.HeaderText = "Ürün ID";
      this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
      this.dataGridViewImageColumn1.HeaderText = "Sİl";
      this.dataGridViewImageColumn1.Image = (Image) componentResourceManager.GetObject("dataGridViewImageColumn1.Image");
      this.dataGridViewImageColumn1.MinimumWidth = 6;
      this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1208, 590);
      this.Controls.Add((Control) this.panel1);
      this.Name = nameof (fdeneme);
      this.Text = nameof (fdeneme);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tableLayoutPanel17.ResumeLayout(false);
      this.tableLayoutPanel17.PerformLayout();
      this.tableLayoutPanel16.ResumeLayout(false);
      this.tableLayoutPanel16.PerformLayout();
      this.tableLayoutPanel14.ResumeLayout(false);
      this.tableLayoutPanel15.ResumeLayout(false);
      this.tableLayoutPanel15.PerformLayout();
      ((ISupportInitialize) this.GridBekle).EndInit();
      this.ResumeLayout(false);
    }
  }
}