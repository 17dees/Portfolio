// HourlyEmployee class that extends Employee.
using System;

public class HourlyEmployee : Employee
{
    private double _wage; // wage per hour
    private int _hours;    // hours worked for the week

    // OK for constants to be public... they can't change
    public const int MAX_STANDARD_HOURS = 40; // Normal hours in week
    public const double OVERTIME_RATE = 1.5;  // Overtime rate
    public const int MAX_WEEK_HOURS = 168;    // Max hours in week

    public double Wage
    {
        // Precondition:  None
        // Postcondition: The employee's wage per hour is returned
        get
        {
            return _wage;
        }

        // Precondition:  value >= 0
        // Postcondition: The employee's wage per hour is set to the specified value
        //                or 0 if invalid
        set
        {
            if (value >= 0) // validation
                _wage = value;
            else
                _wage = 0; // Safe default
        }
    }

    public int Hours
    {
        // Precondition:  None
        // Postcondition: The employee's hours worked is returned
        get
        {
            return _hours;
        }

        // Precondition:  0 <= value <= MAX_WEEK_HOURS
        // Postcondition: The employee's hours worked is set to the specified value
        //                or 0 if invalid
        set
        {
            if (value >= 0 && value <= MAX_WEEK_HOURS) // validation
                _hours = value;
            else
                _hours = 0; // Safe default
        }
    }

    // Precondition:  hourlyWage >= 0, hoursWorked >=0
    // Postcondition: The employee is constructed with the specified name, SSN, wage per hour, and
    //                hours worked
    public HourlyEmployee(string first, string last, string ssn, double hourlyWage, int hoursWorked)
        : base(first, last, ssn) // Calls base class constructor
    {
        Wage = hourlyWage; // validate hourly wage via property
        Hours = hoursWorked; // validate hours worked via property
    }

    // Override virtual method in Employee, replacing its body
    // Precondition:  None
    // Postcondition: The employee's earnings are calculated and returned
    public override double CalcEarnings()
    {
        if (Hours <= MAX_STANDARD_HOURS) // No overtime                          
            return Wage * Hours;
        else // Overtime
            return (MAX_STANDARD_HOURS * Wage) + ((Hours - MAX_STANDARD_HOURS) * Wage * OVERTIME_RATE);
    }

    // Precondition:  None
    // Postcondition: The employee's information is returned as a formatted string
    public override string ToString()
    {
        // base.ToString() calls version from Employee to help produce formatted string
        return $"hourly employee: {base.ToString()}{Environment.NewLine}" +
            $"hourly wage: {Wage:C} ; hours worked: {Hours}";
    }                                         
}