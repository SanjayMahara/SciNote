CREATE TABLE [dbo].[Person]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (150) COLLATE Latin1_General_CI_AI NOT NULL,
[MailId] [varchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
