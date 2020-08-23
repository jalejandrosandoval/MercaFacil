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

/****** Object:  Table [dbo].[Detalle_Producto]    Script Date: 13/10/2017 5:04:51 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalle_Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Producto] [varchar](50) NOT NULL,
	[Fecha_Vencimiento] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Detalle_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Detalle_Producto]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Producto_Producto] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Producto] ([Codigo_Barras])
GO

ALTER TABLE [dbo].[Detalle_Producto] CHECK CONSTRAINT [FK_Detalle_Producto_Producto]
GO

