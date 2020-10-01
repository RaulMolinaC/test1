
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, aux, aux2;

            a = 3.0;

            b = 7.0;

            c = -10.0;

            aux = (b * b) - (4 * a * c);

            aux2 = System.Math.Sqrt(aux);

            x1 = (-b + aux2) / (2 * a);

            System.Console.WriteLine("Solución de x1 = " + x1);




            double x2, aux3, aux4;

            aux3 = (b * b) - (4 * a * c);

            aux4 = System.Math.Sqrt(aux3);

            x2 = (-b - aux4) / (2 * a);

            System.Console.WriteLine("Solución de x2 = " + x2);




            double d, h, m, s, horas, minutos, segundos;

            d = 7.0;

            h = 24.0;
                        
            m = 60.0;
                       
            s = 60.0;


            horas = d * h;

            minutos = horas * m;

            segundos = minutos * s;


            System.Console.WriteLine("7 días son : " + horas + " horas"); 

            System.Console.WriteLine("7 días son : " + minutos + " minutos");

            System.Console.WriteLine("7 días son : " + segundos + " segundos");



             
        }
    }
}
