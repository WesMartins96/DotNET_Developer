using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }


        //Polimorfismo (Sobrescrever)
        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos! sou Professor e meu salário é: {Salario.ToString("C")}");
        }
    }
}
