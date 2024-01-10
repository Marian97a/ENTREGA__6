using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Mvtur_Viagens_API.Models
{
    public class Clientes
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        [JsonIgnore]
        public List<Passagens> Passagens { get; set; }
    }
}