using Libreria_EESA.Dato.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Libreria_EESA.Dato
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) 
        { 
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
