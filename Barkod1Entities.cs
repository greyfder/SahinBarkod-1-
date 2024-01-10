// Decompiled with JetBrains decompiler
// Type: SahinBarkod_1_.Barkod1Entities
// Assembly: SahinBarkod(1), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 385D7DEA-ECAA-432D-A8AE-7B00E3F12E6F
// Assembly location: C:\Barkodlu Satis Sahin\SahinBarkod(1).exe

using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace SahinBarkod_1_
{
  public class Barkod1Entities : DbContext
  {
    public Barkod1Entities()
      : base("name=Barkod1Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) => throw new UnintentionalCodeFirstException();

    public virtual DbSet<SahinBarkod_1_.Urun> Urun { get; set; }

    public virtual DbSet<SahinBarkod_1_.Terazi> Terazi { get; set; }

    public virtual DbSet<SahinBarkod_1_.Satisid> Satisid { get; set; }

    public virtual DbSet<SahinBarkod_1_.islem> islem { get; set; }

    public virtual DbSet<SahinBarkod_1_.islemOzet> islemOzet { get; set; }

    public virtual DbSet<SahinBarkod_1_.UrunGrup> UrunGrup { get; set; }

    public virtual DbSet<SahinBarkod_1_.Barkod> Barkod { get; set; }

    public virtual DbSet<SahinBarkod_1_.StokHareket> StokHareket { get; set; }

    public virtual DbSet<SahinBarkod_1_.CokluB> CokluB { get; set; }

    public virtual DbSet<SahinBarkod_1_.Sabit> Sabit { get; set; }

    public virtual DbSet<SahinBarkod_1_.Kullanici> Kullanici { get; set; }

    public virtual DbSet<SahinBarkod_1_.HızlıUrun> HızlıUrun { get; set; }

    public virtual DbSet<SahinBarkod_1_.Sbt> Sbt { get; set; }

    public virtual ObjectResult<cokurun_Result> cokurun() => ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction<cokurun_Result>(nameof (cokurun));

    public virtual ObjectResult<stok_Result> stok() => ((IObjectContextAdapter) this).ObjectContext.ExecuteFunction<stok_Result>(nameof (stok));
  }
}
