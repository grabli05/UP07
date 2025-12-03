using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<StockOperation> StockOperations { get; set; } = new List<StockOperation>();
}
