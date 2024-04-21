using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

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
                        //Primos();
                        //Console.WriteLine($"Numero de turno: {turno}");
                        Fibonacci(turno);
                        break;
                    case 5:
                        SaltarTurno();
                        //Primos();
                        //Console.WriteLine($"Numero de turno: {turno}");
                        Fibonacci(turno);
                        
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
        public void Fibonacci(int turn)
        {
            int v1 = 0;
            int v2 = 1;
            for (int i = 0; i < 30; i++)
            {
                int temp = v1;
                v1 = v2;
                v2 = temp + v1;
                if (turn == v1)
                {
                    Console.WriteLine($"Coinsidencia {turn} y {v1}");
                }
            }
            
        }
        public void Primos()
        {
            int a = 0;   
            for (int i = 1; i < (turno + 1); i++)
            {
                if (turno % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine(turno + " No es primo");
            }
            else
            {
                Console.WriteLine(turno + " Si es primo");
            }
            Console.ReadLine();
        }
    }
}
