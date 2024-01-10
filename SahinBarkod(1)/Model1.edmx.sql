
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/17/2023 19:54:55
-- Generated from EDMX file: C:\Users\sahin\source\repos\SahinBarkod(1)\SahinBarkod(1)\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Barkod1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Barkod]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Barkod];
GO
IF OBJECT_ID(N'[dbo].[CokluB]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CokluB];
GO
IF OBJECT_ID(N'[dbo].[Hesap]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hesap];
GO
IF OBJECT_ID(N'[dbo].[HızlıUrun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HızlıUrun];
GO
IF OBJECT_ID(N'[dbo].[islem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[islem];
GO
IF OBJECT_ID(N'[dbo].[islemOzet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[islemOzet];
GO
IF OBJECT_ID(N'[dbo].[Kullanici]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kullanici];
GO
IF OBJECT_ID(N'[dbo].[Sabit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sabit];
GO
IF OBJECT_ID(N'[dbo].[Satisid]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Satisid];
GO
IF OBJECT_ID(N'[dbo].[Sbt]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sbt];
GO
IF OBJECT_ID(N'[dbo].[StokHareket]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StokHareket];
GO
IF OBJECT_ID(N'[dbo].[Terazi]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Terazi];
GO
IF OBJECT_ID(N'[dbo].[Urun]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Urun];
GO
IF OBJECT_ID(N'[dbo].[UrunGrup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UrunGrup];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Urun'
CREATE TABLE [dbo].[Urun] (
    [Urunid] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunAd] nvarchar(100)  NULL,
    [Acıklama] nvarchar(100)  NULL,
    [UrunGrup] nvarchar(50)  NULL,
    [AlisFiyat] float  NULL,
    [SatisFiyat] float  NULL,
    [KdvOrani] int  NULL,
    [KdvTutari] float  NULL,
    [Birim] nvarchar(50)  NULL,
    [Miktar] float  NULL,
    [Tarih] datetime  NULL,
    [Kullanci] nvarchar(50)  NULL,
    [SatisFiyat2] float  NULL,
    [SatisFiyat3] float  NULL,
    [SatisFiyat4] float  NULL,
    [SatisFiyat5] float  NULL,
    [Onay] bit  NULL
);
GO

-- Creating table 'Terazi'
CREATE TABLE [dbo].[Terazi] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeraziOnEk] int  NULL
);
GO

-- Creating table 'Satisid'
CREATE TABLE [dbo].[Satisid] (
    [Satisid1] int IDENTITY(1,1) NOT NULL,
    [islemno] int  NULL,
    [Urunad] nvarchar(50)  NULL,
    [Barkod] nvarchar(50)  NULL,
    [Urungrup] nvarchar(50)  NULL,
    [Birim] nvarchar(50)  NULL,
    [Alisfiyat] float  NULL,
    [Satisfiyat] float  NULL,
    [Miktar] float  NULL,
    [Toplam] float  NULL,
    [Kdvtutari] float  NULL,
    [Odemesekli] nvarchar(50)  NULL,
    [İade] bit  NULL,
    [Tarih] datetime  NULL,
    [Kullanici] nvarchar(50)  NULL,
    [Satisfiyat2] float  NULL,
    [Satisfiyat3] float  NULL,
    [Satisfiyat4] float  NULL,
    [Satisfiyat5] float  NULL
);
GO

-- Creating table 'islem'
CREATE TABLE [dbo].[islem] (
    [Id] int  NOT NULL,
    [islemno] int  NULL
);
GO

-- Creating table 'islemOzet'
CREATE TABLE [dbo].[islemOzet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [İslemNo] int  NULL,
    [İade] bit  NULL,
    [OdemeSekli] nvarchar(50)  NULL,
    [Nakit] float  NULL,
    [Kart] float  NULL,
    [Gelir] bit  NULL,
    [Gider] bit  NULL,
    [AlısFiyatToplam] float  NULL,
    [Acıklama] nvarchar(500)  NULL,
    [Tarih] datetime  NULL,
    [Kullanici] nvarchar(50)  NULL
);
GO

-- Creating table 'UrunGrup'
CREATE TABLE [dbo].[UrunGrup] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UrunGrupAd] nvarchar(50)  NULL
);
GO

-- Creating table 'Barkod'
CREATE TABLE [dbo].[Barkod] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkodno] int  NULL
);
GO

-- Creating table 'StokHareket'
CREATE TABLE [dbo].[StokHareket] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [UrunAd] nvarchar(50)  NULL,
    [Birim] nvarchar(50)  NULL,
    [Miktar] float  NULL,
    [UrunGrup] nvarchar(50)  NULL,
    [Kullanici] nvarchar(50)  NULL,
    [Tarih] datetime  NULL
);
GO

-- Creating table 'CokluB'
CREATE TABLE [dbo].[CokluB] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(50)  NULL,
    [Urunid] int  NULL
);
GO

-- Creating table 'Sabit'
CREATE TABLE [dbo].[Sabit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [KartKomisyon] int  NULL,
    [Yazici] bit  NULL,
    [AdSoyad] nvarchar(50)  NULL,
    [Unvan] nvarchar(100)  NULL,
    [Adres] nvarchar(500)  NULL,
    [Telefon] nvarchar(20)  NULL,
    [EPosta] nvarchar(50)  NULL
);
GO

-- Creating table 'Kullanici'
CREATE TABLE [dbo].[Kullanici] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(50)  NULL,
    [Telefon] nchar(20)  NULL,
    [EPosta] nvarchar(50)  NULL,
    [KullaniciAd] nvarchar(50)  NULL,
    [Sifre] nvarchar(50)  NULL,
    [Satis] bit  NULL,
    [Rapor] bit  NULL,
    [Stok] bit  NULL,
    [UrunGiris] bit  NULL,
    [Ayarlar] bit  NULL,
    [FiyatGuncelle] bit  NULL,
    [Yedekleme] bit  NULL
);
GO

-- Creating table 'HızlıUrun'
CREATE TABLE [dbo].[HızlıUrun] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Barkod] nvarchar(20)  NULL,
    [UrunAd] nvarchar(100)  NULL,
    [Fiyat] float  NULL,
    [Resim] nvarchar(100)  NULL,
    [Resim2] varbinary(max)  NULL
);
GO

-- Creating table 'Sbt'
CREATE TABLE [dbo].[Sbt] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Kart] nvarchar(10)  NULL,
    [Yazici] nvarchar(10)  NULL
);
GO

-- Creating table 'Hesap'
CREATE TABLE [dbo].[Hesap] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ekran] nvarchar(max)  NULL,
    [toplam] float  NULL,
    [tarih] datetime  NULL,
    [ayrac] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Urunid] in table 'Urun'
ALTER TABLE [dbo].[Urun]
ADD CONSTRAINT [PK_Urun]
    PRIMARY KEY CLUSTERED ([Urunid] ASC);
GO

-- Creating primary key on [Id] in table 'Terazi'
ALTER TABLE [dbo].[Terazi]
ADD CONSTRAINT [PK_Terazi]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Satisid1] in table 'Satisid'
ALTER TABLE [dbo].[Satisid]
ADD CONSTRAINT [PK_Satisid]
    PRIMARY KEY CLUSTERED ([Satisid1] ASC);
GO

-- Creating primary key on [Id] in table 'islem'
ALTER TABLE [dbo].[islem]
ADD CONSTRAINT [PK_islem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'islemOzet'
ALTER TABLE [dbo].[islemOzet]
ADD CONSTRAINT [PK_islemOzet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UrunGrup'
ALTER TABLE [dbo].[UrunGrup]
ADD CONSTRAINT [PK_UrunGrup]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Barkod'
ALTER TABLE [dbo].[Barkod]
ADD CONSTRAINT [PK_Barkod]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StokHareket'
ALTER TABLE [dbo].[StokHareket]
ADD CONSTRAINT [PK_StokHareket]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CokluB'
ALTER TABLE [dbo].[CokluB]
ADD CONSTRAINT [PK_CokluB]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sabit'
ALTER TABLE [dbo].[Sabit]
ADD CONSTRAINT [PK_Sabit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Kullanici'
ALTER TABLE [dbo].[Kullanici]
ADD CONSTRAINT [PK_Kullanici]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HızlıUrun'
ALTER TABLE [dbo].[HızlıUrun]
ADD CONSTRAINT [PK_HızlıUrun]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sbt'
ALTER TABLE [dbo].[Sbt]
ADD CONSTRAINT [PK_Sbt]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hesap'
ALTER TABLE [dbo].[Hesap]
ADD CONSTRAINT [PK_Hesap]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------