// colocando biblioteca
using System;
using System.Globalization;
//nome do programa
namespace Course
{
    public class Program//classe programa
    {
        public static void Main(string[] args)//programa principal 
        {
            // variaveis de numero e de i
            double num, i = 1;
             //do usado para repetir numeros ate um determinado quartidade aonde vc defini
            do
            {
                //interface de usuario para atribuir um valor a num
                Console.WriteLine("digite um numero de 1 a 10 ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            // while usado para repetir o numero que escrevel ate chegar a 10 
            while (num < 1 || num > 10);
                   //interface onde mostrara todos os numeros
                    Console.WriteLine("voce digitou o numero " + num +".");

                
            
        }   

    }
}
