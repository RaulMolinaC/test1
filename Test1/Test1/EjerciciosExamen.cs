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
        public static int MayorMenorIgual(int a, int b)
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

                i = i + 3;               
            }
            System.Console.WriteLine();
        }
        
        //Hacer una función que imprima por pantalla la siguiente serie Serie(10): 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 
        public static void Serie2(int n)
        {
            {
                for (int i = 0; i < n; i++)
                    System.Console.Write(i + ",");
            }
            System.Console.WriteLine();
        }

        //Lo mismo que el anterior pero sin la coma del final
        public static void Serie3(int n)
        {
            {
                System.Console.Write(0);
                for (int i = 1; i < n; i++)
                    System.Console.Write("," + i);
            }
            System.Console.WriteLine();
        }

        //Hacer una función que se le pase un número n e 
        public static void SerieAsteríscos(int n)
        {
            {
                for (int i = 0; i < n; i++)
                    System.Console.Write("*");
            }
            System.Console.WriteLine();
        }

        //Hacer lo mismo que el anterior pero alternando * con +
        public static void SerieAsteriscoMas(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                    System.Console.Write("*");
                else
                    System.Console.Write("+");
            }
            System.Console.WriteLine();
        }

        //Hacer una fución que devuelva el menor de nueve enteros ocupando una sola línea.
        public static int EsMenor9(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            int menor1 = EsMenor3(n1, n2, n3);
            int menor2 = EsMenor3(n4, n5, n6);
            int menor3 = EsMenor3(n7, n8, n9);
            int Menor3 = EsMenor3 (menor1, menor2, menor3);
            return Menor3;
        }

        //Hacer una función a la que se le pase un entero y que imprima por pantalla filas y columnas
        public static void ColumnasFilas(int n)
        {
            for(int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        //Hacer un afunción que se le pase un número entero e imrima por pantalla el mismo número de filas y columnas pero una de "*" y otra de "+"
        public static void ColumnasFilas2(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((f % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        //Hacer una función a la que se le pase un entero y que imprima por pantalla filas y columnas
        public static void ColumnasFilas3(int n)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c <= f; c++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public static void ColumnasFilas4(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios = n - f - 1;
                int nasteriscos = f + 1;

                for (int c = 0; c < nespacios; c++)
                    System.Console.Write(" ");
                for (int c = 0; c < nasteriscos; c++)
                    System.Console.Write("+");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public static void ColumnasFilas5(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios1 = n - f - 1;
                int nespacios2 = f * 2;

                for (int c = 0; c < nespacios1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public static void ColumnasFilas6(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios1 = f;
                int nespacios2 = (n - f - 1) * 2;

                for (int c = 0; c < nespacios1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        public static void ColumnasFilas7(int n)
        {
            ColumnasFilas5(n);
            ColumnasFilas6(n);
        }

        //Hacer un afunción que devuelva 2 elevado a n, siendo n el parametro que recibe la función
        public static int Ejercicio21(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
                result *= 2;
            return result;
        }

        //Hacer una función que imprima por pantalla la bandera americana 
        public static void Bandera()
        {
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 70; c++)
                {
                    if (0 <= c && c <= 4 && 0 <= f && f <=2)
                    {
                        int flag = f + c;
                        if ((flag % 2) == 0)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");
                    }
                    else if ((f % 4) < 2)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }            
        }

    }

}
