using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class ItemCompraRepository : IItemCompraRepository
    {
        private readonly AppDbContext _context;

        public ItemCompraRepository(AppDbContext context)
        {
            _context = context;
        }

        public ItemCompra Add(ItemCompra itemCompra)
        {
            _context.ItensCompras.Add(itemCompra);
            return itemCompra;
        }

        public void Delete(Guid id)
        {
            var itemcompra = _context.ItensCompras.Find(id);

            if (itemcompra != null)
            {
                _context.ItensCompras.Remove(itemcompra);
            }
        }

        public IEnumerable<ItemCompra> GetAll()
        {
            return _context.ItensCompras.ToList();
        }

        public ItemCompra? GetById(Guid id)
        {
            return _context.ItensCompras.Find(id);
        }

        public IEnumerable<ItemCompra> GetByNome(string nome)
        {
            return null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
