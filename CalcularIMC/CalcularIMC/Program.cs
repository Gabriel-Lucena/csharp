using System;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double altura, massa, imc;

            Console.Write("Digite sua altura em metros: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite sua massa em quilos: ");
            massa = double.Parse(Console.ReadLine());

            imc = massa / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("\nIMC = " + imc + " -> Abaixo do peso");
            } 
                else if (imc <= 24)
            {

                Console.WriteLine("\nIMC = " + imc + " -> Normal");

            } else if (imc <= 29)
            {

                Console.WriteLine("\nIMC = " + imc + " -> Acima do peso");
            } else if (imc <= 34)
            {
                Console.WriteLine("\nIMC = " + imc + " -> Obesidade");
            } else
            {
                Console.WriteLine("\n IMC = " + imc + " -> Obesidade II");
            }




            Console.ReadKey();
        }
    }
}
