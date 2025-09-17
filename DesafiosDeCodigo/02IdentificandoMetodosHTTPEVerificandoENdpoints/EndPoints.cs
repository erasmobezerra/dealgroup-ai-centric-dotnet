// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;
// using System.Threading.Tasks;

// namespace DesafiosDeCodigo._02IdentificandoMetodosHTTPEVerificandoENdpoints
// {
//     public class EndPoints
//     {
//         static void Main()
//         {
//             string requestedEndpoint = Console.ReadLine();
//             int numberOfAllowedPatterns = int.Parse(Console.ReadLine());
//             List<string> allowedPatterns = new List<string>();

//             // Lê os padrões autorizados e adiciona na lista
//             for (int i = 0; i < numberOfAllowedPatterns; i++)
//             {
//                 string pattern = Console.ReadLine();
//                 allowedPatterns.Add(pattern);
//             }

//             // TODO: Verifique se o formato do endpoint é válido
//             bool isValidEndpointFormat = IsValidEndpointFormat(requestedEndpoint);


//             // TODO: Verifique se o endpoint está autorizado
//             bool isAuthorized = IsAuthorized(requestedEndpoint, allowedPatterns);

//             if (isValidEndpointFormat && isAuthorized)
//             {
//                 Console.WriteLine("valid");
//             }
//             else
//             {
//                 Console.WriteLine("invalid");
//             }
//         }

//         // Função que valida o formato do endpoint com expressão regular
//         static bool IsValidEndpointFormat(string endpoint)
//         {
//             // A expressão regular garante que:
//             // - Comece com /api/
//             // - Siga com um ou mais segmentos alfanuméricos separados por /
//             // - Não contenha espaços, símbolos ou barras duplas
//             string pattern = @"^/api/([a-zA-Z0-9]+(/([a-zA-Z0-9]+))*)?$";

//             return Regex.IsMatch(endpoint, pattern);
//         }

//         // Função que verifica se o endpoint está dentro dos padrões autorizados
//         static bool IsAuthorized(string endpoint, List<string> allowedPatterns)
//         {
//             foreach (string pattern in allowedPatterns)
//             {
//                 // Se o padrão termina com "/*", ele permite qualquer subcaminho a partir desse ponto
//                 if (pattern.EndsWith("/*"))
//                 {
//                     // Remove o '*' e mantém o prefixo para comparação
//                     string basePattern = pattern.Substring(0, pattern.Length - 1);

//                     // Verifica se o endpoint começa com o padrão base
//                     if (endpoint.StartsWith(basePattern))
//                     {
//                         return true;
//                     }
//                 }
//                 else
//                 {
//                     // Se o padrão não tem *, a comparação é exata
//                     if (endpoint == pattern)
//                     {
//                         return true;
//                     }
//                 }
//             }

//             // Se nenhum padrão autorizou o acesso, retorna falso
//             return false;
//         }
//     }
// }