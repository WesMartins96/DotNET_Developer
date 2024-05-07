using Deserializacao_JSON.Models;
using Newtonsoft.Json;


//Deserializar um objeto
//Trabalhar as informações de um arquivo JSON para a linguagem C#

string conteudoArquivoJson = File.ReadAllText(@"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\DotNET_Developer\Deserializacao_JSON\Arquivos\vendas.json");

List<Venda> vendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);

foreach (var venda in vendas)
{
    Console.WriteLine($"Id: {venda.Id} / Produto: {venda.Produto} / Preço: {venda.Preco.ToString("F2")} / Data da Venda: {venda.DataVenda.ToString("dd/MM/yyyy")}");
}
