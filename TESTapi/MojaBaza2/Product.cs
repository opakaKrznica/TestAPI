using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TESTapi.MojaBaza2;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public double ProductPrice { get; set; }

    public int Discount { get; set; }

    public int CategoryId { get; set; }

    public string? ImagePath { get; set; }

    [JsonIgnore]
    public virtual Category? Category { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<ShoppingCard>? ShoppingCards { get; set; } = new List<ShoppingCard>();
}
