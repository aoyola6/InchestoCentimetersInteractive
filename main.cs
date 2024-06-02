using System;

namespace InchesToCentimetersInteractive
{
    class Program
    {
        // Declare a named constant for the conversion factor
        const double CentimetersPerInch = 2.54;

        static void Main(string[] args)
        {
            // Prompt the user to enter a measurement in inches
            Console.Write("Enter a measurement in inches: ");
            string userInput = Console.ReadLine();

            // Attempt to parse the user input to a double
            if (double.TryParse(userInput, out double inches))
            {
                // Calculate the equivalent measurement in centimeters
                double centimeters = inches * CentimetersPerInch;

                // Display the measurement in both inches and centimeters
                Console.WriteLine($"{inches} inch(es) is approximately {centimeters} centimeter(s).");
            }
            else
            {
                // Inform the user if the input was not a valid number
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
    }
}




    