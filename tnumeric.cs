// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.tnumeric
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SahinBarkod_1_
{
  internal class tnumeric : TextBox
  {
    public tnumeric()
    {
      this.Size = new Size(115, 26);
      this.BackColor = Color.White;
      this.Font = new Font("Microsoft Sans Serif", 12f);
      this.Name = "tNumeric";
      this.TextAlign = HorizontalAlignment.Right;
      this.Click += new EventHandler(this.Tnumeric_Click);
      this.KeyPress += new KeyPressEventHandler(this.Tnumeric_KeyPress);
    }

    private void Tnumeric_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ',')
        return;
      e.Handled = true;
    }

    private void Tnumeric_Click(object sender, EventArgs e) => this.SelectAll();
  }
}
