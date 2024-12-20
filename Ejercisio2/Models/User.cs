using System;
using System.Collections.Generic;

namespace Ejercisio2.Models;

public partial class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? UserEmail { get; set; }
}
