create proc BolumListele
as
begin
select * from Bolumler
end


-----------------------

create proc BolumEkle(
@BolumAdi varchar(50),
@OgrenciSayisi int )
as begin
insert into Bolumler(BolumAdi,OgrenciSayisi)VALUES(@BolumAdi,@OgrenciSayisi)
end


--------------------
create proc BolumGuncelle
@Bolum_Id int,@BolumAdi varchar(50),@OgrenciSayisi int
as begin update 
Bolumler set BolumAdi=@BolumAdi,OgrenciSayisi=@OgrenciSayisi where Bolum_Id=@Bolum_Id
END

------------

create proc BolumSil
@Bolum_Id int as begin 
delete from Bolumler where Bolum_Id=@Bolum_Id
end

-------

create proc DersListele
as begin 
select * from Dersler 
end

---------
create proc DersEkle(
@DersAdi varchar(50),
@Ogretmen_Id int
)
as begin
insert into Dersler(DersAdi,Ogretmen_Id) values(@DersAdi,@Ogretmen_Id)
end
---------
create proc DersGuncelle
@Ders_Id int,@DersAdi varchar(50),@Ogretmen_Id int
as begin update 
Dersler set DersAdi=@DersAdi,Ogretmen_Id=@Ogretmen_Id where Ders_Id=@Ders_Id
end

------------
create proc DersSil
@Ders_Id int as begin 
delete from Dersler where Ders_Id=@Ders_Id
end

-------

create proc NotListele
as begin 
select * from Notlar
end

------
create proc NotEkle(
@Ders_Id int,
@OgrenciNo int,
@Vize float,
@Final float,
@Ortalama float,
@Durum varchar(50)
)
as begin 
insert into Notlar(Ders_Id,OgrenciNo,Vize,Final,Ortalama,Durum) values (@Ders_Id,@OgrenciNo,@Vize,@Final,@Ortalama,@Durum)
end
--------------
create proc NotGuncelle
@Not_Id int ,@Ders_Id int ,@OgrenciNo int, @Vize float,@Final float,@Ortalama float,@Durum varchar(50) 
as begin update 
Notlar set Ders_Id=@Ders_Id,OgrenciNo=@OgrenciNo,Vize=@Vize,Final=@Final,Ortalama=@Ortalama,Durum=@Durum where Not_Id=@Not_Id
end

---
create proc NotSil
@Not_Id int as begin
delete from Notlar where  Not_Id=@Not_Id
end

--------

create proc OgrenciListele
as begin
select * from Ogrenciler
end
----------------
create proc OgrenciEkle(
@OgrenciAdi varchar(50),
@OgrenciSoyadi varchar(50),
@Bolum_Id int
)
 as begin
insert into Ogrenciler(OgrenciAdi,OgrenciSoyadi,Bolum_Id) values (@OgrenciAdi,@OgrenciSoyadi,@Bolum_Id)
end
-------
CREATE PROC OgrenciGuncelle
@OgrenciNo int,@OgrenciAdi varchar(50),@OgrenciSoyadi varchar(50),@Bolum_Id int
as begin update 
Ogrenciler set OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,Bolum_Id=@Bolum_Id where OgrenciNo=@OgrenciNo
end
----
create proc OgrenciSil
@OgrenciNo int as begin
delete from Ogrenciler where OgrenciNo=@OgrenciNo
end
--------------
create proc OgretmenListele
as begin
select * from Ogretmenler end
-----------
create proc OgretmenEkle(
@OgretmenAdi varchar(50),
@OgretmenSoyadi varchar(50),
@OgretmenBrans varchar(50)
)
 as begin 
insert into Ogretmenler(OgretmenAdi,OgretmenSoyadi,OgretmenBrans) values(@OgretmenAdi,@OgretmenSoyadi,@OgretmenBrans) end
-----------
create proc OgretmenGuncelle
@Ogretmen_Id int,@OgretmenAdi varchar(50),@OgretmenSoyadi varchar(50),@OgretmenBrans varchar(50)
as begin update
Ogretmenler set OgretmenAdi=@OgretmenAdi,OgretmenSoyadi=@OgretmenSoyadi,OgretmenBrans=@OgretmenBrans where Ogretmen_Id=@Ogretmen_Id
end
------
create proc OgretmenSil
@Ogretmen_Id int as begin
delete from Ogretmenler where Ogretmen_Id=@Ogretmen_Id end

----
create proc BolumAra
@BolumAdi varchar(50)
as begin 
select * from Bolumler where BolumAdi=@BolumAdi
end

create proc DersAra
@DersAdi varchar(50)
as begin 
select * from Dersler where DersAdi=@DersAdi
end
---
create proc NotAra
@Ders_Id int
as begin 
select * from Notlar where Ders_Id=@Ders_Id
end
---
create proc OgrenciAra
@OgrenciAdi varchar(50)
as begin 
select * from Ogrenciler where OgrenciAdi=@OgrenciAdi
end

----
create proc OgretmenAra
@OgretmenAdi varchar(50)
as begin 
select * from Ogretmenler where OgretmenAdi=@OgretmenAdi
end


----
create proc KullaniciGiris(
@KullaniciAdi varchar(50),
@Sifre varchar(50)
)
as begin select * from Kullanici where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre 
end 


create proc KullaniciEkle(
@KullaniciAdi varchar(50),
@Sifre varchar(50),
@Mail varchar(50),
@Telefon char(10)
)
as begin
insert into Kullanici(KullaniciAdi,Sifre,Mail,Telefon) values (@KullaniciAdi,@Sifre,@Mail,@Telefon) 
end



