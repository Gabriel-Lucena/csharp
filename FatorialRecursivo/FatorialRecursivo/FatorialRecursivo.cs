using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class FatorialRecursivo
    {
        public int Fatorial(int inteiro)
        {
            if (inteiro == 0)
            {
                return 1;
            }

            return inteiro * Fatorial(inteiro - 1);
        }
    }
}
