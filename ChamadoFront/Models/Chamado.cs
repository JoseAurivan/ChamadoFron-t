#nullable enable
using System;
using System.Text.Json.Serialization;
using Models.Enums;
using Models.Interface;

namespace Models
{
    [Serializable]
    public class Chamado:IModelBase
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }
        [JsonPropertyName("resposta")]
        public string? Resposta { get; set; }
        [JsonPropertyName("numeroprotocolo")]
        public string? NumeroProtocolo { get; set; }
        [JsonPropertyName("cliente")]
        public Cliente? Cliente { get; set; }
        [JsonPropertyName("statuschamado")]
        public StatusChamado StatusChamado { get; set; }
        [JsonPropertyName("setordestino")]
        public Setor SetorDestimno { get; set; }
        [JsonPropertyName("dataabertura")]
        public DateTime? DataAbertura { get; set; }
        [JsonPropertyName("datafechado")]
        public DateTime? DataFechado { get; set; }


        public override string ToString()
        {
            string resposta = "Cliente Responsável: " + Cliente?.Nome + "\nDescricao: " + Descricao +
                              "\nStatus do Chamado: " + StatusChamado;
            if (Resposta is not null)
                resposta += "\nResposta:" + Resposta;
            
            return resposta ;
        }
    }
    
    
}