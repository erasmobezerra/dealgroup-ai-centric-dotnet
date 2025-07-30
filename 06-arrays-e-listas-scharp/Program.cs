
/* 
== ARRAYS E LISTAS em C# ==

==> ARRAYS 
*/

// O valor Default de um índice num array de inteiros é "0"

int[] arrayInteiros = new int[3];
//int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// Caso tente acessar um index inexistente em um array, por exemplo o array tem 2 elementos e tento acessar o elemento 3 que não existe, será lançada uma exceção:
//arrayInteiros[3] = 50;


/* Redimensionando um Array - > Resize() 
 Altera o número de elementos de uma matriz unidimensional para o novo tamanho especificado. Isso pode ser usado para aumentar ou diminuir 
 o número de elementos em uma determinada matriz.

 Age copiando a referência do array original com seus elementos e então aponta a referência para o novo array originado do redimensionamento 
 do original de acordo com as especificações passados por parâmetro no método
*/
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


/*
 Copiando um Array -> Copy()
 Copia os elementos de um array para outro array já existente, especificando quantos elementos devem ser copiados.
*/
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);




// Percorrendo um Array com "For"
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posicao Nº {contador} - {arrayInteiros[contador]}");
}





// Percorrendo um Array com "Foreach"
int contadorDeArray = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posicao Nº {contadorDeArray} - {valor}");
    contadorDeArray++;
}



// Listas em C#

// Uma List é uma coleção dinâmica que permite adicionar ou remover elementos conforme necessário. Elas são extremamente versáteis e úteis quando o tamanho da coleção pode variar. 


List<string> listString = new List<string>();

listString.Add("SP");
listString.Add("BA");
listString.Add("MG");
listString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");

listString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");

listString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listString.Count} - Capacidade: {listString.Capacity}");


