using _13Tuplas.Models;

// *******************  TUPLAS *********************************
// Tuplas 

// Três maneiras de se declarar uma Tupla: 
// 1ª -> É a mais indicada

// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Leonardo", "Buta", 1.80M);

//ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Leonardo", "Buta", 1.80M);
//var outroExemploTuplaCreate = Tuple.Create(1, "Leonardo", "Buta", 1.80M);

// Console.WriteLine($"Id: {tupla.Id}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");

// *****************  TUPLAS EM MÉTODOS ***************************

LeituraArquivo arquivo = new LeituraArquivo();

// * DESCARTE -> SE NÃO PRECISA UTILIZAR UMA PROPRIEDADE, ESCREVER "_" NO LUGAR DO NOME DA PROPRIEDADE
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    // Console.WriteLine("Quantidade linhas do arquivo: " + quantidadeLinhas);
    Console.WriteLine("============================");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
    Console.WriteLine("============================");
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo.");
}

