IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Categories] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [StartRange] int NOT NULL,
    [EndRange] int NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Products] (
    [Sku] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Category] nvarchar(max) NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Sku])
);

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'EndRange', N'Name', N'StartRange') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] ON;
INSERT INTO [Categories] ([Id], [EndRange], [Name], [StartRange])
VALUES (1, 19999, N'Home', 10000),
(2, 29999, N'Garden', 20000),
(3, 39999, N'Electronics', 30000),
(4, 49999, N'Fitness', 40000),
(5, 59999, N'Toys', 50000);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'EndRange', N'Name', N'StartRange') AND [object_id] = OBJECT_ID(N'[Categories]'))
    SET IDENTITY_INSERT [Categories] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Sku', N'Category', N'Description', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Products]'))
    SET IDENTITY_INSERT [Products] ON;
INSERT INTO [Products] ([Sku], [Category], [Description], [Name], [Price])
VALUES (12000, N'Home', N'TestA', N'A', 100),
(13000, N'Home', N'TestB', N'B', 100),
(22000, N'Garden', N'TestC', N'C', 100),
(23000, N'Garden', N'TestD', N'D', 100),
(32000, N'Electronics', N'TestE', N'E', 100),
(33000, N'Electronics', N'TestF', N'F', 100),
(42000, N'Fitness', N'TestG', N'G', 100),
(43000, N'Fitness', N'TestH', N'H', 100),
(52000, N'Toys', N'TestI', N'I', 100),
(53000, N'Toys', N'TestJ', N'J', 100);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Sku', N'Category', N'Description', N'Name', N'Price') AND [object_id] = OBJECT_ID(N'[Products]'))
    SET IDENTITY_INSERT [Products] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210627221821_MMTShop', N'2.1.11-servicing-32099');

GO

CREATE PROCEDURE [dbo].[GetProductsByCategory]
                    @Category varchar(20)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from [dbo].[Products] where Category = @Category
                END

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210627230012_sp-GetProductsByCategory', N'2.1.11-servicing-32099');

GO

