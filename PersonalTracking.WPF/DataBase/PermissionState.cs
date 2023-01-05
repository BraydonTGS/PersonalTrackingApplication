using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class PermissionState
{
    public int Id { get; set; }

    public string StateName { get; set; } = null!;

    public IEnumerable<Permission> Permissions { get; } = new List<Permission>();
}
