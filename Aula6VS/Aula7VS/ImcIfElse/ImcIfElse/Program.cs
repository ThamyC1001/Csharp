using System;

namespace ImcIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            String nome;
           
           Console.WriteLine("Escreva seu nome: ");
           nome = Console.ReadLine();

           Console.WriteLine("insira seu peso:");
           peso = float.Parse(Console.ReadLine());

           Console.WriteLine("insira sua altura:");
           altura = float.Parse(Console.ReadLine());

           imc = peso / (altura * altura);
           Console.WriteLine("seu imc é:" + imc);

            if  (imc < 18.5)
            {
                Console.Write("Abaixo do peso:" + imc);
            }
            else if (imc < 25) 
            {
                Console.WriteLine("Peso normal é" + imc);
            }
            else if (imc < 30)
            {
                Console.WriteLine("Sobre peso é:" + imc);
            }
            else (imc => 30)
            {
                Console.WriteLine("Obesidade é:" + imc);
            }













        }
    }
}
