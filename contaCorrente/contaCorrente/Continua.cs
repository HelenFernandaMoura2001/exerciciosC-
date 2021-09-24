using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    class Continua
    {
        public Boolean perguntar()
        {
            Console.WriteLine("Deseja Realizar uma nova Transação? 1 -sim, 2 - não");

            String texto = Console.ReadLine();
            texto.Trim();//tira qualquer espaco antes e depois da string
            if (texto == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
