using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22AbstratasEInterfaces.Models
{
    public class Diretor : Professor // HERANÇA -> A classe Diretor não pode herdar as características da classe sealed Professor
    {
        public override void Apresentar() // não pode ser sobescrito pois o método Apresentar() da classe Professor é sealed
        {
            // base.Apresentar(); // Chama o método da classe pai (Pessoa)
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um professor que ganha R${Salario}.");
        }
    }
}
