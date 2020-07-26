CREATE TABLE [dbo].[Dispositivos] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]        VARCHAR (200) NULL,
    [Hostname]      VARCHAR (300) NULL,
    [MACAddress]    VARCHAR (17)  NOT NULL,
    [fechaCreacion] DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

