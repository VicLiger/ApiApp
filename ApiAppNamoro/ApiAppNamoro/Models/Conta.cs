using System.ComponentModel.DataAnnotations;

namespace ApiAppNamoro.Models
{
    public class Conta
    {
        [Key]
        public int ContaId { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string FotoPerfil { get; set; }
    }
}
