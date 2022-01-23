using Microsoft.EntityFrameworkCore;
using WebAppi.Models;

namespace WebAppi.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Recivos> RECIBOS { get; set; }
        public DbSet<Usuarios> USUARIO { get; internal set; }
    }
}
