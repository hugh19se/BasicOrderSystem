USE [OrderDB]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/14/2024 10:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[Forenames] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Line1] [nvarchar](50) NULL,
	[Line2] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Postcode] [nvarchar](8) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/14/2024 10:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
	[OrderPlaced] [datetime] NOT NULL,
	[OrderDelivered] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 10/14/2024 10:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatuses](
	[Status] [int] NOT NULL,
	[StatusDescription] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (1, N'ukonzel0@slate.com', N'Urbain', N'Konzel', N'Suite 21', N'Suite 92', N'Pakkat', N'FXSH')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (2, N'mschiementz1@tinyurl.com', N'Micah', N'Schiementz', N'Suite 23', N'Apt 173', N'Hacienda La Calera', N'BIRK')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (3, N'pbrundell2@google.cn', N'Pedro', N'Brundell', N'Room 362', N'PO Box 11184', N'Sedati', N'PABA')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (4, N'nashwin3@sitemeter.com', N'Nelia', N'Ashwin', N'PO Box 44206', N'20th Floor', N'HanHuang', N'RORS')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (5, N'iheadingham4@freewebs.com', N'Ingeborg', N'Headingham', N'PO Box 46804', N'15th Floor', N'Nybro', N'KHTW')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (6, N'cspencer5@princeton.edu', N'Carmella', N'Spencer', N'Suite 66', N'Room 450', N'Bánov', N'KGVT')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (7, N'dheppner6@g.co', N'Deni', N'Heppner', N'Room 52', N'12th Floor', N'Sudomerice', N'YNUB')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (8, N'asparsholt7@nifty.com', N'Ahmad', N'Sparsholt', N'Suite 8', N'PO Box 29733', N'Palmira', N'SAWD')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (9, N'ncullon8@a8.net', N'Nydia', N'Cullon', N'Suite 41', N'Suite 78', N'Leiling', N'SKRG')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (10, N'wgealle9@oakley.com', N'Wrennie', N'Gealle', N'Suite 52', N'13th Floor', N'Oi', N'EDDV')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (11, N'mpashlera@bluehost.com', N'Mattias', N'Pashler', N'Apt 443', N'Room 1101', N'Kokkini Trimithia', N'WBKW')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (12, N'ybramwichb@forbes.com', N'Yank', N'Bramwich', N'PO Box 21391', N'Suite 33', N'Carnaxide', N'SSFB')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (13, N'bfancourtc@cmu.edu', N'Ben', N'Fancourt', N'Suite 98', N'Suite 37', N'Lomé', N'MRPV')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (14, N'gmccartd@earthlink.net', N'Georgeanne', N'McCart', N'Suite 21', N'PO Box 46087', N'Mandalt', NULL)
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (15, N'hsymee@webmd.com', N'Heidi', N'Syme', N'Room 416', N'Room 1155', N'Mugumu', N'MUMJ')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (16, N'hdaelf@dropbox.com', N'Harland', N'Dael', N'Room 402', N'Suite 12', N'Tsaghveri', N'SNJK')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (17, N'nbrownriggg@thetimes.co.uk', N'Nadiya', N'Brownrigg', N'Room 896', N'PO Box 51132', N'Sawin', N'FOGK')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (18, N'tbowketth@twitter.com', N'Tandie', N'Bowkett', N'Room 73', N'19th Floor', N'Chuandao', N'YCAS')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (19, N'ajoseferi@house.gov', N'August', N'Josefer', N'Apt 283', N'Suite 87', N'Gurung', N'FAKP')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (20, N'bdegoeyj@twitpic.com', N'Benito', N'De Goey', N'2nd Floor', N'Room 116', N'Manonjaya', N'YPIR')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (21, N'omewsk@shutterfly.com', N'Ophelia', N'Mews', N'11th Floor', N'Suite 93', N'Marjayoûn', N'RPUN')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (22, N'blathanl@nhs.uk', N'Boigie', N'Lathan', N'Suite 26', N'PO Box 61535', N'Rumyantsevo', N'KCGZ')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (23, N'rgwillymm@va.gov', N'Roshelle', N'Gwillym', N'PO Box 10714', N'Apt 1299', N'Quimper', N'VYLK')
GO
INSERT [dbo].[Customers] ([CustomerID], [Email], [Forenames], [Surname], [Line1], [Line2], [City], [Postcode]) VALUES (24, N'amarchettin@mysql.com', N'Antone', N'Marchetti', N'PO Box 89140', N'12th Floor', N'Santo Tomas', N'LEBZ')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (1, 12, 1, CAST(19.55 AS Decimal(18, 2)), CAST(N'2024-08-21T19:28:21.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (2, 19, 1, CAST(9.97 AS Decimal(18, 2)), CAST(N'2024-01-15T20:05:10.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (3, 6, 1, CAST(13.94 AS Decimal(18, 2)), CAST(N'2023-07-17T07:04:13.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (4, 10, 1, CAST(11.23 AS Decimal(18, 2)), CAST(N'2023-09-04T19:09:48.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (5, 23, 2, CAST(28.95 AS Decimal(18, 2)), CAST(N'2024-06-05T18:09:05.000' AS DateTime), CAST(N'2023-03-24T03:49:45.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (6, 9, 1, CAST(22.46 AS Decimal(18, 2)), CAST(N'2024-03-29T12:52:27.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (7, 23, 2, CAST(11.96 AS Decimal(18, 2)), CAST(N'2024-09-03T12:16:00.000' AS DateTime), CAST(N'2023-04-19T16:07:34.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (8, 22, 1, CAST(4.93 AS Decimal(18, 2)), CAST(N'2023-02-16T03:08:45.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (9, 23, 1, CAST(28.03 AS Decimal(18, 2)), CAST(N'2024-01-17T05:40:34.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (10, 12, 1, CAST(11.23 AS Decimal(18, 2)), CAST(N'2024-06-10T06:06:55.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (11, 6, 1, CAST(16.95 AS Decimal(18, 2)), CAST(N'2023-05-30T12:16:15.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (12, 18, 1, CAST(8.17 AS Decimal(18, 2)), CAST(N'2023-04-23T05:03:29.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (13, 20, 1, CAST(16.80 AS Decimal(18, 2)), CAST(N'2023-03-10T15:53:44.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (14, 18, 2, CAST(9.32 AS Decimal(18, 2)), CAST(N'2024-08-24T19:49:39.000' AS DateTime), CAST(N'2023-05-05T15:04:18.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (15, 7, 1, CAST(4.08 AS Decimal(18, 2)), CAST(N'2023-12-26T02:32:24.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (16, 11, 1, CAST(7.80 AS Decimal(18, 2)), CAST(N'2023-12-16T17:39:40.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (17, 6, 1, CAST(22.57 AS Decimal(18, 2)), CAST(N'2024-07-16T05:05:33.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (18, 11, 1, CAST(28.78 AS Decimal(18, 2)), CAST(N'2023-12-31T01:55:05.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (19, 10, 1, CAST(23.66 AS Decimal(18, 2)), CAST(N'2023-11-24T03:16:14.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (20, 19, 1, CAST(8.66 AS Decimal(18, 2)), CAST(N'2023-12-03T01:07:19.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (21, 7, 2, CAST(20.15 AS Decimal(18, 2)), CAST(N'2023-12-25T20:08:07.000' AS DateTime), CAST(N'2023-10-17T12:28:36.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (22, 22, 2, CAST(2.14 AS Decimal(18, 2)), CAST(N'2023-10-30T19:25:25.000' AS DateTime), CAST(N'2024-09-12T14:24:59.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (23, 24, 1, CAST(24.53 AS Decimal(18, 2)), CAST(N'2024-04-15T02:34:44.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (24, 19, 1, CAST(2.21 AS Decimal(18, 2)), CAST(N'2023-01-03T03:02:34.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (25, 8, 1, CAST(4.37 AS Decimal(18, 2)), CAST(N'2023-10-14T04:00:52.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (26, 18, 2, CAST(6.40 AS Decimal(18, 2)), CAST(N'2023-12-11T19:22:55.000' AS DateTime), CAST(N'2024-03-29T03:38:23.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (27, 20, 1, CAST(6.78 AS Decimal(18, 2)), CAST(N'2023-11-12T20:10:57.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (28, 3, 1, CAST(1.42 AS Decimal(18, 2)), CAST(N'2024-07-24T18:01:31.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (29, 4, 2, CAST(29.16 AS Decimal(18, 2)), CAST(N'2024-02-06T08:46:02.000' AS DateTime), CAST(N'2024-04-27T00:29:45.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (30, 19, 1, CAST(15.17 AS Decimal(18, 2)), CAST(N'2023-08-01T11:57:21.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (31, 22, 1, CAST(29.79 AS Decimal(18, 2)), CAST(N'2024-02-20T08:19:21.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (32, 24, 1, CAST(17.26 AS Decimal(18, 2)), CAST(N'2024-03-20T07:58:15.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (33, 19, 1, CAST(2.32 AS Decimal(18, 2)), CAST(N'2024-01-31T19:04:40.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (34, 9, 1, CAST(26.38 AS Decimal(18, 2)), CAST(N'2023-06-25T12:10:06.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (35, 16, 1, CAST(25.22 AS Decimal(18, 2)), CAST(N'2023-08-15T08:47:22.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (36, 23, 1, CAST(2.98 AS Decimal(18, 2)), CAST(N'2024-07-17T05:18:59.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (37, 1, 2, CAST(10.34 AS Decimal(18, 2)), CAST(N'2023-11-17T12:47:18.000' AS DateTime), CAST(N'2024-08-12T01:52:01.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (38, 20, 1, CAST(24.63 AS Decimal(18, 2)), CAST(N'2023-07-30T20:45:56.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (39, 13, 1, CAST(17.28 AS Decimal(18, 2)), CAST(N'2023-10-06T05:33:12.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (40, 20, 1, CAST(28.20 AS Decimal(18, 2)), CAST(N'2024-04-14T12:29:15.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (41, 4, 1, CAST(0.53 AS Decimal(18, 2)), CAST(N'2024-02-28T13:04:19.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (42, 2, 2, CAST(27.39 AS Decimal(18, 2)), CAST(N'2024-02-13T14:15:21.000' AS DateTime), CAST(N'2023-08-24T20:02:52.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (43, 4, 1, CAST(11.42 AS Decimal(18, 2)), CAST(N'2023-07-17T14:17:40.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (44, 12, 2, CAST(1.05 AS Decimal(18, 2)), CAST(N'2023-05-15T10:53:42.000' AS DateTime), CAST(N'2023-12-25T02:53:51.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (45, 18, 1, CAST(20.93 AS Decimal(18, 2)), CAST(N'2023-07-08T16:05:40.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (46, 11, 1, CAST(23.36 AS Decimal(18, 2)), CAST(N'2024-08-21T01:51:23.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (47, 4, 1, CAST(15.63 AS Decimal(18, 2)), CAST(N'2024-08-28T04:06:16.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (48, 23, 1, CAST(21.19 AS Decimal(18, 2)), CAST(N'2024-02-03T17:58:35.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (49, 5, 1, CAST(5.97 AS Decimal(18, 2)), CAST(N'2023-01-02T13:29:54.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (50, 4, 1, CAST(29.17 AS Decimal(18, 2)), CAST(N'2023-09-03T09:51:12.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (51, 3, 1, CAST(22.62 AS Decimal(18, 2)), CAST(N'2023-06-11T08:41:56.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (52, 14, 1, CAST(10.90 AS Decimal(18, 2)), CAST(N'2024-04-17T19:38:55.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (53, 3, 1, CAST(27.83 AS Decimal(18, 2)), CAST(N'2023-10-10T21:14:44.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (54, 22, 1, CAST(1.94 AS Decimal(18, 2)), CAST(N'2024-02-09T16:44:49.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (55, 5, 2, CAST(19.31 AS Decimal(18, 2)), CAST(N'2024-03-31T16:57:25.000' AS DateTime), CAST(N'2023-03-09T09:27:36.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (56, 16, 1, CAST(4.44 AS Decimal(18, 2)), CAST(N'2024-05-30T05:27:28.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (57, 13, 1, CAST(3.53 AS Decimal(18, 2)), CAST(N'2024-02-01T13:07:34.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (58, 9, 1, CAST(8.94 AS Decimal(18, 2)), CAST(N'2024-03-28T06:44:01.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (59, 8, 1, CAST(24.92 AS Decimal(18, 2)), CAST(N'2023-12-28T17:18:54.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (60, 5, 1, CAST(11.61 AS Decimal(18, 2)), CAST(N'2024-04-02T04:42:37.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (61, 22, 1, CAST(24.09 AS Decimal(18, 2)), CAST(N'2024-09-11T04:54:58.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (62, 16, 1, CAST(18.30 AS Decimal(18, 2)), CAST(N'2024-01-22T00:51:22.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (63, 2, 1, CAST(26.30 AS Decimal(18, 2)), CAST(N'2023-09-17T07:37:22.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (64, 6, 1, CAST(1.82 AS Decimal(18, 2)), CAST(N'2023-05-31T15:50:44.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (65, 3, 1, CAST(13.76 AS Decimal(18, 2)), CAST(N'2024-04-08T03:29:33.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (66, 14, 1, CAST(6.73 AS Decimal(18, 2)), CAST(N'2024-08-09T02:49:28.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (67, 16, 1, CAST(21.29 AS Decimal(18, 2)), CAST(N'2024-07-03T15:46:09.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (68, 18, 1, CAST(11.19 AS Decimal(18, 2)), CAST(N'2023-09-20T13:37:10.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (69, 6, 1, CAST(25.35 AS Decimal(18, 2)), CAST(N'2024-02-23T12:19:56.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (70, 11, 2, CAST(26.26 AS Decimal(18, 2)), CAST(N'2024-01-14T23:26:24.000' AS DateTime), CAST(N'2024-05-12T17:05:25.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (71, 23, 1, CAST(4.25 AS Decimal(18, 2)), CAST(N'2023-01-01T09:32:12.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (72, 9, 1, CAST(5.81 AS Decimal(18, 2)), CAST(N'2024-04-14T17:49:45.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (73, 6, 1, CAST(8.17 AS Decimal(18, 2)), CAST(N'2023-03-13T22:17:20.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (74, 13, 1, CAST(3.20 AS Decimal(18, 2)), CAST(N'2023-02-16T02:50:27.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (75, 20, 1, CAST(3.67 AS Decimal(18, 2)), CAST(N'2023-11-03T03:17:28.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (76, 5, 1, CAST(2.53 AS Decimal(18, 2)), CAST(N'2024-01-28T07:47:27.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (77, 16, 2, CAST(24.16 AS Decimal(18, 2)), CAST(N'2023-11-10T12:14:16.000' AS DateTime), CAST(N'2024-07-14T02:07:20.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (78, 3, 1, CAST(2.20 AS Decimal(18, 2)), CAST(N'2024-04-17T22:40:45.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (79, 4, 1, CAST(17.38 AS Decimal(18, 2)), CAST(N'2024-01-08T21:40:37.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (80, 24, 1, CAST(5.32 AS Decimal(18, 2)), CAST(N'2023-06-27T12:22:10.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (81, 19, 1, CAST(18.35 AS Decimal(18, 2)), CAST(N'2023-12-12T15:12:46.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (82, 10, 1, CAST(14.60 AS Decimal(18, 2)), CAST(N'2024-03-12T12:23:40.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (83, 18, 1, CAST(28.56 AS Decimal(18, 2)), CAST(N'2024-07-18T19:55:22.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (84, 19, 1, CAST(27.31 AS Decimal(18, 2)), CAST(N'2023-03-17T22:03:18.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (85, 20, 1, CAST(10.76 AS Decimal(18, 2)), CAST(N'2024-08-20T23:24:08.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (86, 9, 1, CAST(26.09 AS Decimal(18, 2)), CAST(N'2024-07-29T07:57:10.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (87, 9, 1, CAST(11.52 AS Decimal(18, 2)), CAST(N'2024-10-01T19:44:29.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (88, 9, 1, CAST(25.28 AS Decimal(18, 2)), CAST(N'2023-08-03T11:50:38.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (89, 1, 1, CAST(12.88 AS Decimal(18, 2)), CAST(N'2023-04-21T18:40:52.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (90, 8, 1, CAST(12.62 AS Decimal(18, 2)), CAST(N'2023-05-03T08:04:49.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (91, 2, 2, CAST(26.38 AS Decimal(18, 2)), CAST(N'2024-06-23T05:35:52.000' AS DateTime), CAST(N'2024-09-22T14:52:20.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (92, 3, 1, CAST(14.27 AS Decimal(18, 2)), CAST(N'2023-09-02T12:51:09.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (93, 9, 1, CAST(8.89 AS Decimal(18, 2)), CAST(N'2023-07-16T00:52:49.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (94, 5, 1, CAST(22.69 AS Decimal(18, 2)), CAST(N'2023-01-31T13:10:39.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (95, 4, 1, CAST(24.02 AS Decimal(18, 2)), CAST(N'2024-07-06T13:08:55.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (96, 9, 1, CAST(0.24 AS Decimal(18, 2)), CAST(N'2023-11-15T12:40:50.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (97, 20, 1, CAST(7.42 AS Decimal(18, 2)), CAST(N'2024-03-10T22:47:59.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (98, 7, 1, CAST(15.84 AS Decimal(18, 2)), CAST(N'2023-05-14T03:33:58.000' AS DateTime), NULL)
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (99, 23, 2, CAST(4.71 AS Decimal(18, 2)), CAST(N'2024-07-18T20:11:02.000' AS DateTime), CAST(N'2024-07-22T08:11:13.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [Status], [Total], [OrderPlaced], [OrderDelivered]) VALUES (100, 4, 2, CAST(23.09 AS Decimal(18, 2)), CAST(N'2024-09-10T04:30:44.000' AS DateTime), CAST(N'2024-02-07T13:01:22.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
INSERT [dbo].[OrderStatuses] ([Status], [StatusDescription]) VALUES (1, N'Created')
GO
INSERT [dbo].[OrderStatuses] ([Status], [StatusDescription]) VALUES (2, N'Delivered')
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
/****** Object:  StoredProcedure [dbo].[GetCustomers]    Script Date: 10/14/2024 10:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomers]
AS
BEGIN
SELECT
	c.CustomerID
	, c.Email
	, c.Forenames
	, c.Surname
	, c.Line1
	, c.Line2
	, c.City
	, c.Postcode
FROM
Customers c
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrders]    Script Date: 10/14/2024 10:40:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrders]
AS
BEGIN
SELECT
	o.OrderID
	, o.CustomerID
	, o.[Status]
	, o.Total
	, o.OrderPlaced
	, o.OrderDelivered
FROM
Orders o
END
GO
