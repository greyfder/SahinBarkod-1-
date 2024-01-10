// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.StokHareket
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System;

namespace SahinBarkod_1_
{
  public class StokHareket
  {
    public int Id { get; set; }

    public string Barkod { get; set; }

    public string UrunAd { get; set; }

    public string Birim { get; set; }

    public double? Miktar { get; set; }

    public string UrunGrup { get; set; }

    public string Kullanici { get; set; }

    public DateTime? Tarih { get; set; }
  }
}
