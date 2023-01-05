using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class TaskState
{
    public int Id { get; set; }

    public string StateName { get; set; } = null!;

    public IEnumerable<Task> Tasks { get; } = new List<Task>();
}
