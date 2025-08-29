using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classe Object: 
// A classe base de todas as classes em C# é a classe Object. Todas as classes herdam implicitamente de Object.
// Ou seja, todas as classes em C# são subclasses de Object, o que significa que elas herdam seus métodos e propriedades.

// Ao criar uma classe, você pode sobrescrever os métodos da classe Object para fornecer implementações personalizadas.
// O método ToString() é um exemplo comum de sobrescrita, onde você pode retornar uma representação em string do objeto.

// Métodos principais da classe Object:
// -> ToString(): Retorna uma representação em string do objeto.
// -> Equals(): Compara os endereços da memórias dos dois objetos para verificar se são iguais.
// -> GetHashCode(): Retorna um código hash para o objeto, usado em coleções como dicionários.
// -> GetType(): Retorna o tipo do objeto em tempo de execução.
namespace _22AbstratasEInterfaces.Models
{
    internal class Computador
    {
        // De onde vem o método ToString()?
        // O método ToString() é herdado da classe base Object, que é a classe raiz de todas as classes em C#.
        public override string ToString()
        {
            return "Retornando a classe Computador pelo método ToStrin()";
        }
       

    }
}
