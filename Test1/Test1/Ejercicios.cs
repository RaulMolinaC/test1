using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Test1
{
    class Ejercicios
    {
        // Ejercicio: hacer una función que imprima por
        // pantalla los númerosdel 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 10)
            {
                System.Console.WriteLine(contador);
                // contador = contador + 1;
                // contador += 1;
                //contador++;

                contador = contador + 1;
            }

        }

        //Haz una función que imprima los 
        // números pares que hay desde el cero hasta n

        public static void Ejercicio2(int n)
        {
            int i = 0;
            while (i < n)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i = i + 1;

            }

        }


        public static void Ejercicio3(int numerico)
        {
            bool es_primo = Utils.IsPrime(numerico);
            if (es_primo)
                System.Console.WriteLine("El número " + numerico + " es primo");
            else
                System.Console.WriteLine("El número " + numerico + " no es primo");



        }


        public static void Ejercicio4()
        {
            int i = 0;
            int n = 100;
            while (i < n)
            {
                System.Console.WriteLine(i);

                i++;

            }


        }


        public static void Ejercicio5()
        {

            int i = 0;
            int n = 100;
            while (i < n)
            {

                System.Console.WriteLine(i * 3);

                i++;
                             
            }
                         
        
        
        }


        public static void Ejercicio6()
        {

            int i = 0;
            int n = 100;
            while (i < n)
            {

                System.Console.WriteLine(i * i);

                i++;

            }



        }

        public static void Ejercicio7()
        {

            int i = 0;
            int n = 100;
            while (i < n)
            {

                System.Console.WriteLine(5 - i);

                i++;

            }



        }



        public static void Ejercicio8()
        {

            int i = 0;
            int n = 100;
            while (i < n)
            {
                              
                if (Utils.IsEven(i))                     
                    System.Console.WriteLine(i);
                else                           
                    System.Console.WriteLine(-i);

                i++;

            }



        }


        public static void Ejercicio(9)
        {

            int aa = 0;
            int a = 1;

             
            int i = 0;
            int n = 100;
            while (i < n)
            {

                System.Console.WriteLine

              


            }









        }



    }
}
