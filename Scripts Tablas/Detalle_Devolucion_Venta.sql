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

/****** Object:  Table [dbo].[Detalle_Devolucion_Venta]    Script Date: 13/10/2017 5:04:09 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_Devolucion_Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CodBarras_Producto] [varchar](50) NOT NULL,
	[Id_Devolucion] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Devolucion_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_Devolucion_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Devolucion_Venta_Devolucion_Venta] FOREIGN KEY([Id_Devolucion])
REFERENCES [dbo].[Devolucion_Venta] ([Id])
GO

ALTER TABLE [dbo].[Detalle_Devolucion_Venta] CHECK CONSTRAINT [FK_Detalle_Devolucion_Venta_Devolucion_Venta]
GO

ALTER TABLE [dbo].[Detalle_Devolucion_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Venta_Producto] FOREIGN KEY([CodBarras_Producto])
REFERENCES [dbo].[Producto] ([Codigo_Barras])
GO

ALTER TABLE [dbo].[Detalle_Devolucion_Venta] CHECK CONSTRAINT [FK_Devolucion_Venta_Producto]
GO

