using Microsoft.EntityFrameworkCore;
using MiProyectoWebAPI.Models;

namespace MiProyectoWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}

