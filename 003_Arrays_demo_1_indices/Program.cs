using System;

namespace _003_Arrays_demo_1_indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 7, -1, 12 };
            //int[] arr = new int[6];

            int evenSum = 0;
            int oddProduct = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    evenSum += arr[i];
                else
                    oddProduct *= arr[i];
            }

            Console.WriteLine(evenSum);
            Console.WriteLine(oddProduct);
        }
    }
}
