


int qtdEstoque = 10;
Console.WriteLine($"Quantidade disponivel em estoque: {qtdEstoque}");
Console.Write("Digite a quantidade a ser comprada: ");
int qtdComprada = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantidade comprada: {qtdComprada}");

if (qtdEstoque >= qtdComprada)
{
    Console.WriteLine("Temos em estoque");
    Console.WriteLine("Compra Realizada");
}
else
{
    Console.WriteLine("Não temos em estoque");
    Console.WriteLine("Compra não realizada");
}


//IF aninhado
int idade = 18;
if (idade >= 18)
{
    Console.WriteLine("Pode viajar");
}
else if (idade < 18 && idade >= 14)
{
    Console.WriteLine("Pode Viajar com a permissão dos pais");
}
else if (idade < 14 && idade >= 10)
{
    Console.WriteLine("Pode viajar acompanhado dos pais");
}
else
{
    Console.WriteLine("Não é permitido menores de 10 anos nesta viagem");
}



//switch Case, alternativa para verificação de multiplos casos (ifs)
Console.Write("Digite uma letra para descobrir se é uma vogal ou não: ");
string letra = Console.ReadLine();
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}