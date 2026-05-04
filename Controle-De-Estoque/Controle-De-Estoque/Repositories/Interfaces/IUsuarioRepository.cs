using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAll();
        Usuario? GetById(Guid id);
        IEnumerable<Usuario> GetByNome(string nome);
        Usuario Add(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Guid id);
        void SaveChanges();
    }
}
