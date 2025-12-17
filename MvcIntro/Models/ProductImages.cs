namespace MvcIntro.Models
{
    public class ProductImages : BaseEntity
    {
        public string ImageURL { get; set; }
        public bool? IsPrymary { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
