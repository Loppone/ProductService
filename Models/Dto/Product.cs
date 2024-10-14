namespace ProductService.Models.Dto
{
    public class Product
    {
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
