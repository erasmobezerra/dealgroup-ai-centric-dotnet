using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22AbstratasEInterfaces.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Email { get; set; }

        public Pessoa() { }

        public Pessoa(string? nome)
        {
            Nome = nome;
        }
        // virtual -> permite que o método seja sobrescrito na classe filha
        // Se a classe filha implementar o método Apresentar, deve usar a palavra-chave override         
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
