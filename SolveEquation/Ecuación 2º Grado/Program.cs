using System;
using System.Security.Cryptography.X509Certificates;

namespace Ecuación_2º_Grado
{
    class Program
    {


        
        static void Main(string[] args)
        {

            double s1;

            s1 = EquationSolvers.SolveEquation(2.0, -4.0);

            System.Console.WriteLine("s1 = " + s1);



            double s2;

            s2 = EquationSolvers.SolveEquation2(1.0, -1.0, 0.0);

            System.Console.WriteLine("s2 " + s2);

        }




    }
}
