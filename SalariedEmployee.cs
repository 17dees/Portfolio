// SalariedEmployee class that extends Employee.
using System;

public class SalariedEmployee : Employee
{
    private double _weeklySalary; // Weekly salary

    public double WeeklySalary
    {
        // Precondition:  None
        // Postcondition: The employee's weekly salary is returned
        get
        {
            return _weeklySalary;
        }

        // Precondition:  value >= 0
        // Postcondition: The employee's weekly salary is set to the specified value
        //                or 0 if invalid
        set
        {
            if (value >= 0) // validation
                _weeklySalary = value;
            else
                _weeklySalary = 0; // Safe default
        }
    }

    // Precondition:  salary >= 0
    // Postcondition: The employee is constructed with the specified name, SSN, and
    //                weekly salary
    public SalariedEmployee(string first, string last, string ssn, double salary)
        : base(first, last, ssn) // Calls base class constructor
    {
        WeeklySalary = salary; // validate salary via property
    }

    // Override virtual method in Employee, replacing its body
    // Precondition:  None
    // Postcondition: The employee's earnings are calculated and returned
    public override double CalcEarnings()
    {
        return WeeklySalary;
    }         

    // Precondition:  None
    // Postcondition: The employee's information is returned as a formatted string
    public override string ToString()
    {
        // base.ToString() calls version from Employee to help produce formatted string
        return $"salaried employee: {base.ToString()}{Environment.NewLine}" +
            $"weekly salary: {WeeklySalary:C}";
    }                                    
}
