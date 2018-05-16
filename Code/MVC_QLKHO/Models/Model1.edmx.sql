
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/05/2018 09:39:44
-- Generated from EDMX file: D:\FLANCER\C#\WEB\MVC_QLKHO\MVC_QLKHO\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dbQLKho];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CT_XuatKho_LoHang]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_XuatKho] DROP CONSTRAINT [FK_CT_XuatKho_LoHang];
GO
IF OBJECT_ID(N'[dbo].[FK_CT_XuatKho_PhieuXuat]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CT_XuatKho] DROP CONSTRAINT [FK_CT_XuatKho_PhieuXuat];
GO
IF OBJECT_ID(N'[dbo].[FK_HangHoa_NhomHangHoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HangHoa] DROP CONSTRAINT [FK_HangHoa_NhomHangHoa];
GO
IF OBJECT_ID(N'[dbo].[FK_LoHang_HangHoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoHang] DROP CONSTRAINT [FK_LoHang_HangHoa];
GO
IF OBJECT_ID(N'[dbo].[FK_LoHang_NhaCungCap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoHang] DROP CONSTRAINT [FK_LoHang_NhaCungCap];
GO
IF OBJECT_ID(N'[dbo].[FK_LoHang_NhaKho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoHang] DROP CONSTRAINT [FK_LoHang_NhaKho];
GO
IF OBJECT_ID(N'[dbo].[FK_LoHang_PhieuNhap]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LoHang] DROP CONSTRAINT [FK_LoHang_PhieuNhap];
GO
IF OBJECT_ID(N'[dbo].[FK_PhieuNhap_NhanVien]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhieuNhap] DROP CONSTRAINT [FK_PhieuNhap_NhanVien];
GO
IF OBJECT_ID(N'[dbo].[FK_PhieuXuat_NhanVien]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhieuXuat] DROP CONSTRAINT [FK_PhieuXuat_NhanVien];
GO
IF OBJECT_ID(N'[dbo].[FK_VitriSua_NhaKho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VitriSua] DROP CONSTRAINT [FK_VitriSua_NhaKho];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CT_XuatKho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CT_XuatKho];
GO
IF OBJECT_ID(N'[dbo].[HangHoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HangHoa];
GO
IF OBJECT_ID(N'[dbo].[LoHang]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LoHang];
GO
IF OBJECT_ID(N'[dbo].[NhaCungCap]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhaCungCap];
GO
IF OBJECT_ID(N'[dbo].[NhaKho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhaKho];
GO
IF OBJECT_ID(N'[dbo].[NhanVien]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhanVien];
GO
IF OBJECT_ID(N'[dbo].[NhomHangHoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NhomHangHoa];
GO
IF OBJECT_ID(N'[dbo].[PhieuNhap]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhieuNhap];
GO
IF OBJECT_ID(N'[dbo].[PhieuXuat]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhieuXuat];
GO
IF OBJECT_ID(N'[dbo].[VitriSua]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VitriSua];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CT_XuatKho'
CREATE TABLE [dbo].[CT_XuatKho] (
    [ID_CT] int IDENTITY(1,1) NOT NULL,
    [ID_PhieuXuat] int  NULL,
    [MaLoHang] int  NULL,
    [SoLuong] int  NULL,
    [Note] nvarchar(50)  NULL
);
GO

-- Creating table 'HangHoas'
CREATE TABLE [dbo].[HangHoas] (
    [MaHH] nvarchar(50)  NOT NULL,
    [TenHH] nvarchar(500)  NULL,
    [MoTa] nvarchar(500)  NULL,
    [ID_NHH] nvarchar(50)  NULL,
    [IsDelete] bit  NULL,
    [SoLuongTon] int  NULL
);
GO

-- Creating table 'LoHangs'
CREATE TABLE [dbo].[LoHangs] (
    [MaLoHang] int IDENTITY(1,1) NOT NULL,
    [MaHH] nvarchar(50)  NULL,
    [NSX] datetime  NULL,
    [HSD] datetime  NULL,
    [SoLuong] int  NULL,
    [Status] int  NULL,
    [ID_NhaKho] int  NULL,
    [ID_PhieuNhap] int  NULL,
    [MaNCC] nvarchar(50)  NULL,
    [Tang] int  NULL,
    [Hang] int  NULL,
    [Cot] int  NULL
);
GO

-- Creating table 'NhaCungCaps'
CREATE TABLE [dbo].[NhaCungCaps] (
    [MaNCC] nvarchar(50)  NOT NULL,
    [TenNCC] nvarchar(500)  NULL,
    [DiaChi] nvarchar(500)  NULL,
    [SDT] nvarchar(500)  NULL,
    [Web] nvarchar(500)  NULL,
    [IsDelete] bit  NULL
);
GO

-- Creating table 'NhaKhoes'
CREATE TABLE [dbo].[NhaKhoes] (
    [ID_NhaKho] int IDENTITY(1,1) NOT NULL,
    [SoTang] int  NULL,
    [SoHang] int  NULL,
    [SoCot] int  NULL,
    [Status] nvarchar(50)  NULL
);
GO

-- Creating table 'NhanViens'
CREATE TABLE [dbo].[NhanViens] (
    [MaNV] nvarchar(50)  NOT NULL,
    [TenNV] nvarchar(50)  NULL,
    [PB] nvarchar(50)  NULL,
    [CV] nvarchar(50)  NULL,
    [MT] nvarchar(50)  NULL,
    [MatKhau] nvarchar(50)  NULL,
    [IsDelete] bit  NULL
);
GO

-- Creating table 'NhomHangHoas'
CREATE TABLE [dbo].[NhomHangHoas] (
    [ID_NHH] nvarchar(50)  NOT NULL,
    [TenNHH] nvarchar(500)  NULL,
    [IsDelete] bit  NULL
);
GO

-- Creating table 'PhieuNhaps'
CREATE TABLE [dbo].[PhieuNhaps] (
    [ID_PhieuNhap] int IDENTITY(1,1) NOT NULL,
    [ThoiGian] datetime  NULL,
    [ID_NhanVien] nvarchar(50)  NULL,
    [Note] nvarchar(50)  NULL
);
GO

-- Creating table 'PhieuXuats'
CREATE TABLE [dbo].[PhieuXuats] (
    [ID_PhieuXuat] int IDENTITY(1,1) NOT NULL,
    [ID_NhanVien] nvarchar(50)  NULL,
    [ThoiGian] datetime  NULL,
    [Note] nvarchar(50)  NULL
);
GO

-- Creating table 'VitriSuas'
CREATE TABLE [dbo].[VitriSuas] (
    [ID_ViTri] int IDENTITY(1,1) NOT NULL,
    [ID_NhaKho] int  NULL,
    [Tang] int  NULL,
    [Hang] int  NULL,
    [Cot] int  NULL,
    [Note] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_CT] in table 'CT_XuatKho'
ALTER TABLE [dbo].[CT_XuatKho]
ADD CONSTRAINT [PK_CT_XuatKho]
    PRIMARY KEY CLUSTERED ([ID_CT] ASC);
GO

-- Creating primary key on [MaHH] in table 'HangHoas'
ALTER TABLE [dbo].[HangHoas]
ADD CONSTRAINT [PK_HangHoas]
    PRIMARY KEY CLUSTERED ([MaHH] ASC);
GO

-- Creating primary key on [MaLoHang] in table 'LoHangs'
ALTER TABLE [dbo].[LoHangs]
ADD CONSTRAINT [PK_LoHangs]
    PRIMARY KEY CLUSTERED ([MaLoHang] ASC);
GO

-- Creating primary key on [MaNCC] in table 'NhaCungCaps'
ALTER TABLE [dbo].[NhaCungCaps]
ADD CONSTRAINT [PK_NhaCungCaps]
    PRIMARY KEY CLUSTERED ([MaNCC] ASC);
GO

-- Creating primary key on [ID_NhaKho] in table 'NhaKhoes'
ALTER TABLE [dbo].[NhaKhoes]
ADD CONSTRAINT [PK_NhaKhoes]
    PRIMARY KEY CLUSTERED ([ID_NhaKho] ASC);
GO

-- Creating primary key on [MaNV] in table 'NhanViens'
ALTER TABLE [dbo].[NhanViens]
ADD CONSTRAINT [PK_NhanViens]
    PRIMARY KEY CLUSTERED ([MaNV] ASC);
GO

-- Creating primary key on [ID_NHH] in table 'NhomHangHoas'
ALTER TABLE [dbo].[NhomHangHoas]
ADD CONSTRAINT [PK_NhomHangHoas]
    PRIMARY KEY CLUSTERED ([ID_NHH] ASC);
GO

-- Creating primary key on [ID_PhieuNhap] in table 'PhieuNhaps'
ALTER TABLE [dbo].[PhieuNhaps]
ADD CONSTRAINT [PK_PhieuNhaps]
    PRIMARY KEY CLUSTERED ([ID_PhieuNhap] ASC);
GO

-- Creating primary key on [ID_PhieuXuat] in table 'PhieuXuats'
ALTER TABLE [dbo].[PhieuXuats]
ADD CONSTRAINT [PK_PhieuXuats]
    PRIMARY KEY CLUSTERED ([ID_PhieuXuat] ASC);
GO

-- Creating primary key on [ID_ViTri] in table 'VitriSuas'
ALTER TABLE [dbo].[VitriSuas]
ADD CONSTRAINT [PK_VitriSuas]
    PRIMARY KEY CLUSTERED ([ID_ViTri] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaLoHang] in table 'CT_XuatKho'
ALTER TABLE [dbo].[CT_XuatKho]
ADD CONSTRAINT [FK_CT_XuatKho_LoHang]
    FOREIGN KEY ([MaLoHang])
    REFERENCES [dbo].[LoHangs]
        ([MaLoHang])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CT_XuatKho_LoHang'
CREATE INDEX [IX_FK_CT_XuatKho_LoHang]
ON [dbo].[CT_XuatKho]
    ([MaLoHang]);
GO

-- Creating foreign key on [ID_PhieuXuat] in table 'CT_XuatKho'
ALTER TABLE [dbo].[CT_XuatKho]
ADD CONSTRAINT [FK_CT_XuatKho_PhieuXuat]
    FOREIGN KEY ([ID_PhieuXuat])
    REFERENCES [dbo].[PhieuXuats]
        ([ID_PhieuXuat])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CT_XuatKho_PhieuXuat'
CREATE INDEX [IX_FK_CT_XuatKho_PhieuXuat]
ON [dbo].[CT_XuatKho]
    ([ID_PhieuXuat]);
GO

-- Creating foreign key on [ID_NHH] in table 'HangHoas'
ALTER TABLE [dbo].[HangHoas]
ADD CONSTRAINT [FK_HangHoa_NhomHangHoa]
    FOREIGN KEY ([ID_NHH])
    REFERENCES [dbo].[NhomHangHoas]
        ([ID_NHH])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HangHoa_NhomHangHoa'
CREATE INDEX [IX_FK_HangHoa_NhomHangHoa]
ON [dbo].[HangHoas]
    ([ID_NHH]);
GO

-- Creating foreign key on [MaHH] in table 'LoHangs'
ALTER TABLE [dbo].[LoHangs]
ADD CONSTRAINT [FK_LoHang_HangHoa]
    FOREIGN KEY ([MaHH])
    REFERENCES [dbo].[HangHoas]
        ([MaHH])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoHang_HangHoa'
CREATE INDEX [IX_FK_LoHang_HangHoa]
ON [dbo].[LoHangs]
    ([MaHH]);
GO

-- Creating foreign key on [MaNCC] in table 'LoHangs'
ALTER TABLE [dbo].[LoHangs]
ADD CONSTRAINT [FK_LoHang_NhaCungCap]
    FOREIGN KEY ([MaNCC])
    REFERENCES [dbo].[NhaCungCaps]
        ([MaNCC])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoHang_NhaCungCap'
CREATE INDEX [IX_FK_LoHang_NhaCungCap]
ON [dbo].[LoHangs]
    ([MaNCC]);
GO

-- Creating foreign key on [ID_NhaKho] in table 'LoHangs'
ALTER TABLE [dbo].[LoHangs]
ADD CONSTRAINT [FK_LoHang_NhaKho]
    FOREIGN KEY ([ID_NhaKho])
    REFERENCES [dbo].[NhaKhoes]
        ([ID_NhaKho])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoHang_NhaKho'
CREATE INDEX [IX_FK_LoHang_NhaKho]
ON [dbo].[LoHangs]
    ([ID_NhaKho]);
GO

-- Creating foreign key on [ID_PhieuNhap] in table 'LoHangs'
ALTER TABLE [dbo].[LoHangs]
ADD CONSTRAINT [FK_LoHang_PhieuNhap]
    FOREIGN KEY ([ID_PhieuNhap])
    REFERENCES [dbo].[PhieuNhaps]
        ([ID_PhieuNhap])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoHang_PhieuNhap'
CREATE INDEX [IX_FK_LoHang_PhieuNhap]
ON [dbo].[LoHangs]
    ([ID_PhieuNhap]);
GO

-- Creating foreign key on [ID_NhaKho] in table 'VitriSuas'
ALTER TABLE [dbo].[VitriSuas]
ADD CONSTRAINT [FK_VitriSua_NhaKho]
    FOREIGN KEY ([ID_NhaKho])
    REFERENCES [dbo].[NhaKhoes]
        ([ID_NhaKho])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VitriSua_NhaKho'
CREATE INDEX [IX_FK_VitriSua_NhaKho]
ON [dbo].[VitriSuas]
    ([ID_NhaKho]);
GO

-- Creating foreign key on [ID_NhanVien] in table 'PhieuNhaps'
ALTER TABLE [dbo].[PhieuNhaps]
ADD CONSTRAINT [FK_PhieuNhap_NhanVien]
    FOREIGN KEY ([ID_NhanVien])
    REFERENCES [dbo].[NhanViens]
        ([MaNV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhieuNhap_NhanVien'
CREATE INDEX [IX_FK_PhieuNhap_NhanVien]
ON [dbo].[PhieuNhaps]
    ([ID_NhanVien]);
GO

-- Creating foreign key on [ID_NhanVien] in table 'PhieuXuats'
ALTER TABLE [dbo].[PhieuXuats]
ADD CONSTRAINT [FK_PhieuXuat_NhanVien]
    FOREIGN KEY ([ID_NhanVien])
    REFERENCES [dbo].[NhanViens]
        ([MaNV])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhieuXuat_NhanVien'
CREATE INDEX [IX_FK_PhieuXuat_NhanVien]
ON [dbo].[PhieuXuats]
    ([ID_NhanVien]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------