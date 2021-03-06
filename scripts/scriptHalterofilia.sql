USE [msCloudExpertsbd]
GO
/****** Object:  Table [dbo].[Competencia]    Script Date: 16/06/2022 2:38:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competencia](
	[Cod_Competencia] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Deportista] [int] NOT NULL,
	[Cod_Modalidad] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Competencia] PRIMARY KEY CLUSTERED 
(
	[Cod_Competencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deportista]    Script Date: 16/06/2022 2:38:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deportista](
	[Cod_Deportista] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Deportista] [nvarchar](250) NOT NULL,
	[Cod_pais] [int] NOT NULL,
 CONSTRAINT [PK_Deportista] PRIMARY KEY CLUSTERED 
(
	[Cod_Deportista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modalidad]    Script Date: 16/06/2022 2:38:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modalidad](
	[Cod_Modalidad] [int] IDENTITY(1,1) NOT NULL,
	[Nom_modalidad] [nvarchar](250) NULL,
 CONSTRAINT [PK_Modalidad] PRIMARY KEY CLUSTERED 
(
	[Cod_Modalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 16/06/2022 2:38:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[Cod_pais] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Pais] [nvarchar](200) NULL,
 CONSTRAINT [PK_Pais] PRIMARY KEY CLUSTERED 
(
	[Cod_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Competencia]  WITH CHECK ADD  CONSTRAINT [FK_Competencia_Deportista] FOREIGN KEY([Cod_Deportista])
REFERENCES [dbo].[Deportista] ([Cod_Deportista])
GO
ALTER TABLE [dbo].[Competencia] CHECK CONSTRAINT [FK_Competencia_Deportista]
GO
ALTER TABLE [dbo].[Competencia]  WITH CHECK ADD  CONSTRAINT [FK_Competencia_Modalidad] FOREIGN KEY([Cod_Modalidad])
REFERENCES [dbo].[Modalidad] ([Cod_Modalidad])
GO
ALTER TABLE [dbo].[Competencia] CHECK CONSTRAINT [FK_Competencia_Modalidad]
GO
ALTER TABLE [dbo].[Deportista]  WITH CHECK ADD  CONSTRAINT [FK_Deportista_Pais] FOREIGN KEY([Cod_pais])
REFERENCES [dbo].[Pais] ([Cod_pais])
GO
ALTER TABLE [dbo].[Deportista] CHECK CONSTRAINT [FK_Deportista_Pais]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCompetenciaList]    Script Date: 16/06/2022 2:38:08 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SP_GetCompetenciaList] as
Begin
 
SELECT Competencia.Cod_Competencia,Competencia.Cod_Deportista,Competencia.Cod_Modalidad,Pais.Nom_Pais,Deportista.Nom_Deportista,Modalidad.Nom_modalidad,Competencia.Cantidad 
from [dbo].[Competencia] inner join Deportista ON Deportista.Cod_Deportista=Competencia.Cod_Deportista
inner join Pais ON Pais.Cod_pais=Deportista.Cod_pais
inner join Modalidad ON Modalidad.Cod_Modalidad=Competencia.Cod_Modalidad
End
GO
