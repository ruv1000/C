USE [master]
GO
/****** Object:  Database [Port]    Script Date: 03.10.2013 13:51:15 ******/
CREATE DATABASE [Port] ON  PRIMARY 
( NAME = N'Port', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Port.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Port_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Port_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Port] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Port].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Port] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Port] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Port] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Port] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Port] SET ARITHABORT OFF 
GO
ALTER DATABASE [Port] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Port] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Port] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Port] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Port] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Port] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Port] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Port] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Port] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Port] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Port] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Port] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Port] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Port] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Port] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Port] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Port] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Port] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Port] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Port] SET  MULTI_USER 
GO
ALTER DATABASE [Port] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Port] SET DB_CHAINING OFF 
GO
USE [Port]
GO
/****** Object:  Table [dbo].[History_Ship]    Script Date: 03.10.2013 13:51:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History_Ship](
	[ID_H] [int] IDENTITY(1,1) NOT NULL,
	[ID_Ship] [int] NOT NULL,
	[Data_Arrivels] [date] NOT NULL,
	[Data_Departure] [date] NOT NULL,
 CONSTRAINT [PK_History_Ship] PRIMARY KEY CLUSTERED 
(
	[ID_H] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Load]    Script Date: 03.10.2013 13:51:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Load](
	[ID_Load] [int] IDENTITY(1,1) NOT NULL,
	[ID_Ship] [int] NOT NULL,
	[Info_Load] [nvarchar](50) NOT NULL,
	[Amount of cargo] [nvarchar](50) NOT NULL,
	[Units] [nvarchar](50) NOT NULL,
	[F.I.O._Recipient] [nvarchar](50) NOT NULL,
	[From] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Load_1] PRIMARY KEY CLUSTERED 
(
	[ID_Load] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ship]    Script Date: 03.10.2013 13:51:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ship](
	[ID_Ship] [int] IDENTITY(1,1) NOT NULL,
	[Type_Ship] [nvarchar](50) NOT NULL,
	[Name_Ship] [nvarchar](50) NOT NULL,
	[Capitan] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ship] PRIMARY KEY CLUSTERED 
(
	[ID_Ship] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[History_Ship] ON 

INSERT [dbo].[History_Ship] ([ID_H], [ID_Ship], [Data_Arrivels], [Data_Departure]) VALUES (1, 2, CAST(0xA7370B00 AS Date), CAST(0xAC370B00 AS Date))
INSERT [dbo].[History_Ship] ([ID_H], [ID_Ship], [Data_Arrivels], [Data_Departure]) VALUES (2, 2, CAST(0xC5260B00 AS Date), CAST(0xA52B0B00 AS Date))
SET IDENTITY_INSERT [dbo].[History_Ship] OFF
SET IDENTITY_INSERT [dbo].[Load] ON 

INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (1, 2, N'Нефть', N'14800', N'Гал.', N'Москаленко А.В.', N'Россия')
INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (3, 2, N'Мазут', N'1500', N'Гал.', N'Слива Д.М.', N'Россия')
INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (4, 3, N'Зерно', N'140', N'Тон', N'Калашник К.О.', N'Украина')
INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (5, 3, N'Рис', N'259', N'Тон', N'Кожурин В.Б.', N'Китай')
INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (6, 4, N'Бананы', N'48', N'Конт.', N'Субочева И.А.', N'Африка')
INSERT [dbo].[Load] ([ID_Load], [ID_Ship], [Info_Load], [Amount of cargo], [Units], [F.I.O._Recipient], [From]) VALUES (7, 4, N'Авто', N'56', N'Конт.', N'Андрєєв А.А.', N'Германия')
SET IDENTITY_INSERT [dbo].[Load] OFF
SET IDENTITY_INSERT [dbo].[Ship] ON 

INSERT [dbo].[Ship] ([ID_Ship], [Type_Ship], [Name_Ship], [Capitan], [Country]) VALUES (2, N'Танкер', N'Дербент', N'Иванов И.И.', N'Украина')
INSERT [dbo].[Ship] ([ID_Ship], [Type_Ship], [Name_Ship], [Capitan], [Country]) VALUES (3, N'Сухогруз', N'Бербент', N'Абдулаев А.А.', N'Россия')
INSERT [dbo].[Ship] ([ID_Ship], [Type_Ship], [Name_Ship], [Capitan], [Country]) VALUES (4, N'Контейнеровоз', N'HAPAG LLOYD', N'Emma Maersk', N'USSA')
SET IDENTITY_INSERT [dbo].[Ship] OFF
ALTER TABLE [dbo].[History_Ship]  WITH CHECK ADD  CONSTRAINT [FK_History_Ship_Ship] FOREIGN KEY([ID_Ship])
REFERENCES [dbo].[Ship] ([ID_Ship])
GO
ALTER TABLE [dbo].[History_Ship] CHECK CONSTRAINT [FK_History_Ship_Ship]
GO
ALTER TABLE [dbo].[Load]  WITH CHECK ADD  CONSTRAINT [FK_Load_Ship] FOREIGN KEY([ID_Ship])
REFERENCES [dbo].[Ship] ([ID_Ship])
GO
ALTER TABLE [dbo].[Load] CHECK CONSTRAINT [FK_Load_Ship]
GO
USE [master]
GO
ALTER DATABASE [Port] SET  READ_WRITE 
GO
