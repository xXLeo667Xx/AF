//colocando uma blibioteca
using System;
using System.Globalization;
// nome do programa
namespace Course
{
    public class Program//classe programa
    {
       
       
          //um programa para calculo de soma 
          public static int Soma(int a, int b)
            {
                int resultado;

                resultado = a + b;

                return resultado;   
            }
           public static double Divi(double a, double b)//um programa para calculo de divizão
            {
                double resulatdo;

                resulatdo = a / b;

                return resulatdo;
            }

           public static int Sulb(int a, int b)//um programa para calculo de sulbitração
            {
                int resultado;

                resultado = a - b;

                return resultado;
            }

            public static int Mult(int a, int b)//um programa para calculo de multiplicação
            {
                int resultado;

                resultado = a * b;

                return resultado;
            }

        public static void Main(string[] args)// programa principal 
        {
            //variaveis como valores ja atribuidos 
            int a, b;
            int soma = Soma(5, 7);
            int sulb = Sulb(5, 7);
            double divi = Divi(5, 3);
            int mult = Mult(5, 7);
            //interface onde mostrara o calculo das contas 
            Console.WriteLine(soma.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(divi.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine(sulb.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(mult.ToString( CultureInfo.InvariantCulture));

        }
    }
}
