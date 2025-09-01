-- MANIPULANDO DADOS

-- Built-in functions => são funções pré-existentes que auxiliam na manipulação de dados, 
--                       como, por exemplo, somar, subtrair, media...


-- COUNT() => Retorna o n�mero de registros retornados por uma consulta de sele��o --

-- Retorna em uma nova coluna QuantidadeProdutos o n�mero de registros(linhas) da tabela Produtos  
SELECT COUNT(*) AS QuantidadeProdutos FROM Produtos
-- Retorna em uma nova coluna QuantidadeProdutosTamanhoM o n�mero de registros(linhas) da tabela Produtos  
SELECT COUNT(*) AS QuantidadeProdutosTamanhoM FROM Produtos WHERE Tamanho = 'M'


--  SUM() => Calcula a soma de um conjunto de valores --

-- Retorna em uma nova coluna PrecoTotal a soma dos pre�os nos registros da tabela Produtos
SELECT SUM(Preco) AS PrecoTotal FROM Produtos

--  MAX() => Retorna o valor m�ximo em um conjunto de valores
SELECT MAX(Preco) AS PrecoMaximo FROM Produtos
SELECT MAX(Preco) AS PrecoMaximoTamanhoP FROM Produtos WHERE Tamanho = 'GG'

-- *** MIN() => Retorna o valor m�nimo em um conjunto de valores
SELECT MIN(Preco) AS PrecoMinimo FROM Produtos

-- *** AVG() => Retorna o valor m�dio de uma express�o
SELECT AVG(Preco) AS MediadosPrecos FROM Produtos


--  CONCATENAÇÃO =>  � o processo de combina��o de duas ou mais cadeias de caracteres, colunas ou express�es em uma �nica cadeia de caracteres.  
--               =>  O operador + � usado para concatenar strings no MS SQL Server. Ele pega dois ou mais argumentos e retorna uma �nica cadeia de caracteres concatenada.

-- Contatenando uma nova coluna NomeProduto as colunas Nome e Cor da tabela Produtos
SELECT Nome + ', Cor: ' + Cor 
AS NomeProduto 
FROM Produtos

-- Com o operador +, nenhum dos argumentos ser� convertido automaticamente. Cada argumento da express�o precisa ser do tipo VARCHAR se a concatena��o for bem sucedida. 
-- Para concatenar valores de diferentes tipos, usamos a fun��o CAST()
SELECT 'Nome: '+ Nome + ', Cor: ' + Cor + ', Pre�o: ' + CAST(Preco AS VARCHAR) 
AS ProdutoPreco 
FROM Produtos

-- UPPER() E LOWER() => Converte uma string para mai�sculas e min�sculas, respectivamente
SELECT UPPER(Nome) AS Nome, LOWER(Cor) AS Cor 
FROM Produtos


-- ALTER TABLE =>  modificar a estrutura de uma tabela existente sem precisar recri�-la.

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



--  GROUP BY 
--     => agrupa linhas que t�m os mesmos valores em linhas de resumo, como "encontrar o n�mero de clientes em cada pa�s".
--     => � frequentemente usada com fun��es de agrega��o (COUNT(), MAX(), MIN(), SUM(), AVG()) para agrupar o conjunto de resultados por uma ou mais colunas.

-- Liste a quantidade de cada tamanho de roupa (agrupe as linhas que t�s os mesmos tamanhos (P, G, GG....) e exiba a quantidade existente por tamanho)
SELECT 
	Tamanho,
	COUNT(*) Quantidade
FROM Produtos
GROUP BY Tamanho


-- Liste a quantidade de cada tamanho de roupa por ordem descendente de quantidade - n�o agrupe registro com Tamanho vazio 
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

-- INNER JOIN 
SELECT * 
FROM Clientes INNER JOIN Enderecos 
ON Clientes.Id = Enderecos.IdCLiente
WHERE Clientes.Id = 4;


