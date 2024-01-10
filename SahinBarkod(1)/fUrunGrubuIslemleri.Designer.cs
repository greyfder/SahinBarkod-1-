namespace SahinBarkod_1_
{
    partial class fUrunGrubuIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGrubuIslemleri));
            this.listurungrup = new System.Windows.Forms.ListBox();
            this.bEkle = new SahinBarkod_1_.bstandart();
            this.tUrunGrupAd = new SahinBarkod_1_.tstandart();
            this.lstandart1 = new SahinBarkod_1_.lstandart();
            this.bSil = new SahinBarkod_1_.bstandart();
            this.SuspendLayout();
            // 
            // listurungrup
            // 
            this.listurungrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listurungrup.FormattingEnabled = true;
            this.listurungrup.ItemHeight = 24;
            this.listurungrup.Location = new System.Drawing.Point(17, 73);
            this.listurungrup.Name = "listurungrup";
            this.listurungrup.Size = new System.Drawing.Size(250, 244);
            this.listurungrup.TabIndex = 2;
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEkle.Image = global::SahinBarkod_1_.Properties.Resources.Ekle24;
            this.bEkle.Location = new System.Drawing.Point(138, 321);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(129, 73);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(17, 37);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(250, 29);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // lstandart1
            // 
            this.lstandart1.AutoSize = true;
            this.lstandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart1.Location = new System.Drawing.Point(12, 9);
            this.lstandart1.Name = "lstandart1";
            this.lstandart1.Size = new System.Drawing.Size(153, 25);
            this.lstandart1.TabIndex = 0;
            this.lstandart1.Text = "Ürün Grubu Adı:";
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.Maroon;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSil.Image = global::SahinBarkod_1_.Properties.Resources.clear4848;
            this.bSil.Location = new System.Drawing.Point(17, 321);
            this.bSil.Margin = new System.Windows.Forms.Padding(1);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(119, 73);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // fUrunGrubuIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(281, 404);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.listurungrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.lstandart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fUrunGrubuIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fUrunGrubuIslemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private lstandart lstandart1;
        private tstandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listurungrup;
        private bstandart bEkle;
        private bstandart bSil;
    }
}