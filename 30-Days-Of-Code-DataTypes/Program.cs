using System;

namespace _30_Days_Of_Code_DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declartion for an Integer, double and a string
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            //Second varible declaration for an Integer, double and a string
            int i2;
            double d2;
            string s2;

            //Converting user input into a Integer, double and a string
            i2 = int.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
            s2 = Console.ReadLine();

            // Prints the sum in the console output for the integer.
            Console.WriteLine(String.Format("{0:0}", i + i2));

            // Prints the sum in the console output for the double.
            Console.WriteLine(String.Format("{0:0:0}", d + d2));

            // Prints the sum in the console output for the string.
            Console.WriteLine(s + s2);

        }
    }
}
