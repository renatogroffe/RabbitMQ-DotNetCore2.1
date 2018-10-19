using System.ComponentModel.DataAnnotations;

namespace APIMensagens.Models
{
    public class Conteudo
    {
        [Required]
        public string Mensagem { get; set; }
    }
}