using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14DescontrutorDeObjetos.Models
{
    public class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Desconstrutor
        public void Deconstruct(out string nome, out int idade)
        {
            nome = Nome;
            idade = Idade;
        }
    }
}