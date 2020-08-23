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

/****** Object:  Table [dbo].[Devolucion_Venta]    Script Date: 13/10/2017 5:05:02 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Devolucion_Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero_Factura] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_Devolucionn_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Devolucion_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Venta_Factura_Venta] FOREIGN KEY([Numero_Factura])
REFERENCES [dbo].[Factura_Venta] ([Numero_Factura])
GO

ALTER TABLE [dbo].[Devolucion_Venta] CHECK CONSTRAINT [FK_Devolucion_Venta_Factura_Venta]
GO

