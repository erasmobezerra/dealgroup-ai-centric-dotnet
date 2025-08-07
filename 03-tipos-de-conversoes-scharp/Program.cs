// Cast - casting


//Casting, ou conversão de tipos, é uma operação que altera o tipo de um determinado valor. 
//Por exemplo, é possível converter uma string em uma data ou um tipo numérico em uma string

//O C# pode realizar conversões implícitas (automáticas e seguras) ou explícitas (utilizando funções pré-definidas). 


//   **CONVERSÕES EXPLÍCITAS

//--Conversão com Convert --

//conversão é realizada normalmenete
int a = Convert.ToInt32("5");

// ❌ System.FormatException
// A string "5fgfg" contém caracteres não numéricos. Convert espera uma string estritamente numérica.
// int b = Convert.ToInt32("5fgfg");


//Convert aceita nulo, "convertendo" em 0
int c = Convert.ToInt32(null);


// *** Conversão com Parse

//conversão é realizada normalmenete
int d = int.Parse("5");

// ❌ System.FormatException
// O método Parse tenta transformar a string "5dfgdfgd" em inteiro, mas falha porque contém letras.
// int e = int.Parse("5dfgdfgd");

/// ❌ System.ArgumentNullException
// O Parse não aceita valores nulos e lança exceção quando o argumento é null.
// int f = int.Parse(null);


//Conversão para String
int inteiro = 5;
string g = inteiro.ToString();


// ❌ System.NullReferenceException
// Embora `numero` seja do tipo `int?`, está nulo. Como o método `ToString()` é chamado em uma referência nula, gera erro.
// int? numero = null;
// string h = numero.ToString();
// Console.WriteLine(a);

Console.WriteLine("Conversões explícitas realizadas com sucesso!");


//**CONVERSÕES IMPLÍCITAS

//Na conversão implícita o compilador converte automaticamente uma variável de um tipo para outro 
//quando não há perda de informação na conversão. Por exemplo, uma variável do tipo inteiro pode ser convertida para 
//um tipo float, pois não há perda de informação já que float cabe dentro de um double, não o contrário.

//Exemplos de cast implícito (inteiro para decimal):

int numeroInteiro = 42;

// Cast implícito de int para double
double numeroDecimal = numeroInteiro;

Console.WriteLine($"Valor inteiro: {numeroInteiro}");
Console.WriteLine($"Valor decimal (cast implícito): {numeroDecimal}");



// **  TryParse - Convertendo de forma segura  ** 

string m = "25d";
// ❌ System.FormatException
// A string "25d" não pode ser convertida para inteiro pois contém o caractere 'd', que é inválido.

// int k = Convert.ToInt32(m);
// Console.WriteLine(k);
// Console.WriteLine("Conversão realizada com sucesso!");


// Para converter de forma segunra, utilizamos TryParse:
int o = 0;
if (int.TryParse(m, out o))
{     Console.WriteLine($"Conversão realizada com sucesso: {o}");
}
else
{
    Console.WriteLine("Erro ao converter a string para inteiro.");
}




