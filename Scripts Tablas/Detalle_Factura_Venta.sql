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

/****** Object:  Table [dbo].[Detalle_Factura_Venta]    Script Date: 13/10/2017 5:04:39 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_Factura_Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero_Factura] [varchar](50) NOT NULL,
	[CodBarras_Producto] [varchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_Total] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Factura_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_Factura_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Compra_Factura_Venta] FOREIGN KEY([Numero_Factura])
REFERENCES [dbo].[Factura_Venta] ([Numero_Factura])
GO

ALTER TABLE [dbo].[Detalle_Factura_Venta] CHECK CONSTRAINT [FK_Detalle_Factura_Compra_Factura_Venta]
GO

ALTER TABLE [dbo].[Detalle_Factura_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Compra_Producto] FOREIGN KEY([CodBarras_Producto])
REFERENCES [dbo].[Producto] ([Codigo_Barras])
GO

ALTER TABLE [dbo].[Detalle_Factura_Venta] CHECK CONSTRAINT [FK_Detalle_Factura_Compra_Producto]
GO

