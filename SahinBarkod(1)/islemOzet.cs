//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SahinBarkod_1_
{
    using System;
    using System.Collections.Generic;
    
    public partial class islemOzet
    {
        public int Id { get; set; }
        public Nullable<int> İslemNo { get; set; }
        public Nullable<bool> İade { get; set; }
        public string OdemeSekli { get; set; }
        public Nullable<double> Nakit { get; set; }
        public Nullable<double> Kart { get; set; }
        public Nullable<bool> Gelir { get; set; }
        public Nullable<bool> Gider { get; set; }
        public Nullable<double> AlısFiyatToplam { get; set; }
        public string Acıklama { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Kullanici { get; set; }
    }
}
