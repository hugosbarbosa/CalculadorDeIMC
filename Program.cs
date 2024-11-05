using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorDeIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine();

            double imc = peso / (altura * altura);

            Console.Write("Seu IMC é: " + imc.ToString("F2") + " ");

            if (imc <= 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc >= 18.6 && imc <= 25)
            {
                Console.WriteLine("Você está no peso ideal");
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está sobrepeso");
            }

            else if (imc > 30 && imc <= 35)
            {
                Console.WriteLine("Você está com obesidade grau 1");
            }

            else if (imc > 35 && imc <= 40)
       
            {
                Console.WriteLine("Você está com obesidade grau 2");
            }

            else
            {
                Console.WriteLine("Você está com obesidade grau 3");        
            }

            
            Console.ReadKey();
        }

    }
}
