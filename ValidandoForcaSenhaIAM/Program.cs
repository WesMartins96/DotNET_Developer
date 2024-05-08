
/*
Descrição:
Você está trabalhando para uma empresa que utiliza extensivamente os serviços da AWS, 
e após algumas análises a equipe de segurança identificou que algumas senhas dos usuários no IAM são fracas e podem representar um risco à segurança dos dados da empresa. 
Para resolver esse problema, foi solicitado que você desenvolva um programa capaz de analisar as senhas dos usuários e fornecer uma validação de força com base em 
critérios predefinidos.

Requisitos de segurança para a senha:
-A senha deve ter no mínimo 8 caracteres.
-A senha deve conter pelo menos uma letra maiúscula (A-Z).
-A senha deve conter pelo menos uma letra minúscula (a-z).
-A senha deve conter pelo menos um número (0-9).
-A senha deve conter pelo menos um caractere especial, como !, @, #, $, %, etc.

Entrada:
A entrada será uma única string representando a senha que precisa ser validada.

Saída:
Seu programa deve retornar uma mensagem indicando se a senha fornecida pelo usuário atende aos requisitos de segurança ou não, 
juntamente com um feedback explicativo sobre os critérios considerados.
*/


class Program
{
    static string VerificarForcaSenha(string senha)
    {
        int comprimentoMinimo = 8;
        bool temLetraMaiuscula = false;
        bool temLetraMinuscula = false;
        bool temNumero = false;
        bool temCaractereEspecial = false;

        // TODO: Verifique o comprimento da senha
        //A senha deve ter no mínimo 8 caracteres.
        if (senha.Length < comprimentoMinimo)
        {
            return "Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.";
        }

        // Verificando se a senha contém letras maiúsculas e minúsculas
        temLetraMaiuscula = senha.Any(char.IsUpper);
        temLetraMinuscula = senha.Any(char.IsLower);

        // Verificando se a senha contém sequências comuns
        string[] sequenciasComuns = { "123456", "abcdef" };
        if (sequenciasComuns.Any(s => senha.Contains(s)))
            return "Sua senha contem uma sequencia comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém palavras comuns
        string[] palavrasComuns = { "password", "123456", "qwerty" };
        if (palavrasComuns.Contains(senha))
            return "Sua senha e muito comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém números e caracteres especiais
        temNumero = senha.Any(char.IsDigit);
        temCaractereEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

        if (temLetraMinuscula && temLetraMaiuscula && temNumero && temCaractereEspecial)
            return "Sua senha atende aos requisitos de seguranca. Parabens!";
        else
            return "Sua senha nao atende aos requisitos de seguranca.";
    }

    static void Main(string[] args)
    {
        string senha = Console.ReadLine().Trim();

        string resultado = VerificarForcaSenha(senha);

        Console.WriteLine(resultado);
    }
}