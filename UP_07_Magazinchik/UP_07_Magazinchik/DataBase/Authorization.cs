using System;
using System.Collections.Generic;

namespace UP_07_Magazinchik.DataBase;

public partial class Authorization
{
    public int AuthorizationId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool Blocked { get; set; }

    public virtual User? User { get; set; }
}
