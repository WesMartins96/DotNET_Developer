

//Tupla
using Tuplas.Models;

(int Id, string Nome, string Sobrenome, double Altura) tupla = (1, "Wesley", "Martins", 1.65);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

Console.WriteLine();

//Outra sintaxe para utilização de Tuplas
ValueTuple<int, string, string, double> tuplaSintaxe = (2, "Beatriz", "Cristina", 1.62);
Console.WriteLine($"Id: {tuplaSintaxe.Item1}");
Console.WriteLine($"Nome: {tuplaSintaxe.Item2}");
Console.WriteLine($"Sobrenome: {tuplaSintaxe.Item3}");
Console.WriteLine($"Altura: {tuplaSintaxe.Item4}");

Console.WriteLine();

//Outra sintaxe para a utilização de Tuplas
var tuplaOutraSintaxe = Tuple.Create(3, "Gael", 3);
Console.WriteLine($"Id: {tuplaOutraSintaxe.Item1}");
Console.WriteLine($"Nome: {tuplaOutraSintaxe.Item2}");
Console.WriteLine($"Idade: {tuplaOutraSintaxe.Item3}");

Console.WriteLine();


Console.WriteLine("---Método Tupla---");
LeituraArquivo arquivo = new LeituraArquivo();

//usando tupla do metodo
var (sucesso, linhasArquivo, quantidadeLinhas) =  arquivo.LerArquivo(@"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\DotNET_Developer\Tuplas\Arquivos\arquivo_tupla.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (var linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}

//Podemos ter uma tupla com x valores de diversos tipos, porem se não usarmos todos os valores da tupla,
//usamos o 'descarte'. Para isso usamos o caractere _ ;
//exemplo:
//var (sucesso, linhasArquivo, _) = arquivo.LerArquivo(@"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\DotNET_Developer\Tuplas\Arquivos\arquivo_tupla.txt");
//Deste modo só usaremos 2 valores de uma tupla criada com 3 valores, 'descartando' um de seus valores;