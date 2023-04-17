using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Operadores Matemáticos

            //int num1 = 10;
            //int num2 = 2;

            ////int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);

            #endregion

            #region Precedência de Operadores

            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;

            //double res = (num1 + num2) * num3 / 3;

            #endregion

            #region Incremento e Decremento

            //int num1 = 10;

            //num1++;

            #endregion

            #region Concatenação

            //Console.WriteLine("A e " + "B");

            #endregion

            #region Operadores Atribuição

            //int num1 = 10;
            //int num2 = 20;

            //num1 -= 2;
            //num1 += 2;
            //num1 *= 2;
            //num1 /= 2;
            //num1 %= 2;

            //string letras= "A e ";
            //letras += "B";

            #endregion


            #region Iguladade e Comparação

            //bool res = 100 == 50;
            //bool res2 = 100 * 2 != 200;

            #endregion

            #region Relacionais

            //bool res = 100 < 50;
            //bool res2 = 2 >= 2;

            #endregion

            #region Operadores Lógicos

            bool res1 = 100 > 500;
            bool res2 = 50 == 50;

            bool res3 = res1 || res2;
            bool res4 = res1 && res2;

            #endregion

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
