USE [GameDb]
GO
/****** Object:  Table [dbo].[BanGames]    Script Date: 2024/1/10 下午 02:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanGames](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Member1] [int] NOT NULL,
	[Member2] [int] NOT NULL,
	[Content] [nvarchar](200) NOT NULL,
	[Date] [datetime] NOT NULL,
	[AdminId] [int] NOT NULL,
	[StatusTime] [datetime] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_BanGames] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BanMembers]    Script Date: 2024/1/10 下午 02:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanMembers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Member1] [int] NOT NULL,
	[Member2] [int] NOT NULL,
	[Content] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[AdminId] [int] NOT NULL,
	[StatusTime] [datetime] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_BanMembers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 2024/1/10 下午 02:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cards]    Script Date: 2024/1/10 下午 02:20:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[Bank] [int] NOT NULL,
	[Card] [char](10) NOT NULL,
	[Date] [char](4) NOT NULL,
	[Security] [char](3) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[LastName] [nvarchar](10) NULL,
 CONSTRAINT [PK_Cards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
