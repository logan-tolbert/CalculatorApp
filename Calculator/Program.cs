using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Calculator
{   /// <summary>
/// A simple command line calculator project
///   NOTE: CODE that has been commented out does not function properly at this time
///   
///     Author: Logan Tolbert
/// </summary>
    internal class Program
    {
        // ADD
        //public static sbyte add(sbyte a, sbyte b)
        //{
        //    return (sbyte)(a + b);
        //}

        //public static byte add(byte x, byte y)
        //{
        //    return (byte)(x + y);
        //}
        
        //public static short add(short x, short y) 
        //{
        //    return (short)(x + y); 
        //}

        public static void add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"\n{x} + {y} = {sum}");
        }

        //public static uint add(uint x, int y)
        //{
        //    return (uint)(x + y);
        //}


        //public static long add (long x, long y)
        //{
        //    return x + y;
        //}


        //public static decimal add(decimal x, decimal y)
        //{
        //    return (decimal)x + y;
        //}


        //public static double add(double x, double y)
        //{
        //    return x + y;
        //}


        //public static float add(float x, float y) 
        //{
        //    return x + y; 
        //}   


        //public static string add(string x, string y)
        //{
        //    return x + y;
        //}


        //public static int add(params int[] values)
        //{
        //    int sum = 0;
        //    foreach (int value in values)
        //    {
        //        sum += value;
        //    }
        //    return sum;
        //}




        // SUBTRACT
        public static void subtract(int x, int y) 
        {
            int difference = x - y;
            Console.WriteLine($"\n{x} - {y} = {difference}");
        }


        // MULTIPLY
        public static void multiply(int x, int y)
        {
            int product = x + y;
            Console.WriteLine($"\n{x} * {y} = {product}");
        }


        // DIVIDE
        public static void divide(int x, int y)
        {
            double quotient = (double) x / y;
            Console.WriteLine($"\n{x} / {y} = {quotient}");
        }


        // REMAINDER
        public static void remainder(int x, int y)
        {
            int sum = x % y;
            Console.WriteLine($"\n{x} % {y} = {sum}");
        }


        static void Main(string[] args)
        {

            // Console Theme Control
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.BackgroundColor = ConsoleColor.Black; 
            Console.Clear();


            Int32 num1 = 0;
            Int32 num2 = 0;
            var menuItem = "";

            Console.WriteLine("\t- Console Calculator -");
            Console.WriteLine("\t\tAlpha");
            Console.WriteLine("Type the letter to run the desired function and press ENTER.\n");
            Console.WriteLine("Functions");
            Console.WriteLine("----------");
            Console.WriteLine("A) ADD");
            Console.WriteLine("S) SUBTRACT");
            Console.WriteLine("M) MULTIPLY");
            Console.WriteLine("D) DIVIDE");
            Console.WriteLine("R) REMAINDER");
            Console.WriteLine(Environment.NewLine);

            Console.Write(">>> ");
            menuItem = Console.ReadLine();

            if (menuItem == null)
            {
                return;
            }

            switch (menuItem)
            {
                case ("a" or "A"):// ADD
                    Console.WriteLine("Enter your two numbers and press ENTER.");
                    Console.Write(">>> ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write($">>> {num1} + ");
                    num2 = int.Parse(Console.ReadLine());


                    add(num1, num2);
                    break;
                case ("s" or "S"):// SUBTRACT
                    Console.WriteLine("Type number and press ENTER.");
                    Console.Write(">>> ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write($">>> {num1} - ");
                    num2 = int.Parse(Console.ReadLine());

                    subtract(num1, num2);
                    break;


                case ("m" or "M"):// MULTIPLY
                    Console.WriteLine("Type number and press ENTER.");
                    Console.Write(">>> ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write($">>> {num1} * ");
                    num2 = int.Parse(Console.ReadLine());

                    multiply(num1, num2);
                    break;


                case ("d" or "D"):// DIVIDE
                    Console.WriteLine("Type number and press ENTER.");
                    Console.Write(">>> ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write($">>> {num1} / ");
                    num2 = int.Parse(Console.ReadLine());

                    divide(num1, num2);
                    break;


                case ("r" or "R"):// MODULUS/REMAINDER
                    Console.WriteLine("Type number and press ENTER.");
                    Console.Write(">>> ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write($">>> {num1} % ");
                    num2 = int.Parse(Console.ReadLine());

                    remainder(num1, num2);
                    break;


                default:
                    Console.WriteLine("Function not currently available");
                    break;
            
            }
        }
    }
}
