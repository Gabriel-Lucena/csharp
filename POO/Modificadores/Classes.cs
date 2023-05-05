using System.IO;

namespace Modificadores
{
    class Teste
    {
        /*
         * private - membros da classe são privados, só são visíveis dentro da classe
         * protected - objetos não tem acesso
         *             , mas membros das classes herdadas podem ter acesso
         * internal - tem visibilidade em todo assembly, não é visível quando a classe for importada
         */

        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }

    }

    class Humano
    {
        /*
         * A classe que herda pode interagir com nome
         */

        protected string nome;
        private string sobrenome;
        internal int idade;
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nome = "";
            idade = 18;
        }
    }
}
