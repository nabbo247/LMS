USE [master]
GO
/****** Object:  Database [LMSDB]    Script Date: 1/29/2019 3:53:55 PM ******/
CREATE DATABASE [LMSDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LMSDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\LMSDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LMSDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\LMSDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LMSDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LMSDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LMSDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LMSDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LMSDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LMSDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LMSDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LMSDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LMSDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [LMSDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LMSDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LMSDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LMSDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LMSDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LMSDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LMSDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LMSDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LMSDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LMSDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LMSDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LMSDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LMSDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LMSDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LMSDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LMSDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LMSDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LMSDB] SET  MULTI_USER 
GO
ALTER DATABASE [LMSDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LMSDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LMSDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LMSDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [LMSDB]
GO
/****** Object:  StoredProcedure [dbo].[AssignmentAndTrackingActivateDeactivate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AssignmentAndTrackingActivateDeactivate]
	@trackingId int,	
	@isActive bit	

AS
BEGIN	

	SET NOCOUNT ON;

	update tblAssignmentAndTracking set isActive=@isActive 	where  trackingId=@trackingId
	
END

GO
/****** Object:  StoredProcedure [dbo].[AssignmentAndTrackingGetAllInactive]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AssignmentAndTrackingGetAllInactive] 
	@trackingId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblAssignmentAndTracking where trackingId=@trackingId and isActive=0
END

GO
/****** Object:  StoredProcedure [dbo].[CourseActivateDeactivate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CourseActivateDeactivate]
	@courseId int,	
	@isActive bit	

AS
BEGIN	

	SET NOCOUNT ON;

	update tblCourses set 	isActive=@isActive 	where  courseId=@courseId
	
END

GO
/****** Object:  StoredProcedure [dbo].[CourseAdd]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CourseAdd]
	@courseName nvarchar(50),
	@courseDetails nvarchar(50),
	@courseCategory nvarchar(50),
	@coursePath nvarchar(50),
	@isActive bit,
	@createdBy int,
	@createdOn date,
	@tenantId int

AS
BEGIN	
declare @status bit
	SET NOCOUNT ON;
	if not exists (select courseId from tblCourses where courseName=@courseName)
	begin
    INSERT INTO [dbo].[tblCourses]
           ([courseName]
           ,[courseDetails]
           ,[courseCategory]
           ,[coursePath]
           ,[isActive]
           ,[createdBy]
           ,[createdOn]
           ,[tenantId])
     VALUES
           (@courseName
           ,@courseDetails
           ,@courseCategory
           ,@coursePath
           ,@isActive
           ,@createdBy
           ,getdate()
           ,@tenantId)

		   set @status=1
     end
		 else
			 begin

			 set @status=0
	 
			 end
	 return @status
END

GO
/****** Object:  StoredProcedure [dbo].[CourseGetAllInactive]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CourseGetAllInactive] 
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblCourses where tenantId=@tenantId and isActive=0
END

GO
/****** Object:  StoredProcedure [dbo].[CourseGetById]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CourseGetById]
	@courseId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblCourses where courseId=@courseId
END

GO
/****** Object:  StoredProcedure [dbo].[CoursesGetAll]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CoursesGetAll] 
	@tenantId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblCourses where tenantId=@tenantId and isActive=1
END

GO
/****** Object:  StoredProcedure [dbo].[CourseUpdate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CourseUpdate]
	@courseId int,
	@courseName nvarchar(50),
	@courseDetails nvarchar(50),
	@courseCategory nvarchar(50),
	@coursePath nvarchar(50),
	@isActive bit,
	@createdBy int,
	@tenantId int

AS
BEGIN	

	SET NOCOUNT ON;

	update tblCourses set courseName=@courseName,
	courseDetails=@courseDetails,
	courseCategory=@courseCategory,
	coursePath=@coursePath,
	isActive=@isActive,
	createdOn=getdate(),
	tenantId=@tenantId
	where  courseId=@courseId
	
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesActivateDeactivate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NotificationTemplatesActivateDeactivate]
	@templateId int,	
	@isActive bit	

AS
BEGIN	

	SET NOCOUNT ON;

	update tblNotificationTemplates set isActive=@isActive 	where  templateId=@templateId
	
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesAdd]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NotificationTemplatesAdd]
	@templateName nvarchar(50),
	@templateSubject nvarchar(500),
	@templateDescription ntext,	
	@isActive bit,
	@createdBy int,
	@createdOn date,
	@tenantId int

AS
BEGIN	
declare @status bit
	SET NOCOUNT ON;
	if not exists (select templateId from tblNotificationTemplates where templateName=@templateName)
	begin
    INSERT INTO [dbo].[tblNotificationTemplates]
           ([templateName]
           ,[templateSubject]
           ,[templateDescription]           
           ,[isActive]
           ,[createdBy]
           ,[createdOn]
           ,[tenantId])
     VALUES
           (@templateName
           ,@templateSubject
           ,@templateDescription           
           ,@isActive
           ,@createdBy
           ,getdate()
           ,@tenantId)

		   set @status=1
     end
		 else
			 begin

			 set @status=0
	 
			 end
	 return @status
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesGetAll]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NotificationTemplatesGetAll] 
	@tenantId int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblNotificationTemplates where tenantId=@tenantId and isActive=1
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesGetAllInactive]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NotificationTemplatesGetAllInactive] 
	@templateId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblNotificationTemplates where templateId=@templateId and isActive=0
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesGetById]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Dinesh>
-- Create date: <Create 01/29/2019,,>
-- Description:	<To get notification details by id and tenant id,,>
-- =============================================
CREATE PROCEDURE [dbo].[NotificationTemplatesGetById]
	@templateId int,
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblNotificationTemplates where tenantId=@tenantId and templateId=@templateId
END

GO
/****** Object:  StoredProcedure [dbo].[NotificationTemplatesUpdate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[NotificationTemplatesUpdate]
	@templateId int,
	@templateName nvarchar(50),
	@templateSubject nvarchar(500),
	@templateDescription ntext,	
	@isActive bit,
	@createdBy int,
	@createdOn date,
	@tenantId int

AS
BEGIN	

	SET NOCOUNT ON;

	update tblNotificationTemplates set templateName=@templateName,
	templateSubject=@templateSubject,
	templateDescription=@templateDescription,	
	isActive=@isActive,
	createdOn=getdate(),
	tenantId=@tenantId
	where  templateId=@templateId
	
END

GO
/****** Object:  StoredProcedure [dbo].[TenantActivateDeactivate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TenantActivateDeactivate]
	@tenantId int,	
	@isActive bit	

AS
BEGIN	

	SET NOCOUNT ON;

	update tblTenant set 	isActive=@isActive 	where  tenantId=@tenantId
	
END

GO
/****** Object:  StoredProcedure [dbo].[TenantAdd]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TenantAdd]
	@tenantName nvarchar(50),
	@tenantDomain nvarchar(50),
	@activationFrom date,
	@activationTo date,
	@isActive bit,
	@createdBy int,
	@noOfUserAllowed int

AS
BEGIN	
declare @status bit
	SET NOCOUNT ON;
	if not exists (select tenantId from tblTenant where tenantDomain=@tenantDomain)
	begin
    INSERT INTO [dbo].[tblTenant]
           ([tenantName]
           ,[tenantDomain]
           ,[activationFrom]
           ,[activationTo]
           ,[isActive]
           ,[createdBy]
           ,[createdOn]
           ,[noOfUserAllowed])
     VALUES
           (@tenantName
           ,@tenantDomain
           ,@activationFrom
           ,@activationTo
           ,@isActive
           ,@createdBy
           ,getdate()
           ,@noOfUserAllowed)

		   set @status=1
     end
		 else
			 begin

			 set @status=0
	 
			 end
	 return @status
END

GO
/****** Object:  StoredProcedure [dbo].[TenantGetAll]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TenantGetAll] 
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblTenant where isActive=1
END

GO
/****** Object:  StoredProcedure [dbo].[TenantGetAllInactive]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TenantGetAllInactive] 
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblTenant where isActive=0
END

GO
/****** Object:  StoredProcedure [dbo].[TenantGetById]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TenantGetById]
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblTenant where tenantId=@tenantId
END

GO
/****** Object:  StoredProcedure [dbo].[TenantUpdate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[TenantUpdate]
	@tenantId int,
	@tenantName nvarchar(50),
	@tenantDomain nvarchar(50),
	@activationFrom date,
	@activationTo date,
	@isActive bit,
	@createdBy int,
	@noOfUserAllowed int = null

AS
BEGIN	

	SET NOCOUNT ON;

	update tblTenant set tenantName=@tenantName,
	tenantDomain=@tenantDomain,
	activationFrom=@activationFrom,
	activationTo=@activationTo,
	isActive=@isActive,
	noOfUserAllowed=@noOfUserAllowed
	where  tenantId=@tenantId
	
END

GO
/****** Object:  StoredProcedure [dbo].[UserActivateDeactivate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UserActivateDeactivate]
	@userId int,	
	@isActive bit	

AS
BEGIN	

	SET NOCOUNT ON;

	update tblUser set 	isActive=@isActive 	where  userId=@userId
	
END

GO
/****** Object:  StoredProcedure [dbo].[UserAdd]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UserAdd]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@emailId nvarchar(50),
	@password nvarchar(50),
	@DOB date,
	@contactNo nvarchar(50),
	@isActive bit,
	@createdBy int,
	@tenantId int,
	@roleId int

AS
BEGIN	
declare @status bit
	SET NOCOUNT ON;
	if not exists (select userId from tblUser where emailId=@emailId)
	begin
    INSERT INTO [dbo].[tblUser]
           ([firstName]
           ,[lastName]
           ,[emailId]
           ,[password]
           ,[contactNo]
           ,[isActive]
		   ,[createdBy]
           ,[createdOn]
           ,[tenantId]
		   ,[roleId])
     VALUES
           (@firstName
           ,@lastName
           ,@emailId
           ,@password
           ,@contactNo
           ,@isActive
		   ,@createdBy
           ,getdate()
           ,@tenantId
		   ,@roleId)

		   set @status=1
     end
		 else
			 begin

			 set @status=0
	 
			 end
	 return @status
END

GO
/****** Object:  StoredProcedure [dbo].[UserGetAll]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UserGetAll] 
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblUser where tenantId=@tenantId and isActive=1
END

GO
/****** Object:  StoredProcedure [dbo].[UserGetAllInactive]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UserGetAllInactive] 
	@tenantId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblUser where tenantId=@tenantId and isActive=0
END

GO
/****** Object:  StoredProcedure [dbo].[UserGetById]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UserGetById]
	@userId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    select * from tblUser where userId=@userId
END

GO
/****** Object:  StoredProcedure [dbo].[UserUpdate]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UserUpdate]
	@userId int,
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@emailId nvarchar(50),
	@password nvarchar(50),
	@DOB date,
	@contactNo nvarchar(50),
	@isActive bit,
	@createdBy int,
	@tenantId int,
	@roleId int

AS
BEGIN	
declare @status bit
	SET NOCOUNT ON;
	if exists (select userId from tblUser where emailId=@emailId and userId=@userId)
	begin
    UPDATE [dbo].[tblUser] SET
           [firstName] = @firstName
           ,[lastName] = @lastName
           ,[emailId] = @emailId
           ,[password] = @password
		   ,[DOB] = @DOB
           ,[contactNo] = @contactNo
           ,[isActive] = @isActive
		   ,[createdBy] = @createdBy
           ,[createdOn] = getdate()
           ,[tenantId] = @tenantId
		   ,[roleId] = @roleId
     where userId=@userId
		 set @status=1
     end
		 else
			 begin

			 set @status=0
	 
			 end
	 return @status
END

GO
/****** Object:  Table [dbo].[tblAssignmentAndTracking]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAssignmentAndTracking](
	[trackingId] [int] IDENTITY(1,1) NOT NULL,
	[courseId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[assignedDate] [date] NULL,
	[validFrom] [date] NULL,
	[validTo] [date] NULL,
	[statusId] [int] NOT NULL,
	[createdBy] [int] NULL,
	[createdOn] [date] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_tblAssignmentAndTracking] PRIMARY KEY CLUSTERED 
(
	[trackingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCourses]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourses](
	[courseId] [int] IDENTITY(1,1) NOT NULL,
	[courseName] [nvarchar](50) NOT NULL,
	[courseDetails] [nvarchar](250) NULL,
	[courseCategory] [nvarchar](50) NULL,
	[coursePath] [nvarchar](250) NULL,
	[isActive] [bit] NULL,
	[createdBy] [int] NULL,
	[createdOn] [date] NULL,
	[tenantId] [int] NOT NULL,
 CONSTRAINT [PK_tblCourses] PRIMARY KEY CLUSTERED 
(
	[courseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNotificationTemplates]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNotificationTemplates](
	[templateId] [int] IDENTITY(1,1) NOT NULL,
	[templateName] [nvarchar](50) NOT NULL,
	[templateSubject] [nvarchar](500) NOT NULL,
	[templateDescription] [ntext] NOT NULL,
	[isActive] [bit] NULL,
	[createdBy] [int] NULL,
	[createdOn] [date] NULL,
	[tenantId] [int] NULL,
 CONSTRAINT [PK_NotificationTemplates] PRIMARY KEY CLUSTERED 
(
	[templateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[statusId] [int] NOT NULL,
	[statusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[statusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTenant]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTenant](
	[tenantId] [int] IDENTITY(1,1) NOT NULL,
	[tenantName] [nvarchar](50) NOT NULL,
	[tenantDomain] [nvarchar](50) NOT NULL,
	[activationFrom] [date] NULL,
	[activationTo] [date] NULL,
	[isActive] [bit] NULL,
	[createdBy] [int] NOT NULL,
	[createdOn] [date] NOT NULL,
	[noOfUserAllowed] [int] NULL,
 CONSTRAINT [PK_tblTenant] PRIMARY KEY CLUSTERED 
(
	[tenantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NULL,
	[lastName] [nvarchar](50) NULL,
	[emailId] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[DOB] [date] NULL,
	[contactNo] [nvarchar](50) NULL,
	[isActive] [bit] NULL,
	[createdBy] [int] NOT NULL,
	[createdOn] [date] NULL,
	[tenantId] [int] NOT NULL,
	[roleId] [int] NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUserRoles]    Script Date: 1/29/2019 3:53:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserRoles](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblUserRoles] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tblAssignmentAndTracking]  WITH CHECK ADD  CONSTRAINT [FK_tblAssignmentAndTracking_tblStatus] FOREIGN KEY([statusId])
REFERENCES [dbo].[tblStatus] ([statusId])
GO
ALTER TABLE [dbo].[tblAssignmentAndTracking] CHECK CONSTRAINT [FK_tblAssignmentAndTracking_tblStatus]
GO
ALTER TABLE [dbo].[tblUser]  WITH CHECK ADD  CONSTRAINT [FK_tblUser_tblUserRoles] FOREIGN KEY([roleId])
REFERENCES [dbo].[tblUserRoles] ([roleId])
GO
ALTER TABLE [dbo].[tblUser] CHECK CONSTRAINT [FK_tblUser_tblUserRoles]
GO
USE [master]
GO
ALTER DATABASE [LMSDB] SET  READ_WRITE 
GO
