USE [master]
GO
/****** Object:  Database [SWP391]    Script Date: 15-Mar-22 4:18:12 PM ******/
CREATE DATABASE [SWP391]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SWP391', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SWP391.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SWP391_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SWP391_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SWP391] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SWP391].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SWP391] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SWP391] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SWP391] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SWP391] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SWP391] SET ARITHABORT OFF 
GO
ALTER DATABASE [SWP391] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SWP391] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SWP391] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SWP391] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SWP391] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SWP391] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SWP391] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SWP391] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SWP391] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SWP391] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SWP391] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SWP391] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SWP391] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SWP391] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SWP391] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SWP391] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SWP391] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SWP391] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SWP391] SET  MULTI_USER 
GO
ALTER DATABASE [SWP391] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SWP391] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SWP391] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SWP391] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SWP391] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SWP391] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SWP391] SET QUERY_STORE = OFF
GO
USE [SWP391]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttemptDetaileds]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttemptDetaileds](
	[AttemptId] [varchar](10) NOT NULL,
	[QuestionBankId] [varchar](10) NOT NULL,
	[UserAnswer] [text] NULL,
 CONSTRAINT [PK_AttemptDetaileds] PRIMARY KEY CLUSTERED 
(
	[AttemptId] ASC,
	[QuestionBankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Attempts]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attempts](
	[AttemptId] [varchar](10) NOT NULL,
	[TotalMark] [float] NOT NULL,
	[StartTime] [datetime2](7) NULL,
	[UserId] [nvarchar](450) NULL,
	[QuizId] [varchar](10) NULL,
 CONSTRAINT [PK_Attempts] PRIMARY KEY CLUSTERED 
(
	[AttemptId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[BlogId] [varchar](10) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[Brief] [nvarchar](500) NULL,
	[Content] [text] NULL,
	[VideoURL] [text] NULL,
	[SlideId] [int] NOT NULL,
	[ThumbnailURL] [text] NULL,
	[CreatedDate] [datetime2](7) NULL,
	[StatusId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryValue] [varchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentId] [varchar](10) NOT NULL,
	[CommentBody] [text] NULL,
	[BlogId] [varchar](10) NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseOwners]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseOwners](
	[CourseOwnerId] [nvarchar](450) NOT NULL,
	[CourseId] [varchar](10) NOT NULL,
	[PurchaseTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_CourseOwners] PRIMARY KEY CLUSTERED 
(
	[CourseOwnerId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[CourseId] [varchar](10) NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
	[Description] [text] NULL,
	[ShortDescription] [varchar](500) NULL,
	[ThumbnailURL] [text] NULL,
	[Title] [varchar](255) NULL,
	[Price] [float] NOT NULL,
	[SlideId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[LessonId] [varchar](10) NOT NULL,
	[LessonName] [varchar](255) NULL,
	[LessonOrder] [int] NOT NULL,
	[Script] [text] NULL,
	[VideoURL] [text] NULL,
	[TopicId] [varchar](10) NULL,
 CONSTRAINT [PK_Lessons] PRIMARY KEY CLUSTERED 
(
	[LessonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PricePackages]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PricePackages](
	[PricePackageId] [int] IDENTITY(1,1) NOT NULL,
	[PricePackageName] [varchar](255) NULL,
	[Description] [text] NULL,
	[Price] [float] NOT NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_PricePackages] PRIMARY KEY CLUSTERED 
(
	[PricePackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionBanks]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionBanks](
	[QuestionId] [varchar](10) NOT NULL,
	[Answer] [text] NULL,
	[Content] [text] NULL,
	[Explanation] [text] NULL,
	[Weight] [float] NOT NULL,
	[QuizLevelId] [int] NOT NULL,
	[CourseId] [varchar](10) NULL,
	[OptionA] [nvarchar](max) NULL,
	[OptionB] [nvarchar](max) NULL,
	[OptionC] [nvarchar](max) NULL,
	[OptionD] [nvarchar](max) NULL,
	[StatusId] [int] NOT NULL,
 CONSTRAINT [PK_QuestionBanks] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuizLevels]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuizLevels](
	[QuizLevelId] [int] IDENTITY(1,1) NOT NULL,
	[QuizLevelName] [varchar](255) NULL,
 CONSTRAINT [PK_QuizLevels] PRIMARY KEY CLUSTERED 
(
	[QuizLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuizQuestions]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuizQuestions](
	[QuizId] [varchar](10) NOT NULL,
	[QuestionId] [varchar](10) NOT NULL,
 CONSTRAINT [PK_QuizQuestions] PRIMARY KEY CLUSTERED 
(
	[QuizId] ASC,
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuizTypes]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuizTypes](
	[QuizTypeId] [int] IDENTITY(1,1) NOT NULL,
	[QuizTypeName] [varchar](255) NULL,
 CONSTRAINT [PK_QuizTypes] PRIMARY KEY CLUSTERED 
(
	[QuizTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quizzes]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quizzes](
	[QuizId] [varchar](10) NOT NULL,
	[Description] [text] NULL,
	[Duration] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[QuestionNum] [int] NOT NULL,
	[TopicId] [varchar](10) NULL,
	[QuizTypeId] [int] NOT NULL,
	[QuizLevelId] [int] NOT NULL,
	[CourseId] [varchar](10) NULL,
 CONSTRAINT [PK_Quizzes] PRIMARY KEY CLUSTERED 
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slides]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slides](
	[SlideId] [int] IDENTITY(1,1) NOT NULL,
	[SlideValue] [varchar](255) NULL,
 CONSTRAINT [PK_Slides] PRIMARY KEY CLUSTERED 
(
	[SlideId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusValue] [varchar](255) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Topics](
	[TopicId] [varchar](10) NOT NULL,
	[TopicOrder] [int] NOT NULL,
	[TopicName] [varchar](255) NULL,
	[CourseId] [varchar](10) NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserPricePackages]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPricePackages](
	[UserId] [nvarchar](450) NOT NULL,
	[PricePackageId] [int] NOT NULL,
	[RemainingDay] [int] NOT NULL,
	[SubcribeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserPricePackages] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[PricePackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[FullName] [nvarchar](255) NULL,
	[Address] [text] NULL,
	[ProfilePictureURL] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 15-Mar-22 4:18:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220313132355_ChangeTopicKeys', N'5.0.14')
GO
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'14223', N'How TikTok Is Changing Brand Experience In Vietnam With Khiem Ho Of TikTok And Aniq Syed Of Publicis Media', N'Marketing experts Khiem Ho and Aniq Syed share some best practices on how brands can stand out on TikTok using short-form videos.', N'Dubbed the “destination for short-form mobile videos,” TikTok became famous for its fast video format featuring authentic, entertaining content. But they’re more than that — creators on TikTok use the platform for discussion, campaign for issues, and educate the audiences. Marketers are also drawn to TikTok’s access to audiences of all ages across different backgrounds. This is an opportunity for marketers to create something new and fresh on the platform. With its rapid growth and engaged users from all generations – gaining over one billion global audiences, 240 million of which are in Southeast Asia – TikTok is well suited to further transform the way mobile marketing works. Khiem Ho, head of Client Solutions at TikTok Vietnam, joined TikTok at a perfect time — “when the entertainment platform was rapidly changing the world with short-form videos,” he said. Nine months in the company, Khiem operates on TikTok’s complex monetization strategy and products across the funnel. In this episode of the Vietnam Innovators podcast, he is joined by Aniq Syed, deputy managing director of Publicis Media in Vietnam to discuss trends that marketers should take advantage of with TikTok like ‘Shoppertainment’, tips on how to stand out in the platform, and the best practices from their latest campaign collaboration for Maybelline’s M?y Bé Lì campaign.', N'hhVDBF-Z-ow', 1, N'thumbnail3.jpg', CAST(N'2022-04-03T15:53:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'26334', N'These Architects Are Designing Homes For Vietnam’s Tradition Of Multigenerational Living', N'Multigenerational living arrangements are a cultural norm in Vietnam, a society that reveres elders. So what are architects doing to make homes accessible for families of all ages?', N'It was a brutally hot and breezeless summer season in Hue, one of Vietnam''s stickiest cities. Lien, who teaches Japanese, had just finished a class and was seeing off her students at the front door. There wasn’t a single drop of rain for over a week that time, so she lingered in the front garden to water her parched hedges and trees. After quenching their thirst, she slipped inside her naturally cool house, flipped on the rice cooker and heated up yesterday’s caramelized pork. She then headed upstairs to inform her elderly parents that lunch is almost ready before returning to the kitchen to chop up the vegetables. In Lotus House, Lien’s home and workplace, she glided between the classroom, front door, kitchen, leafy garden and two stories. But in almost every other Vietnamese city house, usually multistory abodes connected by precarious staircases, this ease of movement would be unthinkable because Lien is in a wheelchair. Lotus House, which was completed in 2019, was architect Le Minh Quang’s first project for a client with disabilities, and he admits that “it was a huge, interesting challenge.” Lien needs access to every corner of the house, garden and classroom, so Le’s firm, MW archstudio, proposed two long ramps. The lower ramp begins at the front door, crosses the garden and enters the open plan kitchen and adjoined classroom. The upper ramp connects the two stories via an open-air, U-shaped corridor lined with trees and plants. Both stories are broad and uncluttered, with plenty of space in which to maneuver a wheelchair. But Le’s job went beyond designing a comfortable residence for Lien; he also had to consider her parents, both of whom are in their late 80s. Lien is their main caregiver. “[They] are very sensitive,” says Le, referring to their deteriorating mental and physical states. “So the house needs to be safe and comfortable, but it should also be open and connected to the positive energy of nature.”Le wanted to craft an indoor space that was protected from – but connected to – the elements, so he deployed bioclimatic design, an approach that builds according to the local climate for optimum human comfort. He fitted the house with various broad windows that open and allow plenty of natural light, encourage cross ventilation and offer views of the garden. But he also used sensibly positioned sunshades and a generous buffer zone – a void separating outside and in – to mitigate heating from the sun. Although Lotus House was a special case for Le, multigenerational households are the norm in Vietnam. “The connection between family members across different generations is always a top priority,” says Le. “It is the root of Vietnamese culture.” Vietnamese architecture doesn’t always reflect Le’s sentiment. The (in)famous “tube houses” in Hanoi and Ho Chi Minh City, for example, are usually narrow and spread over several stories. Despite the inconvenience, a ground floor living room that doubles as a bedroom for an immobile grandparent isn’t uncommon. Some boutique firms, such as Le’s MW archstudio, are beginning to rethink this exclusionary approach, bringing a new wave of inclusive architecture to the fore. The two-story Nha Be House, designed by Ho Chi Minh City architecture firm Tropical Space and completed in early 2021, demonstrates that architects also need to think beyond physical disabilities. “[The clients] needed to live in a place with fresh air,” says Tran Thi Ngu Ngon, one of the firm’s co-founders and lead architects. “But they also wanted to create a warm living environment for themselves.”', N'G3IoEc7EHlg', 1, N'thumbnail5.jpg', CAST(N'2022-03-10T15:54:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'32596', N'4 Tips From Successful Startup Founders On Getting A ‘Yes’ From Investors', N'Raising a capital often means the difference between success and failure.', N'Survival 101 is a new Vietcetera series focused on giving expert and relevant tips on coping with different challenges - in our personal lives, in business, and all that''s in between. Let’s say you have this brilliant business idea you know would profit and grow eventually. Your passion is just on fire, and there’s no stopping you from establishing your own startup. After all, what you need to start a business is just a solid idea that can go far. Right? What many young entrepreneurs do not know until they’re officially in it is that the startup ecosystem (or the business world for that matter) is a very competitive environment. Everyone has ideas they want to fight for, and there are investors who won’t have second thoughts dismissing your work as “no big deal”. Even the greatest of ideas or business models could crash and burn even right before they could take off. Because here’s the hard truth: raising capital often means the difference between success and failure. Having the right amount of capital from the right investors is vital for giving your business idea the chance to live to its full potential. But of course, it’s not going to be a smooth road to travel through. You’re not going to get a surprise call from angel investors or venture capitalists if that’s what you are waiting for. It takes hard work and patience, creativity and resourcefulness, and an indestructible strong will. Here are some of the most practical and useful tips from successful founders of Vietnam-based startups that can help you find the right people who will help you lift those ideas off the ground, and how you can eventually get that most coveted “yes” from investors.', N'J_AqLBkyIMU', 1, N'thumbnail14.jpg', CAST(N'2022-03-15T19:02:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'40801', N'Notable Vietnamese Academics', N'Historically, great Vietnamese scholars were philosophers, statesmen and poets, but modern Vietnamese scholars tend to be in a diverse range of fields.', N'Our drive has been to cover the up and coming movers and shakers who are meaningful to a rising Vietnam. We believe that it isn’t just business people. It bleeds out to artists, designers, creatives, scientists, and academics. But why do we love academics specifically? Academics connect to an international standard of knowledge and insight into the world and Vietnam. This goes beyond the anecdotal information we provide. One of the greatest and most enduring Vietnamese traditions is our respect for education and scholarship. Those who aspire to be at the top of their field are widely known among their countrymen and typically used as an example for the youth. Historically, great Vietnamese scholars were philosophers, statesmen and poets, but modern Vietnamese scholars tend to be in a diverse range of fields. For a start, here are some notable scholars and academics of modern Vietnam you might have already heard about.', N'x', 1, N'thumbnail8.jpg', CAST(N'2022-03-15T15:56:00.0000000' AS DateTime2), 1, 2, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'44342', N'Bringing Vietnam Intelligence To The World With Phạm Minh Tuấn CEO Of FPT Software', N'Phạm Minh Tuấn’s mission is to transform FPT Software’s business, tech and people. ', N'FPT Software is the leading technology company in Vietnam and Southeast Asia. In the last 23 years, FPT Software pioneered in building and developing Vietnamese-branded software, applying technology to life, and creating benefits for people and businesses. And they continue to modernize national backbone industries, providing young people with education and practical training. The company also leads the software export sector and contributes to bringing Vietnamese wisdom to the world. In Vietnam, most of the extensive information systems in state agencies and key economic sectors are built and developed by FPT. Tu?n revealed that FPT Software gained its first success in Japan. At the moment, they consider three pillars of their success — Japan, North America, and Europe.  When asked why he stayed for 25 years in the same company, Tu?n shared his reasons. As cliche as it may sound, he stayed this long because he could be his true self while working at FPT. “FPT’s leaders allow people to do the job their way,” he said. “They just give the mission, and they give you the freedom to do the job and achieve the goals.” Because of the different roles Tu?n filled in in the past, he believes it’s one of the reasons he made it this far and long. He called it “experiments” — handling different responsibilities while in different locations. Tu?n trusts that he and his colleagues have lived up to their dream of bringing Vietnam intelligence to the world. “From the beginning, nobody knew about Vietnam, but nowadays, Vietnam is in the top 10 destinations for software service.” Talking about the tough years in the industry, Tu?n revealed that there was never a time he ever thought of giving up something he was tasked to accomplish. However, he revealed that the leaders and investors of FPT Software considered giving up from 1999 to 2004 because it was an extremely difficult time for the company. Looking back, he’s thankful the decision was always to go on and keep doing what they do best.', N'vCDcIYk4qyc', 1, N'thumbnail1.jpg', CAST(N'2022-03-19T15:40:00.0000000' AS DateTime2), 1, 2, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'45593', N'The Top 10 Most Watched Vietnam Innovators Podcast Episodes On Youtube In 2021', N'Vietnam Innovators is Vietcetera’s flagship business show — here’s a list of this year’s most-viewed podcast episodes on YouTube. ', N'While podcasts are often meant for idle listening — commuting to work, gym sessions, or long flights — YouTube still managed to become a top podcasting platform that offers creators an excellent opportunity to reach more people with their shows. In Vietnam, Vietcetera is leading the podcast industry  with its chart-topping shows with audiences averaging as much as a 71% retention rate and accumulating more than two million downloads a month on Spotify and Apple Podcasts. Another achievement worth celebrating is on November 11, the Vietcetera channel  officially received its silver play button from YouTube after hitting 100,000 subscribers. As of this writing, the channel has over 131,000 subs and more than 10 million views. Vietnam Innovators podcast (VNI) is Vietcetera’s flagship business show where Hao Tran — the host and also the CEO of Vietcetera — meets with business executives and leaders in various industries to talk about Vietnam’s future growth prospects and why they believe innovation will be key to the country’s role in the world order. VNI’s first season premiered on October 8, 2020 and had 37 episodes. Its second season kicked off on August 24, 2021 and has, so far, 21 episodes. “As I typed in to look for videos about innovation and leadership in Vietnam, there were not that many videos about that. Luckily, I found your channel,” a YouTube user left that comment in one episode of VNI. The show releases one episode weekly across channels like YouTube, Spotify, Apple podcast. Brands like HSBC, KPMG and AIA are just a few of the VNI sponsors making each episode possible. ', N'g3pdXAt5p3g', 1, N'thumbnail2.jpg', CAST(N'2022-03-17T15:50:00.0000000' AS DateTime2), 1, 3, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'52820', N'Samsung Ranked Best Brand In Vietnam In 2021', N'YouGov’s new consumer research reveals Samsung, Vietnam Airlines and Shopee as top brands in Vietnam this year.', N'A new report by YouGov, an international market research firm, crowns South Korean electronics manufacturer Samsung as top brand in Vietnam in 2021, finishing ahead of more than 350 companies. Samsung outranked flag carrier Vietnam Airlines, which topped last year’s ranking. YouGov’s Best Brand Rankings report measured brands’ overall health, taking into account consumers’ impression, satisfaction and recommendation, as well as product quality, value and reputation. The scores were taken from more than 54,700 interviews with Vietnamese consumers between October 2020 and September 2021. Samsung scored 54.7, while Vietnam Airlines stood 2nd with a score of 48.3. In 3rd place was e-commerce giant Shopee with 41.9. Japanese electronics company Panasonic and Vietnamese brands The Gio Di Dong, Hao Hao, Omachi, Biti’s, Kinh Do and MoMo complete the top 10 brands in the country. UK-based YouGov said that the pandemic, with the grounding of flights and travel restrictions, appears to have hurt Vietnam Airlines’ score, which was 61.5 last year. Meanwhile, as online retail thrived during lockdowns, digital devices and e-commerce platforms moved up the rankings. In 2020 Samsung and Shopee were at 2nd and 7th, respectively. The new rankings “show that despite the pandemic, the health of the biggest companies remains robust in the minds of consumers. Both Samsung and Vietnam Airlines are trusted, valued and respected in the Vietnamese market, with positive reputations and strong brand health across all metrics.” Known for its high-quality consumer smartphones, Samsung’s market share in Vietnam continuously increases. In the second quarter of 2020, it became the biggest-selling smartphone in the country after posting 4% annual sales growth, surpassing sales of China’s Oppo and Vivo and Vietnam’s VinSmart. Beyond smartphones, Samsung also manufactures appliances, semiconductors, and chips.', N'CkuOpk2z43Q', 1, N'thumbnail9.jpg', CAST(N'2022-03-12T19:00:00.0000000' AS DateTime2), 1, 3, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'57435', N'Studio Noor’s Co-Founding Partner David Hodkinson', N'We visited Studio Noor to meet with their co-founding partner, David Hodkinson, to talk about why not having a signature design is their kind of signature.', N'Lauded architect Frank Lloyd Wright once said, “More and more, so it seems to me, light is the beautifier of the building.” For architects, light is the most important aspect of design — if it’s done very well, the design can look incredible. If it’s not done right, whatever the design is, it will look awful.Noor, which translates to “light from the heavens”, was established in 2003 by David Hodkinson and Luc Lejeune. Fast forward to today, now “Studio Noor” is a leading architecture and design studio with a focus on hospitality projects headquartered in Vietnam and Greece. To David, they don’t just design hospitality, they enjoy and consume the industry. Growing up exposed to his father’s printing and cartography background, David already knew he wanted to be an architect. And he excels at it. David brings with him years of global experience working for UK’s Glenn Howells and Architecture PLB, not to mention having achieved a First Class Honors degree in Architecture at Oxford Brookes University in England, and getting his Master’s in Architecture and Interiors from the Royal College of Art in London. Fondly enough, before taking his Master’s, his “Okay, let’s try something else” brought him to Vietnam, spending six to seven months of touring around the country. While in Royal College of Art, all David had in mind was how he felt so alive and in touch with life in Vietnam. Eighteen years later, he is still here… bringing light from the heavens through his projects. Vietcetera visited Studio Noor, tucked in one of Saigon’s busiest streets, to meet with their co-founding partner and design director, David Hodkinson, to talk about how the studio is managing overseas projects despite the pandemic and why not having a signature design is their kind of signature.', N'x', 1, N'thumbnail4.jpg', CAST(N'2022-03-05T15:54:00.0000000' AS DateTime2), 1, 3, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'58830', N'Jio Health Explores Three Traditional Vietnamese Remedies', N'Does disregarding traditional remedies mean we’re missing out on effective treatments? Jio Health shares three traditional Vietnamese medicine and wellness approaches worth exploring.', N'Traditional medicine has been the subject of a long-standing debate in scientific communities around the world. While others, like Dr. Paul A. Offit—author of Do You Believe In Magic?—offer up scathing criticisms regarding alternative medicines. Although variations of traditional Vietnamese medicine date back more than 2,000 years—to the reign of the Hung Vuong dynasty—it is still widely practiced throughout Vietnam today. And as global scrutiny continues to question the benefits of traditional medical treatments, we thought it was time to explore some ancient practices with supporting  scientific studies. We reconnected with our friends at Jio Health for a healthy dose of their expert medical advice on the hotly-debated topic.', N'lrNu8InarYU', 1, N'thumbnail11.jpg', CAST(N'2022-03-22T15:57:00.0000000' AS DateTime2), 1, 8, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'68919', N'Vietnamese Language Is The Second Most Popular Language In Taiwan, Study Reveals', N'In the Asia and Oceania continent, English is the most popular language in 14 of the 26 countries.', N'Aside from being able to stay safe and spend more quality time with family members, the movement restrictions caused by the global pandemic have resulted in people turning into acquiring new things, looking for productive hobbies like making arts and crafts, cooking and baking, playing instruments, practicing mindfulness, and learning foreign languages. If you’re in Vietnam, especially in locked-down cities and provinces, you probably have bumped into posts on your social media newsfeed of someone looking for language teachers, or locals who can teach them basic Vietnamese words. Students, teachers, office workers, millennials, boomers — people naturally crave something to fill their minds and (longer) days. While it’s true that Vietnamese are learning foreign languages to get better jobs and to get into bigger circles, the presence of expats, especially teachers, in the country makes it more relevant and useful for the locals to be familiar with other languages apart from their own. Not to mention foreign online content platforms like Netflix produces Korean, Thai, Spanish, and of course, English content among others. In a recent study by WordTips, where they translated relevant search terms for each country and looked into yearly Google search data to discover the most studied languages around the world, it was revealed that in over 98 countries, people are trying to learn English — including Vietnam with 13.66% yearly searches per 1,000 internet users. The neighboring countries of Thailand (44.28%), Cambodia (1.5%), and Malaysia (5.34%) also have English as the top language their citizens want to learn. In the Asia and Oceania continent, English is the most popular language in 14 of the 26 countries. “Learning a second language is more popular on this continent, with more Google searches being made here than anywhere else. The top three countries for language learning are Indonesia, Thailand, and Japan,” reads their report. However, their research added it shouldn’t be assumed that the most-searched language to learn in each country is representative of the whole nation. With that, they also presented the second most popular language search. “For example, French only appears in Africa as a most popular search but is also sought-after in Canada, Portugal, and Bosnia, among other places, as an alternative language to learn.” According to the second set of data, Polish, Indonesian, Tamil, Thai, Turkish, and Vietnamese are popular, which didn’t appear in the initial set. In fact, the Taiwanese government is campaigning to encourage immigrants to teach their native languages to their children. And here’s a quick trivia, there are over 80,000 children with dual Vietnamese-Taiwanese citizenship in Taiwan, and schools have been teaching Vietnamese since 2018, making the Vietnamese language the second most popular language in Taiwan with 1.23% yearly searches per 1,000 internet users.', N'zYLAcfnY4bw', 1, N'thumbnail6.jpg', CAST(N'2022-03-02T15:55:00.0000000' AS DateTime2), 1, 6, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'77906', N'Software Development Outsourcing In Vietnam: Trends In 2019', N'In order to get key insights on software development outsourcing trends in Vietnam, we reached out to industry leaders Giang Tran and Kent Nguyen.', N'As the world economy continues to globalize and outsource software development to Vietnam, new trends are rapidly developing in the industry. 2019 is bringing new types of projects, new international dynamics and new company cultures. In order to get key insights on what’s happening and what’s coming, we reached out to two industry leaders: Giang Martin Tran, founder and CEO of Restaff-House of Norway; and Kent Nguyen, entrepreneur and technology consultant at 31Seven. Read our discussion below about the future of software development outsourcing in Vietnam, and how Giang and Kent’s own enterprises are navigating shifting technology and labor landscapes.', N'x8gQ1GXiRCU', 1, N'thumbnail12.jpg', CAST(N'2022-02-12T15:57:00.0000000' AS DateTime2), 1, 5, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'81654', N'Antibiotics In Vietnam: Jio Health''s Ways To Avoid Overuse', N'Once a medical revolution that gave us longer healthier lives—the era of antibacterials which has lastied for the last century has transitioned into a period of global concern. The same concerns apply to the overuse of antibiotics in Vietnam. So here Jio Health helped us to understand more about the issue.', N'It’s clear we’re fighting a losing war against evolving bacteria. The World Health Organization  is calling the problem “a serious threat [that] is no longer a prediction for the future.” Another report by Columbia University called the overuse “potentially devastating, threatening to set back progress against certain infectious diseases to the pre-antibiotic era.” Last year, the New York Times reported the death of an elderly women killed not by cancer, pneumonia, or heart disease, but by “bacteria that were resistant to every antibiotic doctors could throw at them.”  And as long ago as the 1950s, the overuse of penicillin and erythromycin was already producing weakened responses. Since then, the problem has been amplified by years of inappropriate treatments, incorrect dosages, and self-prescription—antibiotics don’t, for example, work for viral illnesses despite often being taken to cure the common cold. Credit: David MarchalThere’s a saying in Vietnamese: “Tot qua hoa lop” which means “going beyond the limit is as bad as falling short.” It’s a phrase that could apply to our overuse of antibiotics in Vietnam. Here, people often take advice from family or friends and self-medicate rather than spend hours in queues at medical centers. And pharmacists also dispense advice as freely as their medicines. This is enabled by the accessibility of most medications, including antibiotics, which are sold without prescription at 88% of urban drugstores and 91% of rural drugstores according to one recent survey. We checked in again with Jio Health’s Head of Internal Medicine, Dr. Si, to better understand the problem of the overuse of antibiotics in Vietnam, and to get suggestions on what we can be doing to help alleviate the risks.', N'_J2OOy9Wxqk', 1, N'thumbnail10.jpg', CAST(N'2022-03-02T19:01:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'86449', N'Better Jobs, Bigger Circle: Why Young Vietnamese Are Learning Foreign Languages', N'Knowing a second language, after all, means a whole new literature is in your hands - or tongue.', N'Choosing which language to learn, or pick up next, is a personal and, sometimes, a complicated process: it can come on the back of a trend in software development, or it can come out of the combined elements of interest, need, and even community. The choices can be as personal as they are varied. You may want a high-level language that would open possible career opportunities, a functional language that you can use when you travel abroad, or simply a language that you love to learn because it''s trendy (maybe Korean so you won’t anymore need subtitles for your favorite k-drama?). Knowing a second language, after all, means a whole new literature is in your hands - or tongue. Hana Thu, who’s now 26 years old, learned Japanese while finishing her university degree. Believing that learning a foreign language would be a key professional advantage, Hana didn’t mind the occasional confusion as she shifted from Vietnamese to Nihongo. “Originally, I was interested to learn Korean but my university wasn’t offering that then,” she explains. “However, even if I only remember a few Japanese words, it was a memorable experience for me and it helped me connect with people.” But after graduating, she was convinced that learning English will benefit her more, so she put more effort into speaking and using the language. Having no interest in going abroad and working, she’s optimistic to join a multinational company and apply her English skills. Hana is just one of the many Vietnamese, Millennials, and Gen Z mostly, who have taken a liking to learn foreign languages besides English. While English remains the most preferred language (being the world’s lingua franca) to learn as it gives one greater chance of landing a high-paying job and of working in a foreign land, young people are also now trying to learn Nihongo, Korean, Spanish, and Chinese among others.', N'tf5mBshJ5L8', 1, N'thumbnail7.jpg', CAST(N'2022-04-10T15:55:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Blogs] ([BlogId], [Title], [Brief], [Content], [VideoURL], [SlideId], [ThumbnailURL], [CreatedDate], [StatusId], [CategoryId], [UserId]) VALUES (N'98883', N'How To Protect Your Data Online, According To Vietnam’s Most Infamous Former Hacker', N'We don’t realize how much data we’re sharing online. Tagged as one of the world’s most prolific hackers, Hieu Minh Ngo, shares tips on how to secure data online.', N'Vietnam has nearly 98 million people, with 73.7% of them active social media users — a figure higher than other Asian economies. In fact, Vietnamese are considered the most active on the Internet and social media platforms in the region, outpacing South Koreans and Chinese Internet users. That doesn’t come as a surprise, though. Vietnam’s connection speed is commendable; not to mention the affordability of smartphones and the availability of free Wi-Fi just about anywhere. But as Vietnam becomes more wired than ever, such digital connectivity has also presented disturbing realities not too many know about: compromised personal data, stolen identities and leaked information. For regular Internet users, getting their Twitter account hacked for a few hours would raise concern, but not enough to push them to re-evaluate their data privacy and protection. But, do we really know how much data we’re “voluntarily” sharing online? What better way to answer this question and gauge just how vulnerable our privacy is in cyberspace than to ask one of the world’s most prolific hackers and identity thieves, Hieu Minh Ngo. Hieu, who grew up in a quiet Vietnamese seaside town, ran Internet scams since he was a teenager, stealing more than 200 million personal and financial data. In 2013 at the age of 25, he was arrested by the US Secret Service in Guam, and served seven years in federal prison. When he was released in November 2019, Hieu returned to Vietnam, settled for a new life in Saigon, and is now a cybersecurity specialist, offering training and consultation for nonprofit organizations and Vietnam’s National Cybersecurity Center.While Hieu still vividly remembers how scared he was during detention, he doesn’t shy away from his storied past. A quick check on his LinkedIn  and you’d find the words “Former Cybercriminal and Convicted Hacker” on his bio. “My information is all over the Internet, there’s nothing else to hide,” he said in our previous interview with him. Today, as he strives to lead a more honest life, Hieu shares practical tips on how Vietnamese Internet users can protect their data — names, birth dates, social security numbers, bank account, etc. — from online villains lurking behind unsuspicious names and icons.', N'YK4u38DDlJY', 1, N'thumbnail13.jpg', CAST(N'2022-03-10T15:58:00.0000000' AS DateTime2), 1, 1, N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (1, N'Arts and Humanities')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (2, N'Business')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (3, N'Computer Science')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (4, N'Data Science')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (5, N'Information Technology')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (6, N'Health')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (7, N'Math and Logic')
INSERT [dbo].[Categories] ([CategoryId], [CategoryValue]) VALUES (8, N'Personal Development')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
INSERT [dbo].[Comments] ([CommentId], [CommentBody], [BlogId], [UserId]) VALUES (N'27ZEQMKCO', N'Great haha', N'44342', N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
INSERT [dbo].[Comments] ([CommentId], [CommentBody], [BlogId], [UserId]) VALUES (N'Y857YGKKJ', N'Hello', N'44342', N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6')
GO
INSERT [dbo].[CourseOwners] ([CourseOwnerId], [CourseId], [PurchaseTime]) VALUES (N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6', N'C0001', CAST(N'2001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0001', CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'Graphic Design is all around us! Words and pictures—the building blocks of graphic design—are the elements that carry the majority of the content in both the digital world and the printed world. As graphic design becomes more visible and prevalent in our lives, graphic design as a practice becomes more important in our culture.

Through visual examples, this course will teach you the fundamental principles of graphic design: imagemaking, typography, composition, working with color and shape... foundational skills that are common in all areas of graphic design practice. I don''t just want you to watch a video of someone talking about design, I want you to MAKE design! If you want to be a designer you have to be a maker and a communicator, so this course will offer you lots of opportunities to get your hands dirty with exercises and with more practical projects.

At the end of this course you will have learned how to explore and investigate visual representation through a range of image-making techniques; understand basic principles of working with shape, color and pattern; been exposed to the language and skills of typography; and understand and have applied the principles of composition and visual contrast. If you complete the course, along with its optional (but highly recommended) briefs, you will have a core set of graphic design skills that you can apply to your own projects, or to more deeply investigate a specialized area of graphic design.

To succeed in this course you will need access to a computer. You can complete this course without one but it will be tougher. Access to, and a beginner''s level knowledge of Adobe Creative Suite programs, such as Illustrator, Photoshop and InDesign will help you, especially if you want to complete the optional briefs.', N'Graphic Design is all around us! Words and pictures—the building blocks of graphic design—are the elements that carry the majority of the content in both the digital world and the printed world. As graphic design becomes more visible and prevalent in our lives, graphic design as a practice becomes more important in our culture.', N'C0001.png', N'Fundamentals of Graphic Design
', 9.69, 1, 1, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0002', CAST(N'2022-06-09T00:00:00.0000000' AS DateTime2), N'This course will introduce you to some of the main areas of research in contemporary philosophy. Each module a different philosopher will talk you through some of the most important questions and issues in their area of expertise. We’ll begin by trying to understand what philosophy is – what are its characteristic aims and methods, and how does it differ from other subjects? Then we’ll spend the rest of the course gaining an introductory overview of several different areas of philosophy. 

Topics you’ll learn about will include: 

Epistemology, where we’ll consider what our knowledge of the world and ourselves consists in, and how we come to have it;

Philosophy of science, where we’ll investigate foundational conceptual issues in scientific research and practice;

Philosophy of Mind, where we’ll ask questions about what it means for something to have a mind, and how minds should be understood and explained;

Political Philosophy, where we''ll investigate whether we have an obligation to obey the law;

Moral Philosophy, where we’ll attempt to understand the nature of our moral judgements and reactions – whether they aim at some objective moral truth, or are mere personal or cultural preferences, and;

Metaphysics, where we’ll think through some fundamental conceptual questions about free will and the nature of reality.

The development of this MOOC has been led by the University of Edinburgh''s Eidyn research centre.

To accompany ''Introduction to Philosophy'', we are pleased to announce a tie-in book from Routledge entitled ''Philosophy for Everyone''. This course companion to the ''Introduction to Philosophy'' course was written by the Edinburgh Philosophy team expressly with the needs of MOOC students in mind. ''Philosophy for Everyone'' contains clear and user-friendly chapters, chapter summaries, glossary, study questions, suggestions for further reading and guides to online resources. Please click "Start Here" and navigate to the "Optional Reading" page for more information.', N'This course will introduce you to some of the main areas of research in contemporary philosophy. Each module a different philosopher will talk you through some of the most important questions and issues in their area of expertise. We’ll begin by trying to understand what philosophy is – what are its characteristic aims and methods, and how does it differ from other subjects? Then we’ll spend the rest of the course gaining an introductory overview of several different areas of philosophy. ', N'C0002.png', N'Indigenous Canada
', 9.89, 1, 1, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0003', CAST(N'2021-04-13T00:00:00.0000000' AS DateTime2), N'Why just write poems when you can write better ones? This course is built on the notion that the most exciting writing begins after the first draft. It is specifically for folks who believe that writing poems just to express oneself is like using the Internet just for email. After all, poetry can change the way you and your readers think of the world and its inhabitants; it can break new ground for language; turn a blank sheet of paper into a teeming concert of voices and music.

Though any of us may have the potential to make that happen, having an understanding of how several tools of poetic composition can be used (and audaciously “mis-used”) gives you more ways to try (and if we do this right, we might surprise ourselves most of all). 

We''ll cover key poetic terms and devices by studying poems by a handful of modern and contemporary poets and then get a chance to try our own hand at writing new poem drafts from a select number of prompts. Throughout the course you will have the opportunity to workshop your poem drafts and get feedback on your work, working towards a more polished poem.', N'Why just write poems when you can write better ones? This course is built on the notion that the most exciting writing begins after the first draft. It is specifically for folks who believe that writing poems just to express oneself is like using the Internet just for email. After all, poetry can change the way you and your readers think of the world and its inhabitants; it can break new ground for language; turn a blank sheet of paper into a teeming concert of voices and music.', N'C0003.png', N'Sharpened Visions: A Poetry Workshop
', 9.99, 2, 1, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0004', CAST(N'2021-03-25T00:00:00.0000000' AS DateTime2), N'An overview of the ideas, methods, and institutions that permit human society to manage risks and foster enterprise.  Emphasis on financially-savvy leadership skills. Description of practices today and analysis of prospects for the future. Introduction to risk management and behavioral finance principles to understand the real-world functioning of securities, insurance, and banking industries.  The ultimate goal of this course is using such industries effectively and towards a better society.', N'An overview of the ideas, methods, and institutions that permit human society to manage risks and foster enterprise.  Emphasis on financially-savvy leadership skills. Description of practices today and analysis of prospects for the future. Introduction to risk management and behavioral finance principles to understand the real-world functioning of securities, insurance, and banking industries.  The ultimate goal of this course is using such industries effectively and towards a better society.', N'C0004.png', N'Financial Markets
', 9, 1, 2, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0005', CAST(N'2022-01-02T00:00:00.0000000' AS DateTime2), N'We all negotiate on a daily basis. On a personal level, we negotiate with friends, family, landlords, car sellers and employers, among others. Negotiation is also the key to business success. No business can survive without profitable contracts. Within a company, negotiation skills can lead to your career advancement. 

I hope that you will join the hundreds of thousands of learners who have made “Successful Negotiation” one of the most popular and highly-rated MOOCs worldwide.  In the course, you’ll learn about and practice the four steps to a successful negotiation: 

   (1) Prepare: Plan Your Negotiation Strategy 

   (2) Negotiate: Use Key Tactics for Success 

   (3) Close: Create a Contract 

   (4) Perform and Evaluate: The End Game 

To successfully complete this course and improve your ability to negotiate, you’ll need to do the following: 

(1) Watch the short videos (ranging from 5 to 20 minutes). The videos are interactive and they include questions to test your understanding of negotiation strategy and skills. You can speed up or slow down videos to match your preferred pace for listening. Depending on your schedule, you can watch the videos over a few weeks or you can binge watch them. A learner who binge-watched the course concluded that “It’s as good as Breaking Bad.” Another learner compared the course to “House of Cards.”  Both shows contain interesting examples of complex negotiations!

(2) Test your negotiation skills by completing the negotiation in Module 6. You can negotiate with a local friend or use Discussions to find a partner from another part of the world. Your negotiation partner will give you feedback on your negotiation skills. To assist you with your negotiations, I have developed several free negotiating planning tools that are related to the course.  These tools and a free app are available at http://negotiationplanner.com/ 

(3) Take the final exam. To successfully complete the course, you must answer 80% of the questions correctly. The exam is a Mastery Exam, which means that you can take it as many times as you want until you master the material. 

Course Certificate
You have the option of earning a Course Certificate.  A Certificate provides formal recognition of your achievements in the course and includes the University of Michigan logo.   Learn more about Certificates at: https://learner.coursera.help/hc/en-us/articles/209819053-Get-a-Course-Certificate', N'We all negotiate on a daily basis. On a personal level, we negotiate with friends, family, landlords, car sellers and employers, among others. Negotiation is also the key to business success. No business can survive without profitable contracts. Within a company, negotiation skills can lead to your career advancement. ', N'C0005.png', N'Successful Negotiation: Essential Strategies and Skills', 9, 2, 2, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0006', CAST(N'2021-08-06T00:00:00.0000000' AS DateTime2), N'This specialization is a precursor to the Applied Project Management Certificate. Project management has been proven to be the most effective method of delivering products within cost, schedule, and resource constraints. This intensive and hands-on series of courses gives you the skills to ensure your projects are completed on time and on budget while giving the user the product they expect. You will gain a strong working knowledge of the basics of project management and be able to immediately use that knowledge to effectively manage work projects. At the end of the series you will be able to identify and manage the product scope, build a work breakdown structure, create a project plan, create the project budget, define and allocate resources, manage the project development, identify and manage risks, and understand the project procurement process.', N'This specialization is a precursor to the Applied Project Management Certificate. Project management has been proven to be the most effective method of delivering products within cost, schedule, and resource constraints', N'C0006.png', N'Project Management Principles and Practices
', 8.97, 1, 2, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0007', CAST(N'2021-05-04T00:00:00.0000000' AS DateTime2), N'This course aims to teach everyone the basics of programming computers using Python. We cover the basics of how one constructs a program from a series of simple instructions in Python.  The course has no pre-requisites and avoids all but the simplest mathematics. Anyone with moderate computer experience should be able to master the materials in this course. This course will cover Chapters 1-5 of the textbook “Python for Everybody”.  Once a student completes this course, they will be ready to take more advanced programming courses. This course covers Python 3.', N'This course aims to teach everyone the basics of programming computers using Python. We cover the basics of how one constructs a program from a series of simple instructions in Python.  The course has no pre-requisites and avoids all but the simplest mathematics', N'C0007.png', N'Programming for Everybody (Getting Started with Python)', 6.92, 2, 3, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0008', CAST(N'2022-01-01T00:00:00.0000000' AS DateTime2), N'This course teaches learners (industry professionals and students) the fundamental concepts of parallel programming in the context of Java 8. Parallel programming enables developers to use multicore computers to make their applications run faster by using multiple processors at the same time. By the end of this course, you will learn how to use popular parallel Java frameworks (such as ForkJoin, Stream, and Phaser) to write parallel programs for a wide range of multicore platforms including servers, desktops, or mobile devices, while also learning about their theoretical foundations including computation graphs, ideal parallelism, parallel speedup, Amdahl''s Law, data races, and determinism.

Why take this course?

•	All computers are multicore computers, so it is important for you to learn how to extend your knowledge of sequential Java programming to multicore parallelism.
•	Java 7 and Java 8 have introduced new frameworks for parallelism (ForkJoin, Stream) that have significantly changed the paradigms for parallel programming since the early days of Java.
•	Each of the four modules in the course includes an assigned mini-project that will provide you with the necessary hands-on experience to use the concepts learned in the course on your own, after the course ends.
•	During the course, you will have online access to the instructor and the mentors to get individualized answers to your questions posted on forums.

The desired learning outcomes of this course are as follows:

•	Theory of parallelism: computation graphs, work, span, ideal parallelism, parallel speedup, Amdahl''s Law, data races, and determinism
•	Task parallelism using Java’s ForkJoin framework
•	Functional parallelism using Java’s Future and Stream frameworks
•	Loop-level parallelism with extensions for barriers and iteration grouping (chunking)
•	Dataflow parallelism using the Phaser framework and data-driven tasks

Mastery of these concepts will enable you to immediately apply them in the context of multicore Java programs, and will also provide the foundation for mastering other parallel programming systems that you may encounter in the future  (e.g., C++11, OpenMP, .Net Task Parallel Library).', N'This course teaches learners (industry professionals and students) the fundamental concepts of parallel programming in the context of Java 8. Parallel programming enables developers to use multicore computers to make their applications run faster by using multiple processors at the same time', N'C0008.png', N'Parallel Programming in Java
', 8, 1, 3, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0009', CAST(N'2021-12-12T00:00:00.0000000' AS DateTime2), N'This course explores Javascript based front-end application development, and in particular the React library (Currently Ver. 16.3). This course will use JavaScript ES6 for developing React application. You will also get an introduction to the use of Reactstrap for Bootstrap 4-based responsive UI design. You will be introduced to various aspects of React components. You will learn about React router and its use in developing single-page applications. You will also learn about designing controlled forms. You will be introduced to the Flux architecture and Redux. You will explore various aspects of Redux and use it to develop React-Redux powered applications. You will then learn to use Fetch for client-server communication and the use of REST API on the server side. A quick tour through React animation support and testing rounds off the course. You must have preferably completed the previous course in the specialization on Bootstrap 4, or have a working knowledge of Bootstrap 4 to be able to navigate this course. Also a good working knowledge of JavaScript, especially ES 5 is strongly recommended.

At the end of this course you will:

- Be familiar with client-side Javascript application development and the React library
- Be able to implement single page applications in React
- Be able to use various React features including components and forms
- Be able to implement a functional front-end web application using React
- Be able to use Reactstrap for designing responsive React applications
- Be able to use Redux to design the architecture for a React-Redux application', N'This course explores Javascript based front-end application development, and in particular the React library (Currently Ver. 16.3). This course will use JavaScript ES6 for developing React application. You will also get an introduction to the use of Reactstrap for Bootstrap 4-based responsive UI design', N'C0009.png', N'Front-End Web Development with React
', 8, 2, 3, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0010', CAST(N'2021-11-08T00:00:00.0000000' AS DateTime2), N'Your smartphone, smartwatch, and automobile (if it is a newer model) have AI (Artificial Intelligence) inside serving you every day. In the near future, more advanced “self-learning” capable DL (Deep Learning) and ML (Machine Learning) technology will be used in almost every aspect of your business and industry. So now is the right time to learn what DL and ML is and how to use it in advantage of your company. This course has three parts, where the first part focuses on DL and ML technology based future business strategy including details on new state-of-the-art products/services and open source DL software, which are the future enablers. The second part focuses on the core technologies of DL and ML systems, which include NN (Neural Network), CNN (Convolutional NN), and RNN (Recurrent NN) systems. The third part focuses on four TensorFlow Playground projects, where experience on designing DL NNs can be gained using an easy and fun yet very powerful application called the TensorFlow Playground. This course was designed to help you build business strategies and enable you to conduct technical planning on new DL and ML services and products.', N'Your smartphone, smartwatch, and automobile (if it is a newer model) have AI (Artificial Intelligence) inside serving you every day. In the near future, more advanced “self-learning” capable DL (Deep Learning) and ML (Machine Learning) technology will be used in almost every aspect of your business and industry. So now is the right time to learn what DL and ML is and how to use it in advantage of your company', N'C0010.png', N'Deep Learning for Business
', 8.79, 1, 4, 3, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0011', CAST(N'2021-04-08T00:00:00.0000000' AS DateTime2), N'If you are a software developer who wants to build scalable AI-powered algorithms, you need to understand how to use the tools to build them. This course is part of the upcoming Machine Learning in Tensorflow Specialization and will teach you best practices for using TensorFlow, a popular open-source framework for machine learning. 

The Machine Learning course and Deep Learning Specialization from Andrew Ng teach the most important and foundational principles of Machine Learning and Deep Learning. This new deeplearning.ai TensorFlow Specialization teaches you how to use TensorFlow to implement those principles so that you can start building and applying scalable models to real-world problems. To develop a deeper understanding of how neural networks work, we recommend that you take the Deep Learning Specialization.', N'If you are a software developer who wants to build scalable AI-powered algorithms, you need to understand how to use the tools to build them. This course is part of the upcoming Machine Learning in Tensorflow Specialization and will teach you best practices for using TensorFlow, a popular open-source framework for machine learning. ', N'C0011.png', N'Introduction to TensorFlow for Artificial Intelligence, Machine Learning, and Deep Learning', 9.1, 3, 4, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0012', CAST(N'2021-03-06T00:00:00.0000000' AS DateTime2), N'Case Studies: Analyzing Sentiment & Loan Default Prediction

In our case study on analyzing sentiment, you will create models that predict a class (positive/negative sentiment) from input features (text of the reviews, user profile information,...).  In our second case study for this course, loan default prediction, you will tackle financial data, and predict when a loan is likely to be risky or safe for the bank. These tasks are an examples of classification, one of the most widely used areas of machine learning, with a broad array of applications, including ad targeting, spam detection, medical diagnosis and image classification. 

In this course, you will create classifiers that provide state-of-the-art performance on a variety of tasks.  You will become familiar with  the most successful techniques, which are most widely used in practice, including logistic regression, decision trees and boosting.  In addition, you will be able to design and implement the underlying algorithms that can learn these models at scale, using stochastic gradient ascent.  You will implement these technique on real-world, large-scale machine learning tasks.  You will also address significant tasks you will face in real-world applications of ML, including handling missing data and measuring precision and recall to evaluate a classifier.  This course is hands-on, action-packed, and full of visualizations and illustrations of how these techniques will behave on real data.  We''ve also included optional content in every module, covering advanced topics for those who want to go even deeper! 

Learning Objectives: By the end of this course, you will be able to:
   -Describe the input and output of a classification model.
   -Tackle both binary and multiclass classification problems.
   -Implement a logistic regression model for large-scale classification.  
   -Create a non-linear model using decision trees.
   -Improve the performance of any model using boosting.
   -Scale your methods with stochastic gradient ascent.
   -Describe the underlying decision boundaries.  
   -Build a classification model to predict sentiment in a product review dataset.  
   -Analyze financial data to predict loan defaults.
   -Use techniques for handling missing data.
   -Evaluate your models using precision-recall metrics.
   -Implement these techniques in Python (or in the language of your choice, though Python is highly recommended).', N'Case Studies: Analyzing Sentiment & Loan Default Prediction

In our case study on analyzing sentiment, you will create models that predict a class (positive/negative sentiment) from input features (text of the reviews, user profile information,...).  In our second case study for this course', N'C0012.png', N'Machine Learning: Classification
', 7, 3, 4, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0013', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Prepare for a career in the high-growth field of IT, no experience or degree required. Get professional training designed by Google and get on the fast-track to a competitively paid job. There are 340,500 U.S. job openings in IT and a $50,800 average entry-level salary in IT support.¹

Over 5 courses, learn in-demand skills that prepare you for an entry-level job. At under 10 hours per week, you can complete the certificate in less than 6 months. Upon completion, you can directly apply for jobs with Google and over 130 U.S. employers, including Walmart, Best Buy, and Astreya.

75% of Google Career Certificate Graduates in the United States report an improvement in their career trajectory (e.g. new job or career, promotion or raise) within 6 months of certificate completion²

This program also prepares you for the CompTIA A+ exams, the industry standard certification for IT—you’ll earn a dual credential when you complete both.

This program is ACE® approved—when you complete, you can earn up to 12 college credits, the equivalent of 4 associate degree-level courses.

If you’re interested in building on your IT foundations, check out the Google IT Automation with Python Professional Certificate.

Check out all Google Career Certificates here. Now $39 (save $10)!

¹Burning Glass: Labor Insight (Last 12 Months: 2/1/20 - 1/31/21)

²Based on program graduate survey responses, United States 2021', N'Prepare for a career in the high-growth field of IT, no experience or degree required. Get professional training designed by Google and get on the fast-track to a competitively paid job. There are 340,500 U.S. job openings in IT and a $50,800 average entry-level salary in IT support.', N'C0013.png', N'Google IT Support
', 9.99, 1, 5, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0014', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'In this Specialization, we will cover 3 key technologies that are foundational and driving significant growth and innovation. These are Cloud Computing, Data Science, and Artificial Intelligence (AI).

Technology is essential for the future of business. Almost any organization that wants to modernize or get ahead, and anyone working there, needs to understand and leverage these essential technologies.

The courses in this Specialization provide foundational knowledge of Cloud, Data and AI, including business drivers behind their growth, the value they provide, their applications and use cases, and an understanding of how these technologies work. You will not only become familiar with the buzzwords associated with these technologies, but also experience them in action and develop hands-on skills to start working with them.

This Specialization is suitable for a variety of learners who are beginners with these technologies, including managers and executives, professionals who want to upskill, and students getting ready to start a career.

There is no special prior knowledge or hardware required. The only pre-requisites are basic computer literacy, device with a modern web browser with internet connectivity, and motivation to self-learn online.', N'In this Specialization, we will cover 3 key technologies that are foundational and driving significant growth and innovation. These are Cloud Computing, Data Science, and Artificial Intelligence (AI).', N'C0014.png', N'Key Technologies for Business
', 9.99, 1, 5, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0015', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Data engineering is one of the fastest-growing tech occupations, where the demand for skilled data engineers far outweighs the supply. The goal of data engineering is to make quality data available for fact-finding and data-driven decision making. This Specialization from IBM will help anyone interested in pursuing a career in data engineering by teaching fundamental skills to get started in this field. No prior data engineering experience is required to succeed in this Specialization.

 The Specialization consists of 5 self-paced online courses covering skills required for data engineering, including the data engineering ecosystem and lifecycle, Python, SQL, and Relational Databases.  You will learn these data engineering prerequisites through engaging videos and hands-on practice using real tools and real-world databases. You''ll develop your understanding of data engineering, gain skills that can be applied directly to a data career, and build the foundation of your data engineering career.

 Upon successfully completing these courses, you will have the practical knowledge and experience to delve deeper into data engineering and work on more advanced data engineering projects. ', N' The Specialization consists of 5 self-paced online courses covering skills required for data engineering, including the data engineering ecosystem and lifecycle, Python, SQL, and Relational Databases.', N'C0015.png', N'Data Engineering Foundations
', 8, 2, 5, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0016', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Learn to provide psychological first aid to people in an emergency by employing the RAPID model: Reflective listening, Assessment of needs, Prioritization, Intervention, and Disposition.

Utilizing the RAPID model (Reflective listening, Assessment of needs, Prioritization, Intervention, and Disposition), this specialized course provides perspectives on injuries and trauma that are beyond those physical in nature. The RAPID model is readily applicable to public health settings, the workplace, the military, faith-based organizations, mass disaster venues, and even the demands of more commonplace critical events, e.g., dealing with the psychological aftermath of accidents, robberies, suicide, homicide, or community violence. In addition, the RAPID model has been found effective in promoting personal and community resilience.

Participants will increase their abilities to: 
 - Discuss key concepts related to PFA
 - Listen reflectively
 - Differentiate benign, non-incapacitating psychological/ behavioral crisis reactions from more severe, potentially incapacitating, crisis reactions
 - Prioritize (triage) psychological/ behavioral crisis reactions 
 - Mitigate acute distress and dysfunction, as appropriate 
 - Recognize when to facilitate access to further mental health support 
 - Practice self-care 

Developed in collaboration with Johns Hopkins Open Education Lab.', N'Learn to provide psychological first aid to people in an emergency by employing the RAPID model: Reflective listening, Assessment of needs, Prioritization, Intervention, and Disposition.', N'C0016.png', N'Psychological First Aid
', 9.99, 1, 6, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0017', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Este curso on-demand (ABIERTO, se puede cursar en cualquier momento), impartido en castellano por la Universidad Autónoma de Barcelona y el Centro de Crisis de Barcelona, está destinado a entrenar en la aplicación de primeros auxilios psicológicos (PAP) a personas afectadas por situaciones altamente estresantes, abarcando tanto emergencias cotidianas (incidentes críticos estadísticamente frecuentes que afectan de manera muy intensa: un accidente de tráfico, una hospitalización, una agresión o la muerte traumática o repentina de una persona, etc.) como emergencias comunitarias y/o masivas (sucesos infrecuentes, que afectan a muchas personas o a una comunidad entera y que sobrepasan con mucho lo que sucede habitualmente en ella: una catástrofe natural, un accidente ferroviario o aéreo o un atentado). 

DESTINATARIOS: 
A). Población general, incluyendo protocolos específicos para niños, adolescentes, personas mayores y discapacitados psíquicos. 
B). Profesionales que trabajan en contextos sanitarios, educativos y sociales. 
C). Responsables de programas de ayuda a niños, personas mayores, colectivos multi-problemáticos y discapacitados. Gobiernos locales, líderes religiosos, fuerzas de seguridad estudiantes que se están preparando para ejercer todas estas profesiones. 
D). Recomendado para voluntarios que colaboran en la ayuda a colectivos que han sufrido situaciones de estrés emocional agudo y traumático, como asociaciones de pacientes, grupos de auto-ayuda, ONGs, etc. 

OBJETIVOS DEL CURSO: 
1). Adquirir las competencias para aplicar los primeros auxilios psicológicos a personas, a familias y a comunidades tras un evento estresante cotidiano o comunitario. 
2). Ser capaz de preparar diferentes escenarios para ser utilizados como lugar de recepción de afectados y familiares y para la aplicación de los primeros auxilios psicológicos. 
3). Entrenarse en la aplicación de los protocolos de desactivación y recuperación de los intervinientes que han estado participando en la gestión de una emergencia.

INICIO: 7 de Octubre de 2015
ESTADO DEL CURSO: ABIERTO

NOTA SOBRE LOS SUBTÍTULOS: se ofrecen subtítulos en inglés solo para algunos vídeos del curso, cuyo idioma de grabación es el inglés. Para estos también se ofrecen en español. Para el resto de vídeos, los subtítulos se ofrecen en español.', N'Este curso on-demand (ABIERTO, se puede cursar en cualquier momento), impartido en castellano por la Universidad Autónoma de Barcelona y el Centro de Crisis de Barcelona, está destinado a entrenar en la aplicación de primeros auxilios psicológicos (PAP) a personas afectadas por situaciones altamente estresantes, abarcando tanto emergencias cotidianas (incidentes críticos estadísticamente frecuentes que afectan de manera muy intensa', N'C0017.png', N'Primeros Auxilios Psicológicos (PAP)
', 9, 1, 6, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0018', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'The healthcare system is a rapidly evolving field with new research leading to advancements in
medicine. Developed at Johns Hopkins University and led by top-ranked Hopkins faculty and
cancer experts, this specialization on Cancer Biology focuses on the basics of cancer biology,
how cancer metastasis occurs, and specifically, screening guidelines for prostate cancer, the
most common cancer in American men.


This specialization starts with an Introduction to the Biology of Cancer, introduces the molecular
biology of cancer and the biologic hallmarks of cancer. The course also describes the risk
factors for the major cancers worldwide, including lung cancer, breast cancer, colon cancer,
prostate cancer, liver cancer, and stomach cancer. Experts at Johns Hopkins University explain
how cancer is staged, the major ways cancer is found by imaging, and how the major cancers
are treated.


The specialization takes a deeper dive in Understanding Cancer Metastasis, explaining how
cancer spreads or metastasizes. This course will describe the major theories of metastasis and
then describe the biology behind the steps in metastasis. The course also describes the major
organs targeted by metastasis and describes how metastases harm the patient.
Lastly, it focuses on Understanding Prostate Cancer, providing you with the tools to examine the
incidence of prostate cancer, including risk factors, stages, and treatments at each stage.', N'The healthcare system is a rapidly evolving field with new research leading to advancements in
medicine. Developed at Johns Hopkins University and led by top-ranked Hopkins faculty and
cancer experts, this specialization on Cancer Biology focuses on the basics of cancer biology,
how cancer metastasis occurs, and specifically, screening guidelines for prostate cancer, the
most common cancer in American men.', N'C0018.png', N'Cancer Biology
', 9, 2, 6, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0019', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'In this course you will get an introduction to the main tools and ideas in the data scientist''s toolbox. The course gives an overview of the data, questions, and tools that data analysts and data scientists work with. There are two components to this course. The first is a conceptual introduction to the ideas behind turning data into actionable knowledge. The second is a practical introduction to the tools that will be used in the program like version control, markdown, git, GitHub, R, and RStudio.', N'In this course you will get an introduction to the main tools and ideas in the data scientist''s toolbox. The course gives an overview of the data, questions, and tools that data analysts and data scientists work with. ', N'C0019.png', N'The Data Scientist’s Toolbox
', 9.79, 1, 7, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0020', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Cryptography is an indispensable tool for protecting information in computer systems. In this course you will learn the inner workings of cryptographic systems and how to correctly use them in real-world applications. The course begins with a detailed discussion of how two parties who have a shared secret key can communicate securely when a powerful adversary eavesdrops and tampers with traffic. We will examine many deployed protocols and analyze mistakes in existing systems. The second half of the course discusses public-key techniques that let two parties generate a shared secret key. Throughout the course participants will be exposed to many exciting open problems in the field and work on fun (optional) programming projects. In a second course (Crypto II) we will cover more advanced cryptographic tasks such as zero-knowledge, privacy mechanisms, and other forms of encryption.', N'Cryptography is an indispensable tool for protecting information in computer systems. In this course you will learn the inner workings of cryptographic systems and how to correctly use them in real-world applications. ', N'C0020.png', N'Cryptography I
', 9.99, 1, 7, 3, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0021', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'This six-course program is designed for anyone looking to gain in-demand technical skills to kickstart a career as a marketing analyst or better analyze their business. No experience necessary.

Developed by marketing analytics experts at Aptly together with Meta marketers, the industry-relevant curriculum is designed to prepare you for jobs that include Marketing Analyst, Marketing Researcher, and more.

You’ll learn basic marketing principles, how data informs marketing decisions, and how you can apply the OSEMN data analysis framework to approach common analytics questions. You’ll learn how to use essential tools like Python and SQL to gather, connect, and analyze relevant data. Plus, common statistical methods used to segment audiences, evaluate campaign results, optimize the marketing mix, and evaluate sales funnels.  

Along the way, you''ll learn to visualize data using Tableau and how to use Meta Ads Manager to create campaigns, evaluate results, and run experiments to optimize your campaigns. You''ll also get to practice your new skills through hands-on, industry-relevant projects.

The final course prepares you for the Meta Marketing Science Certification exam.  Upon successful completion of the program, you''ll earn both the Coursera and the Meta Marketing Science Certifications. You’ll also get exclusive access to the Meta Career Programs Job Board—a job search platform with 200+ top employers looking to hire skilled and certified talent.', N'This six-course program is designed for anyone looking to gain in-demand technical skills to kickstart a career as a marketing analyst or better analyze their business. No experience necessary.', N'C0021.png', N'Meta Marketing Analytics
', 9.99, 1, 8, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0022', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Prepare for a new career in the high-growth field of project management, no experience or degree required. Get professional training designed by Google and get on the fastrack to a competitively paid job. There are 475,100 U.S. job openings in project management with a $59,000 average entry-level salary.¹

Project managers are natural problem-solvers. They set the plan and guide teammates, and manage changes, risks, and stakeholders.

Over 6 courses, gain in-demand skills that will prepare you for an entry-level job. Learn from Google employees whose foundations in project management served as launchpads for their own careers. At under 10 hours per week, you can complete in less than six months. 

Upon completion, you can directly apply for jobs with Google and over 130 U.S. employers, including Walmart, Best Buy, and Astreya. 

This program qualifies you for over 100 hours of project management education, which helps prepare you for Project Management Institute Certifications like the globally-recognized Certified Associate in Project Management (CAPM)®.

75% of Google Career Certificate Graduates in the United States report an improvement in their career trajectory (e.g. new job or career, promotion or raise) within 6 months of certificate completion²

Check out all Google Career Certificates here.

¹Burning Glass: Labor Insight (Last 12 Months: 2/1/20 - 1/31/21)

²Based on program graduate survey responses, United States 2021', N'Prepare for a new career in the high-growth field of project management, no experience or degree required. Get professional training designed by Google and get on the fastrack to a competitively paid job. There are 475,100 U.S. job openings in project management with a $59,000 average entry-level salary.¹', N'C0022.png', N'Google Project Management', 9.99, 1, 8, 1, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0023', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Whether you’ve been tinkering with social media platforms for your business already or are completely new to the field of digital marketing, you’ve come to the right place. This six-course program, developed by digital marketing experts at Aptly together with Meta marketers, includes an industry-relevant curriculum designed to prepare you for an entry-level role in social media marketing.

After an introduction to digital marketing and major social media platforms, you’ll learn to establish an online presence, create posts, build a following, and manage your social media accounts. You’ll develop skills in creating and managing advertising campaigns in social media and learn to evaluate the results of your marketing efforts.

Upon successful completion of the program, you’ll earn both the Coursera and the Meta Digital Marketing Associate Certification, proving your skills in social media marketing and in the use of Meta Ads Manager.

Once you earn your Meta Certification, you’ll get exclusive access to the new Meta Career Programs Job Board—a job search platform that connects Meta Certified professionals with 200+ top employers who have committed to sourcing talent through its certification programs. We’ll provide you with the link once you’ve completed all the courses and passed the exam.

This specialization is also offered in Arabic, Portuguese, and Spanish.

', N'Whether you’ve been tinkering with social media platforms for your business already or are completely new to the field of digital marketing, you’ve come to the right place. This six-course program, developed by digital marketing experts at Aptly together with Meta marketers, includes an industry-relevant curriculum designed to prepare you for an entry-level role in social media marketing.', N'C0023.png', N'Meta Social Media Marketing
', 9.99, 3, 8, 2, NULL)
INSERT [dbo].[Courses] ([CourseId], [CreatedDate], [Description], [ShortDescription], [ThumbnailURL], [Title], [Price], [SlideId], [CategoryId], [StatusId], [UserId]) VALUES (N'C0024', CAST(N'2022-03-12T00:00:00.0000000' AS DateTime2), N'Prepare for a new career in the high-growth field of data analytics, no experience or degree required. Get professional training designed by Google and have the opportunity to connect with top employers. There are 337,400 U.S. job openings in data analytics with a $67,900 average entry-level salary.¹

Data analytics is the collection, transformation, and organization of data in order to draw conclusions, make predictions, and drive informed decision making. 

Over 8 courses, gain in-demand skills that prepare you for an entry-level job. You’ll learn from Google employees whose foundations in data analytics served as launchpads for their own careers. At under 10 hours per week, you can complete the certificate in less than 6 months. 

You’ll prepare yourself for jobs that include junior or associate data analyst, database administrator, and more. Upon completion of the certificate, you can directly apply for jobs with Google and over 130 U.S. employers, including Walmart, Best Buy, Astreya. 

75% of Google Career Certificate Graduates in the United States report an improvement in their career trajectory (e.g. new job or career, promotion or raise) within 6 months of certificate completion²

Check out all Google Career Certificates here.

¹Burning Glass: Labor Insight (Last 12 Months: Feb. 1, 2020 - Jan. 31, 2021)

²Based on program graduate survey responses, United States 2021', N'Prepare for a new career in the high-growth field of data analytics, no experience or degree required. Get professional training designed by Google and have the opportunity to connect with top employers. There are 337,400 U.S. job openings in data analytics with a $67,900 average entry-level salary.¹', N'C0024.png', N'Google Data Analytics
', 9, 3, 8, 1, NULL)
GO
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001AA', N'Course Welcome', 1, N'Graphic design is a really broad field, it can take many forms. You can be a graphic designer and just make books or logos. You could design web interfaces, or t-shirts, chocolate boxes, or political posters. But what all of these specialized areas of graphic design have in common is the design is being used to represent a product, or an idea, or a message, and convey that to an audience. Design is a way of communicating something to someone else through visual means. There are many different types of graphic designer. Some are very technical, some are very formal. Some have a practice derived by research or concept and some are driven purely by style or aesthetics, others by the desire to experiment. But they all deal with controlled communication through text and image. Sometimes designers just use image, illustration, and sometimes they just use text, typography. But mostly designers use a combination of the two tied together by the use of color and composition.', N'https://d3c33hcgiwev3.cloudfront.net/Za_uilc1EeWKcg4hVzMYgw.processed/full/540p/index.webm?Expires=1647302400&Signature=RP38vRJli8SKJVdDhLbOtGPVF2--ZYbJsXllFFiVn08HAcEOBNOXC1UnFXw2GYpTkf6AcIxJRUNXgQm0NMtjdXtI7DJbp7caenftCVd9YzPCQOibMgiHLRDmopMxXCYO62H7EBfaiuhx6NY5Pxi6j6Vgae8gMQkVIpYwZuweBGM_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001AB', N'Why Peer Review?', 2, N' Why peer review is important to a creative practice. Design is rarely a solitary practice. As a designer, you might be working with clients or have a boss you need to report to. You might also be part of a design team or even managing the team of your own. You might be asked to present a project to stakeholders at a company or pitch your services to a new client. Ultimately, your design needs to stand alone. But in the process of making design, you should be testing out your ideas with an audience, getting feedback and developing your design accordingly. Design is very intertwined with communication and to be a successful designer, you need to be able to talk about your work to explain it and show that you understand how it''s working. In different situations It may be necessary to explain your own work and other people''s work in a clear and constructive way. So in this course, you''ll be engaging in peer review to evaluate the work of your peers as well as get feedback on your own work. If you''re serious about working as a designer or improving your design skills, consider peer review as excellent practice. In peer review, you''ll be asked to observe and openly reflect on what is working and not working. It appears graphic design submission. The goal of this exercise is to help your fellow designers move their work forward and for you to get that same advice in turn.', N'https://d3c33hcgiwev3.cloudfront.net/9_at6KDeSci2reig3gnI5w.processed/full/540p/index.webm?Expires=1647302400&Signature=gzxdc16PKqfx13ssK1NCtlzvu4NwrBLlK3gVgp9r57CIzq624XuA0avIm6D1sCyg0M5H-Fe-m85Btdsu42FIrFjQbCjg7fmIaUk3vpQraPt9covV0YycN0Kpj4CIH0Y~kH0iidvutLAld~U7Nk88nt03RgXhP2TvJjPk3nfC1oU_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001AC', N'Peer Review Tips', 3, N'Peer review tips, critique and feedback are essential parts of the design process. They''re an essential way to see if your design is communicating what you intended to an audience. So in this video I''m going to outline a few tips for completing peer review assignment successfully in this class. Participation in peer review thoughtfully and meaningful will help you practice these indispensable skills. Submitting assignments, read the instructions carefully, make sure you take a look at the review criteria so you know how your assignment will be assessed. Review any examples your instructor may have provided and upload exactly what you are asked to do. If something in the instructions isn''t clear post your question in the course forums so staff can assist you. Make it your best work. This is your creation and your creativity and should be an exercise that demonstrates what you can do. Practice assignments should be opportunities to fail, but a final assignment should be something worthy of your professional portfolio.', N'https://d3c33hcgiwev3.cloudfront.net/F3paS-n6S8S6Wkvp-hvEnA.processed/full/540p/index.webm?Expires=1647302400&Signature=cHm-ep0dSnmdChBlG3PlTm9qEoX4-6CcUP3r0JVUIWU7FvRYeDLcnbfl~l1xUCbDtIsYBhM1dylbLMmf9PnOezpIB6JjIMd5G3GFbIZ8sRQ7~kJDvIAcNO4ivfQ~AdnL5vC-4OFwDeLAl6Sy3xEHRbUknqKpEpnV3U5JrCXb75o_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001BA', N'Introduction to Typography', 1, N'For many people typography can be one of the hardest aspects of graphic design to understand. But its also one of the most important. If you think about it graphic design is really made up of communication in words. And communication in pictures. A typography is half of that equation, it''s how we communicate with words. For many people, type can feel like a foreign language. It almost seems like it''s very obtuse. Like you can''t enter into it or see it or understand it in any way. So what we''re gonna try and do in this course is break down typography. .So you understand the terminology to do with it. And you understand a few basic ways to work with type. What we''re really hoping the outcome of this course will be, is that you''ll feel comfortable with using type. And you''ll be able to have a set of rules that you know how to work with type. But it''ll also hopefully free you up a little bit to start experimenting and playing with type a bit more.', N'https://d3c33hcgiwev3.cloudfront.net/E5aQ_1dGEeWVqBJeWFTSgQ.processed/full/540p/index.webm?Expires=1647302400&Signature=fdkSdAttSgoXB2sUKpmprJImZ2e7UmqnE4C3DKw0waGSv6GHrnXqVDCaqIaAzCIi6itUz5VDVxrKWa9yldRadMErnbszh4uVRZ1ouKtw8ZR4WxfdaJCS53WroJyCFkD61y4gy98mi8zDDkOkJ~1p8N9loN-xvij8702~egqxFsY_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001BB', N'The Anatomy of Letters', 2, N'Where the end of the letter form trails off is known as a spur. And obviously the ends of the letters can also be a place where serifs might exist. A lot of typographic terms are based on the human body. And that''s probably because letter forms were drawn on humanous proportions based either on proportions of the human figure, or drawn showing evidence of human hand. So let''s look at some of those terms.', N'https://d3c33hcgiwev3.cloudfront.net/RpeTxlwXEeWZgBLZEKssZQ.processed/full/540p/index.webm?Expires=1647302400&Signature=c-3zkAcwYDO1h31HHaUH9VCVAY7goDWs440zrW7QnyxQiqtz6qcklv~rYvClT4iFyQyb2hBwlEijsuE3oiXiqvJBGdVkrwtM48z3uU7AZI9PU73yjzKa9JcAGjhMeCX~yBX9foapFtIogrfYQc3TnU2LFJiqhuP4U-w2WrpCGbg_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001BC', N'Words and Spacing', 3, N'Now we''ve looked at typographic terminology to do with letterforms, let''s look at some of the terminology to do with words. Here''s a word made up of single letterforms, and they look like they''re floating in space on the page, but they''re not really floating in space, they''re aligned on an invisible line called a baseline. The baseline falls at the bottom of the capital letters and it falls at the bottom of the main, central part of the lower case letters. And you can see where a letter form like an x, for instance, really delineates that height of the lower case letters, and that in fact is called the x-height. Most lowercase letters share a common x-height. And there''s other measurements that we look at as well. If you look at the height of a capital letter, that''s called the cap-height. Now some letter forms have pieces that go above and below the x-height. When they go above the x-height, they''re called ascenders, and when they go below the x-height, they''re called descenders.', N'https://d3c33hcgiwev3.cloudfront.net/HbZK1lwWEeWSuhJSxsy6bQ.processed/full/540p/index.webm?Expires=1647302400&Signature=gugl9rcGcD-HXRwnK9qS4ZjyaLlQmlje-iCeFBAS3~yLUz3DRD2C0YUjoDMndugQnKfLXcmwiX2UVoJuENQRnGGBgm14Z2XKCtP13QwzIM-oqFtUsPUjfVv5EDNVKcYH46FEfPKwgKq7mg-lPwWixKTTSNMv6qu0ipOvdQqRoAo_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001CA', N'Introduction to Shape & Color', 1, N'This week we''re going to look at shape and color in graphic design. We''ve already looked at images and how they work and now we''re going to look at objects and color. But not as tools to make images of things, but more in terms of abstract graphic form. To start, we''ll be looking at how abstract shapes communicate through their form, and how they can be used to create marks, icons, and symbols. Not surprisingly, graphic shapes are all around us, most noticeably as logos and icons, but also as major or secondary elements in almost every piece of on-screen or printed design. Quite simply, shapes are everywhere. Whether they''re active or passive, communicative or neutral, they form an invisible background to most of graphic design.', N'https://d3c33hcgiwev3.cloudfront.net/7QXekVdGEeWpwArLK7EZ9w.processed/full/540p/index.webm?Expires=1647302400&Signature=GIkezwqXgB3H4BsX7niRS02TwVj8t0GAHBU-WG7NBsAiXbqeEtEI1tdySo1EjrqvIGOfMVmAz683Y3P0xgiMsNbKeZ5YxSq7ajU1t2pMJ5xceKl0EdBsF9FFmPznKT94kznZb9qoHESU2NrrtYRFlC9MeMj~Fm3680aKoUYq7J0_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001CB', N'Graphic Shapes', 2, N'In this segment we''re going to look at graphic shapes, how designers use shapes and form and simple shapes can be used by designers to help with contrast, add visual interest. They can be an element that sits aside typography or imagery. And they can really be a unifying element that works together in a larger system. So we''re gonna start out by really looking at these three basic shapes. And these shapes typify the kind of directional qualities that other shapes might have. So you can see the circle is represented as the shape is circular. The triangle, the direction of it is more diagonal. And the square, the direction of it is horizontal and vertical.', N'https://d3c33hcgiwev3.cloudfront.net/eC5MSFwFEeWzLwrzeFOkAw.processed/full/540p/index.webm?Expires=1647302400&Signature=UPug5ljDEfsSfODCsZWj5HKPwxzqy7N05cMFC-kosrPnwiFAeFgQ4iUDHwE2gHvygKBJTurtt8h28K3IxJ6Sqjbo~naAz-P~vncnIKQf3lUzvXTQoWxiFbUbysZy-fOQvnhooxkSADBb5W~NEn9O~nicJ7ybBLMU1qRX5xrGX0U_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001CC', N'Visual Contrast', 3, N'Some of the ideas that we''re going to look at concerning shape and form and color are based on the principles from Johannes Itten who was a teacher at the Bauhaus in the early 1920''s. And he developed a basic course or a foundation there that looked at shape and form and color and composition in a way that hadn''t really been done before. It was a very modern way of looking at these ideas. And he did it in a way that these basic principles applied to fine art, and to industrial design, to graphic design, to a lot of different practices.', N'https://d3c33hcgiwev3.cloudfront.net/qV5PFFwFEeWMhg7baGhc3w.processed/full/540p/index.webm?Expires=1647302400&Signature=HCG5YfXL3YD-HWxrLHEm6FfgYhtIPYikSlxTDQdDQBcfQBYYNkCSk9pTAeD9QIQfHTjoqF-wYHrltYXjXwxar91HDk0q9NHKAGKpQcaGqjbYXWR6vbiE0jh-0pAYe7LISY9EA3wL8HjReLlF0heL1~u63pf2gePgzMFYHWQ5pvE_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001DA', N'Introduction to Composition', 1, N'So far in this course, we''ve broken design down into smaller parts in order to investigate and experience it. To make it understandable and to learn about it. Now we''re going to think about how to put some of those component pieces back together again. And we''re going to use composition to do that.', N'https://d3c33hcgiwev3.cloudfront.net/_oSgV1dGEeWKcg4hVzMYgw.processed/full/540p/index.webm?Expires=1647302400&Signature=FRJckQWXsAfbgVq8t1I3lmDNk4L7nFwM2sNjvw8KlD2HLmIXxjbAZ7-q7QYL~I2oQbcN6J8nvDokM7eEfMnvDuu59A5b~p9k2cov77mHs-ZnbhoB94YY2fp8TviojNBnRatQA9r3SF6HEcZk-HB1QL~YtEAHQWgKV0Mb-qn7MQU_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001D')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001DB', N'Principles of Composition', 2, N'Composition is basically the arrangement and positioning of elements on a surface to form a piece of graphic design. So this could be on screen, it could be in print, but basically it''s putting together any of those elements. It could be typography, it could be shapes, it could be images. And composition is a very powerful tool. To begin with, it can really make the difference between things not making any sense, and exactly the same elements coming together and making sense.', N'https://d3c33hcgiwev3.cloudfront.net/H211QFvqEeWVtgr31Ad8Fw.processed/full/540p/index.webm?Expires=1647302400&Signature=lRj2lYFDkMKYYUG6jPEBWLvwn14EPjM6QSjDqOhFw-nVhzEoyUGWnb4XWIu7sXPOLBQ8uSXMLgIDucemDNJgWWMtSNtCcWK1oNCaEIi8ISZr-01MKpWcd7z8T35Nx8Z9DhhS3Yy7vYvCKBlptL6nChEfeG6rqfd9CzJ675wf0rY_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001D')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0001DC', N'Visual Contrasts', 3, N'So let''s look at weight now and try and isolate weight as a contrast. So here you can see we have two shapes that are very even. Exactly the same tone. They have the same visual weight, which is obviously related to their scale and their form as well. But you can see just by turning one into an outline and leaving the other solid, the dark shape suddenly has a lot more presence on the page. A lot more contrast volume. So it appears to have more weight. And obviously we can do this tonally as well. We can look at a 50% shape here, and look at the difference between that tonally. And again, it''s in terms of contrast. So the shape on the right appears to be visually larger than the shape on the left, and visually heavier as well.', N'https://d3c33hcgiwev3.cloudfront.net/KyJhSlvwEeWZgBLZEKssZQ.processed/full/540p/index.webm?Expires=1647302400&Signature=a5XryZ-WomRA1mXoCObI-DS5tlVdFzLJAyevsH1QtT~ws3AIdeWgqYaNBlPyQYUadXksD18JI~he4EsgIKBwKC6~jwqN1wUXepMEqaQoLOF2vyLSeWZTvjRLx5JhB3aPf5RUfIwjROvZvsKFH2PaoGHdTFfnGTFG5~jQQ-1gulA_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0001D')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002AA', N'Introduction', 1, N'Indigenous Canada comes from an Indigenous perspective, and, out of respect, we attempted to use the languages of the people as much as possible, especially when describing the names of places and explaining meaningful concepts. We have tried to do the best of our ability to find and use the proper pronunciations. But remember, these aren''t our first languages, so we apologize beforehand for any mistakes in our enunciations. If the legends fall silent, who will teach the children of our ways? Welcome to Indigenous Canada, a 12-lesson MOOC that explores Indigenous histories and contemporary issues in Canada. My name is Tracey Bear, and I''m from Montreal Lake First Nation. And I''m Alannah Mandamin-Shawanda, from Wikwemikong First Nation. And I am Isaac Twinn, from Sawridge First Nation in the Lesser Slave Lake area. ', N'https://d3c33hcgiwev3.cloudfront.net/duCgtqhnEees8xJDNprx2g.processed/full/540p/index.webm?Expires=1647302400&Signature=GHU5GVFRX2h3kwEgQeT1xo2DIMsdT-nMSRgJuKbhE2NkwM-csOWNLr5WqCJV032QI9XWaUIk4s8bdB9EbZF5sBk4CmT3nPTChjoTwnU0KkgU95sbFpVx2DnWjl0tKPTAN~GZFwY5hTxJ4tENjpzAFHwTea1nNPEuQtjrWgsTITU_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002AB', N'Storytelling', 2, N'First, stories connect the past to the present and to future generations. There are many versions of the Wisacejak Creation Story, but the meaning remains the same as it is told from great-grandmothers to their great-grandchildren. Stories are gifts to be shared and handed down generation to generation. As a Nehiyaw''iskwew, or Cree woman can be reassured that while she may not have met her great-great-grandmother. The Wisacejak story transcends time and connects her to her ancestors. This means that a story I hear from my grandmother is the same one that she heard from her grandmother and so and so on. These stories allow us to communicate with future generations in the same way our ancestors communicate with us.', N'https://d3c33hcgiwev3.cloudfront.net/1ZSCJdwsEealhw7wjDSRNA.processed/full/540p/index.webm?Expires=1647302400&Signature=chjhYq2q8S97bq2K9JRFK~1tPzzQ~e6HvxG9onsf-dZqHrLy8ThbMk58kH9~YOqBXvEO-g-hKbudTIaaWnzWueuDrDJf2GEAmEDLYtGCpfsHwjGObWoj3HDnVRDp6KzHIS3YQdUps-X0iOkqICZBVWHjAfldrA6Iq99COis~NLI_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002AC', N'Indigenous Worldviews', 3, N'Sharing all the worldviews of every Indigenous nation does not fall within the scope of this lesson. That would probably take us years. However, we will talk briefly about four different worldviews, Inuit, Nehiyawak, Kanien:keha''ka or Mohawk, and Tlingit. First, we will discuss some commonalities between Indigenous nations. Then, we will take a brief look at some of the ways in which each of these nations, the Inuit, Nehiyawak, Kanien:keha''ka, and Tlingit understand their place in the world and how these worldviews rationalize thoughts and actions.', N'https://d3c33hcgiwev3.cloudfront.net/b_mAn9wtEeapog4KcuzcmA.processed/full/540p/index.webm?Expires=1647302400&Signature=BBImPCH~o8DrGgIKyMxXmroTgo0mFsJXpogqYJmOwhDTeqWM6-325avlwPCM52SUlckWbVSJhYNP7Ewzta2DLf3C1FzlKXV7N73oNNUX3ZgvZZiIDFTo74afIdTYAY4JNF9lYjtlIZN7~IBxxMprF8IobElDIKluXwN0xRXNVoM_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002A')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002BA', N'Pre-Contact North American Networking', 1, N'The Wyandot, or Huron, were agriculturalists and lived in villages in what is now present day Southern Ontario. This nation had some of the highest population densities in Canada, with estimates ranging from 20,000 to 33,000 inhabitants. As a consequence of contacting colonization, the Indigenous peoples of Western Hemisphere experienced a tragic and massive loss of population.', N'https://d3c33hcgiwev3.cloudfront.net/EUK6YtwyEea8ewolfPqLSA.processed/full/540p/index.webm?Expires=1647302400&Signature=PaVJcNQtFxlPzHn5C6sqVeuiLyZIsOD~MHopTfLxKfvqMgDRwC5jCu6CEiK0hEhYZDm5uRC76AchxHCI41EX8BLnj7ETdjfdLp2LytYiChPXSS-NxW1671qY9i0UFSMc7phPc8TwdoCAzweUnNHLeNhJ1eqaXNRAf7wq1Z-DmjA_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002BB', N'Colonization', 2, N'Before we begin our discussion of the fur trade, a major activity that brought Europeans in great numbers to Indigenous lands, we must first talk about the first encounters between Europeans and Indigenous peoples in what is now Canada. We can''t begin a conversation about the history of Canada as a nation without talking about colonization.', N'https://d3c33hcgiwev3.cloudfront.net/TKWh_AsoEeerCw6pb06wQA.processed/full/540p/index.webm?Expires=1647302400&Signature=aaUqwTR-vOkLAdVxRhVzhib-21WnE-C4aI3srSO9H3tzL8JupekwDsWWbXjiN9JNxciOYt1GC~LpzkyV9tm~8wv0QKFGvuwTSqCbCKEkbyiEjGoEP26ke4BVKXFU9Bc91x6xy-3dIq29yxgfSaIP5mkiLW7T7SKQGU99YfQcjLg_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002BC', N'The Fur Trade Part 1', 3, N'Trading old clothing or used furs gave them access to European technologies and material goods like metal objects, such as needles, pots and kettles, axes, ice chisels, hatchets, knives and projectile points. Other goods were traded, like guns, bullets, beads, linens for fishing nets, and mirrors. The only metal accessible before contact was copper, but it was too soft for utilitarian purposes.', N'https://d3c33hcgiwev3.cloudfront.net/TKXJKAsoEeeBNhJf9KzsOA.processed/full/540p/index.webm?Expires=1647302400&Signature=AlFfjgQPYOsY-DufnPMWg-0zJPC9yNEU8jf~Gmf2RnpVJbqrVZ6eIO8Pk0Zqo6YcDBjdn5IStFF9zVgbU9~ocGh2Y1673EpftnGgiLsHFsLfnlIPbQh5M18In9i0xLCJV7g7UIDe8Dw7VqEFSPRh47rRM6MCsrDQeKd7kavQum8_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002B')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002CA', N'Perspectives on Treaty Making', 1, N'We have learned in previous lessons that when Europe''s competing empires, including the British and the French, arrived in North America, Indigenous peoples were already resident throughout the continent with their own distinct cultures and intricate political structures. Indigenous people saw the arrival of these new people as both an opportunity to create new political alliances and an occasion to create new trading partnerships. This lesson examines the subsequent treaty agreements and alliances made between North America''s Indigenous peoples, and the newly arrived empires in the area that eventually became Canada. The Two Row Wampum Belt of the Haudenosaunee, also known as that Iroquois, is a great example that illustrated one way that Indigenous peoples recorded and preserved their laws and governance systems. The Two Row Wampum Belt is made from either whelk shell, quahog, or hard shelled clams. The belt''s rows of cylindrical purple and white beads are bound together with hemp that runs its full length.', N'https://d3c33hcgiwev3.cloudfront.net/JEB5iBPbEeeExg76uXNxYA.processed/full/540p/index.webm?Expires=1647302400&Signature=ME1oCWpiviqH7MwRzpkHZGWPpq~c2MRB7kltfnZllW5viJtdnh0plg0C7hNh75MOUF7CtUpSqQmy-qhtnbseXbD27XzlIUSNcwsDe4hmSZ2n5NOYbI6UntFp3PYnhlPFk0CchIu8-S-QaiLznF6TbKObu2Rf4UtTfFO~XgQ2iNk_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002CB', N'Numbered Treaties Part 1', 2, N'Previously, we discussed Rupert''s Land, the area of present day northwest Canada originally granted to the Hudson''s Bay Company for the purposes of trading. Although the Hudson''s Bay Company never owned title to the lands in northwest, they were expected to negotiate with the area''s Indigenous peoples if they wanted to develop or settle any of the territory. When the Earl of Selkirk was granted three-hundred thousand (300,000) square kilometres at the Forks of the Red and Assiniboine Rivers, the resident Cree, Assiniboine, Saulteaux and Métis were not consulted. To rectify this, in 1817, Chief Peguis and four other leaders entered into an agreement with Selkirk granting the Red River settlement access to the lands adjacent to the Forks. Reverting to the Hudson''s Bay Company in 1836 and the Canadian government in 1869, both argued that Selkirk''s 1817 agreement constituted a land surrender, but in 1863 Peguis published a rebuttal stating that the Selkirk Treaty was never intended as a session of title.', N'https://d3c33hcgiwev3.cloudfront.net/TbjfjQsrEeeBNhJf9KzsOA.processed/full/540p/index.webm?Expires=1647302400&Signature=kJfzv9f6N-pIme1n1QLDvgpeQC6zO9CVrQRR6NRCSxOwkZoWUFVnJYSyApPb5Y5J-CsP00Ta-bLHzMB-8reI2TqTJoaw3NXFuq-RnulqNfeaTsRapt25~GRNfibkXvCqQZTZtxLVR8n94WaVAAtM65pItRqFLmXPvQs8hgRGvHY_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002CC', N'Numbered Treaties Part 2', 3, N'Other leaders, like Big Bear, continued to demand better terms. During negotiations, when offered one square mile for each family within the reserve, Chief Pitikwahanapiwiyin or Poundmaker, famously argued: [MUSIC] >> The governor mentions how much land is to be given to us. He says 640 acres, one mile square for each family, he will give us. This is our land! It isn''t a piece of pemmican to be cut off and given in little pieces back to us. It is ours and we will take what we want.', N'https://d3c33hcgiwev3.cloudfront.net/QkNsKAswEeeYfApVbTauLA.processed/full/540p/index.webm?Expires=1647302400&Signature=UsqD~mrdWMJ9VtEQeCrLmGH8UAjEMwaBiskJer9zbLp-3xLfA6fovWQnkTGJoR6ARimcysVw--SwvfbXFg1vzsB6XsKB8FmWs6SFMg5dpF9Jn2VEZxG1m~ebX0VxafihNV66LCc3ZMM-de3teVh1lR7U4vUm9CvSJxTjFJ6j8zg_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002C')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002DA', N'Indigenous Concepts of Law', 1, N'Throughout history, people gathered together to create communities and societies, as they relied upon each other for companionship and survival. As people congregated together in the tens, hundreds, thousands, or even millions, moral codes and behavioural measures were needed. Without structured principles, conflict and disorder would be inevitable. Prior to Europeans arriving in North America, Indigenous communities had governing bodies to develop guidelines to co-exist peacefully and prosper within their environment.', N'https://d3c33hcgiwev3.cloudfront.net/hmiEeNzVEeaPGwpHRIQ-5A.processed/full/540p/index.webm?Expires=1647302400&Signature=h-U5HPf9gWPiBuzgeElaJXv1PMnooKUPN7G-DG6ZMO-lVDqOD6-X8eryC~-OFjbU2zpJoi4lhYAoZoCWfavvziif~-bfzv6IaiLQLPzeXUzV9yYjQHm88RcaUf9ccb9Wb32FLfkMm9LD73qDC5PARqdh909F-AZ48Y1eagbE55o_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002D')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002DB', N'Outside Influences Part 1', 2, N'Canadian courts and Indigenous nations disagree with the interpretation of those rights. The result of this has been repeated court battles and disagreements over who has land rights, subsistence rights claims, and Aboriginal jurisdiction over matters such as fisheries and wildlife management. The concept of civilization emerged in 18th century Europe to describe complex, centralized societies removed and disassociated from the natural environment. For Europeans, a civilized person meant a cultural identity focused around Christianity, technology, and settled lifestyles.', N'https://d3c33hcgiwev3.cloudfront.net/QkQJAwswEeerCw6pb06wQA.processed/full/540p/index.webm?Expires=1647302400&Signature=Hn9YX9Swv8oe7aASUl9gCyXAqhGO8~PqOkyEvm4ZfWDku~encyZDs8aEyvUAfcMxe8v8vw7j2A~s1NkdBBog7pUgifTixoRb2ofPrznprbF-FLi5hvwhL8g7fJQ75GwdLZgBoeDC37RCzXRBIXYBXA8KXCG~66NX8u-YLoudmKI_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002D')
INSERT [dbo].[Lessons] ([LessonId], [LessonName], [LessonOrder], [Script], [VideoURL], [TopicId]) VALUES (N'L0002DC', N'Outside Influences Part 2', 3, N'James Douglas, appointed as the Hudson''s Bay Company''s Chief Factor in 1851, enacted several land title policies. They were based on the same agreements made in New Zealand with the Maori in 1840. It''s worth nothing that the Maori and the British had two very different interpretations of these agreements. To the British, this meant while Indigenous people had a right of occupancy, they did not have title to the land.', N'https://d3c33hcgiwev3.cloudfront.net/SCxX2ws0EeeBNhJf9KzsOA.processed/full/540p/index.webm?Expires=1647302400&Signature=ETpGddWqGgX9E0w23uuaDALHT8e-hHqDsb6Y9kO1pCxZV9mpm1b7~BSfY7YE5gKxVu~9gJqHVKtXf~~ADz2k9oeqDdZpJOGOA0BWJs-Xv95P3pG~hXYe5HtV3QTx10jaIIxXEOYr12~qstbdlFPZLyNcM34U4Bl1vzvjQLurS5A_&Key-Pair-Id=APKAJLTNE6QMUY6HBC5A', N'T0002D')
GO
SET IDENTITY_INSERT [dbo].[PricePackages] ON 

INSERT [dbo].[PricePackages] ([PricePackageId], [PricePackageName], [Description], [Price], [StatusId]) VALUES (1, N'Standard', N'This is standard plan.', 0, 1)
INSERT [dbo].[PricePackages] ([PricePackageId], [PricePackageName], [Description], [Price], [StatusId]) VALUES (2, N'Premium', N'This is premium plan.', 5, 1)
INSERT [dbo].[PricePackages] ([PricePackageId], [PricePackageName], [Description], [Price], [StatusId]) VALUES (3, N'Vip', N'This is vip plan.', 12, 1)
SET IDENTITY_INSERT [dbo].[PricePackages] OFF
GO
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'12781', N'A', N'What is true about private constructor?', N'Object of private constructor can only be created within class. Private constructor is used in singleton pattern.', 1, 1, N'C0001', N'Private constructor ensures only one instance of a class exist at any point of time', N'Private constructor ensures multiple instances of a class exist at any point of time', N'Private constructor eases the instantiation of a class', N'Private constructor allows creating objects in other classes', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'13354', N'C', N'Which of the following has the highest memory requirement?', N'JVM is the super set which contains heap, stack, objects, pointers, etc.', 1, 1, N'C0001', N'Heap', N'Stack', N'JVM', N'Class', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'17173', N'D', N'Which of these events will be generated if we close an applet’s window?', N'WindowEvent is generated when a window is activated, closed, deactivated, deiconfied, iconfied, opened or quit.', 1, 1, N'C0001', N'ActionEvent', N'ComponentEvent', N'AdjustmentEvent', N'WindowEvent', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'18', N'C', N'Which component is used to compile, debug and execute the java programs?', N'JDK is a core component of Java Environment and provides all the tools, executables and binaries required to compile, debug and execute a Java Program.', 100, 1, N'C0001', N'JRE', N'JIT', N'JDK', N'JVM', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'19835', N'B', N'Who invented Java Programming?', N'Java programming was developed by James Gosling at Sun Microsystems in 1995. James Gosling is well known as the father of Java.', 1, 2, N'C0015', N'Guido van Rossum', N'James Gosling', N'Dennis Ritchie', N'Bjarne Stroustrup', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'20', N'C', N'Which of these cannot be used for a variable name in Java?', N'Keywords are specially reserved words that can not be used for naming a user-defined variable, for example: class, int, for, etc.', 100, 1, N'C0001', N'identifier & keyword', N'identifier', N'keyword', N'none of the mentioned', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'21', N'D', N'What is the extension of java code files?', N'Java files have .java extension.', 100, 2, N'C0001', N'.js', N'.txt', N'.class', N' .java', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'22', N'D', N'Which environment variable is used to set the java path?', N'JAVA_HOME is used to store a path to the java installation.', 100, 1, N'C0001', N'MAVEN_Path', N'JavaPATH', N'JAVA', N'JAVA_HOME', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'23', N'C', N'Which of the following is not an OOPS concept in Java?', N'There are 4 OOPS concepts in Java. Inheritance, Encapsulation, Polymorphism and Abstraction.', 100, 1, N'C0001', N'Polymorphism', N'Inheritance', N'Compilation', N'Encapsulation', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'25', N'B', N'What is not the use of “this” keyword in Java?', N'“this” is an important keyword in java. It helps to distinguish between local variable and variables passed in the method as parameters.', 100, 3, N'C0001', N'Referring to the instance variable when a local variable has the same name', N'Passing itself to the method of the same class', N'Passing itself to another method', N'Calling another constructor in constructor chaining', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'26', N'B', N'Which of the following is a type of polymorphism in Java Programming?', N'There are two types of polymorphism in Java. Compile time polymorphism (overloading) and runtime polymorphism (overriding).', 100, 1, N'C0001', N'Multiple polymorphism', N'Compile time polymorphism', N'Multilevel polymorphism', N'Execution time polymorphism', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'27', N'C', N'How can we remove an object from ArrayList?', N'There are 2 ways to remove an object from ArrayList. We can use overloaded method remove(int index) or remove(Object obj). We can also use an Iterator to remove the object.', 100, 1, N'C0001', N'remove() method', N'using Iterator', N'remove() method and using Iterator', N'delete() method', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'28', N'D', N'Which of the below is not an implementation of List interface?', N'SessionList is not an implementation of List interface. The others are concrete classes of List.', 100, 1, N'C0001', N'RoleUnresolvedList', N'Stack', N'AttibuteList', N'SessionList', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'30106', N'B', N'Which of the following is a garbage collection technique?', N'A mark and sweep garbage collection consists of two phases, the mark phase and the sweep phase. I mark phase all the objects reachable by java threads, native handles and other root sources are marked alive and others are garbage. In sweep phase, the heap is traversed to find gaps between live objects and the gaps are marked free list used for allocating memory to new objects.', 1, 1, N'C0001', N'Cleanup model', N'Mark and sweep model', N'Space management model', N'Sweep model', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'33240', N'D', N'What is not the use of “this” keyword in Java?', N'“this” is an important keyword in java. It helps to distinguish between local variable and variables passed in the method as parameters.', 1, 1, N'C0001', N'Passing itself to another method', N'Calling another constructor in constructor chaining', N'Referring to the instance variable when local variable has the same name', N'Passing itself to method of the same class', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'33549', N'A', N'Where is a new object allocated memory?', N'A new object is always created in young space. Once young space is full, a special young collection is run where objects which have lived long enough are moved to old space and memory is freed up in young space for new objects.', 1, 1, N'C0001', N'Young space', N'Old space', N'Young or Old space depending on space availability', N' JVM', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'37589', N'C', N'What is false about constructor?', N'The constructor cannot have a return type. It should create and return new objects. Hence it would give a compilation error', 1, 1, N'C0001', N'Constructors cannot be synchronized in Java', N'Java does not provide default copy constructor', N'Constructor can have a return type', N'“this” and “super” can be used in a constructor', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'39286', N'D', N'Which statement is true about Java?', N'Java is called ‘Platform Independent Language’ as it primarily works on the principle of ‘compile once, run everywhere’.', 1, 1, N'C0014', N'Java is a sequence-dependent programming language', N'Java is a code dependent programming language', N'Java is a platform-dependent programming language', N'Java is a platform-independent programming language', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'44434', N'C', N'Which exception is thrown when java is out of memory?', N'The Xms flag has no default value, and Xmx typically has a default value of 256MB. A common use for these flags is when you encounter a java.lang.OutOfMemoryError.', 1, 1, N'C0001', N'MemoryFullException', N'MemoryOutOfBoundsException', N'OutOfMemoryError', N'MemoryError', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'50981', N'D', N'Which of these packages contains all the classes and methods required for even handling in Java?', N'Most of the event to which an applet response is generated by a user. Hence they are in Abstract Window Kit package, java.awt.event.', 1, 2, N'C0014', N'java.applet', N'java.awt', N'java.event', N'java.awt.event', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'53036', N'A', N'What is -Xms and -Xmx while starting jvm?', N'JVM will be started with Xms amount of memory and will be able to use a maximum of Xmx amount of memory. java -Xmx2048m -Xms256m.', 1, 1, N'C0001', N'Initial; Maximum memory', N'Maximum; Initial memory', N'Maximum memory', N'Initial memory', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'60495', N'C', N'Which of these methods are used to register a mouse motion listener?', N'None', 1, 1, N'C0001', N'addMouse()', N'addMouseListener()', N'addMouseMotionListner()', N'eventMouseMotionListener()', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'60677', N'B', N'What is true about constructor?', N'Constructor returns a new object with variables defined as in the class. Instance variables are newly created and only one copy of static variables are created.', 1, 1, N'C0001', N'It can contain return type', N'It can take any number of parameters', N'It can have any non access modifiers', N'Constructor cannot throw an exception', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'64423', N'C', N'What would be the behaviour if this() and super() used in a method?', N'this() and super() cannot be used in a method. This throws compile time error.', 1, 1, N'C0001', N'Runtime error', N'Throws exception', N'compile time error', N'Runs successfully', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'65695', N'D', N'What would be the behaviour if one parameterized constructor is explicitly defined?', N'The class compiles successfully. But the object creation of that class gives a compilation error.', 1, 1, N'C0001', N'Compilation error', N'Compilation succeeds', N'Runtime error', N'Compilation succeeds but at the time of creating object using default constructor, it throws compilation error', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'66009', N'A', N'What would be behaviour if the constructor has a return type?', N'The constructor cannot have a return type. It should create and return new object. Hence it would give compilation error.', 1, 1, N'C0001', N'Compilation error', N'Runtime error', N'Compilation and runs successfully', N'Only String return type is allowed', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'69482', N'D', N'What is true about Class.getInstance()?', N'Class class provides list of methods for use like getInstance().', 1, 1, N'C0001', N'Class.getInstance calls the constructor', N'Class.getInstance is same as new operator', N'Class.getInstance needs to have matching constructor', N'Class.getInstance creates object if class does not have any constructor', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'74091', N'A', N'How to get prints of shared object memory maps or heap memory maps for a given process?', N'We can use jmap as jmap -J-d64 -heap pid.', 1, 1, N'C0001', N'jmap', N'memorymap', N'memorypath', N'jvmmap', 1)
INSERT [dbo].[QuestionBanks] ([QuestionId], [Answer], [Content], [Explanation], [Weight], [QuizLevelId], [CourseId], [OptionA], [OptionB], [OptionC], [OptionD], [StatusId]) VALUES (N'98404', N'B', N'What is true about protected constructor?', N'Protected access modifier means that constructor can be accessed by child classes of the parent class and classes in the same package.', 1, 1, N'C0001', N'Protected constructor can be called directly', N'Protected constructor can only be called using super()', N'Protected constructor can be used outside package', N'Protected constructor can be instantiated even if child is in a different package', 1)
GO
SET IDENTITY_INSERT [dbo].[QuizLevels] ON 

INSERT [dbo].[QuizLevels] ([QuizLevelId], [QuizLevelName]) VALUES (1, N'Easy')
INSERT [dbo].[QuizLevels] ([QuizLevelId], [QuizLevelName]) VALUES (2, N'Medium')
INSERT [dbo].[QuizLevels] ([QuizLevelId], [QuizLevelName]) VALUES (3, N'Hard')
SET IDENTITY_INSERT [dbo].[QuizLevels] OFF
GO
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'12781')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'12781')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'13354')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'13354')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'17173')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'17173')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'18')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'18')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'19835')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'19835')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'20')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'63714', N'20')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'21')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'22')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'23')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'25')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'26')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'27')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'28')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'30106')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'33240')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'33549')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'37589')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'39286')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'44434')
INSERT [dbo].[QuizQuestions] ([QuizId], [QuestionId]) VALUES (N'13735', N'50981')
GO
SET IDENTITY_INSERT [dbo].[QuizTypes] ON 

INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (1, N'Assignment 1')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (2, N'Assignment 2')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (3, N'Progress Test 1')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (4, N'Progress Test 2')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (5, N'Progress Test 3')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (6, N'Practice')
INSERT [dbo].[QuizTypes] ([QuizTypeId], [QuizTypeName]) VALUES (7, N'Homework')
SET IDENTITY_INSERT [dbo].[QuizTypes] OFF
GO
INSERT [dbo].[Quizzes] ([QuizId], [Description], [Duration], [Name], [QuestionNum], [TopicId], [QuizTypeId], [QuizLevelId], [CourseId]) VALUES (N'13735', N'Day la description 2  ', 30, N'SWY305', 20, N'T0001C', 4, 2, NULL)
INSERT [dbo].[Quizzes] ([QuizId], [Description], [Duration], [Name], [QuestionNum], [TopicId], [QuizTypeId], [QuizLevelId], [CourseId]) VALUES (N'63714', N'Day la description cho SWP', 22, N'SWP391 Test 1', 6, N'T0001B', 3, 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[Slides] ON 

INSERT [dbo].[Slides] ([SlideId], [SlideValue]) VALUES (1, N'Trending')
INSERT [dbo].[Slides] ([SlideId], [SlideValue]) VALUES (2, N'Recommended')
INSERT [dbo].[Slides] ([SlideId], [SlideValue]) VALUES (3, N'Normal')
SET IDENTITY_INSERT [dbo].[Slides] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusValue]) VALUES (1, N'Active')
INSERT [dbo].[Status] ([StatusId], [StatusValue]) VALUES (2, N'Inactive')
INSERT [dbo].[Status] ([StatusId], [StatusValue]) VALUES (3, N'Pending')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0001A', 1, N'Fundamentals of Imagemaking', N'C0001')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0001B', 2, N'Fundamentals of Typography', N'C0001')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0001C', 3, N'Fundamentals of Shape and Color', N'C0001')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0001D', 4, N'Fundamentals of Composition', N'C0001')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0002A', 1, N'Worldview', N'C0002')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0002B', 2, N'Fur Trade', N'C0002')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0002C', 3, N'Trick or Treaty', N'C0002')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0002D', 4, N'New Rules, New Game', N'C0002')
INSERT [dbo].[Topics] ([TopicId], [TopicOrder], [TopicName], [CourseId]) VALUES (N'T0002E', 5, N'Killing the Indian in the Child', N'C0002')
GO
INSERT [dbo].[Users] ([Id], [FullName], [Address], [ProfilePictureURL], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'', N'David Dang', NULL, NULL, N'dtd', N'DTD', N'datdthe151528@fpt.edu.vn', N'DATDTHE151528@FPT.EDU.VN', 1, N'AQAAAAEAACcQAAAAECpLfKWpuF9sy+E3CHo9sG8e62gpwWnmKB7tpCGD6p3TxHBkAFHWM8UHe5n7c2M5UQ==', N'II6BW524GDBNEWOSLHVKXRAU3RYOWIXY', N'35e8f033-4d17-43f0-a57e-8474aa66ed08', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[Users] ([Id], [FullName], [Address], [ProfilePictureURL], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd3089f74-bf5b-4ee8-8c6b-520e89a36ff6', N'David Dang', NULL, NULL, N'tiendat91', N'TIENDAT91', N'datdang912001@gmail.com', N'DATDANG912001@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEH/Gpc4LjQbUTmABel1AI6g12YUQfFbWoe0ho0HeqIMye4XAgMjtScVXewPhX60nFw==', N'JIA4SCEPFNKG5CS25ESVNPPM6VYBLEEI', N'ccf76e1b-ed42-47d3-b2f5-47d30f35cadd', NULL, 0, 0, NULL, 1, 0)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AttemptDetaileds_QuestionBankId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AttemptDetaileds_QuestionBankId] ON [dbo].[AttemptDetaileds]
(
	[QuestionBankId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Attempts_QuizId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Attempts_QuizId] ON [dbo].[Attempts]
(
	[QuizId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Attempts_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Attempts_UserId] ON [dbo].[Attempts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Blogs_CategoryId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_CategoryId] ON [dbo].[Blogs]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Blogs_SlideId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_SlideId] ON [dbo].[Blogs]
(
	[SlideId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Blogs_StatusId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_StatusId] ON [dbo].[Blogs]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Blogs_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_UserId] ON [dbo].[Blogs]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Comments_BlogId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Comments_BlogId] ON [dbo].[Comments]
(
	[BlogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Comments_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Comments_UserId] ON [dbo].[Comments]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_CourseOwners_CourseId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_CourseOwners_CourseId] ON [dbo].[CourseOwners]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Courses_CategoryId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Courses_CategoryId] ON [dbo].[Courses]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Courses_SlideId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Courses_SlideId] ON [dbo].[Courses]
(
	[SlideId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Courses_StatusId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Courses_StatusId] ON [dbo].[Courses]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Courses_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Courses_UserId] ON [dbo].[Courses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Lessons_TopicId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Lessons_TopicId] ON [dbo].[Lessons]
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PricePackages_StatusId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_PricePackages_StatusId] ON [dbo].[PricePackages]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_QuestionBanks_CourseId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuestionBanks_CourseId] ON [dbo].[QuestionBanks]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionBanks_QuizLevelId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuestionBanks_QuizLevelId] ON [dbo].[QuestionBanks]
(
	[QuizLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionBanks_StatusId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuestionBanks_StatusId] ON [dbo].[QuestionBanks]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_QuizQuestions_QuestionId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_QuizQuestions_QuestionId] ON [dbo].[QuizQuestions]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Quizzes_CourseId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Quizzes_CourseId] ON [dbo].[Quizzes]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Quizzes_QuizLevelId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Quizzes_QuizLevelId] ON [dbo].[Quizzes]
(
	[QuizLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Quizzes_QuizTypeId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Quizzes_QuizTypeId] ON [dbo].[Quizzes]
(
	[QuizTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Quizzes_TopicId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Quizzes_TopicId] ON [dbo].[Quizzes]
(
	[TopicId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleClaims_RoleId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_RoleClaims_RoleId] ON [dbo].[RoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[Roles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Topics_CourseId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Topics_CourseId] ON [dbo].[Topics]
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserClaims_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserClaims_UserId] ON [dbo].[UserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserLogins_UserId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserLogins_UserId] ON [dbo].[UserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserPricePackages_PricePackageId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserPricePackages_PricePackageId] ON [dbo].[UserPricePackages]
(
	[PricePackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[Users]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 15-Mar-22 4:18:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[Users]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttemptDetaileds]  WITH CHECK ADD  CONSTRAINT [FK_AttemptDetaileds_Attempts_AttemptId] FOREIGN KEY([AttemptId])
REFERENCES [dbo].[Attempts] ([AttemptId])
GO
ALTER TABLE [dbo].[AttemptDetaileds] CHECK CONSTRAINT [FK_AttemptDetaileds_Attempts_AttemptId]
GO
ALTER TABLE [dbo].[AttemptDetaileds]  WITH CHECK ADD  CONSTRAINT [FK_AttemptDetaileds_QuestionBanks_QuestionBankId] FOREIGN KEY([QuestionBankId])
REFERENCES [dbo].[QuestionBanks] ([QuestionId])
GO
ALTER TABLE [dbo].[AttemptDetaileds] CHECK CONSTRAINT [FK_AttemptDetaileds_QuestionBanks_QuestionBankId]
GO
ALTER TABLE [dbo].[Attempts]  WITH CHECK ADD  CONSTRAINT [FK_Attempts_Quizzes_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([QuizId])
GO
ALTER TABLE [dbo].[Attempts] CHECK CONSTRAINT [FK_Attempts_Quizzes_QuizId]
GO
ALTER TABLE [dbo].[Attempts]  WITH CHECK ADD  CONSTRAINT [FK_Attempts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Attempts] CHECK CONSTRAINT [FK_Attempts_Users_UserId]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Slides_SlideId] FOREIGN KEY([SlideId])
REFERENCES [dbo].[Slides] ([SlideId])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Slides_SlideId]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Status_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Status_StatusId]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Users_UserId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Blogs_BlogId] FOREIGN KEY([BlogId])
REFERENCES [dbo].[Blogs] ([BlogId])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Blogs_BlogId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Users_UserId]
GO
ALTER TABLE [dbo].[CourseOwners]  WITH CHECK ADD  CONSTRAINT [FK_CourseOwners_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[CourseOwners] CHECK CONSTRAINT [FK_CourseOwners_Courses_CourseId]
GO
ALTER TABLE [dbo].[CourseOwners]  WITH CHECK ADD  CONSTRAINT [FK_CourseOwners_Users_CourseOwnerId] FOREIGN KEY([CourseOwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[CourseOwners] CHECK CONSTRAINT [FK_CourseOwners_Users_CourseOwnerId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Slides_SlideId] FOREIGN KEY([SlideId])
REFERENCES [dbo].[Slides] ([SlideId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Slides_SlideId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Status_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Status_StatusId]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Users_UserId]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [FK_Lessons_Topics_TopicId] FOREIGN KEY([TopicId])
REFERENCES [dbo].[Topics] ([TopicId])
GO
ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [FK_Lessons_Topics_TopicId]
GO
ALTER TABLE [dbo].[PricePackages]  WITH CHECK ADD  CONSTRAINT [FK_PricePackages_Status_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[PricePackages] CHECK CONSTRAINT [FK_PricePackages_Status_StatusId]
GO
ALTER TABLE [dbo].[QuestionBanks]  WITH CHECK ADD  CONSTRAINT [FK_QuestionBanks_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[QuestionBanks] CHECK CONSTRAINT [FK_QuestionBanks_Courses_CourseId]
GO
ALTER TABLE [dbo].[QuestionBanks]  WITH CHECK ADD  CONSTRAINT [FK_QuestionBanks_QuizLevels_QuizLevelId] FOREIGN KEY([QuizLevelId])
REFERENCES [dbo].[QuizLevels] ([QuizLevelId])
GO
ALTER TABLE [dbo].[QuestionBanks] CHECK CONSTRAINT [FK_QuestionBanks_QuizLevels_QuizLevelId]
GO
ALTER TABLE [dbo].[QuestionBanks]  WITH CHECK ADD  CONSTRAINT [FK_QuestionBanks_Status_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[QuestionBanks] CHECK CONSTRAINT [FK_QuestionBanks_Status_StatusId]
GO
ALTER TABLE [dbo].[QuizQuestions]  WITH CHECK ADD  CONSTRAINT [FK_QuizQuestions_QuestionBanks_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[QuestionBanks] ([QuestionId])
GO
ALTER TABLE [dbo].[QuizQuestions] CHECK CONSTRAINT [FK_QuizQuestions_QuestionBanks_QuestionId]
GO
ALTER TABLE [dbo].[QuizQuestions]  WITH CHECK ADD  CONSTRAINT [FK_QuizQuestions_Quizzes_QuizId] FOREIGN KEY([QuizId])
REFERENCES [dbo].[Quizzes] ([QuizId])
GO
ALTER TABLE [dbo].[QuizQuestions] CHECK CONSTRAINT [FK_QuizQuestions_Quizzes_QuizId]
GO
ALTER TABLE [dbo].[Quizzes]  WITH CHECK ADD  CONSTRAINT [FK_Quizzes_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[Quizzes] CHECK CONSTRAINT [FK_Quizzes_Courses_CourseId]
GO
ALTER TABLE [dbo].[Quizzes]  WITH CHECK ADD  CONSTRAINT [FK_Quizzes_QuizLevels_QuizLevelId] FOREIGN KEY([QuizLevelId])
REFERENCES [dbo].[QuizLevels] ([QuizLevelId])
GO
ALTER TABLE [dbo].[Quizzes] CHECK CONSTRAINT [FK_Quizzes_QuizLevels_QuizLevelId]
GO
ALTER TABLE [dbo].[Quizzes]  WITH CHECK ADD  CONSTRAINT [FK_Quizzes_QuizTypes_QuizTypeId] FOREIGN KEY([QuizTypeId])
REFERENCES [dbo].[QuizTypes] ([QuizTypeId])
GO
ALTER TABLE [dbo].[Quizzes] CHECK CONSTRAINT [FK_Quizzes_QuizTypes_QuizTypeId]
GO
ALTER TABLE [dbo].[Quizzes]  WITH CHECK ADD  CONSTRAINT [FK_Quizzes_Topics_TopicId] FOREIGN KEY([TopicId])
REFERENCES [dbo].[Topics] ([TopicId])
GO
ALTER TABLE [dbo].[Quizzes] CHECK CONSTRAINT [FK_Quizzes_Topics_TopicId]
GO
ALTER TABLE [dbo].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Courses_CourseId] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([CourseId])
GO
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Courses_CourseId]
GO
ALTER TABLE [dbo].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [dbo].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [dbo].[UserPricePackages]  WITH CHECK ADD  CONSTRAINT [FK_UserPricePackages_PricePackages_PricePackageId] FOREIGN KEY([PricePackageId])
REFERENCES [dbo].[PricePackages] ([PricePackageId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPricePackages] CHECK CONSTRAINT [FK_UserPricePackages_PricePackages_PricePackageId]
GO
ALTER TABLE [dbo].[UserPricePackages]  WITH CHECK ADD  CONSTRAINT [FK_UserPricePackages_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserPricePackages] CHECK CONSTRAINT [FK_UserPricePackages_Users_UserId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [dbo].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
USE [master]
GO
ALTER DATABASE [SWP391] SET  READ_WRITE 
GO
