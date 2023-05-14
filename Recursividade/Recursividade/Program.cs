using System;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursiva recursiva = new Recursiva();

            recursiva.ExecutarRecursivo("Olá mundo!", 5);

            Console.ReadKey();
        }
    }
}
