using System;

namespace Recursividade
{
    internal class Recursiva
    {
        // Sem recursividade
        public void Executar(string mensagem, int quantidade)
        {
            for (int contador = 0; contador < quantidade; contador++)
            {
                Console.WriteLine(mensagem);
            }
        }

        // Com recursividade
        public void ExecutarRecursivo(string mensagem, int quantidade)
        {
            if (quantidade > 0)
            {
                Console.WriteLine(mensagem);
                ExecutarRecursivo(mensagem, quantidade - 1);
            }

        }
    }
}
