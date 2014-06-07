USE [POSTBACK]
GO

INSERT INTO Categoria(descricao) VALUES('BOM', '#53da3f')
INSERT INTO Categoria(descricao) VALUES('MELHORAR', '#5bb4e5')
INSERT INTO Categoria(descricao) VALUES('APRENDI', '#fee000')

INSERT INTO Quadro(descricao, ativo) VALUES('HACKATON 2.0', 1)

DECLARE @idQuadro INT
SET @idQuadro = SCOPE_IDENTITY()

INSERT INTO CategoriaToQuadro(IdCategoria, IdQuadro) 
	SELECT id, @idQuadro FROM Categoria


INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('alimentação')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('aprendizado')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('interação')