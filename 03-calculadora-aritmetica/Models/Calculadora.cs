namespace CalculadoraAritmetica.Models
{
    /// <summary>
    /// Classe responsável por realizar operações aritméticas básicas.
    /// </summary>
    public class Calculadora
    {
        /// <summary>
        /// Realiza a soma de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        public void Somar(int a, int b)
        {
            try
            {
                Console.WriteLine($"Soma: {a} + {b} = {a + b}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao somar: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Realiza a subtração de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        public void Subtrair(int a, int b)
        {
            try
            {
                Console.WriteLine($"Subtração: {a} - {b} = {a - b}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao subtrair: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Realiza a multiplicação de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        public void Multiplicar(int a, int b)
        {
            try
            {
                Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao multiplicar: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Realiza a divisão de dois números inteiros e exibe o resultado no console.
        /// </summary>
        /// <param name="a">Numerador</param>
        /// <param name="b">Denominador</param>
        /// <exception cref="DivideByZeroException">Lançada quando o denominador é zero.</exception>
        public void Dividir(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Divisão por zero não é permitida.");
                }
                Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao dividir: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Calcula a potência de um número elevado a um expoente e exibe o resultado no console.
        /// </summary>
        /// <param name="baseNum">Base da potência</param>
        /// <param name="expoente">Expoente</param>
        public void Potencia(int baseNum, int expoente)
        {
            try
            {
                double resultado = Math.Pow(baseNum, expoente);
                Console.WriteLine($"Potência: {baseNum} ^ {expoente} = {resultado}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao calcular potência: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Calcula a raiz quadrada de um número inteiro e exibe o resultado no console.
        /// </summary>
        /// <param name="numero">Número para calcular a raiz quadrada</param>
        /// <exception cref="ArgumentException">Lançada quando o número é negativo.</exception>
        public void RaizQuadrada(int numero)
        {
            try
            {
                if (numero < 0)
                {
                    throw new ArgumentException("Raiz quadrada de número negativo não é permitida.");
                }
                double resultado = Math.Sqrt(numero);
                Console.WriteLine($"Raiz quadrada: √{numero} = {resultado}");
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao calcular raiz quadrada: {ex.Message}", ex);
            }
        }
    }
}
