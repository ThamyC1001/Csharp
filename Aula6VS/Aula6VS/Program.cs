using System;

namespace Aula6VS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numero;

            Console.WriteLine("Tabuada");
            Console.WriteLine("Insira o numero que voçê quer multiplicar:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = numero * x;
                Console.WriteLine($"{numero} X {x} = {resultado}");
            }
        }

    }
}


