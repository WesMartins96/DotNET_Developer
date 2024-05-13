
/*
Descrição:
Nesse desafio, você deverá criar um programa que permita ao usuário escolher o valor e o naipe de uma carta de baralho, e exibir a carta escolhida.

Para isso, será necessário criar uma classe chamada Carta, que possua dois atributos: naipe e valor. Os valores de naipe e valor devem ser definidos como enumerações, 
para facilitar a escolha do usuário.

Como observação, os valores do enum Valor são:

Ás = 1; Valete = 2; Dama = 3; Rei = 4.
Já os valores do enum Naipe são :

Paus = 0; Ouros = 1; Copas = 2; Espadas = 3.
O programa deve permitir que o usuário escolha o valor e o naipe da carta, e em seguida criar uma instância da classe Carta com os valores escolhidos. Por fim, o programa deve exibir a carta escolhida, mostrando tanto o valor quanto o naipe da carta.

Requisitos:
Utilizar a classe "Carta" que possui dois atributos: "naipe" e "valor", ambos são enums.
Utilizar switch case para tratar exceções ao escolher o naipe e o valor da carta.
O programa deve permitir que o usuário escolha o naipe e o valor da carta.
O programa deve exibir a carta escolhida pelo usuário.

Entrada:
A entrada deve receber duas informações, referentes ao valor e naípe, conforme exemplo abaixo:
valor: Enum  - representando o valor da carta;
naipe: Enum  - representando o náipe da carta.

Saída:
O código deverá retornar uma mensagem (string) informando qual o valor da carta e seu náipe, após receber como entrada os Enums valor e naipe. 
Veja as entradas recebida abaixo:
3
2

De acordo com esses valores de entrada, a saída ficará desta maneira:
Carta escolhida: Dama de Ouros
*/


public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

public class Carta
{
    private Naipe naipe;
    private Valor valor;

    public Carta(Naipe n, Valor v)
    {
        naipe = n;
        valor = v;
    }

    public Naipe GetNaipe()
    {
        return naipe;
    }

    public Valor GetValor()
    {
        //TODO: Implemente o GetValor();
        return valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input para escolher a carta desejada
        int valorEscolhido, naipeEscolhido;
        do
        {

            valorEscolhido = int.Parse(Console.ReadLine());
        } while (valorEscolhido < 1 || valorEscolhido > 4);

        do
        {

            naipeEscolhido = int.Parse(Console.ReadLine());
        } while (naipeEscolhido < 0 || naipeEscolhido > 3);

        // Criação da carta escolhida pelo usuário
        Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

        // Exibição da carta escolhida pelo usuário
        string nomeValor = "", nomeNaipe = "";

        switch (cartaEscolhida.GetValor())
        {
            case Valor.As:
                nomeValor = "Ás";
                break;
            case Valor.Valete:
                nomeValor = "Valete";
                break;
            case Valor.Dama:
                nomeValor = "Dama";
                break;
            case Valor.Rei:
                nomeValor = "Rei";
                break;
        }

        switch (cartaEscolhida.GetNaipe())
        {
            case Naipe.Paus:
                nomeNaipe = "Paus";
                break;
            case Naipe.Ouros:
                nomeNaipe = "Ouros";
                break;
            //TODO: Complete o código
            case Naipe.Copas:
                nomeNaipe = "Copas";
                break;
            case Naipe.Espadas:
                nomeNaipe = "Espadas";
                break;
        }

        Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");
    }
}