USE [master]
GO

/****** Object:  Database [OnlineCourseDatabase]    Script Date: 09/07/2016 08:54:01 ******/
CREATE DATABASE [OnlineCourseDatabase] ON  PRIMARY 
( NAME = N'OnlineCourseDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\OnlineCourseDatabase.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OnlineCourseDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\OnlineCourseDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [OnlineCourseDatabase] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineCourseDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [OnlineCourseDatabase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET ARITHABORT OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [OnlineCourseDatabase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [OnlineCourseDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [OnlineCourseDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET  DISABLE_BROKER 
GO

ALTER DATABASE [OnlineCourseDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [OnlineCourseDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [OnlineCourseDatabase] SET  READ_WRITE 
GO

ALTER DATABASE [OnlineCourseDatabase] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [OnlineCourseDatabase] SET  MULTI_USER 
GO

ALTER DATABASE [OnlineCourseDatabase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [OnlineCourseDatabase] SET DB_CHAINING OFF 
GO

