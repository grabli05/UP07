using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Sku { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public int? CategoryId { get; set; }

    public int? WarehousespaceId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<StockOperation> StockOperations { get; set; } = new List<StockOperation>();

    public virtual Warehousespace? Warehousespace { get; set; }
}
