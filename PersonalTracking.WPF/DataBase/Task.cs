using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Task
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskContent { get; set; }

    public DateTime? TaskStartDate { get; set; }

    public DateTime? TaskDeliveryDate { get; set; }

    public int TaskState { get; set; }

    public Employee Employee { get; set; } = null!;

    public TaskState TaskStateNavigation { get; set; } = null!;
}
