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

/****** Object:  Table [dbo].[Telefono_Usuario]    Script Date: 13/10/2017 5:06:08 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Telefono_Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [int] NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Telefono_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Telefono_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Telefono_Usuario_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id])
GO

ALTER TABLE [dbo].[Telefono_Usuario] CHECK CONSTRAINT [FK_Telefono_Usuario_Usuario]
GO

