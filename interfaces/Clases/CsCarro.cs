using interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Clases
{
    internal class CsCarro : ICarro
    {
        public string marca { get; set;}
        public string color { get; set;}
        public int modelo { get; set;}

        public string acelerar(int cuanto)
        {
            Console.WriteLine($"vas a {cuanto}");
            return "Acelerar";
        }

        public void encendercarro()
        {
            Console.WriteLine("El carro esta encendido");
        }

        public string getvelocidadactual()
        {
            Console.WriteLine("Vas a 100kph");
            return "velocidad";
        }
    }
}
