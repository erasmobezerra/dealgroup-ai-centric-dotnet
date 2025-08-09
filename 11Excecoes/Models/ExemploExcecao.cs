using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11Excecoes.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }
        
        public void Metodo4()
        {
            // Usando o Throw para lançar uma exceção personalizada
            // Lançando uma exceção para ser tratada em outra camada
            throw new Exception("Ocorreu uma exceção no Metodo4() !");
        }
    }
}