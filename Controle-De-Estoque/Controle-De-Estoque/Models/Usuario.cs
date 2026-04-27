using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Controle_De_Estoque.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        public enum PerfilUsuario
        {
            Administrador = 1,
            Operador = 2
        }

        [Key]
        public Guid UsuarioId { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required, MaxLength(255)]
        public string SenhaHash { get; set; }
        [Required, MaxLength(255), EmailAddress]
        public string Email { get; set; }
        [Required]
        public PerfilUsuario Perfil { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}
