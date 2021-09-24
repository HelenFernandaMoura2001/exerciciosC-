using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    public class Corrente: IContaCorrente
    {
      public List <Credito> Creditos { get; set;} // criando um espaço na memoria para receber o objeto
      public List <Debito> Debitos { get; set;}// criando um espaço na memoria para receber o objeto
      public double saldo { get; set;} // variavel 
      public void CalculaSaldo()
      {//as alteracoes feitas aqui nas variaveis, representam as alteracoes feitas no obj e nao na classe

            foreach (Credito element in Creditos)
            {
                saldo += element.valor;
            }

            foreach (Debito element in Debitos)
            {
                saldo -= element.valor;
            }
      }


    }
}
