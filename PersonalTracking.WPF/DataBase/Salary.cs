using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Salary
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }

    public int Amount { get; set; }

    public int Year { get; set; }

    public int MonthId { get; set; }

    public Employee Employee { get; set; } = null!;

    public Month Month { get; set; } = null!;
}
