USE [master]
GO
/****** Object:  Database [GestionActividadFisica]    Script Date: 5/09/2024 7:43:59 a. m. ******/
CREATE DATABASE [GestionActividadFisica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionActividadFisica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GestionActividadFisica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionActividadFisica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GestionActividadFisica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionActividadFisica] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionActividadFisica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionActividadFisica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionActividadFisica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionActividadFisica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionActividadFisica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionActividadFisica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET RECOVERY FULL 
GO
ALTER DATABASE [GestionActividadFisica] SET  MULTI_USER 
GO
ALTER DATABASE [GestionActividadFisica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionActividadFisica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionActividadFisica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionActividadFisica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionActividadFisica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionActividadFisica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GestionActividadFisica', N'ON'
GO
ALTER DATABASE [GestionActividadFisica] SET QUERY_STORE = OFF
GO
USE [GestionActividadFisica]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CondicionesEmocionales]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CondicionesEmocionales](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CondicionesEmocionales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluaciones]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluaciones](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPersona] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[AntecendenteDiabetes] [bit] NOT NULL,
	[AntecendenteCancer] [bit] NOT NULL,
	[IdCiudad] [int] NOT NULL,
	[Peso] [decimal](18, 2) NOT NULL,
	[Talla] [decimal](18, 2) NOT NULL,
	[IdCondicionEmocional] [int] NOT NULL,
 CONSTRAINT [PK_Evaluaciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [varchar](50) NOT NULL,
	[SegundoNombre] [varchar](50) NULL,
	[PrimerApellido] [varchar](50) NOT NULL,
	[SegundoApellido] [varchar](50) NULL,
	[IdTipoDocumento] [int] NOT NULL,
	[NumeroDocumento] [nvarchar](50) NOT NULL,
	[IdSexo] [int] NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexos]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexos](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sexos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposDocumento]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposDocumento](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDocumento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 5/09/2024 7:43:59 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[Clave] [nvarchar](50) NOT NULL,
	[IdPersona] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Sexos] ([Id], [Nombre]) VALUES (1, N'Femenino')
INSERT [dbo].[Sexos] ([Id], [Nombre]) VALUES (2, N'Masculino')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Personas]    Script Date: 5/09/2024 7:43:59 a. m. ******/
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [IX_Personas] UNIQUE NONCLUSTERED 
(
	[IdTipoDocumento] ASC,
	[NumeroDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Usuarios]    Script Date: 5/09/2024 7:43:59 a. m. ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [IX_Usuarios] UNIQUE NONCLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personas] ADD  CONSTRAINT [DF_Pacientes_NumeroDocumento]  DEFAULT ('0000000000') FOR [NumeroDocumento]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_Ciudades] FOREIGN KEY([IdCiudad])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_Ciudades]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_CondicionesEmocionales] FOREIGN KEY([IdCiudad])
REFERENCES [dbo].[CondicionesEmocionales] ([Id])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_CondicionesEmocionales]
GO
ALTER TABLE [dbo].[Evaluaciones]  WITH CHECK ADD  CONSTRAINT [FK_Evaluaciones_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([Id])
GO
ALTER TABLE [dbo].[Evaluaciones] CHECK CONSTRAINT [FK_Evaluaciones_Personas]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Sexos] FOREIGN KEY([IdSexo])
REFERENCES [dbo].[Sexos] ([Id])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_Sexos]
GO
ALTER TABLE [dbo].[Personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_TiposDocumento] FOREIGN KEY([IdTipoDocumento])
REFERENCES [dbo].[TiposDocumento] ([Id])
GO
ALTER TABLE [dbo].[Personas] CHECK CONSTRAINT [FK_Personas_TiposDocumento]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Personas] FOREIGN KEY([IdPersona])
REFERENCES [dbo].[Personas] ([Id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Personas]
GO
USE [master]
GO
ALTER DATABASE [GestionActividadFisica] SET  READ_WRITE 
GO
