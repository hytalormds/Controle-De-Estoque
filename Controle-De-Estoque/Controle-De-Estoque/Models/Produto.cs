using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_Estoque.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public Guid ProdutoId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(255)]
        public string? Descricao { get; set; }
        [Required, Column(TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public int EstoqueMinimo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        [Required]
        public Guid CategoriaId { get; set; }
        [Required]
        public Guid FornecedorId { get; set; }
        public Categoria Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }

    }
}
