// See https://aka.ms/new-console-template for more information
using _21HerancaEPoliformismo.Models;

Aluno p1 = new Aluno("Erasmo");
p1.Idade = 37;
p1.Email = "erasmo@example.com";
p1.Nota = 8.5;

p1.Apresentar();

Professor p2 = new Professor("Maria");
p2.Idade = 45;
p2.Email = "maria@gmail.com";
p2.Salario = 5000;

p2.Apresentar();