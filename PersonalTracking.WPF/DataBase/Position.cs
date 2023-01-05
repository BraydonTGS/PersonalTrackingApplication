using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Position
{
    public int Id { get; set; }

    public string PositionName { get; set; } = null!;

    public int DepartmentId { get; set; }

    public Department Department { get; set; } = null!;

    public IEnumerable<Employee> Employees { get; } = new List<Employee>();
}
