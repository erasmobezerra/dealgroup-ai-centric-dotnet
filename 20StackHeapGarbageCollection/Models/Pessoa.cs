using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20StackHeapGarbageCollection.Models
{
    public class Pessoa
    {
        private string _nome;
        //private int _idade;

        public string Nome
        {
            // Body Expressions -> abstrai as chaves e return
            get => _nome;
            // Validação de entrada
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Nome não pode ser vazio ou nulo.");
                }
                _nome = value;
            }
        }

        // public int Idade
        // {
        //     get => _idade;
        //     set
        //     {
        //         if (value < 0)
        //         {
        //             throw new ArgumentException("Idade não pode ser negativa.");
        //         }
        //         _idade = value;
        //     }
        // }

        public string Sobrenome { get; set; }

        // Propriedade somente leitura que combina Nome e Sobrenome
        public string NomeCompleto { get => $"{Nome} {Sobrenome}"; }

        // Construtor padrão sem parâmetros
        public Pessoa() { }

        // Construtor padrão
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        // // Metodo para apresentar informações da pessoa
        // public void Apresentar()
        // {
        //     Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        // }


    }
}