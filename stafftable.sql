USE [healthcare]
GO

/****** Object:  Table [dbo].[StaffList]    Script Date: 07-06-2025 20:44:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffList](
	[StaffListID] [int] NOT NULL,
	[Name] [nvarchar](255) NULL,
	[StaffID] [nvarchar](50) NULL,
	[RoleID] [int] NULL,
	[ContactNo] [nvarchar](50) NULL,
	[EmailID] [nvarchar](255) NULL,
	[ShiftPreference] [nvarchar](10) NULL,
 CONSTRAINT [PK_StaffList] PRIMARY KEY CLUSTERED 
(
	[StaffListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

