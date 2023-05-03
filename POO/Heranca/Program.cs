using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parte 1

            //Carro carro = new Carro();
            //Bicicleta bicicleta = new Bicicleta();
            ////Veiculo veiculo = new Veiculo(); // Não se pode instanciar objetos da classe

            ////carro.LigarMotor();
            ////bicicleta.Pedalar();

            ////carro.Cor = "Alaranjado";
            ////bicicleta.Cor = "Preta";

            ////Console.WriteLine(carro.Cor);
            ////Console.WriteLine(bicicleta.Cor);

            //carro.Acelerar();
            //bicicleta.Acelerar();

            #endregion

            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            Console.WriteLine("\nHumano");

            humano.Olhos();
            humano.Cabelos();
            
            Console.WriteLine("\nPessoa");

            pessoa.Olhos();
            pessoa.Cabelos();

            Console.WriteLine("\nHomem");

            homem.Olhos();
            homem.Cabelos();

            Console.ReadKey();
        }
    }
}
