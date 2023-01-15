using Microsoft.EntityFrameworkCore;
using WebAPI.Entidades;
namespace WebAPIAutores
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
    }
}
