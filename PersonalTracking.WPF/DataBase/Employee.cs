using System;
using System.Collections.Generic;

namespace PersonalTracking.WPF.DataBase;

public partial class Employee
{
    public int Id { get; set; }

    public int UserNo { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public int DepartmentId { get; set; }

    public int PositionId { get; set; }

    public int Salary { get; set; }

    public DateTime? Birthday { get; set; }

    public string? Address { get; set; }

    public string Password { get; set; } = null!;

    public bool IsAdmin { get; set; }

    public Department Department { get; set; } = null!;

    public IEnumerable<Permission> Permissions { get; } = new List<Permission>();

    public Position Position { get; set; } = null!;

    public IEnumerable<Salary> Salaries { get; } = new List<Salary>();

    public IEnumerable<Task> Tasks { get; } = new List<Task>();
}
