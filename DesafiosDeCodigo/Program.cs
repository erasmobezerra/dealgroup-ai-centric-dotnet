using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {

        string requestedEndpoint = Console.ReadLine();
        int numberOfAllowedPatterns = int.Parse(Console.ReadLine());
        List<string> allowedPatterns = new List<string>();

        // Lê os padrões autorizados e adiciona na lista
        for (int i = 0; i < numberOfAllowedPatterns; i++)
        {
            string pattern = Console.ReadLine();
            allowedPatterns.Add(pattern);
        }

        // TODO: Verifique se o formato do endpoint é válido
        // TODO: Verifique se o endpoint está autorizado
        if (IsValidEndpointFormat(requestedEndpoint) && IsAuthorized(requestedEndpoint, allowedPatterns))
        {
            Console.WriteLine("valid");
        }
        else
        {
            Console.WriteLine("invalid");
        }

    }


    // Função que valida o formato do endpoint com expressão regular
    static bool IsValidEndpointFormat(string endpoint)
    {
        // A expressão regular garante que:
        // - Comece com /api/
        // - Siga com um ou mais segmentos alfanuméricos separados por /
        // - Não contenha espaços, símbolos ou barras duplas
        string pattern = @"^/api/([a-zA-Z0-9]+(/([a-zA-Z0-9]+))*)?$";

        return Regex.IsMatch(endpoint, pattern);
    }

    // Função que verifica se o endpoint está dentro dos padrões autorizados
    static bool IsAuthorized(string endpoint, List<string> allowedPatterns)
    {
        foreach (string pattern in allowedPatterns)
        {
            // Se o padrão termina com "/*", ele permite qualquer subcaminho a partir desse ponto
            if (pattern.EndsWith("/*"))
            {
                // Remove o '*' e mantém o prefixo para comparação
                string basePattern = pattern.Substring(0, pattern.Length - 1);

                // Verifica se o endpoint começa com o padrão base
                if (endpoint.StartsWith(basePattern))
                {
                    return true;
                }
            }
            else
            {
                // Se o padrão não tem *, a comparação é exata
                if (endpoint == pattern)
                {
                    return true;
                }
            }
        }

        // Se nenhum padrão autorizou o acesso, retorna falso
        return false;
    }
}



    //static void Main()
    //{

        // // *** IDENTIFICANDO O MÉTODO HTTP MAIS FREQUENTE ***

        // // Lê a string contendo os métodos HTTP separados por vírgula
        // //string input = Console.ReadLine();
        // string input = "PUT, POST, PUT, DELETE, PUT";

        // // TODO: Preencha Dicionário para mapear métodos válidos e suas descrições
        // Dictionary<string, string> methodDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        // {
        //     {"GET", "busca ou recupera dados de um recurso"},
        //     {"POST",    "envia dados para processamento"},
        //     {"PUT", "atualiza todos os dados de um recurso"},
        //     {"DELETE",  "remove um recurso específico"}
        // };

        // // Divide a entrada em métodos, remove espaços e transforma em maiúsculas
        // string[] methods = input.Split(',');

        // // Dicionário para contar as ocorrências de cada método (case-insensitive)
        // Dictionary<string, int> methodCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        // foreach (var rawMethod in methods)
        // {
        //     string method = rawMethod.Trim();

        //     if (methodCounts.ContainsKey(method))
        //         methodCounts[method]++;
        //     else
        //         methodCounts[method] = 1;
        // }

        // // Encontra o método com maior frequência (se houver empate, pega o primeiro)
        // int maxCount = methodCounts.Values.Max();
        // string mostFrequentMethod = methodCounts.First(kv => kv.Value == maxCount).Key;
        // int count = methodCounts[mostFrequentMethod];

        // // TODO: Verifique se o método está entre os válidos para definir a descrição
        // if (methodDescriptions.ContainsKey(mostFrequentMethod))
        // {
        //     string descriptionOfmostFrequentMethod = methodDescriptions[mostFrequentMethod];            
        //     Console.WriteLine($"{mostFrequentMethod} - {descriptionOfmostFrequentMethod} - {count}");
        // }
        // else
        // {
        //     // Caso método inválido
        //     Console.WriteLine($"{mostFrequentMethod} - metodo nao reconhecido - {count}");
        // }


        // Console.WriteLine("**********************************************************");
        // // * Implementando um Sistema de Mensagens para Reservas

        // // Lê a entrada como uma string no formato: Nome, Número do Quarto, Número de Diárias
        // string input = Console.ReadLine();
        // // * Use para testar localmente no VSCode:
        // // string input = "Aline, 101, 3"; // 1º Teste
        // // string input = "Marina, 102, 1"; // 2º Teste
        // // string input = "Carlos, 203, 2"; // 3º Teste

        // // Divide a string pelos separadores de vírgula
        // string[] parts = input.Split(',');

        // // Extrai e trata os dados de entrada
        // string guestName = parts[0].Trim();            // Nome do hóspede
        // int roomNumber = int.Parse(parts[1].Trim());   // Número do quarto
        // int days = int.Parse(parts[2].Trim());         // Quantidade de diárias

        // // TODO: Calcule o valor total da estadia (R$150 por diária)
        // int rooRate = 150;
        // int valor_total = days * rooRate;

        // // TODO: Exiba a mensagem formatada conforme solicitado  
        // Console.WriteLine($"{guestName} vai se hospedar no quarto {roomNumber} por R${valor_total}");
        // // Saída Esperada 1ºTeste: "Aline vai se hospedar no quarto 101 por R$450"
        // // Saída Esperada 1ºTeste: "Marina vai se hospedar no quarto 102 por R$150"
        // // Saída Esperada 1ºTeste: "Carlos vai se hospedar no quarto 203 por R$300"


        // Console.WriteLine("**********************************************************");
        // // *Validando Nomes em Lista de Usuários
        // try
        // {
        //     // Lê uma linha de entrada do usuário
        //     string inputLine = Console.ReadLine();
        //     // string inputLine = $"\"João\", \"Maria\", \"\""; // 1º Teste
        //     // string inputLine = $"\"Carlos\", \"Ana\", null"; // 2º Teste
        //     // string inputLine = $"\"Mairo\", \"\""; // 3º Teste

        //     // Separa os nomes por vírgula, remove espaços e aspas extras
        //     var names = inputLine.Split(',')
        //                          .Select(n => n.Trim().Trim('"'))
        //                          .ToList();

        //     // Lista para armazenar nomes válidos
        //     var validNames = new List<string>();
        //     // Lista para armazenar mensagens de erro
        //     var errors = new List<string>();

        //     // Itera sobre cada nome processado
        //     foreach (var name in names)
        //     {
        //         try
        //         {
        //             // TODO: Verifique se o nome é a string "null"
        //             if (name == "null")
        //                 throw new ArgumentNullException();

        //             // TODO: Verifique se o nome está vazio ou contém apenas espaços
        //             if (string.IsNullOrWhiteSpace(name))
        //                 throw new ArgumentException();

        //             // TODO: Se o nome passou pelas validações, adicione aos nomes válidos
        //             validNames.Add(name);
        //         }
        //         catch (ArgumentNullException)
        //         {
        //             errors.Add("Erro: nome nulo");
        //         }
        //         catch (ArgumentException)
        //         {
        //             errors.Add("Erro: nome invalido");
        //         }
        //     }

        //     // Exibe a saída formatada
        //     // Se houver erros, mostra os nomes válidos e os erros
        //     if (errors.Any())
        //         Console.WriteLine($"{string.Join(", ", validNames)} / {string.Join(", ", errors)}");
        //     else
        //         // Caso contrário, mostra apenas os nomes válidos
        //         Console.WriteLine(string.Join(", ", validNames));
        // }
        // catch (Exception ex)
        // {
        //     // Captura e exibe qualquer erro inesperado
        //     Console.WriteLine($"Erro inesperado: {ex.Message}");
        // }
    //}