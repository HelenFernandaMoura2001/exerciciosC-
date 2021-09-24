using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    class Imposto :IImposto
    {
        public double valor { get; set; }
        public double[] taxa { get; set; } = new double[4];
        public Double calcularImposto()
        {
            double valorFinal = 0;
            if(valor <= 999)
            {
                valorFinal += valor * taxa[0] / 100;
            }
            else if(valor > 999 && valor <= 2999)
            {
                valorFinal += valor * taxa[1] / 100;
            }
            else if (valor > 2999 && valor <= 6999)
            {
                valorFinal += valor * taxa[2] / 100;
            }
            else
            {
                valorFinal += valor * taxa[3] / 100;
            }
            return valorFinal;
        }

    }
}

/*
 Se o valor for menor ou igual a 999, o imposto deve ser de 2%(0)
Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%(1)
Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%(2)
Se for maior ou igual a 7000, o imposto deve ser de 3%(3)
 */