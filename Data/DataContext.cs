using ClothShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothShop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Sneaker> Sneakers => Set<Sneaker>();
    }
}