using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe altura em metros ");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20 )
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> Abaixo do peso");
            }
            else if ((valorIMC >= 20) && (valorIMC<=24))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> Peso normal");
            }
            else if ((valorIMC >= 25) && (valorIMC < 30))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> Acima do Peso");
            }
            else if ((valorIMC >= 30) && (valorIMC < 34))
            {
                Console.WriteLine("\n IMC = " + valorIMC + " -> Obesso");
            }
            else
            {
                Console.WriteLine("\n IMC = " + valorIMC + "-> Muito Obesso");
            }
            
            Console.ReadKey();
        }
    }
}
