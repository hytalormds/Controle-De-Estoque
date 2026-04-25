using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("ItemVenda")]
    public class ItemVenda
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        [Column(TypeName ="decimal(10,2")]
        public decimal Preco { get; set; }
        [Required]
        public Produto FkProduto { get; set; }
        [Required]
        public Venda FkVenda { get; set; }

        [ForeignKey("FkProduto")]
        public virtual Produto Produto { get; set; }
        [ForeignKey("FkFornecedor")]
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
