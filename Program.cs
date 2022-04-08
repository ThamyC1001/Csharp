using Aula8VS.src;
using System;

namespace Aula8VS
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Galinhazinha");
            Galinha isabelly = new Galinha("isabelly", "rosa", "milho", "aves");
            Galinha claudia = new Galinha(" claudia", "branca", "grilo", "aves");
            Galinha rosangela = new Galinha("rosangela", "marrom", "sementes", "aves");

            Console.WriteLine($"galinha 1 é a {isabelly.Nome} de cor {isabelly.Cor} e Classes {isabelly.Classes}");
            Console.WriteLine($"galinha 2 é a {claudia.Nome} de cor {claudia.Cor} e Classes {claudia.Classes}");
            Console.WriteLine($"galinha 3 é a {rosangela.Nome} de cor {rosangela.Cor} e Classes {rosangela.Classes}");

            isabelly.comer("grilos");
            claudia.dormir();
            rosangela.botarovo();
            Console.WriteLine();
        }


    }
}