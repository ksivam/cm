﻿
CREATE TABLE [dbo].[Salesperson](
	[SalespersonID] [int] NOT NULL,
	[Name] [varchar](max) NOT NULL,
	[Age] [int] NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_Salesperson] PRIMARY KEY CLUSTERED 
(
	[SalespersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

