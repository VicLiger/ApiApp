using System.ComponentModel.DataAnnotations;

namespace ApiAppNamoro.Models
{
    public class Conta
    {
        [Key]
        public int ContaId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O seu nome é muito grande")]
        public string Nome { get; set; }

        [Required]
        [Range(1,100, ErrorMessage = "Insira um valor válido entre 1 e 100")]
        public int Idade { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Insira uma imagem válida")]
        public string FotoPerfil { get; set; }
    }
}
