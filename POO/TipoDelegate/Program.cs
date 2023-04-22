using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDelegate
{
    class Program
    {
        delegate void Operacao(int inteiro1, int inteiro2);

        static void Main(string[] args)
        {
            Matematica operacoes = new Matematica();

            Operacao conta = null;

            conta += operacoes.Somar;
            conta += operacoes.Subtrair;
            conta += operacoes.Multiplicar;
            conta += operacoes.Dividir;

            conta(10, 2);

            Console.WriteLine();

            conta -= operacoes.Dividir;
            conta -= operacoes.Subtrair;

            conta(15, 3);

            Console.ReadKey();
        }
    }
}
