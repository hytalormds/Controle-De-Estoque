using Controle_De_Estoque.Models;

namespace Controle_De_Estoque.Repositories.Interfaces
{
    public interface IMovimentacaoRepository
    {
        IEnumerable<Movimentacao> GetAll();
        Movimentacao? GetById(Guid id);
        IEnumerable<Movimentacao> GetByNome(string nome);
        Movimentacao Add(Movimentacao movimentacao);
        void Update(Movimentacao movimentacao);
        void Delete(Guid id);
        void SaveChanges();
    }
}
