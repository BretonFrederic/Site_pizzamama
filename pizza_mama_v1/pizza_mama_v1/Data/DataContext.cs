using Microsoft.EntityFrameworkCore;
using pizza_mama_v1.Models;

namespace pizza_mama_v1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
