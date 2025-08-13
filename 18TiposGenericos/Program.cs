
using System.Collections.Concurrent;
using _18TiposGenericos.Models;

// *Tipos Genéricos no C#

// *Conceito
// Tipos genéricos permitem definir classes, structs, interfaces e métodos com parâmetros de tipo que são especificados apenas no momento do uso

// *Classes Genéricas
// As classes genéricas encapsulam operações que não são específicas de um determinado tipo de dados
// No exemplo abaixo, a classe genérica MeuArray<T> pode ser instanciada com o tipo desejado: 

MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);


MeuArray<string> arrayStrings = new MeuArray<string>();
arrayStrings.AdicionarElementoArray("Hello Word");
Console.WriteLine(arrayStrings[0]);


MeuArray<bool> arrayBool = new MeuArray<bool>();
arrayBool.AdicionarElementoArray(false);
Console.WriteLine(arrayBool[0]);


// *Principais Tipos Genéricos da Biblioteca .NET
// List<T>
List<int> numeros = new() { 1, 2, 3 };
numeros.Add(4);

// Dictionary<TKey, TValue>
Dictionary<string, decimal> precos = new();
precos["Banana"] = 1.99M;
precos["Maçã"] = 2.49M;

// Queue<T> e Stack<T>
Queue<string> fila = new();
fila.Enqueue("Alice");
fila.Enqueue("Bob");

Stack<string> pilha = new();
pilha.Push("Primeiro");
pilha.Push("Segundo");

// HashSet<T>
HashSet<int> conjunto = new() { 1, 2, 3 };
conjunto.Add(2); // não adiciona duplicata

// Nullable<T>
int? idade = null;
if (!idade.HasValue)
{
    idade = 18;
}

// ConcurrentDictionary<TKey, TValue>
var cache = new ConcurrentDictionary<Guid, string>();
cache.TryAdd(Guid.NewGuid(), "Valor qualquer");


