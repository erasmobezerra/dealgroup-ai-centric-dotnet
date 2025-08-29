using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22AbstratasEInterfaces.Models
{
    // Classe ContaCorrente que herda da classe abstrata Conta
    // Caso a classe abstrata tenha métodos abstratos, a classe derivada deve implementar esses métodos
    public class ContaCorrente : Conta
    {
        // override -> indica que estamos sobrescrevendo um método da classe base Conta        
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}
