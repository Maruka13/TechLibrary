using Microsoft.EntityFrameworkCore;
using TechLibrary.api.Domain.Entities;
using TechLibrary.Api.Domain.Entities;

namespace TechLibrary.api.Infraestructure.DataAccess
{
    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\emanu\\OneDrive\\Área de Trabalho\\TechLibraryDb.db");
        }
    }
}
