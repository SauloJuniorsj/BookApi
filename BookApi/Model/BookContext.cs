using Microsoft.EntityFrameworkCore;

namespace BookApi.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated(); 
        }
        public DbSet<Book> Books { get; set; } //cada entitade precisa ser mapeada aqui
    }
}
