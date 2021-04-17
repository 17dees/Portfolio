// T6181

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make the following changes/additions:
// 1. PieceWorkerEmployee IS-A Employee
// 2. Add public decimal property named Wage with get and set accessors
//    for the new field. Be sure to validate the value being set to ensure
//    that it is non-negative. If not, throw an ArgumentOutOfRangeException.
// 3. Add public int property named Pieces with get and set accessors for
//    the new field. Be sure to validate the value being set to ensure that
//    it is non-negative. If not, throw an ArgumentOutOfRangeException.
// 4. Add a constructor that initializes the piece worker employee with the
//    given values for first name, last name, social security number,
//    wage per piece, and number of pieces produced.
// 5. Override method Earnings so that it calculates the employee’s earnings
//    by multiplying the wage per piece times the number of pieces produced.
// 6. Override the ToString method to return a String that will display all
//    data fields neatly. You must use base.ToString() in your implementation.
public class PieceWorkerEmployee 
{
    public decimal Wage;
    private int Pieces;
    public PieceWorkerEmployee(string firstName, string lastname, string socialSecurityNumber, decimal wagePerPiece,
        decimal totalPieces)
    {
        Wage = wagePerPiece;
        Pieces = totalPieces;
    }
public decimal Wage
    {
        get
        {
            return wagePerPiece;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(WeeklySalary)} must be >= 0");
            }

            wagePerPiece = value;
        }
    }
public int Pieces
    {
        get
        {
            return totalPieces;
        }
        set
        {
            if (value < 0) // validation
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                   value, $"{nameof(Pieces)} must be >= 0");
            }

            totalPieces = value;
        }
    }
}

