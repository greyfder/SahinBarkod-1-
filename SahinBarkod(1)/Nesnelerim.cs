using System;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
    class Nesnelerim
    {
    }
    class lstandart : Label
    {
        public lstandart()// ctor yazıp tab tab yapınca bu oto geliyor
        {
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Text = "lStandart";
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "lStandart";
        }
    }
    class bstandart : Button
    {
        public bstandart()
        {
            this.BackColor = System.Drawing.Color.Tomato;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "bNakit";
            this.Size = new System.Drawing.Size(157, 109);
            this.TabIndex = 0;
            this.Text = "NAKİT\r\n(F1)";
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.UseVisualStyleBackColor = false;
        }
    }
    class tstandart : TextBox
    {
        public tstandart()
        {
            this.Size = new System.Drawing.Size(250, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);

        }
    }
    class tnumeric : TextBox
    {
        public tnumeric()
        {
            this.Size = new System.Drawing.Size(115, 26);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "tNumeric";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Click += Tnumeric_Click; // bastığında
            this.KeyPress += Tnumeric_KeyPress;
        }

        private void Tnumeric_KeyPress(object sender, KeyPressEventArgs e) // sadece raka ve silmme tuşu çalışır
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void Tnumeric_Click(object sender, EventArgs e)
        {
            this.SelectAll(); // hepsini seçsin
        }
    }
    class gridozel : DataGridView
    {
        public gridozel()
        {
            this.AllowUserToAddRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(1, 224);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GridSatis";
            this.RowHeadersVisible = false;
            this.RowHeadersWidth = 49;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.26957F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RowsDefaultCellStyle = this.DefaultCellStyle;
            this.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(3);
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RowTemplate.Height = 33;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(795, 440);
        }
    }
}
