using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Key]
        public Guid VendaId { get; set; }
        [Required]
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required]
        public Guid UsuarioId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public Usuario Usuario { get; set; }
    }
}
