namespace Estaticas
{
    static class Matematica
    {
        public static int taxa;

        public static int Adicionar(int valor)
        {
            return valor + taxa;
        }

        public static int Diminuir(int valor)
        {
            return valor - taxa;

        }
    }
}
