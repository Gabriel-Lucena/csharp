using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Bicicleta bicicleta = new Bicicleta();

            carro.LigarMotor();
            bicicleta.Pedalar();

            carro.Cor = "Alaranjado";
            bicicleta.Cor = "Preta";

            Console.WriteLine(carro.Cor);
            Console.WriteLine(bicicleta.Cor);



            Console.ReadKey();
        }
    }
}
