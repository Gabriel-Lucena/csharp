
using System;

namespace Heranca
{
    class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerou!");
        }

        public void Parar()
        {
            Console.WriteLine("Parou!");
        }

    }
}
