using Abstracao_Encapsulamento.Models;


//Abstração
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Wesley";
pessoa1.Idade = 27;
pessoa1.Apresentacao();

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Beatriz";
pessoa2.Idade = 26;
pessoa2.Apresentacao();

Console.WriteLine();

//Encapsulamento
ContaCorrente contaCorrente = new ContaCorrente(1100, 2500);
contaCorrente.Sacar(250);
Console.WriteLine(contaCorrente);