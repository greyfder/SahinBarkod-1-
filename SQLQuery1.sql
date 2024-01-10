create procedure stok as
select k1.Barkod,k1.UrunAd,k1.UrunGrup,k1.Birim,k1.SatisFiyat,k1.Miktar,k1.Tarih,k1.Kullanci from Urun k1 inner join CokluB k2 on k1.Urunid = k2.Urunid