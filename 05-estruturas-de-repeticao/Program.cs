/*
== ESTRUTURAS DE REPETIÇÃO ==

struturas de repetição
Estruturas de repetição, também conhecidas como loops (laços), são utilizadas para executar repetidamente uma 
instrução ou bloco de instrução enquanto determinada condição estiver sendo satisfeita.

As principais estruturas de repetição na maioria das linguagens são o for e o while, no C# além dessas duas 
também temos o do/while e o foreach.

Estrutura while
O while é uma estrutura de repetição que irá repetir o bloco de código enquanto uma determinada condição for 
verdadeira, geralmente o while é utilizando quando não sabemos quantas vezes o trecho de código em questão deve ser repetido.

A estrutura de repetição while possui a seguinte estrutura:

while (<condição>)
{
    // Trecho de código a ser repetido
}

*/

// Exemplo Prático:

int numero = -1;
while (numero != 10)
{
    Console.Write("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 10)
    {
        Console.WriteLine("Você errou, tente um número maior.");
    }
    else if (numero > 10)
    {
        Console.WriteLine("Você errou, tente um número menor.");
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou!");
    }
}




// Estrutura do/while
// A estrutura do/while é bem semelhante a estrutura while, a diferença é que na estrutura do/while a condição é testada apenas ao final do loop, ou seja, o código será executado ao menos uma vez, mesmo que a condição seja falsa desde o início.
// Veja um simples exemplo de uso do do/while

int contador = 15;
do
{
    Console.WriteLine("O contador vale: " + contador);
    contador++;
} while (contador <= 10);


/* 
Estrutura for
O for é uma estrutura de repetição que trabalha com uma variável de controle e que repete o seu bloco de código até que um determinada condição que envolve essa variável de controle seja falsa, geralmente utilizamos a estrutura for quando sabemos a quantidade de vezes que o laço precisará ser executado.

O for possui a seguinte estrutura:

Copiar
for (<variável de controle>, <condição de parada>, <incremento/decremento da váriavel de controle>)
{
    // Trecho de código a ser repetido
}


Veja o exemplo abaixo:

*/

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("A variável i agora vale " + i);
}


/*
Estrutura foreach
Além da estrutura for no C# também temos a estrutura foreach, basicamente a estrutura foreach serve para que possamos percorrer os elementos de uma estrutura de dados de forma mais simples e menos verbosa.

O foreach foi adicionado pois na maioria das vezes que precisamos percorrer os elementos de uma coleção não nos interessa o índice daquela coleção e sim o seu valor e antes da existência do foreach era necessário utilizar o for e percorrer os elementos de uma coleção utilizando os índices da mesma.


Veja como percorríamos um array antes da existência da estrutura foreach:
*/

string[] alunos = new string[4] { "Cleyson", "Anna", "Autobele", "Hayssa" };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(alunos[i]);
}



// Veja como ficaria o código acima refatorado para que usemos o foreach:


string[] alunos = new string[4] { "Cleyson", "Anna", "Autobele", "Hayssa" };
foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}



// > EXEMPLO PRÁTICO

string opcao;
bool sair = false;

while(!sair)
{
    Console.WriteLine("Digite a sua opçao: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": 
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar Cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            //Environment.Exit(0);
            sair = true;
            break;
        default:
            Console.WriteLine("Programa encerrado");
            sair = true;
            break;            
    }

}

Console.WriteLine("O programa foi encerrado.");

*
