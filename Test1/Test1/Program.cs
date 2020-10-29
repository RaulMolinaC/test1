﻿using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                double s1;

                s1 = EquationSolvers.SolveEquation(2.0, -4.0);

                System.Console.WriteLine("S1 = " + s1);

            }


            {
                double s2;

                s2 = EquationSolvers.SolveEquation2(1.0, -1.0, 0.0);

                System.Console.WriteLine("S2 = " + s2);

            }


            {

                double s3;

                s3 = Geometry.GetVectorLength(1.0, 2.0);

                System.Console.WriteLine("S3 = " + s3);

            }


            {

                double s4;

                s4 = Geometry.GetVectorLength2(1.0, 1.0, 1.0);

                System.Console.WriteLine("S4 = " + s4);

            }

            {

                int s5 = Utils.GetMinValue(3, 5);

                System.Console.WriteLine("S5 = " + s5);

            }


            {

                int s6 = Utils.GetMaxValue(3, 5);

                System.Console.WriteLine("S6 = " + s6);

            }


            {
                bool s7 = Utils.IsEven(4);

                System.Console.WriteLine("S7 = " + s7);

            }

            {
                Ejercicios.Ejercicio1();

            }


            {
                Ejercicios.Ejercicio2(50);
            }


            {
                int i = 2;

                while (i <= 10)
                {
                    Ejercicios.Ejercicio3(i);

                    i++;

                }
                           

            }


            {
                Ejercicios.Ejercicio4();
            }


            {
                Ejercicios.Ejercicio5();
            }


            {
                Ejercicios.Ejercicio6();
            }

            {
                Ejercicios.Ejercicio7();
            }


            {
                Ejercicios.Ejercicio8();
            }


            {
                Ejercicios.Ejercicio9();
            }


            {
                Ejercicios.Asteriscos2(5);
            }

            {
                EjerciciosExamen.Sum(1,2);
            }

            {
                EjerciciosExamen.Rest(3,1);
            }

            {
                EjerciciosExamen.MinValue(1,3);
            }

            {
                EjerciciosExamen.EsMenor(1, 3);
            }
        }

                
    }

}
