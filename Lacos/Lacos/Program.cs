using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region While

            //int valor = 0;

            //while (valor < 10)
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;
            //}

            #endregion

            #region Do-while

            //int valor = 15;

            //do
            //{
            //    Console.WriteLine("O valor é " + valor);
            //    valor++;

            //} while (valor < 10);

            #endregion

            #region For

            //for (int i = 0, j = 10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("i = " + i + " | j = " + j);
            //}

            #endregion

            #region foreach

            string[] nomes = { "A", "B", "C", "D"};

            foreach(var nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            #endregion

            Console.ReadKey();
        }
    }
}
