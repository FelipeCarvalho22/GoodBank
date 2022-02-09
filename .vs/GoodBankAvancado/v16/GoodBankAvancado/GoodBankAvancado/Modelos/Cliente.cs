using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodBankAvancado.Modelos
{
    /// <summary>
    /// Define um cliente para o banco GoodBank Avançado
    /// </summary>
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public string Profissao { get; set; }

        /// <summary>
        /// Cria uma instancia Cliente no banco GoodBank
        /// </summary>
        /// <param name="cpf">Representa o valor da propriedade <see cref="CPF"/> e deve possuir a seguinte formação XXX.XXX.XXX-XX</param>
        /// <param name="nome">Representa o valor da propriedade <see cref="Nome"/></param>
        public Cliente(string cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }

    }
}
