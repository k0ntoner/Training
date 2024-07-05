
using Microsoft.EntityFrameworkCore;

namespace BookAPP.Models
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions<BookContext> opt)
            : base(opt) { }
        public DbSet<BookItem> BookItems { get; set; } = null!;
    }
}
