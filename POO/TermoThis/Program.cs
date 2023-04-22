using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Acessar acesso = new Acessar();

            if (acesso.Login("dasdasd"))
            {
                Console.WriteLine("Olá!");
            }
            else
            {
                Console.WriteLine("Acesso Negado!");
            } 


            Console.ReadKey();
        }
    }
}
