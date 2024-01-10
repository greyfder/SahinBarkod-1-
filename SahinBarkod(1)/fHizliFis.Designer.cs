namespace SahinBarkod_1_
{
    partial class fHizliFis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bCikis = new System.Windows.Forms.Button();
            this.bGetir = new SahinBarkod_1_.bstandart();
            this.tYazdır = new SahinBarkod_1_.bstandart();
            this.bGöster = new SahinBarkod_1_.bstandart();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.lBitisTarih = new SahinBarkod_1_.lstandart();
            this.lBaslangıctarih = new SahinBarkod_1_.lstandart();
            this.dtBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.GridListe = new SahinBarkod_1_.gridozel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bCikis);
            this.splitContainer1.Panel1.Controls.Add(this.bGetir);
            this.splitContainer1.Panel1.Controls.Add(this.tYazdır);
            this.splitContainer1.Panel1.Controls.Add(this.bGöster);
            this.splitContainer1.Panel1.Controls.Add(this.dtBitis);
            this.splitContainer1.Panel1.Controls.Add(this.lBitisTarih);
            this.splitContainer1.Panel1.Controls.Add(this.lBaslangıctarih);
            this.splitContainer1.Panel1.Controls.Add(this.dtBaslangıc);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridListe);
            this.splitContainer1.Size = new System.Drawing.Size(1025, 431);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // bCikis
            // 
            this.bCikis.BackColor = System.Drawing.Color.DimGray;
            this.bCikis.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.bCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCikis.ForeColor = System.Drawing.Color.White;
            this.bCikis.Image = global::SahinBarkod_1_.Properties.Resources.exit4854;
            this.bCikis.Location = new System.Drawing.Point(807, 34);
            this.bCikis.Margin = new System.Windows.Forms.Padding(1);
            this.bCikis.Name = "bCikis";
            this.bCikis.Size = new System.Drawing.Size(142, 70);
            this.bCikis.TabIndex = 22;
            this.bCikis.UseVisualStyleBackColor = false;
            this.bCikis.Click += new System.EventHandler(this.bCikis_Click);
            // 
            // bGetir
            // 
            this.bGetir.BackColor = System.Drawing.Color.LightCoral;
            this.bGetir.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGetir.Image = global::SahinBarkod_1_.Properties.Resources.goz24;
            this.bGetir.Location = new System.Drawing.Point(428, 34);
            this.bGetir.Margin = new System.Windows.Forms.Padding(1);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(168, 70);
            this.bGetir.TabIndex = 12;
            this.bGetir.Text = "GETİR";
            this.bGetir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bGetir.UseVisualStyleBackColor = false;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // tYazdır
            // 
            this.tYazdır.BackColor = System.Drawing.Color.RosyBrown;
            this.tYazdır.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.tYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tYazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tYazdır.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tYazdır.Image = global::SahinBarkod_1_.Properties.Resources.printer;
            this.tYazdır.Location = new System.Drawing.Point(613, 34);
            this.tYazdır.Margin = new System.Windows.Forms.Padding(1);
            this.tYazdır.Name = "tYazdır";
            this.tYazdır.Size = new System.Drawing.Size(180, 70);
            this.tYazdır.TabIndex = 12;
            this.tYazdır.Text = "YAZDIR";
            this.tYazdır.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tYazdır.UseVisualStyleBackColor = false;
            this.tYazdır.Click += new System.EventHandler(this.tYazdır_Click);
            // 
            // bGöster
            // 
            this.bGöster.BackColor = System.Drawing.Color.Tomato;
            this.bGöster.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bGöster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bGöster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGöster.Image = global::SahinBarkod_1_.Properties.Resources.Ara32;
            this.bGöster.Location = new System.Drawing.Point(232, 34);
            this.bGöster.Margin = new System.Windows.Forms.Padding(1);
            this.bGöster.Name = "bGöster";
            this.bGöster.Size = new System.Drawing.Size(180, 70);
            this.bGöster.TabIndex = 12;
            this.bGöster.Text = "Göster";
            this.bGöster.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bGöster.UseVisualStyleBackColor = false;
            this.bGöster.Click += new System.EventHandler(this.bGöster_Click);
            // 
            // dtBitis
            // 
            this.dtBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitis.Location = new System.Drawing.Point(16, 80);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(196, 25);
            this.dtBitis.TabIndex = 11;
            // 
            // lBitisTarih
            // 
            this.lBitisTarih.AutoSize = true;
            this.lBitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBitisTarih.ForeColor = System.Drawing.Color.DarkCyan;
            this.lBitisTarih.Location = new System.Drawing.Point(13, 58);
            this.lBitisTarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBitisTarih.Name = "lBitisTarih";
            this.lBitisTarih.Size = new System.Drawing.Size(85, 20);
            this.lBitisTarih.TabIndex = 10;
            this.lBitisTarih.Text = "Bitiş Tarihi:";
            // 
            // lBaslangıctarih
            // 
            this.lBaslangıctarih.AutoSize = true;
            this.lBaslangıctarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lBaslangıctarih.ForeColor = System.Drawing.Color.DarkCyan;
            this.lBaslangıctarih.Location = new System.Drawing.Point(13, 11);
            this.lBaslangıctarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBaslangıctarih.Name = "lBaslangıctarih";
            this.lBaslangıctarih.Size = new System.Drawing.Size(124, 20);
            this.lBaslangıctarih.TabIndex = 9;
            this.lBaslangıctarih.Text = "Başlangıç Tarihi:";
            // 
            // dtBaslangıc
            // 
            this.dtBaslangıc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangıc.Location = new System.Drawing.Point(16, 34);
            this.dtBaslangıc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtBaslangıc.Name = "dtBaslangıc";
            this.dtBaslangıc.Size = new System.Drawing.Size(196, 25);
            this.dtBaslangıc.TabIndex = 8;
            // 
            // GridListe
            // 
            this.GridListe.AllowUserToAddRows = false;
            this.GridListe.AllowUserToDeleteRows = false;
            this.GridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridListe.EnableHeadersVisualStyles = false;
            this.GridListe.Location = new System.Drawing.Point(0, 0);
            this.GridListe.Margin = new System.Windows.Forms.Padding(1);
            this.GridListe.Name = "GridListe";
            this.GridListe.ReadOnly = true;
            this.GridListe.RowHeadersVisible = false;
            this.GridListe.RowHeadersWidth = 49;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.GridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.GridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridListe.RowTemplate.Height = 33;
            this.GridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListe.Size = new System.Drawing.Size(1025, 272);
            this.GridListe.TabIndex = 3;
            this.GridListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListe_CellDoubleClick);
            this.GridListe.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridListe_CellFormatting);
            // 
            // fHizliFis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 431);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fHizliFis";
            this.Text = "fHizliFis";
            this.Load += new System.EventHandler(this.fHizliFis_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private gridozel GridListe;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private lstandart lBitisTarih;
        private lstandart lBaslangıctarih;
        private System.Windows.Forms.DateTimePicker dtBaslangıc;
        private bstandart bGöster;
        private bstandart tYazdır;
        private bstandart bGetir;
        private System.Windows.Forms.Button bCikis;
    }
}