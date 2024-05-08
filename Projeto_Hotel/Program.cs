using Projeto_Hotel.Models;




List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Wesley", sobrenome: "Martins");
Pessoa pessoa2 = new Pessoa(nome: "Beatriz", sobrenome: "Menezes");
Pessoa pessoa3 = new Pessoa(nome: "Gael");
Pessoa pessoa4 = new Pessoa(nome: "Olivia");
Pessoa pessoa5 = new Pessoa(nome: "Arthur", sobrenome: "Noreika");
Pessoa pessoa6 = new Pessoa(nome: "Gustavo", sobrenome: "Augusto");
Pessoa pessoa7 = new Pessoa(nome: "Jorge", sobrenome: "Lopes");
Pessoa pessoa8 = new Pessoa(nome: "Cristina", sobrenome: "Pereira");
Pessoa pessoa9 = new Pessoa(nome: "Bruno", sobrenome: "Potter");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);
hospedes.Add(pessoa3);
hospedes.Add(pessoa4);
hospedes.Add(pessoa5);
hospedes.Add(pessoa6);
hospedes.Add(pessoa7);
hospedes.Add(pessoa8);
hospedes.Add(pessoa9);

Suite suite = new Suite(tipoSuite: "Diamante", capacidade: 10, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach (var nome in hospedes)
{
    Console.WriteLine($"Hóspede: {nome}");
}
Console.WriteLine($"Valor Diária: {reserva.CalcularValorDiaria().ToString("C")}");

