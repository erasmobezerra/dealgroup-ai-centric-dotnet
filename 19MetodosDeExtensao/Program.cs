using _19MetodosDeExtensao.Models;

// *Métodos de Extensão em C#

// Métodos de extensão permitem “adicionar” métodos a tipos já existentes sem modificar seu código-fonte 
// original, nem criar uma classe derivada. Eles são declarados como métodos estáticos, mas podem ser 
// invocados como se fossem métodos de instância do tipo estendido.

// - O compilador identifica métodos de extensão pelo modificador this no primeiro parâmetro.
// - Só estão disponíveis quando o namespace que contém a definição é importado via using no código cliente.

int numero = 20;
bool par = false;
par = numero.EhPar(); // método de extensão
string mensagem = "O número " + numero + " " + "é " + (par ? "par" : "impar");
Console.WriteLine(mensagem);


string frase = "O rápido castor saltou sobre o cão preguiçoso.";
int totalPalavras = frase.WordCount(); // método de extensão 
Console.WriteLine($"Total de palavras: {totalPalavras}");
