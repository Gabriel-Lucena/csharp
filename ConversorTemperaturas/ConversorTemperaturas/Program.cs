using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            double temperaturaC, temperaturaK, temperaturaF;

            Console.Write("Digite a temperatura em graus Celsius: ");
            temperaturaC = double.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura de " +  temperaturaC + "°C corresponde a: ");
            Console.WriteLine(program.CToK(temperaturaC) + " Kelvin");
            Console.WriteLine(program.CToF(temperaturaC) + " Fahrenheit");

            Console.ReadKey();
        }

        public double CToK(double temperaturaC)
        {
            double temperaturaK = temperaturaC + 273.15;
            return temperaturaK;
        }

        public double CToF(double temperaturaC)
        {
            double temperaturaF = 9 / 5 * temperaturaC + 32 ;

            return temperaturaF;
        }
    }
}
