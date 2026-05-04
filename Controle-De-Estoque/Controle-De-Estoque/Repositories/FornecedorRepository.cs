using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly AppDbContext _context;

        public FornecedorRepository(AppDbContext context)
        {
            _context = context;
        }

        public Fornecedor Add(Fornecedor fornecedor)
        {
            _context.Fornecedores.Add(fornecedor);
            return fornecedor;
        }

        public void Delete(Guid id)
        {
            var fornecedor = _context.Fornecedores.Find(id);

            if(fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
            }
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            return _context.Fornecedores.ToList();
        }

        public Fornecedor? GetById(Guid id)
        {
            return _context.Fornecedores.Find(id);
        }

        public IEnumerable<Fornecedor> GetByNome(string nome)
        {
            return _context.Fornecedores
                .Where(f => f.Nome.Contains(nome))
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
        }
    }
}
