using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1
{
    internal class Soldado:Unidad

    {
        public void ConfigurarArquero()
        {
            Name = "Soldado";
            Vida = 50;
            Dano= 10;
        }
    }
}
