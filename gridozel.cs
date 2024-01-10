// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.gridozel
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal class gridozel : DataGridView
  {
    public gridozel()
    {
      this.AllowUserToAddRows = false;
      this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      this.BackgroundColor = SystemColors.GradientInactiveCaption;
      this.BorderStyle = BorderStyle.None;
      this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
      this.DefaultCellStyle.BackColor = Color.FromArgb(0, 174, 219);
      this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.765218f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.DefaultCellStyle.ForeColor = Color.White;
      this.DefaultCellStyle.Padding = new Padding(3);
      this.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
      this.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
      this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
      this.ColumnHeadersDefaultCellStyle = this.DefaultCellStyle;
      this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.EnableHeadersVisualStyles = false;
      this.Location = new Point(1, 224);
      this.Margin = new Padding(1);
      this.Name = "GridSatis";
      this.RowHeadersVisible = false;
      this.RowHeadersWidth = 49;
      this.Dock = DockStyle.Fill;
      this.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11.26957f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.RowsDefaultCellStyle = this.DefaultCellStyle;
      this.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
      this.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Silver;
      this.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
      this.RowTemplate.Height = 33;
      this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      this.Size = new Size(795, 440);
    }
  }
}
