/*
Descrição:
Em jogos de RPG, os jogadores frequentemente adquirem itens mágicos que possuem poderes e habilidades especiais. 
Neste desafio, você deve criar uma classe "ItemMagico" que represente um item mágico e seja capaz de armazenar o nome, descrição e poder do item.

Crie a classe "ItemMagico" que possua os seguintes atributos: "nome", "descricao" e "poder". Além disso, a classe deve ter um método chamado "criar", 
que recebe como argumento os valores do nome, descrição e poder do item, respectivamente.

Entrada:
A entrada será dada pela chamada do método "criar" da classe "ItemMagico", utilizando o io.read() para obter os valores dos atributos de cada item:
nome: nome do item
descricao: descrição do item
poder: poder do item
Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

Saída:
A saída deverá ser a impressão das informações do item criado, no formato:
Nome: [nome do item]
Descrição: [descrição do item]
Poder: [poder]
 */


public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Poder { get; set; }

    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        string nome = Console.ReadLine();


        string descricao = Console.ReadLine();


        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}