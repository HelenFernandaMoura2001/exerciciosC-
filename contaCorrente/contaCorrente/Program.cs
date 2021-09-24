using System;

namespace contaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            var sistema = new SistemaBancario();//instanciando um sistema bancario
            sistema.Transacao();//inicializando uma transação
           
        }
    }
}
