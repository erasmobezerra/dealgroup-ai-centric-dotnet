
/* 
*Nullable Value Types no C#

Em .NET, um nullable value type (ou tipo de valor anulável) é uma forma de representar um tipo de valor 
que pode receber um valor normal ou null. Isso é particularmente útil para lidar com dados de bancos de 
dados onde colunas numéricas ou de data podem ter valores ausentes.

*Conceito
Por padrão, os tipos de valor (como int, double, bool, DateTime) não podem ser null. Para permitir que 
eles recebam null, você usa a sintaxe ? após o nome do tipo.

*Declaração e Atribuição
Como um tipo de valor é implicitamente conversível para o tipo anulável correspondente, você pode atribuir valores diretamente: */
double? pi = 3.14;
char? letra = 'a';
int? contador = 10;
bool? flag = null;
int?[] arr = new int?[10];
string? nullString = null;
string? emptyString = "";
string? whiteString = " ";


// *Entradas nulas de string 
//1. Verificar se é nula ou vazia use string.IsNullOrEmpty():
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("A entrada está vazia ou nula.");
}

if (string.IsNullOrEmpty(emptyString))
{
    Console.WriteLine("A entrada está vazia ou nula.");
}

// 2. Verificar se é nula, vazia ou só espaços use string.IsNullOrWhiteSpace():
if (string.IsNullOrWhiteSpace(whiteString))
{
    Console.WriteLine("A entrada está vazia, nula ou contém apenas espaços.");
}

// 3. Operador de coalescência nula (??)
string name = nullString ?? "Visitante";
Console.WriteLine($"Bem-vindo, {name}!");

// 4. Operador condicional nulo (?.) Evita exceções ao acessar métodos ou propriedades:
int length = nullString?.Length ?? 0;
Console.WriteLine($"Comprimento da string: {length}");

//  5. Throw se for nula (validação defensiva) - Para garantir que uma string não seja nula:
if (nullString is null)
    throw new ArgumentNullException("A string não pode ser nula.");



// *Verificação de Valor
// *Exemplo 1: Utilize "HasValue" ou compare diretamente com null:
int? x = 42;
if (x.HasValue) {
    Console.WriteLine($"x tem valor: {x.Value}");
} else {
    Console.WriteLine("x é null");
}

// *Exemplo 2: Você também pode usar o pattern matching com "is":
int? y = null;
if (y is int valorDeY)
{
    Console.WriteLine($"y tem valor: {valorDeY}");
}
else
{
    Console.WriteLine("y não tem valor");
}


// *Exemplo 3: Usando GetValueOrDefault()
// Este exemplo mostra como obter um valor padrão (0 neste caso) se a variável for null.
void CalcularSalario(double? bonus)
{
    double salarioBase = 2000.0;
    // Se 'bonus' for null, GetValueOrDefault() retorna 0.0
    double bonusCalculado = bonus.GetValueOrDefault();
    
    double salarioTotal = salarioBase + bonusCalculado;
    Console.WriteLine($"Salário total: {salarioTotal:C}");
}

// Uso do método
CalcularSalario(500.0); // Salário total: R$ 2.500,00
CalcularSalario(null);  // Salário total: R$ 2.000,00


// *Exemplo 4: Usando o operador de coalescência nula (??)
// O operador ?? é uma forma mais curta e elegante de fazer a mesma coisa que GetValueOrDefault() em muitos casos, 
// permitindo que você atribua um valor padrão caso a variável seja null.
void ProcessarDataEntrega(DateTime? dataEntrega)
{
    // Se 'dataEntrega' for null, a 'dataLimite' será a data atual + 7 dias
    DateTime dataLimite = dataEntrega ?? DateTime.Now.AddDays(7);
    
    Console.WriteLine($"A data limite para entrega é: {dataLimite.ToShortDateString()}");
}

// Uso do método
ProcessarDataEntrega(new DateTime(2025, 12, 25)); // A data limite para entrega é: 25/12/2025
ProcessarDataEntrega(null);                        // A data limite para entrega é: [Data atual + 7 dias]

// *Exemplo 5: Suspensão (lifted) de Operadores Aritméticos e Relacionais
// Operadores aritméticos e relacionais são “suspensos” (lifted). Se algum operando for null, o resultado é null:
int? a = 5;
int? b = null;
int? soma = a + b;               // soma == null
bool? comparacao = a > b;        // comparacao == null


