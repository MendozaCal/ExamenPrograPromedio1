﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1.Cod._Pablo
{
    internal class Juego
    {
        int turno = 1;
        public void MainMenu()
        {
            bool resumen = true;
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Actualmente cuentas con 100 de energía Administralos correctamente para ganar");
            while (resumen)
            {
                Console.WriteLine("Elije una opción");
                Console.WriteLine("1. Ver Base");
                Console.WriteLine("2. Construir Estructura");
                Console.WriteLine("3. Construir Unidad");
                Console.WriteLine("4. Iniciar Combate");
                Console.WriteLine("5. Saltar Turno");
                Console.WriteLine("6. Salir del Juego");
                int Option = int.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        ShowBase();
                        break;
                    case 2:
                        ContruirEstructuras();
                        break;
                    case 3:
                        ConstruirUnidad();
                        break;
                    case 4:
                        Atacar();
                        break;
                    case 5:
                        SaltarTurno();
                        break;
                    case 6:
                        resumen = false;
                        break;
                }
                
            }
        }
        public void ShowBase()
        {

        }
        public void ContruirEstructuras()
        {

        }
        public void ConstruirUnidad()
        {

        }
        public void Atacar()
        {

        }
        public void SaltarTurno()
        {

        }


    }
}
