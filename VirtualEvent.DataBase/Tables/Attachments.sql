CREATE TABLE [dbo].[Attachments] (
    [AttachmentId] INT          IDENTITY (1, 1) NOT NULL,
    [EventId]      INT          NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Attachments] PRIMARY KEY CLUSTERED ([AttachmentId] ASC),
    CONSTRAINT [FK_Attachments_Events] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([EventId])
);

