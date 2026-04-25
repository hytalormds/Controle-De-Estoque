using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required]
        public Usuario FkUsuario { get; set; }
        [Required]
        public Fornecedor FkFornecedor { get; set; }

        [ForeignKey("FkFornecedor")]
        public virtual Usuario Fornecedor { get; set; }

        [ForeignKey("FkUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
