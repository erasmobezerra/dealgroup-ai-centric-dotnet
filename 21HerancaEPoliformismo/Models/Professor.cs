using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21HerancaEPoliformismo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public Professor(){}

        // Construtor que chama o construtor da classe base (Pessoa)
        public Professor(string? nome) : base(nome)
        {
        }

        public override void Apresentar()
        {
            // base.Apresentar(); // Chama o método da classe pai (Pessoa)
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um professor que ganha R${Salario}.");
        }
    }
}
