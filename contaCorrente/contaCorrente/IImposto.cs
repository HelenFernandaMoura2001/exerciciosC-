using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    interface IImposto
    {
        public double valor { get; set; }
        public double [] taxa { get; set; } 
        public Double calcularImposto();
    }
}
