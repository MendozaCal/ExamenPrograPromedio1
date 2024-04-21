using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1
{
    internal class Unidad
    {
        public string Name { get; set; }
        public int  Vida { get; set; }
        public int Dano { get; set; }

        public Unidad(string name, int vida, int dano)
        {
            Name = name;
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
