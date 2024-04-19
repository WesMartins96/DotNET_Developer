

// FOR
int numero = 10;
for (int i = 1; i <= numero; i++)
{
    Console.WriteLine($"usado for: {numero} X {i} = {numero * i}");
}


// WHILE
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine($"usando while: {numero} X {contador} = {numero * contador}");
    contador++;
    //podemos interromper o laço de repetição usando break;
    if (contador == 6)
    {
        break;
    }
}


// DO WHILE
int soma = 0, num = 0;
do
{
    Console.Write($"Usando Do While: Digite um número! vamos somar! (0 para parar): ");
    num = int.Parse(Console.ReadLine());

    soma += num;
} while (num != 0);
Console.WriteLine($"usando Do While: Total da soma dos números digitados é: {soma}");





