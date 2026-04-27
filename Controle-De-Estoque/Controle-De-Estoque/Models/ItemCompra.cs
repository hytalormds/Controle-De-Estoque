using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("ItemCompra")]
    public class ItemCompra
    {
        [Key]
        public Guid ItemCompraId { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        [Required]
        public Guid CompraId { get; set; }
        [Required]
        public Guid ProdutoId { get; set; }
        public Compra Compra { get; set; }
        public Produto Produto { get; set; }
    }
}
