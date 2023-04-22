using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor,ant2 = 0, ant1 = 1, aux, aux2, quantidade;

            Console.Write("Digite a quantidade de números da sequência: ");
            quantidade =  int.Parse(Console.ReadLine());



            for (int i = 0; i < quantidade; i++)
            {
                    valor = ant2 + ant1;
                if (i == 0)
                {
                    Console.Write(ant2 + ", ");
                }
                else if (i == 1) 
                {
                    Console.Write(ant1 + ", ");
                }
                else
                {
                    aux2 = ant1;
                    aux = valor;
                    valor = ant2 + ant1;
                    ant1 = aux;
                    ant2 = aux2;
                    

                    if ( quantidade - 1 == i)
                    {
                        Console.Write(valor);
                    } else
                    {
                        Console.Write(valor + ", ");
                    }
                    
                }

            }

            Console.ReadKey();
        }
    }
}
