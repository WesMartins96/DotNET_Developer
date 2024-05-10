using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas_Interfaces.Models
{
    //classe abstrata 
    public abstract class Conta
    {
        protected decimal Saldo { get; set; }

        //método abstrato
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O Saldo é: {Saldo:C}");
        }
    }
}
