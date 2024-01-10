using Mvtur_Viagens_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Mvtur_Viagens_API.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Destinos> Destinos { get; set; }
        public DbSet<Passagens> Passagens { get; set; }
    }
}