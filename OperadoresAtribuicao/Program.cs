
//Atribuindo valor
int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);

c = c + 5; // 30 + 5
Console.WriteLine(c);

c -= 10; // 35 - 10
Console.WriteLine(c);


//Converter tipos de variaveis (cast - casting)
//A diferença de (Convert) para o (Parse) é o tratamento de valores null, Convert aceita null, enquanto Parse não aceita.
int n1 = Convert.ToInt32("50");
Console.WriteLine(n1);

int n2 = int.Parse("20");
Console.WriteLine(n2);

double price = double.Parse("35,59");
Console.WriteLine(price);

//conversão para tipo string
string s1 = 100.ToString();
string s2 = 350.ToString();
Console.WriteLine(s1 + s2); //não é realizado a soma, mas sim a concatenação das strings


//cast implícito
int num1 = 5;
double num2 = num1;
Console.WriteLine(num2); //agora o valor é double, pois foi realizado o cast implícito.


//Realizar uma conversão segura
string numeroString = "25www";
int.TryParse(numeroString, out int numero);
Console.WriteLine(numero);
Console.WriteLine("Sistema não estourou um erro por não conseguir converter!");

