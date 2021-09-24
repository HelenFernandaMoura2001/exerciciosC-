using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    public interface IContaCorrente
    {
        List <Credito> Creditos { get; set; }
        List <Debito> Debitos{ get; set; }
        double saldo { get;}
        public void CalculaSaldo();

    }
}
