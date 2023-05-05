using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {

            Teste teste = new Teste();

            teste.sobrenome = "";
            //teste.nome = "";
            //teste.Metodo1();
            teste.Executar();

            Homem homem = new Homem();

            homem.Metodo();
            homem.idade = 19;

            Console.ReadKey();
        }
    }
}
