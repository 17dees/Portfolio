// Employee base class.
using System;

public class Employee
{
    private string _firstName; // Employee's first name
    private string _lastName;  // Employee's last name
    private string _ssn;       // Employee's SSN

    public string FirstName
    {
        // Precondition:  None
        // Postcondition: The employee's first name is returned
        get { return _firstName; }

        // Precondition:  None
        // Postcondition: The employee's first name is set to the specified value
        set { _firstName = value; }
    }

    public string LastName
    {
        // Precondition:  None
        // Postcondition: The employee's last name is returned
        get { return _lastName; }

        // Precondition:  None
        // Postcondition: The employee's last name is set to the specified value
        set { _lastName = value; }
    }

    public string SocialSecurityNumber
    {
        // Precondition:  None
        // Postcondition: The employee's SSN is returned
        get { return _ssn; }

        // Precondition:  None
        // Postcondition: The employee's SSN is set to the specified value
        set { _ssn = value; }
    }

    // Precondition:  None
    // Postcondition: The employee is constructed with the specified name and SSN
    public Employee(string first, string last, string ssn)
    {
        FirstName = first;
        LastName = last;
        SocialSecurityNumber = ssn;
    }

    // virtual method to be overridden by derived classes
    // Precondition:  None
    // Postcondition: The employee's earnings are calculated and returned
    public virtual double CalcEarnings()
    {
        return 0; // placeholder implementation here
    }

    // Precondition:  None
    // Postcondition: The employee's information is returned as a formatted string
    public override string ToString()
    {
        return $"{FirstName} {LastName}{Environment.NewLine}"+
            $"social security number: {SocialSecurityNumber}";
    }
}
