using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IFornecedorRepository
    {
        IEnumerable<Fornecedor> GetAll();
        Fornecedor? GetById(Guid id);
        IEnumerable<Fornecedor> GetByNome(string nome);
        Fornecedor Add(Fornecedor fornecedor);
        void Update(Fornecedor fornecedor);
        void Delete(Guid id);
        void SaveChanges();
    }
}
