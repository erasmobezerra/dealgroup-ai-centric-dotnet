using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine($"Soma: {a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"Subtração: {a} - {b} = {a - b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"Multiplicação: {a} * {b} = {a * b}");
        }

        public void Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            Console.WriteLine($"Divisão: {a} / {b} = {a / b}");
        }

        public void Potencia(int baseNum, int expoente)
        {
            double resultado = Math.Pow(baseNum, expoente);
            Console.WriteLine($"Potência: {baseNum} ^ {expoente} = {resultado}");
        }

        public void RaizQuadrada(int numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
                return;
            }
            double resultado = Math.Sqrt(numero);
            Console.WriteLine($"Raiz quadrada: √{numero} = {resultado}");
        }
    }
}
