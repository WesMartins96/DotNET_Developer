using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }



        public virtual void Apresentacao()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos!");
        }
    }
}
