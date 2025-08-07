/* ESTRUTURAS CONDICIONAIS
 
=> IF / ELSE

A estrutura condicional if/else é um recurso que indica quais instruções o sistema deve processar de acordo com uma expressão booleana. Assim, o sistema testa se uma condição é verdadeira e então executa comandos de acordo com esse resultado.

Sintaxe do if/else:

if (expressão booleana)
{
	// código 1
}
else
{
// código 2
}




=> Sintaxe do else if:

Complementar ao if/else temos o operador else if que traz uma nova condição a ser testada no caso de falha no teste da condição anterior.


if (expressão booleana 1)
{
	// código 1
}
else if (expressão booleana 2)
{
	// código 2
}
else
{
	// código 3
}




=> Operador Ternário

O operador ternário é um recurso para tomada de decisões com objetivo similar ao do if/else mas que é codificado em apenas uma linha.

Sintaxe do operador ternário:

expressão booleana ? código 1 : código 2;


==================================
Exemplo de uso if else:
*/

double media = 8;
if (media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else if (media < 7 && media >=5)
{
    Console.WriteLine("Aluno em recuperação!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}


// Exemplo de uso Operador Ternário:

media = 8;
string resultado = "Olá aluno, você foi ";
resultado += media >= 7 ? "aprovado." : "reprovado.";
Console.WriteLine(resultado);





/* =>  Switch Case?
 
É uma estrutura de controle de fluxo em C# (e em muitas outras linguagens de programação, como o Java, por exemplo) que permite que um programa escolha entre várias alternativas com base no valor de uma expressão. Em essência, o switch case é uma alternativa mais limpa e organizada aos blocos if-else aninhados.
A sintaxe básica do switch case em C# é a seguinte:

switch (expressao)
{
  case valor1:
      // Código a ser executado se a expressão for igual a valor1
      break;
  case valor2:
      // Código a ser executado se a expressão for igual a valor2
      break;
  // Outros casos possíveis
  default:
      // Código a ser executado se nenhum dos casos anteriores for correspondido
      break;
}

*/

// Exemplo prático:

double num1 = 10;
double num2 = 5;
char operador = '+';
double soma = 0;


switch (operador)
{
  case '+':
      soma = num1 + num2;
      break;
  case '-':
      soma = num1 - num2;
      break;
  case '*':
      soma = num1 * num2;
      break;
  case '/':
      soma = num1 / num2;
      break;
  default:
      Console.WriteLine("Operador inválido");
      return;
}

Console.WriteLine($"Resultado: {soma}");








