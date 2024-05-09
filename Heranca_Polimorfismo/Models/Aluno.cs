namespace Heranca_Polimorfismo.Models
{
    //Herança
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }


        //Polimorfismo (Sobrescrever)
        public override void Apresentacao()
        {
            Console.WriteLine($"Olá, me chamo {Nome} e tenho {Idade} anos! sou Aluno e minha nota é: {Nota}");
        }
    }
}
