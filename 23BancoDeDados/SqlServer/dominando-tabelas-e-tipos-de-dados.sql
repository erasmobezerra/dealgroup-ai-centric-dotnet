-- Se já existir uma Tabela chamada Produtos, exclua ela.
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

-- Ordenando todas as colunas da tabela dbo.Clientes de forma ordenada (ASC) 1ª pelo Nome e 2º pelo Sobrenome
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

-- Insira na tabela Cliente os valores informados na ordem de colunas informadas. (caso a ordem seja a mesma da tabela, não é preciso informar os nomes das colunas)  
INSERT INTO Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Erasmo', 'Buta', 'erasmo@gmail.com', 1, GETDATE())

-- Verificar se o registro foi inserido 
SELECT * FROM dbo.Clientes WHERE Nome = 'Erasmo'

-- Caso a ordem de inserção seja a mesma da tabela, não é preciso informar os nomes das colunas
INSERT INTO Clientes VALUES ('Daniel', 'Bezerra', 'daniel@gmail.com', 1, GETDATE())

-- Verificar se o registro foi inserido
SELECT * FROM dbo.Clientes WHERE Nome = 'Daniel' AND Sobrenome = 'Bezerra'

-- Se na criação da tabela o identificador (Id) foi implementado, não é necessário informar essa coluna nas pesquisas INSERT. 
-- Ao utilizar UPDATE e DELETE, é recomendado usar o Id no Where para especificar o registro
-- Caso esqueça de utilizar Where nos comandos UPDATE E DELETE, todos as colunas de todos os registros da tabela serão afetados

-- Atualiza na tabela Clientes as colunas Email e AceitaComunicados onde o Id = 1
UPDATE Clientes 
SET Email = 'emailatualizado@gmail.com', AceitaComunicados = 1
WHERE Id = 1;

-- Verificar se o registro foi atualizado
SELECT * FROM Clientes	WHERE Id = '1';

-- Deleta na tabela cliente o registro com Id = 1
DELETE Clientes WHERE Id = 1;



-- BEGIN TRAN (Begin Transaction) => Esse comando inicia uma transação. A partir desse ponto, todas as operações (como INSERT, UPDATE, DELETE) 
--                                   ficam pendentes até que você decida confirmar ou cancelar a transação.
--                                   Garante que todas as operações sejam concluídas com sucesso antes de salvar as alterações no banco.

-- ROLLBACK => Esse comando desfaz todas as alterações feitas desde o BEGIN TRAN. É como apertar "cancelar" — útil quando ocorre um erro ou algo inesperado.
--             Nenhuma alteração é salva no banco. 

-- COMMIT => Confirma todas as alterações feitas desde o BEGIN TRANSACTION.
--           Grava permanentemente os dados no banco.
--           Depois do COMMIT, não dá pra voltar atrás com ROLLBACK.


BEGIN TRAN

UPDATE Clientes 
SET Email = 'emailsuperatualizado@email.com',
	AceitaComunicados = 0,
	Sobrenome = 'Bezerra';

DELETE Produtos;

SELECT * FROM Clientes; 

ROLLBACK

SELECT * FROM Clientes; 



