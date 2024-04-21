using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set.Models
{
    public class Pessoa
    {
        //validando com get e set
        private string _nome;
        private int _idade;

        
        public string Nome 
        {
            //usando BodyExpression para facilitar a sintaxe do get, quando a validação é simples
            get => _nome.ToUpper();

            set
            {
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        //valor apenas de leitura, sem o Set. e usando Body Expressions.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {
            //usando BodyExpression para facilitar a sintaxe do get, quando a validação é simples
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Digite uma idade valida [Acima de 0 anos]");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {NomeCompleto}, e tenho {Idade} anos!");
        }
    }
}
