using System;

namespace calculoArea
{
    class Program
    {     
        static void Main(string[] args)
        {
            Retangulo objR = new Retangulo(); //instânciando um objeto
            objR.Leitura(); // chamando a função leitura
            objR.Imprime(); // chamanda a função Imprime

            Console.ReadKey();
        }  
    }

    public class Retangulo
    {
        private double largura, altura;
        private double area;
        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Area { get => area;}

        public double GetCalculaArea()
        {
            try
            {
                if (this.altura < 0.0 || this.largura < 0.0)
                {
                    return -1.0;
                }
                this.area = this.altura * this.largura;
                return this.area;
            }
            catch (Exception)
            {

                return -2.0;
            }
            
        }

        public void Leitura()
        {
            try
            {
                Console.WriteLine("insira a altura:");
                this.altura = double.Parse(Console.ReadLine());

                Console.WriteLine("insira a largura:");
                this.largura = double.Parse(Console.ReadLine());
                
            }
            catch (Exception)
            {
                Console.WriteLine("Insira somente numeros!");
                Console.WriteLine("Ou por favor utilize ponto para casa decimal e virgula para milhar");
                Leitura();
            }  
        }

        public void Imprime()
        {
            try
            {
                if (GetCalculaArea() == -1.0)
                {
                    Console.WriteLine("Os numeros inseridos são negativos");
                    Leitura();
                }
                else if (this.area == -2.0)
                {
                    Console.WriteLine("Os numeros inseridos são muito grandes");
                    Leitura();
                }
                else
                {
                    Console.Write("O resultado da área ");
                    Console.Write(this.area);
                }
            }
            catch (Exception)
            {

               Console.WriteLine("Por favor utilize ponto para casa decimal e virgula para milhar");
            }
           
        } 
    } 
}
    
