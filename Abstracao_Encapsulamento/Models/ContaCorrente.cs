namespace Abstracao_Encapsulamento.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }

        //Encapsulamento
        private decimal Saldo;

        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de [{valor.ToString("C")}] realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro! Saldo insuficiente para esta operação!");
            }

        }

        public override string ToString()
        {
            return $"Meu saldo atualizado: [{Saldo.ToString("C")}]";
        }

    }
}
