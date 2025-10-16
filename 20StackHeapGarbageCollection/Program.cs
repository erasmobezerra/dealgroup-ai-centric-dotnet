using _20StackHeapGarbageCollection.Models;

// Alocação de memória

// Vamos entender os dois tipos de memória existentes no C#, tipos de valores e tipos de referência.
// O .NET trabalha com dois tipos de memória, onde um armazena dados estáticos e o outro armazena dados dinâmicos.

// Stack -> Armazena tipos de valores (int, double, bool, struct, enum)
//       -> O tipo de valor armazena dados estáticos e não complexos

// Heap -> Armazena tipos de referência (class, array, interface, string, delegate)
//      -> O tipo de referência armazena dados dinâmicos e complexos, 

// Garbage Collector (GC) -> A limpeza da memória Heap não é feita de maneira tradicional, sendo assim, ela depende do Garbage Collector (GC)
//                             para fazer a limpeza de memória, liberando espaço que não está mais sendo utilizado.


// Tipos de valor e referência

// Tipo de valor: Uma variável de um tipo de valor contém uma instância do tipo.
// Quando você copia a variável, você copia a instância.
int a = 10;

int b = a;
b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

// Tipo de referência: Uma variável de um tipo de referência contém uma referência a uma instância do tipo .
// Quando você copia a variável, você copia a referência, não a instância.
Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

Pessoa p2 = p1;
p2.Nome = "Vinicius";

Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");
