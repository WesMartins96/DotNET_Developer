using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces.Models
{
    public class Corrente : Conta
    {



        //se a classe pai tem um metodo abstrato é obrigatorio a inserção na classe que esta herdando do pai.
        public override void Creditar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
