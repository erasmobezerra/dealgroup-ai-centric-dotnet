// Coleções 
// Coleções são estruturas de dados que permitem armazenar e manipular grupos de objetos.

// https://learn.microsoft.com/pt-br/dotnet/standard/collections/
// https://learn.microsoft.com/pt-br/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0

namespace _12ExcecoesEColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queue (Fila)
            // FIFO -> First In, First Out
            // A fila é uma coleção que segue a ordem de inserção, onde o primeiro elemento adicionado é o primeiro a ser removido.
            Queue<int> fila = new Queue<int>();

            // Adicionando elementos à fila
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);

            // Exibindo os elementos da fila
            Console.WriteLine("Elementos na fila:");
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            // Removendo o primeiro elemento da fila
            int primeiro = fila.Dequeue();
            Console.WriteLine($"Removido da fila: {primeiro}");

            // Exibindo os elementos restantes na fila
            Console.WriteLine("Elementos restantes na fila:");
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }

            // Stack (Pilha)
            // LIFO -> Last In, First Out
            // A pilha é uma coleção onde o último elemento adicionado é o primeiro a ser removido.
            Stack<int> pilha = new Stack<int>();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);

            // Exibindo os elementos da pilha
            Console.WriteLine("Elementos na pilha:");
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            // Removendo o último elemento da pilha
            int ultimo = pilha.Pop();
            Console.WriteLine($"Removido da pilha: {ultimo}");

            // Exibindo os elementos restantes na pilha
            Console.WriteLine("Elementos restantes na pilha:");
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            // Dictionary (Dicionário)
            // Coleção de pares chave-valor, onde cada chave é única. A ordem dos elementos não é garantida.
            // Uma vez adicionado um par de chave e valor, somente o valor poderá ser modificado. 
            // Os valores podem ser repetidos, porém a chave sempre é única
            Dictionary<string, string> estadosBrasileiros = new Dictionary<string, string>();
            estadosBrasileiros.Add("BA", "Salvador");
            estadosBrasileiros.Add("PE", "Recife");
            estadosBrasileiros.Add("RN", "Natal");
            estadosBrasileiros.Add("AL", "Maceio");
            estadosBrasileiros.Add("SE", "Aracajú");

            Console.WriteLine("Dictionary estados brasileiros: ");
            foreach (var item in estadosBrasileiros)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            // estadosBrasileiros.Add("BA", "Salvador"); -> Gera Exceção pois a chave no dictionary deve ser única

            // adicionando novo par de chave e valor.
            // embora já exista na coleção um valor "Salvador", a chave "BAHIA" não, portanto é adicionado com sucesso 
            estadosBrasileiros.Add("BAHIA", "Salvador");

            estadosBrasileiros["PE"] = "Olinda - valor alterado";

            Console.WriteLine("Dictionary modificado: ");
            foreach (var item in estadosBrasileiros)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine("Exibindo valor da chave 'AL': ");
            Console.WriteLine(estadosBrasileiros["AL"]);



        }
    }
}

