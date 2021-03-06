USE [master]
GO
/****** Object:  Database [QLTDL]    Script Date: 12/20/2017 12:39:41 PM ******/
CREATE DATABASE [QLTDL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTDL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLTDL.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTDL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QLTDL_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTDL] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTDL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTDL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTDL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTDL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTDL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTDL] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTDL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTDL] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLTDL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTDL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTDL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTDL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTDL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTDL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTDL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTDL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTDL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTDL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTDL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTDL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTDL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTDL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTDL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTDL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTDL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTDL] SET  MULTI_USER 
GO
ALTER DATABASE [QLTDL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTDL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTDL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTDL] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLTDL]
GO
/****** Object:  Table [dbo].[CTNTQ]    Script Date: 12/20/2017 12:39:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNTQ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDTT] [int] NOT NULL,
	[TENGOI] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTTT]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTTT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDDDL] [int] NOT NULL,
	[IDLOAI] [int] NOT NULL,
	[NOIDUNG] [nvarchar](max) NULL,
	[THANHTIEN] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DOANDL]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANDL](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDT] [int] NOT NULL,
	[TENGOI] [nvarchar](max) NULL,
	[NGAYBD] [datetime] NULL,
	[NGAYKT] [datetime] NULL,
	[TONGKINHPHI] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GIATOUR]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIATOUR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDT] [int] NOT NULL,
	[GIATOUR] [money] NOT NULL,
	[NGAYBD] [datetime] NULL,
	[NGAYKT] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KH]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KH](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HOTL] [nvarchar](255) NOT NULL,
	[TEN] [nvarchar](255) NULL,
	[CMND] [int] NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](255) NULL,
	[SDT] [int] NULL,
	[QUOCTICH] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITOUR]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITOUR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAI] [nchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITT]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITT](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NOIDUNG] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](255) NULL,
	[HOTL] [nvarchar](255) NULL,
	[SDT] [int] NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[CMND] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHIEMVU]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHIEMVU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NHIEMVU] [nchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NOITHAMQUAN]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NOITHAMQUAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENGOI] [nvarchar](max) NULL,
	[TENNUOC] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NVTD]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NVTD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDDDL] [int] NOT NULL,
	[IDNVU] [int] NOT NULL,
	[IDNV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TGTOUR]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TGTOUR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKH] [int] NOT NULL,
	[IDDDL] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOUR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDL] [int] NOT NULL,
	[TENGOI] [nvarchar](max) NULL,
	[DACDIEM] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOURDD]    Script Date: 12/20/2017 12:39:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOURDD](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDT] [int] NOT NULL,
	[IDDD] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CTNTQ] ON 

INSERT [dbo].[CTNTQ] ([ID], [IDTT], [TENGOI]) VALUES (1, 1, N'Nhà thờ Đức Bà')
INSERT [dbo].[CTNTQ] ([ID], [IDTT], [TENGOI]) VALUES (2, 1, N'Phố đi bộ')
INSERT [dbo].[CTNTQ] ([ID], [IDTT], [TENGOI]) VALUES (3, 3, N'Bãi biển ')
INSERT [dbo].[CTNTQ] ([ID], [IDTT], [TENGOI]) VALUES (4, 6, N'Thành nhà Nguyễn')
INSERT [dbo].[CTNTQ] ([ID], [IDTT], [TENGOI]) VALUES (1002, 3, N'Mộ Hàn Mặc Tử')
SET IDENTITY_INSERT [dbo].[CTNTQ] OFF
SET IDENTITY_INSERT [dbo].[CTTT] ON 

INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (1, 1003, 1, N'khách sạn 5 sao 2 ngày', 15000000.0000)
INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (2, 5, 2, N'đi từ a -> b', 2000000.0000)
INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (3, 1003, 3, N'ăn uống 3 ngày', 10000000.0000)
INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (4, 1003, 4, N'chi phí khác', 5000000.0000)
INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (5, 1005, 1, N'khách sạn 5 sao 2 ngày', 7000000.0000)
INSERT [dbo].[CTTT] ([ID], [IDDDL], [IDLOAI], [NOIDUNG], [THANHTIEN]) VALUES (6, 1005, 2, N'ok', 400000.0000)
SET IDENTITY_INSERT [dbo].[CTTT] OFF
SET IDENTITY_INSERT [dbo].[DOANDL] ON 

INSERT [dbo].[DOANDL] ([ID], [IDT], [TENGOI], [NGAYBD], [NGAYKT], [TONGKINHPHI]) VALUES (5, 1, N'Đoàn cty nhất nghệ', CAST(0x0000A84F00000000 AS DateTime), CAST(0x0000A85200000000 AS DateTime), 5000000.0000)
INSERT [dbo].[DOANDL] ([ID], [IDT], [TENGOI], [NGAYBD], [NGAYKT], [TONGKINHPHI]) VALUES (1002, 1, N'đoàn 2', CAST(0x0000A84400000000 AS DateTime), CAST(0x0000A84600000000 AS DateTime), 20000000.0000)
INSERT [dbo].[DOANDL] ([ID], [IDT], [TENGOI], [NGAYBD], [NGAYKT], [TONGKINHPHI]) VALUES (1003, 2, N'Đoàn 3', CAST(0x0000A84500000000 AS DateTime), CAST(0x0000A84700000000 AS DateTime), 40000000.0000)
INSERT [dbo].[DOANDL] ([ID], [IDT], [TENGOI], [NGAYBD], [NGAYKT], [TONGKINHPHI]) VALUES (1004, 2, N'Đoàn 4', CAST(0x0000A84F00000000 AS DateTime), CAST(0x0000A85100000000 AS DateTime), 20000000.0000)
INSERT [dbo].[DOANDL] ([ID], [IDT], [TENGOI], [NGAYBD], [NGAYKT], [TONGKINHPHI]) VALUES (1005, 3, N'Đoàn 5', CAST(0x0000A84D00000000 AS DateTime), CAST(0x0000A84F00000000 AS DateTime), 14000000.0000)
SET IDENTITY_INSERT [dbo].[DOANDL] OFF
SET IDENTITY_INSERT [dbo].[GIATOUR] ON 

INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (1, 1, 5000000.0000, CAST(0x0000A8430159AB0C AS DateTime), CAST(0x0000A85A0159AAA0 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (2, 2, 10000000.0000, CAST(0x0000A84500A09487 AS DateTime), CAST(0x0000A85A00A09434 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (3, 3, 3500000.0000, CAST(0x0000A84500A09434 AS DateTime), CAST(0x0000A85A00A09434 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (4, 3, 4500000.0000, CAST(0x0000A84500A09434 AS DateTime), CAST(0x0000A85A00A09434 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (5, 1, 4000000.0000, CAST(0x0000A8430159AAA0 AS DateTime), CAST(0x0000A85A0159AAA0 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (6, 1, 4000000.0000, CAST(0x0000A8430159AAA0 AS DateTime), CAST(0x0000A85A0159AAA0 AS DateTime))
INSERT [dbo].[GIATOUR] ([ID], [IDT], [GIATOUR], [NGAYBD], [NGAYKT]) VALUES (7, 1, 4000000.0000, CAST(0x0000A84E0159AAA0 AS DateTime), CAST(0x0000A85A0159AAA0 AS DateTime))
SET IDENTITY_INSERT [dbo].[GIATOUR] OFF
SET IDENTITY_INSERT [dbo].[KH] ON 

INSERT [dbo].[KH] ([ID], [HOTL], [TEN], [CMND], [GIOITINH], [DIACHI], [SDT], [QUOCTICH]) VALUES (1, N'Nguyễn', N'Khanh', 25623515, N'Nam', N'69 Lý Thường Kiệt', 1656136537, N'Việt Nam')
INSERT [dbo].[KH] ([ID], [HOTL], [TEN], [CMND], [GIOITINH], [DIACHI], [SDT], [QUOCTICH]) VALUES (2, N'Trần ', N'Trang', 25623516, N'Nữ', N'32 Độc Lập', 1656136539, N'Việt Nam')
INSERT [dbo].[KH] ([ID], [HOTL], [TEN], [CMND], [GIOITINH], [DIACHI], [SDT], [QUOCTICH]) VALUES (3, N'user 2', N'user 2', 25623540, N'Nam', N'25 Thành công', 1656136540, N'Việt Nam')
INSERT [dbo].[KH] ([ID], [HOTL], [TEN], [CMND], [GIOITINH], [DIACHI], [SDT], [QUOCTICH]) VALUES (4, N'user 3', N'user 3', 25623541, N'Nữ', N'24 Lê Lợi', 1656136541, N'Việt Nam')
SET IDENTITY_INSERT [dbo].[KH] OFF
SET IDENTITY_INSERT [dbo].[LOAITOUR] ON 

INSERT [dbo].[LOAITOUR] ([ID], [TENLOAI]) VALUES (1, N'Du lịch gia đình                                                                                                                                                                                                                                               ')
INSERT [dbo].[LOAITOUR] ([ID], [TENLOAI]) VALUES (2, N'Du lịch kết hợp                                                                                                                                                                                                                                                ')
INSERT [dbo].[LOAITOUR] ([ID], [TENLOAI]) VALUES (3, N'Du lịch vui                                                                                                                                                                                                                                                    ')
SET IDENTITY_INSERT [dbo].[LOAITOUR] OFF
SET IDENTITY_INSERT [dbo].[LOAITT] ON 

INSERT [dbo].[LOAITT] ([ID], [NOIDUNG]) VALUES (1, N'Khách sạn')
INSERT [dbo].[LOAITT] ([ID], [NOIDUNG]) VALUES (2, N'Lái xe')
INSERT [dbo].[LOAITT] ([ID], [NOIDUNG]) VALUES (3, N'Ăn uống')
INSERT [dbo].[LOAITT] ([ID], [NOIDUNG]) VALUES (4, N'Khác')
SET IDENTITY_INSERT [dbo].[LOAITT] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([ID], [TENNV], [HOTL], [SDT], [GIOITINH], [CMND]) VALUES (1, N'Khánh', N'Nguyễn', 1656136537, N'Nam', 25623515)
INSERT [dbo].[NHANVIEN] ([ID], [TENNV], [HOTL], [SDT], [GIOITINH], [CMND]) VALUES (2, N'Phương', N'Trần ', 1656136538, N'Nữ', 25623516)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NHIEMVU] ON 

INSERT [dbo].[NHIEMVU] ([ID], [NHIEMVU]) VALUES (1, N'Hướng dẫn viên                                                                                                                                                                                                                                                 ')
INSERT [dbo].[NHIEMVU] ([ID], [NHIEMVU]) VALUES (2, N'Thông dịch viên                                                                                                                                                                                                                                                ')
INSERT [dbo].[NHIEMVU] ([ID], [NHIEMVU]) VALUES (3, N'Lái xe                                                                                                                                                                                                                                                         ')
INSERT [dbo].[NHIEMVU] ([ID], [NHIEMVU]) VALUES (4, N'Phục vụ                                                                                                                                                                                                                                                        ')
SET IDENTITY_INSERT [dbo].[NHIEMVU] OFF
SET IDENTITY_INSERT [dbo].[NOITHAMQUAN] ON 

INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (1, N'Sài Gòn', N'Việt Nam')
INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (2, N'Nha Trang', N'Việt Nam')
INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (3, N'Quy Nhơn', N'Việt Nam')
INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (4, N'Đà Nẵng ', N'Việt Nam')
INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (5, N'Hà Nội', N'Việt Nam')
INSERT [dbo].[NOITHAMQUAN] ([ID], [TENGOI], [TENNUOC]) VALUES (6, N'Huế', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[NOITHAMQUAN] OFF
SET IDENTITY_INSERT [dbo].[NVTD] ON 

INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1, 5, 1, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (2, 5, 3, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (3, 5, 4, 2)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1002, 1003, 1, 2)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1003, 1003, 4, 2)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1004, 1003, 2, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1005, 1003, 3, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1006, 1002, 2, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1007, 1005, 1, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1008, 1005, 3, 1)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1009, 1005, 2, 2)
INSERT [dbo].[NVTD] ([ID], [IDDDL], [IDNVU], [IDNV]) VALUES (1010, 1005, 4, 2)
SET IDENTITY_INSERT [dbo].[NVTD] OFF
SET IDENTITY_INSERT [dbo].[TGTOUR] ON 

INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (1, 1, 5)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (2, 1, 1003)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (3, 2, 1003)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (4, 3, 1003)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (5, 4, 1003)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (6, 1, 1002)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (7, 2, 1002)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (8, 3, 1002)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (9, 4, 1002)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (10, 1, 1004)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (11, 2, 1004)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (12, 1, 1005)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (13, 2, 1005)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (14, 3, 1005)
INSERT [dbo].[TGTOUR] ([ID], [IDKH], [IDDDL]) VALUES (15, 4, 1005)
SET IDENTITY_INSERT [dbo].[TGTOUR] OFF
SET IDENTITY_INSERT [dbo].[TOUR] ON 

INSERT [dbo].[TOUR] ([ID], [IDL], [TENGOI], [DACDIEM]) VALUES (1, 1, N'Sg-Đn', N'chưa có')
INSERT [dbo].[TOUR] ([ID], [IDL], [TENGOI], [DACDIEM]) VALUES (2, 2, N'SG-Huế', N'ez tour')
INSERT [dbo].[TOUR] ([ID], [IDL], [TENGOI], [DACDIEM]) VALUES (3, 3, N'SG-QN', N'tour Sài Gòn Quy Nhơn')
SET IDENTITY_INSERT [dbo].[TOUR] OFF
SET IDENTITY_INSERT [dbo].[TOURDD] ON 

INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1002, 2, 1)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1003, 2, 2)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1004, 2, 3)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1005, 2, 4)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1010, 3, 1)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1011, 3, 3)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1012, 3, 1002)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1013, 3, 2)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1020, 1, 1)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1021, 1, 2)
INSERT [dbo].[TOURDD] ([ID], [IDT], [IDDD]) VALUES (1022, 1, 3)
SET IDENTITY_INSERT [dbo].[TOURDD] OFF
ALTER TABLE [dbo].[CTNTQ]  WITH CHECK ADD FOREIGN KEY([IDTT])
REFERENCES [dbo].[NOITHAMQUAN] ([ID])
GO
ALTER TABLE [dbo].[CTTT]  WITH CHECK ADD FOREIGN KEY([IDDDL])
REFERENCES [dbo].[DOANDL] ([ID])
GO
ALTER TABLE [dbo].[CTTT]  WITH CHECK ADD FOREIGN KEY([IDLOAI])
REFERENCES [dbo].[LOAITT] ([ID])
GO
ALTER TABLE [dbo].[DOANDL]  WITH CHECK ADD FOREIGN KEY([IDT])
REFERENCES [dbo].[TOUR] ([ID])
GO
ALTER TABLE [dbo].[GIATOUR]  WITH CHECK ADD FOREIGN KEY([IDT])
REFERENCES [dbo].[TOUR] ([ID])
GO
ALTER TABLE [dbo].[NVTD]  WITH CHECK ADD FOREIGN KEY([IDDDL])
REFERENCES [dbo].[DOANDL] ([ID])
GO
ALTER TABLE [dbo].[NVTD]  WITH CHECK ADD FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([ID])
GO
ALTER TABLE [dbo].[NVTD]  WITH CHECK ADD FOREIGN KEY([IDNVU])
REFERENCES [dbo].[NHIEMVU] ([ID])
GO
ALTER TABLE [dbo].[TGTOUR]  WITH CHECK ADD FOREIGN KEY([IDDDL])
REFERENCES [dbo].[DOANDL] ([ID])
GO
ALTER TABLE [dbo].[TGTOUR]  WITH CHECK ADD FOREIGN KEY([IDKH])
REFERENCES [dbo].[KH] ([ID])
GO
ALTER TABLE [dbo].[TOUR]  WITH CHECK ADD FOREIGN KEY([IDL])
REFERENCES [dbo].[LOAITOUR] ([ID])
GO
ALTER TABLE [dbo].[TOURDD]  WITH CHECK ADD FOREIGN KEY([IDDD])
REFERENCES [dbo].[CTNTQ] ([ID])
GO
ALTER TABLE [dbo].[TOURDD]  WITH CHECK ADD FOREIGN KEY([IDT])
REFERENCES [dbo].[TOUR] ([ID])
GO
USE [master]
GO
ALTER DATABASE [QLTDL] SET  READ_WRITE 
GO
