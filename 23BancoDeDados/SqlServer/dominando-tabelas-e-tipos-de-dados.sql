
-- A LINGUAGEM SQL

-- O que são comandos SQL?
-- Comandos SQL são instruções utilizadas para gerenciar e manipular dados em bancos de dados relacionais. 
-- A sigla SQL significa “Structured Query Language”, ou “Linguagem de Consulta Estruturada” em português. 
-- Esses comandos permitem executar operações como consultar, inserir, atualizar e excluir informações em sistemas como MySQL, PostgreSQL, Oracle e SQL Server. 
-- Embora seja uma linguagem padrão, cada Sistema Gerenciador de Banco de Dados (SGBD) possui particularidades. 
-- Podemos dividir os comandos SQL em grupos: DDL, DQL, DML, DCL e TCL. 

-- DDL (Data Definition Language): CREATE, DROP, ALTER, TRUNCATE
-- DCL (Data Control Language): GRANT, REVOKE
-- DML (Data Manipulation Language): INSERT, UPDATE, DELETE
-- TCL (Data Transaction Language: COMMIT, ROLLBACK, SAVE POINT 
-- DQL  (Data Query Language): SELECT 


-- Se j� existir uma Tabela chamada Produtos, exclua ela.
DROP TABLE IF EXISTS dbo.Clientes
-- Criar Tabela Produtos com as seguintes colunas e tipos de dados
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Sobrenome] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AceitaComunicados] [bit] NULL,
	[DataCadastro] [datetime2](7) NULL
)

-- Selecionar todas as colunas da tabela dbo.Clientes
SELECT * FROM dbo.Clientes;

-- Selecione a coluna Nome da Tabela Clientes
SELECT Nome FROM Clientes;

-- Ordenando todas as colunas da tabela dbo.Clientes ordenadas (ASC) pelo Nome
SELECT * FROM dbo.Clientes ORDER BY Nome;

-- Ordenando todas as colunas da tabela dbo.Clientes ordenadas descendente (DESC) pelo Nome
SELECT * FROM dbo.Clientes ORDER BY Nome DESC;

-- Ordenando todas as colunas da tabela dbo.Clientes de forma ordenada (ASC) 1� pelo Nome e 2� pelo Sobrenome
SELECT * FROM dbo.Clientes ORDER BY Nome, Sobrenome;

-- Selecionar todas as colunas da tabela dbo.Clientes onde Nome = 'Adam' e ordene pelo Nome
SELECT * FROM dbo.Clientes WHERE Nome = 'Adam' ORDER BY Nome

-- Selecionar todas as colunas da tabela dbo.Clientes onde Nome = 'Adam' e Sobrenome = 'Reynolds'
SELECT * FROM dbo.Clientes WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds' 


-- Selecionar todas as colunas da tabela dbo.Clientes onde Nome = 'Adam' ou Sobrenome = 'Reynolds'
SELECT * FROM dbo.Clientes WHERE Nome = 'Adam' OR Sobrenome = 'Reynolds' 

-- Selecionar todas as colunas da tabela dbo.Clientes onde Nome iniciar com a letra 'G'
SELECT * FROM dbo.Clientes WHERE Nome LIKE 'G%' 

-- Selecionar todas as colunas da tabela dbo.Clientes onde Nome contem a letra 'G'
SELECT * FROM dbo.Clientes WHERE Nome LIKE '%G%' 

-- Insira na tabela Cliente os valores informados na ordem de colunas informadas. (caso a ordem seja a mesma da tabela, n�o � preciso informar os nomes das colunas)  
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Erasmo', 'Buta', 'erasmo@gmail.com', 1, GETDATE())

-- Verificar se o registro foi inserido 
SELECT * FROM dbo.Clientes WHERE Nome = 'Erasmo'

-- Caso a ordem de inser��o seja a mesma da tabela, n�o � preciso informar os nomes das colunas
INSERT INTO Clientes VALUES ('Daniel', 'Bezerra', 'daniel@gmail.com', 1, GETDATE())

-- Verificar se o registro foi inserido
SELECT * FROM dbo.Clientes WHERE Nome = 'Daniel' AND Sobrenome = 'Bezerra'

-- Se na cria��o da tabela o identificador (Id) foi implementado, n�o � necess�rio informar essa coluna nas pesquisas INSERT. 
-- Ao utilizar UPDATE e DELETE, � recomendado usar o Id no Where para especificar o registro
-- Caso esque�a de utilizar Where nos comandos UPDATE E DELETE, todos as colunas de todos os registros da tabela ser�o afetados

-- Atualiza na tabela Clientes as colunas Email e AceitaComunicados onde o Id = 1
UPDATE Clientes 
SET Email = 'emailatualizado@gmail.com', AceitaComunicados = 1
WHERE Id = 1;

-- Verificar se o registro foi atualizado
SELECT * FROM Clientes	WHERE Id = '1';

-- Deleta na tabela cliente o registro com Id = 1
DELETE Clientes WHERE Id = 1;



-- BEGIN TRAN (Begin Transaction) => Esse comando inicia uma transa��o. A partir desse ponto, todas as opera��es (como INSERT, UPDATE, DELETE) 
--                                   ficam pendentes at� que voc� decida confirmar ou cancelar a transa��o.
--                                   Garante que todas as opera��es sejam conclu�das com sucesso antes de salvar as altera��es no banco.

-- ROLLBACK => Esse comando desfaz todas as altera��es feitas desde o BEGIN TRAN. � como apertar "cancelar" � �til quando ocorre um erro ou algo inesperado.
--             Nenhuma altera��o � salva no banco. 

-- COMMIT => Confirma todas as altera��es feitas desde o BEGIN TRANSACTION.
--           Grava permanentemente os dados no banco.
--           Depois do COMMIT, n�o d� pra voltar atr�s com ROLLBACK.


BEGIN TRAN

UPDATE Clientes 
SET Email = 'emailsuperatualizado@email.com',
	AceitaComunicados = 0,
	Sobrenome = 'Bezerra';

DELETE Produtos;

SELECT * FROM Clientes; 

ROLLBACK

SELECT * FROM Clientes; 



