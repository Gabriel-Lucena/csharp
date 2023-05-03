using System;

namespace Heranca
{
    class Humano
    {
        /*
         * virtual - Pode ser sobreposto, mas pode ter implementação base
         */

        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }

    class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }

    class Homem : Pessoa
    {
        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem.Olhos");
        //}

        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelos");
        }
    }
}
