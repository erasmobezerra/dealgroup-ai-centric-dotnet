namespace _22AbstratasEInterfaces.Interfaces
{
    // Interfaces
    // -> Contratos que definem um conjunto de métodos e propriedades que uma classe deve implementar.
    // -> Métodos e propriedades em interfaces são implicitamente públicas e abstratas.
    // -> Uma classe pode implementar várias interfaces, permitindo a herança múltipla de comportamentos.
    // -> Métodos sem corpo (não implementados, somente assinatura) são considerados abstratos e devem ser implementados nas classes que herdam a interface.

    public interface ICalculadora
    {
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        int Multiplicar(int a, int b);

        // -> Métodos em Interfaces com corpo não precisam sem implementados nas classes
        // -> Não são comuns em interfaces, pois o objetivo principal é definir um contrato.
        int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return a / b;
        }

    }
}
