namespace MvcIntro.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductImages> ProductImages { get; set; }
    }
}
