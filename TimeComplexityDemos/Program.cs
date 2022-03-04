using System;
using System.Threading;

namespace TimeComplexityDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time complexity measurement:");
            var arreglo1 = new int[] { 1, 2, 3 };
            var arreglo2 = new int[] { 8, 6, 5, 4, 5, 6, 7, 8, 9, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 1, 1, 2, 3, 3, 4, 5 };

            LinealExecution(arreglo1);
            //LinealExecution(arreglo2);
        }               

        private static int LinealExecution(int[] arreglo)
        {
            DateTime start = DateTime.Now;

            var contador = 0;
            foreach(var item in arreglo)
            {
                contador++;
            }            

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}.");

            return contador;
        }
    }
}
