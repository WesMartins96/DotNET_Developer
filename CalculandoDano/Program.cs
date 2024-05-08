
/*
Entrada:
Seu programa deverá receber uma entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: 
o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

Saída:
A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. 
Caso o valor do dano seja negativo, deve ser exibido zero.

Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída:
"O dano causado pelo ataque foi: 2" 
 */

class Program
{
    static int CalcularDano(int ataque, int defesa)
    {
        if (ataque <= defesa)
        {
            return 0;
        }
        else
        {
            return ataque - defesa;
        }

    }

    static void Main(string[] args)
    {
        int ataque = int.Parse(Console.ReadLine());

        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
