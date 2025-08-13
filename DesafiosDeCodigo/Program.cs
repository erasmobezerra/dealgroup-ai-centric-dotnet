using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // * Implementando um Sistema de Mensagens para Reservas

        // Lê a entrada como uma string no formato: Nome, Número do Quarto, Número de Diárias
        string input = Console.ReadLine();
        // * Use para testar localmente no VSCode:
        // string input = "Aline, 101, 3"; // 1º Teste
        // string input = "Marina, 102, 1"; // 2º Teste
        // string input = "Carlos, 203, 2"; // 3º Teste

        // Divide a string pelos separadores de vírgula
        string[] parts = input.Split(',');

        // Extrai e trata os dados de entrada
        string guestName = parts[0].Trim();            // Nome do hóspede
        int roomNumber = int.Parse(parts[1].Trim());   // Número do quarto
        int days = int.Parse(parts[2].Trim());         // Quantidade de diárias

        // TODO: Calcule o valor total da estadia (R$150 por diária)
        int rooRate = 150;
        int valor_total = days * rooRate;

        // TODO: Exiba a mensagem formatada conforme solicitado  
        Console.WriteLine($"{guestName} vai se hospedar no quarto {roomNumber} por R${valor_total}");
        // Saída Esperada 1ºTeste: "Aline vai se hospedar no quarto 101 por R$450"
        // Saída Esperada 1ºTeste: "Marina vai se hospedar no quarto 102 por R$150"
        // Saída Esperada 1ºTeste: "Carlos vai se hospedar no quarto 203 por R$300"


        Console.WriteLine("**********************************************************");
        // *Validando Nomes em Lista de Usuários
        try
        {
            // Lê uma linha de entrada do usuário
            string inputLine = Console.ReadLine();
            // string inputLine = $"\"João\", \"Maria\", \"\""; // 1º Teste
            // string inputLine = $"\"Carlos\", \"Ana\", null"; // 2º Teste
            // string inputLine = $"\"Mairo\", \"\""; // 3º Teste

            // Separa os nomes por vírgula, remove espaços e aspas extras
            var names = inputLine.Split(',')
                                 .Select(n => n.Trim().Trim('"'))
                                 .ToList();

            // Lista para armazenar nomes válidos
            var validNames = new List<string>();
            // Lista para armazenar mensagens de erro
            var errors = new List<string>();

            // Itera sobre cada nome processado
            foreach (var name in names)
            {
                try
                {
                    // TODO: Verifique se o nome é a string "null"
                    if (name == "null")
                        throw new ArgumentNullException();

                    // TODO: Verifique se o nome está vazio ou contém apenas espaços
                    if (string.IsNullOrWhiteSpace(name))
                        throw new ArgumentException();

                    // TODO: Se o nome passou pelas validações, adicione aos nomes válidos
                    validNames.Add(name);
                }
                catch (ArgumentNullException)
                {
                    errors.Add("Erro: nome nulo");
                }
                catch (ArgumentException)
                {
                    errors.Add("Erro: nome invalido");
                }
            }

            // Exibe a saída formatada
            // Se houver erros, mostra os nomes válidos e os erros
            if (errors.Any())
                Console.WriteLine($"{string.Join(", ", validNames)} / {string.Join(", ", errors)}");
            else
                // Caso contrário, mostra apenas os nomes válidos
                Console.WriteLine(string.Join(", ", validNames));
        }
        catch (Exception ex)
        {
            // Captura e exibe qualquer erro inesperado
            Console.WriteLine($"Erro inesperado: {ex.Message}");
        }
    }
}