using System;
using System.Collections.Generic;

namespace TESTapi.MojaBaza2;

public partial class ShoppingCard
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string OrderedByName { get; set; } = null!;

    public string OrderedByEmail { get; set; } = null!;

    public string OrderId { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
