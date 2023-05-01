using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Bicicleta bicicleta = new Bicicleta();
            //Veiculo veiculo = new Veiculo(); // Não se pode instanciar objetos da classe

            //carro.LigarMotor();
            //bicicleta.Pedalar();

            //carro.Cor = "Alaranjado";
            //bicicleta.Cor = "Preta";

            //Console.WriteLine(carro.Cor);
            //Console.WriteLine(bicicleta.Cor);

            carro.Acelerar();
            bicicleta.Acelerar();


            Console.ReadKey();
        }
    }
}
