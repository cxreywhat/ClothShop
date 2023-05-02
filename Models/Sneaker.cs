namespace ClothShop.Models
{
    public class Sneaker
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Price { get; set; } = 0;
        public string? Description { get; set; } = "No";
        public int Size { get; set; } = 28;
        public string? Color { get; set; } = "White"; 
    }
}