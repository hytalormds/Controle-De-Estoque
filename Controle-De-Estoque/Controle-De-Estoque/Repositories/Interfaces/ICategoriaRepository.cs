using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
        Categoria? GetById(Guid id);
        IEnumerable<Categoria> GetByNome(string nome);
        Categoria Add(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(Guid id);

        void SaveChanges();
    }
}
