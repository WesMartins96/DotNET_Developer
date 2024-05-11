using ClassesAbstratas_Interfaces.Models;



//Abstração
Corrente contaCorrente = new Corrente();
contaCorrente.Creditar(500);
contaCorrente.ExibirSaldo();


Console.WriteLine();


//Object (Classes e metodos)
Computador computador = new Computador();
computador.GetType();
computador.ToString();
computador.Equals(computador.ToString());
computador.GetHashCode();


//Interface
Calculadora calculadora = new Calculadora();
int soma = calculadora.Somar(20, 50);
Console.WriteLine(soma);
