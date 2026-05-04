using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly AppDbContext _context;

        public MovimentacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Movimentacao Add(Movimentacao movimentacao)
        {
            _context.Movimentacaos.Add(movimentacao);
            return movimentacao;
        }

        public void Delete(Guid id)
        {
            var movimentacao = _context.Movimentacaos.Find(id);

            if (movimentacao != null)
            {
                _context.Movimentacaos.Remove(movimentacao);
            }
        }

        public IEnumerable<Movimentacao> GetAll()
        {
            return _context.Movimentacaos.ToList();
        }

        public Movimentacao? GetById(Guid id)
        {
            return _context.Movimentacaos.Find(id);
        }

        public IEnumerable<Movimentacao> GetByNome(string nome)
        {
            return null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Movimentacao movimentacao)
        {
            _context.Movimentacaos.Update(movimentacao);
        }
    }
}
