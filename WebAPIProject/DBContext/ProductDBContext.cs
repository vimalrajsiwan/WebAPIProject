using Microsoft.EntityFrameworkCore;

namespace WebAPIProject.DBContext
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
            try
            {
                Database.EnsureCreated();
                Database.Migrate();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
