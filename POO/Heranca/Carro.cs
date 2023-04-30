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


    }
}
