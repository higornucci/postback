﻿USE [POSTBACK]
GO

INSERT INTO Categoria(descricao, CorHexadecimal) VALUES('BOM', '#53da3f')
INSERT INTO Categoria(descricao, CorHexadecimal) VALUES('MELHORAR', '#5bb4e5')
INSERT INTO Categoria(descricao, CorHexadecimal) VALUES('APRENDI', '#fee000')

INSERT INTO Quadro(descricao, ativo) VALUES('HACKATON 2.0', 1)

DECLARE @idQuadro INT
SET @idQuadro = SCOPE_IDENTITY()

INSERT INTO CategoriaToQuadro(IdCategoria, IdQuadro) 
	SELECT id, @idQuadro FROM Categoria


INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('alimentação')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('aprendizado')
INSERT INTO SugestaoDeTag(Tag_Nome) VALUES('interação')

INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	1,	1,	'ALIMENTACAO')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	1,	1,	'ALIMENTACAO')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'EVENTO')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'DIA')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'DIA')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'DIA')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'DIA')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	2,	1,	'DIA')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	1,	1,	'ALIMENTACAO')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	3,	1,	'EVENTO')
INSERT INTO POSTIT (CONTEUDO, IDCATEGORIA, IDQUADRO, TAG_NOME) VALUES ('LOREM IPSUM DOLOR SIT AMET, CONSECTETUR ADIPISCING ELIT.', 	3,	1,	'EVENTO')