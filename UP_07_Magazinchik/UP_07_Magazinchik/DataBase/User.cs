using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int RolesId { get; set; }

    public int AuthorizationId { get; set; }

    public virtual Authorization Authorization { get; set; } = null!;

    public virtual Role Roles { get; set; } = null!;

    public virtual ICollection<StockOperation> StockOperations { get; set; } = new List<StockOperation>();
}
