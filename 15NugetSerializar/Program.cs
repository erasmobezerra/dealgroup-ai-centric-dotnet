using _15NugetSerializar.Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();
DateTime dataAtual = DateTime.Now;

Venda v1 = new Venda(1, "Meterial de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

// JsonConvert -> biblioteca do Newtonsoft para conversão entre objetos .NET e JSON
// Serialização -> converte a lista de vendas em uma string JSON
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas-serialize.json", serializado);

Console.WriteLine("Serializando Objeto em JSON: ");
Console.WriteLine(serializado);
Console.WriteLine("-------------------------------------------------------");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas-deserialize.json");

// Deserialização -> converte a string JSON de volta para uma lista de objetos Venda
List<Venda> listaVendas2 = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

Console.WriteLine("Deserializando JSON em Objeto: ");
foreach (Venda venda in listaVendas2)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                        $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}