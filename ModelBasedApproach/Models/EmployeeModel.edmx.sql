
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/14/2019 23:56:03
-- Generated from EDMX file: C:\Users\Azam\documents\visual studio 2015\Projects\BlueSharkBatch_24sep2019\ModelBasedApproach\Models\EmployeeModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ganesh];
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

-- Creating table 'EmployeeDetails'
CREATE TABLE [dbo].[EmployeeDetails] (
    [EmpId] int IDENTITY(1,1) NOT NULL,
    [Ename] nvarchar(max)  NOT NULL,
    [EmpSalary] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [EmpId] in table 'EmployeeDetails'
ALTER TABLE [dbo].[EmployeeDetails]
ADD CONSTRAINT [PK_EmployeeDetails]
    PRIMARY KEY CLUSTERED ([EmpId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------