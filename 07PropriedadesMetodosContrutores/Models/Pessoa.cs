using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* Propriedades -> Permitem encapsular campos, oferecendo controle sobre como os valores são acessados e modificados.
 - Métodos -> É um bloco de códigos que definem comportamentos que as instâncias da classe podem executar. 
 - Construtores -> Métodos especiais usados para inicializar objetos de uma classe, definindo valores, limites e outras configurações iniciais.
 - Body Expressions -> Sintaxe concisa para definir propriedades e métodos, eliminando a necessidade de chaves e o uso explícito de `return`.
 - Modificadores de acesso -> Controlam a visibilidade e o acesso aos membros da classe, como `public`, `private`, `protected` e `internal`.
        public -> Acessível de qualquer lugar.
        private -> Acessível apenas dentro da própria classe.    
        protected -> Acessível apenas dentro da própria classe e por classes derivadas.
        internal -> Acessível apenas dentro do mesmo assembly (projeto). 
*/


// Exemplo de classe Pessoa com propriedades, métodos e construtores
namespace _07PropriedadesMetodosContrutores.Models
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