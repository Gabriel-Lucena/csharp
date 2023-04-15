using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {

        enum Notas
        {
            Minimo = 10,
            Media = 20,
            Maxima = 30
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {

            #region Números inteiros
            //// Integral com sinal
            //sbyte num1 = 10; // 8 bits
            //short num2 = 20; // 16 bits
            //int num3 = 30; // 32 bits
            //long num4 = 40L; // 64 bits

            //// Integral sem sinal

            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num8 = 40L;

            //sbyte numero;

            //numero = 100;

            //numero = 120;

            //numero = num1;


            #endregion

            #region Números Reais
            //float real1 = 100.75f; // 32 bits
            //double real2 = 500.654; //64 bits
            //decimal real3 = 752538.457M; // 128 bits

            //double valor;
            //valor = real1;

            #endregion

            #region Char

            //char letra = '\u0061';
            //char escape = '\n';
            //char escape2 = '\\';
            //char nulo = '\0';

            #endregion

            #region Booleano

            //bool verificar = false;
            //verificar = true;

            #endregion

            #region String

            //string texto = "ABC\n\nBCA";
            //string texto2 = @"ABC\\nBCA";
            //string mensagem = null;
            //mensagem = texto;

            #endregion

            #region Var 

            // Recebe vários valores

            //var valor = 100;
            //valor = 20;
            //valor = "A";

            #endregion

            #region Object

            //object obj = false;
            //obj = 234;

            #endregion


            #region Constantes

            //const double pi = 3.1415;

            #endregion

            #region Enumeração

            //Notas notasAlunos = Notas.Media;

            #endregion

            #region Estrutura
               

            Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 1;
            p1.nome = "A";

            Pessoa p2 = new Pessoa()
            {
                nome = "B",
                idade = 2,
                altura = 1
            };

            #endregion

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();


        }
    }
}
