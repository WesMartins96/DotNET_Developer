using OperadoresAritmeticos_ClasseMath.Models;


Calculadora calculadora = new Calculadora();

calculadora.Somar(10, 10);
calculadora.Subtrair(25, 10);
calculadora.Multiplicar(5, 8);
calculadora.Dividir(50, 5);

//Incremento
int numIncremento = 2;
numIncremento++;
Console.WriteLine(numIncremento);

//Decremento
int numDecremento = 5;
numDecremento--;
Console.WriteLine(numDecremento);


//Classe Math
//Potencia
calculadora.Potencia(3, 3);

//seno, coseno e tangente
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);

//Raiz quadrada
calculadora.RaizQuadrada(9);


