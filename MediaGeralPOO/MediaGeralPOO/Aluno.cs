using System;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public string nome { get; private set; }

        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            this.nome = nome;
            _notas = new double[provas];

        }

        public void InserirNotas()
        {
            for (int i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }

        private double CalcularMedia()
        {
            double somaNotas = 0;

            for (int i = 0; i < _notas.Length; i++)
            {
                somaNotas += _notas[i];
            }

            double media = somaNotas / _notas.Length;

            return media;
        }
    }
}
