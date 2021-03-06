USE [master]
GO
/****** Object:  Database [QuanLyKho]    Script Date: 24-Apr-17 10:05:10 PM ******/
CREATE DATABASE [QuanLyKho]
GO
USE [QuanLyKho]
GO
/****** Object:  Table [dbo].[ADMIN]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[DONVI]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 24-Apr-17 10:05:10 PM ******/

CREATE TABLE [dbo].[HANGHOA](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[tenhang] [nvarchar](200) NOT NULL,
	[mota] [nvarchar](1024) NULL,
	[donvitinh] [varchar](50) NULL,
	[thoigianbaohanh] [int] NULL,
	[manhom] [int] NULL,
 CONSTRAINT [pk_hanghoa] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGNHAP]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[HANGXUAT]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[NHOMHANG]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 24-Apr-17 10:05:10 PM ******/

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
ALTER TABLE [dbo].[PHIEUNHAP] ADD  DEFAULT (getdate()) FOR [ngaynhap]
GO
ALTER TABLE [dbo].[PHIEUXUAT] ADD  DEFAULT (getdate()) FOR [ngayxuat]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [fk_hanghoa_nhomhang] FOREIGN KEY([manhom])
REFERENCES [dbo].[NHOMHANG] ([ma])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [fk_hanghoa_nhomhang]
GO
ALTER TABLE [dbo].[HANGNHAP]  WITH CHECK ADD  CONSTRAINT [fk_hangnhap] FOREIGN KEY([maHang])
REFERENCES [dbo].[HANGHOA] ([ma])
GO
ALTER TABLE [dbo].[HANGNHAP] CHECK CONSTRAINT [fk_hangnhap]
GO
ALTER TABLE [dbo].[HANGXUAT]  WITH CHECK ADD  CONSTRAINT [fk_hangxuat_hanghoa] FOREIGN KEY([maHang])
REFERENCES [dbo].[HANGHOA] ([ma])
GO
ALTER TABLE [dbo].[HANGXUAT] CHECK CONSTRAINT [fk_hangxuat_hanghoa]
GO
ALTER TABLE [dbo].[HANGXUAT]  WITH CHECK ADD  CONSTRAINT [fk_hangxuat_nhanvien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NHANVIEN] ([ma])
GO
ALTER TABLE [dbo].[HANGXUAT] CHECK CONSTRAINT [fk_hangxuat_nhanvien]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_donvi] FOREIGN KEY([madonvi])
REFERENCES [dbo].[DONVI] ([ma])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fk_nhanvien_donvi]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_phieunhap_ncc] FOREIGN KEY([maNCC])
REFERENCES [dbo].[NHACUNGCAP] ([ma])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [fk_phieunhap_ncc]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [fk_phieunhap_nhanvien] FOREIGN KEY([maNV])
REFERENCES [dbo].[NHANVIEN] ([ma])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [fk_phieunhap_nhanvien]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [fk_phieuxuat] FOREIGN KEY([maNV])
REFERENCES [dbo].[NHANVIEN] ([ma])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [fk_phieuxuat]
GO
USE [master]
GO
ALTER DATABASE [QuanLyKho] SET  READ_WRITE 
GO
