USE [master]
GO
/****** Object:  Database [SoftwareCompany]    Script Date: 17/06/2019 11:25:02 PM ******/
CREATE DATABASE [SoftwareCompany]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SoftwareCompany', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SoftwareCompany.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SoftwareCompany_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SoftwareCompany_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SoftwareCompany] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoftwareCompany].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoftwareCompany] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SoftwareCompany] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SoftwareCompany] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SoftwareCompany] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SoftwareCompany] SET ARITHABORT OFF 
GO
ALTER DATABASE [SoftwareCompany] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SoftwareCompany] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SoftwareCompany] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SoftwareCompany] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SoftwareCompany] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SoftwareCompany] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SoftwareCompany] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SoftwareCompany] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SoftwareCompany] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SoftwareCompany] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SoftwareCompany] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SoftwareCompany] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SoftwareCompany] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SoftwareCompany] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SoftwareCompany] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SoftwareCompany] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SoftwareCompany] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SoftwareCompany] SET RECOVERY FULL 
GO
ALTER DATABASE [SoftwareCompany] SET  MULTI_USER 
GO
ALTER DATABASE [SoftwareCompany] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SoftwareCompany] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SoftwareCompany] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SoftwareCompany] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SoftwareCompany] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SoftwareCompany', N'ON'
GO
ALTER DATABASE [SoftwareCompany] SET QUERY_STORE = OFF
GO
USE [SoftwareCompany]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SoftwareCompany]
GO
/****** Object:  Table [dbo].[EducationDegrees]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationDegrees](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[EnName] [nvarchar](200) NOT NULL,
	[ArName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_EducationDegrees_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeProjects]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeProjects](
	[EmployeeId] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[FatherName] [nvarchar](200) NOT NULL,
	[MotherName] [nvarchar](200) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
	[PhoneNumber] [nvarchar](10) NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[PersonalPhoto] [image] NULL,
	[ExperinceYears] [int] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[EducationDegreeId] [int] NOT NULL,
 CONSTRAINT [PK_Employees_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Unique_Employees_UserId] UNIQUE NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgrammingLanguages]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgrammingLanguages](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ProgrammingLanguages_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectComments]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectComments](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjectId] [uniqueidentifier] NOT NULL,
	[Comment] [nvarchar](600) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_ProjectComments_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[Id] [uniqueidentifier] NOT NULL,
	[ProjectName] [nvarchar](200) NOT NULL,
	[ProgrammingLanguageId] [int] NOT NULL,
	[ProjectTypeId] [int] NOT NULL,
	[CustomerName] [nvarchar](200) NULL,
	[StartDate] [date] NOT NULL,
	[DeliverDate] [date] NOT NULL,
 CONSTRAINT [PK_Projects_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectTypes]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTypes](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[Type] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ProjectTypes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[EnName] [nvarchar](200) NOT NULL,
	[ArName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_PositionTypes_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17/06/2019 11:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Users_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees] ADD  CONSTRAINT [Default_Employees_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ProjectComments] ADD  CONSTRAINT [Default_ProjectComments_Default]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ProjectComments] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Projects] ADD  CONSTRAINT [Default_Projects_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [Default_Users_Id]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[EmployeeProjects]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProjects_Employees_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeProjects] CHECK CONSTRAINT [FK_EmployeeProjects_Employees_EmployeeId]
GO
ALTER TABLE [dbo].[EmployeeProjects]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeProjects_Projects_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeProjects] CHECK CONSTRAINT [FK_EmployeeProjects_Projects_ProjectId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_EducationLevel_EducationLevelId] FOREIGN KEY([EducationDegreeId])
REFERENCES [dbo].[EducationDegrees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_EducationLevel_EducationLevelId]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Users_UserId]
GO
ALTER TABLE [dbo].[ProjectComments]  WITH CHECK ADD  CONSTRAINT [FK_ProjectComments_Projects_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectComments] CHECK CONSTRAINT [FK_ProjectComments_Projects_ProjectId]
GO
ALTER TABLE [dbo].[ProjectComments]  WITH CHECK ADD  CONSTRAINT [FK_ProjectComments_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectComments] CHECK CONSTRAINT [FK_ProjectComments_Users_UserId]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_ProgrammingLanguages_ProgrammingLanguageId] FOREIGN KEY([ProgrammingLanguageId])
REFERENCES [dbo].[ProgrammingLanguages] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_ProgrammingLanguages_ProgrammingLanguageId]
GO
ALTER TABLE [dbo].[Projects]  WITH CHECK ADD  CONSTRAINT [FK_Projects_ProjectTypes_ProjectTypeId] FOREIGN KEY([ProjectTypeId])
REFERENCES [dbo].[ProjectTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Projects] CHECK CONSTRAINT [FK_Projects_ProjectTypes_ProjectTypeId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
USE [master]
GO
ALTER DATABASE [SoftwareCompany] SET  READ_WRITE 
GO
