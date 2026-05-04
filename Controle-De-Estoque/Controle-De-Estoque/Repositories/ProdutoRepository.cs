using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Produto Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            return produto;
        }

        public void Delete(Guid id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
            }
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto? GetById(Guid id)
        {
            return _context.Produtos.Find(id);
        }

        public IEnumerable<Produto> GetByNome(string nome)
        {
            return _context.Produtos
                .Where(p => p.Nome.Contains(nome))
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _context.Produtos.Update(produto);
        }
    }
}
