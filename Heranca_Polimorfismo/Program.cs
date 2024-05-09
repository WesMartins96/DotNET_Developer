using Heranca_Polimorfismo.Models;

//Herança Aluno : Pessoa
Aluno aluno1 = new Aluno();
aluno1.Nome = "Wesley";
aluno1.Idade = 27;
aluno1.Nota = 7.5;
aluno1.Apresentacao();
Console.WriteLine($"Nota: [{aluno1.Nota}]");

Console.WriteLine();

//Herança Professor : Pessoa
Professor professor1 = new Professor();
professor1.Nome = "Beatriz";
professor1.Idade = 26;
professor1.Salario = 15000M;
professor1.Apresentacao();
Console.WriteLine($"Salário: [{professor1.Salario.ToString("C")}]");

Console.WriteLine();

Console.WriteLine("Usando polimorfismo");
//Polimorfismo
Professor professor2 =  new Professor();
professor2.Nome = "Gael";
professor2.Idade = 47;
professor2.Salario = 3500M;
professor2.Apresentacao();