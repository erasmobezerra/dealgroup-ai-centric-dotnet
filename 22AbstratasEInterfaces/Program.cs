// Classes Abstratas
// -> Classes que não podem ser instanciadas, servem como base para outras classes.
// -> Elas podem conter métodos abstratos (sem implementação) e/ou métodos concretos (com implementação).

// Método abstrato: são métodos declarados sem corpo, que devem ser implementados nas classes derivadas.

using _22AbstratasEInterfaces.Models;

//Conta conta = new Conta(); // Não é possível instanciar uma classe abstrata

ContaCorrente contaCorrente = new ContaCorrente();
contaCorrente.Creditar(1000);
contaCorrente.ExibirSaldo(); // Exibe: Saldo: R$ 1.000,00

// **********************************************************************************************************

// Classe Object: 
// A classe base de todas as classes em C# é a classe Object. Todas as classes herdam implicitamente de Object.

Computador computador = new Computador();
Computador computador2 = new Computador();

Console.WriteLine(computador.ToString()); // Exibe: Retornando a classe Computador pelo método ToStrin()
Console.WriteLine(computador.GetType()); // Exibe: _22AbstratasEInterfaces.Models.Computador
Console.WriteLine(computador.Equals(computador2)); // Exibe: False (pois são objetos diferentes)
Console.WriteLine(computador.GetHashCode()); // Exibe o código hash do objeto

// e se computador1 tivesse os mesmos valores que computador2?
Computador computador1 = computador2; // Apontando para o mesmo objeto na memória, cópia da referência
Console.WriteLine(computador1.Equals(computador2)); // Exibe: True (pois são o mesmo objeto na memória)

// **********************************************************************************************************

// Interfaces:
// As interfaces definem um contrato que as classes devem seguir, permitindo a implementação de múltiplos comportamentos.
// A classe calculadora implementa a interface ICalculadora, que define os métodos de operações matemáticas.
Calculadora calculadora = new Calculadora();
Console.WriteLine(calculadora.Somar(10, 5)); // Exibe: 15
Console.WriteLine(calculadora.Subtrair(10, 5)); // Exibe: 5
Console.WriteLine(calculadora.Multiplicar(10, 5)); // Exibe: 50
Console.WriteLine(calculadora.Dividir(10, 5)); // Exibe: 2