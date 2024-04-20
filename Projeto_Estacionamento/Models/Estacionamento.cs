using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estacionamento.Models
{
    public class Estacionamento
    {
        private decimal PrecoInicial;
        private decimal PrecoPorHora;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar[AAA-0000]: ");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
            Console.WriteLine($"VEÍCULO DA PLACA {placa} ESTACIONADO!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();
            if (Veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");            
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PrecoInicial + PrecoPorHora * horas;

                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var item in Veiculos)
                {
                    Console.WriteLine($" -> {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
