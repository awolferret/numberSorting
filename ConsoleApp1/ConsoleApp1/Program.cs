using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int minValue = 0;
            int maxValue = 11;
            int bufferNumber;
            int[] array = new int [random.Next(minValue,maxValue)];

            for (int i = 1; i < array.GetLength(0)+1; i++)
            {

                for (int j = 1; j < array.Length; j++)
                {
                
                    if (array[j] < array[j - 1])
                    {
                        bufferNumber = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = bufferNumber;
                    }
                }
            Console.WriteLine(i);
            }
        }
    }
}