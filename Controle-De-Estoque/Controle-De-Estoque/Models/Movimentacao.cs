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
        public Guid MovimentacaoId { get; set; }
        [Required]
        public TipoTransacao Tipo { get; set; }
        [Required]
        public int Quantidade { get; set; }
        [Required]
        public DateTime Data { get; set; } = DateTime.UtcNow;
        [Required, MaxLength(255)]
        public string Motivo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }

        [Required]
        public Guid ProdutoId { get; set; }
        [Required]
        public Guid UsuarioId { get; set; }
        public Produto Produto { get; set; }

        public Usuario Usuario { get; set; }
    }
}
