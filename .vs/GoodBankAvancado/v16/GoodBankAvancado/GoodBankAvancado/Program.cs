using GoodBankAvancado.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBankAvancado
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("399.800.288-07", "Felipe Siqueira Carvalho Silva");
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(cliente.CPF);
            Console.ReadLine();
        }
    }
}
