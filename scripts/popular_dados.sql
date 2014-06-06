USE [POSTBACK]
GO

INSERT INTO Categoria(descricao) VALUES('BOM')
INSERT INTO Categoria(descricao) VALUES('MELHORAR')
INSERT INTO Categoria(descricao) VALUES('APRENDI')

INSERT INTO Quadro(descricao) VALUES('HACKATON 2.0')

DECLARE @idQuadro INT
SET @idQuadro = SCOPE_IDENTITY()

INSERT INTO CategoriaToQuadro(IdCategoria, IdQuadro) 
	SELECT id, @idQuadro FROM Categoria


INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('alimentação')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('aprendizado')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('interação')