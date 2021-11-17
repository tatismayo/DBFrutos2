using System;
using Microsoft.EntityFrameworkCore;
using DBFrutos2.Dominio;

namespace DBFrutos2.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoUsuario> TiposUsuario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Factura> Factura { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Initial Catalog=BDFrutos2; Data Source=LAPTOP-N5N4CBFB\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}
