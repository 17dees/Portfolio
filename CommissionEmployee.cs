// Grading ID: j7186 
using System;

// Make the following changes/additions:
// 1. CommissionEmployee IS-A Employee
// 2. Add public double property named GrossSales with get and set accessors
//    for the new field. Be sure to validate the value being set to ensure
//    that it is non-negative. If the value is negative, then set the gross
//    sales to 0.
// 3. Add public double property named CommissionRate with get and set accessors
//    for the new field. Be sure to validate the value being set to ensure
//    that it is between 0 and 1 (inclusive). If the value is not, then set
//    the commission rate to 0.05 .
// 4. Add a constructor that initializes the commission employee with the
//    given values for first name, last name, social security number,
//    gross sales, and commission rate.
// 5. Override method CalcEarnings so that it calculates the employee’s earnings
//    by multiplying the gross sales times the commission rate. The method returns
//    a double and accepts no parameters. Remember, you must use keyword override.
// 6. Override the ToString method to return a String that will display all
//    data fields neatly, returning a string that includes the employee's first name,
//    last name, social security number, gross sales (currency formatted), and commission
//    rate (percent formatted). Let the base class do as much of the work as possible. The
//    method returns a string and accepts no parameters. Remember, you must use keyword
//    override. You should use base.ToString() in your implementation.
public class CommissionEmployee : Employee
{
    double grossSales;
    double comissionRate;

public double GrossSales
{
    get
    {
        return grossSales;
    }
    set
    {
        if (value >= 0)
            grossSales = value;
        else
            grossSales = 0;
    }
}
    public double ComissionRate
    {
        get
        {
            return comissionRate;
        }
        set
        {
            if (value >= 0 && value <= 1)
                comissionRate = value;
            else
                comissionRate = 0.05;
        }
     }
    public CommissionEmployee(string first, string last, string ssn, double TotalSales, double ComishRate)
        : base (first, last, ssn)
    {
        GrossSales = TotalSales;
        ComissionRate = ComishRate;
    }
    public override double CalcEarnings()
    {
        return GrossSales * ComissionRate;
    }
    public override string ToString()
    {
        return $"Comissioned Employee: {base.ToString()}{Environment.NewLine}" +
             $"Gross Sales: {GrossSales}" + $"Comission Rate: {ComissionRate}";
    }
}
       
