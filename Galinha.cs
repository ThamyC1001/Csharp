using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8VS.src
{
    internal class Galinha
    {

        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Alimento { get; set; }
        public string Classes { get; set; }
        public Galinha(string _nome, string _cor, string _alimento, string _classes)
        {
            Nome = _nome;
            Cor = _cor;
            Alimento = _alimento;
            Classes = _classes;
        }
        public void botarovo()
        {
            Console.WriteLine("rosangela esta chocando ovo ...");
        }
        public void comer(string comida)
        {
            Console.WriteLine($"Eu isabelly estou comendo {comida}");
        }

        public void dormir()
        {
            Console.WriteLine($"claudia esta dormindo:"+ "zzzzzzzzzz..");
        }
       
    }
}

    