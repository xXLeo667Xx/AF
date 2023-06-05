using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double num;

            Console.WriteLine("digite um numero intero psitivo:");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("os primeiros numeros " + num + " numeros pares são:");

            for (int i = 2; i <= num * 2; i += 2)
            {
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture) + " ");
            }

        }   

    }
}