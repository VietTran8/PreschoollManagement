USE [master]
GO
/****** Object:  Database [QuanLyMamNon]    Script Date: 5/6/2023 3:20:22 PM ******/
CREATE DATABASE [QuanLyMamNon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyMamNon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyMamNon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyMamNon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QuanLyMamNon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyMamNon] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyMamNon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyMamNon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyMamNon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyMamNon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyMamNon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyMamNon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyMamNon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyMamNon] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyMamNon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyMamNon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyMamNon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyMamNon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyMamNon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyMamNon] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyMamNon] SET QUERY_STORE = OFF
GO
USE [QuanLyMamNon]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[malop] [varchar](5) NOT NULL,
	[tenlop] [nvarchar](100) NULL,
	[phong] [varchar](10) NULL,
	[khoilop] [nvarchar](50) NULL,
	[nienkhoa] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hocsinh]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocsinh](
	[mahocsinh] [varchar](6) NOT NULL,
	[malop] [varchar](5) NULL,
	[hohocsinh] [nvarchar](100) NULL,
	[tenhocsinh] [nvarchar](100) NULL,
	[gioitinh] [int] NULL,
	[ngaysinh] [date] NULL,
	[dantoc] [nvarchar](50) NULL,
	[tongiao] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[quequan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[phuhuynh]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phuhuynh](
	[mahocsinh] [varchar](6) NOT NULL,
	[tenphuhuynh] [nvarchar](100) NULL,
	[sodienthoai] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[mahocsinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[InDanhSachHocSinh]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[InDanhSachHocSinh] as
select hocsinh.mahocsinh as mahs, concat(concat(hohocsinh, ' '), tenhocsinh) as tenhs, ngaysinh, tenlop as lop, tenphuhuynh, sodienthoai from hocsinh, lop, phuhuynh 
where hocsinh.mahocsinh = phuhuynh.mahocsinh and hocsinh.malop = lop.malop
GO
/****** Object:  Table [dbo].[hocphi]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hocphi](
	[mahocphi] [int] IDENTITY(1,1) NOT NULL,
	[mahocsinh] [varchar](6) NULL,
	[namhoc] [int] NULL,
	[handong] [date] NULL,
	[ngaydong] [date] NULL,
	[pttt] [nvarchar](100) NULL,
	[tienhocphi] [float] NULL,
	[tienbaohiem] [float] NULL,
	[tiencapduong] [float] NULL,
	[phikhac] [float] NULL,
	[trangthai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahocphi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kqrenluyen]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kqrenluyen](
	[maketqua] [int] IDENTITY(1,1) NOT NULL,
	[mahocsinh] [varchar](6) NULL,
	[thang] [int] NULL,
	[thechat] [int] NULL,
	[nhanthuc] [int] NULL,
	[ngongu] [int] NULL,
	[tinhcamxh] [int] NULL,
	[thammy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maketqua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[monan]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[monan](
	[mamon] [int] IDENTITY(1,1) NOT NULL,
	[mathucdon] [int] NULL,
	[tenmon] [nvarchar](100) NULL,
	[thu] [int] NULL,
	[buoi] [int] NULL,
	[ghichu] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[mamon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tentaikhoan] [varchar](30) NOT NULL,
	[matkhau] [varchar](18) NULL,
	[vaitro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[tentaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thucdon]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thucdon](
	[mathucdon] [int] IDENTITY(1,1) NOT NULL,
	[ngaybatdau] [date] NULL,
	[ngayketthuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[mathucdon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[hocphi]  WITH CHECK ADD FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[hocsinh] ([mahocsinh])
GO
ALTER TABLE [dbo].[hocsinh]  WITH CHECK ADD FOREIGN KEY([malop])
REFERENCES [dbo].[Lop] ([malop])
GO
ALTER TABLE [dbo].[kqrenluyen]  WITH CHECK ADD FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[hocsinh] ([mahocsinh])
GO
ALTER TABLE [dbo].[monan]  WITH CHECK ADD FOREIGN KEY([mathucdon])
REFERENCES [dbo].[thucdon] ([mathucdon])
GO
ALTER TABLE [dbo].[phuhuynh]  WITH CHECK ADD FOREIGN KEY([mahocsinh])
REFERENCES [dbo].[hocsinh] ([mahocsinh])
GO
/****** Object:  StoredProcedure [dbo].[capNhatHocSinh]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capNhatHocSinh] @mahocsinh varchar(6), @malop varchar(5), @hohocsinh nvarchar(100), @tenhocsinh nvarchar(100), 
@gioitinh int, @ngaysinh date, @dantoc nvarchar(50), @tongiao nvarchar(50), @diachi nvarchar(100),
@quequan nvarchar(100), @tenphuhuynh nvarchar(100), @sodienthoai varchar(12) as
begin
	update hocsinh set malop = @malop, hohocsinh = @hohocsinh,
	tenhocsinh = @tenhocsinh, gioitinh = @gioitinh, ngaysinh = @ngaysinh, 
	dantoc = @dantoc, tongiao = @tongiao, diachi = @diachi, quequan = @quequan where mahocsinh = @mahocsinh

	update phuhuynh set tenphuhuynh = @tenphuhuynh, sodienthoai = @sodienthoai where mahocsinh = @mahocsinh
end
GO
/****** Object:  StoredProcedure [dbo].[deleteClass]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteClass] @malop varchar(5) as
begin 
	delete phuhuynh where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))
	delete hocphi where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))
	delete kqrenluyen where mahocsinh in (select mahocsinh from hocsinh where malop in (select malop from lop where malop = @malop))

	delete hocsinh where malop in (select malop from lop where malop = @malop)

	delete lop where malop = @malop
end
GO
/****** Object:  StoredProcedure [dbo].[themHocSinh]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themHocSinh] @malop varchar(5), @hohocsinh nvarchar(100), @tenhocsinh nvarchar(100), 
@gioitinh int, @ngaysinh date, @dantoc nvarchar(50), @tongiao nvarchar(50), @diachi nvarchar(100),
@quequan nvarchar(100), @tenphuhuynh nvarchar(100), @sodienthoai varchar(12) as
begin 
	declare @maxId int,
			@newId varchar(6)
	if(not exists(select * from hocsinh))
		set @newId = 'HS0001'
	else
	begin
		select @maxId = max(cast(substring(mahocsinh, 3, 4) as int)) from hocsinh
		set @maxId = @maxId + 1
		if(@maxId < 10)
			set @newId = concat('HS000', cast((@maxId) as varchar(1)))
		else if (@maxId < 100)
			set @newId = concat('HS00', cast((@maxId) as varchar(2)))
		else if (@maxId < 1000)
			set @newId = concat('HS0', cast((@maxId) as varchar(3)))
		else
			set @newId = concat('HS', cast((@maxId) as varchar(4)))
	end
	insert into hocsinh (
					mahocsinh,
					malop,
					hohocsinh,
					tenhocsinh,
					gioitinh,
					ngaysinh,
					dantoc,
					tongiao,
					diachi,
					quequan)
			values (
				@newId,
				@malop,
				@hohocsinh,
				@tenhocsinh,
				@gioitinh,
				@ngaysinh,
				@dantoc,
				@tongiao,
				@diachi,
				@quequan
			)
	
	insert into phuhuynh (mahocsinh, tenphuhuynh, sodienthoai) values (@newId, @tenphuhuynh, @sodienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[themLop]    Script Date: 5/6/2023 3:20:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLop] @ten nvarchar(100), @phong varchar(10), @khoilop nvarchar(50),
@nienkhoa varchar(11)
as
begin
	declare @maxId int,
			@newId varchar(5)

	if(not exists(select * from lop))
		set @newId = 'L0001'
	else
	begin
		select @maxId = max(cast(substring(malop, 2, 4) as int)) from lop
		set @maxId = @maxId + 1
		if(@maxId < 10)
			set @newId = concat('L000', cast((@maxId) as varchar(1)))
		else if (@maxId < 100)
			set @newId = concat('L00', cast((@maxId) as varchar(2)))
		else if (@maxId < 1000)
			set @newId = concat('L0', cast((@maxId) as varchar(3)))
		else
			set @newId = concat('L', cast((@maxId) as varchar(4)))
	end

	insert into lop values (@newId, @ten, @phong, @khoilop, @nienkhoa)
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyMamNon] SET  READ_WRITE 
GO
