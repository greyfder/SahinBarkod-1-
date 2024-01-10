--create procedure cokurun as
select *,k2.Urunid as cokluid from Urun k1  inner join CokluB k2 on k1.Urunid=k2.Urunid;