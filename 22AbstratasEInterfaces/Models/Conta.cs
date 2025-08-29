using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22AbstratasEInterfaces.Models
{
    // Classes Abstratas -> Classes que não podem ser instanciadas diretamente, servem como base para outras classes.
    public abstract class Conta
    {
        // Protected -> permite acesso somente às classes derivadas
        protected decimal saldo; 

        // Abstract -> método sem implementação, deve obrigatoriamente ser implementado na classe derivada
        public abstract void Creditar(decimal valor); 

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {saldo:C}");
        }
    }
}
