using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class Role
{
    public int RolesId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
