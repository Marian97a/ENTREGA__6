using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mvtur_Viagens_API.Models
{
    public class Destinos
    {

        [Key]
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Data_ida { get; set; }
        public double Data_volta { get; set; }
        [JsonIgnore]
        public List<Passagens> Passagens { get; set; }
    }
}