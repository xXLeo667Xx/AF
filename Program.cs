//colocando biblioteca
using System;
using System.Globalization;
//nome do programa
namespace Course
{
    public class Program//classe programa
    {
        public static void Main(string[] args)//programa principal
        {
            double num, i = 1;//variaveis 
             //interface de usuario aonde atribuira um valor a num 
            Console.WriteLine("digite um numero intero positivo:");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
              //codigo aonde repetirar o numero que eu colocar 
            while (i <= num)
            {
                //interface aonde mostrara o numero
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture) + " ");
                
                i++;
            }
        }   

    }
}
