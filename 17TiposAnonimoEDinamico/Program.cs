// *Tipos Anônimos no C#

// *Conceito
// Tipos anônimos permitem encapsular um conjunto de propriedades somente leitura em um único objeto 
// sem precisar definir explicitamente uma classe. O compilador gera um tipo com nome interno e infere o 
// tipo de cada propriedade com base na expressão de inicialização.

// *Declaração
// Para criar um tipo anônimo, utilize o operador new com inicializador de objeto:
// Nesse exemplo, o compilador infere Amount como int e Message como string.
var v = new { Amount = 108, Message = "Hello" };
Console.WriteLine(v.Amount + v.Message);

// Outro exemplo:
var v2 = new { Id = 1, Nome = "Produto A", Preco = 9.99 };
Console.WriteLine($"Id: {v2.Id}, Nome: {v2.Nome}, Preço: {v2.Preco}");


Console.WriteLine("*****************************");

// *Tipos Dinâmicos no C#

// *Conceito
// O tipo dynamic permite que operações em um objeto sejam resolvidas apenas em tempo de execução, ignorando a 
// verificação de tipos estáticos do compilador. Na maioria dos casos, um objeto dynamic funciona como se tivesse 
// o tipo object, mas o compilador assume que ele suporta qualquer operação, deixando a validação para o runtime.

// Exemplo 1: mostra como uma variável dynamic pode representar diferentes tipos
dynamic v3 = 1;
Console.WriteLine(v3 + 2);
Console.WriteLine(v3.GetType()); // System.Int32

v3 = "Hello";
Console.WriteLine(v3 + " World");
Console.WriteLine(v3.GetType()); // System.String
