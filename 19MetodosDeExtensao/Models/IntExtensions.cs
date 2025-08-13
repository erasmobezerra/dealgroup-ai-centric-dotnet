using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _19MetodosDeExtensao.Models
{
    public static class IntExtensions
    {
        // Método que extende o comportamento de um tipo int 
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}