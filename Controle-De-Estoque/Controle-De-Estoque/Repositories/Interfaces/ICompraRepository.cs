using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface ICompraRepository
    {
        IEnumerable<Compra> GetAll();
        Compra? GetById(Guid id);
        IEnumerable<Compra> GetByNome(string nome);
        Compra Add(Compra compra);
        void Update(Compra compra);
        void Delete(Guid id);
        void SaveChanges();
    }
}
