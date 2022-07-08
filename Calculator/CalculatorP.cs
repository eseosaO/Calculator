using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    
    class CalculatorP
    {
        static void Main(string[] args)
        {
            /*double a = 42;
            double b = 119;
            double c = a + b;
            Console.WriteLine($"Result from calculation is : {c}");
            Console.ReadKey();*/

            //Declare variables and initialize with zero
            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("-------------------------\n");

            //User asked to enter first number
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            //User asked to enter second number
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            //To Ask user for an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.Write("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine()) 
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while(num2 == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the Calculator console app ...");
            Console.ReadKey();


        }
    }

}




