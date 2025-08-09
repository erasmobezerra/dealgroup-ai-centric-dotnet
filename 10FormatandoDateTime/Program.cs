using System.Globalization;

DateTime data = DateTime.Now;

// Exibe a data no formato "dd/MM/yyyy HH:mm:ss"
Console.WriteLine("DateTime.Now:");
Console.WriteLine(data);

// Exibe a data sem os segundos
Console.WriteLine("ToString:");
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// Exibe a data no formato "dd/MM/yyyy"
Console.WriteLine(data.ToString("dd/MM/yyyy"));

// Método ToLongDateString() exibe a data por extenso
Console.WriteLine(data.ToLongDateString());

// Método ToShortDateString() exibe a data no formato "dd/MM/yyyy"
Console.WriteLine(data.ToShortDateString());

// Convertendo a data com Parse 
// -> Pode gerar exceção se o formato estiver incorreto
Console.WriteLine("Convertendo com Parse() e CultureInfo:");
DateTime dataParse = DateTime.Parse("08-08-2025 15:30:45", new CultureInfo("pt-BR"));
Console.WriteLine(dataParse);


// Convertendo a data com TryParse
// Forma segura de converter strings em data sem lançar exceções em caso de erro
// - Ideal para validar entradas de usuário
string entrada = "09/08/2025";
DateTime dataConvertida;
if (DateTime.TryParse(entrada, out dataConvertida))
    Console.WriteLine($"Data válida: {dataConvertida.ToShortDateString()}");
else
    Console.WriteLine("Data inválida.");

// Exemplo com Falha
entrada = "data inválida";
if (!DateTime.TryParse(entrada, out dataConvertida))
{
    Console.WriteLine("Conversão falhou. Entrada não é uma data válida.");
}

// Considerando a Cultura (Formato Regional)
entrada = "2025-08-09";
CultureInfo cultura = new CultureInfo("en-US");

if (DateTime.TryParse(entrada, cultura, DateTimeStyles.None, out data))
{
    Console.WriteLine($"Data convertida: {data}");
}



// Convertendo a data com TryParseExact()
// -> Permite especificar o formato exato da string de data
// -> Útil quando o formato da data é conhecido e fixo
Console.WriteLine("Convertendo com TryParseExact() e CultureInfo:");
entrada = "2025-08-08 15:30:45";
string formato = "yyyy-MM-dd HH:mm:ss";
bool sucesso = DateTime.TryParseExact(
                        entrada,
                        formato,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime dataTryParse);

if (sucesso)
    Console.WriteLine("Conversão bem-sucedida!");
    
else
    Console.WriteLine("Falha na conversão.");

Console.WriteLine(dataTryParse);


