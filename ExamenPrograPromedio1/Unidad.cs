using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1
{
    internal class Unidad
    {
        public string Name { get; set; } = "Unidad";
        public int Vida { get; set; } = 0;
        public int Dano { get; set; } = 0;
        public void Configurar (string nombre, int vida, int dano)
        {
            Name = nombre;
            Vida = vida;
            Dano = dano;
        }

      
        public virtual void Atacar(Unidad objetivo)
        {
            if (objetivo.Vida > 0)
            {
                objetivo.Vida -= Dano;
            }
        }
    }
}
