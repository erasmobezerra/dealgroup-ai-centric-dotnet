using sintaxe_basica_csharp.Models;

// == SINTAXE BÁSICA C# ==

// Instanciando e utilizando a classe Pessoa
Pessoa pessoa = new Pessoa();
pessoa.Nome = "Erasmo";
pessoa.Idade = 37;

Console.WriteLine("Classe Pessoa");
pessoa.Apresentar();
Console.WriteLine();



// ==  SINTAXE E TIPO DE DADOS EM C# ==

// Tipos numéricos
int idade = 30;
double altura = 1.75;
float peso = 70.5f;
decimal saldo = 1500.75m;

// Tipo caractere e texto
char inicial = 'E';
string nome = "Erasmo";

// Tipo lógico
bool ativo = true;

// Tipo de data/hora
DateTime hoje = DateTime.Now;

// Inferência de tipo
var quantidade = 3;

// Tipo base de todos os dados
object qualquer = "Pode ser qualquer tipo";

// Tipo dinâmico
dynamic dinamico = 42;
dinamico = "Agora sou uma string!";

// Saída no console
Console.WriteLine($"Nome: {nome} ({inicial})");
Console.WriteLine($"Idade: {idade} anos");
Console.WriteLine($"Altura: {altura} m");
Console.WriteLine($"Peso: {peso} kg");
Console.WriteLine($"Saldo disponível: R${saldo}");
Console.WriteLine($"Usuário ativo: {ativo}");
Console.WriteLine($"Data atual: {hoje}");
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Tipo object: {qualquer}");
Console.WriteLine($"Tipo dynamic: {dinamico}");



// DATETIME
DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime);
Console.WriteLine(dateTime.Year);
Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
Console.WriteLine(dateTime.ToString("HH:mm"));

