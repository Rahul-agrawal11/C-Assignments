using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace UsingMyLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Number I:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Number II:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose Operation(1 to 5):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Addition: {Calculator.Add(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"Subtraction: {Calculator.Subtract(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"Multiplication: {Calculator.Multiply(num1, num2)}");
                        break;
                    case 4:
                        Console.WriteLine($"Division: {Calculator.Division(num1, num2)}");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input was not a valid integer. Please enter numeric values.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input value was too large or too small for an Int32.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}