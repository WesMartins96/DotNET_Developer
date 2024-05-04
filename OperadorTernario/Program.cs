


//utilização do IF Ternário
int numero = 2;


//usando IF Tradicional
if (numero % 2 == 0)
{
    Console.WriteLine($"Numero {numero} é par");
}
else
{
    Console.WriteLine($"Numero {numero} é impar");
}

Console.WriteLine();


//usando IF Ternário
bool ehPar = numero % 2 == 0;
Console.WriteLine($"Número {numero} é: {(ehPar ? "par" : "impar")} "); //IF Ternário  (condição ? true : false)
