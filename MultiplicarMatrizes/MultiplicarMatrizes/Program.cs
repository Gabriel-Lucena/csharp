using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicarMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];

            int[,] matriz2 = new int[3, 2];

            int[,] matrizResultante = new int[2, 2];




            Console.WriteLine("Preencher a matriz #1: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for  ( int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write("#1. Posição [" + (linha + 1) + "] [" + (coluna + 1 )+ "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("\nPreencher a matriz #2: ");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write("#2. Posição [" + (linha + 1) + "] [" + (coluna + 1) + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());

                }
            }


            Console.WriteLine("\nResultado da matriz #1 x matriz #2: ");

            int resultado00 = 0, resultado10 = 0, resultado01 = 0, resultado11 = 0;

            for (int i = 0; i < 3; i++)
            {
                resultado00 += matriz1[0, i] * matriz2[i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                resultado10 += matriz1[1, i] * matriz2[i, 0];
            }

            for (int i = 0; i < 3; i++)
            {
                resultado01 += matriz1[0, i] * matriz2[i, 1];
            }

            for (int i = 0; i < 3; i++)
            {
                resultado11 += matriz1[1, i] * matriz2[i, 1];
            }

            matrizResultante[0, 0] = resultado00;
            matrizResultante[1, 0] = resultado10;
            matrizResultante[0, 1] = resultado01;
            matrizResultante[1, 1] = resultado11;


            Console.WriteLine("|" + matrizResultante[0, 0] + " " + matrizResultante[0, 1] + "|");
            Console.WriteLine("|" + matrizResultante[1, 0] + " " + matrizResultante[1, 1] + "|");


            Console.ReadKey();
        }
    }
}
