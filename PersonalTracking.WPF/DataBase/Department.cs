using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Department
{
    public int Id { get; set; }

    public string DepartmentName { get; set; } = null!;

    public IEnumerable<Employee> Employees { get; } = new List<Employee>();

    public IEnumerable<Position> Positions { get; } = new List<Position>();
}
