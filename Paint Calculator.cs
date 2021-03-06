// Grading ID: J7186
// Program 1
// Due Date: 9/23/19
// Course Section: 01
// Calculates the number of gallons of paint based on room size
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Handy-Dandy Paint Estimator");

            double WallLength; // declares the WallLength variable
            double WallHeight; // declares the WallHeight variable
            const int DoorSize = 21; // declares the DoorSize constant
            const int WindowSize = 12; // declares the WindowSize constant
            const int PaintCoverage = 400; // declares the PaintCoverage constant
            int Doors; // declares the door variable
            int Windows; // declares the window variable
            int CoatsofPaint; // declares the coats of paint variable
            double ExactGallons; // declares the gallons variable
            double RealGallons; // declares the amount of gallons to but variable

            Console.Write("Enter the total length of all walls(in feet):"); // Asks for the wall length
            WallLength = double.Parse(Console.ReadLine()); // Assigns the value to the variable

            Console.Write("Enter the height of the walls(in feet):"); // Asks for the heigth of the walls
            WallHeight = double.Parse(Console.ReadLine()); // Assigns the value to the variable

            Console.Write("Enter the number of doors(integer):"); // Asks for number of doors
            Doors = int.Parse(Console.ReadLine()); // Assigns the value to the variable

            Console.Write("Enter the number of windows(integer):"); // Asks for number of windows
            Windows = int.Parse(Console.ReadLine()); // Assigns the value to the variable

            Console.Write("Enter the number of coats of paint(integer):"); // Asks for number of coats of paint
            CoatsofPaint = int.Parse(Console.ReadLine()); // Assigns the value to the varaible

            ExactGallons = (((WallLength * WallHeight) - (WindowSize * Windows) - (DoorSize * Doors))*CoatsofPaint) / PaintCoverage; // Calculates the exact amount of gallons needed to the decimal
            RealGallons = (int)Math.Ceiling(ExactGallons); // Calculates the amount of gallons to buy

            Console.WriteLine("You need a minimum of {0} gallons of paint", ExactGallons); //Outputs the exact gallons
            Console.WriteLine("You'll need to buy {0} gallons, though", RealGallons); // Outputs the amount of gallons to buy
        }
    }
}
