using System;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.sobrenome);
            Console.WriteLine(pessoa.anoNascimento);
            Console.WriteLine(pessoa.idade);

            Console.WriteLine();

            Pessoa pessoa2 = new Pessoa("asdasasd", "fgfgfgfgfg", 12);
            Console.WriteLine(pessoa2.nome);
            Console.WriteLine(pessoa2.sobrenome);
            Console.WriteLine(pessoa2.anoNascimento);
            Console.WriteLine(pessoa2.idade);

            Console.WriteLine();

            Pessoa pessoa3 = new Pessoa("231231asd", "asdaf34");
            Console.WriteLine(pessoa3.nome);
            Console.WriteLine(pessoa3.sobrenome);
            Console.WriteLine(pessoa3.anoNascimento);
            Console.WriteLine(pessoa3.idade);

            Console.ReadKey();
        }
    }
}
