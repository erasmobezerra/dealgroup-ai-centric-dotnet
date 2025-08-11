
// * Desconstrutor 
// É um método especial que permite quebrar um objeto em suas partes // constituintes (normalmente propriedades) usando tuplas. 
// Ele é útil quando você quer extrair dados de um objeto de forma simples e direta.
// É como o oposto de um construtor: enquanto o construtor monta o objeto, o desconstrutor desmonta.

using _14DescontrutorDeObjetos.Models;

var pessoa = new Pessoa("Erasmo", 30);

// Desconstruindo o objeto em variáveis
var (nome, idade) = pessoa;

Console.WriteLine($"Nome: {nome}, Idade: {idade}");
