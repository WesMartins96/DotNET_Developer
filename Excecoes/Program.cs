


//Ler arquivo e usando exceções para captura de erros.

try
{
    string path = @"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\DotNET_Developer\Excecoes\Arquivos\arquivo_Leitura.txt";  //arquivoLeitura.txt
    string[] linhas = File.ReadAllLines(path);

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.Message + " Arquivo não encontrado! ");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine(ex.Message + " caminho da pasta não encontrado! ");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Chegou até aqui!");
}


