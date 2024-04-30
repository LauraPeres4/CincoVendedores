using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CincoVendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] nome = new string[5];
            double[] vendas = new double[5];
            double[] comissao = new double[5];

            for (int i = 0; i<= 5; i++)
            {
                Console.WriteLine("Informe o nome do vendedor: " + nome[i]);
                nome[i] = Console.ReadLine();
                Console.WriteLine("Informe o total das vendas: ");
                vendas[i] = double.Parse(Console.ReadLine());

                if (vendas[i] <= 20.000)
                {
                    comissao[i] = vendas[i] * 0.05;
                    Console.WriteLine("Sua comissão será de: " + comissao[i]);
                }
                else if (vendas[i] <= 40.000)
                {
                    comissao[i] = vendas[i] * 0.06;
                    Console.WriteLine("Sua comissão será de: " + comissao[i]);
                }
                else
                {
                    comissao = vendas[i] * 0.07;
                    Console.WriteLine("Sua comissão será de: " + comissao[i]);
                }
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("O vendedor " + nome[i] + "terá uma comissão de " + comissao[i]);
            }
           

        }
    }
}
