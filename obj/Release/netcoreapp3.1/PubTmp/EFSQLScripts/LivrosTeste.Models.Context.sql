IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006025518_InicializacaoBD')
BEGIN
    CREATE TABLE [Favoritos] (
        [Id] int NOT NULL IDENTITY,
        [Genero] nvarchar(max) NULL,
        [Titulo] nvarchar(max) NULL,
        [Autor] nvarchar(max) NULL,
        [Paginas] int NOT NULL,
        [Ilustracao] bit NOT NULL,
        [SerieDescricao] nvarchar(max) NULL,
        CONSTRAINT [PK_Favoritos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006025518_InicializacaoBD')
BEGIN
    CREATE TABLE [Series] (
        [Id] int NOT NULL IDENTITY,
        [Descricao] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Series] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006025518_InicializacaoBD')
BEGIN
    CREATE TABLE [Livros] (
        [Id] int NOT NULL IDENTITY,
        [Genero] nvarchar(max) NOT NULL,
        [Titulo] nvarchar(max) NOT NULL,
        [Autor] nvarchar(max) NOT NULL,
        [Paginas] int NOT NULL,
        [Ilustracao] bit NOT NULL,
        [SerieId] int NOT NULL,
        CONSTRAINT [PK_Livros] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Livros_Series_SerieId] FOREIGN KEY ([SerieId]) REFERENCES [Series] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006025518_InicializacaoBD')
BEGIN
    CREATE INDEX [IX_Livros_SerieId] ON [Livros] ([SerieId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006025518_InicializacaoBD')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201006025518_InicializacaoBD', N'3.1.8');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006030614_InclucaoTabelaImagem')
BEGIN
    ALTER TABLE [Livros] ADD [ImagemId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006030614_InclucaoTabelaImagem')
BEGIN
    CREATE TABLE [Imagem] (
        [Id] int NOT NULL IDENTITY,
        [NomeImagem] nvarchar(max) NULL,
        [ImagemCapa] nvarchar(max) NULL,
        CONSTRAINT [PK_Imagem] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006030614_InclucaoTabelaImagem')
BEGIN
    CREATE INDEX [IX_Livros_ImagemId] ON [Livros] ([ImagemId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006030614_InclucaoTabelaImagem')
BEGIN
    ALTER TABLE [Livros] ADD CONSTRAINT [FK_Livros_Imagem_ImagemId] FOREIGN KEY ([ImagemId]) REFERENCES [Imagem] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201006030614_InclucaoTabelaImagem')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201006030614_InclucaoTabelaImagem', N'3.1.8');
END;

GO

