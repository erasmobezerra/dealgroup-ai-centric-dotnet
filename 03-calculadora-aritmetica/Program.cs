// Programa principal da Calculadora Aritmética
// Desenvolvido para demonstrar operações matemáticas básicas com tratamento de erros e menu interativo

using System;
using CalculadoraAritmetica.Models;

// Instancia a calculadora
Calculadora calc = new Calculadora();

/// <summary>
/// Exibe o menu interativo para o usuário escolher operações matemáticas.
/// Realiza validação de entrada e tratamento de exceções.
/// </summary>
void ExibirMenu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("==== CALCULADORA ARITMÉTICA ====");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Raiz Quadrada");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
        string? opcao = Console.ReadLine();

        try
        {
            switch (opcao)
            {
                case "1":
                    int a1 = LerInteiro("Digite o primeiro número: ");
                    int b1 = LerInteiro("Digite o segundo número: ");
                    calc.Somar(a1, b1);
                    break;
                case "2":
                    int a2 = LerInteiro("Digite o primeiro número: ");
                    int b2 = LerInteiro("Digite o segundo número: ");
                    calc.Subtrair(a2, b2);
                    break;
                case "3":
                    int a3 = LerInteiro("Digite o primeiro número: ");
                    int b3 = LerInteiro("Digite o segundo número: ");
                    calc.Multiplicar(a3, b3);
                    break;
                case "4":
                    int a4 = LerInteiro("Digite o numerador: ");
                    int b4 = LerInteiro("Digite o denominador: ");
                    calc.Dividir(a4, b4);
                    break;
                case "5":
                    int baseNum = LerInteiro("Digite a base: ");
                    int expoente = LerInteiro("Digite o expoente: ");
                    calc.Potencia(baseNum, expoente);
                    break;
                case "6":
                    int num = LerInteiro("Digite o número: ");
                    calc.RaizQuadrada(num);
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            Console.ResetColor();
        }
        Console.WriteLine("Pressione qualquer tecla para retornar ao menu...");
        Console.ReadKey();
    }
}


/// <summary>
/// Lê um número inteiro do usuário, validando a entrada.
/// </summary>
/// <param name="mensagem">Mensagem exibida para o usuário</param>
/// <returns>Valor inteiro digitado</returns>
int LerInteiro(string mensagem)
{
    int valor;
    while (true)
    {
        Console.Write(mensagem);
        string? entrada = Console.ReadLine();
        if (int.TryParse(entrada, out valor))
        {
            return valor;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Valor inválido! Digite um número inteiro.");
        Console.ResetColor();
    }
}


// Inicia o menu principal da calculadora
ExibirMenu();