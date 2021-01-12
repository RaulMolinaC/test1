using System;
using System.Collections.Generic;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
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
                Ejercicios.Ejercicio2(20);
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
                Ejercicios.Asteriscos(10);
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

            {
                EjerciciosExamen.EsMenorDe10(5, 10);
            }

            {
                EjerciciosExamen.Cat("Ho", "l", "a");
            }

            {
                EjerciciosExamen.MayorMenorIgual(3, 4);
            }

            {
                EjerciciosExamen.EsMenor3(3, 2, 4);
            }

            {
                EjerciciosExamen.PrintError(2); 
            }

            {
                EjerciciosExamen.Serie(10);
            }

            {
                EjerciciosExamen.Serie2(10);
            }

            {
                EjerciciosExamen.Serie3(10);  
            }

            {
                EjerciciosExamen.SerieAsteríscos(8); 
            }

            {
                EjerciciosExamen.SerieAsteriscoMas(5);  
            }

            {
                EjerciciosExamen.EsMenor9(5, 7, 22, 9, 0, 6, 11, 4, 33); 
            }

            {
                EjerciciosExamen.ColumnasFilas(6);
            }

            {
                EjerciciosExamen.ColumnasFilas2(3);
            }

            {
                EjerciciosExamen.ColumnasFilas3(4);
            }

            {
                EjerciciosExamen.ColumnasFilas4(4);
            }

            {
                EjerciciosExamen.ColumnasFilas5(5);
            }

            {
                EjerciciosExamen.ColumnasFilas6(4);
            }

            {
                EjerciciosExamen.ColumnasFilas7(5);
            }

            {
                EjerciciosExamen.Ejercicio21(8);  
            }

            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    EjerciciosExamen.ColumnasFilas7(i);
                    System.Threading.Thread.Sleep(1);
                    System.Console.Clear();
                }

            }
            */
            //
            {
                //EjerciciosExamen.Bandera();
            }


            {
                //EjerciciosExamen.BanderaJaponesa();
            }


            {
                // EjerciciosExamen.Sumatorio(8);
            }

            {
                //EjerciciosExamen.Ejercicio7();
            }

            {
                //( EjerciciosExamen.Ejercicio9();
            }


            List<int> intList = new List<int>();

            intList.Add(3);
            intList.Add(5);
            intList.Add(-1);
            intList.Add(0);
            intList.Add(7);
            intList.Add(-2);

            PrintList(intList);

            PrintOrderedList(intList);

        }
        public static void PrintList(List<int> intList)
        {
            for (int i = 0; i < intList.Count; i++)
                System.Console.WriteLine(intList[i]);
        }

        public static void PrintOrderedList(List<int> intList)
        {
            for (int i = 0; i < intList.Count - 1; i++)
            {
                for (int j = i + 1; j < intList.Count; j++)
                {
                    if (intList[i] > intList[j])
                    {
                        int aux = intList[j];
                        intList[j] = intList[i];
                        intList[i] = aux;
                    }
                }
                System.Console.WriteLine(intList[i]);
            }
        }
    }

}
