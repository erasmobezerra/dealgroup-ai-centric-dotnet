/*
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

*/

-- MANIPULANDO DADOS

-- *** Built-in functions => são funções pré-existentes que auxiliam na manipuação de dados, 
--                       como, por exemplo, somar, subtrair, media...



-- *** COUNT() => Retorna o número de registros retornados por uma consulta de seleção --

-- Retorna em uma nova coluna QuantidadeProdutos o número de registros(linhas) da tabela Produtos  
SELECT COUNT(*) AS QuantidadeProdutos FROM Produtos
-- Retorna em uma nova coluna QuantidadeProdutosTamanhoM o número de registros(linhas) da tabela Produtos  
SELECT COUNT(*) AS QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'


-- *** SUM() => Calcula a soma de um conjunto de valores --

-- Retorna em uma nova coluna PrecoTotal a soma dos preços nos registros da tabela Produtos
SELECT SUM(Preco) AS PrecoTotal FROM Produtos

-- *** MAX() => Retorna o valor máximo em um conjunto de valores
SELECT MAX(Preco) AS PrecoMaximo FROM Produtos
SELECT MAX(Preco) AS PrecoMaximoTamanhoP FROM Produtos WHERE Tamanho = 'GG'

-- *** MIN() => Retorna o valor mínimo em um conjunto de valores
SELECT MIN(Preco) AS PrecoMinimo FROM Produtos

-- *** AVG() => Retorna o valor médio de uma expressão
SELECT AVG(Preco) AS MediadosPrecos FROM Produtos


-- CONCATENANÇÃO =>  é o processo de combinação de duas ou mais cadeias de caracteres, colunas ou expressões em uma única cadeia de caracteres.  
--               =>  O operador + é usado para concatenar cordas no MS SQL Server. Ele pega dois ou mais argumentos e retorna uma única cadeia de caracteres concatenada.

-- Contatenando uma nova coluna NomeProduto as colunas Nome e Cor da tabela Produtos
SELECT Nome + ', Cor: ' + Cor 
AS NomeProduto 
FROM Produtos

-- Com o operador +, nenhum dos argumentos será convertido automaticamente. Cada argumento da expressão precisa ser do tipo VARCHAR se a concatenação for bem sucedida. 
-- Para concatenar valores de diferentes tipos, usamos a função CAST()
SELECT 'Nome: '+ Nome + ', Cor: ' + Cor + ', Preço: ' + CAST(Preco AS VARCHAR) 
AS ProdutoPreco 
FROM Produtos

-- UPPER() E LOWER() => Converte uma string para maiúsculas e minúsculas, respectivamente
SELECT UPPER(Nome) AS Nome, LOWER(Cor) AS Cor 
FROM Produtos


-- *** ALTER TABLE =>  modificar a estrutura de uma tabela existente sem precisar recriá-la.

-- Adicionar Coluna 
ALTER TABLE Produtos ADD DataCadastro DATETIME2
-- Atualizando DataCadastro de todos os registros com a data e hora atual
UPDATE Produtos SET DataCadastro = GETDATE() 

-- Remover Coluna
ALTER TABLE Produtos DROP COLUMN DataCadastro


-- *** Formatando Datas com FORMAT()
SELECT 'Nome: '+ Nome + ', Cor: ' + Cor + ', ' + FORMAT(DataCadastro, 'dd/MM/yyyy HH:mm')
AS ProdutoPrecoData 
FROM Produtos



-- *** GROUP BY 
--     => agrupa linhas que têm os mesmos valores em linhas de resumo, como "encontrar o número de clientes em cada país".
--     => é frequentemente usada com funções de agregação (COUNT(), MAX(), MIN(), SUM(), AVG()) para agrupar o conjunto de resultados por uma ou mais colunas.

-- Liste a quantidade de cada tamanho de roupa (agrupe as linhas que tês os mesmos tamanhos (P, G, GG....) e exiba a quantidade existente por tamanho)
SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
GROUP BY Tamanho


-- Liste a quantidade de cada tamanho de roupa por ordem descendente de quantidade - não agrupe registro com Tamanho vazio 
SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC


-- Criando tabela Enderecos relacionada com a tabela Clientes
DROP TABLE IF EXISTS dbo.Enderecos
CREATE TABLE Enderecos (
	[Id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdCLiente] [int] NULL,
	[Rua] [varchar](255) NULL,
	[Bairro] [varchar](255) NULL,
	[Cidade] [varchar](255) NULL,
	[Estado] [char](2) NULL

	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY(IdCliente)
	REFERENCES Clientes(Id)

)


SELECT * FROM Clientes
SELECT * FROM Enderecos

INSERT INTO Enderecos VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'ES')


SELECT * FROM Clientes WHERE Id = 4;
SELECT * FROM Enderecos WHERE IdCLiente = 4;

-- *** INNER JOIN 
SELECT * 
FROM Clientes INNER JOIN Enderecos 
ON Clientes.Id = Enderecos.IdCLiente
WHERE Clientes.Id = 4;


