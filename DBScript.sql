USE [master]
GO
/****** Object:  Database [proj4]    Script Date: 4/17/2024 10:38:07 PM ******/
CREATE DATABASE [proj4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proj4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MYNEWSERVER\MSSQL\DATA\proj4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proj4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MYNEWSERVER\MSSQL\DATA\proj4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [proj4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proj4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proj4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proj4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proj4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proj4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proj4] SET ARITHABORT OFF 
GO
ALTER DATABASE [proj4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proj4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proj4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proj4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proj4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proj4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proj4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proj4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proj4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proj4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [proj4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proj4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proj4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proj4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proj4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proj4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proj4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proj4] SET RECOVERY FULL 
GO
ALTER DATABASE [proj4] SET  MULTI_USER 
GO
ALTER DATABASE [proj4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proj4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proj4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proj4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proj4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proj4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'proj4', N'ON'
GO
ALTER DATABASE [proj4] SET QUERY_STORE = OFF
GO
USE [proj4]
GO
/****** Object:  Table [dbo].[gameHist]    Script Date: 4/17/2024 10:38:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gameHist](
	[PlayerID] [int] IDENTITY(1,1) NOT NULL,
	[PlayerName] [nchar](10) NULL,
	[NumberOfMoves] [int] NULL,
 CONSTRAINT [PK_gameHist] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [proj4] SET  READ_WRITE 
GO
