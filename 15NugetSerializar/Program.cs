using _15NugetSerializar.Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();
DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Meterial de Escritório", 25.00M, dataAtual, 0.15M);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual, 0.20M);
Venda v3 = new Venda(3, "Cadeira Ergonômica", 350.00M, dataAtual, 0.25M);
Venda v4 = new Venda(4, "Monitor LED 24", 799.90M, dataAtual, null);

listaVendas.Add(v1);
listaVendas.Add(v2);
listaVendas.Add(v3);
listaVendas.Add(v4);

// *JsonConvert -> biblioteca do Newtonsoft para conversão entre objetos .NET e JSON
// *Serialização -> converte a lista de vendas em uma string JSON
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas-serialize.json", serializado);

Console.WriteLine("Serializando Objeto em JSON: ");
Console.WriteLine(serializado);
Console.WriteLine("-------------------------------------------------------");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas-deserialize.json");

// *Deserialização -> converte a string JSON de volta para uma lista de objetos Venda
List<Venda> listaVendas2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

Console.WriteLine("Deserializando JSON em Objeto: ");
foreach (Venda venda in listaVendas2)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                        $"Preço: R${venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
                        $"Desconto: {venda.Desconto?.ToString("P0") ?? "Sem desconto"}");
}

// * Tipos Anônimos em Coleção
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Exibindo lista de vendas com tipos anônimos: ");
var listaAnonima = listaVendas2.Select(v => new { v.Id, v.Produto });
foreach (var item in listaAnonima)
{
    Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}");
}