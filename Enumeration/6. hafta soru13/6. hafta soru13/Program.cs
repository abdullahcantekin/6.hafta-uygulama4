using System;

enum EmployeeRole
{
    Manager = 1,
    Developer,
    Designer,
    Tester
}

class EmployeeSalary
{
    public decimal CalculateSalary(EmployeeRole role)
    {
        switch (role)
        {
            case EmployeeRole.Manager:
                return 5000m;
            case EmployeeRole.Developer:
                return 4000m;
            case EmployeeRole.Designer:
                return 3500m;
            case EmployeeRole.Tester:
                return 3000m;
            default:
                return 0m;
        }
    }
}

class Program
{
    static void Main()
    {
        EmployeeSalary salaryCalculator = new EmployeeSalary();

        EmployeeRole role = EmployeeRole.Developer;
        Console.WriteLine($"Employee role: {role}");
        Console.WriteLine($"Salary: ${salaryCalculator.CalculateSalary(role)}");
    }
}
