CREATE DATABASE QLBANHANG
USE [QLBANHANG]
GO
/****** Object:  Table [dbo].[ChiTietHDBH]    Script Date: 02/08/2020 01:52:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDBH](
	[MaHD] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietHDBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPN]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPN](
	[MaPN] [nchar](10) NOT NULL,
	[MaSP] [nchar](10) NOT NULL,
	[SoLuongNhap] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_ChiTietPN] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
	[LuongCB] [float] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonBH]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBH](
	[MaHD] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[NgayLapHD] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HoaDonBH] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiHH]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHH](
	[MaLoaiHH] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiHH] PRIMARY KEY CLUSTERED 
(
	[MaLoaiHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaNV] [nchar](10) NOT NULL,
	[MatKhau] [nchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[MaCV] [nchar](10) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[MaCV] [nchar](10) NOT NULL,
	[NgayVaoLam] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPN] [nchar](10) NOT NULL,
	[MaNCC] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayLapPN] [date] NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 02/08/2020 01:52:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](10) NOT NULL,
	[MaLoai] [nchar](10) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[DonGiaNhap] [float] NULL,
	[DonGiaBan] [float] NULL,
	[SoLuong] [int] NULL,
	[HinhAnh] [varchar](500) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[ThuongHieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO



ALTER TABLE [dbo].[ChiTietHDBH]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDBH_HoaDonBH] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDonBH] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHDBH] CHECK CONSTRAINT [FK_ChiTietHDBH_HoaDonBH]
GO
ALTER TABLE [dbo].[ChiTietHDBH]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDBH_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHDBH] CHECK CONSTRAINT [FK_ChiTietHDBH_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPN]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPN_PhieuNhapHang] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PhieuNhapHang] ([MaPN])
GO
ALTER TABLE [dbo].[ChiTietPN] CHECK CONSTRAINT [FK_ChiTietPN_PhieuNhapHang]
GO
ALTER TABLE [dbo].[ChiTietPN]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPN_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPN] CHECK CONSTRAINT [FK_ChiTietPN_SanPham]
GO
ALTER TABLE [dbo].[HoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBH_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBH] CHECK CONSTRAINT [FK_HoaDonBH_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonBH]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBH_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBH] CHECK CONSTRAINT [FK_HoaDonBH_NhanVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_ChucVu]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiHH] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHH] ([MaLoaiHH])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiHH]
GO
-- CHỨC VỤ
INSERT ChucVu 
VALUES (N'CV01', N'Quản Lý', 10000000),
(N'CV02', N'Nhân Viên Kho', 7000000),
(N'CV03', N'Nhân Viên Bán Hàng', 7500000)

--LOẠI HÀNG
INSERT LoaiHH VALUES (N'L001', N'Áo Khoác Louis Vuitton'),
(N'L002', N'Áo Thun Louis Vuitton'),
(N'L003', N'Áo Sơ Mi Louis Vuitton'),
(N'L004', N'Balo Louis Vuitton'),
(N'L005', N'Giày Khoác Louis Vuitton'),
(N'L006', N'Quần Tây Louis Vuitton'),
(N'L007', N'Túi - Ví Louis Vuitton')


--NHÂN VIÊN
INSERT NhanVien VALUES (N'NV01', N'Ngô Duy Thái', CAST(0xE4230B00 AS Date), N'Nam', N'Tây Ninh', N'0866897152', N'CV01', CAST(0x7C400B00 AS Date)),
(N'NV02', N'Đặng Thương', CAST(0x75230B00 AS Date), N'Nam', N'TPHCM', N'0985485327', N'CV03', CAST(0x4C410B00 AS Date))


--NGƯỜI DÙNG
INSERT NguoiDung VALUES (N'NV01', N'ndt271199', N'True', N'CV01'),
						(N'NV02', N'ndt271199', N'True', N'CV03')

--SẢN PHẨM
INSERT SanPham VALUES (N'SP001', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM EMBOSSED', 500000, 600000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-da-louis-vuitton-monogram-embossed.jpg', N'Cái', N'Louis Vuitton'),
(N'SP002', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM DEMIN', 550000, 650000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-monogram-denim.jpg', N'Cái', N'Louis Vuitton'),
(N'SP003', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM DEMIN BLACK', 400000, 500000, 70, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-monogram-denim-black.jpg', N'Cái', N'Louis Vuitton'),
(N'SP004', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM NYLON', 700000, 800000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-monogram-nylon.jpg', N'Cái', N'Louis Vuitton'),
(N'SP005', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM STRACK SUIT', 800000, 900000, 55, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-monogram-track-suit.jpg', N'Cái', N'Louis Vuitton'),
(N'SP006', N'L001', N'ÁO KHOÁC LOUIS VUITTON MULTICOLOR MONOGRAM TULLE', 2000000, 2100000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-multicolor-monogram-tulle.jpg', N'Cái', N'Louis Vuitton'),
(N'SP007', N'L001', N'ÁO KHOÁC LOUIS VUITTON REVERSIBLE MIX BLOUSON', 650000, 750000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-reversible-mix-blouson.jpg', N'Cái', N'Louis Vuitton'),
(N'SP008', N'L001', N'ÁO KHOÁC LOUIS VUITTON REVERSIBLE WINDBREAKER', 700000, 800000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-reversible-windbreaker.jpg', N'Cái', N'Louis Vuitton'),
(N'SP009', N'L001', N'ÁO KHOÁC LOUIS VUITTON ZIPPED WITH POCKET DETAIL', 450000, 550000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-louis-vuitton-zipped-with-pocket-detail.jpg', N'Cái', N'Louis Vuitton'),
(N'SP010', N'L001', N'ÁO KHOÁC LOUIS VUITTON MONOGRAM JACQUARD', 800000, 900000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-khoac-lv-louis-vuitton-monogram-jacquard.jpg', N'Cái', N'Louis Vuitton'),
(N'SP011', N'L002', N'ÁO THUN LOUIS VUITTON COULD PRINT T-SHIRT', 500000, 600000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-cloud-print-t-shirt.jpg', N'Cái', N'Louis Vuitton'),
(N'SP012', N'L002', N'ÁO THUN LOUIS VUITTON KANSAS WINDS', 350000, 450000, 37, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-kansas-winds.jpg', N'Cái', N'Louis Vuitton'),
(N'SP013', N'L002', N'ÁO THUN LOUIS VUITTON LV BRICK PRINTED', 250000, 350000, 27, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-lv-brick-printed.jpg', N'Cái', N'Louis Vuitton'),
(N'SP014', N'L002', N'ÁO THUN LOUIS VUITTON LV PLANES', 300000, 400000, 70, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-lv-planes.jpg', N'Cái', N'Louis Vuitton'),
(N'SP015', N'L002', N'ÁO THUN LOUIS VUITTON LV SMOKE PRINTED', 500000, 600000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-lv-smoke-printed.jpg', N'Cái', N'Louis Vuitton'),
(N'SP016', N'L002', N'ÁO THUN LOUIS VUITTON LV STITCH PRINT AND EMBROIDRED', 300000, 400000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-lv-stitch-print-and-embroidered.jpg', N'Cái', N'Louis Vuitton'),
(N'SP017', N'L002', N'ÁO THUN LOUIS VUITTON MONOGRAM 3D EFFECT', 250000, 350000, 80, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-monogram-3d-effect.jpg', N'Cái', N'Louis Vuitton'),
(N'SP018', N'L002', N'ÁO THUN LOUIS VUITTON MONOGRAM GREY', 300000, 400000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-monogram-grey.jpg', N'Cái', N'Louis Vuitton'),
(N'SP019', N'L002', N'ÁO THUN LOUIS VUITTON MONOGRAM TULLE', 800000, 900000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-monogram-tulle.jpg', N'Cái', N'Louis Vuitton'),
(N'SP020', N'L002', N'ÁO THUN LOUIS VUITTON MONOGRAM WHITE', 1000000, 1100000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-phong-louis-vuitton-monogram-white.jpg', N'Cái', N'Louis Vuitton'),
(N'SP021', N'L003', N'ÁO SO MI LOUIS VUITTON LV LEAF DENIM', 1000000, 1100000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-coc-tay-louis-vuitton-lv-leaf-denim.jpg', N'Cái', N'Louis Vuitton'),
(N'SP022', N'L003', N'ÁO SO MI LOUIS VUITTON CAMO DNA BEIGE', 1200000, 1300000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-camo-dna-beige.jpg', N'Cái', N'Louis Vuitton'),
(N'SP023', N'L003', N'ÁO SO MI LOUIS VUITTON CAMO DNA OCEAN', 1250000, 1350000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-camo-dna-ocean.jpg', N'Cái', N'Louis Vuitton'),
(N'SP024', N'L003', N'ÁO SO MI LOUIS VUITTON DNA', 1500000, 1600000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-dna.jpg', N'Cái', N'Louis Vuitton'),
(N'SP025', N'L003', N'ÁO SO MI LOUIS VUITTON DNA BLACK', 1500000, 1600000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-dna-black.jpg', N'Cái', N'Louis Vuitton'),
(N'SP026', N'L003', N'ÁO SO MI LOUIS VUITTON FLOWER PATCHWORK', 2000000, 2100000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-flower-patchwork.jpg', N'Cái', N'Louis Vuitton'),
(N'SP027', N'L003', N'ÁO SO MI LOUIS VUITTON FULL MONOGRAM JACQUARD', 1000000, 1100000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-full-monogram-jacquard.jpg', N'Cái', N'Louis Vuitton'),
(N'SP028', N'L003', N'ÁO SO MI LOUIS VUITTON LV LEAF SILK', 1500000, 1600000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-lv-leaf-silk.jpg', N'Cái', N'Louis Vuitton'),
(N'SP029', N'L003', N'ÁO SO MI LOUIS VUITTON SPACEMAN PRINT', 1700000, 1800000, 54, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-spaceman-print.jpg', N'Cái', N'Louis Vuitton'),
(N'SP030', N'L003', N'ÁO SO MI LOUIS VUITTON LV GALAXY', 1800000, 1900000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\ao-so-mi-louis-vuitton-split-lv-galaxy.jpg', N'Cái', N'Louis Vuitton'),
(N'SP031', N'L004', N'BALO LOUIS VUITTON APOLLO', 300000, 400000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-apollo.jpg', N'Cái', N'Louis Vuitton'),
(N'SP032', N'L004', N'BALO LOUIS VUITTON APOLLO BLUE TAIGA', 450000, 500000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-apollo-blue-taiga.jpg', N'Cái', N'Louis Vuitton'),
(N'SP033', N'L004', N'BALO LOUIS VUITTON APOLLO VIVIENNE', 500000, 600000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-apollo-vivienne.jpg', N'Cái', N'Louis Vuitton'),
(N'SP034', N'L004', N'BALO LOUIS VUITTON CHRISTOPHER', 500000, 600000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-christopher-gm.jpg', N'Cái', N'Louis Vuitton'),
(N'SP035', N'L004', N'BALO LOUIS VUITTON MOCHILA APOLLO', 550000, 750000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-mochila-apollo.jpg', N'Cái', N'Louis Vuitton'),
(N'SP036', N'L004', N'BALO LOUIS VUITTON MONOGRAM TITANIUM', 700000, 800000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-monogram-titanium.jpg', N'Cái', N'Louis Vuitton'),
(N'SP037', N'L004', N'BALO LOUIS VUITTON OUTDOOR MONOGRAM', 800000, 900000, 25, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-outdoor-monogram.jpg', N'Cái', N'Louis Vuitton'),
(N'SP038', N'L004', N'BALO LOUIS VUITTON SPRINTER', 300000, 400000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-sprinter.jpg', N'Cái', N'Louis Vuitton'),
(N'SP039', N'L004', N'BALO LOUIS VUITTON TRIO MONOGRAM', 2000000, 2100000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-louis-vuitton-trio-monogram.jpg', N'Cái', N'Louis Vuitton'),
(N'SP040', N'L004', N'BALO LOUIS VUITTON CHRISTOPHER BACKPACK', 850000, 950000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\balo-lv-christopher-backpack.jpg', N'Cái', N'Louis Vuitton'),
(N'SP041', N'L005', N'GIÀY LOUIS VUITTON LUXEMBOURG SNEAKER', 850000, 950000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-luxembourg-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP042', N'L005', N'GIÀY LOUIS VUITTON LV TRAINER DENIM SNEAKER', 900000, 1000000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-lv-trainer-denim-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP043', N'L005', N'GIÀY LOUIS VUITTON LV TRAINER SNEAKER', 850000, 950000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-lv-trainer-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP044', N'L005', N'GIÀY LOUIS VUITTON LV TRAINER SNEAKER MID TOP', 1500000, 1600000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-lv-trainer-sneaker-mid-top.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP045', N'L005', N'GIÀY LOUIS VUITTON LV TRAINER TRANSPARENT', 900000, 1000000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-lv-trainer-transparent.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP046', N'L005', N'GIÀY LOUIS VUITTON RIVOLI SNEAKER', 900000, 1000000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-rivoli-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP047', N'L005', N'GIÀY LOUIS VUITTON RIVOLI SNEAKER BLACK', 850000, 950000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-rivoli-sneaker-black.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP048', N'L005', N'GIÀY LOUIS VUITTON RUN AWAY SNEAKER', 750000, 850000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-run-away-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP049', N'L005', N'GIÀY LOUIS VUITTON TATTOO SNEAKER', 850000, 950000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-tattoo-sneaker.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP050', N'L005', N'GIÀY LOUIS VUITTON TATTOO SNEAKER BOOT', 1050000, 1150000, 25, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\louis-vuitton-tattoo-sneaker-boot.jpg', N'Ðôi', N'Louis Vuitton'),
(N'SP051', N'L006', N'QU?N TÂY LOUIS VUITTON CLASSIC SLIM', 500000, 600000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\quan-louis-vuitton-classic-slim.jpg', N'Cái', N'Louis Vuitton'),
(N'SP052', N'L006', N'QU?N TÂY LOUIS VUITTON STRETCH SLIM', 600000, 700000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\quan-louis-vuitton-stretch-slim-jeans.jpg', N'Cái', N'Louis Vuitton'),
(N'SP053', N'L007', N'TÚI LOUIS VUITTON KEEPALL BANDOULIERE', 1500000, 1600000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-du-lich-louis-vuitton-keepall-bandouliere.jpg', N'Cái', N'Louis Vuitton'),
(N'SP054', N'L007', N'TÚI LOUIS VUITTON SOFT TRUNK MONOGRAM DENIM', 1500000, 1600000, 20, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-louis-vuitton-soft-trunk-monogram-denim.jpg', N'Cái', N'Louis Vuitton'),
(N'SP055', N'L007', N'TÚI LOUIS VUITTON TRIANGLE MESSENGER BLACK', 1500000, 1600000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-louis-vuitton-triangle-messenger-black.jpg', N'Cái', N'Louis Vuitton'),
(N'SP056', N'L007', N'TÚI LOUIS VUITTON TRIANGLE MESSENGER BLUE', 1800000, 1900000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-louis-vuitton-triangle-messenger-blue.jpg', N'Cái', N'Louis Vuitton'),
(N'SP057', N'L007', N'TÚI LOUIS VUITTON VERTICAL SOFT TRUNK YELLOW', 1700000, 1800000, 25, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-louis-vuitton-vertical-soft-trunk-yellow.jpg', N'Cái', N'Italya'),
(N'SP058', N'L007', N'TÚI LOUIS VUITTON X NIGO SOFT TRUNK MONOGRAM', 2000000, 2100000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-louis-vuitton-x-nigo-soft-trunk-monogram.jpg', N'Cái', N'Italya'),
(N'SP059', N'L007', N'TÚI LOUIS VUITTON CHALK NANO', 1800000, 1900000, 40, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-lv-louis-vuitton-chalk-nano.jpg', N'Cái', N'Louis Vuitton'),
(N'SP060', N'L007', N'TÚI CLUTCH LOUIS VUITTON MONOGRAM', 1700000, 1800000, 50, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-nam-clutch-louis-vuitton-monogram.jpg', N'Cái', N'Louis Vuitton'),
(N'SP061', N'L007', N'TÚI LOUIS VUITTON SOFT TRUNK', 1800000, 1900000, 30, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-nam-louis-vuitton-soft-trunk.jpg', N'Cái', N'Louis Vuitton'),
(N'SP062', N'L007', N'TÚI LOUIS VUITTON SOFT TRUNK BRIEFCASE', 2000000, 2100000, 10, N'D:\DuyThaiIT\PTPM Và UDTM\DoAnQuanLyBanHang\HinhAnh\SanPham\tui-xach-louis-vuitton-soft-trunk-briefcase.jpg', N'Cái', N'Louis Vuitton')