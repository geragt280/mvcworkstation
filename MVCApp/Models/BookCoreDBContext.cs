using Microsoft.EntityFrameworkCore;

namespace MVCApp.Models
{
    public class BookCoreDBContext : DbContext
    {
        public BookCoreDBContext()
        {

        }

        public BookCoreDBContext(DbContextOptions<BookCoreDBContext> options) : base(options)
        {

        }
    }
}
