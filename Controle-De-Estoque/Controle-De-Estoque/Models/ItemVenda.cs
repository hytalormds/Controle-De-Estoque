using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("ItemVenda")]
    public class ItemVenda
    {
        [Key]
        public Guid ItemVendaId { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required, Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        [Required]
        public Guid ProdutoId { get; set; }
        [Required]
        public Guid FornecedorId { get; set; }
        [Required]
        public Guid VendaId { get; set; }
        public Produto Produto { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Venda Venda { get; set; }
    }
}
