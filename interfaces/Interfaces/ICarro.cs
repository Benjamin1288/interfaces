using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Interfaces
{
    internal interface ICarro
    {
        public string marca { get; set; }
        public string color { get; set; }
        public int modelo { get; set; }
        public string getvelocidadactual();
        public void encendercarro();
        public string acelerar(int cuanto);


    }
}
