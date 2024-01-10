// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.bstandart
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal class bstandart : Button
  {
    public bstandart()
    {
      this.BackColor = Color.Tomato;
      this.FlatAppearance.BorderColor = Color.Tomato;
      this.FlatStyle = FlatStyle.Flat;
      this.Font = new Font("Microsoft Sans Serif", 11.89565f, FontStyle.Bold, GraphicsUnit.Point, (byte) 162);
      this.ForeColor = SystemColors.ButtonHighlight;
      this.Location = new Point(1, 1);
      this.Margin = new Padding(1);
      this.Name = "bNakit";
      this.Size = new Size(157, 109);
      this.TabIndex = 0;
      this.Text = "NAKİT\r\n(F1)";
      this.TextImageRelation = TextImageRelation.TextAboveImage;
      this.UseVisualStyleBackColor = false;
    }
  }
}
