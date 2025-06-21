using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string Name;
    public bool Active;
}

public class EmployeeSearch
{
    public static List<Employee> Search(List<Employee> employees, string query)
    {
        return employees
            .Where(e => e.Name.ToLower().Contains(query.ToLower()) && e.Active)
            .ToList();
    }
}
