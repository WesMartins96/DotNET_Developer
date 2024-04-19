

/*Descrição
Uma nova feature para um sistema bancário foi analisada pela equipe de desenvolvimento e será uma das tarefas a serem trabalhadas durante a sprint, 
como desenvolvedor da empresa você recebeu os requisitos para a nova implementação que consiste em uma solução algorítmica que permita aos clientes realizarem 
saques em caixas eletrônicos. No entanto, existem algumas regras a serem seguidas para garantir que um saque possa ser realizado com sucesso.

Regras do saque:

- Cada cliente digitará o valor do seu saldoTotal de sua conta bancária e o valorSaque.
- Um saque só pode ser realizado se o saldoDisponível na conta for igual ou superior ao valor solicitado.
- Se o saldo for suficiente, o valor solicitado deve ser subtraído do saldo disponível, indicando que o saque foi realizado.
- Se o saldo for insuficiente, o saque não deve ser realizado e uma mensagem adequada deve ser exibida.

Entrada
A entrada consiste em dois valores inteiros que representam o total do saldo da conta e o valor do saque.

Saída
Se o saque for realizado com sucesso, exibir a mensagem "Saque realizado com sucesso! Novo saldo: {saldo}", onde {saldo} é o novo saldo disponível na conta.

Se o saque não for possível devido a saldo insuficiente, exibir a mensagem "Saldo insuficiente. Saque nao realizado!"*/

Console.Write("Digite o valor do saldo total: ");
int saldoTotal = int.Parse(Console.ReadLine());
Console.Write("Digite o valor do saque desejado: ");
int valorSaque  = int.Parse(Console.ReadLine());
Banco banco = new Banco(valorSaque, saldoTotal);



//TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
banco.Saque(valorSaque, saldoTotal);

public class Banco
{
    public int Saldo { get; set; }
    public int Valor { get; set; }

    public Banco(int saldo, int valor)
    {
        Saldo = saldo;
        Valor = valor;
    }

    public void Saque(int valor, int saldo)
    {
        saldo = saldo - valor;
        if (saldo >= valor - saldo)
        {
            Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldo}");
        }else
        {
            Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        }
    }
}


