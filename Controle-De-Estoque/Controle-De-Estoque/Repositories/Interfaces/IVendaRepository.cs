using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> GetAll();
        Venda? GetById(Guid id);
        IEnumerable<Venda> GetByNome(string nome);
        Venda Add(Venda venda);
        void Update(Venda venda);
        void Delete(Guid id);
        void SaveChanges();
    }
}
