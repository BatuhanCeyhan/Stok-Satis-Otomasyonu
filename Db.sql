USE [Stok_Otomasyonu]
GO
/****** Object:  Table [dbo].[Giris]    Script Date: 9.01.2024 01:23:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giris](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[RolID] [int] NULL,
	[Dogrulama] [nvarchar](50) NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Giris] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satıs]    Script Date: 9.01.2024 01:23:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satıs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NULL,
	[FaturaKodu] [nvarchar](50) NULL,
	[SatisUrunAdi] [nvarchar](50) NULL,
	[SatisUrunFiyati] [decimal](18, 0) NULL,
	[SatisUrunAdedi] [int] NULL,
	[SatısYerleri] [nvarchar](50) NULL,
	[ToplamSatıs] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Satıs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 9.01.2024 01:23:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[UrunFiyati] [decimal](18, 0) NULL,
	[UrunAdedi] [int] NULL,
	[UrunNotu] [nvarchar](50) NULL,
	[Aktif] [nvarchar](50) NULL,
	[Resim] [nvarchar](50) NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
