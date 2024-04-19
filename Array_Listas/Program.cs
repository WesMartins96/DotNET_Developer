using System.Collections.Generic;

//Array de inteiros
Console.WriteLine("Trabalhando com Array");
int[] numeros = new int[3];
numeros[0] = 96;
numeros[1] = 65;
numeros[2] = 93;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Percorrendo array com For: {numeros[i]}");
}

foreach (int i in numeros)
{
    Console.WriteLine($"Percorrendo array com Foreach: {i}");
}

//Redimensionar um array
Array.Resize(ref numeros, numeros.Length + 2);
numeros[3] = 101;
numeros[4] = 265;
foreach (var item in numeros)
{
    Console.WriteLine($"Array.Resize: {item}");
}


//Copiar todo um array para um outro novo array maior
int[] numerosDobrados = new int[numeros.Length * 2];
Array.Copy(numeros, numerosDobrados, numeros.Length);
numerosDobrados[0] = 245;
numerosDobrados[1] = 877;
numerosDobrados[2] = 562;
numerosDobrados[3] = 786;
numerosDobrados[4] = 933;
numerosDobrados[5] = 198;
numerosDobrados[6] = 378;
numerosDobrados[7] = 488;
numerosDobrados[8] = 654;
numerosDobrados[9] = 104;
foreach (var item in numerosDobrados)
{
    Console.WriteLine($"Array.Copy: {item}");
}
Console.WriteLine();

//Trabalhando com LISTAS
Console.WriteLine("Trabalhando com Listas");
List<string> nomes = new List<string>();
nomes.Add("Wesley");
nomes.Add("Beatriz");
nomes.Add("Gael");
nomes.Add("Gohan");
nomes.Add("Trunks");

for (int i = 0; i < nomes.Count; i++)
{
    Console.WriteLine($"Listagem de nomes usando For: {nomes[i]}");

}

nomes.Add("Goku");
nomes.Add("Vegeta");

//Podemos remover da lista
nomes.Remove("Wesley");
nomes.Remove("Beatriz");
nomes.Remove("Gael");

//Verificar a capacidade da lista
Console.WriteLine($"Capacidade da lista (nomes): {nomes.Capacity}"); 

foreach (var item in nomes)
{
    Console.WriteLine($"Listagem de nomes usando Foreach: {item}");
}


