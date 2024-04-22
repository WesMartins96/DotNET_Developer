

//Formatar o tipo DateTime
using System.Globalization;

DateTime data = DateTime.Now;

Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToString("dd/MM/yyyy"));
Console.WriteLine(data.ToShortTimeString());

//Podemos realizar a conversão de string para DateTime
DateTime dataNasc = DateTime.Parse("16/06/1996 11:52:48");
Console.WriteLine(dataNasc.ToString("dd/MM/yyyy HH:mm"));


//validação se caso a data for invalida sem para a aplicação
string dataValid = "32/06/2024 18:25:49";
bool dataConvertida = DateTime.TryParseExact(dataValid, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date);
if (dataConvertida)
{
    Console.WriteLine($"Convertido com sucesso {data}");
}
else
{
    Console.WriteLine($"Não é possivel converter! data incorreta!");
}
