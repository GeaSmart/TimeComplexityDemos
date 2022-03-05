using System;
using System.Threading;

namespace TimeComplexityDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time complexity measurement:\r\n");

            TestLinear();//Preparing

            TestLinear();
            TestConstant();
            LogarithmicTest();

            Console.ReadLine();
        }

        /********************************* TESTS *********************************/
        private static void TestConstant()
        {
            Console.WriteLine("\r\n *** Constant ***");

            ConstantExecution(1000000);
            ConstantExecution(100000);
            ConstantExecution(10000);
            ConstantExecution(1000);
            ConstantExecution(100);
        }

        private static void TestLinear()
        {
            Console.WriteLine("\r\n *** Linear ***");

            int[] arreglo1 = populateArray(1000000);
            int[] arreglo2 = populateArray(100000);
            int[] arreglo3 = populateArray(10000);
            int[] arreglo4 = populateArray(1000);
            int[] arreglo5 = populateArray(100);

            LinealExecution(arreglo1);
            LinealExecution(arreglo2);
            LinealExecution(arreglo3);
            LinealExecution(arreglo4);
            LinealExecution(arreglo5);
        }

        private static void LogarithmicTest()
        {
            Console.WriteLine("\r\n *** Logarithmic ***");
            var array1 = populateArray(10000);
            var array2 = populateArray(100000);
            var array3 = populateArray(1000000);
            var array4 = populateArray(10000000);
            var array5 = populateArray(100000000);

            LogarithmicExecution(array1,8);
            LogarithmicExecution(array2,8);
            LogarithmicExecution(array3,8);
            LogarithmicExecution(array4,8);
            LogarithmicExecution(array5,8);
        }

        /********************************* EXECUTIONS *********************************/
        private static void ConstantExecution(int length)
        {
            var array = populateArray(length);
            DateTime start = DateTime.Now;

            var first = array[0];

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {length} elements.");
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

        private static int LogarithmicExecution(int[] array, int step)
        {
            DateTime start = DateTime.Now;

            var contador = 0;
            for (int i = 1; i <= array.Length; i *= step)
            {
                contador++;
            }

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {array.Length} elements.");

            return contador;
        }

        /********************************* AUXILIAR *********************************/
        private static int[] populateArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }

            return array;
        }

    }
}
