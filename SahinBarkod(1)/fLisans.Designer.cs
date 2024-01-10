namespace SahinBarkod_1_
{
    partial class fLisans
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
            this.tLisansno = new SahinBarkod_1_.tstandart();
            this.lstandart2 = new SahinBarkod_1_.lstandart();
            this.lKontrolNo = new SahinBarkod_1_.lstandart();
            this.bTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tLisansno
            // 
            this.tLisansno.BackColor = System.Drawing.Color.White;
            this.tLisansno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tLisansno.Location = new System.Drawing.Point(54, 86);
            this.tLisansno.Name = "tLisansno";
            this.tLisansno.Size = new System.Drawing.Size(250, 29);
            this.tLisansno.TabIndex = 1;
            // 
            // lstandart2
            // 
            this.lstandart2.AutoSize = true;
            this.lstandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lstandart2.Location = new System.Drawing.Point(49, 9);
            this.lstandart2.Name = "lstandart2";
            this.lstandart2.Size = new System.Drawing.Size(150, 25);
            this.lstandart2.TabIndex = 0;
            this.lstandart2.Text = "KONTROL NO:";
            // 
            // lKontrolNo
            // 
            this.lKontrolNo.AutoSize = true;
            this.lKontrolNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKontrolNo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKontrolNo.Location = new System.Drawing.Point(49, 47);
            this.lKontrolNo.Name = "lKontrolNo";
            this.lKontrolNo.Size = new System.Drawing.Size(97, 25);
            this.lKontrolNo.TabIndex = 0;
            this.lKontrolNo.Text = "lstandart1";
            // 
            // bTamam
            // 
            this.bTamam.Location = new System.Drawing.Point(71, 150);
            this.bTamam.Name = "bTamam";
            this.bTamam.Size = new System.Drawing.Size(166, 56);
            this.bTamam.TabIndex = 2;
            this.bTamam.Text = "Ekle";
            this.bTamam.UseVisualStyleBackColor = true;
            this.bTamam.Click += new System.EventHandler(this.bTamam_Click);
            // 
            // fLisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 267);
            this.Controls.Add(this.bTamam);
            this.Controls.Add(this.tLisansno);
            this.Controls.Add(this.lstandart2);
            this.Controls.Add(this.lKontrolNo);
            this.Name = "fLisans";
            this.Text = "LİSANS İŞLEMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private tstandart tLisansno;
        private lstandart lstandart2;
        internal lstandart lKontrolNo;
        private System.Windows.Forms.Button bTamam;
    }
}