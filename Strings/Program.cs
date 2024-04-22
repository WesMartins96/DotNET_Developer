using System.Globalization;

//Mudar a localização em todo o sistema
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

List<string> alunos = new List<string>();

alunos.Add("Wesley");
alunos.Add("Beatriz");
alunos.Add("Gael");

for (int i = 0; i < alunos.Count ; i++)
{
    //Concatenação de string
    Console.WriteLine("Nº " + i + " - Aluno: " + alunos[i]);

}

Console.WriteLine();

for (int i = 0; i < alunos.Count; i++)
{
    //Interpolação de string
    Console.WriteLine($"N° {i + 1} - Aluno: {alunos[i]}"); // {i + 1} para exibir a coleção iniciando com 1
}

Console.WriteLine();

//Formatando em valores Monetários
decimal valorMonetario = 1152.99M;
Console.WriteLine($"Preço: {valorMonetario.ToString("C")}"); //Podemos usar também {valorMoneterio:C}

//Representando Porcentagem
double porcentagem = .5555;
Console.WriteLine(porcentagem.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));

//string personalizada
int numero = 16061996;
Console.WriteLine(numero.ToString("00/00/0000"));



