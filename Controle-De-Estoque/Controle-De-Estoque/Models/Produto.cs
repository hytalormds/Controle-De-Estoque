using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controle_De_Estoque.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(255)]
        public string? Descricao { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public int EstoqueMínimo { get; set; }
        [Required]
        public Categoria FkCategoria { get; set; }
        [Required]
        public Fornecedor FkFornecedor { get; set; }

        [ForeignKey("FkCategoria")]
        public virtual Categoria Categoria { get; set; }

        [ForeignKey("FkFornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }

    }
}
