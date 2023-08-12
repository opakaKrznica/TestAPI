namespace TESTfrontEnd.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }
    }
}
