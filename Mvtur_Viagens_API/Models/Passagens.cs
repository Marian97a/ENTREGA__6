using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mvtur_Viagens_API.Models
{
    public class Passagens
    {

        [Key]
        public int Id { get; set; }
        public double Valor_passagens { get; set; }
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }
        public int DestinoId { get; set; }
        public Destinos Destino { get; set; }
    }
}