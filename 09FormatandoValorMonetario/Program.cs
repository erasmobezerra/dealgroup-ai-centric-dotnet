using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1234567.89m;

Console.WriteLine(valorMonetario.ToString("C")); // Formata como moeda
Console.WriteLine(valorMonetario.ToString("N")); // Formata como número

double porcentual = 0.1234;
Console.WriteLine(porcentual.ToString("P")); // Formata como percentual

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));