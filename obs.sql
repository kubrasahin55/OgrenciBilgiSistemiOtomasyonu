USE [ObsSistemi]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[Bolum_Id] [int] IDENTITY(1,1) NOT NULL,
	[BolumAdi] [varchar](50) NULL,
	[OgrenciSayisi] [int] NULL,
 CONSTRAINT [PK_Bolumler] PRIMARY KEY CLUSTERED 
(
	[Bolum_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dersler]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dersler](
	[Ders_Id] [int] IDENTITY(1,1) NOT NULL,
	[DersAdi] [varchar](50) NULL,
	[Ogretmen_Id] [int] NULL,
 CONSTRAINT [PK_Dersler] PRIMARY KEY CLUSTERED 
(
	[Ders_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciNo] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NULL,
	[Sifre] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Telefon] [char](20) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notlar]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notlar](
	[Not_Id] [int] IDENTITY(1,1) NOT NULL,
	[Ders_Id] [int] NULL,
	[OgrenciNo] [int] NULL,
	[Vize] [float] NULL,
	[Final] [float] NULL,
	[Ortalama] [float] NULL,
	[Durum] [varchar](50) NULL,
 CONSTRAINT [PK_Notlar] PRIMARY KEY CLUSTERED 
(
	[Not_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrenciNo] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciAdi] [varchar](50) NULL,
	[OgrenciSoyadi] [varchar](50) NULL,
	[Bolum_Id] [int] NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrenciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmenler]    Script Date: 6.07.2022 18:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmenler](
	[Ogretmen_Id] [int] IDENTITY(1,1) NOT NULL,
	[OgretmenAdi] [varchar](50) NULL,
	[OgretmenSoyadi] [varchar](50) NULL,
	[OgretmenBrans] [varchar](50) NULL,
 CONSTRAINT [PK_Ogretmenler] PRIMARY KEY CLUSTERED 
(
	[Ogretmen_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([Bolum_Id], [BolumAdi], [OgrenciSayisi]) VALUES (1, N'Ekonometri', 35)
INSERT [dbo].[Bolumler] ([Bolum_Id], [BolumAdi], [OgrenciSayisi]) VALUES (2, N'Cografya', 40)
INSERT [dbo].[Bolumler] ([Bolum_Id], [BolumAdi], [OgrenciSayisi]) VALUES (3, N'Matematik', 55)
INSERT [dbo].[Bolumler] ([Bolum_Id], [BolumAdi], [OgrenciSayisi]) VALUES (4, N'Gastronomi ve Mutfak Sanatları', 80)
INSERT [dbo].[Bolumler] ([Bolum_Id], [BolumAdi], [OgrenciSayisi]) VALUES (5, N'Bilişim', 40)
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
GO
SET IDENTITY_INSERT [dbo].[Dersler] ON 

INSERT [dbo].[Dersler] ([Ders_Id], [DersAdi], [Ogretmen_Id]) VALUES (1, N'Yiyecek Üretimi', 1)
INSERT [dbo].[Dersler] ([Ders_Id], [DersAdi], [Ogretmen_Id]) VALUES (2, N'Kartografya', 3)
INSERT [dbo].[Dersler] ([Ders_Id], [DersAdi], [Ogretmen_Id]) VALUES (3, N'Borçlar Hukuku', 3)
INSERT [dbo].[Dersler] ([Ders_Id], [DersAdi], [Ogretmen_Id]) VALUES (4, N'Finansal Muhasebe', 4)
SET IDENTITY_INSERT [dbo].[Dersler] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAdi], [Sifre], [Mail], [Telefon]) VALUES (1, N'Kübra', N'123', N'kubra@gmail.com', NULL)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAdi], [Sifre], [Mail], [Telefon]) VALUES (2, N'Rükna', N'123', N'ruk@Gmail.com', NULL)
INSERT [dbo].[Kullanici] ([KullaniciNo], [KullaniciAdi], [Sifre], [Mail], [Telefon]) VALUES (3, N'ayşe', N'456', N'ayy', N'55566               ')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[Notlar] ON 

INSERT [dbo].[Notlar] ([Not_Id], [Ders_Id], [OgrenciNo], [Vize], [Final], [Ortalama], [Durum]) VALUES (1, 1, 1, 40, 60, 55, N'Geçti')
INSERT [dbo].[Notlar] ([Not_Id], [Ders_Id], [OgrenciNo], [Vize], [Final], [Ortalama], [Durum]) VALUES (2, 2, 3, 60, 80, 75, N'Geçti')
INSERT [dbo].[Notlar] ([Not_Id], [Ders_Id], [OgrenciNo], [Vize], [Final], [Ortalama], [Durum]) VALUES (3, 3, 5, 40, 40, 40, N'Kaldı')
INSERT [dbo].[Notlar] ([Not_Id], [Ders_Id], [OgrenciNo], [Vize], [Final], [Ortalama], [Durum]) VALUES (4, 4, 1, 55, 20, 35, N'Kaldı')
SET IDENTITY_INSERT [dbo].[Notlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 

INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (1, N'Tuncay', N'Şahin', 1)
INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (2, N'Özge', N'Şen', 2)
INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (3, N'Nesrin', N'Uçmak', 3)
INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (4, N'Kaan', N'Şen', 5)
INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (5, N'Kübra', N'Öz', 4)
INSERT [dbo].[Ogrenciler] ([OgrenciNo], [OgrenciAdi], [OgrenciSoyadi], [Bolum_Id]) VALUES (6, N'Kübra', N'Özuu', 4)
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogretmenler] ON 

INSERT [dbo].[Ogretmenler] ([Ogretmen_Id], [OgretmenAdi], [OgretmenSoyadi], [OgretmenBrans]) VALUES (1, N'Nihal ', N'Öz', N'Bilişim')
INSERT [dbo].[Ogretmenler] ([Ogretmen_Id], [OgretmenAdi], [OgretmenSoyadi], [OgretmenBrans]) VALUES (2, N'Ayşe ', N'Bulut', N'Fizik')
INSERT [dbo].[Ogretmenler] ([Ogretmen_Id], [OgretmenAdi], [OgretmenSoyadi], [OgretmenBrans]) VALUES (3, N'Kübra', N'Şahin', N'Matematik')
INSERT [dbo].[Ogretmenler] ([Ogretmen_Id], [OgretmenAdi], [OgretmenSoyadi], [OgretmenBrans]) VALUES (4, N'Rükna', N'Kavraş', N'Bilişim')
INSERT [dbo].[Ogretmenler] ([Ogretmen_Id], [OgretmenAdi], [OgretmenSoyadi], [OgretmenBrans]) VALUES (5, N'Tuncay ', N'Şahin', N'Edebiyat')
SET IDENTITY_INSERT [dbo].[Ogretmenler] OFF
GO
/****** Object:  StoredProcedure [dbo].[BolumAra]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BolumAra]
@BolumAdi varchar(50)
as begin 
select * from Bolumler where BolumAdi=@BolumAdi
end
GO
/****** Object:  StoredProcedure [dbo].[BolumEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BolumEkle](
@BolumAdi varchar(50),
@OgrenciSayisi int )
as begin
insert into Bolumler(BolumAdi,OgrenciSayisi)VALUES(@BolumAdi,@OgrenciSayisi)
end
GO
/****** Object:  StoredProcedure [dbo].[BolumGuncelle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BolumGuncelle]
@Bolum_Id int,@BolumAdi varchar(50),@OgrenciSayisi int
as begin update 
Bolumler set BolumAdi=@BolumAdi,OgrenciSayisi=@OgrenciSayisi where Bolum_Id=@Bolum_Id
END
GO
/****** Object:  StoredProcedure [dbo].[BolumListele]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BolumListele]
as
begin
select * from Bolumler
end
GO
/****** Object:  StoredProcedure [dbo].[BolumSil]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BolumSil]
@Bolum_Id int as begin 
delete from Bolumler where Bolum_Id=@Bolum_Id
end
GO
/****** Object:  StoredProcedure [dbo].[DersAra]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DersAra]
@DersAdi varchar(50)
as begin 
select * from Dersler where DersAdi=@DersAdi
end
GO
/****** Object:  StoredProcedure [dbo].[DersEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DersEkle](
@DersAdi varchar(50),
@Ogretmen_Id int
)
as begin
insert into Dersler(DersAdi,Ogretmen_Id) values(@DersAdi,@Ogretmen_Id)
end
GO
/****** Object:  StoredProcedure [dbo].[DersGuncelle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DersGuncelle]
@Ders_Id int,@DersAdi varchar(50),@Ogretmen_Id int
as begin update 
Dersler set DersAdi=@DersAdi,Ogretmen_Id=@Ogretmen_Id where Ders_Id=@Ders_Id
end
GO
/****** Object:  StoredProcedure [dbo].[DersListele]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DersListele]
as begin 
select * from Dersler 
end
GO
/****** Object:  StoredProcedure [dbo].[DersSil]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DersSil]
@Ders_Id int as begin 
delete from Dersler where Ders_Id=@Ders_Id
end
GO
/****** Object:  StoredProcedure [dbo].[KullaniciEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KullaniciEkle](
@KullaniciAdi varchar(50),
@Sifre varchar(50),
@Mail varchar(50),
@Telefon char(20)
)
as begin
insert into Kullanici(KullaniciAdi,Sifre,Mail,Telefon) values (@KullaniciAdi,@Sifre,@Mail,@Telefon) 
end
GO
/****** Object:  StoredProcedure [dbo].[KullaniciGiris]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KullaniciGiris](
@KullaniciAdi varchar(50),
@Sifre varchar(50)
)
as begin select * from Kullanici where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre 
end 
GO
/****** Object:  StoredProcedure [dbo].[NotAra]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NotAra]
@Ders_Id int
as begin 
select * from Notlar where Ders_Id=@Ders_Id
end
GO
/****** Object:  StoredProcedure [dbo].[NotEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NotEkle](
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
GO
/****** Object:  StoredProcedure [dbo].[NotGuncelle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NotGuncelle]
@Not_Id int ,@Ders_Id int ,@OgrenciNo int, @Vize float,@Final float,@Ortalama float,@Durum varchar(50) 
as begin update 
Notlar set Ders_Id=@Ders_Id,OgrenciNo=@OgrenciNo,Vize=@Vize,Final=@Final,Ortalama=@Ortalama,Durum=@Durum where Not_Id=@Not_Id
end
GO
/****** Object:  StoredProcedure [dbo].[NotListele]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NotListele]
as begin 
select * from Notlar
end
GO
/****** Object:  StoredProcedure [dbo].[NotSil]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[NotSil]
@Not_Id int as begin
delete from Notlar where  Not_Id=@Not_Id
end
GO
/****** Object:  StoredProcedure [dbo].[OgrenciAra]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgrenciAra]
@OgrenciAdi varchar(50)
as begin 
select * from Ogrenciler where OgrenciAdi=@OgrenciAdi
end
GO
/****** Object:  StoredProcedure [dbo].[OgrenciEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgrenciEkle](
@OgrenciAdi varchar(50),
@OgrenciSoyadi varchar(50),
@Bolum_Id int
)
 as begin
insert into Ogrenciler(OgrenciAdi,OgrenciSoyadi,Bolum_Id) values (@OgrenciAdi,@OgrenciSoyadi,@Bolum_Id)
end
GO
/****** Object:  StoredProcedure [dbo].[OgrenciGuncelle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[OgrenciGuncelle]
@OgrenciNo int,@OgrenciAdi varchar(50),@OgrenciSoyadi varchar(50),@Bolum_Id int
as begin update 
Ogrenciler set OgrenciAdi=@OgrenciAdi,OgrenciSoyadi=@OgrenciSoyadi,Bolum_Id=@Bolum_Id where OgrenciNo=@OgrenciNo
end
GO
/****** Object:  StoredProcedure [dbo].[OgrenciListele]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgrenciListele]
as begin
select * from Ogrenciler
end
GO
/****** Object:  StoredProcedure [dbo].[OgrenciSil]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgrenciSil]
@OgrenciNo int as begin
delete from Ogrenciler where OgrenciNo=@OgrenciNo
end
GO
/****** Object:  StoredProcedure [dbo].[OgretmenAra]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenAra]
@OgretmenAdi varchar(50)
as begin 
select * from Ogretmenler where OgretmenAdi=@OgretmenAdi
end
GO
/****** Object:  StoredProcedure [dbo].[OgretmenEkle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenEkle](
@OgretmenAdi varchar(50),
@OgretmenSoyadi varchar(50),
@OgretmenBrans varchar(50)
)
 as begin 
insert into Ogretmenler(OgretmenAdi,OgretmenSoyadi,OgretmenBrans) values(@OgretmenAdi,@OgretmenSoyadi,@OgretmenBrans) end
GO
/****** Object:  StoredProcedure [dbo].[OgretmenGuncelle]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenGuncelle]
@Ogretmen_Id int,@OgretmenAdi varchar(50),@OgretmenSoyadi varchar(50),@OgretmenBrans varchar(50)
as begin update
Ogretmenler set OgretmenAdi=@OgretmenAdi,OgretmenSoyadi=@OgretmenSoyadi,OgretmenBrans=@OgretmenBrans where Ogretmen_Id=@Ogretmen_Id
end
GO
/****** Object:  StoredProcedure [dbo].[OgretmenListele]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenListele]
as begin
select * from Ogretmenler end
GO
/****** Object:  StoredProcedure [dbo].[OgretmenSil]    Script Date: 6.07.2022 18:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenSil]
@Ogretmen_Id int as begin
delete from Ogretmenler where Ogretmen_Id=@Ogretmen_Id end
GO
