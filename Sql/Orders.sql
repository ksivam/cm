
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [date] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SalespersonID] [int] NOT NULL,
	[NumberOfUnits] [int] NOT NULL,
	[CostOfUnit] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Orders] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Customer_Orders]
GO

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Salesperson_Orders] FOREIGN KEY([SalespersonID])
REFERENCES [dbo].[Salesperson] ([SalespersonID])
GO

ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Salesperson_Orders]
GO


