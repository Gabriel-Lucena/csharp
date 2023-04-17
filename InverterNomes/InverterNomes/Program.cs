using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome_1, nome_2, nome_3, nome_4, aux;

            Console.Write("Digite o nome 1: ");
            nome_1 = Console.ReadLine();

            Console.Write("Digite o nome 2: ");
            nome_2 = Console.ReadLine();


            Console.Write("Digite o nome 3: ");
            nome_3 = Console.ReadLine();

            Console.Write("Digite o nome 4: ");
            nome_4 = Console.ReadLine();

            // Invertendo

            aux = nome_1;
            nome_1 = nome_4;
            nome_4 = aux;

            aux = nome_2;
            nome_2 = nome_3;
            nome_3 = aux;


            Console.WriteLine();

            Console.WriteLine("Nomes inseridos na sequência invertida: ");

            Console.WriteLine(nome_1);
            Console.WriteLine(nome_2);
            Console.WriteLine(nome_3);
            Console.WriteLine(nome_4);

            Console.ReadKey();

        }
    }
}
