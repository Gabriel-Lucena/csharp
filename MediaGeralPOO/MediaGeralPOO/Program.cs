using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";

            Console.WriteLine("Quantos alunos? ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] vetorAlunos = new Aluno[quantidadeAlunos];

            for (int i = 0; i < vetorAlunos.Length; i++)
            {
                Console.Clear();

                Console.Write("Aluno #" + (i + 1) + " Nome..: ");
                string nomeAluno = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int quantidadeProvas = int.Parse(Console.ReadLine());

                vetorAlunos[i] = new Aluno(nomeAluno, quantidadeProvas);

                Console.WriteLine("Insira as notas do aluno " + nomeAluno);
                vetorAlunos[i].InserirNotas();
            }

            Console.Clear();

            double somaGeral = 0;

            foreach (Aluno aluno in vetorAlunos)
            {
                Console.WriteLine("Aluno: " + aluno.nome);
                Console.WriteLine("Media: " + aluno.Media);

                Console.WriteLine();

                somaGeral += aluno.Media;
            }

            double mediaGeral = somaGeral / vetorAlunos.Length;

            Console.WriteLine("Média Geral dos Alunos: " + Math.Round(mediaGeral, 1));

            Console.ReadKey();
        }
    }
}
