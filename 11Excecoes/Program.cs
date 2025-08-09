using _11Excecoes.Models;
// Exceções e Tratamento de Erros

// Exceção é um evento que ocorre durante a execução de um programa, interrompendo seu fluxo normal.
// Exceções podem ser causadas por erros de programação, como divisão por zero, ou por condições inesperadas, como arquivos não encontrados.

// Exceções Genéricas -> System.Exception
// Exceções Específicas -> System.IO.FileNotFoundException, System.IO.DirectoryNotFoundException, etc....
/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Acesso negado ao arquivo: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Operação de leitura finalizada.");
}

Console.WriteLine("Chegou até aqui!");
*/


ExemploExcecao exemplo = new ExemploExcecao();
//exemplo.Metodo1();
try
{
    exemplo.Metodo1();
}
catch (Exception ex)
{
    // Tratando a exceção lançada no Metodo4() e propagada até aqui
    Console.WriteLine($"Tratando a exceção: {ex.Message}");
}

Console.WriteLine("Chegou até aqui!");