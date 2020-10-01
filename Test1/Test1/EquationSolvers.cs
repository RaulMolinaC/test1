using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Test1
{
    class EquationSolvers
    {
        public static double SolveEquation(double a, double b)

        {
            double x;

            x = -b / a;

            return x;

        }



        public static double SolveEquation2(double a, double b, double c)

        {
            double aux1, aux2, x;

            aux1= b* b - 4.0 * a * c;

            aux2 = System.Math.Sqrt(aux1);

            x = (-b + aux2) / (2.0 * a);

            return x;

         }


    }
}
