namespace SahinBarkod_1_
{
    partial class fHızlıButonUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHızlıButonUrunEkle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bgeri = new System.Windows.Forms.Button();
            this.tResim = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bstandart1 = new SahinBarkod_1_.bstandart();
            this.chtumu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbutonid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tUrunAra = new System.Windows.Forms.TextBox();
            this.GridUrunler = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bgeri);
            this.splitContainer1.Panel1.Controls.Add(this.tResim);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.bstandart1);
            this.splitContainer1.Panel1.Controls.Add(this.chtumu);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lbutonid);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridUrunler);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 702);
            this.splitContainer1.SplitterDistance = 128;
            this.splitContainer1.TabIndex = 0;
            // 
            // bgeri
            // 
            this.bgeri.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bgeri.BackColor = System.Drawing.Color.DimGray;
            this.bgeri.Image = global::SahinBarkod_1_.Properties.Resources.exit32;
            this.bgeri.Location = new System.Drawing.Point(959, 3);
            this.bgeri.Name = "bgeri";
            this.bgeri.Size = new System.Drawing.Size(160, 122);
            this.bgeri.TabIndex = 8;
            this.bgeri.UseVisualStyleBackColor = false;
            this.bgeri.Click += new System.EventHandler(this.bgeri_Click);
            // 
            // tResim
            // 
            this.tResim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tResim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tResim.Location = new System.Drawing.Point(719, 29);
            this.tResim.Name = "tResim";
            this.tResim.Size = new System.Drawing.Size(208, 31);
            this.tResim.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(565, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bstandart1
            // 
            this.bstandart1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bstandart1.BackColor = System.Drawing.Color.Tomato;
            this.bstandart1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bstandart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bstandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bstandart1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bstandart1.Location = new System.Drawing.Point(719, 64);
            this.bstandart1.Margin = new System.Windows.Forms.Padding(1);
            this.bstandart1.Name = "bstandart1";
            this.bstandart1.Size = new System.Drawing.Size(208, 60);
            this.bstandart1.TabIndex = 0;
            this.bstandart1.Text = "Resim Seç";
            this.bstandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bstandart1.UseVisualStyleBackColor = false;
            this.bstandart1.Click += new System.EventHandler(this.bstandart1_Click);
            // 
            // chtumu
            // 
            this.chtumu.AutoSize = true;
            this.chtumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chtumu.ForeColor = System.Drawing.Color.DarkCyan;
            this.chtumu.Location = new System.Drawing.Point(392, 81);
            this.chtumu.Name = "chtumu";
            this.chtumu.Size = new System.Drawing.Size(167, 29);
            this.chtumu.TabIndex = 4;
            this.chtumu.Text = "Tümünü Göster";
            this.chtumu.UseVisualStyleBackColor = true;
            this.chtumu.CheckedChanged += new System.EventHandler(this.chtumu_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buton Numarası:";
            // 
            // lbutonid
            // 
            this.lbutonid.AutoSize = true;
            this.lbutonid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbutonid.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbutonid.Location = new System.Drawing.Point(153, 19);
            this.lbutonid.Name = "lbutonid";
            this.lbutonid.Size = new System.Drawing.Size(81, 18);
            this.lbutonid.TabIndex = 3;
            this.lbutonid.Text = "Buton no;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(9, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Urun Ara:";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tUrunAra.Location = new System.Drawing.Point(12, 80);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(374, 29);
            this.tUrunAra.TabIndex = 2;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // GridUrunler
            // 
            this.GridUrunler.AllowUserToAddRows = false;
            this.GridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridUrunler.EnableHeadersVisualStyles = false;
            this.GridUrunler.Location = new System.Drawing.Point(0, 0);
            this.GridUrunler.Margin = new System.Windows.Forms.Padding(1);
            this.GridUrunler.Name = "GridUrunler";
            this.GridUrunler.ReadOnly = true;
            this.GridUrunler.RowHeadersVisible = false;
            this.GridUrunler.RowHeadersWidth = 49;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.GridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridUrunler.RowTemplate.Height = 33;
            this.GridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUrunler.Size = new System.Drawing.Size(1122, 570);
            this.GridUrunler.TabIndex = 2;
            this.GridUrunler.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUrunler_CellContentDoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fHızlıButonUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 702);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHızlıButonUrunEkle";
            this.Text = "Hızlı Buton Urun Ekleme";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fHızlıButonUrunEkle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GridUrunler;
        private System.Windows.Forms.CheckBox chtumu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tUrunAra;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbutonid;
        private bstandart bstandart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tResim;
        private System.Windows.Forms.Button bgeri;
    }
}