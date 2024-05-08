using Projeto_Hotel.Models;




List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Wesley", sobrenome: "Martins");
Pessoa pessoa2 = new Pessoa(nome: "Beatriz", sobrenome: "Menezes");
Pessoa pessoa3 = new Pessoa(nome: "Gael");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);
hospedes.Add(pessoa3);

Suite suite = new Suite(tipoSuite: "Diamante", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach (var nome in hospedes)
{
    Console.WriteLine($"Hóspede: {nome}");
}
Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria().ToString("C")}");

