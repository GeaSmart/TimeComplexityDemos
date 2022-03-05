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

            TestConstant();
            TestLinear();            
            LogarithmicTest();
            ExponentialTest();

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
            var array6 = populateArray(1000000000);

            LogarithmicExecution(array1,5);
            LogarithmicExecution(array2,5);
            LogarithmicExecution(array3,5);
            LogarithmicExecution(array4,5);
            LogarithmicExecution(array5,5);
            LogarithmicExecution(array6,5);
        }

        private static void ExponentialTest()
        {
            Console.WriteLine("\r\n *** Exponential ***");
            var array1 = populateArray(500);
            var array2 = populateArray(1000);
            var array3 = populateArray(1500);
            var array4 = populateArray(2000);
            var array5 = populateArray(2500);
            var array6 = populateArray(3000);
            var array7 = populateArray(3500);
            var array8 = populateArray(4000);
            var array9 = populateArray(4500);
            var array10 = populateArray(5000);
            var array11 = populateArray(5500);
            var array12 = populateArray(6000);
            var array13 = populateArray(6500);

            ExponentialExecution(array1);
            ExponentialExecution(array2);
            ExponentialExecution(array3);
            ExponentialExecution(array4);
            ExponentialExecution(array5);
            ExponentialExecution(array6);
            ExponentialExecution(array7);
            ExponentialExecution(array8);
            ExponentialExecution(array9);
            ExponentialExecution(array10);
            ExponentialExecution(array11);
            ExponentialExecution(array12);
            ExponentialExecution(array13);
        }

        /********************************* EXECUTIONS *********************************/
        private static void ConstantExecution(int length)
        {
            var array = populateArray(length);
            DateTime start = DateTime.Now;

            var first = array[0]; //only 1 operation

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {length} elements / 1 operation");
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
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {arreglo.Length} elements / {contador} operations.");

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
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {array.Length} elements / {contador} operations.");

            return contador;
        }

        private static int ExponentialExecution(int[] array)
        {
            DateTime start = DateTime.Now;

            var contador = 0;
            for (int i = 1; i <= array.Length * array.Length; i++)
            {
                contador++;
            }

            TimeSpan elapsedTime = DateTime.Now - start;
            Console.WriteLine($"Elapsed time: {elapsedTime.TotalMilliseconds}\t -> {array.Length} elements / {contador} operations.");

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
