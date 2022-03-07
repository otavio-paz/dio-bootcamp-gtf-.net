using Microsoft.EntityFrameworkCore;

namespace CursoMVC_DIO.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } //falando q tem uma tabela categorias
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database-Cursomvc_dio;Integrated Security-True");
        }
    }
}
