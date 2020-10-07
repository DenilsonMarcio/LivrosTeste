--SELECTS DAS TABELAS PARA CONSULTAS
select * from dbo.Livros;
select * from dbo.Series;
select * from dbo.Favoritos;
select * from dbo.Imagem;

-----------------------PROCEDURES LIVROS---------------------------
--INSERT
CREATE PROCEDURE AdicionarLivro(
	@Genero nvarchar(max),
	@Titulo nvarchar(max),
	@Autor nvarchar(max),
	@Paginas int,
	@Ilustracao bit,
	@SerieId int,
	@ImagemId int
	)
	as
	BEGIN
		INSERT INTO Livros VALUES (@Genero, @Titulo, @Autor, @Paginas, @Ilustracao, @SerieId, @ImagemId)
	END
	exec AdicionarLivro @Genero = 'a', @Titulo = 'b', @Autor = 'c', @Paginas = 150, @Ilustracao = 0, @SerieId = 9
--UPDATE
CREATE PROCEDURE AlterarLivro(
	@Id int,
	@Genero nvarchar(max),
	@Titulo nvarchar(max),
	@Autor nvarchar(max),
	@Paginas int,
	@Ilustracao bit,
	@SerieId int
	)
	as
	BEGIN
		UPDATE Livros SET 
		@Genero = Genero,
		@Titulo = Titulo,
		@Autor = Autor,
		@Paginas = Paginas,
		@Ilustracao = Ilustracao,
		@SerieId = SerieId
		WHERE @Id = Id
	END

--DELETE
CREATE PROCEDURE ExcluirLivro(
	@Id int
	)
	as
	BEGIN
		DELETE FROM Livros WHERE Id = @Id
	END

--SELECT
CREATE PROCEDURE ListaLivros
	as
	BEGIN
		SELECT Id, Genero, Titulo, Autor, Paginas, Ilustracao, SerieId FROM Livros
	END
	
--SELECT COM FILTROS
CREATE PROCEDURE ListaLivrosPorTitulo(
	@Titulo nvarchar(max)
	)
	as
	BEGIN
		SELECT * FROM Livros WHERE Titulo = @Titulo
	END

CREATE PROCEDURE ListaLivrosPorGenero(
	@Genero nvarchar(max)
	)
	as
	BEGIN
		SELECT * FROM Livros WHERE Genero = @Genero
	END

	
CREATE PROCEDURE ListaLivrosPorAutor(
	@Autor nvarchar(max)
	)
	as
	BEGIN
		SELECT * FROM Livros WHERE Autor = @Autor
	END

CREATE PROCEDURE ListaLivrosPorPaginas(
	@Paginas int
	)
	as
	BEGIN
		SELECT * FROM Livros WHERE Paginas = @Paginas or paginas > @Paginas or paginas < @Paginas
	END

	
-----------------------PROCEDURES LIVROS---------------------------

-----------------------PROCEDURES SERIES---------------------------
--INSERT
CREATE PROCEDURE AdicionarSerie(
	@Descricao nvarchar(MAX)
	)
	as
	BEGIN
		INSERT INTO Series VALUES (@Descricao)
	END
	exec AdicionarSerie @Descricao = 'TESTE'
--UPDATE
CREATE PROCEDURE AlterarSerie(
	@Id int,
	@Descricao nvarchar(MAX)
	)
	as
	BEGIN
		UPDATE Series SET 
		@Descricao = Descricao
		WHERE @Id = Id
	END

--DELETE
CREATE PROCEDURE ExcluirSerie(
	@Id int
	)
	as
	BEGIN
		DELETE FROM Series WHERE Id = @Id
	END

--SELECT
CREATE PROCEDURE ListaSerie
	as
	BEGIN
		SELECT * FROM Series;
	END
-----------------------PROCEDURES SERIES---------------------------

-----------------------PROCEDURES IMAGEM---------------------------
--INSERT
CREATE PROCEDURE AdicionarImagem(
	@NomeImagem varchar(MAX),
	@Imagem varbinary(MAX)
	)
	as
	BEGIN
		INSERT INTO Imagem VALUES (@NomeImagem, @Imagem)
	END

--UPDATE
CREATE PROCEDURE AlterarImagem(
	@Id int,
	@NomeImagem varchar(MAX),
	@Imagem varbinary(MAX)
	)
	as
	BEGIN
		UPDATE Imagem SET 
		@NomeImagem = NomeImagem,
		@Imagem = Imagem
		WHERE @Id = Id
	END

--DELETE
CREATE PROCEDURE ExcluirImagem(
	@Id int
	)
	as
	BEGIN
		DELETE FROM Imagem WHERE Id = @Id
	END

--SELECT
CREATE PROCEDURE BuscaPorImagem(
	@NomeImagem varchar(MAX)
	)
	as
	BEGIN
		SELECT * FROM Imagem WHERE NomeImagem = @NomeImagem;
	END
-----------------------PROCEDURES IMAGEM---------------------------

-----------------------PROCEDURES FAVORITOS---------------------------
--INSERT
CREATE PROCEDURE AdicionarFavoritos(
	@Genero nvarchar(max),
	@Titulo nvarchar(max),
	@Autor nvarchar(max),
	@Paginas int,
	@Ilustracao bit,
	@SerieDescricao nvarchar(max)
	)
	as
	BEGIN
		INSERT INTO Favoritos VALUES (@Genero, @Titulo, @Autor, @Paginas, @Ilustracao, @SerieDescricao)
	END

--DELETE
CREATE PROCEDURE ExcluirFavoritos(
	@Id int
	)
	as
	BEGIN
		DELETE FROM Favoritos WHERE Id = @Id
	END

--SELECT
CREATE PROCEDURE ListaFavoritos
	as
	BEGIN
		SELECT * FROM Favoritos
	END

-----------------------PROCEDURES FAVORITOS---------------------------

