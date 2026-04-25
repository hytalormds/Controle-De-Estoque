using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(20)]
        public string Telefone { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
    }
}
