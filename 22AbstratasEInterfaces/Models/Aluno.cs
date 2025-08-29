using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22AbstratasEInterfaces.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno() { }

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
