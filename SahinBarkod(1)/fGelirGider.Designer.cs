namespace SahinBarkod_1_
{
    partial class fGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGelirGider));
            this.cmİslemTuru = new System.Windows.Forms.ComboBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.bEkle = new SahinBarkod_1_.bstandart();
            this.lstandart3 = new SahinBarkod_1_.lstandart();
            this.lstandart2 = new SahinBarkod_1_.lstandart();
            this.tAcıklama = new SahinBarkod_1_.tstandart();
            this.lKart = new SahinBarkod_1_.lstandart();
            this.lNakit = new SahinBarkod_1_.lstandart();
            this.tKart = new SahinBarkod_1_.tnumeric();
            this.tNakit = new SahinBarkod_1_.tnumeric();
            this.tOdemeTuru = new SahinBarkod_1_.lstandart();
            this.lGelirGider = new SahinBarkod_1_.lstandart();
            this.SuspendLayout();
            // 
            // cmİslemTuru
            // 
            this.cmİslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmİslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmİslemTuru.FormattingEnabled = true;
            this.cmİslemTuru.Items.AddRange(new object[] {
            "NAKİT",
            "KART",
            "KART-NAKİT"});
            this.cmİslemTuru.Location = new System.Drawing.Point(12, 79);
            this.cmİslemTuru.Name = "cmİslemTuru";
            this.cmİslemTuru.Size = new System.Drawing.Size(281, 32);
            this.cmİslemTuru.TabIndex = 2;
            this.cmİslemTuru.SelectedIndexChanged += new System.EventHandler(this.cmİslemTuru_SelectedIndexChanged);
            // 
            // dtTarih
            // 
            this.dtTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTarih.Location = new System.Drawing.Point(12, 409);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(281, 29);
            this.dtTarih.TabIndex = 10;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEkle.Image = global::SahinBarkod_1_.Properties.Resources.Ekle32;
            this.bEkle.Location = new System.Drawing.Point(158, 442);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(135, 69);
            this.bEkle.TabIndex = 11;
            this.bEkle.Text = " EKLE";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // lstandart3
            // 
            this.lstandart3.AutoSize = true;
            this.lstandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart3.Location = new System.Drawing.Point(13, 381);
            this.lstandart3.Name = "lstandart3";
            this.lstandart3.Size = new System.Drawing.Size(57, 25);
            this.lstandart3.TabIndex = 9;
            this.lstandart3.Text = "Tarih";
            // 
            // lstandart2
            // 
            this.lstandart2.AutoSize = true;
            this.lstandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart2.Location = new System.Drawing.Point(18, 203);
            this.lstandart2.Name = "lstandart2";
            this.lstandart2.Size = new System.Drawing.Size(92, 25);
            this.lstandart2.TabIndex = 8;
            this.lstandart2.Text = "Açıklama";
            // 
            // tAcıklama
            // 
            this.tAcıklama.BackColor = System.Drawing.Color.White;
            this.tAcıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAcıklama.Location = new System.Drawing.Point(12, 231);
            this.tAcıklama.Multiline = true;
            this.tAcıklama.Name = "tAcıklama";
            this.tAcıklama.Size = new System.Drawing.Size(281, 133);
            this.tAcıklama.TabIndex = 7;
            // 
            // lKart
            // 
            this.lKart.AutoSize = true;
            this.lKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKart.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKart.Location = new System.Drawing.Point(144, 118);
            this.lKart.Name = "lKart";
            this.lKart.Size = new System.Drawing.Size(48, 25);
            this.lKart.TabIndex = 6;
            this.lKart.Text = "Kart";
            // 
            // lNakit
            // 
            this.lNakit.AutoSize = true;
            this.lNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lNakit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lNakit.Location = new System.Drawing.Point(15, 118);
            this.lNakit.Name = "lNakit";
            this.lNakit.Size = new System.Drawing.Size(56, 25);
            this.lNakit.TabIndex = 5;
            this.lNakit.Text = "Nakit";
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(149, 149);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(144, 29);
            this.tKart.TabIndex = 4;
            this.tKart.Text = "0";
            this.tKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(15, 149);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(128, 29);
            this.tNakit.TabIndex = 3;
            this.tNakit.Text = "0";
            this.tNakit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tOdemeTuru
            // 
            this.tOdemeTuru.AutoSize = true;
            this.tOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tOdemeTuru.ForeColor = System.Drawing.Color.DarkCyan;
            this.tOdemeTuru.Location = new System.Drawing.Point(13, 49);
            this.tOdemeTuru.Name = "tOdemeTuru";
            this.tOdemeTuru.Size = new System.Drawing.Size(123, 25);
            this.tOdemeTuru.TabIndex = 0;
            this.tOdemeTuru.Text = "Ödeme Türü";
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelirGider.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lGelirGider.Location = new System.Drawing.Point(13, 13);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(136, 25);
            this.lGelirGider.TabIndex = 0;
            this.lGelirGider.Text = "GELİR-GİDER";
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(303, 525);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lstandart3);
            this.Controls.Add(this.lstandart2);
            this.Controls.Add(this.tAcıklama);
            this.Controls.Add(this.lKart);
            this.Controls.Add(this.lNakit);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.cmİslemTuru);
            this.Controls.Add(this.tOdemeTuru);
            this.Controls.Add(this.lGelirGider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(321, 570);
            this.MinimumSize = new System.Drawing.Size(321, 570);
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir-Gider İşlemleri";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lstandart lGelirGider;
        private System.Windows.Forms.ComboBox cmİslemTuru;
        private lstandart tOdemeTuru;
        private tnumeric tNakit;
        private tnumeric tKart;
        private lstandart lNakit;
        private lstandart lKart;
        private tstandart tAcıklama;
        private lstandart lstandart2;
        private lstandart lstandart3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private bstandart bEkle;
    }
}