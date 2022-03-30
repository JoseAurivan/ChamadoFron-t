using System;
using System.Text.Json.Serialization;
using Models.Interface;

namespace Models
{
    public abstract class Pessoa:IModelBase
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("cpf")]
        public string Cpf { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
    }
}