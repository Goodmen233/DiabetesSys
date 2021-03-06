USE [Diabetes]
GO
/****** Object:  Table [dbo].[t_admin]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_admin](
	[ano] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[age] [int] NULL,
	[sex] [varchar](50) NULL,
	[phone] [varchar](50) NOT NULL,
	[email] [varchar](255) NULL,
	[password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_t_admin] PRIMARY KEY CLUSTERED 
(
	[ano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_diagnosis]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_diagnosis](
	[digno] [int] IDENTITY(1,1) NOT NULL,
	[pno] [int] NOT NULL,
	[dno] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[time] [datetime] NULL,
	[description] [varchar](255) NULL,
 CONSTRAINT [PK_t_diagnosis] PRIMARY KEY CLUSTERED 
(
	[digno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_doctor]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_doctor](
	[dno] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[age] [int] NULL,
	[sex] [varchar](50) NULL,
	[phone] [varchar](50) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[identification] [bit] NOT NULL,
	[patientsNum] [int] NULL,
 CONSTRAINT [PK_t_doctor] PRIMARY KEY CLUSTERED 
(
	[dno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_glycemicIndex]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_glycemicIndex](
	[pno] [int] NOT NULL,
	[value] [decimal](18, 2) NOT NULL,
	[time] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_patient]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_patient](
	[pno] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](255) NOT NULL,
	[age] [int] NULL,
	[sex] [varchar](6) NULL,
	[phone] [varchar](11) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[attendingDoctor] [int] NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_patient] PRIMARY KEY CLUSTERED 
(
	[pno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[t_prescription]    Script Date: 2021/7/1 17:42:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[t_prescription](
	[digno] [int] NOT NULL,
	[medicine] [varchar](255) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[t_admin] ON 

INSERT [dbo].[t_admin] ([ano], [name], [age], [sex], [phone], [email], [password]) VALUES (5, N'CCB                                                                                                                                                                                                                                                            ', 23, N'male  ', N'22222222222', N'841306289@                                                                                                                                                                                                                                                     ', N'333')
INSERT [dbo].[t_admin] ([ano], [name], [age], [sex], [phone], [email], [password]) VALUES (8, N'WCK                                                                                                                                                                                                                                                            ', 23, N'male  ', N'11111111111', NULL, N'333')
INSERT [dbo].[t_admin] ([ano], [name], [age], [sex], [phone], [email], [password]) VALUES (9, N'PJY                                                                                                                                                                                                                                                            ', 23, N'male  ', N'33333333333', NULL, N'333')
SET IDENTITY_INSERT [dbo].[t_admin] OFF
GO
SET IDENTITY_INSERT [dbo].[t_diagnosis] ON 

INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (1, 1, 1, N'一级', CAST(N'2021-06-28T12:12:12.000' AS DateTime), N'再接再励')
INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (2, 1, 1, N'一级', CAST(N'2021-06-28T11:11:11.000' AS DateTime), N'再来一次')
INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (3, 4, 0, N'一级', CAST(N'2021-06-29T03:25:18.857' AS DateTime), N'好好学习')
INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (4, 4, 0, N'三级', CAST(N'2021-06-29T15:16:22.323' AS DateTime), N'好好休息')
INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (5, 1, 0, N'一级', CAST(N'2021-06-29T15:18:48.560' AS DateTime), N'好好休息')
INSERT [dbo].[t_diagnosis] ([digno], [pno], [dno], [type], [time], [description]) VALUES (6, 4, 0, N'三级', CAST(N'2021-06-29T15:27:02.107' AS DateTime), N'好好休息，太难太难')
SET IDENTITY_INSERT [dbo].[t_diagnosis] OFF
GO
SET IDENTITY_INSERT [dbo].[t_doctor] ON 

INSERT [dbo].[t_doctor] ([dno], [name], [age], [sex], [phone], [password], [identification], [patientsNum]) VALUES (4, N'华佗', 98, N'male', N'12345678955', N'123456', 1, 3)
INSERT [dbo].[t_doctor] ([dno], [name], [age], [sex], [phone], [password], [identification], [patientsNum]) VALUES (5, N'认证任', 56, N'男', N'12345678920', N'456', 0, 4)
INSERT [dbo].[t_doctor] ([dno], [name], [age], [sex], [phone], [password], [identification], [patientsNum]) VALUES (6, N'认证one', 12, N'male', N'12312312311', N'123', 0, 2)
INSERT [dbo].[t_doctor] ([dno], [name], [age], [sex], [phone], [password], [identification], [patientsNum]) VALUES (7, N'认证two', 12, N'male', N'12312312313', N'123', 0, 0)
INSERT [dbo].[t_doctor] ([dno], [name], [age], [sex], [phone], [password], [identification], [patientsNum]) VALUES (8, N'医生one', 12, N'male', N'66666666666', N'666', 1, 0)
SET IDENTITY_INSERT [dbo].[t_doctor] OFF
GO
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(32.00 AS Decimal(18, 2)), CAST(N'2021-06-21T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(32.00 AS Decimal(18, 2)), CAST(N'2021-06-22T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(45.00 AS Decimal(18, 2)), CAST(N'2021-06-23T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(65.00 AS Decimal(18, 2)), CAST(N'2021-06-24T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(23.00 AS Decimal(18, 2)), CAST(N'2021-06-25T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (6, CAST(45.00 AS Decimal(18, 2)), CAST(N'2021-06-26T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (4, CAST(46.10 AS Decimal(18, 2)), CAST(N'2021-06-29T03:03:59.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (1, CAST(50.00 AS Decimal(18, 2)), CAST(N'2021-06-27T12:12:12.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (11, CAST(45.00 AS Decimal(18, 2)), CAST(N'2021-06-29T03:24:53.000' AS DateTime))
INSERT [dbo].[t_glycemicIndex] ([pno], [value], [time]) VALUES (12, CAST(445.00 AS Decimal(18, 2)), CAST(N'2021-06-29T03:29:24.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[t_patient] ON 

INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (1, N'xiaohong', 23, N'female', N'####', N'123', 1, N'一级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (3, N'floodstar', 78, N'male', N'####', N'123456', 4, N'一级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (4, N'小明', 45, N'female', N'12345678999', N'333', 4, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (6, N'分配one', 3, N'male', N'78978978978', N'789', 5, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (7, N'分配two', 3, N'male', N'78978978977', N'789', 6, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (8, N'分配three', 3, N'male', N'78978978979', N'789', 5, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (9, N'分配four', 12, N'male', N'78978978974', N'789', 6, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (10, N'分配five', 12, N'male', N'78978978975', N'789', 4, N'三级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (11, N'测试', 65, N'male', N'99999999999', N'555', 5, N'一级')
INSERT [dbo].[t_patient] ([pno], [name], [age], [sex], [phone], [password], [attendingDoctor], [type]) VALUES (12, N'测试one', 12, N'male', N'55555555555', N'555', 5, N'三级')
SET IDENTITY_INSERT [dbo].[t_patient] OFF
GO
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (1, N'胰岛素*100')
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (2, N'胰岛素')
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (3, N'胰岛素*new')
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (4, N'胰岛素')
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (5, N'胰岛素')
INSERT [dbo].[t_prescription] ([digno], [medicine]) VALUES (6, N'胰岛素')
GO
ALTER TABLE [dbo].[t_glycemicIndex]  WITH CHECK ADD  CONSTRAINT [FK_t_glycemicIndex_t_patient] FOREIGN KEY([pno])
REFERENCES [dbo].[t_patient] ([pno])
GO
ALTER TABLE [dbo].[t_glycemicIndex] CHECK CONSTRAINT [FK_t_glycemicIndex_t_patient]
GO
ALTER TABLE [dbo].[t_prescription]  WITH CHECK ADD  CONSTRAINT [FK_t_prescription_t_diagnosis] FOREIGN KEY([digno])
REFERENCES [dbo].[t_diagnosis] ([digno])
GO
ALTER TABLE [dbo].[t_prescription] CHECK CONSTRAINT [FK_t_prescription_t_diagnosis]
GO
