namespace TESTfrontEnd.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool IsHidden { get; set; }
        public string? ImagePath { get; set; }
    }
}

