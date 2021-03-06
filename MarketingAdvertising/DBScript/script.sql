USE [master]
GO
/****** Object:  Database [MarketingAdvertising]    Script Date: 9/16/2018 1:24:04 PM ******/
CREATE DATABASE [MarketingAdvertising] ON  PRIMARY 
( NAME = N'MarketingAdvertising', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\MarketingAdvertising.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MarketingAdvertising_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\MarketingAdvertising_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MarketingAdvertising] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MarketingAdvertising].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MarketingAdvertising] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET ARITHABORT OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MarketingAdvertising] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MarketingAdvertising] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MarketingAdvertising] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MarketingAdvertising] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MarketingAdvertising] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MarketingAdvertising] SET  MULTI_USER 
GO
ALTER DATABASE [MarketingAdvertising] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MarketingAdvertising] SET DB_CHAINING OFF 
GO
USE [MarketingAdvertising]
GO
/****** Object:  Table [dbo].[CustomerInfo]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerInfo](
	[intCustomId] [int] IDENTITY(1,1) NOT NULL,
	[txtCustomerFirstName] [varchar](50) NOT NULL,
	[txtCustomerLastName] [varchar](50) NOT NULL,
	[txtCellNumber] [varchar](50) NULL,
	[txtEmailId] [varchar](100) NULL,
 CONSTRAINT [PK_CustomerInfo] PRIMARY KEY CLUSTERED 
(
	[intCustomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DeviceInfo]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DeviceInfo](
	[intDeviceId] [int] IDENTITY(1,1) NOT NULL,
	[txtDeviceMacId] [varchar](100) NOT NULL,
	[txtAddressLine1] [varchar](100) NOT NULL,
	[txtAddressLine2] [varchar](50) NULL,
	[txtCity] [varchar](50) NULL,
	[txtState] [varchar](50) NULL,
	[txtCountry] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DeviceInfo] PRIMARY KEY CLUSTERED 
(
	[intDeviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginInfo]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginInfo](
	[intLoginId] [int] IDENTITY(1,1) NOT NULL,
	[txtEmailId] [varchar](200) NOT NULL,
	[txtPassword] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoginInfo] PRIMARY KEY CLUSTERED 
(
	[intLoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SlotInfo]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SlotInfo](
	[intSlotId] [int] IDENTITY(1,1) NOT NULL,
	[dtDate] [date] NOT NULL,
	[dtFrom] [datetime] NOT NULL,
	[dtTo] [datetime] NOT NULL,
	[txtDeviceMacId] [varchar](100) NOT NULL,
	[intCustomerId] [int] NOT NULL,
	[txtAdPath] [varchar](500) NOT NULL,
 CONSTRAINT [PK_SlotInfo] PRIMARY KEY CLUSTERED 
(
	[intSlotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[SlotInfo]  WITH CHECK ADD  CONSTRAINT [FK_SlotInfo_SlotInfo] FOREIGN KEY([intSlotId])
REFERENCES [dbo].[SlotInfo] ([intSlotId])
GO
ALTER TABLE [dbo].[SlotInfo] CHECK CONSTRAINT [FK_SlotInfo_SlotInfo]
GO
/****** Object:  StoredProcedure [dbo].[spInsertCustomerDetails]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		@Author,,Name>
-- Create date: @Create Date,,>
-- Description:	@Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertCustomerDetails]
	
	@txtCustomerFirstName varchar(50),
	@txtCustomerLastName varchar(50),
	@txtCellNumber varchar(50),
	@txtEmailId varchar(100)
AS
BEGIN
	INSERT INTO [dbo].[CustomerInfo]
           ([txtCustomerFirstName]
           ,[txtCustomerLastName]
           ,[txtCellNumber]
           ,[txtEmailId])
     VALUES
           (@txtCustomerFirstName, 
           @txtCustomerLastName, 
           @txtCellNumber,
           @txtEmailId)



END

GO
/****** Object:  StoredProcedure [dbo].[spInsertDeviceDetails]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertDeviceDetails] 
	@txtDeviceMacId varchar(100),
	@txtAddressLine1 varchar(100),
	@txtAddressLine2 varchar(50),
	@txtCity varchar(50),
	@txtState varchar(50),
	@txtCountry varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [dbo].[DeviceInfo]
           ([txtDeviceMacId]
           ,[txtAddressLine1]
           ,[txtAddressLine2]
           ,[txtCity]
           ,[txtState]
           ,[txtCountry])
     VALUES
           (@txtDeviceMacId,
		   @txtAddressLine1,
		   @txtAddressLine2,
		   @txtCity,
		   @txtState,
		   @txtCountry
           )
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertLogin]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertLogin]
	@Emailid varchar(200),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	

INSERT INTO [dbo].[LoginInfo]
           ([txtEmailId]
           ,[txtPassword])
     VALUES
           (@EmailId, @Password)

END

GO
/****** Object:  StoredProcedure [dbo].[spInsertSlotInfo]    Script Date: 9/16/2018 1:24:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		@Author,,Name>
-- Create date: @Create Date,,>
-- Description:	@Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertSlotInfo] 
	@dtDate date,
	@dtFrom datetime,
	@dtTo datetime,
	@txtDeviceMacId varchar(100),
	@intCustomerId int,
	@txtAdPath varchar(500)
AS
BEGIN
	INSERT INTO [dbo].[SlotInfo]
           ([dtDate]
           ,[dtFrom]
           ,[dtTo]
           ,[txtDeviceMacId]
           ,[intCustomerId]
           ,[txtAdPath])
     VALUES
           (@dtDate
           ,@dtFrom
           ,@dtTo
           ,@txtDeviceMacId
           ,@intCustomerId
           ,@txtAdPath)
END

GO
USE [master]
GO
ALTER DATABASE [MarketingAdvertising] SET  READ_WRITE 
GO
