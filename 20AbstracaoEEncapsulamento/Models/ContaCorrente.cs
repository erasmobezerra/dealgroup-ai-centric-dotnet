namespace _20AbstracaoEEncapsulamento.Models
{
    // ENCAPSULAMENTO -> Controle de acesso a dados: public, private, protected, internal. 
    // Esta classe é um exemplo de aplicação do Encapsulamento
    // Ela encapsula os dados da conta corrente, permitindo acesso controlado ao saldo
    // Os métodos públicos permitem interagir com o saldo (private) de forma segura
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal saldo;

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor desejado é maior que o saldo disponível");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo disponível é {saldo}");
        }
    }
}