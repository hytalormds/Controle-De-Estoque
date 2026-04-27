using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}
