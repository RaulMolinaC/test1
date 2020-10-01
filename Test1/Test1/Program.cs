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




        }

                
    }

}
