/****** Object:  Table [dbo].[ItemMaster]    Script Date: 11/22/2012 22:36:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ItemMaster]
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 11/22/2012 22:36:58 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[userinfo]') AND type in (N'U'))
DROP TABLE [dbo].[userinfo]
GO
/****** Object:  Table [dbo].[userinfo]    Script Date: 11/22/2012 22:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[userinfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[userinfo](
	[username] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[password] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
END
GO
INSERT [dbo].[userinfo] ([username], [password]) VALUES (N'p                   ', N'p                   ')
INSERT [dbo].[userinfo] ([username], [password]) VALUES (N'pritesh             ', N'gandhi              ')
/****** Object:  Table [dbo].[ItemMaster]    Script Date: 11/22/2012 22:36:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemMaster](
	[itemcode] [int] NULL,
	[itemname] [nchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[quantity] [int] NULL,
	[reorderlevel] [int] NULL
)
END
GO
INSERT [dbo].[ItemMaster] ([itemcode], [itemname], [quantity], [reorderlevel]) VALUES (1, N'mobile              ', 2, 1)
INSERT [dbo].[ItemMaster] ([itemcode], [itemname], [quantity], [reorderlevel]) VALUES (2, N'sim                 ', 2, 3)
