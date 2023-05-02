using ClothShop.Models;

namespace ClothShop.Interfaces.Repository
{
    public interface ISneakerRepository
    {
        public Task<List<Sneaker>> GetAllSneakersAsync();
        public Task<Sneaker?> GetSneakerByIdAsync(int id);
        public Task<bool> CreateSneakerAsync(Sneaker sneaker);
        public Task<bool> DeleteSneakerAsync(int id);

    }
}