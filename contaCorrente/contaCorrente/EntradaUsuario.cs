using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    public class EntradaUsuario
    {
        public String nome { get; set; }
        public double valor { get; set; }
        public Boolean tipo {get; set;}
        public void LerDados()
        {
            String texto;
            Console.WriteLine("Digite o nome da transação");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o valor");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira qual tipo será: Crédito(0) ou Débito(1):");
            texto = Console.ReadLine();
            texto.Trim();
            if(texto == "0")
            {
                tipo = false;
            }
            else
            {
                tipo = true;
            }
            
        }
    }
}
