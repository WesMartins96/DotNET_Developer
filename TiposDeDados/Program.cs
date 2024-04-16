using System.Globalization;

//string - cadeia de caracteres
//char - caractere unicode
//bool - verdadeiro ou falso
//int - valor inteiro numerico
//double - valor decimal numerico
//decimal - valor decimal com precisao para valores monetarios
//DateTime - valor representa datas, usado para manipulacao de datas.


int idade = 20;
Console.WriteLine(idade);

double altura = 1.67;
Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

decimal preco = 25.85M;
Console.WriteLine(preco.ToString("C"));

string frase = "Olá, Tudo bem?";
Console.WriteLine(frase);

bool isAnimal = false;
Console.WriteLine(isAnimal);

char genero = 'M';
Console.WriteLine(genero);

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataAtualFormatada = DateTime.Now;
Console.WriteLine(dataAtualFormatada.ToString("dd/MM/yyyy"));