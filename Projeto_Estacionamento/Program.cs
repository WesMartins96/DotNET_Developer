using Projeto_Estacionamento.Models;
using System.Globalization;


Console.Write("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial: ");
decimal precoInicial = decimal.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

Console.Write("Agora digite o preço por hora: ");
decimal precoPorHora = decimal.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

bool exibirMenu = true;
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
