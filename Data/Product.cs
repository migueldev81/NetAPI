using System;
using System.Collections.Generic;

namespace NetAPI.Data;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Summary { get; set; } = null!;

    public double Price { get; set; }

    public int Stock { get; set; }
}
