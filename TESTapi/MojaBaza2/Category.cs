using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TESTapi.MojaBaza2;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryDescription { get; set; } = null!;

    public bool IsHidden { get; set; }


    public string? ImagePath { get; set; }

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
