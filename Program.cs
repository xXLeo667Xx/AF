using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num, i = 1;

            do
            {

                Console.WriteLine("digite um numero de 1 a 10 ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            while (num < 1 || num > 10);
               
                    Console.WriteLine("voce digitou o numero " + num +".");

                
            
        }   

    }
}