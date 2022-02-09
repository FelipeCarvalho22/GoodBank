using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBankAvancado.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente no banco GoodBank Avançado
    /// </summary>
    public class ContaCorrente
    {
        /// <summary>
        /// Atribui o cliente a conta corrente em questão
        /// </summary>
        public Cliente Titular { get; set; }
        /// <summary>
        /// Numero da Conta Corrente
        /// </summary>
        public int Numero { get; }
        /// <summary>
        /// Agencia sede da Conta Corrente
        /// </summary>
        public int Agencia { get; }
        /// <summary>
        /// Retorna o Total de Contas Correntes criadas no GoodBank
        /// </summary>
        public static int TotalContasBanco { get; private set; }
        /// <summary>
        /// Cria uma instancia Conta Corrente no banco GoodBank
        /// </summary>
        /// <param name="cliente">Representa o valor da propriedade <see cref="Titular"/></param>
        public ContaCorrente(Cliente cliente)
        {
            Titular = cliente;

            Numero = TotalContasBanco + 1000;
            Agencia = 5822;

            TotalContasBanco++;
        }
    }
}
