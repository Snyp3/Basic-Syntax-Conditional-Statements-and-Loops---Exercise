using System;

namespace P01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());

            if (years >= 0 && years <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (years >= 3 && years <= 13)
            {
                Console.WriteLine("child");
            }
            else if (years >= 14 && years <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (years >= 20 && years <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (years >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
