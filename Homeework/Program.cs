using System;

namespace Homeework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 3, 4, 1, 6, };
            Console.WriteLine(Min(arr));

            
        }
        static int Min(int[] arr) 
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min= arr[i];
                }
            }
            return min;
        }
          
    }
}
