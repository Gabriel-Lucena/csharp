using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Vetores

            //int numero = 0;

            //int[] numeros = new int[5] { 1, 2, 3, 4, 5 };

            //string[] nomes = new string[3];
            //nomes[0] = "A";
            //nomes[1] = "B";
            //nomes[2] = "C";

            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(nomes[0] + nomes[1] + nomes[2]);

            #endregion

            #region Matrizes

            int[,] numeros = new int[2, 3];

            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("|" + numeros[0, 0] + "|");
            Console.Write("|" + numeros[0, 1] + "|");
            Console.Write("|" + numeros[0, 2] + "|");

            Console.WriteLine();

            Console.Write("|" + numeros[1, 0] + "|");
            Console.Write("|" + numeros[1, 1] + "|");
            Console.Write("|" + numeros[1, 2] + "|");

            Console.WriteLine();


            string[,] nomes =
            {
                { "A", "B", "C" },
                { "B", "C", "D" },

            };

            #endregion

            Console.WriteLine(nomes[0, 1]);
            Console.ReadKey();
        }
    }
}
