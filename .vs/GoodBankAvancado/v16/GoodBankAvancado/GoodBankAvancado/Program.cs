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
            Console.WriteLine("Bem vindo ao GoodBank-Avançado");
            Console.WriteLine();

            Inicio:

            if (ContaCorrente.TotalContasBanco > 0)
            {
                Console.WriteLine("O que o senhor(a) deseja fazer: 1-Criar uma nova conta, 2-Acessar sua conta ou qualquer outro numero para encerrar.");
                Console.WriteLine();

                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("Vamos criar sua conta corrente!");
                            goto Fim;
                        case 2:
                            Console.WriteLine("Vamos acessar sua conta!");
                            goto Fim;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ops... Você não digitou um numero, por favor tente novamente");
                    goto Inicio;
                }
            }
            else
            {
                Console.WriteLine("Não há nenhuma conta corrente criada, escolha uma das opções:");
                Console.WriteLine();
                Console.WriteLine("Digite: 1-Criar Conta Corrente ou qualquer numero para fechar a aplicação");

                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("Vamos criar sua conta corrente!");
                            goto Fim;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ops... Você não digitou um numero, por favor tente novamente");
                    goto Inicio;
                }
            }

            Fim:
            Console.WriteLine("Obrigado pela visita, aperte Enter para encerrar");
            Console.ReadLine();
        }
    }
}
