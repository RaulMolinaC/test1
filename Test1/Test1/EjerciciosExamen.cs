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

        //hacer una función que reciba un código de error he imprima por pantalla "Error grave" si el código de error es 0
        //"Error moderado"  cuando 1
        //"Error leve" cuando 2
        //"Error desconocido" cuando otro caso
        public static void PrintError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                        break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;
            }
        }

        //Hacer una función a la que se le pase un número e imprima por pantalla una serie como la siguiente serie función(10): 0, 3, 6, 9,
        public static void Serie(int a)
        {
            int i = 0;
            while (i <= a)
            {                
                System.Console.Write(i + ",");

                i = 3;               
            }
        }
        
        //Hacer una función que imprima por pantalla la siguiente serie Serie(10): 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 
        public static void Serie2(int n)
        {            
            for (int i = 0; i < n; i++)            
                System.Console.Write(i + ",");                            
        }

        //Lo mismo que el anterior pero sin la coma del final
        public static void Serie3(int n)
        {
            System.Console.Write(0);
            for (int i = 1; i < n; i++)
                System.Console.Write("," + i);

        }
    }


}
