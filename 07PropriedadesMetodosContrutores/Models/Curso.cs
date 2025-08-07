using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07PropriedadesMetodosContrutores.Models;

// Métodos -> É um bloco de códigos que definem comportamentos que as instâncias da classe podem executar.
// Assinatura do método: Nome do método, parâmetros e tipo de retorno.
namespace _07PropriedadesMetodosContrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterTotalAlunos()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Aluno(s) no curso {Nome}:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"- {aluno.NomeCompleto}");
            }
        }

    }
}