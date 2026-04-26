using Controle_De_Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle_De_Estoque.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<ItemCompra> ItensCompras { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
        public DbSet<Movimentacao> Movimentacaos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
