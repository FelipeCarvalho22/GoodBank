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
            ContaCorrente conta = new ContaCorrente(cliente);

            Console.WriteLine("Recuperando CPF pela conta corrente: " + conta.Titular.CPF);
            Console.WriteLine();
            Console.WriteLine("Recuperando CPF direto do cliente: " + cliente.CPF);
            Console.WriteLine();
            Console.WriteLine($"O cliente {conta.Titular.Nome} criou a conta corrente numero: {conta.Numero} na agencia: {conta.Agencia}.");
            Console.ReadLine();
        }
    }
}
