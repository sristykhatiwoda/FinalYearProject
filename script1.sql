USE [OnlineCourseDatabase]
GO
/****** Object:  Table [dbo].[ASS_AssignmentSubmit]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[ASS_AssignmentSubmit](
	[SubmitAssignmentID] [int] IDENTITY(1,1) NOT NULL,
	[SubmissionDate] [date] NOT NULL,
	[Answer] [nvarchar](max) NOT NULL,
	[Point] [float] NOT NULL,
	[Remarks] [nvarchar](max) NOT NULL,
	[AssignmentID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
 CONSTRAINT [PK_ASS_AssignmentSubmit] PRIMARY KEY CLUSTERED 
(
	[SubmitAssignmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MS_Semester]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MS_Semester](
	[SemesterID] [int] IDENTITY(1,1) NOT NULL,
	[SemesterTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MS_Semester] PRIMARY KEY CLUSTERED 
(
	[SemesterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MS_Faculty]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MS_Faculty](
	[FacultyID] [int] IDENTITY(1,1) NOT NULL,
	[FacultyTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MS_Faculty] PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MS_Course]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MS_Course](
	[CourseID] [int] IDENTITY(1,1) NOT NULL,
	[CourseTitle] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MS_Course] PRIMARY KEY CLUSTERED 
(
	[CourseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MS_Batch]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MS_Batch](
	[BatchID] [int] IDENTITY(1,1) NOT NULL,
	[Batch] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MS_Batch] PRIMARY KEY CLUSTERED 
(
	[BatchID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SC_UserType]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SC_UserType](
	[UserTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SC_UserType] PRIMARY KEY CLUSTERED 
(
	[UserTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SC_User]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SC_User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[UserTypeID] [int] NOT NULL,
 CONSTRAINT [PK_SC_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STU_Student]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STU_Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FacultyID] [int] NOT NULL,
	[BatchID] [int] NOT NULL,
	[SemesterID] [int] NOT NULL,
 CONSTRAINT [PK_STU_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUIZ_Quiz]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUIZ_Quiz](
	[QuizID] [int] IDENTITY(1,1) NOT NULL,
	[QuizQuestiion] [nvarchar](100) NOT NULL,
	[Answer] [nvarchar](50) NOT NULL,
	[Option1] [nvarchar](50) NOT NULL,
	[Option2] [nvarchar](50) NOT NULL,
	[Option3] [nvarchar](50) NOT NULL,
	[Option4] [nvarchar](50) NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_QUIZ_Quiz] PRIMARY KEY CLUSTERED 
(
	[QuizID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NEW_News]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NEW_News](
	[NewsID] [int] IDENTITY(1,1) NOT NULL,
	[NewsTitle] [nvarchar](100) NOT NULL,
	[NewsDescription] [ntext] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_New_News] PRIMARY KEY CLUSTERED 
(
	[NewsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIS_DiscussionForum]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIS_DiscussionForum](
	[DiscussionForumID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [ntext] NOT NULL,
	[Date] [date] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_DIS_DiscussionForum] PRIMARY KEY CLUSTERED 
(
	[DiscussionForumID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COU_CourseContent]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COU_CourseContent](
	[CourseContentID] [int] IDENTITY(1,1) NOT NULL,
	[Video] [nvarchar](50) NULL,
	[File] [nvarchar](50) NULL,
	[CourseID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_COU_CourseContent] PRIMARY KEY CLUSTERED 
(
	[CourseContentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ASS_AssignmentPost]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ASS_AssignmentPost](
	[AssignmentID] [int] IDENTITY(1,1) NOT NULL,
	[Questions] [nvarchar](100) NOT NULL,
	[Deadline] [date] NOT NULL,
	[CourseID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_ASS_AssignmentPost] PRIMARY KEY CLUSTERED 
(
	[AssignmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUIZ_QuizSubmit]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUIZ_QuizSubmit](
	[QuizSubmitID] [int] IDENTITY(1,1) NOT NULL,
	[Answer] [nvarchar](50) NULL,
	[QuizPoint] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[QuizID] [int] NOT NULL,
 CONSTRAINT [PK_QUIZ_QuizPost] PRIMARY KEY CLUSTERED 
(
	[QuizSubmitID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIS_DiscussionForumComment]    Script Date: 06/28/2016 10:03:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIS_DiscussionForumComment](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[DiscussionForumID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_DIS_DiscussionForumComment] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_SC_User_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[SC_User]  WITH CHECK ADD  CONSTRAINT [FK_SC_User_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[SC_User] CHECK CONSTRAINT [FK_SC_User_SC_User]
GO
/****** Object:  ForeignKey [FK_SC_User_SC_UserType]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[SC_User]  WITH CHECK ADD  CONSTRAINT [FK_SC_User_SC_UserType] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[SC_UserType] ([UserTypeID])
GO
ALTER TABLE [dbo].[SC_User] CHECK CONSTRAINT [FK_SC_User_SC_UserType]
GO
/****** Object:  ForeignKey [FK_STU_Student_MS_Batch]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[STU_Student]  WITH CHECK ADD  CONSTRAINT [FK_STU_Student_MS_Batch] FOREIGN KEY([BatchID])
REFERENCES [dbo].[MS_Batch] ([BatchID])
GO
ALTER TABLE [dbo].[STU_Student] CHECK CONSTRAINT [FK_STU_Student_MS_Batch]
GO
/****** Object:  ForeignKey [FK_STU_Student_MS_Faculty]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[STU_Student]  WITH CHECK ADD  CONSTRAINT [FK_STU_Student_MS_Faculty] FOREIGN KEY([FacultyID])
REFERENCES [dbo].[MS_Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[STU_Student] CHECK CONSTRAINT [FK_STU_Student_MS_Faculty]
GO
/****** Object:  ForeignKey [FK_STU_Student_MS_Semester]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[STU_Student]  WITH CHECK ADD  CONSTRAINT [FK_STU_Student_MS_Semester] FOREIGN KEY([SemesterID])
REFERENCES [dbo].[MS_Semester] ([SemesterID])
GO
ALTER TABLE [dbo].[STU_Student] CHECK CONSTRAINT [FK_STU_Student_MS_Semester]
GO
/****** Object:  ForeignKey [FK_QUIZ_Quiz_MS_Course]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[QUIZ_Quiz]  WITH CHECK ADD  CONSTRAINT [FK_QUIZ_Quiz_MS_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MS_Course] ([CourseID])
GO
ALTER TABLE [dbo].[QUIZ_Quiz] CHECK CONSTRAINT [FK_QUIZ_Quiz_MS_Course]
GO
/****** Object:  ForeignKey [FK_New_News_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[NEW_News]  WITH CHECK ADD  CONSTRAINT [FK_New_News_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[NEW_News] CHECK CONSTRAINT [FK_New_News_SC_User]
GO
/****** Object:  ForeignKey [FK_DIS_DiscussionForum_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[DIS_DiscussionForum]  WITH CHECK ADD  CONSTRAINT [FK_DIS_DiscussionForum_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[DIS_DiscussionForum] CHECK CONSTRAINT [FK_DIS_DiscussionForum_SC_User]
GO
/****** Object:  ForeignKey [FK_COU_CourseContent_MS_Course]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[COU_CourseContent]  WITH CHECK ADD  CONSTRAINT [FK_COU_CourseContent_MS_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MS_Course] ([CourseID])
GO
ALTER TABLE [dbo].[COU_CourseContent] CHECK CONSTRAINT [FK_COU_CourseContent_MS_Course]
GO
/****** Object:  ForeignKey [FK_COU_CourseContent_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[COU_CourseContent]  WITH CHECK ADD  CONSTRAINT [FK_COU_CourseContent_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[COU_CourseContent] CHECK CONSTRAINT [FK_COU_CourseContent_SC_User]
GO
/****** Object:  ForeignKey [FK_ASS_AssignmentPost_MS_Course]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[ASS_AssignmentPost]  WITH CHECK ADD  CONSTRAINT [FK_ASS_AssignmentPost_MS_Course] FOREIGN KEY([CourseID])
REFERENCES [dbo].[MS_Course] ([CourseID])
GO
ALTER TABLE [dbo].[ASS_AssignmentPost] CHECK CONSTRAINT [FK_ASS_AssignmentPost_MS_Course]
GO
/****** Object:  ForeignKey [FK_ASS_AssignmentPost_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[ASS_AssignmentPost]  WITH CHECK ADD  CONSTRAINT [FK_ASS_AssignmentPost_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[ASS_AssignmentPost] CHECK CONSTRAINT [FK_ASS_AssignmentPost_SC_User]
GO
/****** Object:  ForeignKey [FK_QUIZ_QuizSubmit_QUIZ_Quiz]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[QUIZ_QuizSubmit]  WITH CHECK ADD  CONSTRAINT [FK_QUIZ_QuizSubmit_QUIZ_Quiz] FOREIGN KEY([QuizID])
REFERENCES [dbo].[QUIZ_Quiz] ([QuizID])
GO
ALTER TABLE [dbo].[QUIZ_QuizSubmit] CHECK CONSTRAINT [FK_QUIZ_QuizSubmit_QUIZ_Quiz]
GO
/****** Object:  ForeignKey [FK_QUIZ_QuizSubmit_STU_Student]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[QUIZ_QuizSubmit]  WITH CHECK ADD  CONSTRAINT [FK_QUIZ_QuizSubmit_STU_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[STU_Student] ([StudentID])
GO
ALTER TABLE [dbo].[QUIZ_QuizSubmit] CHECK CONSTRAINT [FK_QUIZ_QuizSubmit_STU_Student]
GO
/****** Object:  ForeignKey [FK_DIS_DiscussionForumComment_DIS_DiscussionForum]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[DIS_DiscussionForumComment]  WITH CHECK ADD  CONSTRAINT [FK_DIS_DiscussionForumComment_DIS_DiscussionForum] FOREIGN KEY([DiscussionForumID])
REFERENCES [dbo].[DIS_DiscussionForum] ([DiscussionForumID])
GO
ALTER TABLE [dbo].[DIS_DiscussionForumComment] CHECK CONSTRAINT [FK_DIS_DiscussionForumComment_DIS_DiscussionForum]
GO
/****** Object:  ForeignKey [FK_DIS_DiscussionForumComment_SC_User]    Script Date: 06/28/2016 10:03:39 ******/
ALTER TABLE [dbo].[DIS_DiscussionForumComment]  WITH CHECK ADD  CONSTRAINT [FK_DIS_DiscussionForumComment_SC_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[SC_User] ([UserID])
GO
ALTER TABLE [dbo].[DIS_DiscussionForumComment] CHECK CONSTRAINT [FK_DIS_DiscussionForumComment_SC_User]
GO
