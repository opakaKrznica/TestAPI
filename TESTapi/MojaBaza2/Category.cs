using System;
using System.Collections.Generic;

namespace TESTapi.MojaBaza2;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryDescription { get; set; } = null!;

    public bool IsHidden { get; set; }

    public string? ImagePath { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
