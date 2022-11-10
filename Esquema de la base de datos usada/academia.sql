USE [master]
GO

/****** Object:  Database [Academia]    Script Date: 11/6/2022 17:29:46 ******/
CREATE DATABASE [Academia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'academia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'academia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\academia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Academia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Academia] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Academia] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Academia] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Academia] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Academia] SET ARITHABORT OFF 
GO

ALTER DATABASE [Academia] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [Academia] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Academia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Academia] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Academia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Academia] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Academia] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Academia] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Academia] SET  ENABLE_BROKER 
GO

ALTER DATABASE [Academia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Academia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Academia] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Academia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Academia] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Academia] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Academia] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Academia] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Academia] SET  MULTI_USER 
GO

ALTER DATABASE [Academia] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Academia] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Academia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Academia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Academia] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Academia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Academia] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Academia] SET  READ_WRITE 
GO

