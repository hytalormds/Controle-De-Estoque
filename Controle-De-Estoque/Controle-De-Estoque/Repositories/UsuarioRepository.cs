using Controle_De_Estoque.Context;
using Controle_De_Estoque.Models;
using Controle_De_Estoque.Repositories.Interfaces;

namespace Controle_De_Estoque.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Usuario Add(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            return usuario;
        }

        public void Delete(Guid id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario? GetById(Guid id)
        {
            return _context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> GetByNome(string nome)
        {
            return _context.Usuarios
                .Where(u => u.Nome.Contains(nome))
                .ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }
    }
}
