using Newtonsoft.Json;

// JsonProperty -> Mapeia a propriedade da classe para o nome especificado no JSON
// decimal? -> Tipo que pode receber um valor nulo

namespace _15NugetSerializar.Models
{
    public class Venda
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome_produto")]
        public string Produto { get; set; }

        [JsonProperty("preco")]
        public decimal Preco { get; set; }

        [JsonProperty("data_venda")]
        public DateTime DataVenda { get; set; }

        [JsonProperty("desconto")]
        public decimal? Desconto { get; set; }

        public Venda(int id, string produto, decimal preco, DateTime dataVenda, decimal? desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
            Desconto = desconto;
        }
    }
}