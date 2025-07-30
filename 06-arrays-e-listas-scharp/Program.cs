

//== ARRAYS ( Matrizes ) E LISTAS ( Coleções ) em C# ==


// Arrays (MATRIX)

//-Estrutura fixa de dados que armazena múltiplos valores do mesmo tipo.
//- Deve ser inicializado com o tamanho definido.
//- Os elementos são acessados por índices iniciando em 0.



// Caso tente acessar um index inexistente em um array, por exemplo o array tem 2 elementos
// e tento acessar o elemento 3 que não existe, será lançada uma exceção:
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
//arrayInteiros[3] = 50;


// TIPO DE MATRIZES EM C#

// Uma matriz pode ser unidimensional, multidimensional ou irregular.
// O número de dimensões é definido quando uma variável de matriz é declarada.
// O comprimento de cada dimensão é estabelecido quando a instância da matriz é criada.
// Esses valores não podem ser alterados durante o ciclo de vida da instância.
// As matrizes são indexadas por zero: uma matriz com elementos n é indexada de 0 para n-1.
// Os elementos de matriz podem ser de qualquer tipo, inclusive um tipo de matriz.

// Array unidimensional
int[] array1 = new int[5];
// Declare and set array element values.
int[] array2 = [1, 2, 3, 4, 5, 6];

// Array multidimensional
int[,] multiDimensionalArray1 = new int[2, 3];
// Declare and set array element values.
int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

// Uma matriz irregular ( jagged array ) é uma matriz de matrizes e cada matriz de membros tem o valor padrão de null.
int[][] jaggedArray = new int[6][];
jaggedArray[0] = [1, 2, 3, 4];



// Percorrendo um Array com "For"
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posicao Nº {contador} - {arrayInteiros[contador]}");
}

// Percorrendo um Array com "Foreach"
int contadorDeArray = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posicao Nº {contadorDeArray} - {valor}");
    contadorDeArray++;
}



// Formas de Iterar Arrays em C#

// Array unidimensional
int[] notas = { 7, 8, 9 };

Console.WriteLine("Notas (for):");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"Nota {i + 1}: {notas[i]}");
}

Console.WriteLine("\nNotas (foreach):");
foreach (int nota in notas)
{
    Console.WriteLine($"Nota: {nota}");
}

// Array bidimensional
int[,] tabela = {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

Console.WriteLine("\nTabela (for aninhado):");
for (int i = 0; i < tabela.GetLength(0); i++)
{
    for (int j = 0; j < tabela.GetLength(1); j++)
    {
        Console.WriteLine($"tabela[{i},{j}] = {tabela[i, j]}");
    }
}

Console.WriteLine("\nTabela (foreach):");
foreach (int valor in tabela)
{
    Console.WriteLine(valor);
}


//🔢 Array em C#: Métodos e Propriedades Comuns

//🧰 Principais Métodos:
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

/*
 Copiando um Array -> Copy()
 Copia os elementos de um array para outro array já existente, especificando quantos elementos devem ser copiados.
*/
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);




//📋 LISTAS ( Coleções ) em C#

//- Elas são extremamente versáteis e úteis quando o tamanho da coleção pode variar. 
//- Coleção dinâmica que pode crescer ou diminuir.
//- Requer using System.Collections.Generic;

//📋 Como declarar uma List<T>
//✅ Declarando vazia e adicionando depois:
List<string> nomes = new List<string>();
nomes.Add("Ana");
nomes.Add("Carlos");


//✅ Declarando com elementos:
List<int> numeros = new List<int> { 10, 20, 30 };


//✅ Usando var com inferência de tipo:
var frutas = new List<string> { "Maçã", "Banana", "Laranja" };


//🔁 Formas de iterar uma lista

//1. 🔄 for tradicional
for (int i = 0; i < numeros.Count; i++)
{
    Console.WriteLine($"Elemento {i}: {numeros[i]}");
}


//2. 🌀 foreach
foreach (string nome in nomes)
    {
        Console.WriteLine(nome);
    }



//🧰 Principais Métodos:

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



