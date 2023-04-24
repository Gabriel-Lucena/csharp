using System;

namespace Estaticas
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Classe Estática

            //Matematica.taxa = 10;

            //int valor1 = Matematica.Adicionar(200);
            //int valor2 = Matematica.Diminuir(200);

            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);

            #endregion


            Pessoa.maioridade = 21;
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "A";
            pessoa.idade = Pessoa.CalcularIdade(1900);

            pessoa.Apresentar();

            Console.WriteLine(pessoa.nome);
            Console.WriteLine(pessoa.idade);
            Console.WriteLine(Pessoa.maioridade);

            Console.ReadKey();

        }
    }
}
