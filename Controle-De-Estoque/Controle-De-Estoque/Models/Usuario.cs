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
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(255)]
        public string SenhaHash { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public PerfilUsuario Perfil { get; set; }
    }
}
