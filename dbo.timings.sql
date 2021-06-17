CREATE TABLE [dbo].[timings] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (MAX)   NOT NULL,
    [Degree]          VARCHAR (50)    NOT NULL,
    [Office_Time]     VARCHAR (50)    NOT NULL,
    [PhoneNo]         VARBINARY (MAX) NOT NULL,
    [Clinic_Location] VARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

