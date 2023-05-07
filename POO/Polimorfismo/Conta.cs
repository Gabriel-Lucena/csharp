namespace Polimorfismo
{
    class CaixaEletronico : IConta
    {
        public string Usuario { get ; set ; }

        public void Depositar()
        {
            
        }

        public void Sacar()
        {
           
        }

        public void Saldo()
        {
          
        }

        public void SolicitarEmprestimo()
        {

        }
    }

    interface IConta // Membros abstratos
    {
        string Usuario { get; set; }

        void Depositar();

        void Sacar();

        void Saldo();
    }
}
