using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("a"); // imprime o argumento
            //Console.WriteLine("b"); // com quebra de linha

            //Console.Write("c "); // imprime
            //Console.Write("d"); // sem quebra de linha

            //int letraCod = Console.Read(); // lê o código do caractere

            //Console.WriteLine(letraCod);

            //Console.ReadKey(true); // retorna a tecla digitada
            //Console.ReadKey();

            string texto;

            texto = Console.ReadLine(); // lê a string
            Console.WriteLine(texto);

            Console.ReadKey();

        }
    }
}
