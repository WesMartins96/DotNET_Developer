using Newtonsoft.Json;

namespace Deserializacao_JSON.Models
{
    public class Venda
    {
        public int Id { get; set; }

        //Caso o nome que venha do arquivo .json não respeite a sintaxe do C#, usamos atributo do JsonProperty do Newtonsoft.Json.
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
