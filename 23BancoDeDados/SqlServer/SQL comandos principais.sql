 =============================================================================================
 PRAGMA foreign_keys = on;
 
 drop table demo; 
 
 CREATE TABLE cliente(
  codcliente INTEGER PRIMARY KEY,
  nome VARCHAR(50) NOT NULL,
  sexo CHAR(1),
  estado_civil CHAR(1)
 );

 CREATE TABLE endereco (
   codendereco INTEGER PRIMARY KEY,
   logradouro VARCHAR(50) NOT NULL,
   numero  INTEGER,
   bairro VARCHAR(30),
   cidade VARCHAR(50), 
   uf CHAR(2),
   codcliente INTEGER REFERENCES cliente(codcliente)
 ); 
 
 -- Inserindo dados de forma não ordenada
 INSERT INTO cliente (codcliente, estado_civil, nome, sexo)
 VALUES (1, 'S', 'Maria', 'F');
 
 -- Inserindo dados na ordem 
 INSERT INTO cliente VALUES (2, 'Fabiola',  'F', 'C');
 INSERT INTO cliente VALUES (3, 'Rafael',  'M', 'C');
 INSERT INTO cliente VALUES (4, 'Fabiana',  'F', 'C');
 INSERT INTO cliente (codcliente, nome) values (5, 'Pedro');
 INSERT INTO cliente VALUES (6, 'Erasmo',  'M', 'C');
 iNSERT INTO cliente VALUES (7, 'Daniel',  'M', 'C');
 
 
 INSERT INTO endereco VALUES (1, 'R Fredereci Ozanan', 13, 'IBES','Vila Velha', 'ES', 1);
 INSERT INTO endereco VALUES (2, 'R Linda', 17, 'Vila Linda', 'Vitoria', 'ES', 4);
 INSERT INTO endereco VALUES (3, 'R Ipe', 150, 'Jardim Fragoso', 'Vila Velha', 'ES', 3);
 INSERT INTO endereco VALUES (4, 'R Fredereci Ozanan', 13, 'IBES', 'Vila Velha', 'ES', 2);
 INSERT INTO endereco VALUES (5, 'R Fernando Coelho', 13, 'Ilha dos Ayres', 'Vila Velha', 'ES', 1);
 
 update endereco
 set uf=NULL
 where codcliente='2'
 
 SELECT * FROM cliente;
 SELECT * FROM endereco;
  
 UPDATE cliente
 SET sexo='M', estado_civil='S'
 WHERE codcliente = 5;
 
 DELETE FROM endereco
 WHERE codcliente = 1;
 
 DELETE FROM cliente
 WHERE codcliente = 1;
 
 -- Em tabela relacionada com outra, normalmente é preciso forçar a exclusao usando CASCADE;
 -- DELETE FROM cliente
 -- WHERE codcliente = 1 CASCADE;
 
 update endereco
 SET codcliente = 5
 where codendereco = 5;
 
 SELECT * from cliente;
 select * from endereco;
 
 select codendereco, cidade, codcliente 
 FROM endereco;
 
 SELECT *
 from cliente
 where estado_civil = 'S';
 
 SELECT *
 from cliente
 where NOT estado_civil = 'S';
 
 SELECT *
 from cliente
 where estado_civil <> 'S'
 and sexo = 'F'
  
 SELECT *
 from cliente
 where sexo = 'M'
 OR sexo = 'F';
 
 select *
 from cliente
 where nome like 'F%';
 
 select *
 from cliente
 where nome like '%o';
 
 select *
 from cliente
 where codcliente > 1 and codcliente < 3;
 
 select *
 from cliente
 where codcliente BETWEEN 1 and 3;
 
 -- Ordenação de busca ORDER BY
 select * 
 from cliente
 ORDER by nome;
 
 select * 
 from cliente
 ORDER by nome desc;
 
 select * 
 from cliente
 ORDER by sexo, nome;
 
 select * 
 from cliente
 where estado_civil = 'C'
 ORDER by sexo, nome;
 
 -- Produto Cartesiano (combina cada linha de uma tabela (ou conjunto de resultados) com cada linha de outra tabela.)
 select *
 from cliente, endereco;
 
 -- JUNÇÃO por igualdade (Realiza primeiro a multiplicação (prod cartesiano) e depois filtra o resultado)
 select *
 from cliente, endereco
 where cliente.codcliente = endereco.codcliente
 order by codcliente;
 
 -- JUNÇÃO COM INNER JOIN
 -- Para realizarmos a junção, usamos o comando INNER JOIN (ou apenas JOIN) explicitando 
 -- a igualdade entre as chaves primária e estrangeira com a palavra reservada 'ON'
 select cliente.nome, endereco.uf
 from cliente inner join endereco
 on endereco.codcliente = cliente.codcliente
 where cliente.estado_civil = 'C' and endereco.uf = 'ES'
 
 -- Realizar a mesma operacao INNER JOIN mas utilizando Alias para reduzir verbosidadecliente
 -- No lugar de 'cliente.nome', pode ser 'c.nome' desde que informe 'AS c'
 select c.nome, e.uf
 from cliente AS c inner join endereco as e
 on e.codcliente = c.codcliente
 -- where c.estado_civil = 'C' and e.uf = 'ES'
 
 -- Outro tipo de JOIN que pode ser usado é o LETF JOIN cliente
 -- Ele pode ser muito útil em caso em que é necessário retornar dados de uma tabela cliente
 -- que não tenham correspondentes em outra tabela. A prioridade é a tabela da esquerda. 
 select c.nome, e.uf
 from cliente AS c left join endereco as e
 on e.codcliente = c.codcliente

 -- Enquanto o comando RIGHT JOIN, a tabela que será prioridade é a da direita 
 select c.nome, e.uf
 from cliente AS c RIGHT join endereco as e
 on e.codcliente = c.codcliente
 
 -- Funções de Agregação
 select count(codcliente), MIN(codcliente), MAX(codcliente), SUM(codcliente), AVG(codcliente)
 from cliente;
 
 -- Nâo levam em consideração campos nulos no cálculo (há um registro com campo sexo nulo)
 select count(codcliente), count(sexo) from cliente;
 
 
 -- AGRUPAMENTO DE DADOS (GROUP BY)
 -- PODE AGRUPAS LINHAS, COM BASE EM VALORES COMUNS EM UMA OU MAIS COLUNAS E EM SEGUIDA USAR FUNÇÕES DE AGREGAÇÃO
 SELECT sexo, COUNT(codcliente)
 from cliente
 GROUP by sexo
 having sexo is not null; 
 
 
 -- Selecione as colunas sexo e estado civil da tabela cliente
 -- Agrupe as alinhas que possuem os mesmos valores nas colunas especificadas
 -- As linhas da tabela cliente serão agrupadas por todas as combinações únicas de sexo e estaco_civil
 -- A função contará o numero de registros (linhas) que possuem um valor válido na coluna codcliente dentro de cada grupo
 SELECT sexo, estado_civil, COUNT(codcliente)
 from cliente
 GROUP by sexo, estado_civil
 having sexo is not null; 
 
 
 SELECT sexo, estado_civil, COUNT(codcliente)
 from cliente
 GROUP by sexo, estado_civil
 having sexo is not null
 and codcliente > 1; 
 
 
 select sexo, estado_civil, count(codcliente)
 from cliente
 GROUP by sexo, estado_civil
 having count(codcliente) > 1
 
 SELECT cliente.nome, count(endereco.codendereco) as total_endereco
 from cliente 
 left join endereco ON
 endereco.codcliente = cliente.codcliente
 group by cliente.nome
 having total_endereco > 1
  
 =============================================================================================
 PRAGMA foreign_keys = on;
  
 create table aluno (
   id_aluno integer primary key,
   nome_aluno varchar(100) not null,
   uf char(2)
 );
 
 create table boletim (
   id_boletim integer PRIMARY key,
   id_turma integer,
   id_aluno integer references aluno(id_aluno),
   nota numeric(2,1)
 );
 
 insert into aluno values(1, 'Jose', 'DF');
 insert into aluno values(2, 'Maria', 'RJ');
 insert into aluno values(3, 'Pedro', 'SP');
 insert into aluno values(4, 'Joana', 'DF');
 insert into aluno values(5, 'Bia', 'RJ');
 
 insert into boletim values(1, 1, 1, 7);
 insert into boletim values(2, 1, 2, 5);
 insert into boletim values(3, 2, 3, 6);
 insert into boletim values(4, 2, 4, 4);
 insert into boletim values(5, 2, 5, 8);
 
 -- SUBCOBSULTAS
 -- são recursos utilizados para elaboração de querys mais complexas, que nos permitem resolver problemas
 -- que seriam mais difícies com querys mais básicas. São consultas realizads dentro de outra consulta.
 -- O Banco de Dados primeiro realiza a consulta mais interna e depois faz a externa. 
 select id_aluno from boletim
 where nota > (select Avg(nota) from boletim)
 
 -- DISTINCT => Não retorno registros repetidos
 select * from aluno;
 select DISTINCT id_turma from boletim;
 
 -- UNION e INTERSECT são operadores de conjunto que combinam os resultados de duas ou mais consultas SELECT em uma única lista.
 -- UNION => Combina os resultados de duas consultas, retornando todas as linhas de ambas. Por padrão, remove as linhas duplicadas
 select id_aluno from boletim where id_turma = 1
 UNION
 select id_aluno from boletim where id_turma = 2
 
 -- INTERSECT => Compara os resultados de duas consultas e retorna apenas as linhas que existem em ambas.
 select id_aluno from boletim where id_turma = 1
 INTERSECT
 select id_aluno from aluno where uf = 'DF'
 
 
 =============================================================================================================
 
 --VIEWS (VISÔES)
 -- É uma tabela virtual e armazenada em memória, ou seja, 
 -- Ela não contém dados próprios, mas sim uma consulta SELECT que é executada toda vez que a visão é acessada.
 -- Por padrão, visões não podem ser alteradas após criadas pois são somente leitura
 
 -- Criando uma view
 create view vw_alunos_df AS
 select * from aluno where uf='DF';
 -- Chamando uma view
 SELECT * from vw_alunos_df;
 
 -- Criando uma view
 create view vw_boletim AS
 select boletim.id_turma, aluno.nome_aluno, boletim.nota 
 from boletim
 inner join aluno 
 on aluno.id_aluno = boletim.id_aluno
 
  -- Chamando a view
 SELECT * from vw_boletim;
 
 -- Deletando uma view 
 drop VIEW vw_boletim;
 
  -- Alterando uma view (nem todos os bancos permitem)
 ALTER view vw_boletim AS
 select boletim.id_turma, aluno.nome_aluno, boletim.nota, boletim.id_turma 
 from boletim
 inner join aluno 
 on aluno.id_aluno = boletim.id_aluno
 
 
-- ALternativa para alterar, seria excluir e recriar uma nova:
 drop VIEW vw_boletim; 
 
 create view vw_boletim AS
 select boletim.id_turma, aluno.nome_aluno, boletim.nota, boletim.id_turma 
 from boletim
 inner join aluno 
 on aluno.id_aluno = boletim.id_aluno;
 
 
 
 
 