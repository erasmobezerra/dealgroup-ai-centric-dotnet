
using _20AbstracaoEEncapsulamento.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Erasmo";
p1.Idade = 37;

Console.WriteLine("Classe Pessoa");
p1.Apresentar();

Console.WriteLine("**************************");

ContaCorrente conta = new ContaCorrente(123, 5);
Console.WriteLine("Classe ContaCorrente:");
conta.ExibirSaldo();
conta.Sacar(2);
conta.ExibirSaldo();

