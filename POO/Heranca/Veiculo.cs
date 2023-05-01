
using System;

namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }

        public abstract void Acelerar(); // As classes que herdam devem implementar esse método

        public abstract void Parar();

    }
}
