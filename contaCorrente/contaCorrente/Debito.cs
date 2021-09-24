using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    public class Debito :IDebito
    {
        public String nome { get; set; }
        public double valor { get; set; }
    }
}
