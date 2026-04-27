using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        public Guid CompraId { get; set; }
        [Required]
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        [Required]
        public Guid UsuarioId { get; set; }
        [Required]
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Usuario Usuario { get; set; }
    }
}
