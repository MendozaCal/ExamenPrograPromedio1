﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExamenPrograPromedio1.Cod._Pablo
{
    internal class Juego
    {
        Elementos[] ElementosArray = new Elementos[5];
        
        List<Elementos> ElementosBase; 
        int Turno = 0;
        int TurnTo = 0;
        public void MainMenu()
        {
            ElementosArray[0] = new Estructuras();
            ElementosArray[1] = new Estructuras();
            ElementosArray[2] = new Estructuras();
            ElementosArray[3] = new Unidades();
            ElementosArray[4] = new Unidades();
            ElementosBase = new List<Elementos>();
            bool resumen = true;
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Actualmente cuentas con 200 de energía Administralos correctamente para ganar");
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
                    Turno++;
                }
                switch (Option)
                {

                    case 1:
                        ShowBase();
                        break;
                    case 2:
                        ContruirEstructuras(Turno);
                        
                        break;
                    case 3:
                        ConstruirUnidad();
                        break;
                    case 4:
                        Ataque();
                        //Primos();
                        //Console.WriteLine($"Numero de Turno: {Turno}");
                        Fibonacci(Turno);
                        break;
                    case 5:
                        SaltarTurno();
                        //Primos();
                        //Console.WriteLine($"Numero de Turno: {Turno}");
                        Fibonacci(Turno);
                        
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
            foreach (Elementos elementosBase in ElementosBase)
            {
                Console.WriteLine(elementosBase/*Método en clase Elementos que devuelva datos del player*/);
            }
}
        public void ContruirEstructuras(int turn)
        {
            Console.WriteLine("Elegir Estructura q Desea Construir");
            Console.WriteLine("1. Granja _______ 50 de energía");
            Console.WriteLine("2. Torre  _______ 100 de energía");
            Console.WriteLine("3. Casa   _______ 50 de energía");
            int Opt = int.Parse(Console.ReadLine());
            switch (Opt)
            {
                case 1:
                    for (int i = 0; i <= 5; i++)
                    {
                        int comparation = 0;
                        comparation++;
                        if (comparation <= 5)
                        {
                            Console.WriteLine("avr");
                        }
                    }
                    break;
                case 2:
                    break;
            }
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
            for (int i = 1; i < (Turno + 1); i++)
            {
                if (Turno % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine(Turno + " No es primo");
            }
            else
            {
                Console.WriteLine(Turno + " Si es primo");
            }
            Console.ReadLine();
        }
    }
}
