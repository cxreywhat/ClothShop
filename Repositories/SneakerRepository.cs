using ClothShop.Data;
using ClothShop.Interfaces.Repository;
using ClothShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ClothShop.Repositories
{
    public class SneakerRepository : ISneakerRepository
    {
        private readonly DataContext context;

        public SneakerRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<List<Sneaker>> GetAllSneakersAsync()
        {
            return await context.Sneakers.ToListAsync();
        }

        public async Task<Sneaker?> GetSneakerByIdAsync(int id)
        {
            var sneaker = await context.Sneakers.FindAsync(id);
            if(sneaker is null)
            {
                return null;
            } 

            return sneaker;
        }
        public async Task<bool> CreateSneakerAsync(Sneaker sneaker)
        {
            if (sneaker is null) 
            {
                return false;
            }

            context.Sneakers.Add(sneaker);
            await context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteSneakerAsync(int id)
        {
            var sneaker = await context.Sneakers.FindAsync(id);

            if(sneaker is null)
            {
                return false;
            }

            context.Sneakers.Remove(sneaker);
            await context.SaveChangesAsync();

            return true;
        }
    }
}