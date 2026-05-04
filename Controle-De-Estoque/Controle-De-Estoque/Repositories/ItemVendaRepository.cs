using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class ItemVendaRepository : IItemVendaRepository
    {
        private readonly AppDbContext _context;

        public ItemVendaRepository(AppDbContext context)
        {
            _context = context;
        }

        public ItemVenda Add(ItemVenda itemVenda)
        {
            _context.ItensVendas.Add(itemVenda);
            return itemVenda;
        }

        public void Delete(Guid id)
        {
            var itemvenda = _context.ItensVendas.Find(id);

            if (itemvenda != null)
            {
                _context.ItensVendas.Remove(itemvenda);
            }
        }

        public IEnumerable<ItemVenda> GetAll()
        {
            return _context.ItensVendas.ToList();
        }

        public ItemVenda? GetById(Guid id)
        {
            return _context.ItensVendas.Find(id);
        }

        public IEnumerable<ItemVenda> GetByNome(string nome)
        {
            return null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
