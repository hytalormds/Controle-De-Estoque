using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IItemCompraRepository
    {
        IEnumerable<ItemCompra> GetAll();
        ItemCompra? GetById(Guid id);
        IEnumerable<ItemCompra> GetByNome(string nome);
        ItemCompra Add(ItemCompra itemCompra);
        void Delete(Guid id);
        void SaveChanges();
    }
}
