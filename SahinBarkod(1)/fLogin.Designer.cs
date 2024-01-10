namespace SahinBarkod_1_
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.tKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bGiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // tKullaniciAdi
            // 
            this.tKullaniciAdi.Location = new System.Drawing.Point(181, 138);
            this.tKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tKullaniciAdi.Name = "tKullaniciAdi";
            this.tKullaniciAdi.Size = new System.Drawing.Size(204, 33);
            this.tKullaniciAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(99, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre:";
            // 
            // tSifre
            // 
            this.tSifre.Location = new System.Drawing.Point(181, 186);
            this.tSifre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tSifre.Name = "tSifre";
            this.tSifre.PasswordChar = '*';
            this.tSifre.Size = new System.Drawing.Size(204, 33);
            this.tSifre.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SahinBarkod_1_.Properties.Resources.scan_barcode_with_scanner_tool;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(186, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Barkodlu Satış Programı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(119, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 84);
            this.label4.TabIndex = 0;
            this.label4.Text = "Şahin Şahinoğlu";
            // 
            // bGiris
            // 
            this.bGiris.BackColor = System.Drawing.Color.Teal;
            this.bGiris.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGiris.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bGiris.Location = new System.Drawing.Point(392, 138);
            this.bGiris.Name = "bGiris";
            this.bGiris.Size = new System.Drawing.Size(138, 81);
            this.bGiris.TabIndex = 3;
            this.bGiris.Text = "Giriş";
            this.bGiris.UseVisualStyleBackColor = false;
            this.bGiris.Click += new System.EventHandler(this.bGiris_Click);
            this.bGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bGiris_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(553, 239);
            this.Controls.Add(this.bGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tKullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bGiris;
        private System.Windows.Forms.Button button1;
    }
}