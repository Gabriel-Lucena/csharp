using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // Método Simples

        public void Cumprimentar()
        {
            Console.WriteLine("Olá!");
        }

        // Métodos com parâmetros
        public void Somar(int inteiro1,int inteiro2)
        {
            int resultado = inteiro1 + inteiro2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {

            if (idade != 1)
            {
                Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos.");
            } else
            {
                Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " ano.");
            }

        }

        // Passagem de parâmetros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " + valor);
        }

        // Passagem de parâmetros por referência
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referência) é: " + valor);
        }

        // Métodos com retorno de valores
        public string MontaNome(string nome, string sobrenome)
        {
            //string nomeCompleto = nome + " " + sobrenome;

            return nome + " " + sobrenome;
        }

        public int CodigoChar(char caractere)
        {
            //int codigo = (int)caractere;

            return caractere;
        }

        public double ValorPi()
        {
            return 3.1415;
        }

        // Sobrecarga de Métodos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, " + nome + "!");
        }

        public void Cumprimentar(string nome, int hora)
        {
            string mensagem = hora < 12 ? "Bom dia, " + nome + "!": "Boa tarde, " + nome + "!";
            Console.WriteLine(mensagem);
        }

        public bool Comparar(int inteiro1, int inteiro2)
        {
            return inteiro1 == inteiro2;
        }
        public bool Comparar(string string1, string string2)
        {
            return string1 == string2;
        }
    }
}
