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
        /// <summary>
        /// Nome do Cliente
        /// </summary>
        public string Nome { get; set; }    //Acesso e alteração do nome é publico
        public string CPF { get; private set; }     //Acesso publico, mas a alteração é privada
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
