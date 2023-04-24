using System;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();

            teste.Nome = "A";
            teste.Idade = 123;

            Console.WriteLine(teste.Nome + " " + teste.Sobrenome);
            Console.WriteLine(teste.Idade);

            Console.ReadKey();

        }
    }
}
