using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class Warehousespace
{
    public int WarehousespaceId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
