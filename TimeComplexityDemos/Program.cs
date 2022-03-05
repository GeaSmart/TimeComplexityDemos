using System;
using System.Threading;

namespace TimeComplexityDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time complexity measurement:");
            int[] arreglo1 = populateArray(1000000);
            int[] arreglo2 = populateArray(100000);
            int[] arreglo3 = populateArray(10000);
            int[] arreglo4 = populateArray(1000);
            int[] arreglo5 = populateArray(100);

            Console.WriteLine("--------- RESULTS ----------");
            LinealExecution(arreglo1);
            LinealExecution(arreglo2);
            LinealExecution(arreglo3);
            LinealExecution(arreglo4);
            LinealExecution(arreglo5);
        }               

        private static int[] populateArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            return array;
        }

        private static int LinealExecution(int[] arreglo)
        {
            DateTime start = DateTime.Now;

            var contador = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                contador++;
            }

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {arreglo.Length} iterations.");

            return contador;
        }
    }
}
