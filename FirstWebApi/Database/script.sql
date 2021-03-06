USE [RegisterDB]
GO
/****** Object:  Table [dbo].[TblEmployee]    Script Date: 10/24/2017 22:44:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblEmployee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_TblEmployee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TblEmployee] ON
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (1, N'Sandip Das', N'Bangalore', N'Marathalli, Bangalore-37')
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (2, N'abc', NULL, NULL)
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (3, N'abc', NULL, NULL)
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (4, N'jkl', NULL, NULL)
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (5, N'kdfhjks', N'erowiri', N'iwryuiwre')
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (7, N'fgh', N'dfg', N'wer')
INSERT [dbo].[TblEmployee] ([Id], [Name], [City], [Address]) VALUES (8, N'abc', N'def', N'ghi')
SET IDENTITY_INSERT [dbo].[TblEmployee] OFF
