using e_commerce.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace e_commerce.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options): base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}