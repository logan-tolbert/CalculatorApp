using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Calculator
{   /// <summary>
/// A simple command line calculator project
///     Author: Logan Tolbert
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            var foreground = "Green";
            var background = "Black";
            var menuItem = "";
            bool endProgram = false;
            int num1 = 0;
            int num2 = 0;

            ConsoleTheme(foreground, background);
            Console.WriteLine("\t- Console Calculator -");
            Console.WriteLine("\t\tAlpha");
            Console.WriteLine("Type the letter to run the desired function and press ENTER.\n");

            do
            {
                // Menu
                
                Console.WriteLine("Functions");
                Console.WriteLine("----------");
                Console.WriteLine("A) ADD");
                Console.WriteLine("S) SUBTRACT");
                Console.WriteLine("M) MULTIPLY");
                Console.WriteLine("D) DIVIDE");
                Console.WriteLine("R) REMAINDER");

                Console.WriteLine("Q) QUIT");
                Console.WriteLine(Environment.NewLine);

                Console.Write(">>> ");
                menuItem = Console.ReadLine();

                if (menuItem == null)
                {
                    Console.WriteLine("Please enter a valid menu option.");
                }
                else if (menuItem == "q" || menuItem == "Q")
                {
                    Console.WriteLine("Thanks for using Console Caluculator! Goodbye.");
                    endProgram = true;
                    break;
                }

                switch (menuItem)
                {
                    case ("a" or "A"):// ADD
                        Console.WriteLine("Enter your two numbers and press ENTER.");
                        Console.Write(">>> ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write($">>> {num1} + ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine(Add(num1, num2));
                        break;
                    case ("s" or "S"):// SUBTRACT
                        Console.WriteLine("Type number and press ENTER.");
                        Console.Write(">>> ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write($">>> {num1} - ");
                        num2 = int.Parse(Console.ReadLine());
                        Subtract(num1, num2);
                        break;
                    case ("m" or "M"):// MULTIPLY
                        Console.WriteLine("Type number and press ENTER.");
                        Console.Write(">>> ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write($">>> {num1} * ");
                        num2 = int.Parse(Console.ReadLine());
                        Multiply(num1, num2);
                        break;
                    case ("d" or "D"):// DIVIDE
                        Console.WriteLine("Type number and press ENTER.");
                        Console.Write(">>> ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write($">>> {num1} / ");
                        num2 = int.Parse(Console.ReadLine());
                        Divide(num1, num2);
                        break;
                    case ("r" or "R"):// MODULUS/REMAINDER
                        Console.WriteLine("Type number and press ENTER.");
                        Console.Write(">>> ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write($">>> {num1} % ");
                        num2 = int.Parse(Console.ReadLine());
                        Modulus(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Function not available");
                        break;

                }
            } while ((menuItem != "q") || (menuItem != "Q"));
        }
        // Console Theme
        public static void ConsoleTheme(string Foreground, string Background)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        // ADD
        public static int Add(int x, int y)
        {
            var sum = x + y;
            Console.WriteLine($"\n{x} + {y} = {sum}");
            return sum;
        }

        public static int Add(int x, int y, int z)
        {
            var sum = x + y + z;
            Console.WriteLine($"\n{x} + {y} + {z} = {sum}");
            return sum;
        }

        public static double Add(double x, double y)
        {
            var sum = x + y;
            Console.WriteLine($"\n{x} + {y} = {sum}");
            return sum;
        }

        public static double Add(double x, double y, double z)
        {
            var sum = x + y + z;
            Console.WriteLine($"\n{x} + {y} + {z} = {sum}");
            return x + y + z;
        }


        // SUBTRACT
        public static void Subtract(int x, int y)
        {
            int difference = x - y;
            Console.WriteLine($"\n{x} - {y} = {difference}");
        }


        // MULTIPLY
        public static void Multiply(int x, int y)
        {
            int product = x + y;
            Console.WriteLine($"\n{x} * {y} = {product}");
        }


        // DIVIDE
        public static void Divide(int x, int y)
        {
            double quotient = (double)x / y;
            Console.WriteLine($"\n{x} / {y} = {quotient}");
        }


        // MODULUS
        public static void Modulus(int x, int y)
        {
            int remainder = x % y;
            Console.WriteLine($"\n{x} % {y} = {remainder}");
        }


    }
}
