using System;
using System.Collections.Generic;
using System.Text;

namespace contaCorrente
{
    public class SistemaBancario
    {       
        public void Transacao()
        {
            var imposto = new Imposto();//instanciando um objeto imposto
            imposto.taxa[0] = 2.0;//definindo as taxas do imposto
            imposto.taxa[1] = 2.5;
            imposto.taxa[2] = 2.8;
            imposto.taxa[3] = 3.0;
            var dados = new EntradaUsuario();//instancinando uma entrada de dados do usuario
            var objConta = new Corrente();//instancioando uma conta-corrente
            objConta.saldo = 0;//definindo saldo com 0, pois a conta acabou de ser aberta.
            objConta.Debitos = new List<Debito>();//incializando a lista dos debitos
            objConta.Creditos = new List<Credito>();//inicializando a lista dos creditos
            var continua = new Continua();//instanciando um objeto do tipo continua
            do//repeticao de transacoes ate que se deseje sair
            {
                dados.LerDados();//fazendo a leitura dados
                if (dados.tipo)//if para verificar se eh uma debito ou credito
                {
                    var objD = new Debito();
                    objD.nome = dados.nome;//passando o nome dos dados coletados, para o objD
                    objD.valor = dados.valor;
                    objConta.Debitos.Add(objD);//adicionando um debito a conmta
                }
                else
                {
                    var objC = new Credito();
                    objC.nome = dados.nome;
                    objC.valor = dados.valor;
                    objConta.Creditos.Add(objC);
                }
            } while (continua.perguntar());//verifica se o usuario deseja continuar
            listaLacamentos(objConta);//lista lancamentos da conta
            objConta.CalculaSaldo();//calculando saldo
            imposto.valor = objConta.saldo;//passando o saldo para o objeto imposto
          
            imprimeSaldo(objConta.saldo -= imposto.calcularImposto());//calculando imposto e imprimeindo o saldo - o imposto
            
           
        }

        private void imprimeSaldo(double Saldo)
        {
           Console.WriteLine("");
           Console.WriteLine("saldo: "+Saldo);
        }

        private void listaLacamentos(Corrente obj)
        {
            Console.WriteLine("saldo inicial: "+obj.saldo);
            Console.WriteLine("lançamentos: ");
            Console.WriteLine(" ");
            foreach(Credito element in obj.Creditos)//repete at[e acabar os valores da lista
            {
                Console.WriteLine(" + "+element.valor +" -> "+ element.nome);
            }

            foreach (Debito element in obj.Debitos)
            {
                Console.WriteLine(" - " + element.valor + " -> " + element.nome);
            }
        }
    }
}
