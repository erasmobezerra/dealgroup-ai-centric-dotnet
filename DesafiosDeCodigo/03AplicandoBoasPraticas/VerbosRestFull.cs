// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace DesafiosDeCodigo._03AplicandoBoasPraticas
// {
//     public class VerbosRestFull
//     {
//         static void Main()
//         {
//             // Lê a entrada do usuário no formato "ação recurso" (ex: "list user")
//             // string input = Console.ReadLine();
//             string input = "create category";

//             // Divide a entrada em duas partes: ação e recurso
//             string[] parts = input.Split(' ');
//             string action = parts[0].ToLower();
//             string resource = parts[1].ToLower();

//             // TODO: Preencha o dicionário que mapeia as ações para os verbos HTTP correspondentes
//             Dictionary<string, string> httpVerbs = new Dictionary<string, string>()
//             {
//                 { "list", "GET" },
//                 { "create", "POST" },
//                 { "update", "PUT" },
//                 { "delete", "DELETE" },
//             };

//             // Obtém o verbo HTTP correspondente à ação fornecida
//             string verb = httpVerbs[action];
//             string endpoint;

//             // TODO: Defina o endpoint conforme a ação
//             if (action == "list" || action == "create")
//             {
//                 endpoint = Pluralize(resource);
//             }
//             else
//             {
//                 endpoint = "/" + resource + "/{id}";
//             }

//             // Imprime o verbo HTTP e o endpoint no formato especificado
//             Console.WriteLine(verb);
//             Console.WriteLine(endpoint);
//         }

//         // Método estático que pluraliza a palavra conforme regras básicas do inglês
//         static string Pluralize(string word)
//         {
//             // Se a palavra termina em 'y' precedida de consoante, troca por 'ies'
//             if (word.EndsWith("y") && word.Length > 1 && "aeiou".IndexOf(word[word.Length - 2]) == -1)
//             {
//                 return word.Substring(0, word.Length - 1) + "ies";
//             }
//             // Se termina em s, x, z, ch ou sh, adiciona 'es'
//             else if (word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z")
//                      || word.EndsWith("ch") || word.EndsWith("sh"))
//             {
//                 return word + "es";
//             }
//             else
//             {
//                 // Para os demais casos, adiciona 's'
//                 return word + "s";
//             }
//         }
//     }
// }