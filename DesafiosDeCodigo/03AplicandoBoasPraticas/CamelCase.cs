
// using System.Text.RegularExpressions;

// namespace DesafiosDeCodigo._03AplicandoBoasPraticas
// {
//    public class CamelCase
// {
//    static void Main()
//     {
//         // Lê a linha com os nomes das variáveis separados por espaço
//         string input = Console.ReadLine();
//         string[] variableNames = input.Split(' ');

//         // Regex para validar camelCase:
//         // Começa com letra minúscula,
//         // seguido de letras ou números,
//         // palavras internas começam com letra maiúscula sem separadores,
//         // sem espaços ou caracteres especiais.
//         string camelCasePattern = @"^[a-z]+([A-Z][a-z0-9]+)*$";

//         bool allValid = true;


//         // Percorre todos os nomes para validar
//         foreach (string variable in variableNames)
//         {
//             // TODO: Verifique se o nome corresponde ao padrão camelCase
//             if (!Regex.IsMatch(variable, camelCasePattern))
//             {
//                 allValid = false;
//                 Console.WriteLine(variable);
//             }
//         }

//         // TODO: Caso todos estejam corretos, imprima "All valid"
//         if (allValid)
//         {
//             Console.WriteLine("All valid");
//         }
//     }
// }   
// }