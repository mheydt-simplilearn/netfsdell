USE [School]
GO

/****** Object:  Table [dbo].[Class]    Script Date: 4/19/2021 11:11:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[ID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Email] [varchar](75) NOT NULL,
	[Class] [varchar](5) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Class](
	[ID] [int] NOT NULL,
	[Name] [varchar](5) NOT NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Subject](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL
) ON [PRIMARY]
GO