using System.Reflection.Metadata.Ecma335;

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


    }
}
