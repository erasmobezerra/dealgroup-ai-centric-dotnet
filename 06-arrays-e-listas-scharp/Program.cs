//== ARRAYS E LISTAS em C# ==

// https://balta.io/blog/arrays-monodimensionais-e-multidimensionais-no-csharp
// https://web.dio.me/track/deal-group-ai-centric-net

/* ARRAYS 

Os arrays são representações de listas no C#. 
São estruturas fixas de dados que armazenam múltiplos valores do mesmo tipo.
Deve ser inicializado com o tamanho definido.
Os elementos são acessados por índices iniciando em 0. */

/* Array monodimensional (vetor)
O array monodimensional, também conhecido como vetor, é uma lista simples que pode ser declarada da seguinte forma:*/
int[] monodimensionalArray = new int[10];

/*
 É preciso lembrar que os arrays no C# tem a posição inicial como zero. Sendo assim, um array de 10 elementos fica com as posições: 0, 1, 2... 8, 9.
 O C# uma linguagem tipada e isto implica que, uma vez definido o tipo do array, apenas valores do mesmo tipo serão aceitos.
 

 *Inicializando o vetor
  O array pode ser inicializado na declaração Ou posteriormente adicionando valor a cada posição: */
int[] monodimensionalArray1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
monodimensionalArray1[0] = 61;

/* O valor entre colchetes representa a posição do array que deve receber o valor. No exemplo acima, a posição zero está recebendo o valor 61, ou seja, ao 
lermos a primeira posição do nosso array teremos 61 como retorno. 


 *Lendo itens do vetor
  Ler o valor de um elemento do array é bem simples. Basta chamar o array e entre colchetes passar a posição que desejamos: */
Console.WriteLine($"{monodimensionalArray1[0]}");


/* ITERANDO / PERCORRENDO O VETOR
Nós podemos utilizar tanto a instrução for quanto a instrução foreach para percorrer o nosso array e declararmos uma ação cada vez que chegarmos em uma posição diferente.

Primeiro vamos atribuir valores para cada posição do nosso array:*/
for (var item = 0; item < monodimensionalArray.Length; item++)
    monodimensionalArray[item] = item;

// Nos exemplos abaixo, o array é percorrido e o valor armazenado em cada posição é exibido no console:
for (var item = 0; item < monodimensionalArray.Length; item++)
    Console.WriteLine(monodimensionalArray[item]);


// Simplificando com foreach:
foreach (var item in monodimensionalArray)
    Console.WriteLine(monodimensionalArray[item]);


// Caso tente acessar um index inexistente em um array, por exemplo o array tem 2 elementos
// e tento acessar o elemento 3 que não existe, será lançada uma exceção:
int[] arrayInteiros = new int[3];
// Console.WriteLine(arrayInteiros[3]); // Isso causará um erro de índice fora do intervalo (IndexOutOfRangeException).


// Nota 1: Nos casos em que se faça necessário copiar um array, opte sempre pelo método .Clone(). Usar = com arrays apenas cria uma nova referência para os mesmos elementos, 
//         e a edição de um elemento pode acabar modificando os "dois" arrays.Nota 1: Nos casos em que se faça necessário copiar um array, opte sempre pelo método .Clone(). Usar = com arrays apenas cria uma nova referência para os mesmos elementos, e a edição de um elemento pode acabar modificando os "dois" arrays.
int[] original = { 1, 2, 3 };
int[] copia = (int[])original.Clone();

// Nota 2: Copiando arrays com Array.Copy() é uma forma de copiar os elementos de um array para outro array já existente, especificando quantos elementos devem ser copiados.
int[] numeros = { 1, 2, 3, 4 };
int[] copiaNumeros = new int[4];
Array.Copy(numeros, copiaNumeros, numeros.Length);



// ****************************************************



/* Array multidimensional (matriz)
 
Um array multidimensional (matriz) é uma estrutura de dados que permite armazenar valores em mais de uma dimensão, como uma tabela ou grade.


Declarando a matriz
Podemos declarar a matriz acima como um array multidimensional 3x2:*/

int rows = 3;
int columns = 2;

int[,] varMultidimensionalArray = new int[rows, columns];

// Ou de forma mais direta:

int[,] multidimensionalArray1 = new int[3, 2];

//Inicializando a matriz
//A matriz pode ser inicializada na declaração, variando de acordo com a dimensão da matriz:

int[,] multidimensionalArray = new int[3, 2] { { 16, 52 }, { 91, 43 }, { 77, 28 } };

//Ou posteriormente adicionando valor a cada posição assim como mostrado na matriz monodimensional:
multidimensionalArray[0, 0] = 16; // primeira linha, coluna um
multidimensionalArray[0, 1] = 52; // primeira linha, coluna dois
multidimensionalArray[1, 0] = 91; // segunda linha, coluna um
multidimensionalArray[1, 1] = 43; // segunda linha, coluna dois
multidimensionalArray[2, 0] = 77; // terceira linha, coluna um
multidimensionalArray[2, 1] = 28; // terceira linha, coluna dois
// Observe que, diferente do vetor, atribuir valor à matriz exige que seja declarada a linha e coluna do item que está recebendo valor.


// Lendo itens da matriz
// Ler o valor de um item de uma matriz é tão simples quanto ler de um vetor. Basta chamar a matriz e entre colchetes passar a linha e coluna que desejamos:
Console.WriteLine(multidimensionalArray[0, 0]);
//E assim teremos como saída no console o valor da posição indicada.


// ITERANDO / PERCORRENDO A MATRIZ

// Com a nossa matriz definida, vamos percorrer os elementos utilizando a instrução foreach para exibir o valor dos elementos no console:
foreach (int item in multidimensionalArray)
    Console.WriteLine($"{item}");


// Ou Percorrendo a mesma matriz com for aninhado:
for (int i = 0; i < multidimensionalArray.GetLength(0); i++)
{
    for (int j = 0; j < multidimensionalArray.GetLength(1); j++)
    {
        Console.WriteLine($"Linha {i}, Coluna {j}: {multidimensionalArray[i, j]}");
    }
}


// **************************************************

// MÉTODOS PRINCIPAIS DE ARRAY


//-Array.Sort(array) → Ordena os elementos.
//- Array.Reverse(array) → Inverte a ordem dos elementos.
//- Array.IndexOf(array, valor) → Retorna o índice do valor.
//- Array.Clear(array, início, quantidade) → Zera os elementos.
//🧪 Exemplo:
int[] numeross = { 30, 10, 50, 20 };

// Ordenando
Array.Sort(numeross); // [10, 20, 30, 50]

// Invertendo
Array.Reverse(numeross); // [50, 30, 20, 10]

// Índice de um valor
int posicao = Array.IndexOf(numeross, 30); // retorna 1

// Limpando parte do array
Array.Clear(numeross, 1, 2); // [50, 0, 0, 10]


/* Redimensionando um Array - > Resize() 
 Altera o número de elementos de uma matriz unidimensional para o novo tamanho especificado.
 Isso pode ser usado para aumentar ou diminuir 
 o número de elementos em uma determinada matriz.

 Age copiando a referência do array original com seus elementos e então aponta a referência para o novo array originado do redimensionamento 
 do original de acordo com as especificações passados por parâmetro no método
*/
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);



// **************************************************


// LISTAS em C# ( List<T> )

//- Elas são extremamente versáteis e úteis quando o tamanho da coleção pode variar. 
//- Coleção dinâmica que pode crescer ou diminuir.
//- Requer using System.Collections.Generic;

// Como declarar uma List<T>
// Declarando vazia e adicionando depois:
List<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Add("Carlos");


// Declarando com elementos:
List<int> listaDeNumeros = new List<int> { 10, 20, 30 };


// Usando var com inferência de tipo:
var frutas = new List<string> { "Maçã", "Banana", "Laranja" };


// Formas de iterar uma lista

//1. for tradicional
for (int i = 0; i < listaDeNumeros.Count; i++)
{
    Console.WriteLine($"Elemento {i}: {listaDeNumeros[i]}");
}


//2. foreach
foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }




// **************************************************

// MÉTODOS PRINCIPAIS DE UMA List<T>

//- .Add(item) → Adiciona um item.
//- .Remove(item) → Remove item por valor.
//- .RemoveAt(índice) → Remove pelo índice.
//- .Contains(item) → Verifica existência.
//- .IndexOf(item) → Retorna posição.
//- .Sort() e .Reverse() → Ordena/inverte.
//- .Clear() → Remove todos os elementos.
//- .Count → Retorna quantidade de itens.

//🧪 Exemplo:
List<string> frutass = new List<string>();

frutass.Add("Maçã");
frutass.Add("Banana");
frutass.Add("Laranja");

// Verificando existência
if (frutass.Contains("Banana"))
    Console.WriteLine("Tem banana!");

// Ordenando lista
frutass.Sort(); // ["Banana", "Laranja", "Maçã"]

// Removendo
frutass.Remove("Maçã");

// Número de itens
Console.WriteLine($"Total de frutas: {frutass.Count}");



// Formas de copiar os elementos de uma `List<T>` (sem copiar a referência)

// Construtor da List
// Cria uma nova lista com os mesmos elementos.
List<int> listaOriginal = new List<int> { 1, 2, 3 };
List<int> copiaLista = new List<int>(listaOriginal);


// Cópia manual com `foreach`
List<int> novaCopia = new List<int>();
foreach (int item in copiaLista)
{
    novaCopia.Add(item);
}

// Exibindo os elementos copiados
Console.WriteLine("Elementos copiados de novaCopia:");
foreach (var item in novaCopia)
{
    Console.WriteLine(item);
}

// Útil se você quiser aplicar alguma transformação ou filtro durante a cópia.




