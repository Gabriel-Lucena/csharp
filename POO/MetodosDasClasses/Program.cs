using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos metodos = new Metodos();

            #region Métodos Simples

            //metodos.Cumprimentar();

            #endregion

            #region Métodos com Parâmetros

            //metodos.Somar(12, 23);
            //metodos.Apresentar("nome", 1);

            #endregion

            #region Passagem de parâmetros por valor e por referência

            //int valor1 = 100;
            //int valor2 = 100;

            //metodos.AumentarValor(valor1);
            //metodos.AumentarRef(ref valor2);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);

            #endregion

            #region Métodos com retorno de valores

            //string nomeCompleto = metodos.MontaNome("nome", "sobrenome");
            //int codigoChar = metodos.CodigoChar('a');
            //double pi = metodos.ValorPi();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigoChar);
            //Console.WriteLine(pi);

            #endregion

            metodos.Cumprimentar();
            metodos.Cumprimentar("A");
            metodos.Cumprimentar("A", 1);

            bool resultado1 = metodos.Comparar(100, 50 * 2);
            bool resultado2 = metodos.Comparar("A", "a");

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            Console.ReadKey();
        }
    }
}
