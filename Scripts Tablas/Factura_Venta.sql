/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [MercaFacil_2]
GO

/****** Object:  Table [dbo].[Factura_Venta]    Script Date: 13/10/2017 5:05:28 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Factura_Venta](
	[Numero_Factura] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cliente_Id] [int] NOT NULL,
	[Usuario_Id] [int] NOT NULL,
 CONSTRAINT [PK_Factura_Venta] PRIMARY KEY CLUSTERED 
(
	[Numero_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Factura_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Venta_Cliente] FOREIGN KEY([Cliente_Id])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Factura_Venta] CHECK CONSTRAINT [FK_Factura_Venta_Cliente]
GO

ALTER TABLE [dbo].[Factura_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Venta_Usuario] FOREIGN KEY([Usuario_Id])
REFERENCES [dbo].[Usuario] ([Id])
GO

ALTER TABLE [dbo].[Factura_Venta] CHECK CONSTRAINT [FK_Factura_Venta_Usuario]
GO

