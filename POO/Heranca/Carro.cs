using System;

namespace Heranca
{
    class Carro : Veiculo
    {

        public double VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Ligou!");
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o carro!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro!");
        }


    }
}
