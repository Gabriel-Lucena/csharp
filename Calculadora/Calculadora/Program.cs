using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            string operacao;

            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            Inicio:

            Console.WriteLine("Digite a operação: ");
            Console.WriteLine("+ -> soma");
            Console.WriteLine("- -> subtração");
            Console.WriteLine("* -> multiplicação");
            Console.WriteLine("/ -> divisão");
            operacao = Console.ReadLine();

            switch (operacao)
            {
                default:
                    goto Inicio;

                case "+":

                    Console.WriteLine("O resultado é: " + numero1 + numero2);

                    break;

                case "-":

                    Console.WriteLine("O resultado é: " + (numero1 - numero2));

                    break;

                case "*":

                    Console.WriteLine("O resultado é: " + numero1 * numero2);

                    break;

                case "/":
                
                    Console.WriteLine("O resultado é: " + numero1 / numero2);

                    break;
            }

            Novamente:

            Console.WriteLine("Deseja calcular novamente? (s / n)");
            string novamente = Console.ReadLine();

            if (novamente == "S" || novamente == "s")
            {
                goto Inicio;
            } else if ( novamente == "N" || novamente == "n")
            {
                goto Final;
            } else
            {
                goto Novamente;
            }

            Final:;

        }
    }
}
