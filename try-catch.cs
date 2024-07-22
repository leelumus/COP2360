using System;

namespace DivisionWithExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user for input
            Console.Write("Input the first number: ");
            string input1 = Console.ReadLine();
            
            Console.Write("Input the second number: ");
            string input2 = Console.ReadLine();

            try
            {
                // Convert strings to integers
                int dividend = int.Parse(input1);
                int divisor = int.Parse(input2);

                // Perform division
                int result = dividend / divisor;

                // Print the result
                Console.WriteLine($"Here's the result of dividing {dividend} by {divisor} is: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error - Please enter valid integer numbers.");
            }
            catch (DivideByZeroException)
            {
                // Handle division by zero exception
                Console.WriteLine("Error - Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                Console.WriteLine($"An unexpected error occurred - {ex.Message}");
            }
        }
    }
}
