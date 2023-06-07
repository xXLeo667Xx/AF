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
            char resposta;//variavel de rspostar que serve par o final do programa


            do//do codigo de repetiçao 
            {
                //variaveis de falores e de sinais   
                float num1, num2;
                char op;
                //interface de usuario aonde atribuira o valor do sinal da conta e dos dois numeros da conta
                Console.WriteLine("entre com o operador: +, -, /, *: ");
                op = char.Parse(Console.ReadLine());

                Console.WriteLine("entre com dois valores: ");
                num1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                num2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //switch caso não seja + ele colocara todas as opicoes possiveis e suas ações caso caiam elas
                switch (op)
                {
                        //calculo matematico caso o sinal for +
                    case '+':
                        Console.Write(num1 + " + " + num2 + "=");
                        float soma1 = num1 + num2;
                        Console.WriteLine(soma1);
                        break;
                    //calculo matematico caso o sinal for -
                    case '-':
                        Console.Write(num1 + "-" + num2 + "=");
                        float soma2 = num1 - num2;
                        Console.WriteLine(soma2);
                        break;
                    //calculo matematico caso o sinal for /
                    case '/':
                        Console.WriteLine(num1 + "/" + num2 + "=");
                        float soma3 = num1 / num2;
                        Console.WriteLine(soma3);
                        break;
                    //calculo matematico caso o sinal for *
                    case '*':
                        Console.WriteLine(num1 + "*" + num2 + "=");
                        float soma4 = num1 * num2;
                        Console.WriteLine(soma4);
                        break
                     //e se nenhuma acima for ele mostrara uma interface falando que vc escreveu o sinal errado
                    default:
                        Console.WriteLine("operador errado, insira operador correto");
                        break;
                }
                //interface aonde mpedirar para repetir caso queire
                Console.WriteLine("deseja fazer a conta de novo(S/N): ");
                resposta = char.Parse(Console.ReadLine());
            }
            //caso vc escreva que ss ele repetirar se uma dessas opicoes aparecerem 
            while (resposta == 's' || resposta == 'S');
        }
    }
}
