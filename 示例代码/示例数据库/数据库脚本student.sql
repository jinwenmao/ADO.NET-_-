create database student
GO

use student

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_score_course]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[score] DROP CONSTRAINT FK_score_course
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_score_student]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[score] DROP CONSTRAINT FK_score_student
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[course]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[course]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[score]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[score]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[student]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[student]
GO

CREATE TABLE [dbo].[course] (
	[cou_id] [char] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[cou_name] [varchar] (40) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[teacher_id] [char] (10) COLLATE Chinese_PRC_CI_AS NULL ,
	[cou_hour] [int] NULL ,
	[describe] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[score] (
	[stu_id] [char] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[cou_id] [char] (20) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[score] [int] NULL ,
	[term] [char] (10) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[student] (
	[stu_id] [char] (10) COLLATE Chinese_PRC_CI_AS NOT NULL ,
	[name] [varchar] (20) COLLATE Chinese_PRC_CI_AS NULL ,
	[sex] [char] (4) COLLATE Chinese_PRC_CI_AS NULL ,
	[addr] [varchar] (50) COLLATE Chinese_PRC_CI_AS NULL ,
	[birthday] [datetime] NULL ,
	[enexam] [int] NULL ,
	[photo] [image] NULL ,
	[photopath] [nvarchar] (255) COLLATE Chinese_PRC_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[course] ADD
CONSTRAINT [PK_course] PRIMARY KEY CLUSTERED
(
[cou_id]
)ON [PRIMARY]
GO

ALTER TABLE [dbo].[score] ADD
CONSTRAINT [PK_score] PRIMARY KEY CLUSTERED
(
[stu_id],
[cou_id]
)ON [PRIMARY]
GO

ALTER TABLE [dbo].[student] ADD
CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED
(
[stu_id]
)ON [PRIMARY]
GO

ALTER TABLE [dbo].[score] ADD
CONSTRAINT [FK_score_course] FOREIGN KEY
(
[cou_id]

)REFERENCES [dbo].[course]([cou_id]),

CONSTRAINT [FK_score_student] FOREIGN KEY
(
[stu_id]
)REFERENCES [dbo].[student]([stu_id])
GO