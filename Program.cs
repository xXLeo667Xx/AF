using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num, i = 1;

            Console.WriteLine("digite um numero intero positivo:");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (i <= num)
            {
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture) + " ");

                i++;
            }
        }   

    }
}