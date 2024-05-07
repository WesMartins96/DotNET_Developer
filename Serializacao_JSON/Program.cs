using Serializacao_JSON.Models;
using Newtonsoft.Json;

//usando datas em formato JSON
//Ao serializar o tipo DateTime o formato no .json se torna um (ISO 8601) -> Padroniza a representação de datas entre sistemas.
DateTime dataAtual = DateTime.Now;

//serializando uma coleção(lista)
Venda venda1 = new Venda(1, "Peças de PC", 2500.00M, dataAtual); 
Venda venda2 = new Venda(2, "Licença de Software", 399.98M, dataAtual);
Venda venda3 = new Venda(3, "Water Cooler", 79.99M, dataAtual);

List<Venda> listaVendas = new List<Venda>();
listaVendas.Add(venda1);
listaVendas.Add(venda2);
listaVendas.Add(venda3);


//Transformar dado em formato JSON
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
Console.WriteLine(serializado);


//Escrever/criar um arquivo .json
File.WriteAllText(@"C:\Users\wesley_lopes\Desktop\Codigos_Cursos\DotNET_Developer\Serializacao_JSON\Arquivos\arquivo.json", serializado);
