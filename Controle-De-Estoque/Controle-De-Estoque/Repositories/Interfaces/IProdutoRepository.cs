using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto? GetById(Guid id);
        IEnumerable<Produto> GetByNome(string nome);
        Produto Add(Produto produto);
        void Update(Produto produto);
        void Delete(Guid id);
        void SaveChanges();
    }
}
