using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ExamenPrograPromedio1
{
    internal class Tower : Estructura
    {
        public int Dano { get; set; }
        public int vida { get; set; }

        public Tower()
        {
            Nombre = "Torre";
            Costo = 100;
            TiempoConstruccion = 10;
            Dano = 50;
            vida = 200;
        }

    }
}
