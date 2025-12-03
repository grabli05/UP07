using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class OperationType
{
    public int OperationTypeId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<StockOperation> StockOperations { get; set; } = new List<StockOperation>();
}
