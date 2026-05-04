using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class CompraRepository : ICompraRepository 
    {
        private readonly AppDbContext _context;

        public CompraRepository(AppDbContext context)
        {
            _context = context;
        }

        public Compra Add(Compra compra)
        {
            _context.Compras.Add(compra);
            return compra;
        }

        public void Delete(Guid id)
        {
            var compra = _context.Compras.Find(id);

            if(compra != null)
            {
                _context.Compras.Remove(compra);
            }
        }

        public IEnumerable<Compra> GetAll()
        {
            return _context.Compras.ToList();
        }

        public Compra? GetById(Guid id)
        {
            return _context.Compras.Find(id);
        }

        public IEnumerable<Compra> GetByNome(string nome)
        {
            return null;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Compra compra)
        {
            _context.Compras.Update(compra);
        }
    }
}
