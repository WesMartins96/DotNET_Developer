using Construtores.Models;


Pessoa pessoa1 = new Pessoa(nome: "Wesley", sobrenome: "Martins", idade: 27);
Pessoa pessoa2 = new Pessoa("Beatriz", "Cristina", 22);

Console.WriteLine(pessoa1);
Console.WriteLine(pessoa2);