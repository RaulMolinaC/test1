﻿namespace Test1
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {

            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }

        public static int GetMaxValue(int a, int b)
        {

            if (a > b)
                return a;
            else
                return b;

        }


        // IsEven devuelve true si el valos es par y 
        // y false en caso contrario
        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;
            else
                return false;

        }



        public static bool IsPrime(int number)
        {
            int i = 2;
            
            while (i < number)
            {
                if ((number % i) == 0)
                    return false;

                i = i + 1;

            }
            return true;

        }

    }
}
