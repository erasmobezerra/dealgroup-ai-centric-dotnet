// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace DesafiosDeCodigo._02IdentificandoMetodosHTTPEVerificandoENdpoints
// {
//     public class MetodosHttp
//     {
//         static void Main()
//         {
//             // Lê a string contendo os métodos HTTP separados por vírgula
//             string input = Console.ReadLine();

//             // TODO: Preencha Dicionário para mapear métodos válidos e suas descrições
//             Dictionary<string, string> methodDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
//             {
//                 {"GET", "busca ou recupera dados de um recurso"},
//                 {"POST",    "envia dados para processamento"},
//                 {"PUT", "atualiza todos os dados de um recurso"},
//                 {"DELETE",  "remove um recurso específico"}
//             };

//             // Divide a entrada em métodos, remove espaços e transforma em maiúsculas
//             string[] methods = input.Split(',');

//             // Dicionário para contar as ocorrências de cada método (case-insensitive)
//             Dictionary<string, int> methodCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

//             foreach (var rawMethod in methods)
//             {
//                 string method = rawMethod.Trim();

//                 if (methodCounts.ContainsKey(method))
//                     methodCounts[method]++;
//                 else
//                     methodCounts[method] = 1;
//             }

//             // Encontra o método com maior frequência (se houver empate, pega o primeiro)
//             int maxCount = methodCounts.Values.Max();
//             string mostFrequentMethod = methodCounts.First(kv => kv.Value == maxCount).Key;
//             int count = methodCounts[mostFrequentMethod];

//             // TODO: Verifique se o método está entre os válidos para definir a descrição
//             if (methodDescriptions.ContainsKey(mostFrequentMethod))
//             {
//                 string descriptionOfmostFrequentMethod = methodDescriptions[mostFrequentMethod];
//                 Console.WriteLine($"{mostFrequentMethod} - {descriptionOfmostFrequentMethod} - {count}");
//             }
//             else
//             {
//                 // Caso método inválido
//                 Console.WriteLine($"{mostFrequentMethod} - metodo nao reconhecido - {count}");
//             }
//         }
//     }
// }