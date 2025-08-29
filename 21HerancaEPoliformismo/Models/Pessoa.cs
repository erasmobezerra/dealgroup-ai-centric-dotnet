using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ABSTRAÇÃO -> Ocultar detalhes desnecessários e mostrar apenas informações essenciais.
// Uma pessoa no mundo real tem muitas características, mas aqui estamos focando apenas no nome e na idade.
// virtual -> permite que o método seja sobrescrito na classe filha
namespace _21HerancaEPoliformismo.Models
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
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}