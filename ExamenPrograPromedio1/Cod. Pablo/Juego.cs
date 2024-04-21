using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPrograPromedio1.Cod._Pablo
{
    internal class Juego
    {
        int turno = 0;
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

                if (Option == 4 || Option == 5)
                {
                    turno++;
                }
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
                        Ataque();
                        Console.WriteLine($"Numero de turno: {turno}");
                        break;
                    case 5:
                        Console.WriteLine($"Numero de turno: {turno}");
                        SaltarTurno();
                        break;
                    case 6:
                        resumen = false;
                        break;
                    default:
                        Console.WriteLine("Valor Incorrecto");
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
        public void Ataque()
        {

        }
        public void SaltarTurno()
        {

        }


    }
}
