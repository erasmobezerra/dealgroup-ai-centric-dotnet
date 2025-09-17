// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace DesafiosDeCodigo._01ManipulandoValoresETrabalhandoComExcecoes
// {
//     public class Usuarios
//     {
//         static void Main()
//         {
//             try
//             {
//                 // Lê uma linha de entrada do usuário
//                 string inputLine = Console.ReadLine();
//                 // string inputLine = $"\"João\", \"Maria\", \"\"";
//                 // string inputLine = $"\"Carlos\", \"Ana\", null";
//                 // string inputLine = $"\"Mairo\", \"\"";

//                 // Separa os nomes por vírgula, remove espaços e aspas extras
//                 var names = inputLine.Split(',')
//                                      .Select(n => n.Trim().Trim('"'))
//                                      .ToList();

//                 // Lista para armazenar nomes válidos
//                 var validNames = new List<string>();
//                 // Lista para armazenar mensagens de erro
//                 var errors = new List<string>();

//                 // Itera sobre cada nome processado
//                 foreach (var name in names)
//                 {
//                     try
//                     {
//                         // TODO: Verifique se o nome é a string "null"
//                         if (name == "null")
//                             throw new ArgumentNullException();

//                         // TODO: Verifique se o nome está vazio ou contém apenas espaços
//                         if (string.IsNullOrWhiteSpace(name))
//                             throw new ArgumentException();

//                         // TODO: Se o nome passou pelas validações, adicione aos nomes válidos
//                         validNames.Add(name);
//                     }
//                     catch (ArgumentNullException)
//                     {
//                         errors.Add("Erro: nome nulo");
//                     }
//                     catch (ArgumentException)
//                     {
//                         errors.Add("Erro: nome invalido");
//                     }
//                 }

//                 // Exibe a saída formatada
//                 // Se houver erros, mostra os nomes válidos e os erros
//                 if (errors.Any())
//                     Console.WriteLine($"{string.Join(", ", validNames)} / {string.Join(", ", errors)}");
//                 else
//                     // Caso contrário, mostra apenas os nomes válidos
//                     Console.WriteLine(string.Join(", ", validNames));
//             }
//             catch (Exception ex)
//             {
//                 // Captura e exibe qualquer erro inesperado
//                 Console.WriteLine($"Erro inesperado: {ex.Message}");
//             }
//         }
//     }
// }