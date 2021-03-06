USE [master]
GO
/****** Object:  Database [AlexLab]    Script Date: 9/23/2018 12:02:18 AM ******/
CREATE DATABASE [AlexLab]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AlexLab', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AlexLab.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'AlexLab_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\AlexLab_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [AlexLab] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AlexLab].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AlexLab] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AlexLab] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AlexLab] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AlexLab] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AlexLab] SET ARITHABORT OFF 
GO
ALTER DATABASE [AlexLab] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AlexLab] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [AlexLab] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AlexLab] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AlexLab] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AlexLab] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AlexLab] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AlexLab] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AlexLab] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AlexLab] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AlexLab] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AlexLab] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AlexLab] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AlexLab] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AlexLab] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AlexLab] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AlexLab] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AlexLab] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AlexLab] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AlexLab] SET  MULTI_USER 
GO
ALTER DATABASE [AlexLab] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AlexLab] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AlexLab] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AlexLab] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [AlexLab]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[UniqueID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [int] NULL,
	[StartDate] [smalldatetime] NULL,
	[EndDate] [smalldatetime] NULL,
	[AllDay] [bit] NULL,
	[Subject] [nvarchar](50) NULL,
	[Location] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[Label] [int] NULL,
	[ResourceID] [int] NULL,
	[ResourceIDs] [nvarchar](max) NULL,
	[ReminderInfo] [nvarchar](max) NULL,
	[RecurrenceInfo] [nvarchar](max) NULL,
	[CustomField1] [nvarchar](max) NULL,
	[RoomId] [int] NULL,
	[CourseId] [int] NULL,
	[PaidMoney] [decimal](18, 2) NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[IsClose] [bit] NULL,
	[CourseTypeId] [int] NULL,
	[ClientId] [int] NULL,
	[StudentBookMoney] [decimal](18, 2) NULL,
	[CoursePrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[UniqueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](50) NULL,
	[ClientPhone] [nvarchar](50) NULL,
	[ClientNationalId] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClientWorkSpace]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientWorkSpace](
	[ClientWorkSpaceId] [int] IDENTITY(1,1) NOT NULL,
	[ClientWorkSpaceName] [nvarchar](50) NULL,
	[ClientWorkSpacePhone] [nvarchar](50) NULL,
	[ClientWorkSpaceNationalId] [nvarchar](50) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_ClientWorkSpace] PRIMARY KEY CLUSTERED 
(
	[ClientWorkSpaceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseStudent]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseStudent](
	[CourseStudentId] [int] IDENTITY(1,1) NOT NULL,
	[CourseStudentName] [nvarchar](50) NULL,
	[CourseStudentNationalId] [nvarchar](50) NULL,
	[UniqueID] [int] NULL,
	[BookMoney] [decimal](18, 2) NULL,
	[CoursePrice] [decimal](18, 2) NULL,
	[PaidMoney] [decimal](18, 2) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_CourseStudent] PRIMARY KEY CLUSTERED 
(
	[CourseStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CourseType]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseType](
	[CourseTypeId] [int] IDENTITY(1,1) NOT NULL,
	[CourseTypeDesc] [nvarchar](50) NULL,
 CONSTRAINT [PK_CourseType] PRIMARY KEY CLUSTERED 
(
	[CourseTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Expences]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expences](
	[ExpencesId] [int] IDENTITY(1,1) NOT NULL,
	[ExpencesTypeId] [int] NULL,
	[ExpencesDate] [datetime] NULL,
	[ExpencesValue] [decimal](18, 2) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Expences_1] PRIMARY KEY CLUSTERED 
(
	[ExpencesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExpencesType]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpencesType](
	[ExpencesTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ExpencesDesc] [nvarchar](50) NULL,
 CONSTRAINT [PK_Expences] PRIMARY KEY CLUSTERED 
(
	[ExpencesTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeId] [int] NULL,
	[ClientWorkSpaceId] [int] NULL,
	[AppointmentId] [int] NULL,
	[PaymentValue] [decimal](18, 2) NULL,
	[PaymentDate] [datetime] NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaymentType]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[PaymentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PaymentTypeDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Resources]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resources](
	[UniqueID] [int] IDENTITY(1,1) NOT NULL,
	[ResourceID] [int] NOT NULL,
	[ResourceName] [nvarchar](50) NULL,
	[Color] [int] NULL,
	[Image] [image] NULL,
	[CustomField1] [nvarchar](max) NULL,
 CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED 
(
	[UniqueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[RoomDesc] [nvarchar](50) NULL,
	[HourPrice] [decimal](18, 2) NULL,
	[Notes] [nvarchar](50) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Safe]    Script Date: 9/23/2018 12:02:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Safe](
	[SafeId] [int] IDENTITY(1,1) NOT NULL,
	[OpenDate] [datetime] NULL,
	[OpenValue] [decimal](18, 2) NULL,
	[CurrentValue] [decimal](18, 2) NULL,
	[CloseDate] [datetime] NULL,
	[CloseValue] [decimal](18, 2) NULL,
	[IsClose] [bit] NULL,
 CONSTRAINT [PK_Safe] PRIMARY KEY CLUSTERED 
(
	[SafeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [AlexLab] SET  READ_WRITE 
GO
