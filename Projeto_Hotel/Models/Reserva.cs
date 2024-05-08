using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva()
        {
            
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("[ERRO!] Não é possível cadastrar o número de hóspedes selecionados, pois excede o número de suítes!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
           Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal desconto = Suite.ValorDiaria * 0.1M;
                Suite.ValorDiaria -= desconto;

                return (Suite.ValorDiaria * DiasReservados);
            }
            else
            {
                return (Suite.ValorDiaria * DiasReservados);
            }
        }
    }
}
