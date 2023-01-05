using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Month
{
    public int Id { get; set; }

    public string MonthName { get; set; } = null!;

    public IEnumerable<Salary> Salaries { get; } = new List<Salary>();
}
