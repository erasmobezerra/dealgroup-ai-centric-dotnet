namespace _20AbstracaoEEncapsulamento.Models
{
    // ABSTRAÇÃO -> Ocultar detalhes desnecessários e mostrar apenas informações essenciais.
    // Esta classe é um exemplo de aplicação da Abstração
    // Uma pessoa no mundo real tem muitas características, mas aqui estamos focando apenas no nome e na idade.
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}