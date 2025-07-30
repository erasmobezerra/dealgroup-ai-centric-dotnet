// Operadores aritméticos
int a = 10, b = 3;
Console.WriteLine("Aritméticos:");
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"a % b = {a % b}");

// Operadores de comparação
Console.WriteLine("\nComparação:");
Console.WriteLine($"a == b: {a == b}");
Console.WriteLine($"a != b: {a != b}");
Console.WriteLine($"a > b: {a > b}");
Console.WriteLine($"a < b: {a < b}");

// Operadores lógicos
bool cond1 = true;
bool cond2 = false;
Console.WriteLine("\nLógicos:");
Console.WriteLine($"cond1 && cond2: {cond1 && cond2}");
Console.WriteLine($"cond1 || cond2: {cond1 || cond2}");
Console.WriteLine($"!cond1: {!cond1}");

// Operadores de atribuição
Console.WriteLine("\nAtribuição:");
int x = 5;
x += 3; // x = x + 3
Console.WriteLine($"x após x += 3: {x}");
x *= 2; // x = x * 2
Console.WriteLine($"x após x *= 2: {x}");

// Operadores unários
Console.WriteLine("\nUnários:");
int y = 7;
Console.WriteLine($"y = {y}");
Console.WriteLine($"y++ = {y++} (pós-incremento)");
Console.WriteLine($"++y = {++y} (pré-incremento)");
Console.WriteLine($"y-- = {y--} (pós-decremento)");
Console.WriteLine($"--y = {--y} (pré-decremento)");
