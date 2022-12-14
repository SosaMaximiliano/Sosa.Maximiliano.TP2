USE [master]
GO
/****** Object:  Database [SegundoTP]    Script Date: 20/11/2022 18:37:26 ******/
CREATE DATABASE [SegundoTP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SegundoTP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SegundoTP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SegundoTP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SegundoTP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SegundoTP] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SegundoTP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SegundoTP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SegundoTP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SegundoTP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SegundoTP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SegundoTP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SegundoTP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SegundoTP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SegundoTP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SegundoTP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SegundoTP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SegundoTP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SegundoTP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SegundoTP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SegundoTP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SegundoTP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SegundoTP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SegundoTP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SegundoTP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SegundoTP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SegundoTP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SegundoTP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SegundoTP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SegundoTP] SET RECOVERY FULL 
GO
ALTER DATABASE [SegundoTP] SET  MULTI_USER 
GO
ALTER DATABASE [SegundoTP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SegundoTP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SegundoTP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SegundoTP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SegundoTP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SegundoTP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SegundoTP', N'ON'
GO
ALTER DATABASE [SegundoTP] SET QUERY_STORE = OFF
GO
USE [SegundoTP]
GO
/****** Object:  Table [dbo].[Ganadores]    Script Date: 20/11/2022 18:37:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ganadores](
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Especie] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participantes]    Script Date: 20/11/2022 18:37:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participantes](
	[id] [int] NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participantes2]    Script Date: 20/11/2022 18:37:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participantes2](
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participantes3]    Script Date: 20/11/2022 18:37:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participantes3](
	[ID] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Especie] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Ganadores] ([Nombre], [Apellido], [Especie]) VALUES (N'Jarvis', N'Fossey', N'Buteo galapagoensis')
GO
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (1, N'Tucker')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (2, N'Atalanta')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (3, N'Felike')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (4, N'Mattie')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (5, N'Tisha')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (6, N'Hilde')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (7, N'Bili')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (8, N'Fraser')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (9, N'Sydelle')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (10, N'Basia')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (11, N'Melodie')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (12, N'Cristen')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (13, N'Gilda')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (14, N'Hurlee')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (15, N'Kimberlee')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (16, N'Bradford')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (17, N'Dode')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (18, N'Baxie')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (19, N'Josefa')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (20, N'Morgen')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (21, N'Alard')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (22, N'Aimil')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (23, N'Saloma')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (24, N'Phelia')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (25, N'Gayel')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (26, N'Georges')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (27, N'Laird')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (28, N'Hermy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (29, N'Maurine')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (30, N'Emanuele')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (31, N'Cad')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (32, N'Shanta')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (33, N'Kylila')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (34, N'Jamey')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (35, N'Caressa')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (36, N'Alden')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (37, N'Janette')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (38, N'Kermy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (39, N'Scott')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (40, N'Edyth')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (41, N'Bettye')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (42, N'Vale')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (43, N'Blaine')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (44, N'Genna')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (45, N'Laurent')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (46, N'Audy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (47, N'Charlton')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (48, N'Carlin')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (49, N'Teador')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (50, N'Meade')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (51, N'Hortense')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (52, N'Radcliffe')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (53, N'Nicolais')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (54, N'Meggy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (55, N'Aland')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (56, N'Marjory')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (57, N'Sanderson')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (58, N'Inglebert')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (59, N'Clarence')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (60, N'Netty')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (61, N'Anna-diana')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (62, N'Hurley')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (63, N'Mahmoud')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (64, N'Anitra')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (65, N'Justin')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (66, N'Katharyn')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (67, N'Duane')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (68, N'Rodd')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (69, N'Johnathon')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (70, N'Anatole')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (71, N'Rozanne')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (72, N'Claude')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (73, N'Odilia')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (74, N'Stafford')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (75, N'Raf')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (76, N'Leona')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (77, N'Josy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (78, N'Aundrea')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (79, N'Alberik')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (80, N'Sonja')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (81, N'Ellen')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (82, N'Sondra')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (83, N'Swen')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (84, N'Allison')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (85, N'Hamlin')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (86, N'Averil')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (87, N'Veriee')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (88, N'Zaria')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (89, N'Noella')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (90, N'Ozzy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (91, N'Sheffy')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (92, N'Gaylor')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (93, N'Ros')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (94, N'Delcina')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (95, N'Lynne')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (96, N'Helene')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (97, N'Lisa')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (98, N'Zorah')
INSERT [dbo].[Participantes] ([id], [Nombre]) VALUES (99, N'Rochelle')
GO
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Averil')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Luigi')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Richie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Glen')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Ferguson')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Missie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Bailey')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Benjie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Parry')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Myrwyn')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Faustine')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Terrel')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Bunni')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Grant')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Sayers')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Marilyn')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Silas')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'La verne')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Chickie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Onfre')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Wilow')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Koressa')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Sibelle')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Wendell')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Mehetabel')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Buddy')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Vaughan')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Rudolfo')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Yard')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Klarrisa')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Harvey')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Tracie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Meriel')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Joli')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Solly')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Jesse')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Ramonda')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Adan')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Bethena')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Trstram')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Carrol')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Lennard')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Suzann')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Klemens')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Ximenes')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Jessey')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Lonnie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Veradis')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Crystal')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Abigale')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Joe')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Jillayne')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Valeda')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Derek')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Brandise')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Aurthur')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Pepi')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Anet')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Bertram')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Barnebas')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Lena')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Trudey')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Rona')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Kanya')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Chrissie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Juliann')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Shurwood')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Roddy')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Clio')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Beltran')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Karla')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Bentlee')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Susannah')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Dame')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Hedwiga')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Mariann')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Carolan')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Davy')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Jamima')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Albertine')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Prince')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Kariotta')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Colin')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Hayes')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Tyson')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Auberon')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Ellwood')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Korry')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Jannel')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Nelle')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Opaline')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Goldy')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Enrique')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Claudetta')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Minnaminnie')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Laverna')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Tove')
INSERT [dbo].[Participantes2] ([Nombre]) VALUES (N'Amby')
GO
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (1, N'Jarvis', N'Fossey', N'Buteo galapagoensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (2, N'Grissel', N'Lepper', N'Ceryle rudis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (3, N'Aurore', N'Benneton', N'Macaca mulatta')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (4, N'Oralle', N'Pillman', N'Sterna paradisaea')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (5, N'Leon', N'Wagg', N'Canis mesomelas')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (6, N'Lottie', N'Font', N'Sula nebouxii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (7, N'Rhoda', N'Warrior', N'Macaca mulatta')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (8, N'Bartie', N'Tomasicchio', N'Bucephala clangula')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (9, N'Buckie', N'Ranns', N'Felis chaus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (10, N'Eulalie', N'Bach', N'Alouatta seniculus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (11, N'Fowler', N'Snuggs', N'Creagrus furcatus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (12, N'Aubry', N'Durrance', N'Hyaena hyaena')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (13, N'Annmaria', N'Temby', N'Sula nebouxii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (14, N'Leah', N'Dincey', N'Chloephaga melanoptera')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (15, N'Wernher', N'Dunham', N'Cordylus giganteus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (16, N'Dot', N'Ezele', N'Diomedea irrorata')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (17, N'Peria', N'Nasey', N'Equus hemionus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (18, N'Daffi', N'Longfield', N'Trachyphonus vaillantii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (19, N'Lonnard', N'Badam', N'Sciurus niger')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (20, N'Dorine', N'Lampett', N'Grus rubicundus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (21, N'Codee', N'O''Devey', N'Oreotragus oreotragus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (22, N'Gawen', N'Newlan', N'Tiliqua scincoides')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (23, N'Nessy', N'Riba', N'Trichoglossus chlorolepidotus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (24, N'Karlotta', N'Batty', N'Larus sp.')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (25, N'Evin', N'Forsbey', N'Choloepus hoffmani')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (26, N'Griff', N'Hierro', N'Alcelaphus buselaphus cokii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (27, N'Ermentrude', N'Cristobal', N'Phascogale tapoatafa')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (28, N'Brittney', N'Kemwal', N'Passer domesticus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (29, N'Teressa', N'Priter', N'Columba palumbus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (30, N'Betty', N'Tweedie', N'Alligator mississippiensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (31, N'Noland', N'Winkless', N'Alligator mississippiensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (32, N'Christin', N'Salvadore', N'Estrilda erythronotos')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (33, N'Erroll', N'Force', N'Streptopelia senegalensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (34, N'Dominica', N'Nutley', N'Vulpes chama')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (35, N'Ryley', N'Kitson', N'Echimys chrysurus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (36, N'Dame', N'McKane', N'Corvus brachyrhynchos')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (37, N'Selle', N'Korpolak', N'Milvus migrans')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (38, N'Juliane', N'Packington', N'Tursiops truncatus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (39, N'Lucita', N'Veronique', N'Phalacrocorax albiventer')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (40, N'Violette', N'Balaam', N'Numida meleagris')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (41, N'Hazel', N'Beardsell', N'Semnopithecus entellus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (42, N'Preston', N'Haggeth', N'Dendrocitta vagabunda')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (43, N'Garth', N'Giovannilli', N'Meleagris gallopavo')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (44, N'Dal', N'Bloor', N'Ornithorhynchus anatinus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (45, N'Krissy', N'Tyreman', N'Pteropus rufus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (46, N'Dyna', N'Piwell', N'Trichechus inunguis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (47, N'Mallory', N'Shortan', N'Meleagris gallopavo')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (48, N'Dreddy', N'Rewbottom', N'Macropus robustus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (49, N'Kathe', N'Kneeland', N'Choloepus hoffmani')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (50, N'Romonda', N'Bech', N'Varanus sp.')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (51, N'Ivette', N'Doberer', N'Sarcorhamphus papa')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (52, N'Anneliese', N'McCuaig', N'Upupa epops')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (53, N'Cassaundra', N'Girling', N'Isoodon obesulus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (54, N'Cori', N'Speares', N'Ourebia ourebi')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (55, N'Kimmi', N'Melan', N'Varanus salvator')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (56, N'Konrad', N'Di Biasio', N'Macropus eugenii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (57, N'Alexis', N'Maria', N'Felis chaus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (58, N'Zachery', N'Guichard', N'Laniarius ferrugineus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (59, N'Ernestus', N'Cavet', N'Paradoxurus hermaphroditus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (60, N'Yehudit', N'Oller', N'Phascolarctos cinereus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (61, N'Chicky', N'Hirth', N'Capra ibex')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (62, N'Nestor', N'Zavattieri', N'Pseudalopex gymnocercus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (63, N'Gael', N'Lezemere', N'Nycticorax nycticorax')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (64, N'Hewet', N'Landrieu', N'Laniarius ferrugineus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (65, N'Barrie', N'Woodberry', N'Milvus migrans')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (66, N'Carolynn', N'Tomlins', N'Felis silvestris lybica')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (67, N'Laural', N'Lines', N'Falco mexicanus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (68, N'Nickolaus', N'Dudden', N'Alligator mississippiensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (69, N'Jeane', N'Baldry', N'Actophilornis africanus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (70, N'Burr', N'Lathwell', N'Haliaeetus leucocephalus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (71, N'Errick', N'Betonia', N'Cynictis penicillata')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (72, N'Charline', N'Stanger', N'Otaria flavescens')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (73, N'Niven', N'Corner', N'Macropus rufogriseus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (74, N'Deirdre', N'Lorimer', N'Podargus strigoides')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (75, N'Svend', N'Presley', N'Chloephaga melanoptera')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (76, N'Valera', N'Scone', N'Macaca radiata')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (77, N'Zarah', N'Livens', N'Vulpes chama')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (78, N'Ina', N'Dubock', N'Ara macao')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (79, N'Syd', N'Twoohy', N'Diomedea irrorata')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (80, N'Delphinia', N'Gresser', N'Aonyx capensis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (81, N'Peggi', N'Sheardown', N'Capra ibex')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (82, N'Sybil', N'Westcott', N'Corvus albicollis')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (83, N'Terrie', N'Lie', N'Bucephala clangula')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (84, N'Syd', N'Iorizzo', N'Varanus salvator')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (85, N'Glad', N'Hrinchishin', N'Choloepus hoffmani')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (86, N'Darcee', N'Goodrum', N'Chlidonias leucopterus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (87, N'Obadiah', N'Crayker', N'Lepilemur rufescens')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (88, N'Sheffy', N'Eddis', N'Tadorna tadorna')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (89, N'Carena', N'Veel', N'unavailable')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (90, N'Aila', N'Alibone', N'Dipodomys deserti')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (91, N'Rodi', N'Bedo', N'Varanus sp.')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (92, N'Nathalie', N'Craigmyle', N'Equus burchelli')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (93, N'Creight', N'Marrian', N'Pan troglodytes')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (94, N'Langsdon', N'Edwins', N'Aquila chrysaetos')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (95, N'Tori', N'Korda', N'Lepus townsendii')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (96, N'Margi', N'Vuitton', N'Phaethon aethereus')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (97, N'Whitby', N'Matthesius', N'Ovis ammon')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (98, N'Ingamar', N'Muneely', N'Speotyte cuniculata')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (99, N'Dickie', N'Cowope', N'Myrmecophaga tridactyla')
INSERT [dbo].[Participantes3] ([ID], [Nombre], [Apellido], [Especie]) VALUES (100, N'Mercedes', N'Georgel', N'Chauna torquata')
GO
USE [master]
GO
ALTER DATABASE [SegundoTP] SET  READ_WRITE 
GO
