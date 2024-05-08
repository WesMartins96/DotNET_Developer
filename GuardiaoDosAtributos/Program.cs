/*
Descrição:
Em jogos de RPG, os personagens possuem atributos que determinam suas habilidades em diferentes áreas, como força, agilidade, inteligência, etc. 
Neste desafio, você deve criar uma função que verifica se o valor de um determinado atributo está dentro de um intervalo aceitável.

Crie uma função chamada "verificar_atributo" que recebe três parâmetros: "atributo", "valor_minimo" e "valor_maximo". 
A função deve verificar se o valor do atributo está dentro do intervalo definido pelos valores mínimo e máximo.
Caso o valor esteja dentro do intervalo, a função deve retornar true. Caso contrário, deve retornar false.

Entrada:
A entrada do código deverá ser feita através do io.stream(). Serão necessários três valores para chamar a função "verificar_atributo", 
que são: o nome do atributo, o valor mínimo aceitável e o valor máximo aceitável. Além disso, 
também será necessário informar o valor atual do atributo que se deseja verificar.

Saída:
A saída do código será uma mensagem informando se o valor do atributo está dentro ou fora do intervalo especificado. 
Caso o valor esteja dentro do intervalo, a mensagem será "O valor do atributo está dentro do intervalo especificado". 
Caso contrário, a mensagem será "O valor do atributo está fora do intervalo especificado".
*/


class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo)
        {
            Console.WriteLine("O valor do atributo está dentro do intervalo especificado");
            return true;
        }
        else
        {
            Console.WriteLine("O valor do atributo está fora do intervalo especificado");
            return false;
        }
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
    }
}

