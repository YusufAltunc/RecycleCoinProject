USE [master]
GO
/****** Object:  Database [RecycleCoin]    Script Date: 27.02.2023 00:28:31 ******/
CREATE DATABASE [RecycleCoin]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RecycleCoin', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RecycleCoin.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RecycleCoin_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RecycleCoin_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RecycleCoin] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RecycleCoin].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RecycleCoin] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RecycleCoin] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RecycleCoin] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RecycleCoin] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RecycleCoin] SET ARITHABORT OFF 
GO
ALTER DATABASE [RecycleCoin] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RecycleCoin] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RecycleCoin] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RecycleCoin] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RecycleCoin] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RecycleCoin] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RecycleCoin] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RecycleCoin] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RecycleCoin] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RecycleCoin] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RecycleCoin] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RecycleCoin] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RecycleCoin] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RecycleCoin] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RecycleCoin] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RecycleCoin] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RecycleCoin] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RecycleCoin] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RecycleCoin] SET  MULTI_USER 
GO
ALTER DATABASE [RecycleCoin] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RecycleCoin] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RecycleCoin] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RecycleCoin] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RecycleCoin] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RecycleCoin]
GO
/****** Object:  Table [dbo].[MusteriTbl]    Script Date: 27.02.2023 00:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MusteriTbl](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](15) NULL,
	[Soyad] [varchar](15) NULL,
	[TC] [char](11) NULL,
	[Sifre] [varchar](10) NULL,
	[SHA256] [varchar](100) NULL,
	[BeforeSHA256] [varchar](100) NULL,
	[CarbonDegeri] [float] NULL,
	[CoinDegeri] [float] NULL,
 CONSTRAINT [PK_MusteriTbl] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NesnelerTbl]    Script Date: 27.02.2023 00:28:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NesnelerTbl](
	[NesneID] [smallint] IDENTITY(1,1) NOT NULL,
	[NesneAd] [varchar](50) NULL,
	[NesneDegeri] [int] NULL,
 CONSTRAINT [PK_NesnelerTbl] PRIMARY KEY CLUSTERED 
(
	[NesneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[MusteriTbl] ON 

INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (1, N'yusuf', N'altunc', N'12345678912', N'1234', N'cEPeVNzkPyfEDs1QWAzM312eYQ9DRHVK7IOEZJOcSro=', NULL, 8500, 117998.2)
INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (2, N'mahir ', N'yasar', N'11111111111', N'1111', N'AA7ABD0B06C12087C08A420449EBE218B8057B4BF8212D8931FEC1033E534046', N'cEPeVNzkPyfEDs1QWAzM312eYQ9DRHVK7IOEZJOcSro=', 0, 4901.1)
INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (3, N'hamza', N'oksuz', N'33333333333', N'3333', N'wiH/eAj8g6McH1Rn5S+XxQi6bIyjnyas7ciErC4kB1I=', N'AA7ABD0B06C12087C08A420449EBE218B8057B4BF8212D8931FEC1033E534046', 900, 4663.12)
INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (4, N'alper', N'polat', N'77777777777', N'7777', N'OK+o7pAnbKbZttTfRHhWh9gpUDX9aPYowZcuXzTMcY8=', N'wiH/eAj8g6McH1Rn5S+XxQi6bIyjnyas7ciErC4kB1I=', 500, 5000)
INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (5, N'derya', N'tunc', N'99999999999', N'9999', N'YvDc/tyZ3RBwyO4FddKZ4Ygt1/xbEJkW1/Udml+VX+o=', N'OK+o7pAnbKbZttTfRHhWh9gpUDX9aPYowZcuXzTMcY8=', 0, 0)
INSERT [dbo].[MusteriTbl] ([Id], [Ad], [Soyad], [TC], [Sifre], [SHA256], [BeforeSHA256], [CarbonDegeri], [CoinDegeri]) VALUES (6, N'kadir', N'dıncer', N'88888888888', N'8888', N'HKEWSk645VoqA9C3pAM3o5ZywjcTmxCDeqmJKkOe42c=', N'YvDc/tyZ3RBwyO4FddKZ4Ygt1/xbEJkW1/Udml+VX+o=', 0, 0)
SET IDENTITY_INSERT [dbo].[MusteriTbl] OFF
SET IDENTITY_INSERT [dbo].[NesnelerTbl] ON 

INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (1, N'0,5 Litre pet şişe', 100)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (2, N'1,5 Litre pet şişe', 200)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (3, N'2,5 Litre pet şişe', 400)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (4, N'0,33 Aleminium kola kutusu', 500)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (5, N'1 Gazete', 100)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (6, N'0,5 Litre cam şişe', 300)
INSERT [dbo].[NesnelerTbl] ([NesneID], [NesneAd], [NesneDegeri]) VALUES (7, N'1,5 Litre cam şişe', 600)
SET IDENTITY_INSERT [dbo].[NesnelerTbl] OFF
USE [master]
GO
ALTER DATABASE [RecycleCoin] SET  READ_WRITE 
GO
