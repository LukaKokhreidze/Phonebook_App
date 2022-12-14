USE [Phonebook_DB]
GO
/****** Object:  Table [dbo].[Contact_TB]    Script Date: 11/16/2022 2:42:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact_TB](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Surname] [varchar](50) NOT NULL,
	[Phone_Number] [numeric](18, 0) NOT NULL,
	[Secondary_Number] [numeric](18, 0) NULL,
	[Email] [varchar](50) NULL,
	[Addres] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contact_TB] ON 

INSERT [dbo].[Contact_TB] ([Id], [Name], [Surname], [Phone_Number], [Secondary_Number], [Email], [Addres]) VALUES (3, N'asdasd', N'dsadsa', CAST(585858 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'asd', N'dsa')
INSERT [dbo].[Contact_TB] ([Id], [Name], [Surname], [Phone_Number], [Secondary_Number], [Email], [Addres]) VALUES (4, N'asdasd', N'dsadsa', CAST(585858 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'asd', N'dsa')
INSERT [dbo].[Contact_TB] ([Id], [Name], [Surname], [Phone_Number], [Secondary_Number], [Email], [Addres]) VALUES (5, N'asdasd', N'dsadsa', CAST(585858 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'asd', N'dsa')
SET IDENTITY_INSERT [dbo].[Contact_TB] OFF
GO
