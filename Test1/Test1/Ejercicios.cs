﻿namespace Test1
{
    class Ejercicios
    {
        // Ejercicio: hacer una función que imprima por
        // pantalla los númerosdel 0 al 99
        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
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

    }
}
