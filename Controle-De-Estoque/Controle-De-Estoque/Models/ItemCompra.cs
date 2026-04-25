using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("ItemCompra")]
    public class ItemCompra
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        [Required]
        public Compra FkCompra { get; set; }
        [Required]
        public Produto FkProduto { get; set; }

        [ForeignKey("FkCompra")]
        public virtual Compra Compra { get; set; }
        [ForeignKey("FkProduto")]
        public virtual Produto Produto { get; set; }
    }
}
