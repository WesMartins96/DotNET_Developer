

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("[===[Menu]===]");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    Console.Write($"Digite a sua opção: ");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1": Console.WriteLine("Cadastro de Cliente"); 
            break;
        case "2": Console.WriteLine("Busca de Cliente"); 
            break;
        case "3": Console.WriteLine("Apagar Cliente"); 
            break;
        case "4": Console.WriteLine("Programa encerrado");
            exibirMenu = false;
            //Environment.Exit(0); deste modo o sistema console se encerra por completo.
            break;
        default:
            Console.WriteLine("Digite uma opção correta");
            break;
    }
}

Console.WriteLine("Programa executado por completo!");
