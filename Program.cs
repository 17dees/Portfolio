// Grading ID: J7186
// Due Date: 10/20/2019
// Lab 5 
// CIS 199-01
// This lab displays a pattern of stars
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;

            Console.WriteLine("Pattern A"); // This displays the label for the group of stars
            for (int row = 1; row <= MAX_ROWS; row++) // Sets the parameters for the pattern
            {
                for (int star = 1; star <= row; star++) // Sets the parameters for the pattern
                    Console.Write("*"); // Displays the output for the stars
                Console.WriteLine();

            }
            Console.WriteLine("Pattern B"); // This displays the label for the group of stars
            for (int row = 1; row <= MAX_ROWS; row++) // Sets the parameters for the pattern
            {
                for (int star = 10; star >= row; star--) // Sets the parameters for the pattern
                    Console.Write("*"); // Displays the output for the stars
                Console.WriteLine();
            }
            Console.WriteLine("Pattern C"); // This displays the label for the group of stars

            for (int row = 1; row <= MAX_ROWS; row++) // Sets the parameters for the pattern
            {
                for (int spaces = 2; spaces <= row; spaces++) // Sets the parameters for the pattern
                    Console.Write(" "); // Displays the output for the spaces

                for (int star = 10; star >= row; star--) // Sets the parameters for the pattern
                    Console.Write("*"); // Displays the output for the stars
                Console.WriteLine();
            }
            for (int row =1; row <= MAX_ROWS; row++) // Sets the parameters for the pattern
            {
                for (int spaces = 1; spaces <= MAX_ROWS - row; spaces++) // Sets the parameters for the pattern
                    Console.Write(" "); // Displays the output for the spaces
                for (int star = 1; star <= row; star++) // Sets the parameters for the pattern
                    Console.Write("*"); // Displays the output for the stars
                Console.WriteLine();
            }
        }

    }
}
