USE [PastebinLike]
GO

/****** Object:  Table [dbo].[tb_Pastebin]    Script Date: 09/07/2019 18:02:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_Pastebin](
	[Id] [varchar](40) NOT NULL,
	[CreationDate] [datetime2](7) NULL,
	[ExpirationDate] [datetime2](7) NULL,
	[ObjectKey] [varchar](40) NULL,
	[Title] [varchar](50) NULL,
 CONSTRAINT [PK_tb_Pastebin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

