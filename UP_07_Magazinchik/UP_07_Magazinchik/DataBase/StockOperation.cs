using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class StockOperation
{
    public int OperationId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public int? SupplierId { get; set; }

    public int OperationTypeId { get; set; }

    public int Quantity { get; set; }

    public DateTime OperationDate { get; set; }

    public string? Comment { get; set; }

    public virtual OperationType OperationType { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Supplier? Supplier { get; set; }

    public virtual User User { get; set; } = null!;
}
