using System;
using CalculadoraAritmetica.Models;

Calculadora calc = new Calculadora();

Console.WriteLine("Classe Calculadora");
calc.Somar(10, 15);
calc.Subtrair(10, 15);
calc.Multiplicar(10, 15);
calc.Dividir(10, 3);
calc.Potencia(5, 10);
calc.RaizQuadrada(15);