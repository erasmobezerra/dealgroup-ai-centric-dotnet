// **Concatenação** de Strings

// A concatenação junta strings usando o operador `+`.

using System.Text;

string nome = "Maria";
string saudacao = "Olá, " + nome + "! Seja bem-vinda.";
Console.WriteLine(saudacao);

// Exemplo de **Interpolação** de Strings
// A interpolação é mais elegante e fácil de ler. Usa o símbolo `$` antes da string:
string nome = "João";
int idade = 30;
string mensagem = $"Olá, {nome}. Você tem {idade} anos.";
Console.WriteLine(mensagem);

//Você pode até fazer expressões dentro da interpolação:
int a = 5;
int b = 3;
Console.WriteLine($"A soma de {a} e {b} é {a + b}.");


// String.Concat()
//Pode ser eficiente para poucas concatenações, mas cria novas instâncias de string a cada operação, o que pode impactar a memória em loops grandes.
string parte1 = "Bom ";
string parte2 = "dia!";
string frase = String.Concat(parte1, parte2);
Console.WriteLine(frase);

// StringBuilder 
// E uma classe para manipular strings de forma eficiente, especialmente em loops ou concatenações múltiplas.
// Ele permite modificar o conteúdo sem criar novas instâncias de string, economizando memória e melhorando a performance.
var sb = new StringBuilder();
sb.Append("Olá");
sb.Append(" ");
sb.Append("Mundo");
string resultado = sb.ToString();
Console.WriteLine(resultado);

