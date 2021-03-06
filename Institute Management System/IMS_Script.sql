USE [master]
GO
/****** Object:  Database [IMS]    Script Date: 04/12/2014 15:59:53 ******/
CREATE DATABASE [IMS] ON  PRIMARY 
( NAME = N'IMS', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\IMS.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IMS_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\IMS_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IMS] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMS] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [IMS] SET ANSI_NULLS OFF
GO
ALTER DATABASE [IMS] SET ANSI_PADDING OFF
GO
ALTER DATABASE [IMS] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [IMS] SET ARITHABORT OFF
GO
ALTER DATABASE [IMS] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [IMS] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [IMS] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [IMS] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [IMS] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [IMS] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [IMS] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [IMS] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [IMS] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [IMS] SET  DISABLE_BROKER
GO
ALTER DATABASE [IMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [IMS] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [IMS] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [IMS] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [IMS] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [IMS] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [IMS] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [IMS] SET  READ_WRITE
GO
ALTER DATABASE [IMS] SET RECOVERY FULL
GO
ALTER DATABASE [IMS] SET  MULTI_USER
GO
ALTER DATABASE [IMS] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [IMS] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'IMS', N'ON'
GO
USE [IMS]
GO
/****** Object:  Table [dbo].[tbl_registration]    Script Date: 04/12/2014 16:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_registration](
	[Registration_Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[Contact_No] [nvarchar](50) NOT NULL,
	[DOB] [nvarchar](50) NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Qualification] [nvarchar](50) NOT NULL,
	[CourseEnroll] [nvarchar](50) NOT NULL,
	[Registration_fee] [bigint] NOT NULL,
	[Course_Durations] [nvarchar](50) NULL,
	[Course_Fees] [bigint] NULL,
	[Firstinstallment] [bigint] NULL,
	[Firstinstallmentstatus] [nvarchar](50) NULL,
	[Secondinstallment] [bigint] NULL,
	[Secondinstallmentstatus] [nvarchar](50) NULL,
	[datetime] [datetime] NULL,
 CONSTRAINT [PK_tbl_registration] PRIMARY KEY CLUSTERED 
(
	[Registration_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_registration] ([Registration_Id], [Name], [Address], [Contact_No], [DOB], [Gender], [Qualification], [CourseEnroll], [Registration_fee], [Course_Durations], [Course_Fees], [Firstinstallment], [Firstinstallmentstatus], [Secondinstallment], [Secondinstallmentstatus], [datetime]) VALUES (N'STUREG001', N'Mohan Chandra', N'satya vihar burari delhi-84', N'9560498289', N'Tuesday, June 27, 1989', N'Male', N'B.tech/BE', N'ASP .Net', 1000, N'6 Months', 8000, 5000, N'Paid', 3000, N'Paid', CAST(0x0000A30A01359F95 AS DateTime))
INSERT [dbo].[tbl_registration] ([Registration_Id], [Name], [Address], [Contact_No], [DOB], [Gender], [Qualification], [CourseEnroll], [Registration_fee], [Course_Durations], [Course_Fees], [Firstinstallment], [Firstinstallmentstatus], [Secondinstallment], [Secondinstallmentstatus], [datetime]) VALUES (N'STUREG002', N'kamal', N'delhi-90', N'88545454242', N'Monday, May 17, 1993', N'Male', N'BA', N'Networking', 1000, N'6 months', 7500, 4000, N'Not Paid', 3500, N'Not Paid', CAST(0x0000A30B00906722 AS DateTime))
/****** Object:  Table [dbo].[tbl_login]    Script Date: 04/12/2014 16:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_login](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[LastLogin] [datetime] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_login] ([UserName], [Password], [LastLogin]) VALUES (N'admin1', N'admin1', CAST(0x0000A30B00E07360 AS DateTime))
INSERT [dbo].[tbl_login] ([UserName], [Password], [LastLogin]) VALUES (N'admin2', N'admin2', CAST(0x0000A2ED012FB8FE AS DateTime))
/****** Object:  Table [dbo].[tbl_courseinfo]    Script Date: 04/12/2014 16:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_courseinfo](
	[CourseID] [nvarchar](50) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[CourseDurations] [nvarchar](50) NOT NULL,
	[CourseFees] [bigint] NOT NULL,
	[Firstinstallment] [bigint] NOT NULL,
	[Secondinstallment] [bigint] NOT NULL,
 CONSTRAINT [PK_tbl_courseinfo] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE001', N'ASP .Net', N'8 Months', 8000, 5000, 3000)
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE002', N'Java Programming', N'1 Years', 15000, 8000, 7000)
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE003', N'Networking', N'6 months', 7500, 4000, 3500)
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE004', N'PHP', N'8 months ', 12000, 7000, 5000)
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE005', N'SEO', N'4 months', 6000, 4000, 2000)
INSERT [dbo].[tbl_courseinfo] ([CourseID], [CourseName], [CourseDurations], [CourseFees], [Firstinstallment], [Secondinstallment]) VALUES (N'COURSE006', N'Advance Java', N'8 months', 15000, 10000, 5000)
/****** Object:  Default [DF_tbl_registration_datetime]    Script Date: 04/12/2014 16:00:01 ******/
ALTER TABLE [dbo].[tbl_registration] ADD  CONSTRAINT [DF_tbl_registration_datetime]  DEFAULT (getdate()) FOR [datetime]
GO
/****** Object:  Default [DF_tbl_login_LastLogin]    Script Date: 04/12/2014 16:00:01 ******/
ALTER TABLE [dbo].[tbl_login] ADD  CONSTRAINT [DF_tbl_login_LastLogin]  DEFAULT (getdate()) FOR [LastLogin]
GO
