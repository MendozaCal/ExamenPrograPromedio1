using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1
{
    internal class Arquero : Unidad
    {
        public int Costo { get; set; } = 50;
        public void ConfigurarArquero()
        {
            Name  = "Arquero";
            Vida = 70;
            Dano = 15;
        }
    }
}
