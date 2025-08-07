using _07PropriedadesMetodosContrutores.Models;

// Instanciando com construtor sem parâmetros
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Sobrenome = "Silva";

// Instanciando com construtor com parâmetros sem nome dos parâmetros
Pessoa pessoa2 = new Pessoa("Maria", "Silva");

// Instanciando com construtor com parâmetros com nome dos parâmetros
// Pessoa pessoa3 = new Pessoa(Nome: "Ana", Sobrenome: "Oliveira");
Pessoa pessoa3 = new Pessoa
{
    Nome = "Ana",
    Sobrenome = "Oliveira"
};

Curso curso = new Curso();
curso.Nome = "Programação C#";
curso.Alunos = new List<Pessoa>();

curso.AdicionarAluno(pessoa1);
curso.AdicionarAluno(pessoa2);
curso.AdicionarAluno(pessoa3);

int totalAlunos = curso.ObterTotalAlunos();
Console.WriteLine($"Total de alunos no curso {curso.Nome}: {totalAlunos}");
curso.ListarAlunos();

Console.WriteLine("Removendo aluno João Silva...");
curso.RemoverAluno(pessoa1);
totalAlunos = curso.ObterTotalAlunos();
Console.WriteLine($"Total de alunos no curso {curso.Nome}: {totalAlunos}");
curso.ListarAlunos();