using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Matematica
    {

        public void Somar(int inteiro1, int inteiro2)
        {
            Console.WriteLine("A soma é: " + (inteiro1 + inteiro2));
        }

        public void Subtrair(int inteiro1, int inteiro2)
        { 
            Console.WriteLine("A subtração é: " + (inteiro1  - inteiro2));
        }

        public void Multiplicar(int inteiro1, int inteiro2)
        { 
            Console.WriteLine("O produto é: " + (inteiro1 * inteiro2));
        }

        public void Dividir(int inteiro1, int inteiro2)
        {
            Console.WriteLine("O quociente é: " + (inteiro1 / inteiro2));
        }
    }
}
