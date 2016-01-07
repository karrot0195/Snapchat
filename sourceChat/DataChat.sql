USE [DataChat]
GO
/****** Object:  Table [dbo].[FriendList]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FriendList](
	[IDFriendList] [int] NOT NULL,
	[IDUser] [int] NOT NULL,
 CONSTRAINT [PK_FriendList] PRIMARY KEY CLUSTERED 
(
	[IDFriendList] ASC,
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupChat]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupChat](
	[IDGroup] [int] NOT NULL,
	[NameGroup] [nvarchar](20) NULL,
	[createTime] [datetime] NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_GroupChat_1] PRIMARY KEY CLUSTERED 
(
	[IDGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupDetail]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupDetail](
	[IDFriend] [int] NOT NULL,
	[IDGroup] [int] NOT NULL,
 CONSTRAINT [PK_GroupDetail] PRIMARY KEY CLUSTERED 
(
	[IDFriend] ASC,
	[IDGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Message]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[IDUser] [int] NOT NULL,
	[IDSender] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[Message] [nvarchar](50) NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC,
	[IDSender] ASC,
	[DateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MessageOffline]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageOffline](
	[IDUser] [int] NOT NULL,
	[IDSender] [int] NOT NULL,
	[Time] [datetime] NULL,
	[Message] [nvarchar](500) NULL,
 CONSTRAINT [PK_MessageOffline] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC,
	[IDSender] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/13/2015 7:20:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IDUser] [int] NOT NULL,
	[Username] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](15) NOT NULL,
	[State] [bit] NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IDUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[FriendList]  WITH CHECK ADD  CONSTRAINT [FK_FriendList_Users] FOREIGN KEY([IDFriendList])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[FriendList] CHECK CONSTRAINT [FK_FriendList_Users]
GO
ALTER TABLE [dbo].[FriendList]  WITH CHECK ADD  CONSTRAINT [FK_FriendList_Users1] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[FriendList] CHECK CONSTRAINT [FK_FriendList_Users1]
GO
ALTER TABLE [dbo].[GroupChat]  WITH CHECK ADD  CONSTRAINT [FK_GroupChat_Users] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[GroupChat] CHECK CONSTRAINT [FK_GroupChat_Users]
GO
ALTER TABLE [dbo].[GroupDetail]  WITH CHECK ADD  CONSTRAINT [FK_GroupDetail_GroupChat] FOREIGN KEY([IDGroup])
REFERENCES [dbo].[GroupChat] ([IDGroup])
GO
ALTER TABLE [dbo].[GroupDetail] CHECK CONSTRAINT [FK_GroupDetail_GroupChat]
GO
ALTER TABLE [dbo].[GroupDetail]  WITH CHECK ADD  CONSTRAINT [FK_GroupDetail_Users] FOREIGN KEY([IDFriend])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[GroupDetail] CHECK CONSTRAINT [FK_GroupDetail_Users]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Users]
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Users1] FOREIGN KEY([IDSender])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Users1]
GO
ALTER TABLE [dbo].[MessageOffline]  WITH CHECK ADD  CONSTRAINT [FK_MessageOffline_Users] FOREIGN KEY([IDUser])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[MessageOffline] CHECK CONSTRAINT [FK_MessageOffline_Users]
GO
ALTER TABLE [dbo].[MessageOffline]  WITH CHECK ADD  CONSTRAINT [FK_MessageOffline_Users1] FOREIGN KEY([IDSender])
REFERENCES [dbo].[Users] ([IDUser])
GO
ALTER TABLE [dbo].[MessageOffline] CHECK CONSTRAINT [FK_MessageOffline_Users1]
GO
