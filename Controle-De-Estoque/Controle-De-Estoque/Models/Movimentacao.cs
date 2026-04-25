using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Movimentacao")]
    public class Movimentacao
    {
        public enum TipoTransacao
        {
            Entrada = 1,
            Saida = 2
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        public TipoTransacao Tipo { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required]
        [MaxLength(255)]
        public string Motivo { get; set; }

        [Required]
        public Produto FkProduto { get; set; }
        [Required]
        public Usuario FkUsuario { get; set; }

        [ForeignKey("FkProduto")]
        public virtual Produto Produto { get; set; }

        [ForeignKey("FkUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
