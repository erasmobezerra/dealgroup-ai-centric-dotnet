using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// HERANÇA -> Permite criar uma nova classe (Aluno) que herda as características da classe existente 
//            (Pessoa)como seus atributos, métodos e comportamentos.
// POLIMORFISMO -> Permite que uma variável, método ou objeto assuma várias formas. No contexto da herança, 
//             isso significa que um objeto da classe filha (Aluno) pode ser tratado como um objeto da classe pai (Pessoa).
// override -> Permite que um método na classe filha (Aluno) tenha uma implementação diferente do método na classe pai (Pessoa).

// 1. Polimorfismo de Sobrecarga (Estático ou em Tempo de Compilação):
// Ocorre quando uma classe possui múltiplos métodos com o mesmo nome, mas com diferentes listas de parâmetros (número, tipo ou ordem dos argumentos). 

// 2. Polimorfismo de Sobrescrita (Dinâmico ou em Tempo de Execução):
// Ocorre quando uma subclasse redefine (sobrescreve) um método herdado de sua superclasse, fornecendo sua própria implementação. 
namespace _21HerancaEPoliformismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno(){}

        // Construtor que chama o construtor da classe base (Pessoa)
        public Aluno(string? nome) : base(nome)
        {
        }

        public override void Apresentar()
        {
            // base.Apresentar(); // Chama o método da classe pai (Pessoa)
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");
        }

    }
}