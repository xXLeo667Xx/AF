using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
       
       

          public static int Soma(int a, int b)
            {
                int resultado;

                resultado = a + b;

                return resultado;   
            }
           public static double Divi(double a, double b)
            {
                double resulatdo;

                resulatdo = a / b;

                return resulatdo;
            }

           public static int Sulb(int a, int b)
            {
                int resultado;

                resultado = a - b;

                return resultado;
            }

            public static int Mult(int a, int b)
            {
                int resultado;

                resultado = a * b;

                return resultado;
            }

        public static void Main(string[] args)
        {
            int a, b;
            int soma = Soma(5, 7);
            int sulb = Sulb(5, 7);
            double divi = Divi(5, 3);
            int mult = Mult(5, 7);

            Console.WriteLine(soma.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(divi.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine(sulb.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(mult.ToString( CultureInfo.InvariantCulture));

        }




    }
}