create database QuanLyKho
go

USE [QuanLyKho]
GO
/****** Object:  Database [QuanLyKho]    Script Date: 05-May-17 9:00:38 AM ******/

CREATE TABLE [dbo].[ADMIN](
	[tendangnhap] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NULL,
	[quanly] [int] NULL,
 CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED 
(
	[tendangnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DONVI]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONVI](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tendonvi] [nvarchar](200) NOT NULL,
	[chucnang] [nvarchar](200) NULL,
 CONSTRAINT [pk_donvi] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tenhang] [nvarchar](200) NOT NULL,
	[mota] [nvarchar](1024) NULL,
	[donvitinh] [varchar](50) NULL,
	[thoigianbaohanh] [int] NULL,
	[manhom] [int] NULL,
	[soluong] [int] NULL,
 CONSTRAINT [pk_hanghoa] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGNHAP]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGNHAP](
	[Spnhap] [nvarchar](200) NOT NULL,
	[Slchungtu] [int] NULL,
	[Slthucnhap] [int] NULL,
	[Sphieubaohang] [int] NULL,
	[maHang] [int] NULL,
 CONSTRAINT [pk_hangnhap] PRIMARY KEY CLUSTERED 
(
	[Spnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HANGXUAT]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGXUAT](
	[Spxuat] [nvarchar](200) NOT NULL,
	[Slxuat] [int] NULL,
	[maHang] [int] NULL,
	[maNV] [int] NULL,
 CONSTRAINT [pk_hangxuat] PRIMARY KEY CLUSTERED 
(
	[Spxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tenNCC] [nvarchar](200) NOT NULL,
	[diachi] [nvarchar](200) NULL,
	[sodienthoai] [varchar](12) NULL,
 CONSTRAINT [pk_ncc] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[hoten] [nvarchar](200) NOT NULL,
	[ngaysinh] [datetime] NULL,
	[gioitinh] [nvarchar](3) NULL,
	[chuvu] [nvarchar](200) NULL,
	[madonvi] [int] NULL,
 CONSTRAINT [pk_nhanvien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMHANG](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tennhom] [nvarchar](200) NULL,
	[tacdung] [nvarchar](200) NULL,
 CONSTRAINT [pk_nhomhang] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[Spnhap] [nvarchar](200) NOT NULL,
	[ngaynhap] [datetime] NULL,
	[lydonhap] [nvarchar](max) NULL,
	[maNCC] [int] NULL,
	[maNV] [int] NULL,
 CONSTRAINT [pk_phieunhap] PRIMARY KEY CLUSTERED 
(
	[Spnhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 05-May-17 9:00:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[Spxuat] [nvarchar](200) NOT NULL,
	[ngayxuat] [datetime] NULL,
	[lydoxuat] [nvarchar](max) NULL,
	[maNV] [int] NULL,
 CONSTRAINT [pk_phieuxuat] PRIMARY KEY CLUSTERED 
(
	[Spxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[ADMIN] ([tendangnhap], [matkhau], [quanly]) VALUES (N'hungcuong', N'123456', 1)
INSERT [dbo].[ADMIN] ([tendangnhap], [matkhau], [quanly]) VALUES (N'manhthang', N'123456', 0)
SET IDENTITY_INSERT [dbo].[DONVI] ON 

INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (1, N'VĐ', N'Vận chuyển')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (2, N'NHH', N'Nhập hàng hóa')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (3, N'XHH', N'Xuất hàng hóa')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (4, N'QL', N'Quản lý')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (5, N'GHĐ', N'Ghi hóa đơn')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (6, N'BC', N'Báo cáo')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (7, N'KT', N'Kiểm tra')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (9, N'XH', N'Xuất hàng')
INSERT [dbo].[DONVI] ([ma], [tendonvi], [chucnang]) VALUES (20, N'TN', N'Thu ngân')
SET IDENTITY_INSERT [dbo].[DONVI] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([ma], [tenNCC], [diachi], [sodienthoai]) VALUES (1, N'Hoàng Computer', N'220 Cổ Nhuế', N'0999999999')
INSERT [dbo].[NHACUNGCAP] ([ma], [tenNCC], [diachi], [sodienthoai]) VALUES (2, N'CPN', N'12 Phạm Văn Đồng', N'0123456543')
INSERT [dbo].[NHACUNGCAP] ([ma], [tenNCC], [diachi], [sodienthoai]) VALUES (3, N'FPT Shop', N'99 Hai Bà Trưng', N'0000000000')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([ma], [hoten], [ngaysinh], [gioitinh], [chuvu], [madonvi]) VALUES (1, N'Lã Quốc Bảo', CAST(N'1990-11-11 00:00:00.000' AS DateTime), N'Nam', N'0', 1)
INSERT [dbo].[NHANVIEN] ([ma], [hoten], [ngaysinh], [gioitinh], [chuvu], [madonvi]) VALUES (2, N'Lã Quốc Toàn', CAST(N'1995-10-10 00:00:00.000' AS DateTime), N'Nam', N'0', 2)
INSERT [dbo].[NHANVIEN] ([ma], [hoten], [ngaysinh], [gioitinh], [chuvu], [madonvi]) VALUES (5, N'Vũ Hùng Cường', CAST(N'1997-12-02 21:49:19.000' AS DateTime), N'Nam', N'1', 4)
INSERT [dbo].[NHANVIEN] ([ma], [hoten], [ngaysinh], [gioitinh], [chuvu], [madonvi]) VALUES (7, N'', CAST(N'2017-05-02 21:54:07.347' AS DateTime), N'Nữ', N'0', 1)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NHOMHANG] ON 

INSERT [dbo].[NHOMHANG] ([ma], [tennhom], [tacdung]) VALUES (1, N'Computer HP', N'Máy tính thông dụng ( Bàn , laptop... )')
INSERT [dbo].[NHOMHANG] ([ma], [tennhom], [tacdung]) VALUES (2, N'USB Flash', N'Ổ cứng di động')
INSERT [dbo].[NHOMHANG] ([ma], [tennhom], [tacdung]) VALUES (3, N'USB Flash MP3, MP4', N'Ổ cứng ghi được nhạc , phim')
INSERT [dbo].[NHOMHANG] ([ma], [tennhom], [tacdung]) VALUES (5, N'CPU Intel M', N'Bộ vi xử lý trung tâm loại tiết kiệm năng lượng nhất hiện nay')
SET IDENTITY_INSERT [dbo].[NHOMHANG] OFF
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [ngaynhap]
GO
ALTER TABLE [dbo].[PHIEUXUAT] ADD  DEFAULT (getdate()) FOR [ngayxuat]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKho] SET  READ_WRITE 
GO
