using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class LeituraArquivo
    {

        //Metodo que retorna uma tupla
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string path)
        {
            try
            {
                string[] linhas = File.ReadAllLines(path);

                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }


    }
}
