using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Test1
{
    class EjerciciosExamen
    {
        //Hacer una función a la que se le pasen dos números enteros y que devuelva la suma de esos dos números.
        public static int Sum(int a, int b)
        {
          int result = a + b;

          return result;
        }

        //hacer una función que reciba dos reales y hacer la resta.
        public static double Rest(double a, double b)
        {
            return a - b;
        }

        //Hacer una función a la que se le pasendos enteros y devuelva el menor de ellos.
        public static int MinValue(int a, int b)
        {
            if (a < b)
                return a;

            else
                return b;                       
        }

        //Hacer una función que reciba como parametro deos enteros y devuelva si el primero es menor que el segundo.
        public static bool EsMenor(int a, int b)
        {
            if (a < b)
                return true;

            else
                return false;
        }

        public static bool EsMenorDe10(int a, int b)
        {
            return (a < b);
        }

        //Hacer una función a la que se le pasen 3 string y devuelva la concatenación de los 3 string.
        public static string Cat(string S1, string S2, string S3)
        {
            return (S1 + S2 + S3);
        }

        //Hacer una función que reciba 2 int y devuelva -1 si el priemro es menor que el 2º, +1 si el segundo es menor que el 1º, 0 en cualquier otro caso (que sean iguales)
        public static int NoSe(int a, int b)
        {
            if (a < b)
                return -1;

            if (a > b)
                return 1;

            return 0;
        }

        //Hacer una función que te devuelva el menor de tres int.
        public static int EsMenor3(int a, int b, int c)
        {
            if (a < b)
            {
                if (a < c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b < c)
                    return b;
                else
                    return c;
            }

        }
    }


}
