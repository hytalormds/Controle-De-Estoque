using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly AppDbContext _context;

        public VendaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Venda Add(Venda venda)
        {
            _context.Vendas.Add(venda);
            return venda;
        }

        public void Delete(Guid id)
        {
            var venda = _context.Vendas.Find(id);

            if (venda != null)
            {
                _context.Vendas.Remove(venda);
            }
        }

        public IEnumerable<Venda> GetAll()
        {
            return _context.Vendas.ToList();
        }

        public Venda? GetById(Guid id)
        {
            return _context.Vendas.Find(id);
        }

        public IEnumerable<Venda> GetByNome(string nome)
        {
            return null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Venda venda)
        {
            _context.Vendas.Update(venda);
        }
    }
}
