namespace Abstracao_Encapsulamento.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }



        public void Apresentacao()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos!");
        }
    }
}
