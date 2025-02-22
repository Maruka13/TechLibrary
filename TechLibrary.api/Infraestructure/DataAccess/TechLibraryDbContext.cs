using Microsoft.EntityFrameworkCore;
using TechLibrary.api.Domain.Entities;

namespace TechLibrary.api.Infraestructure.DataAccess
{
    public class TechLibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\emanu\\OneDrive\\Área de Trabalho\\TechLibraryDb.db");
        }
    }
}
