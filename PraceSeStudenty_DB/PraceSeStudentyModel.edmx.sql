
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/02/2023 21:05:30
-- Generated from EDMX file: C:\Users\janso\source\repos\PraceSeStudenty\PraceSeStudenty_DB\PraceSeStudentyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Studenti];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Studenti'
CREATE TABLE [dbo].[Studenti] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Jmeno] nvarchar(max)  NOT NULL,
    [Prijmeni] nvarchar(max)  NOT NULL,
    [RodneCislo] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Studenti'
ALTER TABLE [dbo].[Studenti]
ADD CONSTRAINT [PK_Studenti]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------