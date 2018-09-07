using System;

namespace Cuadrado
{
    class Program
    {
        public static int Cuadrado (int n)
        {
            return n * n;
        }
        public static void Main()
        {
            int numero;
            int resultado;
            numero = 5;
            resultado = Cuadrado(numero);
            Console.WriteLine("El cuadrado del numero {0} es {1}", numero, resultado);
            Console.WriteLine("y el de 3 es {0}", Cuadrado(3));
            Console.ReadKey();


        }
    }
}
