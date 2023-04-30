using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.Cliente = "Nome";
            //conta.Saldo = 100;

            // Operação de Depósito

            double valor = 100;
            conta.Depositar(valor);

            // Operação de Saque

            double valor2 = 50;
            conta.Sacar(valor2);

            //Resultado Saldo Atual
            Console.WriteLine("Cliente: " + conta.Cliente);
            Console.WriteLine("Saldo: " + conta.Saldo);

            Console.ReadKey();
        }
    }
}
