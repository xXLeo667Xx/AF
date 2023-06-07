//incluido blibioteca
using System;
using System.Globalization;
//nome do programa
namespace Course
{
    public class Program //classe programa
    {
        public static void Main(string[] args)//programa principal 
        {
            double num;//colocando variavel 
            //interface de usuario para colocar e atribuir um numero positivo a variavel num
            Console.WriteLine("digite um numero intero psitivo:");
            num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //interface aonde mostrara todos os primeiros numeros pares na quantidade colocada pelo usuario
            Console.WriteLine("os primeiros numeros " + num + " numeros pares são:");
            //for apnde passa por cada numero fazendo repetir
            for (int i = 2; i <= num * 2; i += 2)
            {
                Console.WriteLine(i.ToString(CultureInfo.InvariantCulture) + " ");//interfce onde mostrara cada numero 
            }

        }   

    }
}
