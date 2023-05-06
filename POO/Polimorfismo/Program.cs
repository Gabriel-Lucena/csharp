using System;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Forma forma = new Forma();

            Forma circulo = new Circulo();
            Forma retangulo = new Retangulo();
            Forma triangulo = new Triangulo();

            Console.WriteLine("Forma");
            //forma.Desenhar();
            Console.WriteLine("Círculo");
            circulo.Desenhar();
            Console.WriteLine("Retângulo");
            retangulo.Desenhar();
            Console.WriteLine("Triângulo");
            triangulo.Desenhar();

            Console.ReadKey();
        }
    }
}
