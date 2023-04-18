using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int valor = 5;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{

            //    Console.WriteLine("Condição alternativa 1");

            //} else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //} else
            //{
            //    Console.WriteLine("Condição alternativa final");
            //}

            //int numero = 10;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0 )
            //    {
            //        Console.WriteLine(" e também é par.");

            //    } else
            //    {

            //        Console.WriteLine(" mas não é par.");
            //    }

            //}

            int numero = 5;
            string mensagem = "";

            // Condição ? true : false;

            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            mensagem = numero > 5 ? "Maior que 5" : numero < 5 ? "Menor que 5" : "Igual a 5";

            if (numero > 5)
            {
                // maior

            } else if (numero < 5)
            {
                // menor
            } else
            {
                // igual
            }

            //if ( numero > 5)
            //{
            //    mensagem = "Maior que 5.";
            //} else
            //{
            //    mensagem = "Menor que 5.";
            //}

            Console.WriteLine(numero > 5 ? "Maior que 5" : numero < 5 ? "Menor que 5" : "Igual a 5");

            Console.ReadKey();
        }
    }
}
