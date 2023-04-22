using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e Objetos

            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;

            #endregion

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "A";
            pessoa1.sobrenome = "B";
            pessoa1.anoNascimento = 1900;

            Pessoa pessoa2 = new Pessoa()
            {
                nome = "C",
                sobrenome = "D",
                anoNascimento = 1899
            };


            Console.WriteLine("Pessoa 1: " + pessoa1.nome);
            Console.WriteLine("Pessoa 1: " + pessoa1.sobrenome);
            Console.WriteLine("Pessoa 1: " + pessoa1.anoNascimento);
            pessoa1.Cumprimentar();


            Console.WriteLine();

            Console.WriteLine("Pessoa 2: " + pessoa2.nome);
            Console.WriteLine("Pessoa 2: " + pessoa2.sobrenome);
            Console.WriteLine("Pessoa 2: " + pessoa2.anoNascimento);
            pessoa2.Cumprimentar();


            Console.ReadKey();

        }
    }


    class MinhaClasse
    {

    }
}
