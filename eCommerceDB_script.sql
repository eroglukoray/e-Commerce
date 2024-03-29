USE [master]
GO
/****** Object:  Database [CommerceDB]    Script Date: 9.05.2020 18:49:38 ******/
CREATE DATABASE [CommerceDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CommerceDB', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Database\CommerceDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CommerceDB_log', FILENAME = N'E:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Log\CommerceDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CommerceDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CommerceDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CommerceDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CommerceDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CommerceDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CommerceDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CommerceDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CommerceDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CommerceDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CommerceDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CommerceDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CommerceDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CommerceDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CommerceDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CommerceDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CommerceDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CommerceDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CommerceDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CommerceDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CommerceDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CommerceDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CommerceDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CommerceDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CommerceDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CommerceDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CommerceDB] SET  MULTI_USER 
GO
ALTER DATABASE [CommerceDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CommerceDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CommerceDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CommerceDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CommerceDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CommerceDB', N'ON'
GO
ALTER DATABASE [CommerceDB] SET QUERY_STORE = OFF
GO
USE [CommerceDB]
GO
/****** Object:  Table [dbo].[Campaigns]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaigns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[DiscountTypeId] [int] NOT NULL,
	[DiscountRate] [int] NOT NULL,
	[AmountLimit] [int] NOT NULL,
 CONSTRAINT [PK__Campaign__3F5E8D79F3D48E5F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartProducts]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartProducts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CartId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_CartProducts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carts]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TotalPrice] [money] NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_Carts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coupons]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DiscountTypeId] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[DiscountRate] [int] NOT NULL,
 CONSTRAINT [PK_Coupons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deliveries]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deliveries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CartId] [int] NOT NULL,
	[CostPerDelivery] [float] NOT NULL,
	[CostPerProduct] [float] NOT NULL,
	[FixedCost] [float] NOT NULL,
 CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiscountType]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiscountType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_DiscountType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9.05.2020 18:49:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK__Products__B40CC6ED49D3F3CD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Campaigns] ON 

INSERT [dbo].[Campaigns] ([Id], [CategoryId], [DiscountTypeId], [DiscountRate], [AmountLimit]) VALUES (1, 1, 1, 10, 20)
SET IDENTITY_INSERT [dbo].[Campaigns] OFF
SET IDENTITY_INSERT [dbo].[CartProducts] ON 

INSERT [dbo].[CartProducts] ([Id], [CartId], [ProductId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[CartProducts] OFF
SET IDENTITY_INSERT [dbo].[Carts] ON 

INSERT [dbo].[Carts] ([Id], [TotalPrice], [Amount]) VALUES (1, 101.2500, 25)
SET IDENTITY_INSERT [dbo].[Carts] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Title]) VALUES (1, N'Food')
INSERT [dbo].[Categories] ([Id], [Title]) VALUES (2, N'Electronics')
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Coupons] ON 

INSERT [dbo].[Coupons] ([Id], [DiscountTypeId], [Price], [DiscountRate]) VALUES (0, 1, 50.0000, 10)
INSERT [dbo].[Coupons] ([Id], [DiscountTypeId], [Price], [DiscountRate]) VALUES (1, 1, 25.0000, 10)
INSERT [dbo].[Coupons] ([Id], [DiscountTypeId], [Price], [DiscountRate]) VALUES (2, 1, 20.0000, 10)
SET IDENTITY_INSERT [dbo].[Coupons] OFF
SET IDENTITY_INSERT [dbo].[Deliveries] ON 

INSERT [dbo].[Deliveries] ([Id], [CartId], [CostPerDelivery], [CostPerProduct], [FixedCost]) VALUES (1, 1, 5.99, 5, 2.99)
INSERT [dbo].[Deliveries] ([Id], [CartId], [CostPerDelivery], [CostPerProduct], [FixedCost]) VALUES (2, 1, 5.99, 5, 2.99)
INSERT [dbo].[Deliveries] ([Id], [CartId], [CostPerDelivery], [CostPerProduct], [FixedCost]) VALUES (3, 1, 5.99, 5, 2.99)
INSERT [dbo].[Deliveries] ([Id], [CartId], [CostPerDelivery], [CostPerProduct], [FixedCost]) VALUES (4, 1, 5.99, 5, 2.99)
INSERT [dbo].[Deliveries] ([Id], [CartId], [CostPerDelivery], [CostPerProduct], [FixedCost]) VALUES (5, 1, 5.99, 5, 2.99)
SET IDENTITY_INSERT [dbo].[Deliveries] OFF
SET IDENTITY_INSERT [dbo].[DiscountType] ON 

INSERT [dbo].[DiscountType] ([Id], [Title]) VALUES (1, N'Rate')
INSERT [dbo].[DiscountType] ([Id], [Title]) VALUES (2, N'Amount')
SET IDENTITY_INSERT [dbo].[DiscountType] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [CategoryId], [Title], [Price]) VALUES (1, 1, N'Apple', 5.0000)
INSERT [dbo].[Products] ([Id], [CategoryId], [Title], [Price]) VALUES (3, 1, N'Almond', 70.0000)
INSERT [dbo].[Products] ([Id], [CategoryId], [Title], [Price]) VALUES (4, 2, N'Iphone', 10000.0000)
SET IDENTITY_INSERT [dbo].[Products] OFF
USE [master]
GO
ALTER DATABASE [CommerceDB] SET  READ_WRITE 
GO
