using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IItemVendaRepository
    {
        IEnumerable<ItemVenda> GetAll();
        ItemVenda? GetById(Guid id);
        IEnumerable<ItemVenda> GetByNome(string nome);
        ItemVenda Add(ItemVenda itemVenda);
        void Delete(Guid id);
        void SaveChanges();
    }
}
