// Employee hierarchy test application.
// Grading ID: 
using System;
using static System.Console;

public class PayrollSystemTest
{
    public static void Main(string[] args)
    {
        // create derived class objects
        SalariedEmployee salariedEmployee1 =
           new SalariedEmployee("John", "Smith", "111-11-1111", 800.00); // Salaried
        HourlyEmployee hourlyEmployee1 =
           new HourlyEmployee("Karen", "Price", "222-22-2222", 46.75, 40); // Hourly
        SalariedEmployee salariedEmployee2 =
           new SalariedEmployee("Sue", "Jones", "333-33-3333", 1000.00); // Salaried
        HourlyEmployee hourlyEmployee2 =
           new HourlyEmployee("Bob", "Lewis", "444-44-4444", 45.25, 45); // Hourly

        CommissionEmployee comishEmployee1 =
              new CommissionEmployee("Jay", "Johnson", "555-55-5555", 35000, 0.075);
        CommissionEmployee comishEmployee2=
            new CommissionEmployee("Mary", "Mathis", "666-66-6666", 40000, 0.08);

        // Add your 2 CommissionEmployee objects to array below *******************************
        // create Employee array
        Employee[] employees = { salariedEmployee1, hourlyEmployee1,
            salariedEmployee2, hourlyEmployee2, comishEmployee1, comishEmployee2 };

        WriteLine("Employees processed polymorphically:\n");

        // generically process each element in array employees
        foreach (Employee currentEmployee in employees)
        {
            WriteLine(currentEmployee); // invokes ToString implicitly
            WriteLine($"earned {currentEmployee.CalcEarnings():C}");
            WriteLine();
        } // end foreach
    } // end Main
} // end class PayrollSystemTest
