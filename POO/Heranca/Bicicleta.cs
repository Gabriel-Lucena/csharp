using System;

namespace Heranca
{
    sealed class Bicicleta : Veiculo
    {

        public void Pedalar()
        {

        }

        public override void Acelerar() // Sobreposto
        {
            Console.WriteLine("Acelerou a bicicleta!");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bicicleta!");
        }

    }
}
