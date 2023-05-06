using System;

namespace Polimorfismo
{
    abstract public class Forma
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public int Altura { get; private set; }

        public int Largura { get; private set; }

        public int Raio { get; private set; }

        public virtual void Desenhar()
        {
            Console.WriteLine("Preparando-se para desenhar!");
        }

        public virtual void Area()
        {
            double area = Largura * Altura;
            Console.WriteLine("Área: " + area);
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um círculo!");
        }

        public override void Area()
        {
            double area = Math.PI * (Raio * Raio);
            Console.WriteLine("Área do círculo: " + area);
        }
    }

    public class Retangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um retângulo!");
        }

        public override void Area()
        {
            base.Area();
        }
    }

    public class Triangulo : Forma
    {
        public override void Desenhar()
        {
            base.Desenhar();
            Console.WriteLine("Desenhando um triângulo!");
        }

        public override void Area()
        {
            double area = Largura * Altura / 2;
            Console.WriteLine("Área do triângulo: ");
        }
    }
}
