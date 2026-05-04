using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Categoria Add(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            return categoria;
        }

        public void Delete(Guid id)
        {
            var categoria = _context.Categorias.Find(id);

            if(categoria != null)
            {
                _context.Categorias.Remove(categoria);
            }
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categorias.ToList();
        }

        public Categoria? GetById(Guid id)
        {
            return _context.Categorias.Find(id);
        }

        public IEnumerable<Categoria> GetByNome(string nome)
        {
            return _context.Categorias
                .Where(c => c.Nome.Contains(nome))
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }
    }
}
