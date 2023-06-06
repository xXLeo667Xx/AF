using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char resposta;


            do
            {

                float num1, num2;
                char op;

                Console.WriteLine("entre com o operador: +, -, /, *: ");
                op = char.Parse(Console.ReadLine());

                Console.WriteLine("entre com dois valores: ");
                num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (op)
                {
                    case '+':
                        Console.Write(num1 + " + " + num2 + "=");
                        float soma1 = num1 + num2;
                        Console.WriteLine(soma1);
                        break;

                    case '-':
                        Console.Write(num1 + "-" + num2 + "=");
                        float soma2 = num1 - num2;
                        Console.WriteLine(soma2);
                        break;

                    case '/':
                        Console.WriteLine(num1 + "/" + num2 + "=");
                        float soma3 = num1 / num2;
                        Console.WriteLine(soma3);
                        break;

                    case '*':
                        Console.WriteLine(num1 + "*" + num2 + "=");
                        float soma4 = num1 * num2;
                        Console.WriteLine(soma4);
                        break;

                    default:
                        Console.WriteLine("operador errado, insira operador correto");
                        break;
                }
                Console.WriteLine("deseja fazer a conta de novo(S/N): ");
                resposta = char.Parse(Console.ReadLine());
            }
            while (resposta == 's' || resposta == 'S');
        }
    }
}