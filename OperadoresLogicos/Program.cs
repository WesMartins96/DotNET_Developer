

//operador(Pipe) OR (||)
bool isMaiorIdade = true;
bool possuiAltorizacaoDosPais = false;

if (isMaiorIdade || possuiAltorizacaoDosPais)
{
    Console.WriteLine("Pode ir viajar");
}
else
{
    Console.WriteLine("Não tem autorização dos pais e não é maior de idade!");
    Console.WriteLine("Não pode viajar");
}

//operador AND (&&)
int presencaMinima = 75;
double media = 8.5;
if (presencaMinima >= 60 && media >= 7.0)
{
    Console.WriteLine($"Aprovado com {presencaMinima}% de presença e a media {media}");
}
else
{
    Console.WriteLine($"Reprovado com {presencaMinima}% de presença e a media {media}");
}

//operador NOT (!)
bool possuiIngresso = false;
if (!possuiIngresso)
{
    Console.WriteLine("Não é possivel entrar no estádio");
}
else
{
    Console.WriteLine("Pode entrar, possui ingresso");
}