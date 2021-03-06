USE [master]
GO
/****** Object:  Database [dbQLKho]    Script Date: 2018-06-18 15:29:09 ******/
CREATE DATABASE [dbQLKho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbQLKho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbQLKho.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbQLKho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbQLKho_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbQLKho] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQLKho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbQLKho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbQLKho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbQLKho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbQLKho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbQLKho] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbQLKho] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbQLKho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbQLKho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbQLKho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbQLKho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbQLKho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbQLKho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbQLKho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbQLKho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbQLKho] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbQLKho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbQLKho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbQLKho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbQLKho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbQLKho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbQLKho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbQLKho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbQLKho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbQLKho] SET  MULTI_USER 
GO
ALTER DATABASE [dbQLKho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbQLKho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbQLKho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbQLKho] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbQLKho] SET DELAYED_DURABILITY = DISABLED 
GO
USE [dbQLKho]
GO
/****** Object:  Table [dbo].[CT_XuatKho]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_XuatKho](
	[ID_CT] [int] IDENTITY(1,1) NOT NULL,
	[ID_PhieuXuat] [int] NULL,
	[MaLoHang] [int] NULL,
	[SoLuong] [int] NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_XuatKho] PRIMARY KEY CLUSTERED 
(
	[ID_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoas]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoas](
	[MaHH] [nvarchar](50) NOT NULL,
	[TenHH] [nvarchar](500) NULL,
	[MoTa] [nvarchar](500) NULL,
	[ID_NHH] [nvarchar](50) NULL,
	[IsDelete] [bit] NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_HangHoas] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoHangs]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoHangs](
	[MaLoHang] [int] IDENTITY(1,1) NOT NULL,
	[MaHH] [nvarchar](50) NULL,
	[NSX] [datetime] NULL,
	[HSD] [datetime] NULL,
	[SoLuong] [int] NULL,
	[Status] [int] NULL,
	[ID_NhaKho] [int] NULL,
	[ID_PhieuNhap] [int] NULL,
	[MaNCC] [nvarchar](50) NULL,
	[Tang] [int] NULL,
	[Hang] [int] NULL,
	[Cot] [int] NULL,
 CONSTRAINT [PK_LoHangs] PRIMARY KEY CLUSTERED 
(
	[MaLoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCaps]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCaps](
	[MaNCC] [nvarchar](50) NOT NULL,
	[TenNCC] [nvarchar](500) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[SDT] [nvarchar](500) NULL,
	[Web] [nvarchar](500) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_NhaCungCaps] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaKhoes]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaKhoes](
	[ID_NhaKho] [int] IDENTITY(1,1) NOT NULL,
	[SoTang] [int] NULL,
	[SoHang] [int] NULL,
	[SoCot] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaKhoes] PRIMARY KEY CLUSTERED 
(
	[ID_NhaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanViens]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanViens](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[PB] [nvarchar](50) NULL,
	[CV] [nvarchar](50) NULL,
	[MT] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_NhanViens] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomHangHoas]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHangHoas](
	[ID_NHH] [nvarchar](50) NOT NULL,
	[TenNHH] [nvarchar](500) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_NhomHangHoas] PRIMARY KEY CLUSTERED 
(
	[ID_NHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuNhaps]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhaps](
	[ID_PhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [datetime] NULL,
	[ID_NhanVien] [nvarchar](50) NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuNhaps] PRIMARY KEY CLUSTERED 
(
	[ID_PhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuats]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuats](
	[ID_PhieuXuat] [int] IDENTITY(1,1) NOT NULL,
	[ID_NhanVien] [nvarchar](50) NULL,
	[ThoiGian] [datetime] NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuXuats] PRIMARY KEY CLUSTERED 
(
	[ID_PhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VitriSuas]    Script Date: 2018-06-18 15:29:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VitriSuas](
	[ID_ViTri] [int] IDENTITY(1,1) NOT NULL,
	[ID_NhaKho] [int] NULL,
	[Tang] [int] NULL,
	[Hang] [int] NULL,
	[Cot] [int] NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_VitriSuas] PRIMARY KEY CLUSTERED 
(
	[ID_ViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CT_XuatKho] ON 

INSERT [dbo].[CT_XuatKho] ([ID_CT], [ID_PhieuXuat], [MaLoHang], [SoLuong], [Note]) VALUES (1, 3, 2, 1, N'')
INSERT [dbo].[CT_XuatKho] ([ID_CT], [ID_PhieuXuat], [MaLoHang], [SoLuong], [Note]) VALUES (2, 3, 4, 1, N'')
INSERT [dbo].[CT_XuatKho] ([ID_CT], [ID_PhieuXuat], [MaLoHang], [SoLuong], [Note]) VALUES (3, 4, 6, 996, NULL)
INSERT [dbo].[CT_XuatKho] ([ID_CT], [ID_PhieuXuat], [MaLoHang], [SoLuong], [Note]) VALUES (4, 5, 2, 500, NULL)
INSERT [dbo].[CT_XuatKho] ([ID_CT], [ID_PhieuXuat], [MaLoHang], [SoLuong], [Note]) VALUES (5, 6, 2, 499, NULL)
SET IDENTITY_INSERT [dbo].[CT_XuatKho] OFF
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'002', N'SỮA', NULL, N'002', 0, 7199)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'003', N'COCACOLA', NULL, N'003', 0, 0)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'007', N'bcs', NULL, N'diepvien', 0, 5000)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'1996', N'Quần áo quảng châu', NULL, N'1996', 0, 1000)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'STING', N'STING Đỏ', NULL, N'NUOC', 0, 0)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'THỰC PHẨM', N'BIM BIM', NULL, N'THỰC PHẨM', 0, NULL)
INSERT [dbo].[HangHoas] ([MaHH], [TenHH], [MoTa], [ID_NHH], [IsDelete], [SoLuongTon]) VALUES (N'VINA', N'Vina mềm', NULL, N'THUOC', 0, 123)
SET IDENTITY_INSERT [dbo].[LoHangs] ON 

INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (1, N'VINA', CAST(N'2018-03-30 00:00:00.000' AS DateTime), CAST(N'2018-03-17 00:00:00.000' AS DateTime), 123, 1, 1, 1, N'VINA', 3, 4, 1)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (2, N'STING', CAST(N'2018-04-12 00:00:00.000' AS DateTime), CAST(N'2018-04-28 00:00:00.000' AS DateTime), 0, 0, 1, 2, N'NUOC', 1, 1, 1)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (3, N'THỰC PHẨM', CAST(N'2018-04-05 00:00:00.000' AS DateTime), CAST(N'2018-04-20 00:00:00.000' AS DateTime), 4000, 1, 1, 3, N'NUOC', 1, 2, 1)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (4, N'002', CAST(N'2018-04-13 00:00:00.000' AS DateTime), CAST(N'2018-04-20 00:00:00.000' AS DateTime), 2199, 1, 1, 4, N'NUOC', 1, 1, 2)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (5, N'007', CAST(N'2018-06-18 00:00:00.000' AS DateTime), CAST(N'2020-12-30 00:00:00.000' AS DateTime), 5000, 1, 1, 5, N'diepvien', 1, 3, 2)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (6, N'1996', CAST(N'2018-03-03 00:00:00.000' AS DateTime), CAST(N'2019-04-07 00:00:00.000' AS DateTime), 1000, 1, 1, 6, N'1996', 2, 1, 1)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (7, N'THỰC PHẨM', CAST(N'2018-02-23 00:00:00.000' AS DateTime), CAST(N'2023-12-31 00:00:00.000' AS DateTime), 60000, 1, 1, 7, N'O''STAR', 2, 2, 2)
INSERT [dbo].[LoHangs] ([MaLoHang], [MaHH], [NSX], [HSD], [SoLuong], [Status], [ID_NhaKho], [ID_PhieuNhap], [MaNCC], [Tang], [Hang], [Cot]) VALUES (8, N'002', CAST(N'2018-06-13 00:00:00.000' AS DateTime), CAST(N'2019-02-05 00:00:00.000' AS DateTime), 5000, 1, 1, 8, N'NUOC', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[LoHangs] OFF
INSERT [dbo].[NhaCungCaps] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Web], [IsDelete]) VALUES (N'1996', N'Quảng Châu', N'TQ', N'12345678901', NULL, 0)
INSERT [dbo].[NhaCungCaps] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Web], [IsDelete]) VALUES (N'diepvien', N'diepvien', N'english', N'0923423489', NULL, 0)
INSERT [dbo].[NhaCungCaps] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Web], [IsDelete]) VALUES (N'NUOC', N'NƯỚC UỐNG VIỆT NAM', N'SG', N'0987423322', NULL, 0)
INSERT [dbo].[NhaCungCaps] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Web], [IsDelete]) VALUES (N'O''STAR', N'O''STAR', N'TPHCM', N'0983232455', NULL, 0)
INSERT [dbo].[NhaCungCaps] ([MaNCC], [TenNCC], [DiaChi], [SDT], [Web], [IsDelete]) VALUES (N'VINA', N'VINATABA', N'HN', N'0987654321', N'vinataba.com', 0)
SET IDENTITY_INSERT [dbo].[NhaKhoes] ON 

INSERT [dbo].[NhaKhoes] ([ID_NhaKho], [SoTang], [SoHang], [SoCot], [Status]) VALUES (1, 3, 4, 3, N'SanSang')
SET IDENTITY_INSERT [dbo].[NhaKhoes] OFF
INSERT [dbo].[NhanViens] ([MaNV], [TenNV], [PB], [CV], [MT], [MatKhau], [IsDelete]) VALUES (N'001', N'QUYẾT', N'QUẢN LÝ', N'QuanLy', N'ÁD', N'admin', 0)
INSERT [dbo].[NhanViens] ([MaNV], [TenNV], [PB], [CV], [MT], [MatKhau], [IsDelete]) VALUES (N'admin', N'1', N'1', N'QuanLy', N'1', N'admin', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'002', N'002', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'003', N'003', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'1996', N'Quần Áo', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'diepvien', N'diepvien', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'NUOC', N'Nước', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'THỰC PHẨM', N'THỰC PHẨM', 0)
INSERT [dbo].[NhomHangHoas] ([ID_NHH], [TenNHH], [IsDelete]) VALUES (N'THUOC', N'Thuốc lá', 0)
SET IDENTITY_INSERT [dbo].[PhieuNhaps] ON 

INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (1, CAST(N'2018-04-05 09:54:09.327' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (2, CAST(N'2018-04-05 10:00:05.400' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (3, CAST(N'2018-04-05 10:45:14.223' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (4, CAST(N'2018-04-05 10:53:17.237' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (5, CAST(N'2018-06-18 09:48:11.807' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (6, CAST(N'2018-06-18 09:55:10.807' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (7, CAST(N'2018-06-18 10:01:09.420' AS DateTime), N'admin', N'')
INSERT [dbo].[PhieuNhaps] ([ID_PhieuNhap], [ThoiGian], [ID_NhanVien], [Note]) VALUES (8, CAST(N'2018-06-18 10:35:33.687' AS DateTime), N'admin', N'')
SET IDENTITY_INSERT [dbo].[PhieuNhaps] OFF
SET IDENTITY_INSERT [dbo].[PhieuXuats] ON 

INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (1, N'admin', CAST(N'2018-04-05 10:00:25.827' AS DateTime), N'')
INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (2, N'admin', CAST(N'2018-04-05 10:53:54.067' AS DateTime), N'')
INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (3, N'admin', CAST(N'2018-04-16 18:44:06.540' AS DateTime), N'')
INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (4, N'admin', CAST(N'2018-06-18 10:02:19.757' AS DateTime), N'')
INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (5, N'admin', CAST(N'2018-06-18 10:33:37.797' AS DateTime), N'')
INSERT [dbo].[PhieuXuats] ([ID_PhieuXuat], [ID_NhanVien], [ThoiGian], [Note]) VALUES (6, N'admin', CAST(N'2018-06-18 10:34:39.550' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[PhieuXuats] OFF
/****** Object:  Index [IX_FK_CT_XuatKho_LoHang]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CT_XuatKho_LoHang] ON [dbo].[CT_XuatKho]
(
	[MaLoHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CT_XuatKho_PhieuXuat]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CT_XuatKho_PhieuXuat] ON [dbo].[CT_XuatKho]
(
	[ID_PhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_HangHoa_NhomHangHoa]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_HangHoa_NhomHangHoa] ON [dbo].[HangHoas]
(
	[ID_NHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_LoHang_HangHoa]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LoHang_HangHoa] ON [dbo].[LoHangs]
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_LoHang_NhaCungCap]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LoHang_NhaCungCap] ON [dbo].[LoHangs]
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LoHang_NhaKho]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LoHang_NhaKho] ON [dbo].[LoHangs]
(
	[ID_NhaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_LoHang_PhieuNhap]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_LoHang_PhieuNhap] ON [dbo].[LoHangs]
(
	[ID_PhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_PhieuNhap_NhanVien]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_PhieuNhap_NhanVien] ON [dbo].[PhieuNhaps]
(
	[ID_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_FK_PhieuXuat_NhanVien]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_PhieuXuat_NhanVien] ON [dbo].[PhieuXuats]
(
	[ID_NhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_VitriSua_NhaKho]    Script Date: 2018-06-18 15:29:09 ******/
CREATE NONCLUSTERED INDEX [IX_FK_VitriSua_NhaKho] ON [dbo].[VitriSuas]
(
	[ID_NhaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_XuatKho]  WITH CHECK ADD  CONSTRAINT [FK_CT_XuatKho_LoHang] FOREIGN KEY([MaLoHang])
REFERENCES [dbo].[LoHangs] ([MaLoHang])
GO
ALTER TABLE [dbo].[CT_XuatKho] CHECK CONSTRAINT [FK_CT_XuatKho_LoHang]
GO
ALTER TABLE [dbo].[CT_XuatKho]  WITH CHECK ADD  CONSTRAINT [FK_CT_XuatKho_PhieuXuat] FOREIGN KEY([ID_PhieuXuat])
REFERENCES [dbo].[PhieuXuats] ([ID_PhieuXuat])
GO
ALTER TABLE [dbo].[CT_XuatKho] CHECK CONSTRAINT [FK_CT_XuatKho_PhieuXuat]
GO
ALTER TABLE [dbo].[HangHoas]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHangHoa] FOREIGN KEY([ID_NHH])
REFERENCES [dbo].[NhomHangHoas] ([ID_NHH])
GO
ALTER TABLE [dbo].[HangHoas] CHECK CONSTRAINT [FK_HangHoa_NhomHangHoa]
GO
ALTER TABLE [dbo].[LoHangs]  WITH CHECK ADD  CONSTRAINT [FK_LoHang_HangHoa] FOREIGN KEY([MaHH])
REFERENCES [dbo].[HangHoas] ([MaHH])
GO
ALTER TABLE [dbo].[LoHangs] CHECK CONSTRAINT [FK_LoHang_HangHoa]
GO
ALTER TABLE [dbo].[LoHangs]  WITH CHECK ADD  CONSTRAINT [FK_LoHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCaps] ([MaNCC])
GO
ALTER TABLE [dbo].[LoHangs] CHECK CONSTRAINT [FK_LoHang_NhaCungCap]
GO
ALTER TABLE [dbo].[LoHangs]  WITH CHECK ADD  CONSTRAINT [FK_LoHang_NhaKho] FOREIGN KEY([ID_NhaKho])
REFERENCES [dbo].[NhaKhoes] ([ID_NhaKho])
GO
ALTER TABLE [dbo].[LoHangs] CHECK CONSTRAINT [FK_LoHang_NhaKho]
GO
ALTER TABLE [dbo].[LoHangs]  WITH CHECK ADD  CONSTRAINT [FK_LoHang_PhieuNhap] FOREIGN KEY([ID_PhieuNhap])
REFERENCES [dbo].[PhieuNhaps] ([ID_PhieuNhap])
GO
ALTER TABLE [dbo].[LoHangs] CHECK CONSTRAINT [FK_LoHang_PhieuNhap]
GO
ALTER TABLE [dbo].[PhieuNhaps]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanViens] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhaps] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuXuats]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuat_NhanVien] FOREIGN KEY([ID_NhanVien])
REFERENCES [dbo].[NhanViens] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuats] CHECK CONSTRAINT [FK_PhieuXuat_NhanVien]
GO
ALTER TABLE [dbo].[VitriSuas]  WITH CHECK ADD  CONSTRAINT [FK_VitriSua_NhaKho] FOREIGN KEY([ID_NhaKho])
REFERENCES [dbo].[NhaKhoes] ([ID_NhaKho])
GO
ALTER TABLE [dbo].[VitriSuas] CHECK CONSTRAINT [FK_VitriSua_NhaKho]
GO
USE [master]
GO
ALTER DATABASE [dbQLKho] SET  READ_WRITE 
GO
